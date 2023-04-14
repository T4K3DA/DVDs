
namespace Emprestimo.Gestao.Model
{
    public class RegistroEmprestimoModel
    {
        public ICollection<EmprestimoModel> Emprestimos { get; set; }

        public void Empresta(AmigoModel amigo, DVDModel dvd)
        {

        }

        public void Devolve(DVDModel dvd)
        {

        }

        private bool EstahEmprestado(DVDModel dvd)
        {
            return true;
        }

        private bool FaixaEtariaAbaixo(AmigoModel amigo, DVDModel dvd)
        {
            return true;
        }
    }
}