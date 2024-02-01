using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        ///<summary>
        /// This post method will return the string "Hello World!"
        ///</summary>
        ///<return>
        /// A string "Hello World!"
        ///</return>
        ///<example>
        ///POST: localhost: xx/api/Greeting - > "Hello World!"
        ///</example>
        ///

        public string Post()
        {
            return "Hello World!";
        }

        ///<summary>
        /// This Get method will take an integer Input and return a string with a message "Greetings to (integer input) people!"
        ///</summary>
        ///<param name="id">The integer input (integer number)</param>
        ///<return>
        /// A String "Greetings to {id} people!"
        ///</return>
        ///<example>
        ///GET: localhost: xx/api/Greeting/3  -> "Greetings to 3 people!"
        ///</example>
        ///<example>
        ///GET: localhost: xx/api/Greeting/6  -> "Greetings to 6 people!"
        ///</example>
        ///<example>
        ///GET: localhost: xx/api/Greeting/0  -> "Greetings to 0 people!"
        ///</example>

        public string Get(int id)
        {
            string greeting = "Greetings to " + id + " people!";
            return greeting;
        }        
    }
}
