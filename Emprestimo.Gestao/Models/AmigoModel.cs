
namespace Emprestimo.Gestao.Model
{
    public class AmigoModel : PessoaModel
    {
        private FaixaEtariaModel FaixaEtaria { get; set; }

        private long NumTelefone { get; set; }

        private string Email { get; set; }
        
        private string Endereco { get; set; }
    }
}