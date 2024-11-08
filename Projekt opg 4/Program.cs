namespace Projekt_opg_4
{
    internal class Program
    {
        static void Main()
        {
            Motorcycle motorcycle = new Motorcycle();
            Car car = new Car();
            
            //DatabaseConnection db = new Databaseconnection();

            string answer = "1";
            Console.WriteLine("Hvad vil du?\n1.Opret køretøj\n2.Find information");
            answer = Console.ReadLine();

            if (answer == "1")
            {
                CreateVehicle();
                Main();
            }
            else if (answer == "2")
            {
                FindInformation();
                Main();
            }
            else
            {
                Console.WriteLine("Fejl, prøv igen");
                Main();
            }

            void CreateVehicle()
            {
                Console.WriteLine("Er det en bil eller en motorcykel?\n1. Bil \n2. Motorcykel");
                answer = Console.ReadLine();

                if (answer == "1")
                {
                    car.CreateCar();
                    //db.AddVehicle(car);
                    //Her ville vi gemme car til databasen
                }
                else if (answer == "2")
                {
                    motorcycle.CreateMotorcycle();
                    //db.AddVehicle(motorcycle);
                    //Her ville vi gemme motorcycle til databasen
                }
                else
                {
                    Console.WriteLine("Fejl, prøv igen");
                    CreateVehicle();
                }

            }

            void FindInformation()
            {
                Console.WriteLine("Vil du finde information på en bil eller motorcykel?\n1. Bil\n2. Motorcykel");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    //Burde tilgå Databasen, ligenu tager den blot den seneste oprettede bil
                    foreach (string s in car.GetVehicleDetails())
                    {
                        Console.WriteLine(s);
                    }
                }
                else if (input == "2")
                {
                    //Burde tilgå Databasen, ligenu tager den blot den seneste oprettede motorcykel
                    foreach (string s in motorcycle.GetVehicleDetails())
                    {
                        Console.WriteLine(s);
                    }
                }
            }
        }
    }
}
