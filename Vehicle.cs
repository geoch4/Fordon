using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fordon
{
    public class Vehicle
    {
        public int Year {  get; set; } //ålder i år
        public bool HasInsurance { get; set; }//true/false för försäkring

        public string CheckInspektion()
        {
            if (Year> 5 && HasInsurance == false)
            {
                return "Ej godkänt";
            }
            else if (Year < 5 && HasInsurance == true)
            {
                return "Godkänt";
            }
            else
            {
                return "Måste kompletteras";
            }
        }
    }
}


    

