using Microsoft.AspNetCore.Mvc;
using NerdStore.Core.Data.EventSourcing;
using System;
using System.Threading.Tasks;

namespace NerdStore.WebApp.MVC.Controllers
{
    public class EventosController : Controller
    {
        private readonly IEventSourcingRepository _eventSourcingRepository;

        public EventosController(IEventSourcingRepository eventSourcingRepository)
        {
            _eventSourcingRepository = eventSourcingRepository;
        }

        [HttpGet("eventos/{id:guid}")]
        public async Task<IActionResult> Index(Guid id)
            => View(await _eventSourcingRepository.ObterEventos(id));
    }
}
