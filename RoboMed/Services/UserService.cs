using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using RoboMed.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RoboMed.Services
{
    public class UserService
    {
        /// <summary>
        /// A method used to authorize a user for Robomed API. Use the returned value in the Authorization header
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        /// <returns>Returns a bearer token (jwt) if the credentials are correct or null if they are not</returns>
        public async Task<string> Authenticate(string email, string pass)
        {
            var request = new AuthenticateRequest(email, pass);
            var client = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(request), null, "application/json");
            var result = await client.PostAsync("https://robomed.ro/api/api/User/Authenticate", content);

            string token = null;
            if(result.StatusCode == System.Net.HttpStatusCode.OK)
                token = await result.Content.ReadAsStringAsync();

            return token;
        }
    }
}