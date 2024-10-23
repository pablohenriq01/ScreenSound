using ScreenSound.Models;

internal interface IAvaliar
{
    void AdicionarNota(Avaliacao nota);

    double Media{get;}
}