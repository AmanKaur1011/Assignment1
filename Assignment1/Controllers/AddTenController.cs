using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        ///<summary>
        /// This method will take an integer input and return 10 more than that integer input.
        ///</summary>
        ///<param name="id">The integer input (integer number)</param>
        ///<return>
        /// An integer which is 10 more than the input number
        ///</return>
        ///<example>
        ///GET: localhost: xx/api/AddTen/21  -> 31
        ///</example>
        ///<example>
        ///GET: localhost: xx/api/AddTen/0  -> 10
        ///</example>
        ///<example>
        ///GET: localhost: xx/api/AddTen/-9  -> 1
        ///</example>
        
       public int Get(int id) {
            int newNum = id + 10;
            return newNum;
        
        }

    }
}
