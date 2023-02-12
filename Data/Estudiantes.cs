using LinqToDB.Mapping;

namespace Data
{
    public class Estudiantes
    {
        [PrimaryKey, Identity]
        public int id { get; set; }
        public int numeroId { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
    }
}
