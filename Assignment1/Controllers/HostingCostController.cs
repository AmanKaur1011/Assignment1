using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        ///<summary>
        ///This method is going to  calculate the total amount for web hosting and maintenance  to be charged to the client including tax 
        ///and displays three strings which shows the cost before tax,total hst , and final cost after tax
        ///client is going to be charged fortnightly(1fortnight= 14 days) , $5.50/FN.
        ///This method will take the integer input as the total number of days  elaspsed since the beginning of the hosting.
        ///</summary>
        
        ///<param name="id">the input integer{id} as number of days</param>
        
        ///<returns>
        ///three strings ->1st  string will show the cost before taxes 
        ///              ->2nd string will show the total tax charged on the total cost
        ///              ->and 3rd string will show the final cost after taxes
        ///</returns>
       
        ///<example>
        /// Get: localhost:xx/api/HostingCost/0 -> "1 Fortnights at $5.50/FN = $5.50 CAD"
        ///                                        "HST 13% = $0.72 CAD"
        ///                                        "Total = $6.22 CAD"
        ///</example>
        ///<example>
        /// Get: localhost:xx/api/HostingCost/14 -> "2 Fortnights at $5.50/FN = $11.00 CAD"
        ///                                        "HST 13% = $1.43 CAD"
        ///                                        "Total = $12.43 CAD"
        ///</example>
        //<example>
        /// Get: localhost:xx/api/HostingCost/15 -> "2 Fortnights at $5.50/FN = $11.00 CAD"
        ///                                        "HST 13% = $1.43 CAD"
        ///                                        "Total = $12.43 CAD"
        ///</example>
        ///<example>
        /// Get: localhost:xx/api/HostingCost/21 -> "2 Fortnights at $5.50/FN = $11.00 CAD"
        ///                                        "HST 13% = $1.43CAD"
        ///                                        "Total = $12.43 CAD"
        ///</example>
        ///<example>
        /// Get: localhost:xx/api/HostingCost/28 -> "3 Fortnights at $5.50/FN = $16.50 CAD"
        ///                                        "HST 13% = $2.14 CAD"
        ///                                        "Total = $18.64 CAD"
        ///</example>

        public IEnumerable<string> Get(int id)
        { 

            // 1 fortnight = 14 days
            int fortnights=(id/ 14)+1;
            double totalCost = fortnights * 5.50;
            //math.round() is going to return decimal value till 2 decimal points 
            double hst =Math.Round(((13*totalCost)/100),2);
            double finalCost = totalCost + hst;
            string result1 = fortnights+" Fortnight at $5.50/FN = $" + totalCost+"CAD";
            string result2 = "HST 13% = $" + hst + " CAD";
            string result3 = "Total = $" + finalCost + " CAD";
            return new String[]{result1,result2,result3};
            
        }
    }
}
