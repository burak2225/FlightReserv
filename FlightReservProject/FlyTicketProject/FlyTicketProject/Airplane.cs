using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyTicketProject
{
    internal class Airplane
    {
        public string Model;
        public string SerialNum;
        public string MaintDate;
        public string Capacity;

        public Airplane(string model, string serialnum, string maintenance, string capacity)
        {
            Model = model;
            SerialNum = serialnum;
            MaintDate = maintenance;
            Capacity = capacity;
        }
    }

}
