using System;//namespace is at the top so that you can call it through out the program

class Program
{
public static void Main()
{
int num1, num2;

Console.WriteLine("Enter the first number");
num1 = Convert.ToInt32(Console.ReadLine());//Readline allows the user to enter a number but it defaults as string so convert

Console.WriteLine("Enter the second number");
num2 = Convert.ToInt32(Console.ReadLine());

int sum = num1 + num2;

Console.WriteLine("Addition is : {0}",sum);
Console.Write("Good Morning");//Write stays on the same line
Console.WriteLine("How are you doing?");//writeline moves the text to the next line
}
}