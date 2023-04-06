///> Vladislav Hmilnickij:

////////////////////////////////////////////

///1) создать список "List" интов например от 1 до 10 и все четные числа выводить умноженными на 2, через форич

///2) с помощью любого цикла заменить все нечётные числа на 1

List<int> nums = new List<int>
{ 1, 9, 3, 4, 5, 6, 7, 11, 2, 10, 8, 12, 13, 14, 15 };
Console.Write(" Full masive: ");

foreach (int num in nums)
{   
    Console.Write(num + " ");
}

Console.WriteLine();

Console.Write("\n Even multiplied by two: ");
foreach (int i in nums)
{
    if (i % 2 == 0)
        Console.Write($" {i * 2} ");
    else
        Console.Write($" {i - i + 1} ");
}

Console.WriteLine();

Console.Write("\n Odd ones are replaced by one: ");
for (int i = 0; i < nums.Count; i++)
{
    if (nums[i] % 2 == 1)
    {
        nums[i] = 1;
        Console.Write(nums[i] + " ");
    }
}

Console.WriteLine();
Console.WriteLine();

///3) создать новый список интов и в него записать из первово списка те значения которые больше 10 и меньше 7

///4) нужно отсортировать второй список и вывести все элементы через фор

Console.WriteLine();

Console.Write("Sorting of numbers: ");
int[] numbers = { 1, 3, 2, 8, 7, 15, 5, 9, 6, 13, 11, 12, 4, 10 };
var orderedNumbers = from i in numbers
                     orderby i
                     select i;
foreach (int i in orderedNumbers)
    Console.Write(i + " ");

Console.WriteLine();
Console.WriteLine();

//////////////////////////////////////////

var selectedNumber = nums.Where(a => a > 10 || a < 7).Select(a => a+6);

foreach (int ints in selectedNumber)
    Console.Write(ints + " ");

Console.WriteLine();


//////////////////////////////////////////
