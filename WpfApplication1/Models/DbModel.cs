namespace WpfApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DbModel : DbContext
    {
        // Your context has been configured to use a 'DbModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WpfApplication1.Models.DbModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DbModel' 
        // connection string in the application configuration file.
        public DbModel()
            : base("name=DbModel")
        {
        }
        public virtual DbSet<YakýtAlýmý> YakýtAlýmlarý { get; set; }
        public virtual DbSet<YakýtTürü> YakýtTürleri { get; set; }
        public virtual DbSet<Pompa> Pompalar { get; set; }
        public virtual DbSet<Araç> Araçlar { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}