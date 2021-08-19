using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteMVVM.Models
{
    public class BaseDatos
    {
        readonly SQLiteAsyncConnection db;
        public BaseDatos(String dbpath)
        {
            db = new SQLiteAsyncConnection(dbpath);
            //creacion de las tablas de la bd 
            db.CreateTableAsync<Empleado>().Wait();
        }

        //Metodos del CRUD para Sitios 

        #region Sitios 
        //Select 
        public Task<List<Empleado>> ObtenerSitios()
        {
            return db.Table<Empleado>().ToListAsync();
        }

        //Insert 
        public Task<int> InsertEmpleado(Empleado empleado)
        {
            if (empleado.Id != 0)
            {
                return db.UpdateAsync(empleado);
            }
            else
            {
                return db.InsertAsync(empleado);
            }
        }
        //Traer un solo sitio (Ubicacion) 
        //public Task<Sitios> ObtenerSitios(int pid)
        //{
        //    return db.Table<Sitios>()
        //        .Where(i => i.id == pid)
        //        .FirstOrDefaultAsync();
        //}

        //Delete 
        public Task<int> EliminarFoto(Empleado foto)
        {
            return db.DeleteAsync(foto);
        }
        #endregion Sitios 
    }
}
