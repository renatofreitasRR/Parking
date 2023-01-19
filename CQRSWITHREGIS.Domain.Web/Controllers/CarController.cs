using Microsoft.AspNetCore.Mvc;
using Parking.Domain.Data;
using Parking.Domain.Entities;
using Parking.Domain.Repositories.Contracts;

namespace Parking.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        public CarController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _uow.CarRepository.GetAllAsync();

            return Ok(new { });
        }
    }
}
