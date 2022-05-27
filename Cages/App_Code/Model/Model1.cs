namespace Cages.App_Code.Model
{
    using FirebirdSql.Data.FirebirdClient;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class Model1 : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'Model1' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Cages.App_Code.Model.Model1' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Model1'  en el archivo de configuración de la aplicación.
        public Model1() :base("name=Model1")
            //: base(new FbConnection(@"Data Source=localhost;Initial Catalog=localhost:C:\\gdb\\Laserken\\GESTOR.GDB; User Id=SYSDBA;password=masterkey;Charset=NONE;"), true)
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        //public virtual DbSet<ANDROID_ENVIOS> DBEnvios { get; set; }
        //public virtual DbSet<PZPEDIDO> DBPzpedido { get; set; }
        public virtual DbSet<MOVSPZ> DBMOVSPZ { get; set; }

        public virtual DbSet<KAJA> DBCAGE { get; set; }

        //https://stackoverflow.com/questions/12130059/how-turn-off-pluralize-table-creation-for-entity-framework-5
        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            dbModelBuilder.Conventions.Remove<IncludeMetadataConvention>();
        }
    }

    public class ANDROID_ENVIOS
    {
        [Key]
        public int IDENVIO { get; set; }
        public string NOMBRE { get; set; }

        public string USUARIO { get; set; }
    }
    
    public class MOVSPZ
    {
        [Key]
        public int CODIGO { get; set; }
        public int PEDIDO { get; set; }

        public string O_PED { get; set; }
        public int CANTIDAD { get; set; }
    }
    [Table("ANDROID_CAGE")]
    public class KAJA
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDCAGE { get; set; }
        public string AREA { get; set; }

        public string ESTANTE { get; set; }
        
    }

}