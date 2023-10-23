
//Напишите прогу, кот-я ан вход принимает три числа,
// и выдает максимальное из этих чисел.

int a = 30;
int b = 40;
int c = 20;

if (a > b && a > c) 
{
    Console.WriteLine(a + "=max");
}
else { 
    if (b > a && b > c)
        Console.WriteLine(b + "=max");

    else {
        Console.WriteLine(c + "=max");
    }    

}

