using Newtonsoft.Json;

namespace Gml.Web.Api.Core.Options
{
    public class ServerSettings
    {
        [JsonProperty(nameof(PolicyName))]
        public string PolicyName => Environment.GetEnvironmentVariable("PROJECT_POLICYNAME") 
                                    ?? throw new Exception("Policy name not found");

        [JsonProperty(nameof(ProjectName))]
        public string ProjectName => Environment.GetEnvironmentVariable("PROJECT_NAME") 
                                     ?? throw new Exception("Project name not found");

        [JsonProperty(nameof(SecurityKey))]
        public string SecurityKey => Environment.GetEnvironmentVariable("SECURITY_KEY") ?? string.Empty;

        public string ProjectVersion => "1.1.0"; // Статическая версия, если она не зависит от переменной среды

        public string[] SkinDomains { get; set; } = Array.Empty<string>(); // Оставляем как массив по умолчанию

        [JsonProperty(nameof(ProjectDescription))]
        public string? ProjectDescription => Environment.GetEnvironmentVariable("PROJECT_DESCRIPTION");

        public string? ProjectPath => Environment.GetEnvironmentVariable("PROJECT_PATH") ?? string.Empty;

        public string? TextureEndpoint => Environment.GetEnvironmentVariable("TEXTURE_ENDPOINT");
    }
}
