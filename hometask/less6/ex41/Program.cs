string showSklonenie(int number, string[] sklonenie){
    int lastDigit = number%10;
    if(lastDigit == 1){
        return $"{number} {sklonenie[0]}";
    }else if(lastDigit>1 && lastDigit<5){
        return $"{number} {sklonenie[1]}";
    }else{
        return $"{number} {sklonenie[2]}";
    }
}

int ReadNums(){
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num > 0){
        return 1;
    }else{
        return 0;
    }
}

int M = 4;
int count = 0;
string[] arrSkl = {"число","числа","чисел"};

while(M>0){
    count += ReadNums();
    M--;
}

Console.WriteLine($"Введено {showSklonenie(count,arrSkl)} больше нуля!");