//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.Data.SqlClient;


//namespace Projekt_opg_4
//{
//    internal class DatabaseConnection
//    {

//        public static void Run()
//        {
//            var connectionString = "Data Source=localhost;" +
//                                   "Initial Catalog=Northwind;" +
//                                   "Integrated Security=SSPI;" +
//                                   "TrustServerCertificate=true";

//            //Console.Write("Enter SQL SELECT statement: ");
//            //var sqlStatement = Console.ReadLine();

//            var sqlStatement = "SELECT * FROM Customers";

//            using var con = new SqlConnection(connectionString);
//            con.Open();



//            var reader = command.ExecuteReader();

//            while (reader.Read())
//            {
//                for (var i = 0; i < reader.FieldCount; i++)
//                    Console.Write($"{reader.GetName(i)}: {reader[i]}\t");

//                Console.WriteLine();
//            }
//        }


//        public void AddParameter(string parameter, car.setParameter)
//    }
//}
