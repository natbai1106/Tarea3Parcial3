using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteMVVM.Models
{
    public class Empleados
    {
        public class Empleado
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }

            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Edad { get; set; }
            public string Direccion { get; set; }

            [OneToMany]
            public List<Puesto> Puesto { get; set; }
        }

        public class Puesto
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }

            public string DetallePuesto { get; set; }

            [ForeignKey(typeof(Empleado))]
            public int EmpleadoId { get; set; }
        }
    }
}
