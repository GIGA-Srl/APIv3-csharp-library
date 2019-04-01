/* 
 * SendinBlue API
 *
 * SendinBlue provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/sendinblue  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  | 
 *
 * OpenAPI spec version: 3.0.0
 * Contact: contact@sendinblue.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = sib_api_v3_sdk.Client.SwaggerDateConverter;

namespace sib_api_v3_sdk.Model
{
    /// <summary>
    /// GetSendersListIps
    /// </summary>
    [DataContract]
    public partial class GetSendersListIps :  IEquatable<GetSendersListIps>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSendersListIps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSendersListIps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSendersListIps" /> class.
        /// </summary>
        /// <param name="ip">Dedicated IP available in your account (required).</param>
        /// <param name="domain">Domain of the IP (required).</param>
        /// <param name="weight">Weight of the IP for this sender (required).</param>
        public GetSendersListIps(string ip = default(string), string domain = default(string), long? weight = default(long?))
        {
            // to ensure "ip" is required (not null)
            if (ip == null)
            {
                throw new InvalidDataException("ip is a required property for GetSendersListIps and cannot be null");
            }
            else
            {
                this.Ip = ip;
            }
            // to ensure "domain" is required (not null)
            if (domain == null)
            {
                throw new InvalidDataException("domain is a required property for GetSendersListIps and cannot be null");
            }
            else
            {
                this.Domain = domain;
            }
            // to ensure "weight" is required (not null)
            if (weight == null)
            {
                throw new InvalidDataException("weight is a required property for GetSendersListIps and cannot be null");
            }
            else
            {
                this.Weight = weight;
            }
        }
        
        /// <summary>
        /// Dedicated IP available in your account
        /// </summary>
        /// <value>Dedicated IP available in your account</value>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }

        /// <summary>
        /// Domain of the IP
        /// </summary>
        /// <value>Domain of the IP</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Weight of the IP for this sender
        /// </summary>
        /// <value>Weight of the IP for this sender</value>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public long? Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetSendersListIps {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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
            return this.Equals(input as GetSendersListIps);
        }

        /// <summary>
        /// Returns true if GetSendersListIps instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSendersListIps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSendersListIps input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
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
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
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