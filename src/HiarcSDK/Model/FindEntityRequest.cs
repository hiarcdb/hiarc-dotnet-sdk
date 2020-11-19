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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = HiarcSDK.Client.OpenAPIDateConverter;

namespace HiarcSDK.Model
{
    /// <summary>
    /// FindEntityRequest
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "Query")]
    [JsonSubtypes.KnownSubType(typeof(FindClassificationsRequest), "FindClassificationsRequest")]
    [JsonSubtypes.KnownSubType(typeof(FindRetentionPoliciesRequest), "FindRetentionPoliciesRequest")]
    [JsonSubtypes.KnownSubType(typeof(FindGroupsRequest), "FindGroupsRequest")]
    [JsonSubtypes.KnownSubType(typeof(FindCollectionsRequest), "FindCollectionsRequest")]
    [JsonSubtypes.KnownSubType(typeof(FindUsersRequest), "FindUsersRequest")]
    [JsonSubtypes.KnownSubType(typeof(FindUsersRequest), "findUser")]
    [JsonSubtypes.KnownSubType(typeof(FindGroupsRequest), "findGroup")]
    [JsonSubtypes.KnownSubType(typeof(FindCollectionsRequest), "findCollection")]
    [JsonSubtypes.KnownSubType(typeof(FindClassificationsRequest), "findClassification")]
    [JsonSubtypes.KnownSubType(typeof(FindRetentionPoliciesRequest), "findRetentionPolicies")]
    public partial class FindEntityRequest :  IEquatable<FindEntityRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindEntityRequest" /> class.
        /// </summary>
        /// <param name="query">query.</param>
        public FindEntityRequest(List<Dictionary<string, Object>> query = default(List<Dictionary<string, Object>>))
        {
            this.Query = query;
        }
        
        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public List<Dictionary<string, Object>> Query { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FindEntityRequest {\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FindEntityRequest);
        }

        /// <summary>
        /// Returns true if FindEntityRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FindEntityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindEntityRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Query == input.Query ||
                    this.Query != null &&
                    input.Query != null &&
                    this.Query.SequenceEqual(input.Query)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}