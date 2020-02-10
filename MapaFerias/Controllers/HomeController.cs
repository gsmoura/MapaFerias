using MapaFerias.Models;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;

namespace MapaFerias.Controllers
{
    public class HomeController : Controller
    {
        private appContext db = new appContext();

        public ActionResult Index()
        {
            if (Session["usuarioLogadoID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login user)
        {
            if (ModelState.IsValid)
            {
                using (db)
                {
                    string senha = Encrypt(user.Senha);
                    var retorno = db.Usuarios.Where(a => a.LoginUsuario.Equals(user.LoginUsuario) && a.Senha.Equals(senha)).FirstOrDefault();

                    if(retorno != null)
                    {
                        Session["usuarioLogadoID"] = retorno.Id.ToString();
                        Session["nomeUsuarioLogado"] = retorno.LoginUsuario.ToString();
                        Session["perfil"] = retorno.Pefil.ToString();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.Message = string.Format("Usuário e senha incorretos.");
                        return View();
                    }
                }
            }

            return View(user);
        }


        [NonAction]
        public string Encrypt(string Text)
        {
            if (Text != null)
            {
                return Text;
            }

            return null;
        }
    }
}