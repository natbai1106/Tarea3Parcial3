using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteMVVM.Models
{
   
    public class Empleado
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nombre { get; set; }

        [MaxLength(100)]
        public string Apellido { get; set; }

        [MaxLength(100)]
        public int Edad { get; set; }

        [MaxLength(100)]
        public string Direccion { get; set; }

        [MaxLength(100)]
        public string Puesto { get; set; }
    }

       
    
}
