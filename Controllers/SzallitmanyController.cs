using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCore.Models;
using DotNetCore.Repositories;

namespace DotNetCore.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class SzallitmanyController : Controller
    {
        private readonly ISzallitmanyRepository _szallitmanyRepository;

        public SzallitmanyController(ISzallitmanyRepository szallitmanyRepository)
        {
            _szallitmanyRepository = szallitmanyRepository;
        }

        [HttpGet("all")]
        public IEnumerable<Szallitmany> Get()
        {
            return _szallitmanyRepository.All;
        }

        // GET api/values
        [HttpGet("{id}")]
        public Szallitmany Get(int id)
        {
            return _szallitmanyRepository.Find(id);
        }
    }
}