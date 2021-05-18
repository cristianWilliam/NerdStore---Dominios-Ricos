using MediatR;
using Microsoft.AspNetCore.Mvc;
using NerdStore.Core.Communication.Mediator;
using NerdStore.Core.Messages.CommonMessages.Notifications;
using NerdStore.Vendas.Application.Queries;
using System.Threading.Tasks;

namespace NerdStore.WebApp.MVC.Controllers
{
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoQueries _pedidoQueries;

        public PedidoController(INotificationHandler<DomainNotification> notifications,
            IMediatorHandler mediatorHandler, IPedidoQueries pedidoQueries) : base(notifications, mediatorHandler)
        {
            _pedidoQueries = pedidoQueries;
        }

        [Route("meus-pedidos")]
        public async Task<IActionResult> Index()
            => View(await _pedidoQueries.ObterPedidosCliente(ClienteId));
    }
}
