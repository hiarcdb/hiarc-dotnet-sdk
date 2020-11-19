using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Diagnostics;
using System.Collections.Generic;
using HiarcSDK.Client;
using HiarcSDK.Api;

namespace HiarcSDKIntegrationTest
{
    public class HiarcClient
    {
        const string API_KEY = "<admin-key>";
        const string API_KEY_HEADER_NAME = "X-Hiarc-Api-Key";
        const string AS_USER_HEADER_NAME = "X-Hiarc-User-Key";
        const string BASE_URI = "http://localhost:5000";

        private readonly JsonSerializerOptions jsonOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, WriteIndented = true };
        private readonly Stopwatch sw;

        private int currFile = 1;
        private int currColl = 1;
        private int currUser = 1;
        private int currGroup = 1;
        private int currRetentionPolicy = 1;
        private int currLegalHold = 1;
        private int currClassification = 1;

        public Configuration Configuration { get; private set; }
        public AdminApi AdminApiWithApiKey { get; private set; }
        public ClassificationApi ClassificationWithApiKey { get; private set; }
        public CollectionApi CollectionWithApiKey { get; private set; }
        public FileApi FileApiWithApiKey { get; private set; }
        public FilesApi FilesApiWithApiKey { get; private set; }
        public LegalHoldApi LegalHoldsWithApiKey { get; private set; }
        public UserApi UserApiWithApiKey { get; private set; }
        public GroupApi GroupApiWithApiKey { get; private set; }
        public GroupsApi GroupsApiWithApiKey { get; private set; }
        public RetentionPolicyApi RetentionPolicyWithApiKey { get; private set; }
        public TokenApi TokensApiWithApiKey { get; private set; }

        public HiarcClient()
        {
            sw = new Stopwatch();

            var config = new Configuration();
            config.BasePath = BASE_URI;
            config.ApiKey.Add(API_KEY_HEADER_NAME, API_KEY);
            this.Configuration = config;
            this.AdminApiWithApiKey = new AdminApi(config);
            this.ClassificationWithApiKey = new ClassificationApi(config);
            this.CollectionWithApiKey = new CollectionApi(config);
            this.FileApiWithApiKey = new FileApi(config);
            this.FilesApiWithApiKey = new FilesApi(config);
            this.LegalHoldsWithApiKey = new LegalHoldApi(config);
            this.UserApiWithApiKey = new UserApi(config);
            this.GroupApiWithApiKey = new GroupApi(config);
            this.GroupsApiWithApiKey = new GroupsApi(config);
            this.RetentionPolicyWithApiKey = new RetentionPolicyApi(config);
            this.TokensApiWithApiKey = new TokenApi(config);
        }

        public async Task<bool> InitDB(bool logToConsole = true)
        {
            sw.Restart();
            await this.AdminApiWithApiKey.InitDBAsync();
            sw.Stop();

            if (logToConsole) { Console.WriteLine($"\nInitialized Database: {sw.ElapsedMilliseconds}ms\n####################\n"); };
            return true;
        }

        public async Task<bool> ResetDB(bool logToConsole = true)
        {
            sw.Restart();
            await this.AdminApiWithApiKey.ResetDBAsync();
            sw.Stop();

            if (logToConsole) { Console.WriteLine($"\nReset Database: {sw.ElapsedMilliseconds}ms\n####################\n"); };
            return true;
        }

        public async Task<HiarcSDK.Model.UserCredentials> CreateUserCredentials(string key, bool logToConsole = true)
        {
            var request = new HiarcSDK.Model.CreateUserTokenRequest { Key = key };
            var token = await this.TokensApiWithApiKey.CreateUserTokenAsync(request);
            if (logToConsole) { Console.WriteLine($"Created Token for User '{key}': {ToJson(token)}"); };
            return token;
        }

