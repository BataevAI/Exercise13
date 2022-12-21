

/*  
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели от 1 до 7");
int weekDay = 0; 

while ( (weekDay < 1) || (weekDay > 7)) {

 weekDay = Convert.ToInt32(Console.ReadLine());

if ((weekDay < 1) || (weekDay > 7)) {

    Console.WriteLine("Введите номер дня недели от 1 до 7");
}


}

if (  (weekDay < 6) && (weekDay > 0)) {

Console.WriteLine("Работа и еще раз работа...");

}

else if (  (weekDay == 6) || (weekDay == 7)) Console.WriteLine("У солдата выходной, пуговицы в ряд!");



