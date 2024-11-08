using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_opg_4
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public string RegNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

     

        public virtual string[] GetVehicleDetails()
        {

            string[] Details = new string[5];
            Details[0] = Id.ToString(); 
            Details[1] = RegNumber; 
            Details[2] = Brand;
            Details[3] = Model;
            Details[4] = Year.ToString();
            return Details;
        }



    }

}

