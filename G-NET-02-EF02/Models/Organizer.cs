using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_02_EF02.Models
{
    internal class Organizer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? CompanyName { get; set; }
        public bool IsVerfied { get; set; }
        public OrganizerProfile Profile { get; set; }=null!;

        public ICollection<Event> Events { get; set; } = new HashSet<Event>();


    }
}
