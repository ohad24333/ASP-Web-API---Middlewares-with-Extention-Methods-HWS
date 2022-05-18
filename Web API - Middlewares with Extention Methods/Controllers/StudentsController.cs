using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API___Middlewares_with_Extention_Methods.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [Route("{clas}/{id}")]
        public string Get(int clas,int id)
        {
            return "" + clas + " " + id;
        }
    }
}
