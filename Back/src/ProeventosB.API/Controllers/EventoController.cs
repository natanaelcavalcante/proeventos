using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProeventosB.API.Data;
using ProeventosB.API.Models;

namespace ProeventosB.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;
        
        //Construtor
        public EventoController(DataContext context)
        {        
            _context = context;
        }
        //Implementando o Post da API
        [HttpPost]
        public IEnumerable <Evento> Post()
        {
            return _context.Eventos;
        }        

        //Implementando o Get da API
        [HttpGet]
        public IEnumerable <Evento> Get()
        {
            return _context.Eventos;
        }
        //Implementando o Get por Id
        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            //Clausula FirstOrDefault para localizar objeto por Id
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }
        //Implementando o Put da API
        [HttpPut]
        public IEnumerable <Evento> Put()
        {
            return _context.Eventos;
        }
        //Implementando o Put por Id
        [HttpPut("{id}")]
        public Evento PutById(int id)
        {
            //Clausula FirstOrDefault para localizar objeto por Id
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }
        //Implementando o Delete por Id
        [HttpDelete("{id}")]
        public Evento DeleteById(int id)
        {
            //Clausula FirstOrDefault para localizar objeto por Id
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }
        
    }
}
