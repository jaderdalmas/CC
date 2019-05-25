using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CC.Models;
using CC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaCorrenteController : ControllerBase
    {
        private IContaCorrenteService contaCorrenteService { get; set; }

        public ContaCorrenteController(IContaCorrenteService contaCorrenteService)
        {
            this.contaCorrenteService = contaCorrenteService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] LancamentoModel lancamento)
        {
            var isDone = await contaCorrenteService.Lanca(lancamento);

            if (isDone)
                return Ok();
            else
                return Ok(null);
        }
    }
}
