﻿using Newtonsoft.Json;

namespace Keycloak.ApiClient.Net.Models.Clients
{
    public class AccessTokenCertConf
    {
        [JsonProperty("x5t#S256")]
        public string X5Ts256 { get; set; }
    }
}
