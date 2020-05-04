using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using BUYERDB.Repositories;

namespace BuyerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyerController : ControllerBase
    {
        private readonly IBuyerRepository _repo;
        private readonly IConfiguration configuration;

        public BuyerController(IBuyerRepository repo, IConfiguration configuration)
        {
            _repo = repo;
            this.configuration = configuration;
        }
       
    }
}