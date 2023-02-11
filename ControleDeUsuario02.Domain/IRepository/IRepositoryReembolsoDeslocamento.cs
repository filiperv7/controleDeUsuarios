using ControleDeUsuario02.Domain.Model;

namespace ControleDeUsuario02.Domain.IRepository {
    public interface IRepositoryReembolsoDeslocamento {

        ReembolsoDeslocamento Create(ReembolsoDeslocamento reembolsoDeslocamento);

        List<ReembolsoDeslocamento> GetAll();

        List<ReembolsoDeslocamento> PegarReembolsosCriados();

        ReembolsoDeslocamento Update(ReembolsoDeslocamento reembolsoDeslocamento);
    }
}
