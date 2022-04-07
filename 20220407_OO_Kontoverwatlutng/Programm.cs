using System;

namespace _20220407_OO_Kontoverwatlutng
{
    class Programm
    {
        //ein Objekt bzw. eine Instanz der Klasse Konto erzeugen
        static Programm konto = null;


        static void Main(string[] args)
        {
            Console.Title = "Kontoverwaltung";
            Console.WriteLine("Hallo, Sie Sparfuchs zur Kontoverwaltung!");
            Console.ReadLine();
        }

        static void Kontoanlegen() 
        {
            konto = new Programm(); //Konto neu erzeugen und 
        
        }

        //Methode, welches uns das Menü anzeigen soll:
        static void MenuAnzeige()
        {
            Console.Clear(); //Löscht die Konsolenanzeige
            Console.WriteLine("Wählen Sie eine der folgenden Aktionen aus!");
            Console.WriteLine("Aktion Nr. 1: Kontodaten anzeigen");
            Console.WriteLine("Aktion Nr. 2: Geld einzahlen");
            Console.WriteLine("Aktion Nr. 3: Geld auszahlen");
            Console.WriteLine("Aktion Nr. 4: Programm beenden");

            //eine Leerzeile
            Console.WriteLine();

            //Aufforderung Eingabe 
            Console.WriteLine("Geben Sie ein");
        }
    }
}
