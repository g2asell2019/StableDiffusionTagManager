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
    /// ScriptsList
    /// </summary>
    [DataContract(Name = "ScriptsList")]
    public partial class ScriptsList : IEquatable<ScriptsList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptsList" /> class.
        /// </summary>
        /// <param name="txt2img">Titles of scripts (txt2img).</param>
        /// <param name="img2img">Titles of scripts (img2img).</param>
        public ScriptsList(List<Object> txt2img = default(List<Object>), List<Object> img2img = default(List<Object>))
        {
            this.Txt2img = txt2img;
            this.Img2img = img2img;
        }

        /// <summary>
        /// Titles of scripts (txt2img)
        /// </summary>
        /// <value>Titles of scripts (txt2img)</value>
        [DataMember(Name = "txt2img", EmitDefaultValue = false)]
        public List<Object> Txt2img { get; set; }

        /// <summary>
        /// Titles of scripts (img2img)
        /// </summary>
        /// <value>Titles of scripts (img2img)</value>
        [DataMember(Name = "img2img", EmitDefaultValue = false)]
        public List<Object> Img2img { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScriptsList {\n");
            sb.Append("  Txt2img: ").Append(Txt2img).Append("\n");
            sb.Append("  Img2img: ").Append(Img2img).Append("\n");
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
            return this.Equals(input as ScriptsList);
        }

        /// <summary>
        /// Returns true if ScriptsList instances are equal
        /// </summary>
        /// <param name="input">Instance of ScriptsList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScriptsList input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Txt2img == input.Txt2img ||
                    this.Txt2img != null &&
                    input.Txt2img != null &&
                    this.Txt2img.SequenceEqual(input.Txt2img)
                ) && 
                (
                    this.Img2img == input.Img2img ||
                    this.Img2img != null &&
                    input.Img2img != null &&
                    this.Img2img.SequenceEqual(input.Img2img)
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
                if (this.Txt2img != null)
                {
                    hashCode = (hashCode * 59) + this.Txt2img.GetHashCode();
                }
                if (this.Img2img != null)
                {
                    hashCode = (hashCode * 59) + this.Img2img.GetHashCode();
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
