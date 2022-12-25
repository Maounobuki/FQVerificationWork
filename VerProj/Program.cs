
Console.WriteLine("Укажите количество вводимых данных: ");
int m = int.Parse(Console.ReadLine()!);
string [] usdata = ArrInput(m);
Console.WriteLine($"Массив:  [{String.Join(" , ",usdata)}]");
int lenght = ThreeCharCount(usdata);
string [] th = ArrInputThree(usdata, lenght);
Console.WriteLine($"Массив:  [{String.Join(" , ",th)}]");





//-------------methods-----------------------



string [] ArrInput(int lenght)
{
string [] cell = new string [lenght];

for (int i = 0; i<lenght; i++)
{
    Console.WriteLine("Введите значение: ");
    cell[i] = Console.ReadLine()!;
   }
return cell;
}
 
 
 int ThreeCharCount (string [] arr )
 {
    int count = 0;
    for (int i = 0; i<arr.Length; i++)
    {
    if(arr[i].Length<=3)
    {
        count++;
    }
    }
    return count;
 }

 string [] ArrInputThree(string [] arr, int len )
{
string [] three = new string [len];
int n = 0;
for(int i = 0; i<arr.Length; i++)
{
    
    if(arr[i].Length < 4)
    {
       three[n] = arr[i];
         n++; 
    }
 }
 return three;
 }