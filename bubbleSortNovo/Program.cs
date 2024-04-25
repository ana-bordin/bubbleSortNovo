//faça um programa em que o vetor 2 tenha numeros ordenados e sem repetidos e o vetor 3 tenha a ordem decrescente;

int tamanho = 20, aux;
bool zero = false, zeroFim = false, repetido = false;
int[] vetorOriginal = new int[tamanho], vetorOrdenado = new int[tamanho], vetorDecrescente = new int[tamanho];

void LerMatriz(int[] vetor, bool zero, bool zeroFim)
{
    for (int i = 0; i < tamanho; i++)
    {
        if (vetor[i] != 0 || zero == true) {
            {
                Console.Write($"{vetor[i]}");
                zero = false;
            }         
        }
        if (vetor[i] == 0 && zeroFim == true) 
        {
            zeroFim = false;
            Console.Write($"{vetor[i]}");
        }
    }
}

Console.WriteLine("\nVetor sem ordenação:");
for (int i = 0; i < tamanho; i++)
{
    vetorOriginal[i] = new Random().Next(0, 10);
    vetorOrdenado[i] = vetorOriginal[i];
    if (vetorOrdenado[i] == 0)
        zero = true;
}
LerMatriz(vetorOriginal, zero, zeroFim);

Console.WriteLine("\nVetor Ordenado com repetidos:");
for (int i = 0; i < tamanho; i++)
{
    for (int j = i + 1; j < tamanho; j++)
    {
        if (vetorOrdenado[i] > vetorOrdenado[j])
        {
            aux = vetorOrdenado[i];
            vetorOrdenado[i] = vetorOrdenado[j];
            vetorOrdenado[j] = aux;
        }
    }
}
zero = false;
LerMatriz(vetorOrdenado, zero, zeroFim);

Console.WriteLine("\nVetor com ordenação e sem repetidos:\n");
for (int i = 0; i < tamanho - 1; i++)
{
    for (int j = i + 1; j < tamanho - 1; j++)
    {
        if (vetorOrdenado[i] == vetorOrdenado[j])
            vetorOrdenado[i + 1] = vetorOrdenado[j + 1];
    }
}
for (int i = 0; i < tamanho - 1; i++)
{
    for (int j = i + 1; j < tamanho; j++)
    {
        if (vetorOrdenado[i] == vetorOrdenado[j])
            repetido = true;
        if (repetido == true)
            vetorOrdenado[j] = 0;
    }
}
if (vetorOrdenado[0] == 0)
    zero = true;
LerMatriz(vetorOrdenado, zero, zeroFim);

Console.WriteLine("\nVetor com ordenação decrescente:\n");
int x = 0;
for (int i = tamanho - 1; i > -1; i--)
{
    if (vetorOrdenado[i] != 0 || (i == 0 && vetorOrdenado[i] == 0))
    {
        vetorDecrescente[x] = vetorOrdenado[i];
        x++;
        if (i == 0 && vetorOrdenado[i] == 0)
            zeroFim = true;
    }   
}
zero = false;
LerMatriz(vetorDecrescente, zero, zeroFim);
