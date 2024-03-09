namespace InterfaceAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                Console.WriteLine("####################################################################");
                Console.WriteLine("1.Square");
                Console.WriteLine("2.Rectangular");
                Console.WriteLine("0.Quit");
                Console.WriteLine("Etmek Istediyiniz Emeliyyati Secin: ");
                bool isCommand = int.TryParse(Console.ReadLine(), out int command);
                if (isCommand)
                {
                    if(command>0 && command < 3)
                    {
                        switch (command)
                        {
                            case 1:
                                Console.WriteLine("Kvadratin Terefini Daxil Edin: ");
                                int side = Convert.ToInt32(Console.ReadLine());
                                Square square = new Square(side);
                                Console.WriteLine($"Kvadratin Sahesi: {square.CalcArea()}");
                                    break;

                                case 2:
                                Console.WriteLine("Uzunlugu Daxil Edin: ");
                                int length = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Eni Daxil Edin: ");
                                int width =Convert.ToInt32(Console.ReadLine());
                                Rectangular rectangular = new Rectangular(length, width);
                                Console.WriteLine($"Duzbucaqlinin Sahesi: {rectangular.CalcArea()}");
                                break;

                         

                        }
                    }
                    else if (command == 0)
                    {
                        Console.WriteLine("Sistem'den Cixis Etdiniz...");
                        Console.WriteLine("Gelen Hesablamalarda Gorusenedek!");
                        Console.WriteLine("Bye Bye........");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Duzgun Command Daxil Etmediniz!");
                        Console.WriteLine("Zehmet Olmazsa, Duzgun Command Daxil Edin...");

                    }
                }


            }

        }
    }
}