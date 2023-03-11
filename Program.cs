﻿using System.Linq;

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