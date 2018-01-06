using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spider.IdentityServer.Models;

namespace Spider.IdentityServer
{
    internal class Clients
    {
        public static IEnumerable<Client> Get(DomainSettings domainSettings)
        {
            return new List<Client> {
            // new Client
            //{
            //    ClientId = "apiClient",
            //    ClientName = "MVC Client",
            //    AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,

            //    ClientSecrets =
            //        {
            //            new Secret("secret".Sha256())
            //        },

            //    RedirectUris = { "http://localhost:64343/signin-oidc" },
            //    PostLogoutRedirectUris = { "http://localhost:64343/signout-callback-oidc" },

            //    AllowedScopes =
            //        {
            //            IdentityServerConstants.StandardScopes.OpenId,
            //            IdentityServerConstants.StandardScopes.Profile,
            //            "api1"
            //        },
            //    AllowOfflineAccess = true,
            //     AllowedCorsOrigins = new List<string>
            //    {
            //        "https://localhost:4200",
            //        "http://localhost:4200",
            //        "http://localhost:64343",
            //    },
            //},
            //new Client {
            //    ClientId = "oauthClient",
            //    ClientName = "Example Client Credentials Client Application",
            //    AllowedGrantTypes = GrantTypes.ClientCredentials,
            //    ClientSecrets = new List<Secret> {
            //        new Secret("superSecretPassword".Sha256())},
            //    AllowedScopes = new List<string> {"customAPI.read","api1"}
            //},
            new Client {
                ClientId = "angularclientidtokenonly",
                ClientName = "angularclientidtokenonly",
                AccessTokenType = AccessTokenType.Reference,
                AllowedGrantTypes = GrantTypes.Implicit,
                RequireConsent = false,
                AllowAccessTokensViaBrowser = true,
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                AllowedScopes = new List<string>
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    IdentityServerConstants.StandardScopes.Email,
                    "api1",
                    "role",
                    "customAPI.write"
                },
                RedirectUris = new List<string> {domainSettings.InvoicingWebClientUrl},
                PostLogoutRedirectUris = new List<string> {domainSettings.InvoicingWebClientUrl },
                AllowedCorsOrigins = new List<string>
                {
                    domainSettings.InvoicingWebClientUrl,
                    domainSettings.InvoicingApiUrl,
                },
            }
        };
        }
    }
}
