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
    /// EmbeddingsResponse
    /// </summary>
    [DataContract(Name = "EmbeddingsResponse")]
    public partial class EmbeddingsResponse : IEquatable<EmbeddingsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmbeddingsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsResponse" /> class.
        /// </summary>
        /// <param name="loaded">Embeddings loaded for the current model (required).</param>
        /// <param name="skipped">Embeddings skipped for the current model (likely due to architecture incompatibility) (required).</param>
        public EmbeddingsResponse(Dictionary<string, EmbeddingItem> loaded = default(Dictionary<string, EmbeddingItem>), Dictionary<string, EmbeddingItem> skipped = default(Dictionary<string, EmbeddingItem>))
        {
            // to ensure "loaded" is required (not null)
            if (loaded == null)
            {
                throw new ArgumentNullException("loaded is a required property for EmbeddingsResponse and cannot be null");
            }
            this.Loaded = loaded;
            // to ensure "skipped" is required (not null)
            if (skipped == null)
            {
                throw new ArgumentNullException("skipped is a required property for EmbeddingsResponse and cannot be null");
            }
            this.Skipped = skipped;
        }

        /// <summary>
        /// Embeddings loaded for the current model
        /// </summary>
        /// <value>Embeddings loaded for the current model</value>
        [DataMember(Name = "loaded", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, EmbeddingItem> Loaded { get; set; }

        /// <summary>
        /// Embeddings skipped for the current model (likely due to architecture incompatibility)
        /// </summary>
        /// <value>Embeddings skipped for the current model (likely due to architecture incompatibility)</value>
        [DataMember(Name = "skipped", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, EmbeddingItem> Skipped { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmbeddingsResponse {\n");
            sb.Append("  Loaded: ").Append(Loaded).Append("\n");
            sb.Append("  Skipped: ").Append(Skipped).Append("\n");
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
            return this.Equals(input as EmbeddingsResponse);
        }

        /// <summary>
        /// Returns true if EmbeddingsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EmbeddingsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbeddingsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Loaded == input.Loaded ||
                    this.Loaded != null &&
                    input.Loaded != null &&
                    this.Loaded.SequenceEqual(input.Loaded)
                ) && 
                (
                    this.Skipped == input.Skipped ||
                    this.Skipped != null &&
                    input.Skipped != null &&
                    this.Skipped.SequenceEqual(input.Skipped)
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
                if (this.Loaded != null)
                {
                    hashCode = (hashCode * 59) + this.Loaded.GetHashCode();
                }
                if (this.Skipped != null)
                {
                    hashCode = (hashCode * 59) + this.Skipped.GetHashCode();
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
