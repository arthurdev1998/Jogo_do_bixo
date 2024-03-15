using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using JogodoBixo.Repository.Configuracoes.Apostas;
using JogodoBixo.Repository.Configuracoes.Enderecos;

namespace JogodoBixo.Repository.Configuracoes.Jogadores;

[Table("jogador")]
public class Jogador
{
    [Key, Column("cod_serial_jogador")]
    public int Id { get; set; }

    [Column("nome")]
    public int Nome { get; set; }

    [Range(18,120),Column("idade")]
    public int Idade { get; set; }
    
    [Column("email")]
    public int Email { get; set; }

    [Column("aposta")]
    public ICollection<ApostaItem>? ApostasItem { get; set; }

    [Column("endereco")]
    public Endereco? Endereco { get; set; }   
}