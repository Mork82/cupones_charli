using System;
using cuponesCharli.Back.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace cuponesCharli.Back.Persitencia

{
    public partial class CodigosContext : DbContext
    {
        public CodigosContext()
        {
        }

        public CodigosContext(DbContextOptions<CodigosContext> options)
            : base(options)
        {
        }

        public  DbSet<Codigos> Codigos { get; set; }


    }
}
