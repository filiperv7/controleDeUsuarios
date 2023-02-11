using ControleDeUsuario02.Domain.Model;

namespace ControleDeUsuario02.API.Model.Resource {
    public class ReembolsoDeslocamentoResource {

        public int Id { get; set; }

        public string Descricao { get; set; }

        public string EnderecoInicial { get; set; }

        public string EnderecoFinal { get; set; }

        public int KmDeslocado { get; set; }

        public StatusEnum Status { get; set; }

        public DateTime DataCriacao { get; set; }


    }
}
