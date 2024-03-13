using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JogodoBixo.Common.Enums;

namespace JogodoBixo.Repository.Configuracoes.Apostas;

[Table("apostas")]
public class Aposta
{
    [Key, Column("cod_serial_aposta")]
    public int Id { get; set; }

    [Column("cod_serial_jogador")]
    public int JogadorId { get; set; }

    [Column("cod_serial_sorteio")]
    public int SorteioId { get; set; }

    [Column("valoraposta"), Required]
    public int ValorAposta { get; set; }

    [Column("tipoaposta"), Required]
    public ApostaEnum TipoAposta { get; set; } = ApostaEnum.naoSelecionado;

    [Column("numeroapostado"), Required]
    public string? NumeroApostado { get; init;}

    [Column("vencedor")]
    public bool Vencedor { get; set; } = false;

    [Column("ValorPremioEstimado")]
    public int ValorPremioEstimado { get; set; }
}