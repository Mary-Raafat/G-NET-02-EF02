using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_02_EF02.Models
{
    internal class OrganizerProfile
    {
        public int Id { get; set; }
        public string Bio { get; set; } = null!;
        public string Website { get; set; } = null!;
        public string? LogoUrl { get; set; }
        public Organizer Organizer { get; set; } = null!;
    }
}
