//  принять число, выдать третью цифру заданного числа или сообщить, что ее нет

Console.WriteLine("Введите число");
string n = Convert.ToString(Console.ReadLine());
if (n.Length > 2){
  Console.WriteLine(n[2]);
}
else{
Console.WriteLine("Нет третьего числа");
}
