int[,,] FillUniqueArray(int x, int y, int z){
    int[] arrTemp = new int[8];
    int[,,] arr = new int[x,y,z];
    int tempEl = 0;
    for(int i=0; i<x; i++){
        for(int j=0; j<y; j++){
            for(int k=0; k<z; k++){
                arr[i,j,k] = FillUniqueElement(arrTemp);    
                arrTemp[tempEl] = arr[i,j,k];   
                tempEl++;
            }
        }
    }
    return arr;
}

int FillUniqueElement(int[] arr){
    Random random = new Random();
    int val = random.Next(10,100);
    if(Array.IndexOf(arr,val)!=-1){
        val = FillUniqueElement(arr);
    }
    return val;
}

void PrintArray(int[,,] arr){
    for(int k=0; k<arr.GetLength(2); k++){
        for(int i=0; i<arr.GetLength(0); i++){
            for(int j=0; j<arr.GetLength(1); j++){
                Console.Write($"{arr[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] arr = FillUniqueArray(2,2,2);
PrintArray(arr);