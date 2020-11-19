using Xunit;
using System;
using System.Collections.Generic;
using HiarcSDKIntegrationTests;

namespace HiarcSDKIntegrationTest.Tests
{
    public class ClassificationTests : HiarcTestBase
    {
        [Fact]
        public async void ClassificationCRUD()
        {
            var c1 = await _hiarc.CreateClassification();
            var fetchedClassification = await _hiarc.GetClassification(c1.Key);
            Assert.Equal(c1, fetchedClassification, new SdkEntityComparer());

            var newName = "New Name";
            var newDescription = "New description";
            var updateRequest = new HiarcSDK.Model.UpdateClassificationRequest { Name=newName, Description=newDescription };
            var updatedClassification = await _hiarc.UpdateClassification(c1.Key, updateRequest);
            Assert.Equal(newName, updatedClassification.Name);
            Assert.Equal(newDescription, updatedClassification.Description);
            Assert.True(updatedClassification.ModifiedAt > updatedClassification.CreatedAt);

            updateRequest = new HiarcSDK.Model.UpdateClassificationRequest { Key="new key", Name=newName, Description=newDescription };
            await Assert.ThrowsAnyAsync<Exception>(async () => await _hiarc.UpdateClassification(c1.Key, updateRequest));
        }

        [Fact]
        public async void GetAllClassifications()
        {
            var count = LARGE_ENTITY_COUNT;
            for(var i=0; i<count; i++)
            {
                await _hiarc.CreateClassification();
            }

            var allClassifications = await _hiarc.GetAllClassifications();
            Assert.Equal(count, allClassifications.Count);
        }

        [Fact]
        public async void CreateClassificationWithMetadata()
        {
            var md = TestMetadata;
            var c1 = await _hiarc.CreateClassification(md);
            var fetchedClassification = await _hiarc.GetClassification(c1.Key);
            
            Assert.Equal(c1, fetchedClassification, new SdkEntityComparer());
            AssertMetadataSdk(md, fetchedClassification.Metadata);
        }

        [Fact]
        public async void UpdateMetadata()
        {
            var md = TestMetadata;
            var c1 = await _hiarc.CreateClassification(md);
            
            var updatedMD = new Dictionary<string, object>
            {
                { "department", "support" },
                { "quotaCarrying", false },
                { "targetRate", 7.271 },
                { "level", 2 },
                { "startDate", DateTime.Parse("2020-02-25T22:33:50.134Z").ToUniversalTime() }
            };

            var request = new HiarcSDK.Model.UpdateClassificationRequest
            {
                Metadata = updatedMD
            };

            var updatedClassification = await _hiarc.UpdateClassification(c1.Key, request);
            AssertMetadataSdk(updatedMD, updatedClassification.Metadata);
        }

        [Fact]
        public async void NullOutMetadata()
        {
            var md = TestMetadata;
            var c1 = await _hiarc.CreateClassification(md);
            
            var updatedMD = new Dictionary<string, object>
            {
                { "department", null },
                { "quotaCarrying", null }
            };

            var request = new HiarcSDK.Model.UpdateClassificationRequest
            {
                Metadata = updatedMD
            };

            var updatedClassification = await _hiarc.UpdateClassification(c1.Key, request);
            Assert.Equal(3, updatedClassification.Metadata.Keys.Count);

            updatedMD = new Dictionary<string, object>
            {
                { "targetRate", null },
                { "level", null },
                { "startDate", null }
            };

            request = new HiarcSDK.Model.UpdateClassificationRequest
            {
                Metadata = updatedMD
            };

            updatedClassification = await _hiarc.UpdateClassification(c1.Key, request);
            Assert.Null(updatedClassification.Metadata);
        }

        [Fact]
        public async void FindClassifications()
        {
            var md = TestMetadata;
            var c1 = await _hiarc.CreateClassification(md);
            
            md["quotaCarrying"] = false;
            await _hiarc.CreateClassification(md);
            
            await _hiarc.CreateClassification();

            var query = new List<Dictionary<string, object>>
            {
                new Dictionary<string, object>
                {
                    { "prop", "department" },
                    { "op", "starts with" },
                    { "value", "sal" }
                },
                    new Dictionary<string, object>
                {
                    { "bool", "and" }
                },
                    new Dictionary<string, object>
                {
                    { "parens", "(" }
                },
                    new Dictionary<string, object>
                {
                    { "prop", "targetRate" },
                    { "op", ">=" },
                    { "value", 4.22 }
                },
                    new Dictionary<string, object>
                {
                    { "bool", "and" }
                },
                    new Dictionary<string, object>
                {
                    { "prop", "quotaCarrying" },
                    { "op", "=" },
                    { "value", true }
                },
                    new Dictionary<string, object>
                {
                    { "parens", ")" }
                }
            };

            var request = new HiarcSDK.Model.FindClassificationsRequest { Query = query };
            var foundClassifications = await _hiarc.FindClassifications(request);
            Assert.Single(foundClassifications);
            Assert.Equal(c1, foundClassifications[0], new SdkEntityComparer());
        }
    }
}