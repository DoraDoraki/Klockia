
using Klockia.Models;
using Microsoft.AspNet.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Klockia.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return View(db.Types.ToList());
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
        public ActionResult Products()
        {
            return View();

        }

        public ActionResult ByCategory(int id)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            return View(db.Product.Where(p => p.ProductTypeId == id).ToList());
        }



        [HttpPost]
        [AllowAnonymous]
        public ActionResult Checkout(string cart)
        {
            ApplicationDbContext db = new ApplicationDbContext();



            List<OrderDetail> orderDetails = JsonConvert.DeserializeObject<List<OrderDetail>>(cart);

            List<ShopingCartViewModel> viewModel = new List<ShopingCartViewModel>(); //

            decimal totalPrice = 0;

            foreach (var item in orderDetails)
            {
                Product currentProduct = db.Product.Find(item.ProductId); //current Product är denna product som vi klickar på.

                ShopingCartViewModel currentCartItem = new ShopingCartViewModel();
                currentCartItem.Product = currentProduct;
                currentCartItem.Amount = item.Amount;
                currentCartItem.TotalPrice = item.Amount * currentProduct.Price;

                totalPrice += currentCartItem.TotalPrice;

                viewModel.Add(currentCartItem);
            }

            return View(viewModel);
        }
        [HttpPost]
        [Authorize]
        public ActionResult CreateOrder(string cart)
        {
            ApplicationDbContext db = new ApplicationDbContext();

            //Här skapar vi en lista med det vi vill ha från vå
            List<OrderDetail> orderDetails = JsonConvert.DeserializeObject<List<OrderDetail>>(cart);


            Order newOrder = new Order();
            newOrder.OrderDate = DateTime.Now;
            newOrder.CustomerId = User.Identity.GetUserId();

            db.Order.Add(newOrder);
            db.SaveChanges();

            foreach (var item in orderDetails)
            {
                OrderDetail newOrderDetail = new OrderDetail();
                newOrderDetail.OrderId = newOrder.OrderId;
                newOrderDetail.ProductId = item.ProductId;
                newOrderDetail.Amount = item.Amount;

                db.OrderDetails.Add(newOrderDetail);
            }

            db.SaveChanges();

            return View("Thankyou");
        }
    }
}












