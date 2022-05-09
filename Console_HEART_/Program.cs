namespace Console_HEART_
{
    class Program
    {
        static void PrintHeart(double heartSize, string word, int height = 30, int width = 120)
        {
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);

            char[,] buffer = new char[height, width];
            char[] lettersInWord = new char[word.Length];
            lettersInWord = word.ToCharArray();

            int k = 0;
            for (int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    //set coordinates in center
                    double x = j - width / 2;
                    double y = -(i - height / 2);

                    //set "square" symbol
                    y *= 2;

                    double heart = (int)(x * x + (y - Math.Sqrt(Math.Abs(x))) * (y - Math.Abs(x)));

                    if (heart <= heartSize)
                    {
                        if (k >= word.Length) k = 0;
                        buffer[i, j] = lettersInWord[k];
                        k++;
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
            PrintHeart(500, "love");
            Console.ReadLine();
        }
    }
}
