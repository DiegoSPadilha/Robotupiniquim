namespace Robotupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Robo Tupiniquin:  ");

            Console.ReadLine();

            Console.Write("Tamanho do grid X: ");
            int gridx = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tamanho do grid Y: ");
            int gridy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a posiçao inicial X: ");
            int posiinicialx = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a posiçao inicial Y: ");
            int posiincialy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira a direção do robo em (N) (S) (L) (O)");
            char direçao = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("insira as instruções");
            string comando = Console.ReadLine();

            char[] comandoChar = comando.ToCharArray();

            for (int i = 0; i < comando.Length; i++)
            {
                if (comandoChar[i] == 'M')
                {
                    if (direçao == 'N')
                    {
                        posiincialy++;
                    }
                    else if (direçao == 'S')
                    {
                        posiincialy--;
                    }
                    else if (direçao == 'L')
                    {
                        posiinicialx++;
                    }
                    else if (direçao == 'O')
                    {
                        posiinicialx--;
                    }


                }
                else if (comandoChar[i] == 'D')
                {
                    if (direçao == 'N')
                    {
                        direçao = 'L';
                    }
                    else if (direçao == 'S')
                    {
                        direçao = 'O';
                    }
                    else if (direçao == 'L')
                    {
                        direçao = 'S';
                    }
                    else if (direçao == 'O')
                    {
                        direçao = 'N';
                    }



                }
                else if (comandoChar[i] == 'E')
                {
                    if (direçao == 'N')
                    {
                        direçao = 'O';
                    }
                    else if (direçao == 'S')
                    {
                        direçao = 'L';
                    }
                    else if (direçao == 'L')
                    {
                        direçao = 'N';
                    }
                    else if (direçao == 'O')
                    {
                        direçao = 'S';
                    }



                }


            }
            Console.WriteLine("Posição inicial X: " + posiinicialx + " posiçao inical Y: " + posiincialy + " direção: " + direçao);

            Console.Write("Digite a posiçao inicial X: ");
            int posiinicialx2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a posiçao inicial Y: ");
            int posiincialy2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira a direção do robo em (N) (S) (L) (O)");
            char direçao2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("insira as instruções");
            string comando2 = Console.ReadLine();

            char[] comandoChar2 = comando2.ToCharArray();

            for (int i = 0; i < comando2.Length; i++)
            {
                if (comandoChar2[i] == 'M')
                {
                    if (direçao2 == 'N')
                    {
                        posiincialy2++;
                    }
                    else if (direçao2 == 'S')
                    {
                        posiincialy2--;
                    }
                    else if (direçao2 == 'L')
                    {
                        posiinicialx2++;
                    }
                    else if (direçao2 == 'O')
                    {
                        posiinicialx2--;
                    }


                }
                else if (comandoChar2[i] == 'D')
                {
                    if (direçao2 == 'N')
                    {
                        direçao2 = 'L';
                    }
                    else if (direçao2 == 'S')
                    {
                        direçao2 = 'O';
                    }
                    else if (direçao2 == 'L')
                    {
                        direçao2 = 'S';
                    }
                    else if (direçao2 == 'O')
                    {
                        direçao2 = 'N';
                    }



                }
                else if (comandoChar2[i] == 'E')
                {
                    if (direçao2 == 'N')
                    {
                        direçao2 = 'O';
                    }
                    else if (direçao2 == 'S')
                    {
                        direçao2 = 'L';
                    }
                    else if (direçao2 == 'L')
                    {
                        direçao2 = 'N';
                    }
                    else if (direçao2 == 'O')
                    {
                        direçao2 = 'S';
                    }

                }

            }
            Console.WriteLine("Posição inicial X: " + posiinicialx2 + " posiçao inical Y: " + posiincialy2 + " direção: " + direçao2);
            Console.ReadLine();
        }
    }
}