using Microsoft.EntityFrameworkCore;
namespace api_tipocambio_banguat.Models{

    class Conexion : DbContext{
        public Conexion (DbContextOptions<Conexion> options) : base (options){}
        public DbSet<ValoresDelWs> ValoresDelWs{get;set;}
        
    }
    class conectar{
        private const string cadenaConexion="server=localhost;port=3306;database=tipocambiobanguat;userid=root;pwd=Umg-2023";
        public static Conexion Create(){
            var constructor = new DbContextOptionsBuilder<Conexion>();
            constructor.UseMySQL(cadenaConexion);
            var cn= new Conexion (constructor.Options);
            return cn;
            
        }

    }
}