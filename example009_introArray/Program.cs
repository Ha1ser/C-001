//функция нахождения максимального значения
int Max(int arg1, int arg2, int arg3){

    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}


int[] array = {1854, 2545, 3399, 422, 543, 623, 779, 842, 94};
//array[0] = 999;
//Console.WriteLine(array[0]);

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);

