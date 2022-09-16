using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Domain
{
    //Usando DataAnnotations do EF para mudar o nome da tabela.
    //[Table("EventosDetalhes")]
    public class Evento
    {
        //[Key("OutroNomeId")] Caso não queira trabalhar com Id e mudar o nome do mesmo. Atentar para as ForeignKeys.
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime? DataEvento { get; set; }

        //[NotMapped] Caso precise do campo para usar o relacional mas não ser mapeado.
        //public int ContagemDias { get; set; }

        //[Required] caso tenha obrigatoriedade do campo ser preenchido.
        //[MaxLength(50)] Determina o tamanho do campo.
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string ImagemURL { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public IEnumerable<Lote> Lotes { get; set; }
        public IEnumerable<RedeSocial> RedesSociais { get; set; }
        public IEnumerable<PalestranteEvento> PalestrantesEventos { get; set; }
    }
}