int[] array = {12, 45, 4, 32, 89, 4, 72};

int n = array.Length;
int find = 4;
int index = 0;

while (index < n){
    if (array[index] == find) {
        Console.WriteLine(index + "  каеф");
        break;
        }
    index++;

}


