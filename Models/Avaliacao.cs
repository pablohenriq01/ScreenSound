
using System.Security.Cryptography.X509Certificates;

namespace ScreenSound.Models;
internal class Avaliacao
{
    public int Nota{get;}

    public Avaliacao(int nota){
        if (nota > 10)
        {
            System.Console.WriteLine("Erro, somente notas até 10. Será atribuido a nota 10");
            this.Nota = 10;
        } else if (nota < 0)
        {
            System.Console.WriteLine("Erro, somente notas maiores ou iguais a 0. Será atribuido nota 0");
            this.Nota = 0;
        } else {
            this.Nota = nota;
        }
    }

    public static Avaliacao Parse(){
        int nota = int.Parse(Console.ReadLine()!);
        return new Avaliacao(nota);

    }
}