using System;

class Drib
{
    public int чисельник;
    public int знаменник;
    public int ціле;

    public Drib()
    {
        чисельник = 0;
        знаменник = 0;
        ціле = 0;
    }
    public void add(int a)
    {
        знаменник = 0; чисельник = 0;
        if (a != 0) Console.WriteLine("Введіть "+a+" дріб");
        else Console.WriteLine("Введіть дріб");

        Console.WriteLine("Введіть чисельник ");
        чисельник = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть знаменник(крім 0) ");
        while(знаменник == 0) знаменник = Convert.ToInt32(Console.ReadLine());
    }

    public void скорочення()
    {
        bool a = true;
        while (a == true)
        {
            if (знаменник != 1)
            {
                if (знаменник % чисельник == 0)
                {
                    знаменник /= чисельник;
                    чисельник = 1;
                }
                else if (чисельник % знаменник == 0)
                {
                    чисельник /= знаменник;
                    знаменник = 1;
                }
                else if (чисельник % 2 == 0 && знаменник % 2 == 0)
                {
                    чисельник /= 2;
                    знаменник /= 2;
                }
                else if (чисельник % 3 == 0 && знаменник % 3 == 0)
                {
                    чисельник /= 3;
                    знаменник /= 3;
                }
                else if (чисельник % 5 == 0 && знаменник % 5 == 0)
                {
                    чисельник /= 5;
                    знаменник /= 5;
                }
                else
                {
                    a = false;
                }
            }
            else a = false;
        }
    }
    public void see()
    {
        if (ціле != 0)
        {
            Console.Write(ціле + " ");
        }
        Console.Write(чисельник + "|" + знаменник + "\n\n");
    }

}

class Program
{
    void додавання(Drib[] drib)
    {
        Drib rezult = new Drib();
        rezult.знаменник = drib[0].знаменник * drib[1].знаменник;
        rezult.чисельник = drib[1].знаменник * drib[0].чисельник + drib[0].знаменник * drib[1].чисельник;
        rezult.скорочення();
        rezult.see();

    }
    void віднімання(Drib[] drib)
    {
        Drib rezult = new Drib();
        rezult.знаменник = drib[0].знаменник * drib[1].знаменник;
        rezult.чисельник = drib[1].знаменник * drib[0].чисельник - drib[0].знаменник * drib[1].чисельник;
        rezult.скорочення();
        rezult.see();

    }
    void множення(Drib[] drib)
    {
        Drib rezult = new Drib();
        rezult.знаменник = drib[0].знаменник * drib[1].знаменник;
        rezult.чисельник = drib[0].чисельник * drib[1].чисельник;
        rezult.скорочення();
        rezult.see();

    }
    void ділення(Drib[] drib)
    {
        Drib rezult = new Drib();
        rezult.знаменник = drib[0].знаменник * drib[1].чисельник;
        rezult.чисельник = drib[0].чисельник * drib[1].знаменник;
        rezult.скорочення();
        rezult.see();

    }
    void Ціле(Drib drib)
    {
        Drib rezult = new Drib();
        if (drib.чисельник >= drib.знаменник)
        {
            rezult.ціле = drib.чисельник / drib.знаменник;
            rezult.чисельник = drib.чисельник - rezult.ціле * drib.знаменник;
            rezult.знаменник = drib.знаменник;
        }
        else
        {
            rezult.чисельник = drib.чисельник;
            rezult.знаменник = drib.знаменник;
        }
        if (rezult.чисельник == 0)
        {
            Console.WriteLine(rezult.ціле);
        }
        else rezult.see();
    }
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Program mc = new Program();

        Drib[] drib = new Drib[2];
        drib[0] = new Drib();
        drib[1] = new Drib();
        int a;
        while (true)
        {
            a = 0;
            Console.WriteLine("Меню:");
            Console.WriteLine("Скорочення дробу\t - 1");
            Console.WriteLine("Додавання\t - 2");
            Console.WriteLine("Віднімання\t - 3");
            Console.WriteLine("Множення\t - 4");
            Console.WriteLine("Ділення\t - 5");
            Console.WriteLine("Виокремлення цілої частини\t - 6");

            a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                Console.Clear();
                drib[0].add(0);
                drib[0].скорочення();
                drib[0].see();
            }
            else if (a == 2)
            {
                Console.Clear();
                drib[0].add(1);
                drib[1].add(2);
                mc.додавання(drib);
            }
            else if (a == 3)
            {
                Console.Clear();
                drib[0].add(1);
                drib[1].add(2);
                mc.віднімання(drib);
            }
            else if (a == 4)
            {
                Console.Clear();
                drib[0].add(1);
                drib[1].add(2);
                mc.множення(drib);
            }
            else if (a == 5)
            {
                Console.Clear();
                drib[0].add(1);
                drib[1].add(2);
                mc.ділення(drib);
            }
            else if (a == 6)
            {
                Console.Clear();
                drib[0].add(0);
                mc.Ціле(drib[0]);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ви певно напутали");
            }
        }
    }
}



