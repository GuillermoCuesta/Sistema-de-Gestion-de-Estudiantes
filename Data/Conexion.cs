using LinqToDB;
using LinqToDB.Data;
using System;

namespace Data
{
    public class Conexion : DataConnection
    {
        public Conexion() : base("Coneccion1") { }
        public ITable<Estudiantes> _Estudinates { get { return GetTable<Estudiantes>(); } }

        private ITable<T> GetTable<T>()
        {
            throw new NotImplementedException();
        }
    }
}
