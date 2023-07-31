using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProeventosB.API.Models;

namespace ProeventosB.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento{
                    EventoId = 1,
                    Tema = "Angular e .Net 5",
                    Local = "Curitiba-PR",
                    DataEvento = "12/08/2023",
                    QtdPessoas = 100,
                    Lote = "1 Lote"   
                },
                new Evento{
                    EventoId = 2,
                    Tema = "Angular e suas Novidades",
                    Local = "Curitiba-PR",
                    DataEvento = "12/10/2023",
                    QtdPessoas = 100,
                    Lote = "2 Lote"   
                }             
            };
        
        //Construtor
        public EventoController()
        {        
        }
        //Implementando o Get da API
        [HttpGet]
        public IEnumerable <Evento> Get()
        {
            return _evento;
        }
        //Implementando o Get por Id
        [HttpGet("{id}")]
        public IEnumerable <Evento> GetById(int id)
        {
            //Clausula Where para localizar objeto por Id
            return _evento.Where(evento => evento.EventoId == id);
        }
        
    }
}
