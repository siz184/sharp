Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Akk(int M, int N){
    if(M==0){
        return N + 1;
    }else if(M > 0 && N == 0){
        return Akk(M - 1, 1);
    }else{
        return Akk(M - 1, Akk(M, N - 1));
    }
}

Console.WriteLine(Akk(M, N)); 