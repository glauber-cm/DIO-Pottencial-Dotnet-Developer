        int qt = int.Parse(Console.ReadLine());
        string[] v = new string[2];

        for (int i = 0; i < qt; i++ )
        {
            
            v = Console.ReadLine().Split(' ');    

            string a = v[0];
            string b = v[1];

            if (  b[1] > a[0] )
                Console.WriteLine("nao encaixa");
            else if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");

        }