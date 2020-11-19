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
    ///  Class for testing GroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GroupsApiTests : IDisposable
    {
        private GroupsApi instance;

        public GroupsApiTests()
        {
            instance = new GroupsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GroupsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GroupsApi
            //Assert.IsType(typeof(GroupsApi), instance, "instance is a GroupsApi");
        }

        
        /// <summary>
        /// Test GetGroupsForUser
        /// </summary>
        [Fact]
        public void GetGroupsForUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string xHiarcUserKey = null;
            //var response = instance.GetGroupsForUser(key, xHiarcUserKey);
            //Assert.IsType<List<Group>> (response, "response is List<Group>");
        }
        
    }

}