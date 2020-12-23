using MicroRabbit.Transfer.Application.Interfaces;
using MicroRabbit.Transfer.Domain.Modals;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<TransferController> _logger;

        public TransferController(ILogger<TransferController> logger , ITransferService transferService)
        {
            _logger = logger;
            _transferService = transferService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> Get()
        {
            return Ok(_transferService.GetTransferLogs());
        }
    }
}