        public async Task<HiarcSDK.Model.File> GetFile(string key, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var file = await this.FileApiWithApiKey.GetFileAsync(key, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Retrieved File: {ToJson(file)}"); };
            return file;
        }

        public async Task<List<HiarcSDK.Model.FileVersion>> GetFileVersions(string key, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var fileVersions = await this.FileApiWithApiKey.GetVersionsAsync(key, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Retrieved FileVersions: {ToJson(fileVersions)}"); };
            return fileVersions;
        }

        public async Task<List<HiarcSDK.Model.RetentionPolicyApplication>> GetFileRetentionPolicies(string key, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var retentionPolicies = await this.FileApiWithApiKey.GetRetentionPoliciesAsync(key, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Retrieved Retention Policies for File Key '{key}': {ToJson(retentionPolicies)}"); };
            return retentionPolicies;
        }

        public async Task<List<string>> FilterAllowedFiles(List<string> fileKeys, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var request = new HiarcSDK.Model.AllowedFilesRequest() { Keys = fileKeys };
            var allowedFiles = await this.FilesApiWithApiKey.FilterAllowedFilesAsync(request, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Retrieved allowed files: Requested='{fileKeys}', Allowed='{allowedFiles}'"); };
            return allowedFiles;
        }

        public async Task<HiarcSDK.Model.File> CopyFile(string key, string storageService = null, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var copyKey = GenerateKey("file");
            var copyFileRequest = new HiarcSDK.Model.CopyFileRequest() { Key = copyKey, StorageService = storageService };
            var copyOfFile = await this.FileApiWithApiKey.CopyFileAsync(key, copyFileRequest, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Created Copy of File: OriginalKey='{key}', CopyKey='{copyOfFile.Key}'"); };
            return copyOfFile;
        }

        public async Task DownloadFile(string key, string pathToSaveTo, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            sw.Restart();
            using (var s = await this.FileApiWithApiKey.DownloadFileAsync(key, xHiarcUserKey: asUserKey))
            using (System.IO.FileStream fs = System.IO.File.Create(pathToSaveTo))
            {
                await s.CopyToAsync(fs);
            }
            sw.Stop();

            if (logToConsole) { Console.WriteLine($"Downloaded File: Key=\"{key}\", Path=\"{pathToSaveTo}\", Elapsed={sw.ElapsedMilliseconds}ms"); };
        }

        public async Task<HiarcSDK.Model.FileDirectDownload> GetFileDirectDownload(string key, int? expiresInSeconds = null, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            // var url = expiresInSeconds == null ? $"files/{key}/directdownloadurl" : $"files/{key}/directdownloadurl?expiresInSeconds={expiresInSeconds.Value}";

            var directDownloadInfo = await this.FileApiWithApiKey.GetDirectDownloadUrlAsync(key, xHiarcUserKey: asUserKey, expiresInSeconds: expiresInSeconds);
            if (logToConsole) { Console.WriteLine($"Retrieved DirectDownloadInfo: {ToJson(directDownloadInfo)}"); };
            return directDownloadInfo;
        }

        public async Task<HiarcSDK.Model.FileDirectUpload> CreateFileDirectUpload(string storageService = null, int? expiresInSeconds = null, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            // var url = expiresInSeconds == null ? $"files/directuploadurl" : $"files/directuploadurl?expiresInSeconds={expiresInSeconds.Value}";

            var request = new HiarcSDK.Model.CreateDirectUploadUrlRequest { StorageService = storageService };
            var directUploadInfo = await this.FileApiWithApiKey.CreateDirectUploadUrlAsync(request, xHiarcUserKey: asUserKey, expiresInSeconds: expiresInSeconds);
            if (logToConsole) { Console.WriteLine($"Retrieved DirectUploadInfo: {ToJson(directUploadInfo)}"); };
            return directUploadInfo;
        }

        public async Task<HiarcSDK.Model.File> CreateFile(string filePath, Dictionary<string, object> metadata = null, string storageService = null, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            using System.IO.Stream fileStream = System.IO.File.OpenRead(filePath);
            sw.Restart();
            var key = GenerateKey("file");
            var fileName = System.IO.Path.GetFileName(filePath);

            var createFileRequest = new HiarcSDK.Model.CreateFileRequest() { Key = key, Name = fileName, Description = "This is a brand new file", Metadata = metadata, StorageService = storageService };
            sw.Stop();
            return await this.FileApiWithApiKey.CreateFileAsync(createFileRequest, fileStream, xHiarcUserKey: asUserKey);
        }

        public async Task<HiarcSDK.Model.File> UpdateFile(string key, HiarcSDK.Model.UpdateFileRequest request, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var updatedFile = await this.FileApiWithApiKey.UpdateFileAsync(key, request);
            if (logToConsole) { Console.WriteLine($"Updated File: {ToJson(updatedFile)}\""); };
            return updatedFile;
        }

        public async Task DeleteFile(string key, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            await this.FileApiWithApiKey.DeleteFileAsync(key, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Deleted File Key: {key}\""); };
        }

        public async Task<HiarcSDK.Model.File> AttachToExistingFile(string storageService, string storageId, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var fileKey = GenerateKey("file");
            var request = new HiarcSDK.Model.AttachToExistingFileRequest() { Name = fileKey, StorageService = storageService, StorageId = storageId };

            var newFile = await this.FileApiWithApiKey.AttachToExisitingFileAsync(fileKey, request, xHiarcUserKey: asUserKey);

            if (logToConsole) { Console.WriteLine($"Attached to Existing File: Key='{newFile.Key}', StorageService='{storageService}', StorageId='{storageId}'"); };
            return newFile;
        }

        public async Task<IList<HiarcSDK.Model.Collection>> GetCollectionsForFile(string key, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var collections = await this.FileApiWithApiKey.GetCollectionsForFileAsync(key, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Fetched Collections for File '{key}': {ToJson(collections)}"); };
            return collections;
        }

        public async Task<HiarcSDK.Model.File> AddNewVersionToFile(string key, string filePath, string storageService = null, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            using (System.IO.Stream fileStream = System.IO.File.OpenRead(filePath))
            {
                sw.Restart();
                var fileName = System.IO.Path.GetFileName(filePath);

                var addVersionToFileRequest = new HiarcSDK.Model.AddVersionToFileRequest() { Key = key, StorageService = storageService };
                sw.Stop();
                return await this.FileApiWithApiKey.AddVersionAsync(key, addVersionToFileRequest, fileStream, xHiarcUserKey: asUserKey);
            }
        }

        public async Task AddUserToFile(string userKey, string fileKey, HiarcSDK.Model.AccessLevel accessLevel, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var addUserToFileRequest = new HiarcSDK.Model.AddUserToFileRequest() { UserKey = userKey, AccessLevel = accessLevel };
            await this.FileApiWithApiKey.AddUserToFileAsync(fileKey, addUserToFileRequest, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Added user to file: User=\"{userKey}\", File=\"{fileKey}\", AccessLevel=\"{accessLevel}\""); };
        }

        public async Task AddGroupToFile(string groupKey, string fileKey, HiarcSDK.Model.AccessLevel accessLevel, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var addGroupToFileRequest = new HiarcSDK.Model.AddGroupToFileRequest() { GroupKey = groupKey, AccessLevel = accessLevel };
            await this.FileApiWithApiKey.AddGroupToFileAsync(fileKey, addGroupToFileRequest, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Added group to file: Group=\"{groupKey}\", File=\"{fileKey}\", AccessLevel=\"{accessLevel}\""); };
        }

        public async Task AddRetentionPolicyToFile(string retentionPolicyKey, string fileKey, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var addRetentionPolicyToFileRequest = new HiarcSDK.Model.AddRetentionPolicyToFileRequest() { RetentionPolicyKey = retentionPolicyKey };
            await this.FileApiWithApiKey.AddRetentionPolicyToFileAsync(fileKey, addRetentionPolicyToFileRequest, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Added retention policy to file: RetentionPolicy=\"{retentionPolicyKey}\", File=\"{fileKey}\""); };
        }

        public async Task AddClassificationToFile(string classificationKey, string fileKey, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var addClassificationToFileRequest = new HiarcSDK.Model.AddClassificationToFileRequest() { ClassificationKey = classificationKey };
            await this.FileApiWithApiKey.AddClassificationToFileAsync(classificationKey, addClassificationToFileRequest, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Added classification to file: Classification=\"{classificationKey}\", File=\"{fileKey}\""); };
        }

        public async Task<HiarcSDK.Model.User> CreateUser(Dictionary<string, object> metadata = null, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var key = GenerateKey("user");
            var createUserRequest = new HiarcSDK.Model.CreateUserRequest() { Key = key, Name = $"name-{key}", Description = "Lobster taco", Metadata = metadata };
            var newUser = await this.UserApiWithApiKey.CreateUserAsync(createUserRequest);
            if (logToConsole) { Console.WriteLine($"Created New User: {ToJson(newUser)}"); };
            return newUser;
        }

        public async Task<HiarcSDK.Model.User> UpdateUser(string key, HiarcSDK.Model.UpdateUserRequest request, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var updatedUser = await this.UserApiWithApiKey.UpdateUserAsync(key, request);
            if (logToConsole) { Console.WriteLine($"Updated User: {ToJson(updatedUser)}"); };
            return updatedUser;
        }

        public async Task<HiarcSDK.Model.User> GetUser(string key, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var user = await this.UserApiWithApiKey.GetUserAsync(key);
            if (logToConsole) { Console.WriteLine($"Fetched User: {ToJson(user)}"); };
            return user;
        }

        public async Task<HiarcSDK.Model.User> GetCurrentUser(string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var user = await this.UserApiWithApiKey.GetCurrentUserAsync(xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Fetched Current User: {ToJson(user)}"); };
            return user;
        }

        public async Task DeleteUser(string userKey, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            await this.UserApiWithApiKey.DeleteUserAsync(userKey);
            if (logToConsole) { Console.WriteLine($"Deleted User Key: {userKey}"); };
        }

        public async Task<List<HiarcSDK.Model.User>> FindUsers(HiarcSDK.Model.FindUsersRequest request, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var foundUsers = await this.UserApiWithApiKey.FindUserAsync(request);
            if (logToConsole) { Console.WriteLine($"Found {foundUsers.Count} Users: {ToJson(foundUsers)}"); };
            return foundUsers;
        }

        public async Task<List<HiarcSDK.Model.Group>> GetGroupsForUser(string key, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            List<HiarcSDK.Model.Group> groups;
            if (bearerToken != null)
            {
                var config = UserTokenConfiguration(bearerToken);
                var api = new GroupsApi(config);
                groups = await api.GetGroupsForUserAsync(key);
            }
            else
            {
                groups = await this.GroupsApiWithApiKey.GetGroupsForUserAsync(key);
            }
            if (logToConsole) { Console.WriteLine($"Fetched Groups for User: Key=\"{key}\", NumGroups=\"{groups.Count}\""); };
            return groups;
        }

        public async Task<List<HiarcSDK.Model.Group>> GetGroupsForCurrentUser(string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            List<HiarcSDK.Model.Group> groups;
            if (bearerToken != null)
            {
                var config = UserTokenConfiguration(bearerToken);
                var api = new UserApi(config);
                groups = await api.GetGroupsForCurrentUserAsync();
            }
            else
            {
                groups = await this.UserApiWithApiKey.GetGroupsForCurrentUserAsync(xHiarcUserKey: asUserKey);
            }
            if (logToConsole) { Console.WriteLine($"Fetched Groups for Current User: NumGroups=\"{groups.Count}\""); };
            return groups;
        }

        public async Task<IList<HiarcSDK.Model.User>> GetAllUsers(string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var users = await this.UserApiWithApiKey.GetAllUsersAsync();
            if (logToConsole) { Console.WriteLine($"Fetched Users: Count={users.Count}"); };
            return users;
        }

        public async Task<HiarcSDK.Model.Group> CreateGroup(Dictionary<string, object> metadata = null, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var key = GenerateKey("group");
            var createGroupRequest = new HiarcSDK.Model.CreateGroupRequest() { Key = key, Name = $"name-{key}", Metadata = metadata };
            var newGroup = await this.GroupApiWithApiKey.CreateGroupAsync(createGroupRequest);
            if (logToConsole) { Console.WriteLine($"Created New Group: {ToJson(newGroup)}"); };
            return newGroup;
        }

        public async Task<HiarcSDK.Model.Group> GetGroup(string key, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var group = await this.GroupApiWithApiKey.GetGroupAsync(key);
            if (logToConsole) { Console.WriteLine($"Fetched Group: {ToJson(group)}"); };
            return group;
        }

        public async Task<HiarcSDK.Model.Group> UpdateGroup(string key, HiarcSDK.Model.UpdateGroupRequest request, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var updatedGroup = await this.GroupApiWithApiKey.UpdateGroupAsync(key, request);
            if (logToConsole) { Console.WriteLine($"Updated Group: {ToJson(updatedGroup)}"); };
            return updatedGroup;
        }

        public async Task<List<HiarcSDK.Model.Group>> FindGroups(HiarcSDK.Model.FindGroupsRequest request, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var foundGroups = await this.GroupApiWithApiKey.FindGroupAsync(request);
            if (logToConsole) { Console.WriteLine($"Found {foundGroups.Count} Groups: {ToJson(foundGroups)}"); };
            return foundGroups;
        }

        public async Task DeleteGroup(string groupKey, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            await this.GroupApiWithApiKey.DeleteGroupAsync(groupKey);
            if (logToConsole) { Console.WriteLine($"Deleted Group Key: {groupKey}"); };
        }

        public async Task<IList<HiarcSDK.Model.Group>> GetAllGroups(string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var groups = await this.GroupApiWithApiKey.GetAllGroupsAsync();
            Console.WriteLine($"Fetched Groups: Count={groups.Count}");

            if (logToConsole)
            {
                foreach (var group in groups)
                {
                    Console.WriteLine($"Fetched Group: Key=\"{group.Key}\", Name=\"{group.Name}\"");
                }
            };
            return groups;
        }

        public async Task AddUserToGroup(string groupKey, string userKey, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var result = await this.GroupApiWithApiKey.AddUserToGroupAsync(groupKey, userKey);
            if (logToConsole) { Console.WriteLine($"Added User to Group: User=\"{userKey}\", Group=\"{groupKey}\""); };
        }

        public async Task<HiarcSDK.Model.Collection> CreateCollection(Dictionary<string, object> metadata = null, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var key = GenerateKey("collection");
            var createCollectionRequest = new HiarcSDK.Model.CreateCollectionRequest() { Key = key, Name = $"name-{key}", Metadata = metadata };
            var newCollection = await this.CollectionWithApiKey.CreateCollectionAsync(createCollectionRequest, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Created New Collection: {ToJson(newCollection)}"); };
            return newCollection;
        }

        public async Task<HiarcSDK.Model.Collection> UpdateCollection(string key, HiarcSDK.Model.UpdateCollectionRequest request, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var updatedCollection = await this.CollectionWithApiKey.UpdateCollectionAsync(key, request, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Updated Collection: {ToJson(updatedCollection)}"); };
            return updatedCollection;
        }

        public async Task DeleteCollection(string key, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            await this.CollectionWithApiKey.DeleteCollectionAsync(key, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Deleted Collection Key: {key}"); };
        }

        public async Task<List<HiarcSDK.Model.Collection>> FindCollections(HiarcSDK.Model.FindCollectionsRequest request, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var foundCollections = await this.CollectionWithApiKey.FindCollectionAsync(request, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Found {foundCollections.Count} Collections: {ToJson(foundCollections)}"); };
            return foundCollections;
        }

        public async Task<HiarcSDK.Model.Collection> GetCollection(string key, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var collection = await this.CollectionWithApiKey.GetCollectionAsync(key, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Fetched Collection: {ToJson(collection)}"); };
            return collection;
        }

        public async Task<IList<HiarcSDK.Model.Collection>> GetAllCollections(string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            if (bearerToken != null)
            {
                var config = UserTokenConfiguration(bearerToken);
                var api = new CollectionApi(config);
                return await api.GetAllCollectionsAsync();
            }
            else
            {
                var collections = await this.CollectionWithApiKey.GetAllCollectionsAsync(xHiarcUserKey: asUserKey);
                if (logToConsole) { Console.WriteLine($"Fetched Collections: Count={collections.Count}"); };
                return collections;
            }
        }

        public async Task<List<HiarcSDK.Model.File>> GetFilesForCollection(string key, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            if (bearerToken != null)
            {
                var config = UserTokenConfiguration(bearerToken);
                var api = new CollectionApi(config);
                return await api.GetCollectionFilesAsync(key);
            }
            else
            {
                var files = await this.CollectionWithApiKey.GetCollectionFilesAsync(key, xHiarcUserKey: asUserKey);
                if (logToConsole) { Console.WriteLine($"Fetched Files for Collection '{key}': {ToJson(files)}"); };
                return files;
            }
        }

        public async Task<List<HiarcSDK.Model.Collection>> GetChildrenForCollection(string key, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var children = await this.CollectionWithApiKey.GetCollectionChildrenAsync(key, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Fetched Children for Collection '{key}': {ToJson(children)}"); };
            return children;
        }

        public async Task<HiarcSDK.Model.CollectionItems> GetItemsForCollection(string key, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var items = await this.CollectionWithApiKey.GetCollectionItemsAsync(key, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Fetched Items for Collection '{key}': Children={ToJson(items.ChildCollections)}, Files={ToJson(items.Files)}"); };
            return items;
        }

        public async Task RemoveFileFromCollection(string key, string fileKey, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            await this.CollectionWithApiKey.RemoveFileFromCollectionAsync(key, fileKey, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Deleted File '{fileKey}' from Collection '{key}'"); };
        }

        public async Task AddChildCollection(string parentKey, string childKey, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var result = await this.CollectionWithApiKey.AddChildToCollectionAsync(parentKey, childKey, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Added Child to Collection: Parent=\"{parentKey}\", Child=\"{childKey}\""); };
            // return result;
        }

        public async Task AddUserToCollection(string collectionKey, string userKey, HiarcSDK.Model.AccessLevel accessLevel, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var request = new HiarcSDK.Model.AddUserToCollectionRequest() { UserKey = userKey, AccessLevel = accessLevel };
            var result = await this.CollectionWithApiKey.AddUserToCollectionAsync(collectionKey, request, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Added User to Collection: Collection=\"{collectionKey}\", User=\"{userKey}\", AccessLevel=\"{accessLevel}\""); };
        }

        public async Task AddGroupToCollection(string collectionKey, string groupKey, HiarcSDK.Model.AccessLevel accessLevel, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var request = new HiarcSDK.Model.AddGroupToCollectionRequest() { GroupKey = groupKey, AccessLevel = accessLevel };
            var result = await this.CollectionWithApiKey.AddGroupToCollectionAsync(collectionKey, request, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Added Group to Collection: Collection=\"{collectionKey}\", Group=\"{groupKey}\", AccessLevel=\"{accessLevel}\""); };
        }

        public async Task AddFileToCollection(string collectionKey, string fileKey, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var request = new HiarcSDK.Model.AddFileToCollectionRequest() { FileKey = fileKey };
            var result = await this.CollectionWithApiKey.AddFileToCollectionAsync(collectionKey, request, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Added File to Collection: Collection=\"{collectionKey}\", File=\"{fileKey}\""); };
            // return result;
        }

        public async Task<HiarcSDK.Model.RetentionPolicy> GetRetentionPolicy(string key, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var retentionPolicy = await this.RetentionPolicyWithApiKey.GetRetentionPolicyAsync(key);
            if (logToConsole) { Console.WriteLine($"Fetched Retention Policy: {ToJson(retentionPolicy)}"); };
            return retentionPolicy;
        }

        public async Task<HiarcSDK.Model.RetentionPolicy> CreateRetentionPolicy(uint seconds, Dictionary<string, object> metadata = null, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var key = GenerateKey("retentionPolicy");
            var createRetentionPolicyRequest = new HiarcSDK.Model.CreateRetentionPolicyRequest() { Key = key, Name = $"name-{key}", Description = "Lobster taco retention policy", Metadata = metadata, Seconds = seconds };
            var newRetentionPolicy = await this.RetentionPolicyWithApiKey.CreateRetentionPolicyAsync(createRetentionPolicyRequest);
            if (logToConsole) { Console.WriteLine($"Created New Retention Policy: {ToJson(newRetentionPolicy)}\""); };
            return newRetentionPolicy;
        }

        public async Task<HiarcSDK.Model.RetentionPolicy> UpdateRetentionPolicy(string key, HiarcSDK.Model.UpdateRetentionPolicyRequest request, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var updatedRetentionPolicy = await this.RetentionPolicyWithApiKey.UpdateRetentionPolicyAsync(key, request);
            if (logToConsole) { Console.WriteLine($"Updated Retention Policy: {ToJson(updatedRetentionPolicy)}\""); };
            return updatedRetentionPolicy;
        }

        public async Task<IList<HiarcSDK.Model.RetentionPolicy>> GetAllRetentionPolicies(string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var policies = await this.RetentionPolicyWithApiKey.GetAllRetentionPoliciesAsync();
            if (logToConsole) { Console.WriteLine($"Fetched Retention Policies: Count={policies.Count}"); };
            return policies;
        }

        public async Task<List<HiarcSDK.Model.RetentionPolicy>> FindRetentionPolicies(HiarcSDK.Model.FindRetentionPoliciesRequest request, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var foundPolicies = await this.RetentionPolicyWithApiKey.FindRetentionPoliciesAsync(request);
            if (logToConsole) { Console.WriteLine($"Found {foundPolicies.Count} Policies: {ToJson(foundPolicies)}"); };
            return foundPolicies;
        }

        public async Task<HiarcSDK.Model.LegalHold> GetLegalHold(string key, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var legalHold = await this.LegalHoldsWithApiKey.GetLegalHoldAsync(key);
            if (logToConsole) { Console.WriteLine($"Fetched Legal Hold: {ToJson(legalHold)}"); };
            return legalHold;
        }

        public async Task<HiarcSDK.Model.LegalHold> CreateLegalHold(Dictionary<string, object> metadata = null, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var key = GenerateKey("legalHold");
            var createLegalHoldRequest = new HiarcSDK.Model.CreateLegalHoldRequest() { Key = key, Name = $"name-{key}", Description = "Lobster taco legal hold", Metadata = metadata };
            var newLegalHold = await this.LegalHoldsWithApiKey.CreateLegalHoldAsync(createLegalHoldRequest);
            if (logToConsole) { Console.WriteLine($"Created New Legal Hold: {ToJson(newLegalHold)}\""); };
            return newLegalHold;
        }

        public async Task<HiarcSDK.Model.Classification> GetClassification(string key, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var classification = await this.ClassificationWithApiKey.GetClassificationAsync(key, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Fetched Classification: {ToJson(classification)}"); };
            return classification;
        }

        public async Task<IList<HiarcSDK.Model.Classification>> GetAllClassifications(string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var classifications = await this.ClassificationWithApiKey.GetAllClassificationsAsync(xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Fetched Classifications: Count={classifications.Count}"); };
            return classifications;
        }

        public async Task<HiarcSDK.Model.Classification> CreateClassification(Dictionary<string, object> metadata = null, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var key = GenerateKey("classification");
            var createClassificationRequest = new HiarcSDK.Model.CreateClassificationRequest() { Key = key, Name = $"name-{key}", Description = "Lobster taco classification", Metadata = metadata };
            var newClassification = await this.ClassificationWithApiKey.CreateClassificationAsync(createClassificationRequest, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Created New Classification: {ToJson(newClassification)}\""); };
            return newClassification;
        }

        public async Task<HiarcSDK.Model.Classification> UpdateClassification(string key, HiarcSDK.Model.UpdateClassificationRequest request, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var updatedClassification = await this.ClassificationWithApiKey.UpdateClassificationAsync(key, request, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Updated Classification: {ToJson(updatedClassification)}\""); };
            return updatedClassification;
        }

        public async Task<List<HiarcSDK.Model.Classification>> FindClassifications(HiarcSDK.Model.FindClassificationsRequest request, string asUserKey = null, string bearerToken = null, bool logToConsole = true)
        {
            var foundClassifications = await this.ClassificationWithApiKey.FindClassificationAsync(request, xHiarcUserKey: asUserKey);
            if (logToConsole) { Console.WriteLine($"Found {foundClassifications.Count} Classifications: {ToJson(foundClassifications)}"); };
            return foundClassifications;
        }

        public HttpContent JsonContent<T>(T requestModel)
        {
            var json = JsonSerializer.Serialize<T>(requestModel);
            var httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return httpContent;
        }

        public string ToJson<T>(T model)
        {
            return JsonSerializer.Serialize(model, jsonOptions);
        }

        public string GenerateKey(string prefix) => prefix switch
        {
            "file" => $"{prefix}-{currFile++}",
            "collection" => $"{prefix}-{currColl++}",
            "user" => $"{prefix}-{currUser++}",
            "group" => $"{prefix}-{currGroup++}",
            "retentionPolicy" => $"{prefix}-{currRetentionPolicy++}",
            "legalHold" => $"{prefix}-{currLegalHold++}",
            "classification" => $"{prefix}-{currClassification++}",
            _ => $"{prefix}-{Guid.NewGuid()}",
        };

        public Configuration UserTokenConfiguration(string token)
        {
            var config = new Configuration();
            config.BasePath = BASE_URI;
            config.AccessToken = token;
            return config;
        }

        public string BuildPath(string filename) => $"{System.IO.Directory.GetCurrentDirectory()}/../../../TestFiles/{filename}";

    }
}