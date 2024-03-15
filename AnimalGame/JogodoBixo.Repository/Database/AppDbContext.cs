using JogodoBixo.Repository.Configuracoes.Apostas;
using JogodoBixo.Repository.Configuracoes.Enderecos;
using JogodoBixo.Repository.Configuracoes.Jogadores;
using JogodoBixo.Repository.Configuracoes.Sorteios;
using JogodoBixo.Repository.Database.Configurations;
using Microsoft.EntityFrameworkCore;

namespace JogodoBixo.Repository.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<ApostaItem> Apostas { get; set; }
    public DbSet<Jogador> Jogadors { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Sorteio> Sorteios { get; set; }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     ApostasConfiguration.ExecuteConfig(modelBuilder);
    // }
}