// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The credential details
    /// </summary>
    public partial class CredentialDetails
    {
        /// <summary>
        /// Initializes a new instance of the CredentialDetails class.
        /// </summary>
        public CredentialDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CredentialDetails class.
        /// </summary>
        /// <param name="credentials">The credentials. Depends on the
        /// 'credentialType' value. See [Update Datasource
        /// Examples](/rest/api/power-bi/gateways/updatedatasource#examples).</param>
        /// <param name="credentialType">The credential type. Possible values
        /// include: 'Basic', 'Windows', 'Anonymous', 'OAuth2', 'Key'</param>
        /// <param name="encryptedConnection">User input for this attribute is
        /// currently ignored. Today, regardless of the provided value, we
        /// always try to establish an encrypted connection first but fall back
        /// to an unencrypted option in case of a failure. &lt;br/&gt;This will
        /// be fixed for the following data source types with the June 2019
        /// gateway release causing a value of Encrypted to try only an
        /// encrypted connection and NotEncrypted with an unencrypted
        /// connection and there would be no fallback behavior
        /// &lt;ul&gt;&lt;li&gt;Impala&lt;/li&gt;&lt;li&gt;MySql&lt;/li&gt;&lt;li&gt;DB2&lt;/li&gt;&lt;li&gt;Netezza&lt;/li&gt;&lt;li&gt;PostgreSQL&lt;/li&gt;&lt;li&gt;Sybase&lt;/li&gt;&lt;li&gt;Teradata&lt;/li&gt;&lt;li&gt;GoogleBigQuery&lt;/li&gt;&lt;li&gt;Amazon
        /// Redshift&lt;/li&gt;&lt;/ul&gt;. Possible values include:
        /// 'Encrypted', 'NotEncrypted'</param>
        /// <param name="encryptionAlgorithm">The encryption algorithm. For
        /// cloud datasource, use 'None'. For on-premises datasource, use
        /// gateway public key with 'RSA-OAEP' algorithm. Possible values
        /// include: 'None', 'RSA-OAEP'</param>
        /// <param name="privacyLevel">The privacy level. Relevant when
        /// combining data from multiple sources. Possible values include:
        /// 'None', 'Public', 'Organizational', 'Private'</param>
        /// <param name="useCallerAADIdentity">Should the caller's AAD identity
        /// be used for OAuth2 credentials configuration</param>
        /// <param name="useEndUserOAuth2Credentials">Should the end-user
        /// OAuth2 credentials be used for connecting to the datasource in
        /// DirectQuery mode. Only supported for Direct Query to SQL
        /// Azure.</param>
        public CredentialDetails(string credentials, CredentialType credentialType, EncryptedConnection encryptedConnection, EncryptionAlgorithm encryptionAlgorithm, PrivacyLevel privacyLevel, bool? useCallerAADIdentity = default(bool?), bool? useEndUserOAuth2Credentials = default(bool?))
        {
            Credentials = credentials;
            CredentialType = credentialType;
            EncryptedConnection = encryptedConnection;
            EncryptionAlgorithm = encryptionAlgorithm;
            PrivacyLevel = privacyLevel;
            UseCallerAADIdentity = useCallerAADIdentity;
            UseEndUserOAuth2Credentials = useEndUserOAuth2Credentials;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the credentials. Depends on the 'credentialType'
        /// value. See [Update Datasource
        /// Examples](/rest/api/power-bi/gateways/updatedatasource#examples).
        /// </summary>
        [JsonProperty(PropertyName = "credentials")]
        public string Credentials { get; set; }

        /// <summary>
        /// Gets or sets the credential type. Possible values include: 'Basic',
        /// 'Windows', 'Anonymous', 'OAuth2', 'Key'
        /// </summary>
        [JsonProperty(PropertyName = "credentialType")]
        public CredentialType CredentialType { get; set; }

        /// <summary>
        /// Gets or sets user input for this attribute is currently ignored.
        /// Today, regardless of the provided value, we always try to establish
        /// an encrypted connection first but fall back to an unencrypted
        /// option in case of a failure. &amp;lt;br/&amp;gt;This will be fixed
        /// for the following data source types with the June 2019 gateway
        /// release causing a value of Encrypted to try only an encrypted
        /// connection and NotEncrypted with an unencrypted connection and
        /// there would be no fallback behavior
        /// &amp;lt;ul&amp;gt;&amp;lt;li&amp;gt;Impala&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;MySql&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;DB2&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;Netezza&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;PostgreSQL&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;Sybase&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;Teradata&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;GoogleBigQuery&amp;lt;/li&amp;gt;&amp;lt;li&amp;gt;Amazon
        /// Redshift&amp;lt;/li&amp;gt;&amp;lt;/ul&amp;gt;. Possible values
        /// include: 'Encrypted', 'NotEncrypted'
        /// </summary>
        [JsonProperty(PropertyName = "encryptedConnection")]
        public EncryptedConnection EncryptedConnection { get; set; }

        /// <summary>
        /// Gets or sets the encryption algorithm. For cloud datasource, use
        /// 'None'. For on-premises datasource, use gateway public key with
        /// 'RSA-OAEP' algorithm. Possible values include: 'None', 'RSA-OAEP'
        /// </summary>
        [JsonProperty(PropertyName = "encryptionAlgorithm")]
        public EncryptionAlgorithm EncryptionAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets the privacy level. Relevant when combining data from
        /// multiple sources. Possible values include: 'None', 'Public',
        /// 'Organizational', 'Private'
        /// </summary>
        [JsonProperty(PropertyName = "privacyLevel")]
        public PrivacyLevel PrivacyLevel { get; set; }

        /// <summary>
        /// Gets or sets should the caller's AAD identity be used for OAuth2
        /// credentials configuration
        /// </summary>
        [JsonProperty(PropertyName = "useCallerAADIdentity")]
        public bool? UseCallerAADIdentity { get; set; }

        /// <summary>
        /// Gets or sets should the end-user OAuth2 credentials be used for
        /// connecting to the datasource in DirectQuery mode. Only supported
        /// for Direct Query to SQL Azure.
        /// </summary>
        [JsonProperty(PropertyName = "useEndUserOAuth2Credentials")]
        public bool? UseEndUserOAuth2Credentials { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Credentials == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Credentials");
            }
        }
    }
}
