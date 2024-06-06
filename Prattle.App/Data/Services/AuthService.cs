using Prattle.App.Data.Interfaces;
using Prattle.App.Models;
using System.Text.Json;

namespace Prattle.App.Data.Services
{
    public class AuthService : IAuthService
    {

        private readonly HttpClient _httpClient;
        private readonly string _url;
        private readonly JsonSerializerOptions _jsonSerializerOptions;
        public AuthService() {

            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
            _httpClient = new HttpClient(handler);
            //_url = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5163" : "http://localhost:5163";
            _url = "https://10.130.54.72:4433";

            _jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
        }
        public Task<UserDTO> Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
