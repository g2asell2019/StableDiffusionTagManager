/*
 * FastAPI
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = SdWebUpApi.Client.OpenAPIDateConverter;

namespace SdWebUpApi.Model
{
    /// <summary>
    /// MemoryResponse
    /// </summary>
    [DataContract(Name = "MemoryResponse")]
    public partial class MemoryResponse : IEquatable<MemoryResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MemoryResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryResponse" /> class.
        /// </summary>
        /// <param name="ram">System memory stats (required).</param>
        /// <param name="cuda">nVidia CUDA memory stats (required).</param>
        public MemoryResponse(Object ram = default(Object), Object cuda = default(Object))
        {
            // to ensure "ram" is required (not null)
            if (ram == null)
            {
                throw new ArgumentNullException("ram is a required property for MemoryResponse and cannot be null");
            }
            this.Ram = ram;
            // to ensure "cuda" is required (not null)
            if (cuda == null)
            {
                throw new ArgumentNullException("cuda is a required property for MemoryResponse and cannot be null");
            }
            this.Cuda = cuda;
        }

        /// <summary>
        /// System memory stats
        /// </summary>
        /// <value>System memory stats</value>
        [DataMember(Name = "ram", IsRequired = true, EmitDefaultValue = true)]
        public Object Ram { get; set; }

        /// <summary>
        /// nVidia CUDA memory stats
        /// </summary>
        /// <value>nVidia CUDA memory stats</value>
        [DataMember(Name = "cuda", IsRequired = true, EmitDefaultValue = true)]
        public Object Cuda { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MemoryResponse {\n");
            sb.Append("  Ram: ").Append(Ram).Append("\n");
            sb.Append("  Cuda: ").Append(Cuda).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MemoryResponse);
        }

        /// <summary>
        /// Returns true if MemoryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MemoryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemoryResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Ram == input.Ram ||
                    (this.Ram != null &&
                    this.Ram.Equals(input.Ram))
                ) && 
                (
                    this.Cuda == input.Cuda ||
                    (this.Cuda != null &&
                    this.Cuda.Equals(input.Cuda))
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
                if (this.Ram != null)
                {
                    hashCode = (hashCode * 59) + this.Ram.GetHashCode();
                }
                if (this.Cuda != null)
                {
                    hashCode = (hashCode * 59) + this.Cuda.GetHashCode();
                }
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
