////1.Visual studio - Console Application
////2.Создать программу работы c матрицами (двухмерными массивами)
////3.Возможность выбора размера матрицы
////4. Элементы вводятся вручную
////5. Вывести матрицу на консоль (добавить оформление, чтобы выглядело как матрица)
////-Реализовать меню выбора действий(минимум 1 на выбор):
////-Найти количество положительных/отрицательных чисел в матрице
//- Сортировка элементов матрицы построчно (в двух направлениях)
//-Инверсия элементов матрицы построчно
using System.Reflection.Metadata.Ecma335;

bool RepeatSwitch = false;
string MenuOption;
string case1select;
string case2select;
int positiveCount = 0;
int negativeCount = 0;
int temp;
Random rand = new Random();


Console.WriteLine("Enter first limit X ...");
int str = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second limit Y ...");
int stolb = int.Parse(Console.ReadLine());
int[,] array = new int[str, stolb];
Console.WriteLine($"Array created with {str} and {stolb} limits");

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int c = 0; c < array.GetLength(1); c++)
//    {
//        Console.WriteLine($"Enter [{i} , {c}] element: ");
//        array[i, c] = int.Parse(Console.ReadLine());
//    }
//}
GetRandomArray();
Console.WriteLine();

while (!RepeatSwitch)
{
    Console.WriteLine("\n\tSelect option: \n\t1. Positive / Negative count \n\t\tA.Positive \n\t\tB.Negative \n\t2. Sort array 2 ways \n\t\tA.Back \n\t\tB.Forth \n\t3. Inversion \n\t4. Quit");
    MenuOption = Console.ReadLine();
        switch (MenuOption)
    {
        case "1":
                Console.WriteLine("\t\tA. Positive \n\t\tB. Negative");
                case1select = Console.ReadLine();
                switch (case1select)//Selecting second option in this menu
                {
                    case "A":
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            if (array[i, j] > 0)
                                positiveCount++;
                            else
                                negativeCount++;
                              
                        }
                    }
                    Console.WriteLine($"\nPositive numbers amount: {positiveCount}");
                     break;
                    case "B":
                    Console.WriteLine($"\nNegative numbers amount: {negativeCount}");
                     break;
                    default:
                    Console.WriteLine("Wrong input");
                     continue;
                    case "a":
                     goto case "A";
                    case "b":
                     goto case "B";
                }
            break;


        case "2":
            Console.WriteLine("\t\tA. Back \n\t\tB. Forth");
            case2select = Console.ReadLine();
            switch (case2select)//Selecting second option in this menu
            {
                case "A"://Sorts array from high to low
                    for (int i = 0; i < array.GetLength(1); i++)
                    {
                        for (int с = 0; с < array.GetLength(0); с++)
                        {
                            for(int j = 0; j < array.GetLength(1) - с - 1; j++)
                            {
                                if (array[i,j] < array[i,j+1])
                                {
                                    temp = array[i,j+1];
                                    array[i,j+1] = array[i,j];
                                    array[i,j] = temp;
                                }
                            }
                            

                        }
                    }
                    ArrayView();
                    Console.WriteLine();
                     break;


                    case "B"://Sorts array from low to high
                    for (int i = 0; i < array.GetLength(1); i++)
                    {
                        for (int с = 0; с < array.GetLength(0); с++)
                        {
                            for (int j = 0; j < array.GetLength(1) - с - 1; j++)
                            {
                                if (array[i, j] > array[i, j + 1])
                                {
                                    temp = array[i, j + 1];
                                    array[i, j + 1] = array[i, j];
                                    array[i, j] = temp;
                                }
                            }
                        }
                    }
                    ArrayView();
                    Console.WriteLine();
                    break;


                case "a":
                    goto case "A";


                case "b":
                    goto case "B";                                                                                       /*{12 11 13 26 89}
                                                                                                                           {9  7  15 86 25}   */
            }
            break;
        case "3"://Inverts the array
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int c = 0; c < array.GetLength(1)/2; c++)
                {
                    //for (int j = array.GetLength(1)-1; j > array.GetLength(1)/2; j--)
                    
                        
                            temp = array[i, c];
                            array[i, c] = array[i, array.GetLength(1) - c - 1];
                            array[i, array.GetLength(1) - c - 1] = temp;
                     
                }
            }
            ArrayView();
            break;
        case "4":
            RepeatSwitch = true;
            break;
        default:
            Console.WriteLine("\n\t<!>Wrong option, please select the correct one<!>");
            continue;
        }
    
}

void GetRandomArray()//Geting array filled with random numbers (<100)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(-100, 100);
            Console.Write($"\t{array[i, j]}");
        }
    }
}

void ArrayView()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {            
            Console.Write($"\t{array[i, j]}");
        }
    }
}
