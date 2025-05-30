using System;

namespace FirstCode
{
    internal class Program
    {
        //array example print 5 intigers
using System.Net.Security;
using System.Text;

Console.WriteLine("#### Printing intigers using array");
int[] larr = new int[5];
Console.WriteLine("enter a value for integer");
for (int i=0;i<5;i++)
{
    larr[i] =Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("values entered are as follow");
for(int i=0;i<5;i++)
{
    Console.WriteLine(larr[i]);
}






//find minimum value using array
Console.WriteLine("#### Printing min value");
int[] larr1 = new int[] { 1, 33, 44, 72, 4 };
int lintmin = larr1[0];
for (int i = 1; i < 5; i++)
{
    if (lintmin > larr1[i])
    {
        lintmin = larr1[i];
    } }
    Console.WriteLine("min value is" + lintmin);





//find maximum value using array
Console.WriteLine("#### Printing max value");
int[] larr2 = new int[] { 1, 33, 44, 72, 4 };
int lintmax = larr1[0];
for (int i = 1; i < 5; i++)
{
    if (lintmax < larr2[i])
    {
        lintmax = larr2[i];
    }
}
Console.WriteLine("max value is" + lintmax);





//loop for 1 to 10
Console.WriteLine("####printing 1 to 10 using loop");
for(int i=1;i<=10;i++)
{
    Console.WriteLine(i);
}





//loop for printing table of 5
Console.WriteLine("####printing table of 5 using loop");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i*5);
}




//loop for print even number
Console.WriteLine("####printing even numbers using loop");
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)

    {
        Console.WriteLine(i);
    }
}





//printing Even number using another trick
//for(i=2;i<=10;i=i+2)
//{
//Console.WriteLine(i);
//}

//printing Odd number using another trick
//for(i=1;i<=10;i=i+2)
//{
//Console.WriteLine(i);
//}

//nested loop
Console.WriteLine("####Printing star in rectangle form");
Console.WriteLine("enter how many values you need to print rectangle");

int count = Convert.ToInt32(Console.ReadLine());

for(int i=1;i<=count;i++)
{
    for(int j=1;j<=count;j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}





//nested loop
Console.WriteLine("####Printing star in triangle form");
Console.WriteLine("enter how many values you need to print triangle");
int count1 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= count1; i++)
{
    for (int j = 1; j <=i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}





//for a piramid triangle
Console.WriteLine("####piramid triange");
Console.WriteLine("enter how many values you need to print piramid");
int count2 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= count2; i++)
{
    for (int k = count2 - i; k >= 1; k--)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}






//for a reverse piramid triangle
Console.WriteLine("####Revese piramid triange");
Console.WriteLine("enter how many values you need to print reverse piramid");
int count3= Convert.ToInt32(Console.ReadLine());

for (int i = count3; i >= 1; i--)
{
    for (int k = 0; k <count3-i; k++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}






//string revese
Console.WriteLine("####string revese");
{
    static string Reverse(string input)
    {
        StringBuilder reversed = new StringBuilder();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }

        return reversed.ToString();
    }
}





//count digit
Console.WriteLine("count digit");
 int CountTotalDigits(int aint)
{
    int count = 0;
    int intNumber = aint;

    while (intNumber > 0)
    {
        count++;
        intNumber = intNumber / 10;
    }

    return count;
}





//print 1 to 10 using while loop
Console.WriteLine("1 to 10 using while loop ");
{
    int i = 1;
    while (i <= 10)
    {
        Console.WriteLine(i);
        i++;
    }
}




//Add total digit
Console.WriteLine("Add total digit ");
 int AddTotalDigit(int aint)
{
    int Total = 0;
int LintNumber = aint;

while (LintNumber > 0)
{
    Total = Total + LintNumber % 10;
    LintNumber = LintNumber / 10;
}

return Total;
}





//reverse number
Console.WriteLine("Reverse the numbers ");
 int reverse(int aint)
{
    int Total = 0;
int LintNumber = aint;

while (LintNumber > 0)
{
    Total = Total * 10 + LintNumber % 10;
    LintNumber = LintNumber / 10;
}

return Total;
}





//count vovels
Console.WriteLine(" count vovels  ");
int CountVowels(string astr1)
{
    int count = 0;

    for (int i = 0; i < astr1.Length; i++)
    {
        char ch = Char.ToLower(astr1[i]);
        if (ch == 'a' 
            || ch == 'e'
            || ch == 'i'
            || ch == 'o'
            || ch == 'u')
        {
            count++;
        }
    }

    return count;
}

