// вид 1
void Method1(){
    Console.WriteLine("Автор ... ");
}

// Запуск метода
// Method1();



// вид 2
void Method2(string msg){
    Console.WriteLine(msg);
}

// Запуск метода
//Method2("текст сообщения");


void Method2_1(string msg, int count){
    int i = 0;
    while (i < count){
    Console.WriteLine(msg);
    i++;
    }
}

//Method2_1("text", 5);  // или Method2_1(msg: "text", count: 5);



// вид 3
int Method3(){
    return DateTime.Now.Year;
}

//int year = Method3();
//Console.WriteLine(year);



// вид 4
// string Method4(int count, string text){
//     int i = 0;
//     string result = string.Empty; // string.Empty; == "";
//     while(i < count){
//         result = result + text;
//         i++;
//     } 
//     return result;
// } 

// string res = Method4(10, "Y");
// Console.WriteLine(res);

string Method4(int count, string text){
    string result = string.Empty; // string.Empty; == "";
    for(int i = 0; i < count; i++){
        result = result + text;
    } 
    return result;
} 

//string res = Method4(10, "Y");
//Console.WriteLine(res);



for (int i = 2; i <= 10; i++){

    for (int t = 2; t <= 10; t++){
        Console.WriteLine($"{i} * {t} = {i * t}");
    }
    Console.WriteLine();
}



