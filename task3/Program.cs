// Принять на вход число от 1 до 7 и определить, какой это день недели
 
 Console.WriteLine("Введие число от 1 до 7");
 int n = Convert.ToInt32(Console.ReadLine());
 
 bool FindNameOfDay(int x){
    if(x<=7 && x>=6){
        return true;
    }
    else{
        return false;
    }
 }
 if(n>=1 && n<=7){
 bool result = FindNameOfDay(n);
if(result == true ){
Console.WriteLine("да");
 }
else{
Console.WriteLine("нет");
 }
 }
 else {
   Console.WriteLine("проверьте число"); 
 }


