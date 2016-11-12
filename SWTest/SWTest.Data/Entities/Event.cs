using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWTest.Data.Entities
{
    public class Event
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Tecnology { get; set; }

        public DateTime StartingDate { get; set; }

        public string RegistrationLink { get; set; }
    }
}
