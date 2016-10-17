// NAME: a3_1.cpp
// DATE: 20161013
// INST: DHarden CS002C
// AUTH: Anthony Anadon (c) 2106
// DESC:

#define MAX_MAT_SIZE 50


#include <ctime>
#include <time.h>
#include <iostream>
#include <iomanip>
using namespace std;

const int MAT_SIZE = 730;

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

   cout << endl << endl
      << setw(80) << setfill('-') << " "
      << endl << endl;

   for (int r = pStart; r < pStart + pSize; r++)
   {
      cout << setw(5) << setfill(' ') << r << ":\t";

      for (int c = pStart; c < pStart + pSize; c++)
         cout << setw(5) << setfill(' ') << setprecision(3) << pMat[r][c] << " ";
      cout << endl;
   }

   cout << endl << endl
      << setw(80) << setfill('-') << " "
      << endl << endl;
}

/*
My Guess: O(N*N) -or- O(N^2) -> Exponential Growth
   I'm thinking this due to the fact that the matrix multiplication occurs within
three for loops. Each of the loops relies on the one before it and each also runs
through sqrt(N) in each array.


-------------------------------------------------------------------------------


90:      0     0     0     0     0 0.452     0     0     0     0
91:      0     0     0     0  5.87     0     0     0     0     0
92:      0  9.94     0     0     0     0     0     0     0     0
93:      0     0     0     0     0     0     0     0     0     0
94:      0  6.37     0     0     0     0     0     0     0     0
95:      0     0     0     0     0     0     0     0     0     0
96:      0     0     0     0     0     0     0     0     0     0
97:      0     0     0     0     0     0     0     0     0     0
98:      0     0     0     0     0     0     0     0     0     0
99:      0     0  3.34     0     0     0     0     0     0     0


-------------------------------------------------------------------------------



Size = 100 Dyn Array Mult Elapsed Time: 0.005 seconds.

Press any key to continue . . .


-------------------------------------------------------------------------------


190:      0  6.14     0     0     0     0     0     0     0     0
191:   1.12     0     0     0  1.79  7.65     0     0     0     0
192:      0     0     0     0     0     0     0     0     0     0
193:      0     0     0     0     0     0     0     0     0     0
194:      0     0     0     0     0     0     0     0     0     0
195:      0     0     0     0     0     0     0     0     0     0
196:      0     0     0     0     0     0     0     0     0     0
197:      0     0     0     0     0     0     0     0     0     0
198:   7.22     0     0     0     0     0     0     0     0     0
199:      0     0     0     0     0     0     0     0     0     0


-------------------------------------------------------------------------------



Size = 200 Dyn Array Mult Elapsed Time: 0.044 seconds.

Press any key to continue . . .


-------------------------------------------------------------------------------


390:      0     0     0     0     0     0     0     0     0     0
391:      0     0     0     0     0     0     0     0     0     0
392:      0     0     0     0     0     0     0     0     0     0
393:      0     0     0     0     0     0  8.42     0     0     0
394:      0     0     0     0     0     0     0     0     0     0
395:      0     0     0     0     0     0  3.29     0     0     0
396:      0     0     0     0     0     0     0     0     0     0
397:      0     0     0     0     0  9.13     0     0     0     0
398:      0     0     0     0     0     0     0     0     0     0
399:      0     0  8.83     0     0     0     0     0     0     0


-------------------------------------------------------------------------------



Size = 400 Dyn Array Mult Elapsed Time: 0.37 seconds.

Press any key to continue . . .


-------------------------------------------------------------------------------


490:      0     0     0     0     0     0     0     0     0     0
491:      0     0     0     0     0     0     0     0     0     0
492:      0     0     0     0     0     0     0     0  7.07     0
493:      0     0     0     0     0     0     0     0     0     0
494:      0     0     0     0     0     0     0     0     0     0
495:      0  3.41     0     0     0     0     0     0     0     0
496:      0     0     0     0     0     0     0     0     0     0
497:      0     0     0     0     0     0     0     0     0     0
498:      0  6.95     0     0     0     0     0     0     0     0
499:      0     0     0     0     0     0     0     0     0     0


-------------------------------------------------------------------------------



Size = 500 Dyn Array Mult Elapsed Time: 0.83 seconds.

Press any key to continue . . .


-------------------------------------------------------------------------------


540:      0     0     0     0     0     0     0     0     0     0
541:      0     0     0     0     0     0     0  5.85     0     0
542:      0     0     0     0     0     0     0     0     0     0
543:      0     0     0     0     0     0     0  3.26     0     0
544:      0     0     0     0     0     0     0     0     0     0
545:      0     0  7.66     0     0     0     0     0  2.28     0
546:      0     0     0     0     0     0     0     0     0     0
547:      0     0     0     0     0     0     0     0     0     0
548:      0     0     0     0     0     0     0     0     0     0
549:      0     0     0     0  4.14     0     0     0     0     0


-------------------------------------------------------------------------------



Size = 550 Dyn Array Mult Elapsed Time: 0.97 seconds.

Press any key to continue . . .


-------------------------------------------------------------------------------


650:   1.14     0     0     0     0     0     0     0     0     0
651:      0     0     0     0     0     0     0     0     0     0
652:   2.86     0     0     0     0     0     0     0     0     0
653:      0     0     0     0     0     0     0     0     0     0
654:      0     0     0     0     0     0     0     0     0     0
655:      0     0     0     0     0     0  4.84     0     0  2.45
656:      0     0     0     0     0     0     0     0     0     0
657:      0     0     0     0     0     0     0     0     0     0
658:      0     0  2.39     0     0     0     0     0     0     0
659:      0     0     0     0     0     0     0     0     0     0


-------------------------------------------------------------------------------



Size = 660 Dyn Array Mult Elapsed Time: 1.9 seconds.

Press any key to continue . . .


-------------------------------------------------------------------------------


720:      0     0     0     0     0     0     0     0     0     0
721:      0     0     0     0     0     0     0     0     0     0
722:      0     0     0     0     0     0     0     0     0     0
723:      0     0     0     0     0     0     0     0     0     0
724:      0     0     0  6.98     0     0     0  5.35     0     0
725:      0     0     0     0     0     0     0     0     0     0
726:      0     0     0     0     0     0     0  5.92     0     0
727:      0     0     0     0     0     0     0     0     0   9.4
728:   5.26     0     0     0     0     0     0     0     0     0
729:      0     0     0     0     0     0     0     0     0     0


-------------------------------------------------------------------------------



Size = 730 Dyn Array Mult Elapsed Time: 3 seconds.

Press any key to continue . . .
*/