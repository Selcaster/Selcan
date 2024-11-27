using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UniqloMVC.Models;

public partial class SenkimsendostumSenkimsendostumContext : DbContext
{
    public SenkimsendostumSenkimsendostumContext()
    {
    }

    public SenkimsendostumSenkimsendostumContext(DbContextOptions<SenkimsendostumSenkimsendostumContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=sql.bsite.net\\MSSQL2016;Database=senkimsendostum_senkimsendostum;User Id=senkimsendostum_senkimsendostum;Password=Salam123;Trusted_Connection=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
