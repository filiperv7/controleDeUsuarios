namespace ControleDeUsuario02.Domain.Model {
    public class ReembolsoDeslocamento {

        public ReembolsoDeslocamento() {
            Status = StatusEnum.Criado;
        }

        public int Id { get; private set; }

        public string Descricao { get; private set; }

        public string EnderecoInicial { get; private set; }

        public string EnderecoFinal { get; private set; }

        public int KmDeslocado { get; private set; }

        public StatusEnum Status { get; private set; }

        public DateTime DataCriacao { get; private set; }

        public void ModificarValores(int id, string descricao, string enderecoInicial, string enderecoFinal, int kmDeslocamento, StatusEnum status) {
            Id = id;
            Descricao = descricao;
            EnderecoInicial = enderecoInicial;
            EnderecoFinal = enderecoFinal;
            KmDeslocado = kmDeslocamento;
            Status = status;
        }
        
        public void AtribuirValorKmDeslocamento(int kmDeslocamento) {
            KmDeslocado = kmDeslocamento;
        }

        public void Aprovar() {
            if (KmDeslocado < 500) {
                Status = StatusEnum.Aprovado;
            } else {
                Status = StatusEnum.Reprovado;
            }
        }
    }
}
