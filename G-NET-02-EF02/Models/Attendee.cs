using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_02_EF02.Models
{
    internal class Attendee
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;

        public Address Address { get; set; }
        public Badge Badge { get; set; }
        public ICollection<Registration> Registrations { get; set; }

    }
}
