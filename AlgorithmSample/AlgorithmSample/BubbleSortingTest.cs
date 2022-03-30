using System;
namespace AlgorithmSample
{
    internal class BubbleSortingTest
    {
        internal BubbleSortingTest()
        {
        }

        internal void Excecute()
        {
            int[] scores = { 90, 70, 50, 80, 100, 200, 300 };
            sort(scores);
            foreach (int score in scores)
            {
                Console.Write(score + ",");
            }
        }
        private void sort(int[] scores)
        {
            foreach (int score in scores)
            {
                bool isSwap = false;
                for (int j = 0; j < scores.Length - 1; j++)
                {
                    if (scores[j] > scores[j + 1]) // swap
                    {
                        int temp = scores[j];
                        scores[j] = scores[j + 1];
                        scores[j + 1] = temp;
                        isSwap = true;
                    }
                }
                Console.WriteLine(isSwap);
                // 並び替えを停止する
                if (!isSwap)
                {
                    break;
                }
            }
        }
    }
}
