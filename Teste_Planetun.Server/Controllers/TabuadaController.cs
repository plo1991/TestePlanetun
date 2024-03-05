using Microsoft.AspNetCore.Mvc;

namespace Teste_Planetun.Server.Controllers
{
    [ApiController]
    [Route("api/tabuada")]
    public class TabuadaController : ControllerBase
    {
        private readonly ILogger<TabuadaController> _logger;

        public TabuadaController(ILogger<TabuadaController> logger)
        {
            logger = _logger;
        }

        [HttpPost]
        public async Task<IActionResult> ProcessarTabuadas([FromBody] List<int> numeros)
        {
            if (numeros == null || numeros.Count == 0)
            {
                return BadRequest("A lista de números não pode estar vazia.");
            }

            foreach (var numero in numeros)
            {
                await ProcessarTabuadaAsync(numero);
            }

            return Ok("Processamento concluído com sucesso.");
        }

        private async Task ProcessarTabuadaAsync(int numero)
        {
            var tabuadaLines = new List<string>();

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                string linha = $"{numero} x {i} = {resultado}";
                tabuadaLines.Add(linha);
            }

            string fileName = $"tabuada_de_{numero}.txt";
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var line in tabuadaLines)
                {
                    await writer.WriteLineAsync(line);
                }
            }
        }

    }
}
