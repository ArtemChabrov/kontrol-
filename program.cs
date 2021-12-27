// See https://aka.ms/new-console-template for more information
Console.Write("Количество натуральныx чисел в массиве = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.Write("Введите числа: \n ");          
            for (int i = 0; i < n; i++)   
            {
                Console.Write(" \r a[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
                
            }
            
            List<int> b = new List<int>();
            foreach(int i in a)
            {
                if(i%2 == 0) b.Add(i);
            }
            
            Console.Write("Кол-во четных чисел:{0}", b.Count);
            for (int t = 0; t < b.Count; t++)
            {
                Console.Write("\t [{0}]", b[t]);
            }
 
            Console.Write("\nНажмите для завершения =) . . . ");
            Console.ReadKey(true);