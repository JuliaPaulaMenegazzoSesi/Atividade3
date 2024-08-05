using Microsoft.AspNetCore.Mvc;
using cliente.Model;

namespace cliente.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {


            var cliente = new List<Cliente>{


                new Cliente{
                    Id = 1,
                    Nome = "Smartphone",
                    Cpf = "",
                    End = "RECEBIDO",
                    Tel = "EMBALAGENS",
                    Email = "DateTime.Now"
                },
                new Cliente
                {
                    Id = 1,
                    Nome = "Smartphone",
                    Cpf = "",
                    End = "RECEBIDO",
                    Tel = "EMBALAGENS",
                    Email = "DateTime.Now"
                },
                new Cliente 
                {
                    Id = 1,
                    Nome = "Smartphone",
                    Cpf = "",
                    End = "RECEBIDO",
                    Tel = "EMBALAGENS",
                    Email = "DateTime.Now"
                }

            };




           

            return View(cliente);







        }
    }

}



