using Microsoft.AspNetCore.Mvc;
using AulaMVC.Data;
using AulaMVC.Models;
using Microsoft.EntityFrameworkCore;
using AulaMVC.Services;

namespace AulaMVC.Controllers
{


    public class ClientesController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public IActionResult Index()
        {
            var clientes = _clienteService.GetAll();
            return View(clientes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _clienteService.Create(cliente);

                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {

            var cliente = _clienteService.Find(id);

            if(cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _clienteService.Edit(cliente);
                return RedirectToAction("Index");
            }
            return View(cliente);
        }


    }
}
