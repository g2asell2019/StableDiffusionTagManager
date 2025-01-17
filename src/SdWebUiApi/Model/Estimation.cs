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
    /// Estimation
    /// </summary>
    [DataContract(Name = "Estimation")]
    public partial class Estimation : IEquatable<Estimation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Estimation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Estimation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Estimation" /> class.
        /// </summary>
        /// <param name="msg">msg (default to &quot;estimation&quot;).</param>
        /// <param name="rank">rank.</param>
        /// <param name="queueSize">queueSize (required).</param>
        /// <param name="avgEventProcessTime">avgEventProcessTime.</param>
        /// <param name="avgEventConcurrentProcessTime">avgEventConcurrentProcessTime.</param>
        /// <param name="rankEta">rankEta.</param>
        /// <param name="queueEta">queueEta (required).</param>
        public Estimation(string msg = @"estimation", int rank = default(int), int queueSize = default(int), decimal avgEventProcessTime = default(decimal), decimal avgEventConcurrentProcessTime = default(decimal), decimal rankEta = default(decimal), decimal queueEta = default(decimal))
        {
            this.QueueSize = queueSize;
            this.QueueEta = queueEta;
            // use default value if no "msg" provided
            this.Msg = msg ?? @"estimation";
            this.Rank = rank;
            this.AvgEventProcessTime = avgEventProcessTime;
            this.AvgEventConcurrentProcessTime = avgEventConcurrentProcessTime;
            this.RankEta = rankEta;
        }

        /// <summary>
        /// Gets or Sets Msg
        /// </summary>
        [DataMember(Name = "msg", EmitDefaultValue = false)]
        public string Msg { get; set; }

        /// <summary>
        /// Gets or Sets Rank
        /// </summary>
        [DataMember(Name = "rank", EmitDefaultValue = false)]
        public int Rank { get; set; }

        /// <summary>
        /// Gets or Sets QueueSize
        /// </summary>
        [DataMember(Name = "queue_size", IsRequired = true, EmitDefaultValue = true)]
        public int QueueSize { get; set; }

        /// <summary>
        /// Gets or Sets AvgEventProcessTime
        /// </summary>
        [DataMember(Name = "avg_event_process_time", EmitDefaultValue = false)]
        public decimal AvgEventProcessTime { get; set; }

        /// <summary>
        /// Gets or Sets AvgEventConcurrentProcessTime
        /// </summary>
        [DataMember(Name = "avg_event_concurrent_process_time", EmitDefaultValue = false)]
        public decimal AvgEventConcurrentProcessTime { get; set; }

        /// <summary>
        /// Gets or Sets RankEta
        /// </summary>
        [DataMember(Name = "rank_eta", EmitDefaultValue = false)]
        public decimal RankEta { get; set; }

        /// <summary>
        /// Gets or Sets QueueEta
        /// </summary>
        [DataMember(Name = "queue_eta", IsRequired = true, EmitDefaultValue = true)]
        public decimal QueueEta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Estimation {\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  QueueSize: ").Append(QueueSize).Append("\n");
            sb.Append("  AvgEventProcessTime: ").Append(AvgEventProcessTime).Append("\n");
            sb.Append("  AvgEventConcurrentProcessTime: ").Append(AvgEventConcurrentProcessTime).Append("\n");
            sb.Append("  RankEta: ").Append(RankEta).Append("\n");
            sb.Append("  QueueEta: ").Append(QueueEta).Append("\n");
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
            return this.Equals(input as Estimation);
        }

        /// <summary>
        /// Returns true if Estimation instances are equal
        /// </summary>
        /// <param name="input">Instance of Estimation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Estimation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Msg == input.Msg ||
                    (this.Msg != null &&
                    this.Msg.Equals(input.Msg))
                ) && 
                (
                    this.Rank == input.Rank ||
                    this.Rank.Equals(input.Rank)
                ) && 
                (
                    this.QueueSize == input.QueueSize ||
                    this.QueueSize.Equals(input.QueueSize)
                ) && 
                (
                    this.AvgEventProcessTime == input.AvgEventProcessTime ||
                    this.AvgEventProcessTime.Equals(input.AvgEventProcessTime)
                ) && 
                (
                    this.AvgEventConcurrentProcessTime == input.AvgEventConcurrentProcessTime ||
                    this.AvgEventConcurrentProcessTime.Equals(input.AvgEventConcurrentProcessTime)
                ) && 
                (
                    this.RankEta == input.RankEta ||
                    this.RankEta.Equals(input.RankEta)
                ) && 
                (
                    this.QueueEta == input.QueueEta ||
                    this.QueueEta.Equals(input.QueueEta)
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
                if (this.Msg != null)
                {
                    hashCode = (hashCode * 59) + this.Msg.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Rank.GetHashCode();
                hashCode = (hashCode * 59) + this.QueueSize.GetHashCode();
                hashCode = (hashCode * 59) + this.AvgEventProcessTime.GetHashCode();
                hashCode = (hashCode * 59) + this.AvgEventConcurrentProcessTime.GetHashCode();
                hashCode = (hashCode * 59) + this.RankEta.GetHashCode();
                hashCode = (hashCode * 59) + this.QueueEta.GetHashCode();
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
