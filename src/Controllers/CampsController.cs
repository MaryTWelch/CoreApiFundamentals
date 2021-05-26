using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCodeCamp.Controllers
{
    [Route("api/[controller]")] // [controller] inserts whatever is in front of Controller in class name
    public class CampsController : ControllerBase
    {
        public object Get()
        {
            return new { Moniker = "ATL2018", Name = "Atlanta Code Camp" };
        }
    }
}
