int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArr(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelSort(int[] array){
    for(int i = 0; i < array.Length - 1; i++){
        int minPos = i;

        for(int u = i + 1; u < array.Length; u++){
            if(array[u] > array[minPos]) {minPos = u;}
        }
        int temp = array[i];
        array[i] =  array[minPos];
        array[minPos] = temp;

    }
}
PrintArr(arr);

SelSort(arr);
PrintArr(arr);
