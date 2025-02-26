﻿using Newtonsoft.Json;

namespace Keycloak.ApiClient.Net.Models.Root
{
    public class ExportProviders
    {
        [JsonProperty("singleFile")]
        public HasOrder SingleFile { get; set; }

        [JsonProperty("dir")]
        public HasOrder Dir { get; set; }
    }
}