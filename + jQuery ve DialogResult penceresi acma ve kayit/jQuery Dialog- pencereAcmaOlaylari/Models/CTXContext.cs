namespace jQuery_Dialog__pencereAcmaOlaylari.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CTXContext : DbContext
    {
        public CTXContext()
            : base("name=CTXConStr")
        {
        }

        public virtual DbSet<Kullanici> Kullanici { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
