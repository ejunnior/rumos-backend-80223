using Microsoft.AspNetCore.Mvc;

namespace Api.SnackMachine
{
    public class SnackMachineController : ControllerBase
    {
        [HttpPost()]
        public async Task<IActionResult> CreateSnackMachine(
            [FromBody] CreateSnackMachineModel modem)
        {
            throw new NotImplementedException();
        }

        [HttpDelete()]
        public async Task<IActionResult> DeleteSnackMachine(long id)
        {
            throw new NotImplementedException();
        }

        [HttpGet()]
        public async Task<IActionResult> GetSnackMachine()
        {
            throw new NotImplementedException();
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateSnackMachine(
            long id,
            [FromBody] UpdateSnackMachineModel modem)
        {
            throw new NotImplementedException();
        }
    }
}