using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PokemonStore.DAL;
using PokemonStore.Models;

namespace PokemonStore.Controllers
{
    public class LandingController : Controller
    {
        //
        // GET: /Landing/

        private PokemonContext db = new PokemonContext();

        public ActionResult Index() {
            PokemonModel model = new PokemonModel();
            return View(model);
        }

    }
}
