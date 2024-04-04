using Microsoft.AspNetCore.Mvc;
using NegosudSite.Models;


namespace NegosudSite.Controllers
{
	public class PanierController : Controller
	{

        //public IActionResult AjouterAuPanier(string nom, int nombre)
        //{
        //    List<Article> panier;
        //    if (Request.Cookies.ContainsKey("Panier"))
        //    {
        //        panier = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Article>>(Request.Cookies["Panier"]);
        //    }
        //    else
        //    {
        //        panier = new List<Article>();
        //    }

        //    panier.Add(new Article { Nom = nom, Nombre = nombre });

        //    Response.Cookies.Append("Panier", Newtonsoft.Json.JsonConvert.SerializeObject(panier));

        //    // Redirection vers l'action "Index" avec le panier
        //    return RedirectToAction("Index", new { panier = panier });
        //}


        public IActionResult Index()
		{
			//List<Article> panier;
			//if (Request.Cookies.ContainsKey("Panier"))
			//{
			//	panier = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Article>>(Request.Cookies["Panier"]);
			//}
			//else
			//{
			//	panier = new List<Article>();
			//}
			return View();
		}

	}
}
