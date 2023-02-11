using ControleDeUsuario02.WinForm01.Model;
using RestSharp;

namespace ControleDeUsuario02.WinForm01.Controllers {
    public class ReembolsoDeslocamentoController {

        public static List<ReembolsoDeslocamentoModel> GetAll() {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest("/ReembolsoDeslocamento", Method.Get);
            var response = client.ExecuteGet<List<ReembolsoDeslocamentoModel>>(request);

            return response.Data;
        }

        public static ReembolsoDeslocamentoModel Post(ReembolsoDeslocamentoModel reembolsoDeslocamento) {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest($"/ReembolsoDeslocamento", Method.Post);
            var body = new ReembolsoDeslocamentoModel { 
                Id = reembolsoDeslocamento.Id,
                Descricao = reembolsoDeslocamento.Descricao, 
                EnderecoInicial = reembolsoDeslocamento.EnderecoInicial,
                EnderecoFinal = reembolsoDeslocamento.EnderecoFinal,
                DataCriacao = DateTime.Now
            };

            request.AddBody(body);

            var response = client.ExecutePost<ReembolsoDeslocamentoModel>(request);

            return response.Data;
        }
    }
}
