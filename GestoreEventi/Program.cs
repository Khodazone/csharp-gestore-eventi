// See https://aka.ms/new-console-template for more information

public class Program
{
    Console.WriteLine("Crea evento");
Console.WriteLine("Inserisci il titolo dell'evento:");
string nomeEvento = Console.ReadLine();
    Console.WriteLine("Inserisci la data delle evento yyyy/mm/dd");
DateTime data = Convert.ToDateTime(Console.ReadLine());
    Console.WriteLine("Inserisci la capienza massima dell'evento");
int capienzaMassimaEvento = Convert.ToInt32(Console.ReadLine());
}