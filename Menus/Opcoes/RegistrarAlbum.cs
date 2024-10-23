using ScreenSound.Menus.Menu;
using ScreenSound.Models;

internal class RegistrarAlbum : Menu 
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas){
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("Digite a banda cujo álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        while (true)
        {
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];
                Console.Write("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;
                banda.AdicionarAlbum(new Album(tituloAlbum));
                Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
                Thread.Sleep(4000);
                Console.Clear();
                break;
            }
            else
            {
                System.Console.WriteLine("Digite uma banda existente!");
                Thread.Sleep(2500);
                break;
            }
        }
    }
}