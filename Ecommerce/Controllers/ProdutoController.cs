using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.DAL;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoDAO _produtoDAO;
        public ProdutoController(ProdutoDAO produtoDAO)
        {
            _produtoDAO = produtoDAO;
        }
        //*Métodos dentro de um controller são chamados de actions*//
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
            
        }

        [HttpPost] //Receber os dados
        public IActionResult Cadastrar(string txtNome, string txtDescricao, string txtPreco, string txtQuantidade)
        {
            Produto p = new Produto() {
            Nome = txtNome,
            Descricao = txtDescricao,
            Preco = Convert.ToDouble(txtPreco),
            Quantidade = Convert.ToInt32(txtQuantidade)
        };

            _produtoDAO.Cadastrar(p);
            return View();
        }
    }
}