using Microsoft.AspNetCore.Mvc;
using Parking.Domain.Data;
using Parking.Infra.Read.Entities;

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
            var data = _uow.ReadCarRepository.Get();

            return Ok(data);
        }
    }
}
