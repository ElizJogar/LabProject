using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomQuantityProject
{

    class RandomQFunc
    {
        int countOfChots;
        int countOfChoters;
        double[,] probabilityMarix;
        Random rand = new Random();

        public RandomQFunc(int chotersCount, int chotsCount) 
        {
            countOfChoters = chotersCount;
            countOfChots = chotsCount;
            probabilityMarix = new double[countOfChoters, countOfChots];
        }

        void getMatrixOfProbability() 
        {
            for (int i = 0; i < countOfChoters; i++)
            {
                for (int j = 0; j < countOfChots; j++)
                {
                    probabilityMarix[i,j] = Math.Round(rand.NextDouble(),4);
                }
            }
        }

       public string setRandomForShoters()
        {
            string textBox = "";
            getMatrixOfProbability();
            for (int i = 0; i < probabilityMarix.GetLength(0); i++)
            {
                textBox += "Вероятность попадания при выстрелаx для стрелка №" + (i + 1).ToString() + ":" + Environment.NewLine;
                for (int j = 0; j < probabilityMarix.GetLength(1); j++)
                {
                    textBox += probabilityMarix[i, j].ToString() + '\t';
                }
                textBox += Environment.NewLine + Environment.NewLine;
            }
            return textBox;
        }

        public int getRandomQuantityForShoter() //для получения случайной величины каждого стрелка
        {
            double value = 0.0;
            int summ = 0;

            for (int j = 0; j < probabilityMarix.GetLength(0); j++)
            {
                for (int i = 0; i < probabilityMarix.GetLength(1); i++)
                {
                    value = Math.Round(rand.NextDouble(), 4);
                    if ( value < probabilityMarix[j, i] )
                    {
                        summ ++;
                         break;
                    }
                    else
                        summ ++;
                }
            }
           return summ;
        }
    }
    class TableComponent
    {
      public  int randomQuantity;
      public  int frequency;
      public  double relativeFrequency;
        public TableComponent(int RQ, int F, double RF)
        {
            randomQuantity = RQ;
            frequency = F;
            relativeFrequency = RF;
        }
    }
}
