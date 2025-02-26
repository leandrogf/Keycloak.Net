﻿using Newtonsoft.Json;

namespace Keycloak.ApiClient.Net.Models.Root
{
    public class LoginProtocolProviders
    {
        [JsonProperty("saml")]
        public HasOrder Saml { get; set; }

        [JsonProperty("openid-connect")]
        public HasOrder OpenIdConnect { get; set; }
    }
}