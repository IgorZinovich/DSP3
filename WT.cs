using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class WT
    {
        static private int N = 8;
        private float[,] wal = new float[N, N];
        float[,] r;

        public WT()
        {
            r = getFirst();
            getWal();

        }

        public float[] DWT(float[] X)
        {
            float[] c = new float[N];
            for(int i =0; i < N; i++)
            {
                for(int j=0; j < N; j++)
                {
                    c[i] += (float)X[j] * wal[j, i];
                }
            }
            return c;
        }

        private void getWal()
        {
            for(int i = 0; i < N; i++)
            {
                int[] n = new int[4];
                n[0] = 0;
                int k = 1;
                for(int j = 3; j>  0; j--)
                {
                    n[j] = (i & k) > 0 ? 1 : 0;
                    k = (k << 1);
                }
                int[] s = new int[3];
                for(int j=0; j < 3; j++)
                {
                    s[j] = (n[3 - j] != n[3 - j - 1]) ? 1 : 0;
                }
                for (int j = 0; j < N; j++)
                {
                    wal[i, j] = (s[0] == 1 ? r[1, j] : 1) * (s[1] == 1 ? r[2, j] : 1) * (s[2] == 1 ? r[3, j] : 1);
                }
            }
        }

        private float[,] getFirst()
        {
            float[,] r = new float[4, N];
            int step = N;
            for (int i = 0; i < 4; i++)
            {
                int gap = step;
                int j = 0;
                while (j < N)
                {
                    for (; j < gap && j < N; j++)
                    {
                        r[i, j] = 1;
                    }
                    gap += step;
                    for (; j < gap && j < N; j++)
                    {
                        r[i, j] = -1;
                    }
                    gap += step;
                }
                step /= 2;
            }
            return r;
        }
        static public float[] FWT(float[] X)
        {
            if (X.Length == 1)
            {
                return X;
            }
            float[] C1 = new float[X.Length / 2];
            float[] C2 = new float[X.Length / 2];
            for (int i = 0; i < X.Length / 2; i++)
            {
                C1[i] = X[i] + X[i + X.Length / 2];
                C2[i] = X[i] - X[i + X.Length / 2];
            }
            C1 = FWT(C1);
            C2 = FWT(C2);
            //float[] C;// = new float[X.Length];
            return C1.Concat(C2).ToArray();

        }






    }
}
