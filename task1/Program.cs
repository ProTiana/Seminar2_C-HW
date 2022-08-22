//  принять 3х значное число и вернуть вторую его цифру

/*вопрос по задаче: метод типа int всегда выводит значение типа int ?
Если нужно вывести и значение - результат метода и результат проверки, какой тип метода лучше использовать?
не смогла придумать, что вывести, в случаае, когда число не трехзначное. Или проверку нужно делать до метода?*/

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

int FindSecondNumber(int i)
{
    int SecondNumber = 0;
    if (i >= -999 && i <= -100 || i>=100 && i<=999)
    {
        SecondNumber = (i / 10) % 10;
        return SecondNumber;
    }
    else
    {
        SecondNumber = 1000;
        return SecondNumber;
    }
}
int b = FindSecondNumber(n);
if (b == 1000)
{
    Console.WriteLine($"Число {n} не трехзначное. Введите трехзначное число.");
}
else
{
    Console.WriteLine( $"вторая цифра {b}");
}


/* заполнение нового массива
int[] FillArray(int[] array){
    Random random = new Random();
    for(int i = 0; i<array.Length; i++){
        array[i] = random.Next(1,124);
    }
return array;
}
;*/
