var array = new int[10];

for (int k = 0; k < array.Length; k++)
{
    array[k] = new Random().Next(1,40);
}
Array.ForEach(array, arr => Console.Write(arr+" |"));
Console.WriteLine("\n==================================");

int i = 0;
int j = 0;
while (i < array.Length)
{
    int menorPosicao = i;
    while(j < array.Length)
    { 
        if (array[menorPosicao] > array[j])
        {
            menorPosicao = j;
        }
        j++;
    }

    int aux = array[i];
    array[i] = array[menorPosicao];
    array[menorPosicao] = aux;

    i++;
    j = i;
}

Array.ForEach(array, arr => Console.Write(arr + " |"));
