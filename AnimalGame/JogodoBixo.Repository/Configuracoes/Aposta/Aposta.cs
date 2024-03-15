using JogodoBixo.Repository.Configuracoes.Apostas;
using JogodoBixo.Repository.Configuracoes.Jogadores;
using JogodoBixo.Repository.Configuracoes.Sorteios;

namespace JogodoBixo.Repository.Configuracoes.Aposta;

public class Aposta
{
    public int Id { get; set; }
    public int JogadorId { get; set; }
    public Jogador? Jogador { get; set; }
    public ICollection<ApostaItem>? Apostas { get; set; }
    public decimal ValorAposta { get; set; }
    public int SorteioId { get; set; }
    public Sorteio? Sorteio { get; set; }
    public string? NomeAposta { get; set; }
    public DateTime? DataHoraAberturaAposta { get; set; }
    public string? HoraAberturaAposta { get => DataHoraAberturaAposta?.ToString("HH:mm"); }
    public string? DataAberturaAposta { get => DataHoraAberturaAposta?.Date.ToString(); }
    public int MyProperty { get; set; }
}
