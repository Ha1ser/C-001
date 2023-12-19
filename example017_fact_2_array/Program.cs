double Fact (int n){
    // 1! = 1

    if(n == 1) return 1;
    else return n * Fact(n - 1);
}

for (int i = 1; i < 40; i++){
    Console.WriteLine($"{i}! = {Fact(i)}");
}

