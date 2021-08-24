using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Média_Aluno_MVC.Models;

namespace Média_Aluno_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public List<Aluno> lista = ListaAlunos.ListarAlunos();
        public IActionResult Index()
        {
            return View(lista);
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult CadastrarAluno(Aluno aluno)
        {
            ListaAlunos.IncluirAluno(aluno);
            return View("Index", lista);
        }
    }
}
