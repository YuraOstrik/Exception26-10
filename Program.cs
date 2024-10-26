namespace Exception24._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Passport passport = new Passport(21203029, "Иван Петров", 20210);
                passport.DisplayInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }


            //while(true)
            //{
            //    try
            //    {
            //        Console.WriteLine("\n--- Калькулятор перевода систем исчисления ---");
            //        Console.WriteLine("1. Перевести из десятичной в двоичную");
            //        Console.WriteLine("2. Перевести из двоичной в десятичную");
            //        Console.WriteLine("0. Выход");
            //        Console.Write("Выберите направление перевода: ");

            //        int choice = int.Parse(Console.ReadLine());
            //        if (choice == 0) break;

            //        Console.WriteLine("Введите число ");
            //        string input = Console.ReadLine();

            //        switch(choice)
            //        {
            //            case 1:
            //                int bin = int.Parse(input);
            //                Console.WriteLine($"Результат: {Convert.ToString(bin, 2)}");
            //                break;
            //            case 2: 
            //                int dec = Convert.ToInt32(input, 2);
            //                Console.WriteLine($"Результат: {dec}");
            //                break;
            //            case 0:
            //                Console.WriteLine("Not not not");
            //                break;

            //        }

            //    }
            //    catch (FormatException )
            //    {
            //        Console.WriteLine("Ошибка ввода ");
            //    }
            //    catch (OverflowException )
            //    {
            //        Console.WriteLine("Число выходит за пределы допустимого");
            //    }
            //}


        }

        class Passport
        {
            private int num; 
            private string fio; 
            private int issueYear; 

            
            public Passport(int n, string f, int d)
            {
                
                if (n.ToString().Length != 9)
                {
                    throw new ArgumentException("Номер паспорта должен содержать 9 цифр.");
                }

                
                if (d.ToString().Length != 4)
                {
                    throw new ArgumentException("Год выдачи должен содержать 4 цифры.");
                }

                this.num = n;
                this.fio = f;
                this.issueYear = d;
            }

            
            public int Num
            {
                get { return num; }
                set { num = value; }
            }

            public string Fio
            {
                get { return fio; }
                set { fio = value; }
            }

            public int IssueYear
            {
                get { return issueYear; }
                set { issueYear = value; }
            }

            
            public void DisplayInfo()
            {
                Console.WriteLine("Информация о заграничном паспорте:");
                Console.WriteLine($"Номер паспорта: {num}");
                Console.WriteLine($"ФИО: {fio}");
                Console.WriteLine($"Год выдачи: {issueYear}");
            }
        }
    }
}
