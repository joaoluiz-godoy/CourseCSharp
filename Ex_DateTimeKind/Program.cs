DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
Console.WriteLine("d1: " + d1);
Console.WriteLine("d1 Kind: " + d1.Kind);
Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());

DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");
Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")); //Padrão string para o UTC