
using Emprestimo.Gestao.Model;

namespace Emprestimo.Gestao.Services
{
    public class InterfaceService
    {
        public RelatorioEmprestimosService RelatorioEmprestimosService { get; set; }

        public void Imprime(string arg)
        {

        }

        public void ImprimeMenu()
        {

        }

        public DVDModel LeDVD()
        {
            return new DVDModel();
        }

        public AmigoModel LeAmigo()
        {
            return new AmigoModel();
        }

        public void LeEmprestimo()
        {
            
        }

        public void AlertaFaixaEtaria(AmigoModel amigo, DVDModel dvd)
        {
            
        }
    }
}