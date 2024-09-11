//Incialização

using System;

TimeSpan t1 = new TimeSpan();
TimeSpan t2 = new TimeSpan(900000000L);
TimeSpan t3 = new TimeSpan(2, 11, 21);
TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);
Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);
Console.WriteLine(t4);
Console.WriteLine(t5);


//From, vai considerar que double input seja o numero de ..., que tenham passado para criar TimeSpan
TimeSpan t6 = TimeSpan.FromDays(1.5);
TimeSpan t7 = TimeSpan.FromHours(1.5);
TimeSpan t8 = TimeSpan.FromMinutes(1.5);
TimeSpan t9 = TimeSpan.FromSeconds(1.5);
TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);
TimeSpan t11 = TimeSpan.FromTicks(900000000L);
Console.WriteLine(t6);
Console.WriteLine(t7);
Console.WriteLine(t8);
Console.WriteLine(t9);
Console.WriteLine(t10);
Console.WriteLine(t11);


//Propiedades

TimeSpan t12 = TimeSpan.MaxValue;
TimeSpan t13 = TimeSpan.MinValue;
TimeSpan t14 = TimeSpan.Zero;
Console.WriteLine(t12);
Console.WriteLine(t13);
Console.WriteLine(t14);


TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
Console.WriteLine(t);
Console.WriteLine("Days: " + t.Days);
Console.WriteLine("Hours: " + t.Hours);
Console.WriteLine("Minutes: " + t.Minutes);
Console.WriteLine("Milliseconds: " + t.Milliseconds);
Console.WriteLine("Seconds: " + t.Seconds);
Console.WriteLine("Ticks: " + t.Ticks);
Console.WriteLine("TotalDays: " + t.TotalDays);
Console.WriteLine("TotalHours: " + t.TotalHours);
Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);


//Operations 
TimeSpan tOp1 = new TimeSpan(1, 30, 10);
TimeSpan tOp2 = new TimeSpan(0, 10, 5);
TimeSpan sum = tOp1.Add(tOp2);
TimeSpan dif = tOp1.Subtract(tOp2);
TimeSpan mult = tOp2.Multiply(2.0);
TimeSpan div = tOp2.Divide(2.0);
Console.WriteLine(tOp1);
Console.WriteLine(tOp2);
Console.WriteLine(sum);
Console.WriteLine(dif);
Console.WriteLine(mult);
Console.WriteLine(div);
