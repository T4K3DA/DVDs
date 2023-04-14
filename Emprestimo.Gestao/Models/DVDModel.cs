
namespace Emprestimo.Gestao.Model
{
    public class DVDModel
    {
        private FaixaEtariaModel Classificacao { get; set; }

        private string Titulo { get; set; }

        private string Sinopse { get; set; }

        private GeneroModel Genero { get; set; }

        private PessoaModel Diretor { get; set; }

        private PessoaModel ArtistaPrincipal { get; set; }
    }
}