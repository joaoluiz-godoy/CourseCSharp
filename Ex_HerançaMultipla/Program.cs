using System;
using Ex_HerançaMultipla.Devices;


class Program
{
    static void Main(string[] args)
    {
        Printer p = new Printer() { SerialNumber = 1080 };
        p.ProcessDoc("My Letter");
        p.Print("My Letter");

        Scanner s = new Scanner() { SerialNumber = 2003 };
        s.ProcessDoc("My Email");
        Console.WriteLine(s.Scan());

        ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
        c.ProcessDoc("My dissertation");
        c.Print("My dissertation");
        Console.WriteLine(c.Scan());

    }
}