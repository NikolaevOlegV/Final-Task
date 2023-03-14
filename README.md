# Final-Task
Работу выполнин Николаев Олег.

Данная работа необходима для проверки знаний и навыков по итогу прохождения первого блока обучения на программе разработчик.
Для выполнения работы необходимо выполнить следующий алгоритм:

Создать репозиторий на GitHub;
Нарисовать блок-схему алгоритма (находится в папке "Final Task");
Создать файл "README.md" и сделать оформление репозитория;
Написать программу;
Использовать контроль версий в работе.
Условие задачи контрольной работы:
Написать программу, которая из имеюшегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Задача реализована с помощью трех методов:

InputArray(param);
ArraySort(param);
PrintArray(param);
Получаем введеную от пользователя информацию.
Передаем массив строк в метод сортировки.
Проверяем количество элементов массива не более 3х символов.
Создаем новый массив длинной по количеству элементов не более 3х символов.
Записываем элементы не более 3х символов в новый массив.
Возвращаем новый массив и выводим его в консоль.
InputArray()
С помощью данного метода получаем значения типа string, введенные пользователем.

ArraySort()
Данный метод формирует запрашиваемый условием задачи массив строк.

string[] ArraySort(string[] array)

{

int count = 0; // инициализируем счетчик
for (int i = 0; i < array.Length; i++)
{
    
    
    if (array[i].Length <= 3) // проверяем элемента типа string
        count++; // получаем количество элементов длинной не более трех символов
}
string[] newArray = new string[count]; //создаем новый массив нужной длинны
int k = 0; // счетчик для перебора элементов нового массива
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[k] = array[i]; // записываем значение строки длинной не более 3 символов в новый массив
        k++; 
    }

}
return newArray; // возвращаем полученный массив
}

PrintArray(param);
Решение задачи контрольнй работы:
Исходный массив будет изначально задан 
Алгоритм решения:
Создаем строковый массив, с помощью метода и выводим его. Это будет наш исходный массив;
Создаем второй метод, в котором указываем строковый массив.
Далее создаем цикл, в котором будут перебираться элементы массива.
В теле цикла создаем условие перебора, требующееся по условию задачи.
Если условие удовлетворяется, то из ячейки нового массива произойдёт запись текущего элемента в ячейку исходного массива.
Затем выведем полученный результат.
