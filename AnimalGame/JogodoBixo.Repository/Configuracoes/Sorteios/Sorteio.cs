using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JogodoBixo.Repository.Configuracoes.Jogadores;

namespace JogodoBixo.Repository.Configuracoes.Sorteios;

[Table("sorteio")]
public class Sorteio
{
    [Key]
    [Column("cod_serial_id")]
    public int Id { get; init; }

    [NotMapped]
    public DateTime DataHoraAberturaSorteio { get; init; } = DateTime.Now;

    [Column("hora_abertura_sorteio")]
    public string? HoraAberturaSorteio
    {
        get => DataHoraAberturaSorteio.ToString("HH:mm");
    }

    [Column("data_abertura_sorterio")]
    public DateTime DataAberturaSoterio
    {
        get => DataHoraAberturaSorteio.Date;
    }

    [NotMapped, Required]
    public DateTime? DataHoraFechamentoSorteio { get; init; }

    public IEnumerable<int>? Premios { get; set; }

    [Column("grandevencedor")]
    public Jogador? GrandeVencedor { get; set; }
    
    public ICollection<Jogador>? Jogadores { get; set; }
}