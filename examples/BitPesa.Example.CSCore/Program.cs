using BitPesa.Sdk.Api;
using BitPesa.Sdk.Client;
using BitPesa.Sdk.Model;
using System;
using System.Collections.Generic;

namespace BitPesa.Example.CSCore
{
    class Program
    {
        static void AccountValidationExample(Configuration configuration)
        {

            AccountValidationRequest accountValidationRequest = new AccountValidationRequest(
                bankAccount: "90400999999999",
                bankCode: "190100",
                country: AccountValidationRequest.CountryEnum.GH,
                currency: AccountValidationRequest.CurrencyEnum.GHS,
                method: AccountValidationRequest.MethodEnum.Bank
            );

            AccountValidationApi accountValidationApi = new AccountValidationApi(configuration);

            try
            {
                var result = accountValidationApi.PostAccountValidations(accountValidationRequest);
                System.Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                if (e.IsValidationError)
                {
                    var result = e.ParseObject<AccountValidationResponse>();
                    System.Console.WriteLine(result);
                }
                else
                {
                    throw e;
                }

            }
        }

        static Guid? CreateTransactionExample(Configuration configuration)
        {
            TransactionsApi api = new TransactionsApi(configuration);

            Sender sender = new Sender(id: Guid.Parse("058de445-ffff-ffff-ffff-da9c751d14bf"));

            PayoutMethodDetails ngnBankDetails = new PayoutMethodDetails(
                    bankAccount: "123456789",
                    bankAccountType: PayoutMethodBankAccountTypeEnum._20,
                    bankCode: "082",
                    firstName: "First",
                    lastName: "Last"
                );

            PayoutMethod payoutMethod = new PayoutMethod(
                    type: "NGN::Bank",
                    details: ngnBankDetails
                );

            Recipient recipient = new Recipient(
                    requestedAmount: 10000,
                    requestedCurrency: "NGN",
                    payoutMethod: payoutMethod
                );

            Transaction transaction = new Transaction(
                inputCurrency: "USD",
                sender: sender,
                recipients: new List<Recipient>() { recipient }
            );

            try
            {
                TransactionRequest transactionRequest = new TransactionRequest(
                    transaction: transaction
                );
                TransactionResponse transactionResponse = api.PostTransactions(transactionRequest);
                System.Console.WriteLine("Transaction created! ID" + transactionResponse.Object.Id);
                System.Console.WriteLine(transactionResponse.Object);
                return transactionResponse.Object.Id;
            }
            catch (ApiException e)
            {
                if (e.IsValidationError)
                {
                    TransactionResponse transactionResponse = e.ParseObject<TransactionResponse>();
                    System.Console.WriteLine("Validation Error" + transactionResponse.Object.Errors);
                }
                else
                {
                    throw e;
                }
                return null;
            }
        }

        static Guid? CreateAndFundTransactionExample(Configuration configuration)
        {
            Guid? transactionId = CreateTransactionExample(configuration);
            if (transactionId == null)
            {
                return null;
            }
            Debit debit = new Debit(
                    currency: "USD",
                    toId: transactionId,
                    toType: "Transaction"
                );

            DebitRequestWrapper debitRequest = new DebitRequestWrapper(
                    debit: new List<Debit>() { debit }
                );

            AccountDebitsApi debitsApi = new AccountDebitsApi(configuration);
            try
            {
                DebitListResponse debitListResponse = debitsApi.PostAccountsDebits(debitRequest);
                System.Console.WriteLine("Transaction Funded Successfully");
                System.Console.WriteLine(debitListResponse.Object[0]);
            }
            catch (ApiException e)
            {
                if (e.IsValidationError)
                {
                    DebitListResponse debitListResponse = e.ParseObject<DebitListResponse>();
                    System.Console.WriteLine("Transaction could not be funded");
                    System.Console.WriteLine(debitListResponse.Object[0].Errors);
                }
                else
                {
                    throw e;
                }

            }
            return transactionId;
        }

