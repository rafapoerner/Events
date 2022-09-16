using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        //Data notations
        [Required(ErrorMessage = "O campo {0} é obrigatório."),
        StringLength(50, MinimumLength = 3, ErrorMessage = "Intervalo permitido de 3 a 50 caracteres.")    
        ]
        public string Tema { get; set; }

        [   Display(Name ="Qtd pessoas"),
            Range(1, 120000, ErrorMessage ="{0} não pode ser menor que 1 e maior que 120.000")
        ]
        public int QtdPessoas { get; set; }
        //Expressões regulares
        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$", 
        ErrorMessage ="Não é uma imagem válida.(gif, jpg, jpeg, bmp, out png)")]
        public string ImagemURL { get; set; }
        [Required(ErrorMessage ="O {0} é obrigatório. "),
        Phone(ErrorMessage ="O {0} está com número inválido. ")    
        ]
        public string Telefone { get; set; }

        [ Required(ErrorMessage = "O {0} é obrigatório."),
            Display(Name = "E-mail"),
            EmailAddress(ErrorMessage = "É necessário ser um {0} válido.")
        ]
        public string Email { get; set; }
        public IEnumerable<LoteDto> Lotes { get; set; }
        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        public IEnumerable<PalestranteDto> Palestrantes { get; set; }
    }
}