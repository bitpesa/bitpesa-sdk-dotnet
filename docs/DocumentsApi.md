# TransferZero.Sdk.Api.DocumentsApi

All URIs are relative to *https://api-sandbox.transferzero.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDocument**](DocumentsApi.md#getdocument) | **GET** /documents/{Document ID} | Fetching a document
[**GetDocuments**](DocumentsApi.md#getdocuments) | **GET** /documents | Getting a list of documents
[**PostDocuments**](DocumentsApi.md#postdocuments) | **POST** /documents | Creating a document


<a name="getdocument"></a>
# **GetDocument**
> DocumentResponse GetDocument (Guid? documentID)

Fetching a document

Returns a single document by the Documents ID

### Example

#### C#

```csharp
using System;
using System.Diagnostics;
using TransferZero.Sdk.Api;
using TransferZero.Sdk.Client;
using TransferZero.Sdk.Model;

namespace Example
{
    public class GetDocumentExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new DocumentsApi(configuration);
            var documentID = new Guid?(); // Guid? | ID of the document to get.  Example: `/v1/documents/bf9ff782-e182-45ac-abea-5bce83ad6670`

            try {
                // Fetching a document
                DocumentResponse result = apiInstance.GetDocument(documentID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    DocumentResponse result = e.ParseObject<DocumentResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling DocumentsApi.GetDocument: " + e.Message );
                }
            }
        }
    }
}
```

#### VB.NET

```vbnet
Imports TransferZero.Sdk.Api;
Imports TransferZero.Sdk.Client;
Imports TransferZero.Sdk.Model;
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Module Example
    Sub Main(ByVal args As String())
        Dim configuration As Configuration = New Configuration()
        configuration.ApiKey = "KEY"
        configuration.ApiSecret = "SECRET"
        configuration.BasePath = "https://api-sandbox.transferzero.com/v1"

        Dim debitsApi As AccountDebitsApi = New AccountDebitsApi(configuration)

        Dim apiInstance = new DocumentsApi(configuration)
        Dim documentID = new Guid?() REM Guid? | ID of the document to get.  Example: `/v1/documents/bf9ff782-e182-45ac-abea-5bce83ad6670`


        Try
            REM Fetching a document
            Dim result As DocumentResponse = apiInstance.GetDocument(documentID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as DocumentResponse = e.ParseObject(Of DocumentResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling DocumentsApi.GetDocument: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentID** | [**Guid?**](Guid?.md)| ID of the document to get.  Example: &#x60;/v1/documents/bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | 

### Return type

[**DocumentResponse**](DocumentResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdocuments"></a>
# **GetDocuments**
> DocumentListResponse GetDocuments (int? page = null, int? per = null)

Getting a list of documents

Fetches a list of documents.

### Example

#### C#

```csharp
using System;
using System.Diagnostics;
using TransferZero.Sdk.Api;
using TransferZero.Sdk.Client;
using TransferZero.Sdk.Model;

namespace Example
{
    public class GetDocumentsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new DocumentsApi(configuration);
            var page = 1;  // int? | The page number to request (defaults to 1) (optional) 
            var per = 10;  // int? | The number of results to load per page (defaults to 10) (optional) 

            try {
                // Getting a list of documents
                DocumentListResponse result = apiInstance.GetDocuments(page, per);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    DocumentListResponse result = e.ParseObject<DocumentListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling DocumentsApi.GetDocuments: " + e.Message );
                }
            }
        }
    }
}
```

#### VB.NET

```vbnet
Imports TransferZero.Sdk.Api;
Imports TransferZero.Sdk.Client;
Imports TransferZero.Sdk.Model;
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Module Example
    Sub Main(ByVal args As String())
        Dim configuration As Configuration = New Configuration()
        configuration.ApiKey = "KEY"
        configuration.ApiSecret = "SECRET"
        configuration.BasePath = "https://api-sandbox.transferzero.com/v1"

        Dim debitsApi As AccountDebitsApi = New AccountDebitsApi(configuration)

        Dim apiInstance = new DocumentsApi(configuration)
        Dim page = 1 REM int? | The page number to request (defaults to 1) (optional) 
        Dim per = 10 REM int? | The number of results to load per page (defaults to 10) (optional) 


        Try
            REM Getting a list of documents
            Dim result As DocumentListResponse = apiInstance.GetDocuments(page, per)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as DocumentListResponse = e.ParseObject(Of DocumentListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling DocumentsApi.GetDocuments: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The page number to request (defaults to 1) | [optional] 
 **per** | **int?**| The number of results to load per page (defaults to 10) | [optional] 

### Return type

[**DocumentListResponse**](DocumentListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postdocuments"></a>
# **PostDocuments**
> DocumentResponse PostDocuments (DocumentRequest documentRequest)

Creating a document

Creates a new document

### Example

#### C#

```csharp
using System;
using System.Diagnostics;
using TransferZero.Sdk.Api;
using TransferZero.Sdk.Client;
using TransferZero.Sdk.Model;

namespace Example
{
    public class PostDocumentsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new DocumentsApi(configuration);
            var documentRequest = new DocumentRequest(); // DocumentRequest | 

            try {
                // Creating a document
                DocumentResponse result = apiInstance.PostDocuments(documentRequest);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    DocumentResponse result = e.ParseObject<DocumentResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling DocumentsApi.PostDocuments: " + e.Message );
                }
            }
        }
    }
}
```

#### VB.NET

```vbnet
Imports TransferZero.Sdk.Api;
Imports TransferZero.Sdk.Client;
Imports TransferZero.Sdk.Model;
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Module Example
    Sub Main(ByVal args As String())
        Dim configuration As Configuration = New Configuration()
        configuration.ApiKey = "KEY"
        configuration.ApiSecret = "SECRET"
        configuration.BasePath = "https://api-sandbox.transferzero.com/v1"

        Dim debitsApi As AccountDebitsApi = New AccountDebitsApi(configuration)

        Dim apiInstance = new DocumentsApi(configuration)
        Dim documentRequest = new DocumentRequest() REM DocumentRequest | 


        Try
            REM Creating a document
            Dim result As DocumentResponse = apiInstance.PostDocuments(documentRequest)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as DocumentResponse = e.ParseObject(Of DocumentResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling DocumentsApi.PostDocuments: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentRequest** | [**DocumentRequest**](DocumentRequest.md)|  | 

### Return type

[**DocumentResponse**](DocumentResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

