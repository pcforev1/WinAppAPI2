using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WinAppAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        public int GetId(int id)
        {
            return id;
            
        }
    }
}
