using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PwdNote.Backend.Models;
using PwdNote.Backend.Models.Dtos;

namespace PwdNote.Backend.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class PasswordsController : ControllerBase
    {
        public ActionResult<IEnumerable<PasswordAddDto>> Get(
            [FromQuery] string keyword,
            [FromQuery] int limit = -1,
            [FromQuery] int offset = 0)
        {


            return Ok();
        }
    }
}
