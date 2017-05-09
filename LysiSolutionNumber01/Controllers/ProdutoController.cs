using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using LysiSolutionNumber01.Models;
using LysiSolutionNumber01.Models.Repository;

namespace LysiSolutionNumber01.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IDefaultRepository<Produto> _todoRepository;

        public ProdutoController(IDefaultRepository<Produto> todoRepository)
        {
            _todoRepository = todoRepository;
        }

        [HttpGet]
        // GET - /api/todo/
        public IEnumerable<Produto> GetAll()
        {
            return _todoRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetProduto")]
        // GET - /api/todo/{id}
        public IActionResult GetById(long id)
        {
            var item = _todoRepository.Find(id);
            if (item == null)
            {
                return NotFound();
            }            
            return new ObjectResult(item);
        }

        [HttpPost]
        // POST - /api/todo/
        public IActionResult Create([FromBody] Produto item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _todoRepository.Add(item);

            return CreatedAtRoute("GetProduto", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        // PUT - /api/todo/{id}
        public IActionResult Update(long id, [FromBody] Produto item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var Produto = _todoRepository.Find(id);
            if (Produto == null)
            {
                return NotFound();
            }

            Produto.Nome = item.Nome;

            _todoRepository.Update(Produto);
            return new NoContentResult();
        }
    }
}