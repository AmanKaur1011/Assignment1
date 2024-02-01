using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// This Get() method is taken by NumberMachineController class from the ValuesController class
        /// as the method was public  And this method is giong to return a collection(array) of string values.
        /// IEnumerable -> iterate through the collection of data where data in this case are strings 

        /// <summary>
        /// This method is going to take an integer input and perform  4 mathematical operations on it
        /// and  return the value of that 4 mathematical operations as a string  values collection.
        /// </summary>
        /// <param name="id">the integer input(number)</param>
        /// <returns>
        /// returns the value of 4 mathematical operations as a collection of string values
        /// "operation 1 returns ({id}/2)" -> divide integer input by 2
        /// "operation 2 returns ({id}%2)" -> modulus operation-> divide the integer by 2 and  will return the remainder as output
        /// "operation 3 returns ({id}*{id})" -> square of  integer input
        /// "operation 4 returns ({id}-10)" -> subtract 10 from the integer input
        /// 
        /// </returns>
        /// <example>
        /// Get: localhost:xx/api/NumberMachine/10 -> "operation 1 returns 5"
        ///                                           "operation 2 returns 0"
        ///                                           "operation 3 returns 100"
        ///                                           "operation 4 returns 0"
        /// </example>
        /// /// <example>
        /// Get: localhost:xx/api/NumberMachine/-5 -> "operation 1 returns -2"
        ///                                           "operation 2 returns -1"
        ///                                           "operation 3 returns 25"
        ///                                           "operation 4 returns -15"
        /// </example>
        /// /// <example>
        /// Get: localhost:xx/api/NumberMachine/30 -> "operation 1 returns 15"
        ///                                           "operation 2 returns 0"
        ///                                           "operation 3 returns 900"
        ///                                           "operation 4 returns 20"
        /// </example>

        public IEnumerable<string> Get(int id)
        {
            int value1 = id / 2;
            int value2 = id % 2;
            int value3 = id * id;
            int value4 = id - 10;
            string operation1 = "operation 1 returns " + value1;
            string operation2 = "operation 2 returns " + value2;
            string operation3 = "operation 3 returns " + value3;
            string operation4 = "operation 4 returns " + value4;




            return new string[]{ operation1, operation2,operation3,operation4 };


            

        }
        
    }
}
