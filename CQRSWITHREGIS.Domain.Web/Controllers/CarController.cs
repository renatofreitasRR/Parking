using Microsoft.AspNetCore.Mvc;
using Parking.Domain.Core.Entities;
using Parking.Domain.Core.Repositories.Contracts;

namespace Parking.Domain.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IRepository<Car> _repository;
        public CarController(IRepository<Car> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _repository.GetAllAsync();

            return Ok(new { });
        }
    }
}
