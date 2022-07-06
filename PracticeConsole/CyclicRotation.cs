using System.Linq;

namespace PracticeConsole
{
    class CyclicRotation
    {
        public int[] Solution(int[] A, int K)
        {
            var l = A.Length;

            if(l==0)
                return A;

            int Temp;
            for (int i = 0; i < K; i++)
            {
                Temp = A[l - 1];
                for (int j = l - 1; j > 0; j--)
                {
                    A[j] = A[j - 1];
                }
                A[0] = Temp;
            }
            return A;
        }
    }
}