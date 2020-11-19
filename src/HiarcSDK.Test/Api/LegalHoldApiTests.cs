/* 
 * Hiarc API
 *
 * Welcome to the Hiarc API documentation.
 *
 * The version of the OpenAPI document: 0.1.0
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
using Xunit;

using HiarcSDK.Client;
using HiarcSDK.Api;
using HiarcSDK.Model;

namespace HiarcSDK.Test
{
    /// <summary>
    ///  Class for testing LegalHoldApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LegalHoldApiTests : IDisposable
    {
        private LegalHoldApi instance;

        public LegalHoldApiTests()
        {
            instance = new LegalHoldApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LegalHoldApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LegalHoldApi
            //Assert.IsType(typeof(LegalHoldApi), instance, "instance is a LegalHoldApi");
        }

        
        /// <summary>
        /// Test CreateLegalHold
        /// </summary>
        [Fact]
        public void CreateLegalHoldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateLegalHoldRequest createLegalHoldRequest = null;
            //var response = instance.CreateLegalHold(createLegalHoldRequest);
            //Assert.IsType<LegalHold> (response, "response is LegalHold");
        }
        
        /// <summary>
        /// Test GetLegalHold
        /// </summary>
        [Fact]
        public void GetLegalHoldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //var response = instance.GetLegalHold(key);
            //Assert.IsType<LegalHold> (response, "response is LegalHold");
        }
        
    }

}
