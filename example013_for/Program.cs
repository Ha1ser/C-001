string text = "каруСель каруСель это радость для нас каруСель каруСель это радоСть для всех";

string Replace(string text, char oldValue, char newValue){
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++){
        if(text[i] == oldValue){result = result + $"{newValue}";}
        else {result = result + $"{text[i]}";}
    }

    return result;

}

string w = Replace(text, ' ', '_');
Console.WriteLine(w);

Console.WriteLine();

w = Replace(w, 'к', 'К');
Console.WriteLine(w);

Console.WriteLine();

w = Replace(w, 'С', 'с');
Console.WriteLine(w);




