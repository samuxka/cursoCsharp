using System;

class Aula04
{
    int num = 10;

    static void Main()
    {
        int num2 = 0;
    }

    void teste()
    {
        int num3 = 0;
        Console.WriteLine(num);
    }

}

using System;

class Aula04
{
    static int num = 10; //variavel global

    static void Main()
    {
        int num2 = 0; //variavel local
        Console.WriteLine(num);
    }

    void teste()
    {
        int num3 = 0;
        Console.WriteLine(num);
    }

}