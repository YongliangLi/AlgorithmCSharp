using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramModels
{
    public class BinomialDistribution
    {
        public double Binaomial(int n, int k, double p)
        {
            if (n == 0 && k == 0) return 1.0;
            if (n < 0 || k < 0) return 0.0;
            return (1.0 - p)*Binaomial(n - 1, k, p) + p*Binaomial(n - 1, k - 1, p);
        }

        public double Binomial2(int n, int k, double p)
        {
            double[,] b = new double[n + 1, k + 1];
            
            //base case
            for (int i = 0; i <= n; i++)
            {
                b[i, 0] = Math.Pow(1.0 - p, i);
            }
            b[0, 0] = 1.0;

            //recursive formula
            for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    b[i, j] = p*b[i - 1, j - 1] + (1.0 - p)*b[i - 1, j];
                }
            }

            return b[n, k];
        }
    }
}
