using System;
public class Program
{
public static void Main()
{
System.Console.Write("Enter the number of rows for Pascal's Triangle: ");
int numRows = int.Parse(Console.ReadLine());
System.Console.Write("Pascal's Triangle:\n");
PrintPascalsTriangle(numRows);
}
public static void PrintPascalsTriangle(int numRows)
{
for (int i = 0; i < numRows; i++)
{
for (int j = 0; j < numRows - i - 1; j++)
{
System.Console.Write("  ");
}for (int j = 0; j <= i; j++)
{
System.Console.Write("*   ");
}
System.Console.WriteLine();
}
}
}