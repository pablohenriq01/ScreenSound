using ScreenSound.Menus.Menu;
using ScreenSound.Models;

internal class MostrarBandas : Menu
{
    public override void Executar(Dictionary<string,Banda> bandasRegistradas){
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");
        foreach (var bandas in bandasRegistradas)
        {
            System.Console.WriteLine($"Banda : {bandas.Value.Nome}");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
    

}