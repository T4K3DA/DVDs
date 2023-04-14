
namespace Emprestimo.Gestao.Model
{
    public class FaixaEtariaModel
    {
        private int De { get; set; }

        private int Ate { get; set; }

        public bool EhAbaixo(FaixaEtariaModel faixaEtaria)
        {
            return true;
        }
    }
}