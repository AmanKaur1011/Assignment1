using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {

        ///<summary>
        /// This method will take an integer input and returns the square of an integer input .
        ///</summary>
        ///<parm name="id">The integer input (integer number)</param>
        ///<return>
        /// An integer which is a square of the input number(id)
        ///</return>
        ///<example>
        ///GET: localhost: xx/api/Square/2  -> 4
        ///</example>
        ///<example>
        ///GET: localhost: xx/api/Square/-2  -> 4
        ///</example>
        ///<example>
        ///GET: localhost: xx/api/Square/10  -> 100
        ///</example>

        public int Get(int id)
        {
            int squaredNum = id * id;
            return squaredNum;

        }

    }
}

