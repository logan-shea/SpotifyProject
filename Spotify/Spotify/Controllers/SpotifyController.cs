using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpotifyAPI.Web; 
using SpotifyAPI.Web.Auth; 
using SpotifyAPI.Web.Enums; 
using SpotifyAPI.Web.Models;

namespace Spotify.Controllers
{
    public class SpotifyController : Controller
    {
        // GET: Spotify
        public ActionResult Index()
        {
            ClientCredentialsAuth client = new ClientCredentialsAuth();
            client.ClientId = "559a2c8e37d946d782cc29bb373a63f0";
            client.ClientSecret = "23915a1a8a5e406ea1df5bc8baec36e4";
            Token token = new Token();
            


            return View();
        }
       
    }
}