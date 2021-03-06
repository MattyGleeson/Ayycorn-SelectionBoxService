namespace SelectionBoxService.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AyycornDb : DbContext
    {
        public AyycornDb()
            : base("name=AyycornDb")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SelectionBox> SelectionBoxes { get; set; }
        public virtual DbSet<SelectionBoxProduct> SelectionBoxProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual void SetModified(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}
