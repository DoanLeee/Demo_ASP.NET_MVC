using Microsoft.AspNetCore.Mvc;

namespace QuanLiSach.Controllers
{
	public class CartController:Controller
	{
		public ActionResult Index()
		{
			return View();
		}
		public ActionResult Checkout()
		{
			return View("~/Views/Checkout/Index.cshtml");
		}
	}
}
