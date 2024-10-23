using ScreenSound.Menus.Menu;
using ScreenSound.Models;

internal class RegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas){
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda) == false)
        {
            Banda banda = new(nomeDaBanda);
            bandasRegistradas.Add(nomeDaBanda, banda);
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            System.Console.WriteLine("Banda já existente!");
            Thread.Sleep(3000);
        }
    }
}