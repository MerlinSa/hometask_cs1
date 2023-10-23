//напишите прогу, кот-я на вход принимает число N, 
//а на выходе показывает все четные числа от 1 до N.

int N = 15;
int count = 2; // шаг


if(N > 1)
{
    while(count <= N) 
    {
        Console.Write(count + " ");
        count = count + 2;
    }
    
}

