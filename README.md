# QuickSortConsole


**Descrição:**
O "QuickSortConsole" é um programa em C# que implementa o algoritmo de ordenação QuickSort. Este algoritmo é conhecido por sua eficiência e ampla utilização na prática. Ele opera dividindo o array em duas partes, selecionando um elemento pivot e particionando o array de forma que os elementos menores que o pivot fiquem à sua esquerda e os maiores à sua direita. Essa operação é realizada recursivamente em cada parte do array até que todo o array esteja ordenado.

**Funcionalidades:**
- Ordena um array de inteiros utilizando o algoritmo QuickSort.
- Imprime o array antes e depois da ordenação.

**Componentes:**
- `Main`: O método principal que inicializa o programa e chama as funções de ordenação e impressão.
- `QuickSort`: Método responsável por ordenar o array utilizando o algoritmo QuickSort. Este método é recursivo e divide o array em partições menores.
- `Partition`: Método auxiliar que seleciona um pivot e rearranja os elementos do array de forma que os elementos menores que o pivot fiquem à esquerda e os elementos maiores à direita.
- `Swap`: Método auxiliar para trocar os valores de duas variáveis inteiras.
- `PrintArray`: Método auxiliar para imprimir o conteúdo do array.

**Como usar:**
1. Compile o programa utilizando um compilador de C#.
2. Execute o programa.
3. O programa imprimirá o array antes e depois da ordenação.

**Exemplo de uso:**
```csharp
int[] array = { 12, 4, 56, 7, 23, 89, 45, 3, 10 };
Console.WriteLine("Array antes da ordenação:");
PrintArray(array);

QuickSort(array, 0, array.Length - 1);

Console.WriteLine("\nArray depois da ordenação:");
PrintArray(array);
```

**Nota:**
Este programa é uma implementação simples do algoritmo QuickSort em C# e pode ser usado para entender os conceitos básicos do algoritmo de ordenação. Para uso em produção, recomenda-se utilizar implementações de bibliotecas de algoritmos de ordenação padrão, como as fornecidas pela própria biblioteca do .NET.
