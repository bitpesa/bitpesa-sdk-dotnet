/* 
 * BitPesa API
 *
 * Reference documentation for the BitPesa API V1
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using BitPesa.Sdk.Client;
using BitPesa.Sdk.Api;
using BitPesa.Sdk.Model;

namespace BitPesa.Sdk.Test
{
    /// <summary>
    ///  Class for testing PayoutMethodsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PayoutMethodsApiTests
    {
        private PayoutMethodsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PayoutMethodsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PayoutMethodsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PayoutMethodsApi
            //Assert.IsInstanceOfType(typeof(PayoutMethodsApi), instance, "instance is a PayoutMethodsApi");
        }

        
        /// <summary>
        /// Test DeletePayoutMethod
        /// </summary>
        [Test]
        public void DeletePayoutMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? payoutMethodID = null;
            //var response = instance.DeletePayoutMethod(payoutMethodID);
            //Assert.IsInstanceOf<PayoutMethodResponse> (response, "response is PayoutMethodResponse");
        }
        
        /// <summary>
        /// Test GetPayoutMethod
        /// </summary>
        [Test]
        public void GetPayoutMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? payoutMethodID = null;
            //var response = instance.GetPayoutMethod(payoutMethodID);
            //Assert.IsInstanceOf<PayoutMethodResponse> (response, "response is PayoutMethodResponse");
        }
        
        /// <summary>
        /// Test GetPayoutMethods
        /// </summary>
        [Test]
        public void GetPayoutMethodsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> state = null;
            //List<string> type = null;
            //string senderId = null;
            //int? page = null;
            //int? per = null;
            //string createdAtFrom = null;
            //string createdAtTo = null;
            //var response = instance.GetPayoutMethods(state, type, senderId, page, per, createdAtFrom, createdAtTo);
            //Assert.IsInstanceOf<PayoutMethodListResponse> (response, "response is PayoutMethodListResponse");
        }
        
        /// <summary>
        /// Test PatchPayoutMethod
        /// </summary>
        [Test]
        public void PatchPayoutMethodTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? payoutMethodID = null;
            //PayoutMethod payoutMethod = null;
            //var response = instance.PatchPayoutMethod(payoutMethodID, payoutMethod);
            //Assert.IsInstanceOf<PayoutMethodResponse> (response, "response is PayoutMethodResponse");
        }
        
        /// <summary>
        /// Test PostPayoutMethods
        /// </summary>
        [Test]
        public void PostPayoutMethodsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PayoutMethodRequest payoutMethodRequest = null;
            //var response = instance.PostPayoutMethods(payoutMethodRequest);
            //Assert.IsInstanceOf<PayoutMethodResponse> (response, "response is PayoutMethodResponse");
        }
        
    }

}
