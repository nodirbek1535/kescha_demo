
        int n, a = 0;
        Console.Write("n=");
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            a = a + i * i - (i - 1) * (i - 1);
        }
        Console.WriteLine(a);
    