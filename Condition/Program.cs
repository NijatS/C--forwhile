
//Verilmis ededin musbet veya menfi oldugunu yoxlayin
#region Task1
//Console.WriteLine("bir eded daxil edin"  );
//int eded=int.Parse(Console.ReadLine());
//if (eded>0)
//{
//    Console.WriteLine( "bu eded musbetdir" );

//}
//else
//{
//    Console.WriteLine("menfidir");
//}
#endregion


//100dan 2ye kimi 2-2 azaltmaqla ededleri cixar
#region Task2
//for (int i = 100; i >= 2; i-=2)
//{
//    Console.WriteLine(  i);
//}
#endregion

#region Task3
//for (int i = 0; i <= 100; i ++)
//{
//    if (i == 5 ||i==10 )
//    {
//        break;
//    }
//    Console.WriteLine(i);
//}
#endregion

#region Task4
//int[] ededler = { 5, 3, 7, 3, 8, 3 };

//for (int i = 0; i < ededler.Length; i++)
//{
//    //if (ededler[i]==7)
//    //{
//    //	Console.WriteLine(i);
//    //       break;
//    //}
//    if (i == 3)
//    {
//        Console.WriteLine(ededler[i]);
//    }
//}
#endregion

#region Task5
//int cem =0;
//for (int i = 0; i < 100; i++)
//{
//	if (i % 2==0&& i%3==0)
//	{
//		cem=cem + i;
//	}
//}
//Console.WriteLine("ededlerin cemi"+cem);
#endregion

#region Task6
//int cem = 0;
//for (int i = 0; i < 100; i++)
//{
//	if (i % 2 == 0 || i % 3 == 0)
//	{
//		cem = cem + i;
//	}
//}
//Console.WriteLine("ededlerin cemi" + cem);
#endregion

#region Task7
//int i = 0;
//while (i<=5)
//{
//    Console.WriteLine(i);
//    i++;
//}
#endregion

#region Task8
//int i = 0;
//while (i < 40)
//{

//    Console.WriteLine( i );
//    i++;
//}
#endregion


#region Task9
bool davametsin = true;

while (davametsin)
{
	Console.WriteLine("zehmet olmasa adinizi girin");
	string ad = Console.ReadLine();
	if (ad == "samir")
	{
		davametsin =false;
	}
}
#endregion