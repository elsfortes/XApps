using XappsWeb.Models;
using XappsWeb.ViewModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace XappsWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? page)
        {
            WebClient web = new WebClient();
            int pgaux = 1;
            String s;
            JObject jObject;
            IList<JObject> jList;
            IndexViewModel index = new IndexViewModel();

            ViewBag.Title = "Home Page";

            try
            {
                if (page != null)
                    pgaux = (int)page;

                s = web.DownloadString(string.Format("https://reqres.in/api/users?page={0}", page));
                jObject = JObject.Parse(s);

                index.Page = (int)jObject["page"];
                index.Per_page = (int)jObject["per_page"];
                index.Total = (int)jObject["total"];
                index.Total_pages = (int)jObject["total_pages"];

                jList = jObject["data"].Select(t => (JObject)t).ToList<JObject>();
                index.Users = new List<User>();

                foreach (JObject obj in jList)
                {
                    User u = new Models.User((int)obj["id"], (string)obj["first_name"], (string)obj["last_name"], (string)obj["avatar"]);
                    index.Users.Add(u);
                }

                return View(index);
            }
            catch
            {
                return View();
            }
        }
    }
}
