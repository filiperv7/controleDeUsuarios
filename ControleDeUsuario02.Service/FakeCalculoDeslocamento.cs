using ControleDeUsuario02.Domain.Model;

namespace ControleDeUsuario02.Service {
    public class FakeCalculoDeslocamento {

        public static int CalculoDeslocamaneto(ReembolsoDeslocamento reembolsoDeslocamento) {
            Thread.Sleep(3000);
            
            return new Random().Next(1, 1000);
        }
    }
}
