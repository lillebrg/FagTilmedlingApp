using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTilmedlingApp.Codes.Models
{
    internal class TECPerson : IComparable<TECPerson>
    {
        public SchoolingCategory UddannelsesLinje { get; set; }
        public string? FullName { get; set; }
        public int CompareTo(TECPerson? next)
        {
            return FullName.CompareTo(next.FullName);
        }
    }
}
