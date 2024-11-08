using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_opg_4
{
    internal class Car : Vehicle
    {
        public string Drivetrain { get; set; }


        public Car(int id, string regNumber)
        {
            Id = id;    
            RegNumber = regNumber;
        }


        public Car()
        {
            
        }

        

        public Car CreateCar()
        {
            Console.WriteLine("Hvad er bilens ID?");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hvad er bilens regristeringsnummer?");
            string regNumber = Console.ReadLine();

            Car car = new Car(id, regNumber);

            Console.WriteLine("Hvad er bilens mærke?");
            string brand = Console.ReadLine();

            car.Brand = brand;

            Console.WriteLine("Hvad er bilens model?");
            string model = Console.ReadLine();

            car.Model = model;

            Console.WriteLine("Hvilken årgang er bilen fra?");
            int Year = Convert.ToInt32(Console.ReadLine());

            car.Year = Year;

            Console.WriteLine("Hvilken type drivlinje har bilen?");
            string drivetrain = Console.ReadLine();

            car.Drivetrain = drivetrain;

            return car;
        }

        //Database baseret:
        public void FindInformation()
        {
            // Skriv kode til at finde information om bilen fra databasen

            Console.WriteLine("Hvad er bilens registreringsnummer?");
            string searchWord = Console.ReadLine();
        }
        //Database løs:
        public override string[] GetVehicleDetails()
        {
            string[] Details = new string[6];
            Details[0] = Id.ToString();
            Details[1] = RegNumber;
            Details[2] = Brand;
            Details[3] = Model;
            Details[4] = Year.ToString();
            Details[5] = Drivetrain;
            return Details;
        }


    }



}
