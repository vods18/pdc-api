using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Requisito> Requisitos => Set<Requisito>();
    public DbSet<SubRequisito> SubRequisitos => Set<SubRequisito>();
    public DbSet<Referencia> Referencias => Set<Referencia>();
    public DbSet<Software> Softwares => Set<Software>();
    public DbSet<Questionario> Questionario => Set<Questionario>();
    public DbSet<RegrasOcultacao> RegrasOcultacoes => Set<RegrasOcultacao>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=banco.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Questionario>().ToTable("Questionario");
        
        modelBuilder.Entity<RegrasOcultacao>()
            .HasOne(ro => ro.PerguntaGatilho)
            .WithMany(q => q.RegrasOcultacaoGatilho)
            .HasForeignKey(ro => ro.PerguntaGatilhoId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<RegrasOcultacao>()
            .HasOne(ro => ro.PerguntaAlvo)
            .WithMany(q => q.RegrasOcultacaoAlvo)
            .HasForeignKey(ro => ro.PerguntaAlvoId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}