        static string GetTransactionFromErrorMessageExample(Configuration configuration)
        {
            Guid transationId = Guid.Parse("2cf44191-ffff-ffff-ffff-f0d133a709f1");

            TransactionsApi transactionsApi = new TransactionsApi(configuration);

            TransactionResponse response = transactionsApi.GetTransaction(transactionID: transationId);
            System.Console.WriteLine("Payout error message on recipient: " + response.Object.Recipients[0].StateReason);

            return response.Object.Recipients[0].StateReason;
        }

        static void ParseWebhookExample(Configuration configuration)
        {
            string webhookContent = "{\n" +
                "  \"webhook\": \"02b769ff-ffff-ffff-ffff-820d285d76c7\",\n" +
                "  \"event\": \"transaction.created\",\n" +
                "  \"object\": {\n" +
                "    \"id\": \"9170b966-ffff-ffff-ffff-7af5ad7e335f\",\n" +
                "    \"metadata\": {},\n" +
                "    \"state\": \"approved\",\n" +
                "    \"input_amount\": 50.00,\n" +
                "    \"input_currency\": \"EUR\",\n" +
                "    \"sender\": {\n" +
                "      \"id\": \"4be2a144-ffff-ffff-ffff-8ebcbfbbbe0c\",\n" +
                "      \"type\": \"person\",\n" +
                "      \"state\": \"initial\",\n" +
                "      \"state_reason\": null,\n" +
                "      \"country\": \"GB\",\n" +
                "      \"street\": \"Test\",\n" +
                "      \"postal_code\": \"EH1 1TT\",\n" +
                "      \"city\": \"London\",\n" +
                "      \"phone_country\": \"GB\",\n" +
                "      \"phone_number\": \"+447123456789\",\n" +
                "      \"email\": \"test@example.com\",\n" +
                "      \"ip\": \"127.0.0.1\",\n" +
                "      \"first_name\": \"Test\",\n" +
                "      \"last_name\": \"Name\",\n" +
                "      \"birth_date\": \"1990-01-01\",\n" +
                "      \"metadata\": {},\n" +
                "      \"providers\": {}\n" +
                "    },\n" +
                "    \"payin_methods\": [],\n" +
                "    \"paid_amount\": 50.00,\n" +
                "    \"due_amount\": 0,\n" +
                "    \"recipients\": [\n" +
                "      {\n" +
                "        \"id\": \"69dee5aa-ffff-ffff-ffff-0a2c06353c6b\",\n" +
                "        \"transaction_id\": \"9170b966-ffff-ffff-ffff-7af5ad7e335f\",\n" +
                "        \"created_at\": \"2017-07-24T15:08:58Z\",\n" +
                "        \"input_usd_amount\": 60.00,\n" +
                "        \"state\": \"initial\",\n" +
                "        \"transaction_state\": \"initial\",\n" +
                "        \"requested_amount\": 50.00,\n" +
                "        \"requested_currency\": \"EUR\",\n" +
                "        \"input_amount\": 50.00,\n" +
                "        \"input_currency\": \"EUR\",\n" +
                "        \"output_amount\": 20001,\n" +
                "        \"output_currency\": \"NGN\",\n" +
                "        \"payout_method\": {\n" +
                "          \"id\": \"c67580ee-ffff-ffff-ffff-ac51f1d0c035\",\n" +
                "          \"type\": \"NGN::Bank\",\n" +
                "          \"details\": {\n" +
                "            \"email\": \"\",\n" +
                "            \"bank_code\": \"011\",\n" +
                "            \"last_name\": \"Test\",\n" +
                "            \"first_name\": \"User\",\n" +
                "            \"bank_account\": \"1111111111\",\n" +
                "            \"bank_account_type\": \"10\"\n" +
                "          },\n" +
                "          \"metadata\": {},\n" +
                "          \"provider\": \"interswitch\",\n" +
                "          \"fields\": {\n" +
                "            \"email\": {\n" +
                "              \"type\": \"input\",\n" +
                "              \"validations\": {\n" +
                "                \"format\": \"\\\\A((\\\\w+([\\\\-+.]\\\\w+)*@[a-zA-Z0-9]+([\\\\-\\\\.][a-zA-Z0-9]+)*)*){3,320}\\\\z\"\n" +
                "              }\n" +
                "            },\n" +
                "            \"first_name\": {\n" +
                "              \"type\": \"input\",\n" +
                "              \"validations\": {\n" +
                "                \"presence\": true\n" +
                "              }\n" +
                "            },\n" +
                "            \"last_name\": {\n" +
                "              \"type\": \"input\",\n" +
                "              \"validations\": {\n" +
                "                \"presence\": true\n" +
                "              }\n" +
                "            },\n" +
                "            \"bank_code\": {\n" +
                "              \"type\": \"select\",\n" +
                "              \"options\": {\n" +
                "                \"063\": \"Diamond Bank\",\n" +
                "                \"050\": \"EcoBank\",\n" +
                "                \"214\": \"FCMB Bank\",\n" +
                "                \"070\": \"Fidelity Bank\",\n" +
                "                \"011\": \"First Bank of Nigeria\",\n" +
                "                \"058\": \"Guaranty Trust Bank \",\n" +
                "                \"030\": \"Heritage Bank\",\n" +
                "                \"301\": \"Jaiz Bank\",\n" +
                "                \"082\": \"Keystone \",\n" +
                "                \"014\": \"Mainstreet \",\n" +
                "                \"076\": \"Skye Bank\",\n" +
                "                \"039\": \"Stanbic IBTC Bank \",\n" +
                "                \"232\": \"Sterling bank\",\n" +
                "                \"032\": \"Union Bank\",\n" +
                "                \"033\": \"United Bank for Africa \",\n" +
                "                \"215\": \"Unity Bank\",\n" +
                "                \"035\": \"Wema Bank\",\n" +
                "                \"057\": \"Zenith International \"\n" +
                "              },\n" +
                "              \"validations\": {\n" +
                "                \"presence\": true,\n" +
                "                \"inclusion\": {\n" +
                "                  \"in\": {\n" +
                "                    \"063\": \"Diamond Bank\",\n" +
                "                    \"050\": \"EcoBank\",\n" +
                "                    \"214\": \"FCMB Bank\",\n" +
                "                    \"070\": \"Fidelity Bank\",\n" +
                "                    \"011\": \"First Bank of Nigeria\",\n" +
                "                    \"058\": \"Guaranty Trust Bank \",\n" +
                "                    \"030\": \"Heritage Bank\",\n" +
                "                    \"301\": \"Jaiz Bank\",\n" +
                "                    \"082\": \"Keystone \",\n" +
                "                    \"014\": \"Mainstreet \",\n" +
                "                    \"076\": \"Skye Bank\",\n" +
                "                    \"039\": \"Stanbic IBTC Bank \",\n" +
                "                    \"232\": \"Sterling bank\",\n" +
                "                    \"032\": \"Union Bank\",\n" +
                "                    \"033\": \"United Bank for Africa \",\n" +
                "                    \"215\": \"Unity Bank\",\n" +
                "                    \"035\": \"Wema Bank\",\n" +
                "                    \"057\": \"Zenith International \"\n" +
                "                  }\n" +
                "                }\n" +
                "              }\n" +
                "            },\n" +
                "            \"bank_account\": {\n" +
                "              \"type\": \"input\",\n" +
                "              \"validations\": {\n" +
                "                \"presence\": true\n" +
                "              }\n" +
                "            },\n" +
                "            \"bank_account_type\": {\n" +
                "              \"type\": \"select\",\n" +
                "              \"options\": {\n" +
                "                \"20\": \"Current\",\n" +
                "                \"10\": \"Savings\"\n" +
                "              },\n" +
                "              \"validations\": {\n" +
                "                \"presence\": true,\n" +
                "                \"inclusion\": {\n" +
                "                  \"in\": {\n" +
                "                    \"20\": \"Current\",\n" +
                "                    \"10\": \"Savings\"\n" +
                "                  }\n" +
                "                }\n" +
                "              }\n" +
                "            }\n" +
                "          }\n" +
                "        },\n" +
                "        \"metadata\": {}\n" +
                "      }\n" +
                "    ],\n" +
                "    \"created_at\": \"2017-07-24T15:08:58Z\",\n" +
                "    \"expires_at\": \"2017-07-24T16:08:58Z\"\n" +
                "  }\n" +
                "}";

            Webhook webhook = configuration.ParseString<Webhook>(webhookContent);

            if (webhook.Event.StartsWith("transaction"))
            {
                TransactionWebhook transactionWebhook = configuration.ParseString<TransactionWebhook>(webhookContent);
                System.Console.WriteLine(transactionWebhook);
            }
            else if (webhook.Event.StartsWith("recipient"))
            {
                RecipientWebhook recipientWebhook = configuration.ParseString<RecipientWebhook>(webhookContent);
                System.Console.WriteLine(recipientWebhook);
            }
            else if (webhook.Event.StartsWith("sender"))
            {
                SenderWebhook senderWebhook = configuration.ParseString<SenderWebhook>(webhookContent);
                System.Console.WriteLine(senderWebhook);
            }
            else if (webhook.Event.StartsWith("document"))
            {
                DocumentWebhook documentWebhook = configuration.ParseString<DocumentWebhook>(webhookContent);
                System.Console.WriteLine(documentWebhook);
            }
            else if (webhook.Event.StartsWith("payout_method"))
            {
                PayoutMethodWebhook payoutMethodWebhook = configuration.ParseString<PayoutMethodWebhook>(webhookContent);
                System.Console.WriteLine(payoutMethodWebhook);
            }
        }

