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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = HiarcSDK.Client.OpenAPIDateConverter;

namespace HiarcSDK.Model
{
    /// <summary>
    /// InlineObject
    /// </summary>
    [DataContract]
    public partial class InlineObject :  IEquatable<InlineObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject" /> class.
        /// </summary>
        /// <param name="request">request.</param>
        /// <param name="file">file.</param>
        public InlineObject(string request = default(string), System.IO.Stream file = default(System.IO.Stream))
        {
            this.Request = request;
            this.File = file;
        }
        
        /// <summary>
        /// Gets or Sets Request
        /// </summary>
        [DataMember(Name="request", EmitDefaultValue=false)]
        public string Request { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public System.IO.Stream File { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject {\n");
            sb.Append("  Request: ").Append(Request).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
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
            return this.Equals(input as InlineObject);
        }

        /// <summary>
        /// Returns true if InlineObject instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Request == input.Request ||
                    (this.Request != null &&
                    this.Request.Equals(input.Request))
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
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
                if (this.Request != null)
                    hashCode = hashCode * 59 + this.Request.GetHashCode();
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
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
            yield break;
        }
    }

}
