
using Emprestimo.Gestao;
using Emprestimo.Gestao.Model;
using Emprestimo.Gestao.Services;

var main = new Main();

/** TODO: "Tests" **/
var cadastroDVDService = new CadastroDVDService();
cadastroDVDService.Altera(1);
cadastroDVDService.Inclui(new AmigoModel());
cadastroDVDService.Exclui(1);

var cadastroAmigoService = new CadastroAmigoService();

cadastroAmigoService.Altera(1);
cadastroAmigoService.Exclui(1);
cadastroAmigoService.Inclui(new AmigoModel());

var interfaceService = new InterfaceService();
interfaceService.AlertaFaixaEtaria(new AmigoModel(), new DVDModel());
interfaceService.Imprime(string.Empty);
interfaceService.ImprimeMenu();
interfaceService.LeAmigo();
interfaceService.LeDVD();
interfaceService.LeEmprestimo();

interfaceService.RelatorioEmprestimosService = new RelatorioEmprestimosService();
interfaceService.RelatorioEmprestimosService.ImprimeRelatorio();

new FaixaEtariaModel().EhAbaixo(new FaixaEtariaModel());

Console.WriteLine("Ok...");
