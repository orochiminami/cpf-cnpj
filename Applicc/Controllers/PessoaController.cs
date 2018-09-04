using Applicc.Models;
using Applicc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Applicc.Controllers
{
    public class PessoaController : Controller
    {
        public static List<PessoaModel> Pessoas { get; set; }

        public PessoaController()
        {
            if(Pessoas == null)
            {
                Pessoas = new List<PessoaModel>
                {
                    new PessoaModel
                    {
                        Nome = "John Doe",
                        Nascimento = new DateTime(2000, 08, 21),
                        Sexo = Sexo.Masculino
                    },
                    new PessoaModel
                    {
                        Nome = "Jane Doe",
                        Nascimento = new DateTime(2000, 08, 21),
                        Sexo = Sexo.Feminino
                    }
                };
            }
        }

        public ActionResult Index()
        {
            return View(Pessoas);
        }

        public ActionResult New()
        {
            return View("New", new PessoaModel());
        }

        public ActionResult Salvar(PessoaModel model)
        {
            if (ModelState.IsValid)
            {
                Pessoas.Add(model);

            }

            return View("Index", Pessoas);
        }
    }
}