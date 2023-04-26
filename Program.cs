using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of Shop: ");
        int Shop = Convert.ToInt32(Console.ReadLine());
        bool aa =true;
        char[] underscores = new char[Shop];

        for (int i = 0; i < Shop; i++)
        {
            underscores[i] = '_';
        }

        for (int i = 0; i < Shop; i++)
        {
            Console.Write(underscores[i] + " ");
        }

        Console.WriteLine();
        while(aa){
             int position = Convert.ToInt32(Console.ReadLine());

        if (position >= 1 && position <= Shop)
        {
            underscores[position - 1] = 'x';
        }
        else
        {

        }

        for (int i = 0; i < Shop; i++)
        {
            Console.Write(underscores[i] + " ");
        }
        }
       

        Console.ReadLine();
    }
}