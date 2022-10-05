double ReadNums(string text){
    Console.Write($"Введите {text}: ");
    return Convert.ToDouble(Console.ReadLine());
}

double b1 = ReadNums("b1");
double k1 = ReadNums("k1");
double b2 = ReadNums("b2");
double k2 = ReadNums("k2");


if (k1 == k2 && b1 == b2){
    Console.WriteLine("Прямые совпадают");
}else if (k1 == k2){
    Console.WriteLine("Прямые параллельны");
}else{

    double x = (b1-b2)/(k2-k1);
    double y = (k2*b1-k1*b2)/(k2-k1);

    Console.WriteLine($"x:{x}, y:{y}");

}