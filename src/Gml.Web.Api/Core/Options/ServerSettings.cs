using Newtonsoft.Json;

namespace Gml.Web.Api.Core.Options
{
    public class ServerSettings
    {
        [JsonProperty(nameof(PolicyName))] 
        public string PolicyName { get; set; }

        [JsonProperty(nameof(ProjectName))] 
        public string ProjectName { get; set; }

        [JsonProperty(nameof(SecurityKey))] 
        public string SecurityKey { get; set; }

        public string ProjectVersion { get; set; }
        public string[] SkinDomains { get; set; } = Array.Empty<string>();

        [JsonProperty(nameof(ProjectDescription))]
        public string? ProjectDescription { get; set; }

        public string? ProjectPath { get; set; }
        public string? TextureEndpoint { get; set; }
    }

    public static class ServerSettingsProvider
    {
        public static ServerSettings GetServerSettings()
        {
            var projectName = Environment.GetEnvironmentVariable("PROJECT_NAME")
                              ?? throw new Exception("Project name not found");

            var projectDescription = Environment.GetEnvironmentVariable("PROJECT_DESCRIPTION");

            var policyName = Environment.GetEnvironmentVariable("PROJECT_POLICYNAME")
                             ?? throw new Exception("Policy name not found");

            var projectPath = Environment.GetEnvironmentVariable("PROJECT_PATH")
                              ?? string.Empty;

            var securityKey = Environment.GetEnvironmentVariable("SECURITY_KEY")
                              ?? string.Empty;

            return new ServerSettings
            {
                ProjectDescription = projectDescription,
                ProjectName = projectName,
                PolicyName = policyName,
                ProjectVersion = "1.1.0",
                SecurityKey = securityKey,
                ProjectPath = projectPath
            };
        }
    }
}
