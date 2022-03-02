using FagTilmedlingApp.Codes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTilmedlingApp.Codes.Models
{
    internal class TECPerson
    {
        Enums.SchoolingCategory Uddannelseslinje { get; set; }
        public string? FullName { get; set; } 
    }
}
