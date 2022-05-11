using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasMVVM.Models
{
    public class Figura
    {
        //Campos
        public String CharacterName { get; set; } = "";
        public String Brand { get; set; } = "";
        public String Details { get; set; } = "";
        public String RelaseDate { get; set; } = "";
        public int ListPrice { get; set; } = 0;
        public String Imagen { get; set; } = "";

    }
}
