namespace Console_HEART_
{
    class Program
    {
        static void PrintHeart(double heartSize, int height = 30, int width = 120)
        {
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);

            char[,] buffer = new char[height, width];
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    //set coordinates in center
                    double x = j - width / 2;
                    double y = -(i - height / 2);

                    //set "square" symbol
                    y *= 1.9;

                    double heart = (int)(x * x + (y - Math.Sqrt(Math.Abs(x))) * (y - Math.Abs(x)));

                    if (heart <= heartSize)
                    {
                        buffer[i, j] = '♥';
                    }
                    else
                    {
                        buffer[i, j] = ' ';
                    }
                }
            }

            foreach(char pix in buffer)
            {
                Console.Write(pix);
            }
        }

        static void Main()
        {
            PrintHeart(500);
            Console.ReadLine();
        }
    }
}
