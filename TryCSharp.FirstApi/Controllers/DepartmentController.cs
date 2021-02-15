using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TryCSharp.FirstApi.Models;

namespace TryCSharp.FirstApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : ControllerBase
    {

        public Department Get() => throw new NotImplementedException();
        
    }
}
