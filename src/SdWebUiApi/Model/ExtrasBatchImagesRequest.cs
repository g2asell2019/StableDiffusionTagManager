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
    /// ExtrasBatchImagesRequest
    /// </summary>
    [DataContract(Name = "ExtrasBatchImagesRequest")]
    public partial class ExtrasBatchImagesRequest : IEquatable<ExtrasBatchImagesRequest>, IValidatableObject
    {
        /// <summary>
        /// Sets the resize mode: 0 to upscale by upscaling_resize amount, 1 to upscale up to upscaling_resize_h x upscaling_resize_w.
        /// </summary>
        /// <value>Sets the resize mode: 0 to upscale by upscaling_resize amount, 1 to upscale up to upscaling_resize_h x upscaling_resize_w.</value>
        public enum ResizeModeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1
        }


        /// <summary>
        /// Sets the resize mode: 0 to upscale by upscaling_resize amount, 1 to upscale up to upscaling_resize_h x upscaling_resize_w.
        /// </summary>
        /// <value>Sets the resize mode: 0 to upscale by upscaling_resize amount, 1 to upscale up to upscaling_resize_h x upscaling_resize_w.</value>
        [DataMember(Name = "resize_mode", EmitDefaultValue = false)]
        public ResizeModeEnum? ResizeMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtrasBatchImagesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExtrasBatchImagesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtrasBatchImagesRequest" /> class.
        /// </summary>
        /// <param name="resizeMode">Sets the resize mode: 0 to upscale by upscaling_resize amount, 1 to upscale up to upscaling_resize_h x upscaling_resize_w. (default to ResizeModeEnum.NUMBER_0).</param>
        /// <param name="showExtrasResults">Should the backend return the generated image? (default to true).</param>
        /// <param name="gfpganVisibility">Sets the visibility of GFPGAN, values should be between 0 and 1. (default to 0M).</param>
        /// <param name="codeformerVisibility">Sets the visibility of CodeFormer, values should be between 0 and 1. (default to 0M).</param>
        /// <param name="codeformerWeight">Sets the weight of CodeFormer, values should be between 0 and 1. (default to 0M).</param>
        /// <param name="upscalingResize">By how much to upscale the image, only used when resize_mode&#x3D;0. (default to 2M).</param>
        /// <param name="upscalingResizeW">Target width for the upscaler to hit. Only used when resize_mode&#x3D;1. (default to 512).</param>
        /// <param name="upscalingResizeH">Target height for the upscaler to hit. Only used when resize_mode&#x3D;1. (default to 512).</param>
        /// <param name="upscalingCrop">Should the upscaler crop the image to fit in the chosen size? (default to true).</param>
        /// <param name="upscaler1">The name of the main upscaler to use, it has to be one of this list:  (default to &quot;None&quot;).</param>
        /// <param name="upscaler2">The name of the secondary upscaler to use, it has to be one of this list:  (default to &quot;None&quot;).</param>
        /// <param name="extrasUpscaler2Visibility">Sets the visibility of secondary upscaler, values should be between 0 and 1. (default to 0M).</param>
        /// <param name="upscaleFirst">Should the upscaler run before restoring faces? (default to false).</param>
        /// <param name="imageList">List of images to work on. Must be Base64 strings (required).</param>
        public ExtrasBatchImagesRequest(ResizeModeEnum? resizeMode = ResizeModeEnum.NUMBER_0, bool showExtrasResults = true, decimal gfpganVisibility = 0M, decimal codeformerVisibility = 0M, decimal codeformerWeight = 0M, decimal upscalingResize = 2M, int upscalingResizeW = 512, int upscalingResizeH = 512, bool upscalingCrop = true, string upscaler1 = @"None", string upscaler2 = @"None", decimal extrasUpscaler2Visibility = 0M, bool upscaleFirst = false, List<FileData> imageList = default(List<FileData>))
        {
            // to ensure "imageList" is required (not null)
            if (imageList == null)
            {
                throw new ArgumentNullException("imageList is a required property for ExtrasBatchImagesRequest and cannot be null");
            }
            this.ImageList = imageList;
            this.ResizeMode = resizeMode;
            this.ShowExtrasResults = showExtrasResults;
            this.GfpganVisibility = gfpganVisibility;
            this.CodeformerVisibility = codeformerVisibility;
            this.CodeformerWeight = codeformerWeight;
            this.UpscalingResize = upscalingResize;
            this.UpscalingResizeW = upscalingResizeW;
            this.UpscalingResizeH = upscalingResizeH;
            this.UpscalingCrop = upscalingCrop;
            // use default value if no "upscaler1" provided
            this.Upscaler1 = upscaler1 ?? @"None";
            // use default value if no "upscaler2" provided
            this.Upscaler2 = upscaler2 ?? @"None";
            this.ExtrasUpscaler2Visibility = extrasUpscaler2Visibility;
            this.UpscaleFirst = upscaleFirst;
        }

        /// <summary>
        /// Should the backend return the generated image?
        /// </summary>
        /// <value>Should the backend return the generated image?</value>
        [DataMember(Name = "show_extras_results", EmitDefaultValue = true)]
        public bool ShowExtrasResults { get; set; }

        /// <summary>
        /// Sets the visibility of GFPGAN, values should be between 0 and 1.
        /// </summary>
        /// <value>Sets the visibility of GFPGAN, values should be between 0 and 1.</value>
        [DataMember(Name = "gfpgan_visibility", EmitDefaultValue = false)]
        public decimal GfpganVisibility { get; set; }

        /// <summary>
        /// Sets the visibility of CodeFormer, values should be between 0 and 1.
        /// </summary>
        /// <value>Sets the visibility of CodeFormer, values should be between 0 and 1.</value>
        [DataMember(Name = "codeformer_visibility", EmitDefaultValue = false)]
        public decimal CodeformerVisibility { get; set; }

        /// <summary>
        /// Sets the weight of CodeFormer, values should be between 0 and 1.
        /// </summary>
        /// <value>Sets the weight of CodeFormer, values should be between 0 and 1.</value>
        [DataMember(Name = "codeformer_weight", EmitDefaultValue = false)]
        public decimal CodeformerWeight { get; set; }

        /// <summary>
        /// By how much to upscale the image, only used when resize_mode&#x3D;0.
        /// </summary>
        /// <value>By how much to upscale the image, only used when resize_mode&#x3D;0.</value>
        [DataMember(Name = "upscaling_resize", EmitDefaultValue = false)]
        public decimal UpscalingResize { get; set; }

        /// <summary>
        /// Target width for the upscaler to hit. Only used when resize_mode&#x3D;1.
        /// </summary>
        /// <value>Target width for the upscaler to hit. Only used when resize_mode&#x3D;1.</value>
        [DataMember(Name = "upscaling_resize_w", EmitDefaultValue = false)]
        public int UpscalingResizeW { get; set; }

        /// <summary>
        /// Target height for the upscaler to hit. Only used when resize_mode&#x3D;1.
        /// </summary>
        /// <value>Target height for the upscaler to hit. Only used when resize_mode&#x3D;1.</value>
        [DataMember(Name = "upscaling_resize_h", EmitDefaultValue = false)]
        public int UpscalingResizeH { get; set; }

        /// <summary>
        /// Should the upscaler crop the image to fit in the chosen size?
        /// </summary>
        /// <value>Should the upscaler crop the image to fit in the chosen size?</value>
        [DataMember(Name = "upscaling_crop", EmitDefaultValue = true)]
        public bool UpscalingCrop { get; set; }

        /// <summary>
        /// The name of the main upscaler to use, it has to be one of this list: 
        /// </summary>
        /// <value>The name of the main upscaler to use, it has to be one of this list: </value>
        [DataMember(Name = "upscaler_1", EmitDefaultValue = false)]
        public string Upscaler1 { get; set; }

        /// <summary>
        /// The name of the secondary upscaler to use, it has to be one of this list: 
        /// </summary>
        /// <value>The name of the secondary upscaler to use, it has to be one of this list: </value>
        [DataMember(Name = "upscaler_2", EmitDefaultValue = false)]
        public string Upscaler2 { get; set; }

        /// <summary>
        /// Sets the visibility of secondary upscaler, values should be between 0 and 1.
        /// </summary>
        /// <value>Sets the visibility of secondary upscaler, values should be between 0 and 1.</value>
        [DataMember(Name = "extras_upscaler_2_visibility", EmitDefaultValue = false)]
        public decimal ExtrasUpscaler2Visibility { get; set; }

        /// <summary>
        /// Should the upscaler run before restoring faces?
        /// </summary>
        /// <value>Should the upscaler run before restoring faces?</value>
        [DataMember(Name = "upscale_first", EmitDefaultValue = true)]
        public bool UpscaleFirst { get; set; }

        /// <summary>
        /// List of images to work on. Must be Base64 strings
        /// </summary>
        /// <value>List of images to work on. Must be Base64 strings</value>
        [DataMember(Name = "imageList", IsRequired = true, EmitDefaultValue = true)]
        public List<FileData> ImageList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExtrasBatchImagesRequest {\n");
            sb.Append("  ResizeMode: ").Append(ResizeMode).Append("\n");
            sb.Append("  ShowExtrasResults: ").Append(ShowExtrasResults).Append("\n");
            sb.Append("  GfpganVisibility: ").Append(GfpganVisibility).Append("\n");
            sb.Append("  CodeformerVisibility: ").Append(CodeformerVisibility).Append("\n");
            sb.Append("  CodeformerWeight: ").Append(CodeformerWeight).Append("\n");
            sb.Append("  UpscalingResize: ").Append(UpscalingResize).Append("\n");
            sb.Append("  UpscalingResizeW: ").Append(UpscalingResizeW).Append("\n");
            sb.Append("  UpscalingResizeH: ").Append(UpscalingResizeH).Append("\n");
            sb.Append("  UpscalingCrop: ").Append(UpscalingCrop).Append("\n");
            sb.Append("  Upscaler1: ").Append(Upscaler1).Append("\n");
            sb.Append("  Upscaler2: ").Append(Upscaler2).Append("\n");
            sb.Append("  ExtrasUpscaler2Visibility: ").Append(ExtrasUpscaler2Visibility).Append("\n");
            sb.Append("  UpscaleFirst: ").Append(UpscaleFirst).Append("\n");
            sb.Append("  ImageList: ").Append(ImageList).Append("\n");
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
            return this.Equals(input as ExtrasBatchImagesRequest);
        }

        /// <summary>
        /// Returns true if ExtrasBatchImagesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtrasBatchImagesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtrasBatchImagesRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ResizeMode == input.ResizeMode ||
                    this.ResizeMode.Equals(input.ResizeMode)
                ) && 
                (
                    this.ShowExtrasResults == input.ShowExtrasResults ||
                    this.ShowExtrasResults.Equals(input.ShowExtrasResults)
                ) && 
                (
                    this.GfpganVisibility == input.GfpganVisibility ||
                    this.GfpganVisibility.Equals(input.GfpganVisibility)
                ) && 
                (
                    this.CodeformerVisibility == input.CodeformerVisibility ||
                    this.CodeformerVisibility.Equals(input.CodeformerVisibility)
                ) && 
                (
                    this.CodeformerWeight == input.CodeformerWeight ||
                    this.CodeformerWeight.Equals(input.CodeformerWeight)
                ) && 
                (
                    this.UpscalingResize == input.UpscalingResize ||
                    this.UpscalingResize.Equals(input.UpscalingResize)
                ) && 
                (
                    this.UpscalingResizeW == input.UpscalingResizeW ||
                    this.UpscalingResizeW.Equals(input.UpscalingResizeW)
                ) && 
                (
                    this.UpscalingResizeH == input.UpscalingResizeH ||
                    this.UpscalingResizeH.Equals(input.UpscalingResizeH)
                ) && 
                (
                    this.UpscalingCrop == input.UpscalingCrop ||
                    this.UpscalingCrop.Equals(input.UpscalingCrop)
                ) && 
                (
                    this.Upscaler1 == input.Upscaler1 ||
                    (this.Upscaler1 != null &&
                    this.Upscaler1.Equals(input.Upscaler1))
                ) && 
                (
                    this.Upscaler2 == input.Upscaler2 ||
                    (this.Upscaler2 != null &&
                    this.Upscaler2.Equals(input.Upscaler2))
                ) && 
                (
                    this.ExtrasUpscaler2Visibility == input.ExtrasUpscaler2Visibility ||
                    this.ExtrasUpscaler2Visibility.Equals(input.ExtrasUpscaler2Visibility)
                ) && 
                (
                    this.UpscaleFirst == input.UpscaleFirst ||
                    this.UpscaleFirst.Equals(input.UpscaleFirst)
                ) && 
                (
                    this.ImageList == input.ImageList ||
                    this.ImageList != null &&
                    input.ImageList != null &&
                    this.ImageList.SequenceEqual(input.ImageList)
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
                hashCode = (hashCode * 59) + this.ResizeMode.GetHashCode();
                hashCode = (hashCode * 59) + this.ShowExtrasResults.GetHashCode();
                hashCode = (hashCode * 59) + this.GfpganVisibility.GetHashCode();
                hashCode = (hashCode * 59) + this.CodeformerVisibility.GetHashCode();
                hashCode = (hashCode * 59) + this.CodeformerWeight.GetHashCode();
                hashCode = (hashCode * 59) + this.UpscalingResize.GetHashCode();
                hashCode = (hashCode * 59) + this.UpscalingResizeW.GetHashCode();
                hashCode = (hashCode * 59) + this.UpscalingResizeH.GetHashCode();
                hashCode = (hashCode * 59) + this.UpscalingCrop.GetHashCode();
                if (this.Upscaler1 != null)
                {
                    hashCode = (hashCode * 59) + this.Upscaler1.GetHashCode();
                }
                if (this.Upscaler2 != null)
                {
                    hashCode = (hashCode * 59) + this.Upscaler2.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExtrasUpscaler2Visibility.GetHashCode();
                hashCode = (hashCode * 59) + this.UpscaleFirst.GetHashCode();
                if (this.ImageList != null)
                {
                    hashCode = (hashCode * 59) + this.ImageList.GetHashCode();
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
            // GfpganVisibility (decimal) maximum
            if (this.GfpganVisibility > (decimal)1.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GfpganVisibility, must be a value less than or equal to 1.0.", new [] { "GfpganVisibility" });
            }

            // GfpganVisibility (decimal) minimum
            if (this.GfpganVisibility < (decimal)0.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GfpganVisibility, must be a value greater than or equal to 0.0.", new [] { "GfpganVisibility" });
            }

            // CodeformerVisibility (decimal) maximum
            if (this.CodeformerVisibility > (decimal)1.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CodeformerVisibility, must be a value less than or equal to 1.0.", new [] { "CodeformerVisibility" });
            }

            // CodeformerVisibility (decimal) minimum
            if (this.CodeformerVisibility < (decimal)0.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CodeformerVisibility, must be a value greater than or equal to 0.0.", new [] { "CodeformerVisibility" });
            }

            // CodeformerWeight (decimal) maximum
            if (this.CodeformerWeight > (decimal)1.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CodeformerWeight, must be a value less than or equal to 1.0.", new [] { "CodeformerWeight" });
            }

            // CodeformerWeight (decimal) minimum
            if (this.CodeformerWeight < (decimal)0.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CodeformerWeight, must be a value greater than or equal to 0.0.", new [] { "CodeformerWeight" });
            }

            // UpscalingResize (decimal) maximum
            if (this.UpscalingResize > (decimal)8.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UpscalingResize, must be a value less than or equal to 8.0.", new [] { "UpscalingResize" });
            }

            // UpscalingResize (decimal) minimum
            if (this.UpscalingResize < (decimal)1.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UpscalingResize, must be a value greater than or equal to 1.0.", new [] { "UpscalingResize" });
            }

            // UpscalingResizeW (int) minimum
            if (this.UpscalingResizeW < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UpscalingResizeW, must be a value greater than or equal to 1.", new [] { "UpscalingResizeW" });
            }

            // UpscalingResizeH (int) minimum
            if (this.UpscalingResizeH < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UpscalingResizeH, must be a value greater than or equal to 1.", new [] { "UpscalingResizeH" });
            }

            // ExtrasUpscaler2Visibility (decimal) maximum
            if (this.ExtrasUpscaler2Visibility > (decimal)1.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtrasUpscaler2Visibility, must be a value less than or equal to 1.0.", new [] { "ExtrasUpscaler2Visibility" });
            }

            // ExtrasUpscaler2Visibility (decimal) minimum
            if (this.ExtrasUpscaler2Visibility < (decimal)0.0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExtrasUpscaler2Visibility, must be a value greater than or equal to 0.0.", new [] { "ExtrasUpscaler2Visibility" });
            }

            yield break;
        }
    }

}
