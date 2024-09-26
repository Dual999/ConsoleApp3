// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//ДЗ 1
//Запросить у пользователя некоторое количество цифр на вход (от 3 до 7)
//все цифры сложить в массив по порядку
//обработать возможные ошибки через try - catch 
//по окончанию ввода от пользователя вывести на экран среднее арифметическое значение всех введённых чисел

try
{
    Console.WriteLine("Введите первое число от 3 до 7");
    string? n1 = Console.ReadLine();
    Console.WriteLine(" Введите второе числоот 3 до 7");
    string? n2 = Console.ReadLine();
    int number1 = Convert.ToInt32(n1);
    int number2 = Convert.ToInt32(n2);
    int[] arr = new int[2] { number1, number2 };
    Console.WriteLine("Среднее этих чисел: {0}", arr.Average());

}
catch
{
    Console.WriteLine("Ошибка! Я не знаю этот тип данных");
}
