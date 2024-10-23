using ScreenSound.Menus.Menu;
using ScreenSound.Models;

internal class ExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas){
        base.Executar(bandasRegistradas);

        ExibirTituloDaOpcao("Exibir detalhes da banda");
        
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
            Console.WriteLine($"A banda {nomeDaBanda} tem {Album.contadorDeAlbuns} albuns.\n");
            foreach (var albuns in banda.Albuns)
            {
                System.Console.WriteLine($"O album {albuns.Nome} tem a media de {albuns.Media}");
            }
            Console.WriteLine("\nDigite uma tecla para votar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}