using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using SpotifyAPI.Web.Enums;
using SpotifyAPI.Web.Models;
using SpotifyAPI.Web.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Spotify.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            SpotifyWebAPI api = new SpotifyWebAPI();
            List<String> artists = new List<string>();
            ClientCredentialsAuth client = new ClientCredentialsAuth();
            client.ClientId = "559a2c8e37d946d782cc29bb373a63f0";
            client.ClientSecret = "23915a1a8a5e406ea1df5bc8baec36e4";
            Token token = client.DoAuth();
            
            api.AccessToken = token.AccessToken;
            api.UseAuth = true;
            api.UseAutoRetry = true;
            api.TokenType = "Bearer";
            
            FullArtist homie = api.GetArtist("1KpCi9BOfviCVhmpI4G2sY");
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}