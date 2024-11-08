using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace Projekt_opg_4
{
    internal class Motorcycle : Vehicle
    {
        public  bool HasSidecar { get; set; }
        public int NumberOfWheels { get; set; }

        public Motorcycle(int id, string regNumber, string brand, string model, int year, bool hasSideCar, int numberOfWheels)
        {
            Id = id;
            RegNumber = regNumber;
            Brand = brand;
            Model = model;
            Year = year;

            HasSidecar = hasSideCar;    
            NumberOfWheels = numberOfWheels;

        } 
        public Motorcycle(int id, string regNumber)
        {
            Id = id;
            RegNumber = regNumber;

        }

        public Motorcycle()
        {
            
        }

        


        public Motorcycle CreateMotorcycle()
        {
            Console.WriteLine("Hvad er motorcyklens ID?");

            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hvad er motorcyklens regristeringsnummer?");
            string regNumber = Console.ReadLine();

            Motorcycle motorcycle = new Motorcycle(id, regNumber);

            Console.WriteLine("Hvad er motorcyklens mærke?");

            string brand = Console.ReadLine();

            motorcycle.Brand = brand;

            Console.WriteLine("Hvad er motorcyklens model?");

            string model = Console.ReadLine();

            motorcycle.Model = model;

            Console.WriteLine("Hvilken årgang er motorcyklen fra?");

            int year = Convert.ToInt32(Console.ReadLine());

            motorcycle.Year = year;

            Console.WriteLine("Har motorcyklen en sidevogn?\n1. Ja\n2. Nej");
            string answer = Console.ReadLine();

            bool hasSidecar = false;

            if (answer == "1")
            {
                hasSidecar = true;

                motorcycle.HasSidecar = hasSidecar;
            }
            else if (answer == "2")
            {
                motorcycle.HasSidecar = hasSidecar;
            }

            Console.WriteLine("Hvor mange hjul har motorcyklen?");
            int noOfWheels = Convert.ToInt32(Console.ReadLine());

            motorcycle.NumberOfWheels = noOfWheels;

            return motorcycle;
        }

        //Database baseret:
        public void FindInformation()
        {
            // Skriv kode til at finde information om motorcyklen fra databasen

            Console.WriteLine("Hvad er bilens registreringsnummer?");
            string searchWord = Console.ReadLine();
        }
        //Database løs:
        public override string[] GetVehicleDetails()
        {
            string[] Details = new string[7];
            Details[0] = Id.ToString();
            Details[1] = RegNumber;
            Details[2] = Brand;
            Details[3] = Model;
            Details[4] = Year.ToString();
            if (HasSidecar)
            {
                Details[5] = "True";
            }
            else
            {
                Details[5] = "False";
            }
            Details[6] = NumberOfWheels.ToString();
            return Details;
        }
    }  
}
