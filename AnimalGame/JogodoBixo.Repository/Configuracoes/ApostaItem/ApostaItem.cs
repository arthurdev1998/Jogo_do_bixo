using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JogodoBixo.Common.Enums;
using JogodoBixo.Repository.Configuracoes.Jogadores;
using JogodoBixo.Repository.Configuracoes.Sorteios;

namespace JogodoBixo.Repository.Configuracoes.Apostas;

[Table("apostaitem")]
public class ApostaItem
{
    [Key, Column("cod_serial_aposta")]
    public int Id { get; set; }

    public int ApostaId { get; set; }

    [Column("cod_serial_jogador")]
    public int JogadorId { get; set; }

    public Jogador? Jogador { get; set; }

    [Column("cod_serial_sorteio")]
    public int SorteioId { get; set; }

    public Sorteio? Sorteio { get; set; }

    [Column("valoraposta"), Required]
    public string? ValorAposta { get; set; }

    [Column("numeroapostado"), Required]
    public string? NumeroApostado { get; init; }

    [Column("vencedor")]
    public bool Vencedor { get; set; } = false;

    [Column("animal")]
    public AnimalEnum? Animal { get; set; }

    [Column("tipoapostanumero")]
    public TipoApostaNumero? TipoApostaNumero { get; set; }

    // [Column("valorpremioestimado")]
    // public decimal ValorPremioEstimado { get => BetForValor() * ValorAposta; }

    // private int BetForValor()
    // {
    //     var dicionario = new Dictionary<ApostaEnum, int>
    //     {
    //         {ApostaEnum.milharCabeca, 4000},
    //         {ApostaEnum.centenaCabeca, 1000},
    //         {ApostaEnum.dezenaCabeca, 600},
    //         {ApostaEnum.animalCabeca, 90},
    //         {ApostaEnum.milharGrupo, 800},
    //         {ApostaEnum.centenaGrupo, 200},
    //         {ApostaEnum.dezenaGrupo, 120},
    //         {ApostaEnum.animalGrupo, 18},
    //     };

    //     return dicionario.GetValueOrDefault(TipoAposta);
    // }
}