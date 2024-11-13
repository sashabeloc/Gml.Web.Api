using Newtonsoft.Json;

namespace Gml.Web.Api.Core.Options
{
    public class ServerSettings
    {
        [JsonProperty(nameof(PolicyName))]
        public string PolicyName => Environment.GetEnvironmentVariable("PROJECT_POLICYNAME") 
                                    ?? string.Empty;

        [JsonProperty(nameof(ProjectName))]
        public string ProjectName => Environment.GetEnvironmentVariable("PROJECT_NAME") 
                                    ?? string.Empty;

        [JsonProperty(nameof(SecurityKey))]
        public string SecurityKey => Environment.GetEnvironmentVariable("SECURITY_KEY") ?? string.Empty;

        public string ProjectVersion => "1.1.0"; 

        public string[] SkinDomains { get; set; } = Array.Empty<string>();

        [JsonProperty(nameof(ProjectDescription))]
        public string? ProjectDescription => Environment.GetEnvironmentVariable("PROJECT_DESCRIPTION") ?? string.Empty;

        public string? ProjectPath => Environment.GetEnvironmentVariable("PROJECT_PATH") ?? string.Empty;

        public string? TextureEndpoint => Environment.GetEnvironmentVariable("TEXTURE_ENDPOINT");
    }
}
