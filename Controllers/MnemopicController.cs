using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Mnemopic.Controllers
{
    [Route("api/mnemopic")]
    [ApiController]
    public class MnemopicController : ControllerBase
    {
        private readonly ILogger<MnemopicController> _logger;

        public MnemopicController(ILogger<MnemopicController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public Borders.Entities.Mnemopic Get(Guid id)
        {
            var teste = new Borders.Entities.Mnemopic();
            teste.Name = "ball";
            teste.Link = "teste";

            return teste;
        }
    }
}
