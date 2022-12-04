// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите число,соответствующее дню недели ");
int num = int.Parse(Console.ReadLine());
if (num >=6){
    Console.WriteLine("Да");
}
else{
    Console.WriteLine("Нет");
}