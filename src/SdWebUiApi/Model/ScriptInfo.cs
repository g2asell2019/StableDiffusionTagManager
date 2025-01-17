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
    /// ScriptInfo
    /// </summary>
    [DataContract(Name = "ScriptInfo")]
    public partial class ScriptInfo : IEquatable<ScriptInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScriptInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScriptInfo" /> class.
        /// </summary>
        /// <param name="name">Script name.</param>
        /// <param name="isAlwayson">Flag specifying whether this script is an alwayson script.</param>
        /// <param name="isImg2img">Flag specifying whether this script is an img2img script.</param>
        /// <param name="args">List of script&#39;s arguments (required).</param>
        public ScriptInfo(string name = default(string), bool isAlwayson = default(bool), bool isImg2img = default(bool), List<ScriptArg> args = default(List<ScriptArg>))
        {
            // to ensure "args" is required (not null)
            if (args == null)
            {
                throw new ArgumentNullException("args is a required property for ScriptInfo and cannot be null");
            }
            this.Args = args;
            this.Name = name;
            this.IsAlwayson = isAlwayson;
            this.IsImg2img = isImg2img;
        }

        /// <summary>
        /// Script name
        /// </summary>
        /// <value>Script name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Flag specifying whether this script is an alwayson script
        /// </summary>
        /// <value>Flag specifying whether this script is an alwayson script</value>
        [DataMember(Name = "is_alwayson", EmitDefaultValue = true)]
        public bool IsAlwayson { get; set; }

        /// <summary>
        /// Flag specifying whether this script is an img2img script
        /// </summary>
        /// <value>Flag specifying whether this script is an img2img script</value>
        [DataMember(Name = "is_img2img", EmitDefaultValue = true)]
        public bool IsImg2img { get; set; }

        /// <summary>
        /// List of script&#39;s arguments
        /// </summary>
        /// <value>List of script&#39;s arguments</value>
        [DataMember(Name = "args", IsRequired = true, EmitDefaultValue = true)]
        public List<ScriptArg> Args { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScriptInfo {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsAlwayson: ").Append(IsAlwayson).Append("\n");
            sb.Append("  IsImg2img: ").Append(IsImg2img).Append("\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
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
            return this.Equals(input as ScriptInfo);
        }

        /// <summary>
        /// Returns true if ScriptInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ScriptInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScriptInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsAlwayson == input.IsAlwayson ||
                    this.IsAlwayson.Equals(input.IsAlwayson)
                ) && 
                (
                    this.IsImg2img == input.IsImg2img ||
                    this.IsImg2img.Equals(input.IsImg2img)
                ) && 
                (
                    this.Args == input.Args ||
                    this.Args != null &&
                    input.Args != null &&
                    this.Args.SequenceEqual(input.Args)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsAlwayson.GetHashCode();
                hashCode = (hashCode * 59) + this.IsImg2img.GetHashCode();
                if (this.Args != null)
                {
                    hashCode = (hashCode * 59) + this.Args.GetHashCode();
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
