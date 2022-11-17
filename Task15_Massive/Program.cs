// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели");
int day = Convert.ToInt32(Console.ReadLine());
int[] array = new int[] {1, 2, 3, 4, 5, 6, 7};
int len = array.Length;
int index = 0;

while (index <= len)
{ 
   
    if (array[index] == day)
    {
       if (array[index] == 6 || array[index] == 7)
       {
        Console.WriteLine("Выходной день");
       } 
    
else  
{
        Console.WriteLine("Не является выходным");
}
        break;
} else 
{
        index++; 
}
}