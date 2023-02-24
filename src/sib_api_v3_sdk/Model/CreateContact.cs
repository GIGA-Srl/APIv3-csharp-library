/* 
 * SendinBlue API
 *
 * SendinBlue provide a RESTFul API that can be used with any languages. With this API, you will be able to :   - Manage your campaigns and get the statistics   - Manage your contacts   - Send transactional Emails and SMS   - and much more...  You can download our wrappers at https://github.com/orgs/sendinblue  **Possible responses**   | Code | Message |   | :- -- -- -- -- -- --: | - -- -- -- -- -- -- |   | 200  | OK. Successful Request  |   | 201  | OK. Successful Creation |   | 202  | OK. Request accepted |   | 204  | OK. Successful Update/Deletion  |   | 400  | Error. Bad Request  |   | 401  | Error. Authentication Needed  |   | 402  | Error. Not enough credit, plan upgrade needed  |   | 403  | Error. Permission denied  |   | 404  | Error. Object does not exist |   | 405  | Error. Method not allowed  |   | 406  | Error. Not Acceptable  | 
 *
 * OpenAPI spec version: 3.0.0
 * Contact: contact@sendinblue.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = sib_api_v3_sdk.Client.SwaggerDateConverter;

namespace sib_api_v3_sdk.Model
{
    /// <summary>
    /// CreateContact
    /// </summary>
    [DataContract]
    public partial class CreateContact :  IEquatable<CreateContact>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContact" /> class.
        /// </summary>
        /// <param name="email">Email address of the user. Mandatory if &quot;SMS&quot; field is not passed in &quot;attributes&quot; parameter. Mobile Number in &quot;SMS&quot; field should be passed with proper country code. For example {&quot;SMS&quot;:&quot;+91xxxxxxxxxx&quot;} or {&quot;SMS&quot;:&quot;0091xxxxxxxxxx&quot;}.</param>
        /// <param name="attributes">Pass the set of attributes and their values. The attribute&#39;s parameter should be passed in capital letter while creating a contact. These attributes must be present in your SendinBlue account. For eg. {&quot;FNAME&quot;:&quot;Elly&quot;, &quot;LNAME&quot;:&quot;Roger&quot;}.</param>
        /// <param name="emailBlacklisted">Set this field to blacklist the contact for emails (emailBlacklisted &#x3D; true).</param>
        /// <param name="smsBlacklisted">Set this field to blacklist the contact for SMS (smsBlacklisted &#x3D; true).</param>
        /// <param name="listIds">Ids of the lists to add the contact to.</param>
        /// <param name="updateEnabled">Facilitate to update the existing contact in the same request (updateEnabled &#x3D; true) (default to false).</param>
        /// <param name="smtpBlacklistSender">transactional email forbidden sender for contact. Use only for email Contact ( only available if updateEnabled &#x3D; true ).</param>
        public CreateContact(string email = default(string), Object attributes = default(Object), bool? emailBlacklisted = default(bool?), bool? smsBlacklisted = default(bool?), List<long?> listIds = default(List<long?>), bool? updateEnabled = false, List<string> smtpBlacklistSender = default(List<string>))
        {
            this.Email = email;
            this.Attributes = attributes;
            this.EmailBlacklisted = emailBlacklisted;
            this.SmsBlacklisted = smsBlacklisted;
            this.ListIds = listIds;
            // use default value if no "updateEnabled" provided
            if (updateEnabled == null)
            {
                this.UpdateEnabled = false;
            }
            else
            {
                this.UpdateEnabled = updateEnabled;
            }
            this.SmtpBlacklistSender = smtpBlacklistSender;
        }
        
        /// <summary>
        /// Email address of the user. Mandatory if &quot;SMS&quot; field is not passed in &quot;attributes&quot; parameter. Mobile Number in &quot;SMS&quot; field should be passed with proper country code. For example {&quot;SMS&quot;:&quot;+91xxxxxxxxxx&quot;} or {&quot;SMS&quot;:&quot;0091xxxxxxxxxx&quot;}
        /// </summary>
        /// <value>Email address of the user. Mandatory if &quot;SMS&quot; field is not passed in &quot;attributes&quot; parameter. Mobile Number in &quot;SMS&quot; field should be passed with proper country code. For example {&quot;SMS&quot;:&quot;+91xxxxxxxxxx&quot;} or {&quot;SMS&quot;:&quot;0091xxxxxxxxxx&quot;}</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Pass the set of attributes and their values. The attribute&#39;s parameter should be passed in capital letter while creating a contact. These attributes must be present in your SendinBlue account. For eg. {&quot;FNAME&quot;:&quot;Elly&quot;, &quot;LNAME&quot;:&quot;Roger&quot;}
        /// </summary>
        /// <value>Pass the set of attributes and their values. The attribute&#39;s parameter should be passed in capital letter while creating a contact. These attributes must be present in your SendinBlue account. For eg. {&quot;FNAME&quot;:&quot;Elly&quot;, &quot;LNAME&quot;:&quot;Roger&quot;}</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Set this field to blacklist the contact for emails (emailBlacklisted &#x3D; true)
        /// </summary>
        /// <value>Set this field to blacklist the contact for emails (emailBlacklisted &#x3D; true)</value>
        [DataMember(Name="emailBlacklisted", EmitDefaultValue=false)]
        public bool? EmailBlacklisted { get; set; }

        /// <summary>
        /// Set this field to blacklist the contact for SMS (smsBlacklisted &#x3D; true)
        /// </summary>
        /// <value>Set this field to blacklist the contact for SMS (smsBlacklisted &#x3D; true)</value>
        [DataMember(Name="smsBlacklisted", EmitDefaultValue=false)]
        public bool? SmsBlacklisted { get; set; }

        /// <summary>
        /// Ids of the lists to add the contact to
        /// </summary>
        /// <value>Ids of the lists to add the contact to</value>
        [DataMember(Name="listIds", EmitDefaultValue=false)]
        public List<long?> ListIds { get; set; }

        /// <summary>
        /// Facilitate to update the existing contact in the same request (updateEnabled &#x3D; true)
        /// </summary>
        /// <value>Facilitate to update the existing contact in the same request (updateEnabled &#x3D; true)</value>
        [DataMember(Name="updateEnabled", EmitDefaultValue=false)]
        public bool? UpdateEnabled { get; set; }

        /// <summary>
        /// transactional email forbidden sender for contact. Use only for email Contact ( only available if updateEnabled &#x3D; true )
        /// </summary>
        /// <value>transactional email forbidden sender for contact. Use only for email Contact ( only available if updateEnabled &#x3D; true )</value>
        [DataMember(Name="smtpBlacklistSender", EmitDefaultValue=false)]
        public List<string> SmtpBlacklistSender { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateContact {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  EmailBlacklisted: ").Append(EmailBlacklisted).Append("\n");
            sb.Append("  SmsBlacklisted: ").Append(SmsBlacklisted).Append("\n");
            sb.Append("  ListIds: ").Append(ListIds).Append("\n");
            sb.Append("  UpdateEnabled: ").Append(UpdateEnabled).Append("\n");
            sb.Append("  SmtpBlacklistSender: ").Append(SmtpBlacklistSender).Append("\n");
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
            return this.Equals(input as CreateContact);
        }

        /// <summary>
        /// Returns true if CreateContact instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateContact input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.EmailBlacklisted == input.EmailBlacklisted ||
                    (this.EmailBlacklisted != null &&
                    this.EmailBlacklisted.Equals(input.EmailBlacklisted))
                ) && 
                (
                    this.SmsBlacklisted == input.SmsBlacklisted ||
                    (this.SmsBlacklisted != null &&
                    this.SmsBlacklisted.Equals(input.SmsBlacklisted))
                ) && 
                (
                    this.ListIds == input.ListIds ||
                    this.ListIds != null &&
                    this.ListIds.SequenceEqual(input.ListIds)
                ) && 
                (
                    this.UpdateEnabled == input.UpdateEnabled ||
                    (this.UpdateEnabled != null &&
                    this.UpdateEnabled.Equals(input.UpdateEnabled))
                ) && 
                (
                    this.SmtpBlacklistSender == input.SmtpBlacklistSender ||
                    this.SmtpBlacklistSender != null &&
                    this.SmtpBlacklistSender.SequenceEqual(input.SmtpBlacklistSender)
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.EmailBlacklisted != null)
                    hashCode = hashCode * 59 + this.EmailBlacklisted.GetHashCode();
                if (this.SmsBlacklisted != null)
                    hashCode = hashCode * 59 + this.SmsBlacklisted.GetHashCode();
                if (this.ListIds != null)
                    hashCode = hashCode * 59 + this.ListIds.GetHashCode();
                if (this.UpdateEnabled != null)
                    hashCode = hashCode * 59 + this.UpdateEnabled.GetHashCode();
                if (this.SmtpBlacklistSender != null)
                    hashCode = hashCode * 59 + this.SmtpBlacklistSender.GetHashCode();
                return hashCode;
            }
        }
    }

}
