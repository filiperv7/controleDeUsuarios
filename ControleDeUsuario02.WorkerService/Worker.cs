using ControleDeUsuario02.Domain.IRepository;
using ControleDeUsuario02.Domain.Model;
using ControleDeUsuario02.InfraStructure.Persistency.DataContext;
using ControleDeUsuario02.Service;

namespace ControleDeUsuario02.WorkerService {
    public class Worker : BackgroundService {
        private readonly ILogger<Worker> _logger;
        private readonly IServiceProvider _serviceProvider;

        public Worker(ILogger<Worker> logger, IServiceProvider serviceProvider) {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        public override Task StartAsync(CancellationToken cancellationToken) {
            _logger.LogInformation("Serviço de Aprovação de Reembolso iniciado.");
            return base.StartAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
            while (!stoppingToken.IsCancellationRequested) {
                List<ReembolsoDeslocamento> listaDosReembolsosCriados;

                using (IServiceScope escopo = _serviceProvider.CreateScope()) {
                    var reembolsoDeslocamento = escopo.ServiceProvider.GetRequiredService<IRepositoryReembolsoDeslocamento>();

                    listaDosReembolsosCriados = reembolsoDeslocamento.PegarReembolsosCriados();
                }

                if (listaDosReembolsosCriados.Count > 0) {
                    _logger.LogInformation($"Foram encontrados {listaDosReembolsosCriados.Count} Reembolsos com status \"Criado\".");

                    AtribuirKmDeslocamentoEAprovar(listaDosReembolsosCriados);
                }

                await Task.Delay(7000, stoppingToken);
            }
        }

        public void AtribuirKmDeslocamentoEAprovar(List<ReembolsoDeslocamento> reembolsos) {
            int index = 1;

            foreach (ReembolsoDeslocamento reembolso in reembolsos) {
                _logger.LogInformation($"Verificando Aprovação do {index}º de {reembolsos.Count}.");

                reembolso.AtribuirValorKmDeslocamento(FakeCalculoDeslocamento.CalculoDeslocamaneto(reembolso));
                _logger.LogInformation($"Reembolso de Id {reembolso.Id}, recebeu {reembolso.KmDeslocado} de Km de deslocamento.");

                reembolso.Aprovar();
                _logger.LogInformation($"Reembolso de Id {reembolso.Id}, recebeu Status de {reembolso.Status}.");

                using (IServiceScope escopo = _serviceProvider.CreateScope()) {
                    var context = escopo.ServiceProvider.GetRequiredService<Context>();

                    context.Update(reembolso);
                    context.SaveChanges();

                    _logger.LogInformation($"Reembolso de Id {reembolso.Id} atualizado no banco.");
                }

                index++;
            }
        }

        public override Task StopAsync(CancellationToken cancellationToken) {
            _logger.LogInformation("O serviço de Aprovação de Reembolso foi encerrado.\n");
            return base.StopAsync(cancellationToken);
        }
    }
}
