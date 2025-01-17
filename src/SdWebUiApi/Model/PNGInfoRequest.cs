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
    /// PNGInfoRequest
    /// </summary>
    [DataContract(Name = "PNGInfoRequest")]
    public partial class PNGInfoRequest : IEquatable<PNGInfoRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PNGInfoRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PNGInfoRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PNGInfoRequest" /> class.
        /// </summary>
        /// <param name="image">The base64 encoded PNG image (required).</param>
        public PNGInfoRequest(string image = default(string))
        {
            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new ArgumentNullException("image is a required property for PNGInfoRequest and cannot be null");
            }
            this.Image = image;
        }

        /// <summary>
        /// The base64 encoded PNG image
        /// </summary>
        /// <value>The base64 encoded PNG image</value>
        [DataMember(Name = "image", IsRequired = true, EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PNGInfoRequest {\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
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
            return this.Equals(input as PNGInfoRequest);
        }

        /// <summary>
        /// Returns true if PNGInfoRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PNGInfoRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PNGInfoRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
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
                if (this.Image != null)
                {
                    hashCode = (hashCode * 59) + this.Image.GetHashCode();
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
