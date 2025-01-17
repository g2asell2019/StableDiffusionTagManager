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
    /// ImageToImageResponse
    /// </summary>
    [DataContract(Name = "ImageToImageResponse")]
    public partial class ImageToImageResponse : IEquatable<ImageToImageResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToImageResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageToImageResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToImageResponse" /> class.
        /// </summary>
        /// <param name="images">The generated image in base64 format..</param>
        /// <param name="parameters">parameters (required).</param>
        /// <param name="info">info (required).</param>
        public ImageToImageResponse(List<string> images = default(List<string>), Object parameters = default(Object), string info = default(string))
        {
            // to ensure "parameters" is required (not null)
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters is a required property for ImageToImageResponse and cannot be null");
            }
            this.Parameters = parameters;
            // to ensure "info" is required (not null)
            if (info == null)
            {
                throw new ArgumentNullException("info is a required property for ImageToImageResponse and cannot be null");
            }
            this.Info = info;
            this.Images = images;
        }

        /// <summary>
        /// The generated image in base64 format.
        /// </summary>
        /// <value>The generated image in base64 format.</value>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public List<string> Images { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", IsRequired = true, EmitDefaultValue = true)]
        public Object Parameters { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name = "info", IsRequired = true, EmitDefaultValue = true)]
        public string Info { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImageToImageResponse {\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
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
            return this.Equals(input as ImageToImageResponse);
        }

        /// <summary>
        /// Returns true if ImageToImageResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageToImageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageToImageResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    (this.Parameters != null &&
                    this.Parameters.Equals(input.Parameters))
                ) && 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
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
                if (this.Images != null)
                {
                    hashCode = (hashCode * 59) + this.Images.GetHashCode();
                }
                if (this.Parameters != null)
                {
                    hashCode = (hashCode * 59) + this.Parameters.GetHashCode();
                }
                if (this.Info != null)
                {
                    hashCode = (hashCode * 59) + this.Info.GetHashCode();
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
