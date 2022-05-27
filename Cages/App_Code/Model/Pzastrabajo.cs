namespace Cages.App_Code.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class Pzastrabajo : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'Pzastrabajo' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Cages.App_Code.Model.Pzastrabajo' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Pzastrabajo'  en el archivo de configuración de la aplicación.
        public Pzastrabajo()
            : base("name=Pzastrabajo")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Pztrabajo> DBPztrabajo { get; set; }
         public virtual DbSet<LNPLANIF> DBLNPLANIF { get; set; }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            dbModelBuilder.Conventions.Remove<IncludeMetadataConvention>();
        }
    }
    [Table("PZASTRABAJO")]
    public class Pztrabajo
    {
        [Key, Column(Order = 0)]
        public int CODIGO { get; set; }
        [Key, Column(Order = 1)]
        public string POS { get; set; }
        public int PEDIDO { get; set; }
        public string O_PED { get; set; }
    }


    public class LNPLANIF
    {
        [Key]
        public int CODIGO { get; set; }
       
        public int PEDIDO { get; set; }
        public string O_PED { get; set; }
    }


}