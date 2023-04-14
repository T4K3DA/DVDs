
namespace Emprestimo.Gestao.Model
{
    public class EmprestimoModel
    {
        private AmigoModel Amigo { get; set; }

        private DVDModel DVD { get; set; }
        
        private DateTime DataEmprestimo { get; set; }

        private DateTime DataDevolver { get; set; }
    }
}