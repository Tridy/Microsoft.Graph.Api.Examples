using System.Diagnostics;
using System.Text.Json.Serialization;

namespace PlannerQueries.Model
{
    [DebuggerDisplay("{Name}:{Id}")]
    public class Group
    {
        [JsonPropertyName("@odata.type")]
        public string DataType { get; set; }
        
        [JsonPropertyName("id")]
        public string Id { get; set; }
        public object deletedDateTime { get; set; }
        public object classification { get; set; }
        public DateTime createdDateTime { get; set; }
        public string[] creationOptions { get; set; }
        public string description { get; set; }

        [JsonPropertyName("displayName")]
        public string Name { get; set; }
        public object expirationDateTime { get; set; }
        public string[] groupTypes { get; set; }
        public object isAssignableToRole { get; set; }
        public string mail { get; set; }
        public bool mailEnabled { get; set; }
        public string mailNickname { get; set; }
        public string membershipRule { get; set; }
        public string membershipRuleProcessingState { get; set; }
        public string onPremisesDomainName { get; set; }
        public DateTime? onPremisesLastSyncDateTime { get; set; }
        public string onPremisesNetBiosName { get; set; }
        public string onPremisesSamAccountName { get; set; }
        public string onPremisesSecurityIdentifier { get; set; }
        public bool? onPremisesSyncEnabled { get; set; }
        public object preferredDataLocation { get; set; }
        public object preferredLanguage { get; set; }
        public string[] proxyAddresses { get; set; }
        public DateTime renewedDateTime { get; set; }
        public string[] resourceBehaviorOptions { get; set; }
        public string[] resourceProvisioningOptions { get; set; }
        public bool securityEnabled { get; set; }
        public string securityIdentifier { get; set; }
        public object theme { get; set; }
        public string visibility { get; set; }
        public object[] onPremisesProvisioningErrors { get; set; }
    }

}