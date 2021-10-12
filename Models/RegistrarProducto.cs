using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace practicasimulacro.Models
{
    public class RegistrarProducto
    {
        public int Id {get; set;}

        public string producto {get; set;}

        public string Foto {get; set;}        
        public string Descripcion {get; set;}

        public string Precio {get; set;}

        public string Celular {get; set;}

        public string Lugar {get; set;}

        public string NombreCompra {get; set;}

        public string Categoria {get; set;}
    }
}