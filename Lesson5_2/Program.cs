        var rnd = new Random();
            var arr = new int[11];
 
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0}\t", arr[i] = rnd.Next(-10, 10));
            Console.WriteLine(new Random());
 
        
            var odd = arr.Where((element, index) => index%2!=0);
            
            Console.WriteLine("Элементов нечетных позиций: Количество: {0}. Сумма: {1}.", odd.Count(), odd.Sum());
 
            Console.ReadKey();