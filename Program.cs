Double Pnumero = 0;
Double Snumero = 0;

           Console.WriteLine("Favor digitar o Pnumero:");
Pnumero = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Favor digitar o Snumero:");
Snumero = Convert.ToDouble(Console.ReadLine());


if (Pnumero > Snumero)
{
    Console.WriteLine($"O {Pnumero} é maior que o {Snumero}");
}
else 
{
    Console.WriteLine($"O {Snumero} é maior que o {Pnumero}");
}