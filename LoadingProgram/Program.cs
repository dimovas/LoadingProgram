using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] sh = new double[8, 5];
            sh[0, 0] = 1.9; sh[0,1] = 3081.6; sh[0, 2] = 3006.4; sh[0, 3] = 3.636; sh[0, 4] = 1.022;
            sh[1, 0] = 3.0; sh[1,1] = 5100.3; sh[1, 2] = 4976.1; sh[1, 3] = 3.771; sh[1, 4] = 1.588;
            sh[2, 0] = 4.0; sh[2,1] = 6962.4; sh[2, 2] = 6792.6; sh[2, 3] = 3.821; sh[2, 4] = 2.099;
            sh[3, 0] = 5.0; sh[3,1] = 8843.2; sh[3, 2] = 8627.5; sh[3, 3] = 3.792; sh[3, 4] = 2.610;
            sh[4, 0] = 6.0; sh[4,1] = 10748.6; sh[4, 2] = 10486.4; sh[4, 3] = 3.655; sh[4, 4] = 3.123;
            sh[5, 0] = 7.0; sh[5,1] = 12701.3; sh[5, 2] = 12391.5; sh[5, 3] = 3.333; sh[5, 4] = 3.642;
            sh[6, 0] = 8.0; sh[6,1] = 14720.2; sh[6, 2] = 14361.1; sh[6, 3] = 2.832; sh[6, 4] = 4.172;
            sh[7, 0] = 9.0; sh[7,1] = 16794.4; sh[7, 2] = 16384.8; sh[7, 3] = 2.309; sh[7, 4] = 4.706;

            double shipDispl = 13225;

            int m = -1, n = 2;
            for (int i = 0; i < sh.GetLength(0); i++)
            {
                if (sh[i, n] > shipDispl/1.025)
                {
                    m = i - 1;
                    break;
                }
            }
            Console.WriteLine($"D1 = {sh[m,n]}\tD2 = {sh[(m+1),n]}");
            double draughtWL = sh[m, 0] + (shipDispl - sh[m, n]) * (sh[(m + 1), 0] - sh[m, 0]) / (sh[(m + 1), n] - sh[m, n]);
            Console.WriteLine($"Draught at center of WL = {draughtWL}");
        }
    }
}
