using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Tilaus
    {
        public int Id { get; set; }
        public string Nimi { get; set; }
        public int Määrä { get; set; }        
    }
}
