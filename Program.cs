using System.Linq;

string[] strTestArray = new string[8]{"tree","kolobok", "words", "yes", "me", "add", "one", "bear"};
string[] strArray;
string text = string.Empty;

//===================================================================================================
// функция принимает строку из слов, разделенных запятыми и возвращает массив из этих слов,
string[] InputStringArray(string textArg)                          
                                    
{
    var data = textArg.Split(",") 
                .Select(e => e = e.Replace(" ", string.Empty))
               // .Where(e => e.Length <= 3)                                                                    
                .ToArray(); 

    return data;
}

//===================================================================================================
//Функция выводит в консоль строковый массив
void printArray(string[] arr)
{
    string strPrint = string.Empty;

    
        for(int i = 0; i < arr.Length; i++)
        {
            strPrint = strPrint + arr[i] + ", ";    
        }
   
    Console.WriteLine(strPrint);
}

//===================================================================================================
// Функция возвращает новый строковый массив со строками из введенного массива длиной 3 и менее букв
string[] toThreeAndLess(string[] arr)
{
    int tempArrLength = arr.Length;
    string[] tempArr = new string[arr.Length];
    int currPos = 0;
    
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <=3) 
        {
            tempArr[currPos] = arr[i];
            currPos++;   
        }
    }

    string[] arrThreeAndLess = new string[currPos];
    for(int i = 0; i < currPos; i++)
    {
        arrThreeAndLess[i] = tempArr[i];
    }

    return arrThreeAndLess;
}