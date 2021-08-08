using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApi.BLL;
using SimpleWebApi.Model;

namespace SimpleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IAddFunction _function;
        public StudentController(IAddFunction function)
        {
            _function = function;
        }
        [HttpPost]
       public ActionResult<int> Add([FromBody]AddItems ddItems)
        {
            return _function.Add(ddItems);
        }
    }
}
