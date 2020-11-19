using Xunit;
using System;
using System.Collections.Generic;
using HiarcSDKIntegrationTests;

namespace HiarcSDKIntegrationTest.Tests
{
    public class UserTests : HiarcTestBase
    {
        [Fact]
        public async void UserCRUD()
        {
            var u1 = await _hiarc.CreateUser();
            var fetchedUser = await _hiarc.GetUser(u1.Key);
            Assert.Equal(u1, fetchedUser, new SdkEntityComparer());

            var newName = "New Name";
            var newDescription = "New description";
            var updateRequest = new HiarcSDK.Model.UpdateUserRequest { Name=newName, Description=newDescription };
            var updatedUser = await _hiarc.UpdateUser(u1.Key, updateRequest);
            Assert.Equal(newName, updatedUser.Name);
            Assert.Equal(newDescription, updatedUser.Description);
            Assert.True(updatedUser.ModifiedAt > updatedUser.CreatedAt);

            updateRequest = new HiarcSDK.Model.UpdateUserRequest { Key="new key", Name=newName, Description=newDescription };
            await Assert.ThrowsAnyAsync<Exception>(async () => await _hiarc.UpdateUser(u1.Key, updateRequest));

            await _hiarc.DeleteUser(u1.Key);
            await Assert.ThrowsAnyAsync<Exception>(async () => await _hiarc.GetUser(u1.Key));
        }

        [Fact]
        public async void GetAllUsers()
        {
            var count = LARGE_ENTITY_COUNT;
            for(var i=0; i<count; i++)
            {
                await _hiarc.CreateUser();
            }

            var allUsers = await _hiarc.GetAllUsers();
            Assert.Equal(count, allUsers.Count);
        }

        [Fact]
        public async void GetCurrentUser()
        {
            var u1 = await _hiarc.CreateUser();
            var fetchedUser = await _hiarc.GetCurrentUser(asUserKey: u1.Key);
            Assert.Equal(u1.Key, fetchedUser.Key);

            var userCredentials = await _hiarc.CreateUserCredentials(u1.Key);
            fetchedUser = await _hiarc.GetCurrentUser(u1.Key, bearerToken: userCredentials.BearerToken);
            Assert.Equal(u1, fetchedUser, new SdkEntityComparer());
        }

        [Fact]
        public async void GetGroupsForUser()
        {
            var u1 = await _hiarc.CreateUser();
            var g1 = await _hiarc.CreateGroup();
            var g2 = await _hiarc.CreateGroup();
            var g3 = await _hiarc.CreateGroup();

            await _hiarc.AddUserToGroup(g1.Key, u1.Key);
            await _hiarc.AddUserToGroup(g2.Key, u1.Key);

            var groups = await _hiarc.GetGroupsForUser(u1.Key);

            Assert.Equal(2, groups.Count);
            Assert.Contains(g1, groups, new SdkEntityComparer());
            Assert.Contains(g2, groups, new SdkEntityComparer());
            Assert.DoesNotContain(g3, groups, new SdkEntityComparer());
        }

        [Fact]
        public async void GetGroupsForCurrentUser()
        {
            var u1 = await _hiarc.CreateUser();
            var g1 = await _hiarc.CreateGroup();
            var g2 = await _hiarc.CreateGroup();
            var g3 = await _hiarc.CreateGroup();

            await _hiarc.AddUserToGroup(g1.Key, u1.Key);
            await _hiarc.AddUserToGroup(g2.Key, u1.Key);

            var userCredentials = await _hiarc.CreateUserCredentials(u1.Key);
            var groups = await _hiarc.GetGroupsForCurrentUser(bearerToken: userCredentials.BearerToken);

            Assert.Equal(2, groups.Count);
            Assert.Contains(g1, groups, new SdkEntityComparer());
            Assert.Contains(g2, groups, new SdkEntityComparer());
            Assert.DoesNotContain(g3, groups, new SdkEntityComparer());

            groups = await _hiarc.GetGroupsForCurrentUser(asUserKey: u1.Key);

            Assert.Equal(2, groups.Count);
            Assert.Contains(g1, groups, new SdkEntityComparer());
            Assert.Contains(g2, groups, new SdkEntityComparer());
            Assert.DoesNotContain(g3, groups, new SdkEntityComparer());
        }

        [Fact]
        public async void CreateUserWithMetadata()
        {
            var md = TestMetadata;
            var u1 = await _hiarc.CreateUser(md);
            var fetchedUser = await _hiarc.GetUser(u1.Key);
            
            Assert.Equal(u1, fetchedUser, new SdkEntityComparer());
            AssertMetadataSdk(md, fetchedUser.Metadata);
        }

        [Fact]
        public async void UpdateMetadata()
        {
            var md = TestMetadata;
            var u1 = await _hiarc.CreateUser(md);
            
            var updatedMD = new Dictionary<string, object>
            {
                { "department", "support" },
                { "quotaCarrying", false },
                { "targetRate", 7.271 },
                { "level", 2 },
                { "startDate", DateTime.Parse("2020-02-25T22:33:50.134Z").ToUniversalTime() }
            };

            var request = new HiarcSDK.Model.UpdateUserRequest
            {
                Metadata = updatedMD
            };

            var updatedUser = await _hiarc.UpdateUser(u1.Key, request);
            AssertMetadataSdk(updatedMD, updatedUser.Metadata);
        }

        [Fact]
        public async void NullOutMetadata()
        {
            var md = TestMetadata;
            var u1 = await _hiarc.CreateUser(md);
            
            var updatedMD = new Dictionary<string, object>
            {
                { "department", null },
                { "quotaCarrying", null }
            };

            var request = new HiarcSDK.Model.UpdateUserRequest
            {
                Metadata = updatedMD
            };

            var updatedUser = await _hiarc.UpdateUser(u1.Key, request);
            Assert.Equal(3, updatedUser.Metadata.Keys.Count);

            updatedMD = new Dictionary<string, object>
            {
                { "targetRate", null },
                { "level", null },
                { "startDate", null }
            };

            request = new HiarcSDK.Model.UpdateUserRequest
            {
                Metadata = updatedMD
            };

            updatedUser = await _hiarc.UpdateUser(u1.Key, request);
            Assert.Null(updatedUser.Metadata);
        }

        [Fact]
        public async void FindUsers()
        {
            var md = TestMetadata;
            var u1 = await _hiarc.CreateUser(md);
            
            md["quotaCarrying"] = false;
            await _hiarc.CreateUser(md);
            
            await _hiarc.CreateUser();

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

            var request = new HiarcSDK.Model.FindUsersRequest { Query = query };
            var foundUsers = await _hiarc.FindUsers(request);
            Assert.Single(foundUsers);
            Assert.Equal(u1, foundUsers[0], new SdkEntityComparer());
        }
    }
}
