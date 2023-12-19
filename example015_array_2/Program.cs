// двумерный массив для строк
// string[,] table = new string[2, 5];
// table[1, 2] = "слово";


// for (int rows = 0; rows < 2; rows++){
//     for(int columns = 0; columns < 5; columns++){
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }

// }




void PrintArr(int[,] mat){
    for (int rows = 0; rows < mat.GetLength(0); rows++){
        for(int columns = 0; columns < mat.GetLength(1); columns++){
            Console.Write($"{mat[rows, columns]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] mat){
    for(int i = 0; i < mat.GetLength(0); i++){
        for(int j = 0; j < mat.GetLength(1); j++){
            mat[i, j] = new Random().Next(1, 10);
        }
    }
    
}

int[,] matrix = new int[3, 4];
PrintArr(matrix);

Console.WriteLine();

FillArray(matrix);
PrintArr(matrix);