using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace probar.Entidades
{
    public class Persona
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
        public string Dni { get; set; }
    
        public Persona(int id,string nombre, string apellido, string dni)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }


        public Persona()
        {

        }

        public string Salida()
        {
            string salida = "Id: " + Id + " - Nombre: " + Nombre + " - Apellido: " + Apellido + " - DNI: " + Dni;
   
            return (salida);

        }




    }
}
