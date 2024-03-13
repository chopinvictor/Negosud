using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NegosudSite.Controllers
{
	using Microsoft.AspNetCore.Mvc;

	public class AuthController : Controller
	{
		// Action pour afficher la page de connexion
		public IActionResult Login()
		{
			return View();
		}

		// Action pour gérer le formulaire de connexion
		[HttpPost]
		public IActionResult Login(string username, string password)
		{
			// Vérification des informations d'identification, par exemple
			if (username == "utilisateur" && password == "motdepasse")
			{
				// Redirection vers une autre action dans le même contrôleur
				return RedirectToAction("Index", "Home");
			}
			else
			{
				// Redirection vers la même action (la page de connexion) avec un message d'erreur
				TempData["ErrorMessage"] = "Identifiants incorrects";
				return RedirectToAction("Login");
			}
		}
	}
}
