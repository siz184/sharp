void PrintArrayString(int[,] arr){
    for(int i=0; i<arr.GetLength(0); i++){
        for(int j=0; j<arr.GetLength(1); j++){
           Console.Write($"{CheckFirstNull(arr[i,j])} ");
        }
        Console.WriteLine();
    }
}

string CheckFirstNull(int nums){
    string strings = String.Empty;
    if(nums < 10){
        strings = "0" + Convert.ToString(nums);
    }else{
        strings = Convert.ToString(nums);
    }
    return strings;
}

bool stepRight(int[,] arr, int i, int j){
    j++;
    if(j<5){
        if(arr[i,j]==0){
            return true;
        }else{
            return false;
        }
    }
    return false;
}

bool stepBottom(int[,] arr, int i, int j){
    i++;
    if(i<5){
        if(arr[i,j]==0){
            return true;
        }else{
            return false;
        }
    }

    return false;
}

bool stepLeft(int[,] arr, int i, int j){
    j--;
    if(j>-1){
        if(arr[i,j]==0){
            return true;
        }else{
            return false;
        }
    }
    return false;
}

bool stepTop(int[,] arr, int i, int j){
    i--;
    if(i>-1){
        if(arr[i,j]==0){
            return true;
        }else{
            return false;
        }
    }
    return false;
}

int[,] arr = new int[5,5]; // 5 x 5 для проверки

int i = 0;
int j = -1;
int k = 1;

while (k<=25){
    if(stepRight(arr, i, j)){
        while(stepRight(arr, i, j)){
            j++;
            arr[i,j] = k;
            k++;
        }
    }else if(stepBottom(arr, i, j)){
        while(stepBottom(arr, i, j)){
            i++;
            arr[i,j] = k;
            k++;
        }
    }else if(stepLeft(arr, i, j)){
        while(stepLeft(arr, i, j)){
            j--;
            arr[i,j] = k;
            k++;
        }
    }else if(stepTop(arr, i, j)){
        while(stepTop(arr, i, j)){
            i--;
            arr[i,j] = k;
            k++;
        }
    }
}
    
PrintArrayString(arr);