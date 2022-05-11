using System.Text.Json.Serialization;

namespace FBOL_API_v2.Model
{
    public class AuthenticateResponse
    {
        public string AuthToken { get; set; }

        [JsonIgnore] 
        public string RefreshToken { get; set; }
    }
}
