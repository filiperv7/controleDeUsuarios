using ControleDeUsuario02.Domain.IRepository;
using ControleDeUsuario02.Domain.Model;
using ControleDeUsuario02.InfraStructure.Persistency.DataContext;

namespace ControleDeUsuario02.InfraStructure.Repositories {
    public class ReembolsoDeslocamentoRepository : IRepositoryReembolsoDeslocamento {

        private readonly Context _dbContext;

        public ReembolsoDeslocamentoRepository(Context dbContext) {
            _dbContext = dbContext;
        }

        public ReembolsoDeslocamento Create(ReembolsoDeslocamento reembolsoDeslocamento) {
            _dbContext.Add(reembolsoDeslocamento);

            return reembolsoDeslocamento;
        }
        
        public List<ReembolsoDeslocamento> GetAll() {
            return _dbContext.ReembolsosDeslocamento.ToList();
        }

        public List<ReembolsoDeslocamento> PegarReembolsosCriados() {
            return _dbContext.ReembolsosDeslocamento.Where(_ => _.Status == StatusEnum.Criado).ToList();
        }

        public ReembolsoDeslocamento Update(ReembolsoDeslocamento reembolsoDeslocamento) {
            _dbContext.ReembolsosDeslocamento.Update(reembolsoDeslocamento);

            return reembolsoDeslocamento;
        }
    }
}
