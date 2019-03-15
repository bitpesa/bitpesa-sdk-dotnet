﻿Imports BitPesa.Sdk.Api
Imports BitPesa.Sdk.Client
Imports BitPesa.Sdk.Model
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Module Example
    Sub AccountValidationExample(ByVal configuration As Configuration)
        Dim accountValidationRequest As AccountValidationRequest = New AccountValidationRequest(
            bankAccount:="9040099999999",
            bankCode:="190100",
            country:=AccountValidationRequest.CountryEnum.GH,
            currency:=AccountValidationRequest.CurrencyEnum.GHS,
            method:=AccountValidationRequest.MethodEnum.Bank)
        Dim accountValidationApi As AccountValidationApi = New AccountValidationApi(configuration)

        Try
            Dim result = accountValidationApi.PostAccountValidations(accountValidationRequest)
            System.Console.WriteLine(result)
        Catch e As ApiException

            If e.IsValidationError Then
                Dim result = e.ParseObject(Of AccountValidationResponse)()
                System.Console.WriteLine(result)
            Else
                Throw e
            End If
        End Try
    End Sub

    Function CreateTransactionExample(ByVal configuration As Configuration) As Guid?
        Dim api As TransactionsApi = New TransactionsApi(configuration)
        Dim sender As Sender = New Sender(id:=Guid.Parse("058de445-ffff-ffff-ffff-da9c751d14bf"))
        Dim ngnBankDetails As PayoutMethodDetails = New PayoutMethodDetails(
            bankAccount:="123456789",
            bankAccountType:=PayoutMethodBankAccountTypeEnum._20,
            bankCode:="082",
            firstName:="First",
            lastName:="Last")
        Dim payoutMethod As PayoutMethod = New PayoutMethod(type:="NGN::Bank", details:=ngnBankDetails)
        Dim recipient As Recipient = New Recipient(
            requestedAmount:=10000,
            requestedCurrency:="NGN",
            payoutMethod:=payoutMethod)
        Dim transaction As Transaction = New Transaction(
            inputCurrency:="USD",
            sender:=sender,
            recipients:=New List(Of Recipient)() From {
                recipient
            })

        Try
            Dim transactionRequest As TransactionRequest = New TransactionRequest(transaction:=transaction)
            Dim transactionResponse As TransactionResponse = api.PostTransactions(transactionRequest)
            System.Console.WriteLine("Transaction created! ID" & transactionResponse.Object.Id.ToString())
            System.Console.WriteLine(transactionResponse.Object)
            Return transactionResponse.Object.Id
        Catch e As ApiException

            If e.IsValidationError Then
                Dim transactionResponse As TransactionResponse = e.ParseObject(Of TransactionResponse)()
                System.Console.WriteLine("Validation Error" & transactionResponse.Object.Errors.ToString())
            Else
                Throw e
            End If

            Return Nothing
        End Try
    End Function

    Function CreateAndFundTransactionExample(ByVal configuration As Configuration) As Guid?
        Dim transactionId As Guid? = CreateTransactionExample(configuration)

        If transactionId Is Nothing Then
            Return Nothing
        End If

        Dim debit As Debit = New Debit(currency:="USD", toId:=transactionId, toType:="Transaction")
        Dim debitRequest As DebitRequestWrapper = New DebitRequestWrapper(debit:=New List(Of Debit)() From {
                debit
            })
        Dim debitsApi As AccountDebitsApi = New AccountDebitsApi(configuration)

        Try
            Dim debitListResponse As DebitListResponse = debitsApi.PostAccountsDebits(debitRequest)
            System.Console.WriteLine("Transaction Funded Successfully")
            System.Console.WriteLine(debitListResponse.Object(0))
        Catch e As ApiException

            If e.IsValidationError Then
                Dim debitListResponse As DebitListResponse = e.ParseObject(Of DebitListResponse)()
                System.Console.WriteLine("Transaction could not be funded")
                System.Console.WriteLine(debitListResponse.Object(0).Errors)
            Else
                Throw e
            End If
        End Try

        Return transactionId
    End Function

    Function GetTransactionFromErrorMessageExample(ByVal configuration As Configuration) As String
        Dim transationId As Guid = Guid.Parse("2cf44191-ffff-ffff-ffff-f0d133a709f1")
        Dim transactionsApi As TransactionsApi = New TransactionsApi(configuration)
        Dim response As TransactionResponse = transactionsApi.GetTransaction(transactionID:=transationId)
        System.Console.WriteLine("Payout error message on recipient: " & response.Object.Recipients(0).StateReason)
        Return response.Object.Recipients(0).StateReason
    End Function

    Sub ParseWebhookExample(ByVal configuration As Configuration)
        Dim webhookContent As String = "{  ""webhook"": ""02b769ff-ffff-ffff-ffff-820d285d76c7"",  ""event"": ""transaction.created"",  ""object"": {    ""id"": ""9170b966-ffff-ffff-ffff-7af5ad7e335f"",    ""metadata"": {},    ""state"": ""approved"",    ""input_amount"": 50.00,    ""input_currency"": ""EUR"",    ""sender"": {      ""id"": ""4be2a144-ffff-ffff-ffff-8ebcbfbbbe0c"",      ""type"": ""person"",      ""state"": ""initial"",      ""state_reason"": null,      ""country"": ""GB"",      ""street"": ""Test"",      ""postal_code"": ""EH1 1TT"",      ""city"": ""London"",      ""phone_country"": ""GB"",      ""phone_number"": ""+447123456789"",      ""email"": ""test@example.com"",      ""ip"": ""127.0.0.1"",      ""first_name"": ""Test"",      ""last_name"": ""Name"",      ""birth_date"": ""1990-01-01"",      ""metadata"": {},      ""providers"": {}    },    ""payin_methods"": [],    ""paid_amount"": 50.00,    ""due_amount"": 0,    ""recipients"": [      {        ""id"": ""69dee5aa-ffff-ffff-ffff-0a2c06353c6b"",        ""transaction_id"": ""9170b966-ffff-ffff-ffff-7af5ad7e335f"",        ""created_at"": ""2017-07-24T15:08:58Z"",        ""input_usd_amount"": 60.00,        ""state"": ""initial"",        ""transaction_state"": ""initial"",        ""requested_amount"": 50.00,        ""requested_currency"": ""EUR"",        ""input_amount"": 50.00,        ""input_currency"": ""EUR"",        ""output_amount"": 20001,        ""output_currency"": ""NGN"",        ""payout_method"": {          ""id"": ""c67580ee-ffff-ffff-ffff-ac51f1d0c035"",          ""type"": ""NGN::Bank"",          ""details"": {            ""email"": """",            ""bank_code"": ""011"",            ""last_name"": ""Test"",            ""first_name"": ""User"",            ""bank_account"": ""1111111111"",            ""bank_account_type"": ""10""          },          ""metadata"": {},          ""provider"": ""interswitch"",          ""fields"": {            ""email"": {              ""type"": ""input"",              ""validations"": {                ""format"": ""\\A((\\w+([\\-+.]\\w+)*@[a-zA-Z0-9]+([\\-\\.][a-zA-Z0-9]+)*)*){3,320}\\z""              }            },            ""first_name"": {              ""type"": ""input"",              ""validations"": {                ""presence"": true              }            },            ""last_name"": {              ""type"": ""input"",              ""validations"": {                ""presence"": true              }            },            ""bank_code"": {              ""type"": ""select"",              ""options"": {                ""063"": ""Diamond Bank"",                ""050"": ""EcoBank"",                ""214"": ""FCMB Bank"",                ""070"": ""Fidelity Bank"",                ""011"": ""First Bank of Nigeria"",                ""058"": ""Guaranty Trust Bank "",                ""030"": ""Heritage Bank"",                ""301"": ""Jaiz Bank"",                ""082"": ""Keystone "",                ""014"": ""Mainstreet "",                ""076"": ""Skye Bank"",                ""039"": ""Stanbic IBTC Bank "",                ""232"": ""Sterling bank"",                ""032"": ""Union Bank"",                ""033"": ""United Bank for Africa "",                ""215"": ""Unity Bank"",                ""035"": ""Wema Bank"",                ""057"": ""Zenith International ""              },              ""validations"": {                ""presence"": true,                ""inclusion"": {                  ""in"": {                    ""063"": ""Diamond Bank"",                    ""050"": ""EcoBank"",                    ""214"": ""FCMB Bank"",                    ""070"": ""Fidelity Bank"",                    ""011"": ""First Bank of Nigeria"",                    ""058"": ""Guaranty Trust Bank "",                    ""030"": ""Heritage Bank"",                    ""301"": ""Jaiz Bank"",                    ""082"": ""Keystone "",                    ""014"": ""Mainstreet "",                    ""076"": ""Skye Bank"",                    ""039"": ""Stanbic IBTC Bank "",                    ""232"": ""Sterling bank"",                    ""032"": ""Union Bank"",                    ""033"": ""United Bank for Africa "",                    ""215"": ""Unity Bank"",                    ""035"": ""Wema Bank"",                    ""057"": ""Zenith International ""                  }                }              }            },            ""bank_account"": {              ""type"": ""input"",              ""validations"": {                ""presence"": true              }            },            ""bank_account_type"": {              ""type"": ""select"",              ""options"": {                ""20"": ""Current"",                ""10"": ""Savings""              },              ""validations"": {                ""presence"": true,                ""inclusion"": {                  ""in"": {                    ""20"": ""Current"",                    ""10"": ""Savings""                  }                }              }            }          }        },        ""metadata"": {}      }    ],    ""created_at"": ""2017-07-24T15:08:58Z"",    ""expires_at"": ""2017-07-24T16:08:58Z""  }}"
        Dim webhook As Webhook = configuration.ParseString(Of Webhook)(webhookContent)

        If webhook.[Event].StartsWith("transaction") Then
            Dim transactionWebhook As TransactionWebhook = configuration.ParseString(Of TransactionWebhook)(webhookContent)
            System.Console.WriteLine(transactionWebhook)
        ElseIf webhook.[Event].StartsWith("recipient") Then
            Dim recipientWebhook As RecipientWebhook = configuration.ParseString(Of RecipientWebhook)(webhookContent)
            System.Console.WriteLine(recipientWebhook)
        ElseIf webhook.[Event].StartsWith("sender") Then
            Dim senderWebhook As SenderWebhook = configuration.ParseString(Of SenderWebhook)(webhookContent)
            System.Console.WriteLine(senderWebhook)
        ElseIf webhook.[Event].StartsWith("document") Then
            Dim documentWebhook As DocumentWebhook = configuration.ParseString(Of DocumentWebhook)(webhookContent)
            System.Console.WriteLine(documentWebhook)
        ElseIf webhook.[Event].StartsWith("payout_method") Then
            Dim payoutMethodWebhook As PayoutMethodWebhook = configuration.ParseString(Of PayoutMethodWebhook)(webhookContent)
            System.Console.WriteLine(payoutMethodWebhook)
        End If
    End Sub

    Function CreateSenderExample(ByVal configuration As Configuration) As Guid?
        Dim sendersApi As SendersApi = New SendersApi(configuration)
        Dim sender As Sender = New Sender(
            country:="UG",
            phoneCountry:="UG",
            phoneNumber:="752403639",
            email:="example@example.com",
            firstName:="test",
            lastName:="user",
            city:="Lagos",
            street:="Unknown 123",
            postalCode:="798983",
            birthDate:=DateTime.Parse("1980-01-01"),
            ip:="127.0.0.1",
            addressDescription:="Description",
            documents:=New List(Of Document)())
        Dim senderRequest As SenderRequest = New SenderRequest(sender:=sender)

        Try
            Dim response As SenderResponse = sendersApi.PostSenders(senderRequest)
            System.Console.WriteLine(response)
            Return response.Object.Id
        Catch e As ApiException

            If e.IsValidationError Then
                Dim response As SenderResponse = e.ParseObject(Of SenderResponse)()
                System.Console.WriteLine("Validation Error when trying to create sender!")
                System.Console.WriteLine(response)
                System.Console.WriteLine(response.Object.Errors)
                Return Nothing
            Else
                Throw e
            End If
        End Try
    End Function

    Sub UpdateSenderExample(ByVal configuration As Configuration)
        Dim sendersApi As SendersApi = New SendersApi(configuration)
        Dim sender As Sender = New Sender()
        sender.City = "London"
        Dim senderRequest As SenderRequest = New SenderRequest(sender:=sender)

        Try
            Dim response As SenderResponse = sendersApi.PatchSender(Guid.Parse("73f382d0-ffff-ffff-ffff-e78d1a133b8a"), senderRequest)
            System.Console.WriteLine(response)
        Catch e As ApiException

            If e.IsValidationError Then
                Dim response As SenderResponse = e.ParseObject(Of SenderResponse)()
                System.Console.WriteLine("Validation Error when trying to update sender!")
                System.Console.WriteLine(response)
                System.Console.WriteLine(response.Object.Errors)
            Else
                Throw e
            End If
        End Try
    End Sub

    Sub Main(ByVal args As String())
        Dim configuration As Configuration = New Configuration()
        configuration.ApiKey = "KEY"
        configuration.ApiSecret = "SECRET"
        configuration.BasePath = "https://api-sandbox.bitpesa.co/v1"

        REM AccountValidationExample(configuration)
        REM CreateSenderExample(configuration)
        REM UpdateSenderExample(configuration)
        REM CreateTransactionExample(configuration)
        REM CreateAndFundTransactionExample(configuration)
        REM GetTransactionFromErrorMessageExample(configuration)
        REM ParseWebhookExample(configuration)
        System.Console.ReadLine()
    End Sub
End Module
