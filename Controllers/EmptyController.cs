using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMVC.Controllers
{
    public class EmptyController : Controller
    {
        public string Index()
        {
            return "Sou um Controller vazio ;-;";
        }

        public string Saudacao(string nome)
        {
            return $"Ola {nome}, seja bem vindo!";
        }
    }
}
