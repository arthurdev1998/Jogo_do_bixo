using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JogodoBixo.Common.Enums;
using JogodoBixo.Common.Messages;
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

    [Column("numeroapostado")]
    public string? NumeroApostado { get; set; }

    [Column("vencedor")]
    public bool Vencedor { get; set; } = false;

    [Column("animal")]
    public AnimalEnum? Animal { get; set; }

    [Column("tipoapostanumero")]
    public ApostaTipo? ApostaTipo { get; set; }

    [Column("valorpremioestimado")]
    public decimal ValorPremioEstimado { get; set; }

    private ApostaItem() { }

    public static ServiceResult<ApostaItem> CreateApostaItem(Aposta aposta,
            Jogador jogador, Sorteio sorteio, string valoraposta, AnimalEnum animal,
            ApostaTipo apostaTipo, string? numeroapostado = null)
    {
        if (jogador == null)
            throw new ArgumentNullException("Nao é possivel criar um ItemDeAposta sem jogador", nameof(jogador));

        if (aposta == null)
            throw new ArgumentNullException("Nao é possivel criar uma ItemDeAposta sem pertercenter a um Aposta", nameof(jogador));

        ApostaItem apostaItem = new ApostaItem();

        apostaItem.ApostaId = aposta.Id;
        apostaItem.JogadorId = jogador.Id;
        apostaItem.SorteioId = sorteio.Id;

        //Values Default
        apostaItem.ValorAposta = valoraposta;
        apostaItem.NumeroApostado = numeroapostado;
        apostaItem.Animal = animal;
        apostaItem.ApostaTipo = apostaTipo;
        apostaItem.ValorPremioEstimado = 0;

        return new ServiceResult<ApostaItem>(apostaItem);
    }
}