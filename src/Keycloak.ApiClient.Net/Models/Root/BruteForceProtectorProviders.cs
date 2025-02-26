﻿using Newtonsoft.Json;

namespace Keycloak.ApiClient.Net.Models.Root
{
    public class BruteForceProtectorProviders
    {
        [JsonProperty("default-brute-force-detector")]
        public HasOrder DefaultBruteForceDetector { get; set; }
    }
}