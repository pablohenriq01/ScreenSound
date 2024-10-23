﻿using ScreenSound.Menus.Menu;
using ScreenSound.Models;
using OpenAI_API;

var client = new OpenAIAPI("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");
var chat = client.Chat.CreateConversation();
chat.AppendSystemMessage("Resuma a banda Ira! em um paragrafo. Use um estilo informal");

string resposta = await chat.GetResponseFromChatbotAsync();
Console.WriteLine(resposta);

Dictionary<string, Banda> bandasRegistradas = new();
Dictionary<int, Menu> opcoesMenu = new();
opcoesMenu.Add(1, new RegistrarBanda());
opcoesMenu.Add(2, new RegistrarAlbum());
opcoesMenu.Add(3, new MostrarBandas());
opcoesMenu.Add(4, new AvaliarUmaBanda());
opcoesMenu.Add(5, new AvaliarUmAlbum());
opcoesMenu.Add(6, new ExibirDetalhes());
opcoesMenu.Add(-1, new Sair());

void ExibirLogo()
{
Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um album");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");
    Console.Write("\nDigite a sua opção: ");
    
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    if(opcoesMenu.ContainsKey(opcaoEscolhidaNumerica)){
        Menu menu = opcoesMenu[opcaoEscolhidaNumerica];
        if(opcaoEscolhidaNumerica == -1){
            menu.Executar(bandasRegistradas);
        } else {
            menu.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
        }
    }
    else {
        Console.WriteLine("Opção inválida");
        Thread.Sleep(2000);
        ExibirOpcoesDoMenu();
    }
}
// ExibirOpcoesDoMenu();