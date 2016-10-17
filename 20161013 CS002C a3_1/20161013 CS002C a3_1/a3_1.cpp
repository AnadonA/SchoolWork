// NAME: a3_1.cpp
// DATE: 20161013
// INST: DHarden CS002C
// AUTH: Anthony Anadon (c) 2106
// DESC:

#define MAX_MAT_SIZE 10000


#include <ctime>
#include <time.h>
#include <iostream>
#include <iomanip>
using namespace std;

const int MAT_SIZE = 1000;

typedef float* DynMat[MAT_SIZE];

void matShowDyn(const DynMat &, int, int);
void matMulDyn(const DynMat &, const DynMat &, DynMat &, int);

int main()
{
   DynMat mDyn, nDyn, ansDyn;
   float DefaultVal = 0;
   clock_t Start, Stop;
   double Seconds = 0;

   srand(time(NULL));

   for (int x = 0; x < MAT_SIZE; x++)
   {
      mDyn[x] = new float[MAT_SIZE]();
      nDyn[x] = new float[MAT_SIZE]();
      ansDyn[x] = new float[MAT_SIZE]();

      // Assign random values to each of the matrices and default the answer
      for (int y = 0; y < MAT_SIZE; y++)
      {
         mDyn[x][y] = nDyn[x][y] = ansDyn[x][y] = DefaultVal;
      }
   }


   int smallPercent = MAT_SIZE / 20 * MAT_SIZE;
   for (int i = 0; i < smallPercent; i++)
   {
      int   r = rand() % MAT_SIZE,
         c = rand() % MAT_SIZE;

      float v = (float)rand() / (float)RAND_MAX * 9.9 + .1;

      mDyn[r][c] = v;
      nDyn[c][r] = v;
   }

   matShowDyn(mDyn, MAT_SIZE - 10, 10);

   Start = clock();
   matMulDyn(mDyn, nDyn, ansDyn, MAT_SIZE);
   Stop = clock();

   Seconds = (double)(Stop - Start) / (double)CLOCKS_PER_SEC;

   cout << "\nSize = " << MAT_SIZE << " Dyn Array Mult Elapsed Time: "
      << setprecision(2) << Seconds << " seconds." << endl << endl;

   // Return all used memory
   for (int r = 0; r < MAT_SIZE; r++)
   {
      delete[] mDyn[r];
      delete[] nDyn[r];
      delete[] ansDyn[r];
   }
   
   return 0;
}



/*
MATRIX MULTIPLICATION RULES (for square matrices only)
[A] [B] [C] [D]     [a] [b] [c] [d]     [Aa + Be + Ci + Dm] [Ab + Af + Aj + An] [Ac + Ag + Ak + Ao] [Ad + Ah + Al + Ap]
[E] [F] [G] [H]     [e] [f] [g] [h]     [Ea + Ee + Ei + Em] [Fb + Ff + Fj + Fn] [Gc + Gg + Gk + Go] [Hd + Hh + Hl + Hp]
[I] [J] [K] [L]  *  [i] [j] [k] [l]  =  [Ia + Ie + Ii + Im] [Jb + Jf + Jj + Jn] [Kc + Kg + Kk + Ko] [Ld + Lh + Ll + Lp]
[M] [N] [O] [P]     [m] [n] [o] [p]     [Ma + Me + Mi + Mm] [Nb + Nf + Nj + Nn] [Oc + Og + Ok + Oo] [Pd + Ph + Pl + pp]

Solution -> Row,Col iteration
MatrixA  -> Row,Col iteration
MatrixB  -> Col,Row iteration
*/
void matMulDyn(const DynMat &pMatA, const DynMat &pMatB, DynMat &pAnsMat, int pSize)
{
   for (int x = 0; x < pSize; x++)
      for (int y = 0; y < pSize; y++)
         for (int z = 0; z < pSize; z++)
            pAnsMat[x][y] += pMatA[x][z] * pMatB[z][y];
}






void matShowDyn(const DynMat &pMat, int pStart, int pSize)
{
   for (int r = pStart; r < pStart + pSize; r++)
   {
      for (int c = pStart; c < pStart + pSize; c++)
         cout << setw(5) << setfill(' ') << setprecision(3) << pMat[r][c] << " ";
      cout << endl;
   }

   cout << endl << endl;
}

/*
0     0     0     0     0     0     0     0     0     0
0     0     0     0     0     0     0     0     0     0
0     0     0     0     0     0     0     0     0     0
0     0     0     0     0     0     0     0     0     0
0     0     0     0     0     0     0     0     0     0
0     0     0     0     0     0     0     0     0     0
0     0     0     0     0     0     0     0     0     0
0     0     0     0     0     0     0     0     0     0
0     0     0     0     0     0  4.34     0     0     0
0     0     0     0     0     0     0     0     0     0



Size = 30 Dyn Array Mult Elapsed Time: 0 seconds.

Press any key to continue . . .
-------------------------------------------------------------------------------

0     0     0     0     0     0     0     0     0     0
0     0     0     0     0     0  1.24     0     0     0
0     0     0     0     0     0     0     0     0     0
0     0     0     0     0     0     0     0     0     0
0     0     0     0     0     0  3.05   1.3     0     0
0  5.19     0     0     0     0     0  2.42     0     0
0     0     0     0     0     0     0     0     0     0
0     0     0     0     0     0     0     0     0     0
0     0     0     0     0     0     0     0     0     0
0     0     0     0     0     0     0     0     0     0



Size = 50 Dyn Array Mult Elapsed Time: 0.001 seconds.

Press any key to continue . . .
*/