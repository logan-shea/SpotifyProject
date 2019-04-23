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
            return View();
        }
        private static SpotifyWebAPI _spotify;

        public static void Main(String[] args)
        {
            _spotify = new SpotifyWebAPI()
            {
                UseAuth = false,
            };
                FullTrack track = _spotify.GetTrack("3Hvu1pq89D4R0lyPBoujSv");
            Console.WriteLine(track.Name);
        }
    }
}