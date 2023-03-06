Console.WriteLine("Введите натуральное число: ");
            int n= int.Parse(Console.ReadLine());
            f(n);
            Console.Read();
static void f(int n)
        {
            Console.WriteLine(n);
            n-=1;
            if(n>0)
                f(n);
        }
