using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;
using System.Threading.Tasks;

namespace kv_demo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //string keyVaultName = Environment.GetEnvironmentVariable("ad-test-keyvault");
            /////https://ad-test-keyvault.vault.azure.net/secrets/Hello/274562837c414d4d8d8d5ef542f67d5c
            //var kvUri = $"https://{keyVaultName}.vault.azure.net";
            var kvUri = "https://kv-az-demo-web.vault.azure.net/";
            var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());
            var secret_Value = await client.GetSecretAsync("Hello");
            Console.WriteLine($"Secret text - {secret_Value.Value.Value}!");
            Console.ReadKey();
        }
    }
}
