using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FBOL_API_v2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DevelopmentController : Controller
    {
        private readonly ILogger<DevelopmentController> _logger;

        public DevelopmentController(ILogger<DevelopmentController> logger)
        {
            _logger = logger;
        }


     
    }
}

   

