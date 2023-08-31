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
    /// ModulesApiModelsProgressResponse
    /// </summary>
    [DataContract(Name = "modules__api__models__ProgressResponse")]
    public partial class ModulesApiModelsProgressResponse : IEquatable<ModulesApiModelsProgressResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModulesApiModelsProgressResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModulesApiModelsProgressResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModulesApiModelsProgressResponse" /> class.
        /// </summary>
        /// <param name="progress">The progress with a range of 0 to 1 (required).</param>
        /// <param name="etaRelative">etaRelative (required).</param>
        /// <param name="state">The current state snapshot (required).</param>
        /// <param name="currentImage">The current image in base64 format. opts.show_progress_every_n_steps is required for this to work..</param>
        /// <param name="textinfo">Info text used by WebUI..</param>
        public ModulesApiModelsProgressResponse(decimal progress = default(decimal), decimal etaRelative = default(decimal), Object state = default(Object), string currentImage = default(string), string textinfo = default(string))
        {
            this.Progress = progress;
            this.EtaRelative = etaRelative;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for ModulesApiModelsProgressResponse and cannot be null");
            }
            this.State = state;
            this.CurrentImage = currentImage;
            this.Textinfo = textinfo;
        }

        /// <summary>
        /// The progress with a range of 0 to 1
        /// </summary>
        /// <value>The progress with a range of 0 to 1</value>
        [DataMember(Name = "progress", IsRequired = true, EmitDefaultValue = true)]
        public decimal Progress { get; set; }

        /// <summary>
        /// Gets or Sets EtaRelative
        /// </summary>
        [DataMember(Name = "eta_relative", IsRequired = true, EmitDefaultValue = true)]
        public decimal EtaRelative { get; set; }

        /// <summary>
        /// The current state snapshot
        /// </summary>
        /// <value>The current state snapshot</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public Object State { get; set; }

        /// <summary>
        /// The current image in base64 format. opts.show_progress_every_n_steps is required for this to work.
        /// </summary>
        /// <value>The current image in base64 format. opts.show_progress_every_n_steps is required for this to work.</value>
        [DataMember(Name = "current_image", EmitDefaultValue = false)]
        public string CurrentImage { get; set; }

        /// <summary>
        /// Info text used by WebUI.
        /// </summary>
        /// <value>Info text used by WebUI.</value>
        [DataMember(Name = "textinfo", EmitDefaultValue = false)]
        public string Textinfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModulesApiModelsProgressResponse {\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  EtaRelative: ").Append(EtaRelative).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  CurrentImage: ").Append(CurrentImage).Append("\n");
            sb.Append("  Textinfo: ").Append(Textinfo).Append("\n");
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
            return this.Equals(input as ModulesApiModelsProgressResponse);
        }

        /// <summary>
        /// Returns true if ModulesApiModelsProgressResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ModulesApiModelsProgressResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModulesApiModelsProgressResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Progress == input.Progress ||
                    this.Progress.Equals(input.Progress)
                ) && 
                (
                    this.EtaRelative == input.EtaRelative ||
                    this.EtaRelative.Equals(input.EtaRelative)
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.CurrentImage == input.CurrentImage ||
                    (this.CurrentImage != null &&
                    this.CurrentImage.Equals(input.CurrentImage))
                ) && 
                (
                    this.Textinfo == input.Textinfo ||
                    (this.Textinfo != null &&
                    this.Textinfo.Equals(input.Textinfo))
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
                hashCode = (hashCode * 59) + this.Progress.GetHashCode();
                hashCode = (hashCode * 59) + this.EtaRelative.GetHashCode();
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.CurrentImage != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentImage.GetHashCode();
                }
                if (this.Textinfo != null)
                {
                    hashCode = (hashCode * 59) + this.Textinfo.GetHashCode();
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
