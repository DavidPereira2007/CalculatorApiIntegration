using APILearning.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace APILearning.Controllers
{
    [ApiController]
    [Route("api/calculator")]
    public class CalculatorController : ControllerBase
    {
        [HttpPost("add")] // Post para operação de adição
        public ActionResult<double> Add([FromBody] CalculationDto calculation)
        {
            double result = calculation.Number1 + calculation.Number2;

            return Ok(result);
        }

        [HttpPost("subtract")] // Post para operação de subtração

        public ActionResult<double> Subtract([FromBody] CalculationDto calculation)
        {
            double result = calculation.Number1 - calculation.Number2;
            return Ok(result);
        }

        [HttpPost("multiply")] // Post para operação de multiplicação

        public ActionResult<double> Multiply([FromBody] CalculationDto calculation)
        {
            double result = calculation.Number1 * calculation.Number2;
            return Ok(result);
        }

        [HttpPost("divide")] // Post para operação de divisão

        public ActionResult<double> Divide([FromBody] CalculationDto calculation)
        {
            if (calculation.Number2 == 0)
            {
                return BadRequest("Divisão por zero não é permitida.");
            }
            double result = calculation.Number1 / calculation.Number2;
            return Ok(result);
        }

    }
}