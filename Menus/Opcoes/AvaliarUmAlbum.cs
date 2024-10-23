using System.Diagnostics;
using ScreenSound.Menus.Menu;
namespace ScreenSound.Models;
internal class AvaliarUmAlbum : Menu {

    public override void Executar(Dictionary<string, Banda> bandasRegistradas){
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar Album");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write($"Qual album da banda {nomeDaBanda} quer avaliar? ");
            string nomeDoAlbum = Console.ReadLine()!;
            if(banda.Albuns.Any(a => a.Nome.Equals(nomeDoAlbum))){
                Album album = banda.Albuns.First(a => a.Nome.Equals(nomeDoAlbum));
                System.Console.Write("Digite a nota que o album merece: ");
                Avaliacao nota = Avaliacao.Parse();
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o album {nomeDoAlbum}");
                Thread.Sleep(2000);
                Console.Clear();
            } else {
                Console.WriteLine($"\nO album {nomeDoAlbum} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            
            } 
        
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