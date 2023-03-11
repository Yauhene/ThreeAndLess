	Данная программа написана для выполнения итогового задания по теме "Итоги блока. Выбор специализации":

	Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Основной функцией, выполняющей данную работу в программе является toThreeAndLess (string[] toThreeAndLess(strArray)).

	Функция получает исходный массив, формирует аналогичный (временный) массив из пустых строк, далее вносит в него значения из
исходного массива, соответствующие требованиям задания (слова не длиннее 3 знаков) и параллельно рассчитывает размер (количество элементов)
выходного массива. После чего создает выходной массив и копирует в него непустые значения из временного массива. Таким образом, выходной массив
не содержит пустых элементов. 

	Программа подразумевает два пути демонстрации решения:
		1. Использование заранее заложенного в программе исходного массива;
		2. Использование массива, введенного пользователем. В этом случае решено вводить элементы массива в виде строки, разделяя элементы 
			запятыми. Это быстрее и проще, чем запрашивать у пользователя количество элементов на старте с последующим пошаговым заполнением 
			ими массива. 
		
	Задачу преобразования строки, введенной пользователем выполняет функция InputStringArray(text), где text - строковая переменная, введенная 
пользователем.

	Визуализация решения выполняется с помощью метода printArray(strArray), который выводит содержимое массива в консоль в виде строки.
	
	Программа построена на основе циклического меню (цикл While), реализованного в методе mainMenu(), вариант работы выбирается по введенному пользователем числу 
("1" для работы со встроенным в программу массивом, "2" для введения собственного массива), выход осуществляется при выборе "q" либо "Q".
Во всех иных случаях программа указывает пользователю на некорректный выбор.

![Блок-схема](/Graphics/Project_Draft.jpg "Блок-схема алгоритма задания") 