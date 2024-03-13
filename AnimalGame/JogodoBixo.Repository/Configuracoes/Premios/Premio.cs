namespace JogodoBixo.Repository.Configuracoes.Premios;

public class Premio
{
    public int Id { get; set; }
    public int SorteioId { get; set; }
    public DateTime HorarioSorteio { get; init; } = DateTime.UtcNow;
    public string? NumeroSorteado { get; set; }
}
