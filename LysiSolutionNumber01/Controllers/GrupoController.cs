using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;
using LysiSolutionNumber01.Models;

namespace LysiSolutionNumber01.Controllers
{
    [Route("api/[controller]")]
    public class GrupoController : Controller
    {
        public readonly IDefaultRepository<Grupo> _todoRepository;

        public GrupoController(IDefaultRepository<Grupo> todoRepository)
        {
            _todoRepository = todoRepository;
        }

        [HttpGet]
        // GET - /api/todo/
        public IEnumerable<Grupo> GetAll()
        {
            return _todoRepository.GetAll();
        }

        [HttpGet("{id}", Name = "GetGrupo")]
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
        public IActionResult Create([FromBody] Grupo item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _todoRepository.Add(item);

            return CreatedAtRoute("GetGrupo", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        // PUT - /api/todo/{id}
        public IActionResult Update(long id, [FromBody] Grupo item)
        {
            if (item == null || item.Id != id)
            {
                return BadRequest();
            }

            var grupo = _todoRepository.Find(id);
            if (grupo == null)
            {
                return NotFound();
            }

            grupo.Nome = item.Nome;

            _todoRepository.Update(grupo);
            return new NoContentResult();
        }
    }
}