        static Guid? CreateSenderExample(Configuration configuration)
        {
            SendersApi sendersApi = new SendersApi(configuration);
            Sender sender = new Sender(
                    country: "UG",
                    phoneCountry: "UG",
                    phoneNumber: "752403639",
                    email: "example@example.com",
                    firstName: "test",
                    lastName: "user",
                    city: "Lagos",
                    street: "Unknown 123",
                    postalCode: "798983",
                    birthDate: DateTime.Parse("1980-01-01"),
                    ip: "127.0.0.1",
                    addressDescription: "Description",
                    documents: new List<Document>()
                );

            SenderRequest senderRequest = new SenderRequest(
                    sender: sender
                );

            try
            {
                SenderResponse response = sendersApi.PostSenders(senderRequest);
                System.Console.WriteLine(response);
                return response.Object.Id;
            }
            catch (ApiException e)
            {
                if (e.IsValidationError)
                {
                    SenderResponse response = e.ParseObject<SenderResponse>();
                    System.Console.WriteLine("Validation Error when trying to create sender!");
                    System.Console.WriteLine(response);
                    System.Console.WriteLine(response.Object.Errors);
                    return null;
                }
                else
                {
                    throw e;
                }
            }
        }

        static void UpdateSenderExample(Configuration configuration)
        {
            SendersApi sendersApi = new SendersApi(configuration);

            Sender sender = new Sender();
            sender.City = "London";

            SenderRequest senderRequest = new SenderRequest(sender: sender);

            try
            {
                SenderResponse response = sendersApi.PatchSender(Guid.Parse("73f382d0-ffff-ffff-ffff-e78d1a133b8a"), senderRequest);
                System.Console.WriteLine(response);
            }
            catch (ApiException e)
            {
                if (e.IsValidationError)
                {
                    SenderResponse response = e.ParseObject<SenderResponse>();
                    System.Console.WriteLine("Validation Error when trying to update sender!");
                    System.Console.WriteLine(response);
                    System.Console.WriteLine(response.Object.Errors);
                }
                else
                {
                    throw e;
                }
            }
        }

        static void Main(string[] args)
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "KEY";
            configuration.ApiSecret = "SECRET";
            configuration.BasePath = "https://api-sandbox.bitpesa.co/v1";

            //AccountValidationExample(configuration);
            //CreateSenderExample(configuration);
            //UpdateSenderExample(configuration);
            //CreateTransactionExample(configuration);
            //CreateAndFundTransactionExample(configuration);
            //GetTransactionFromErrorMessageExample(configuration);
            //ParseWebhookExample(configuration);
            System.Console.ReadLine();
        }
    }
}
