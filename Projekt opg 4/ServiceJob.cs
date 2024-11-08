using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_opg_4
{
    internal class ServiceJob
    {
        public int ServiceId { get; set; }
        public string VehicleType { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }
        public string MechanicId { get; set; }


        public ServiceJob(int serviceId, string vehicleType, DateTime startDate)
        {
            ServiceId = serviceId;
            VehicleType = vehicleType;
            StartDate = startDate;
        }


        public void CreateServiceJob()
        {
            Console.WriteLine("");



        }
    }
}
