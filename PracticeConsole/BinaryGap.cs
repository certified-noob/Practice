using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeConsole
{
    class BinaryGap
    {
        

        public int Solution(long N)
        {

            var binary = Convert.ToString(N, 2);
            bool IsCounting = false;
            int Zeros = 0;
            var ZerosList = new List<int>();

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1' && !IsCounting)
                {
                    IsCounting = true;
                    continue;
                }
                if (binary[i] == '0' && IsCounting)
                {
                    Zeros++;
                }
                if (binary[i] == '1' && IsCounting)
                {
                    IsCounting = false;
                    ZerosList.Add(Zeros);
                    Zeros = 0;
                    if (i < binary.Length)
                    {
                        IsCounting = true;
                    }
                }
            }

            if (ZerosList.Count() > 0)
                return ZerosList.Max();

            return 0;
        }
    }
}