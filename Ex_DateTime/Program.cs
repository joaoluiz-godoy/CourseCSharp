using System;
using System.Globalization;


//Inicialização
DateTime d1 = new DateTime(2000, 8, 15);
DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);


//Métodos para criar DateTimes
DateTime d4 = DateTime.Now;
DateTime d5 = DateTime.UtcNow;
DateTime d6 = DateTime.Today;


// String -> DateTime
DateTime d7 = DateTime.Parse("2000-08-15"); //não importa se separação é por - ou /
DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");

DateTime d9 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture); //definir exatamente os spots
//lembrar de incluir o CultureInfo.InvariantCulture


//Formatação DateTime -> String 
DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);
string s1 = d.ToLongDateString();
string s2 = d.ToLongTimeString();
string s3 = d.ToShortDateString();
string s4 = d.ToShortTimeString();
string s5 = d.ToString();
string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");
Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.WriteLine(s4);
Console.WriteLine(s5);
Console.WriteLine(s6);
Console.WriteLine(s7);


//Propiedades, ou field acess, do DateTime 

DateTime day = new DateTime(2001, 8, 15, 13, 45, 58, 275);
Console.WriteLine(day);
Console.WriteLine("1) Date: " + d.Date);
Console.WriteLine("2) Day: " + d.Day);
Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
Console.WriteLine("5) Hour: " + d.Hour);
Console.WriteLine("6) Kind: " + d.Kind);
Console.WriteLine("7) Millisecond: " + d.Millisecond);
Console.WriteLine("8) Minute: " + d.Minute);
Console.WriteLine("9) Month: " + d.Month);
Console.WriteLine("10) Second: " + d.Second);
Console.WriteLine("11) Ticks: " + d.Ticks);
Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
Console.WriteLine("13) Year: " + d.Year);