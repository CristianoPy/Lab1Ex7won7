/*Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica
daca x este divizibil cu y.
 In cazul in care x este divizibil cu y, programul va afisa “divizibil” iar in caz contrar,
“indivizibil”.*/


Console.WriteLine("Introduce numarul x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduce numarul y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x / y == 0)
{
    Console.WriteLine("X este divizibil cu y. ");
}
else
{
    Console.WriteLine("X nu este divizibil cu y. ");
}

Console.ReadLine();