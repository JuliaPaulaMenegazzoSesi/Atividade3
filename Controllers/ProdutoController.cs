using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {


            var produtos = new List<Produto>{


                new Produto{
                    Id = 1,
                    Cat = "Smartphone X",
                    Nome = "Smartphone",
                    Valor = 2345.96m,
                    Status = "RECEBIDO",
                    Resp = "EMBALAGENS",
                    Data = DateTime.Now
                },
                new Produto
                {
                    Id = 2,
                    Cat = "Laptop",
                    Nome = "Laptop Y",
                    Valor = 4567.89m,
                    Desc = "Um laptop poderoso com processador de última geração e design elegante.",
                    Status = "RECEBIDO",
                    Resp = "EMBALAGENS",
                    Data = DateTime.Now
                },
                new Produto
                {
                    Id = 3,
                    Cat = "Tablet",
                    Nome = "Tablet Z",
                    Valor = 1234.56m,
                    Desc = "Um tablet versátil com tela de alta resolução e longa duração da bateria.",
                    Status = "RECEBIDO",
                    Resp = "EMBALAGENS",
                    Data = DateTime.Now
                }

            };




           

            return View(produtos);







        }
    }

}



