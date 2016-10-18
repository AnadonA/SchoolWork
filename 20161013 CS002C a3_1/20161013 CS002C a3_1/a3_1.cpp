// NAME: a3_1.cpp
// DATE: 20161017
// INST: DHarden CS002C
// AUTH: Anthony Anadon (c) 2106
// DESC: Homework Week #3
//    Creates three floating point matrices of [MAT_SIZE][MAT_SIZE] each
// defaulted to 0 values. Two of the have approximately 20 percent of their
// values changed to a random float and are multiplied together using the
// matMulDyn function. Their resultant is stored in the third matrix. The
// multiplication operation is timed and the necessary time is output to the
// console (along with one of the original matrices) using the matShowDyn
// function.
//
// matShowDyn(const DynMat &pMat, int pStart, int pSize);
//    PRECONDITIONS:    1) pMat must be a previously declared and defined
//       matrix.        2) pStart must be a non-negative value within the
//       bounds of the Matrix (0 - MAT_SIZE).
//                      3) pSize must be a non-negative value greater than
//       0.
//                      4) pStart + pSize must exist within the bounds of
//       the provided matrix (0 - MAT_SIZE).
//    POSTCONDITION:    The resulting subsquare of the matrix is output to
//       the console in a formatted fashion (to promote readability).
//
//
// matMuldDyn(const DynMat &pMatA, const DynMat &pMatB, DynMat &pAnsMat, int pSize);
//    PRECONDITIONS:    1) pMatA, pMatB, and pAnsMat must be previously 
//       declared and defined matrices.
//                      2) pSize must be a non-negative value greater than
//       0.
//    POSTCONDITIONS:   The matrices pMatA and pMatB are multiplied together
//       using the provided pSize value as the loop limits and their resulting 
//       Matrix is stored in the pAnsMat reference.






// HEADER INCLUSIONS ----------------------------------------------------------
#include <ctime>
#include <time.h>
#include <iostream>
#include <iomanip>
using namespace std;






// CONSTANTS & TYPEDEFS -------------------------------------------------------
const int MAT_SIZE = 2000;        //# of objects per array within the matrices
typedef float* DynMat[MAT_SIZE];






// GLOBAL FUNCTION DECLERATIONS  ----------------------------------------------
void matShowDyn(const DynMat &, int, int);
void matMulDyn(const DynMat &, const DynMat &, DynMat &, int);






// APPLICATION ENTRY POINT ----------------------------------------------------
int main()
{
   srand(time(NULL));

   DynMat mDyn, nDyn, ansDyn;
   float DefaultVal = 0;
   clock_t Start, Stop;
   double Seconds = 0;


   // Initialize the matrices
   for (int x = 0; x < MAT_SIZE; x++)
   {
      mDyn[x] = new float[MAT_SIZE]();
      nDyn[x] = new float[MAT_SIZE]();
      ansDyn[x] = new float[MAT_SIZE]();

      // Assign random values to each of the matrices and default the answer
      for (int y = 0; y < MAT_SIZE; y++)
         mDyn[x][y] = nDyn[x][y] = ansDyn[x][y] = DefaultVal;
   }


   // Change *some* of them to a random value between .1 TO 10.0
   int smallPercent = MAT_SIZE / 20 * MAT_SIZE;
   for (int i = 0; i < smallPercent; i++)
   {
      int   r = rand() % MAT_SIZE,
         c = rand() % MAT_SIZE;

      float v = (float)rand() / (float)RAND_MAX * 9.9 + .1;

      mDyn[r][c] = v;
      nDyn[c][r] = v;
   }

   // Perform the matrix multiplication
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






// matShowDyn Function Definition   -------------------------------------------
void matShowDyn(const DynMat &pMat, int pStart, int pSize)
{

   if (pStart < 0 || pStart >= MAT_SIZE ||
      pStart + pSize > MAT_SIZE || pSize < 1
      || NULL == pMat)
      return;

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






// matMulDyn Function Definition ----------------------------------------------
void matMulDyn(const DynMat &pMatA, const DynMat &pMatB, DynMat &pAnsMat, int pSize)
{
   if (NULL == pMatA || NULL == pMatB || NULL == pAnsMat || pSize < 1)
      return;
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

   for (int x = 0; x < pSize; x++)        // Iteration 3 of sqrt(N)
      for (int y = 0; y < pSize; y++)     // Iteration 2 of sqrt(N)
         for (int z = 0; z < pSize; z++)  // Iteration 1 of sqrt(N)
            pAnsMat[x][y] += pMatA[x][z] * pMatB[z][y];
}






/* ----------------------------------------------------------------------------
My Guess: O(Nsqrt(N)) -or- O(N^(3/2)) -or- Exponential Growth
   I'm thinking this due to the fact that the matrix multiplication occurs within
three for loops. Each of the loops relies on the one before it and each also runs
through sqrt(N) of each matrix. sqrt(N) * sqrt(N) * sqrt(N) = Nsqrt(N)
-------------------------------------------------------------------------------
*/

/* HOMEWORK QUESTIONS   -------------------------------------------------------
1) Size = 40 Dyn Array Mult Elapsed Time: 0.001 seconds. (First Non-Zero Time)
2) x3:   Size = 120 Dyn Array Mult Elapsed Time: 0.031 seconds.
   x4:   Size = 160 Dyn Array Mult Elapsed Time: 0.075 seconds.
         Size = 370 Dyn Array Mult Elapsed Time: 0.98 seconds.
         Size = 450 Dyn Array Mult Elapsed Time: 2.2 seconds.
         Size = 1000 Dyn Array Mult Elapsed Time: 33 seconds.
3) Size = 2000 Dyn Array Mult Elapsed Time: 2.6e+02 seconds.
   (I [CTRL]+[F5]'d it and left it while I cooked dinner...)
   Size = 3000 Dyn Array Mult Elapsed Time: ~I gave up <-
4) It does seem to grow at an exponential rate (N^2 perhaps) starting with a
   very quick execution time to a very long execution time with few addtitional
   values (for example 1 second was ~ 370 MAT_MAX while 2 seconds was only 450).
   It probably more closely resembles Cubic growth, however.
*/


/* CONSOLE RESULTS   ----------------------------------------------------------
-------------------------------------------------------------------------------

30:      0     0     0     0     0     0     0     0     0     0
31:      0     0     0     0     0     0     0     0     0     0
32:      0     0     0     0     0     0     0  7.66     0     0
33:      0     0     0     0     0     0     0     0     0   7.4
34:      0     0     0     0     0     0     0     0     0     0
35:      0     0     0     0     0  3.62     0     0     0     0
36:      0     0     0     0     0     0  9.03     0     0     0
37:      0     0     0     0     0     0     0     0     0     0
38:      0     0     0     0     0  8.34     0     0     0     0
39:      0     0     0     0     0     0     0     0     0     0


-------------------------------------------------------------------------------


Size = 40 Dyn Array Mult Elapsed Time: 0.001 seconds.

Press any key to continue . . .

-------------------------------------------------------------------------------

110:      0     0     0     0     0     0     0     0     0     0
111:      0     0     0     0     0     0     0     0     0     0
112:      0     0     0     0     0     0     0     0     0     0
113:      0     0     0     0     0     0     0  7.19     0     0
114:      0     0     0     0     0     0     0  3.62     0     0
115:      0     0     0  9.72     0     0     0     0     0     0
116:      0     0     0     0     0     0     0     0     0     0
117:      0     0     0     0     0     0     0     0     0     0
118:      0     0     0  8.19     0     0     0     0     0     0
119:   1.72     0     0     0     0     0     0     0     0     0


-------------------------------------------------------------------------------


Size = 120 Dyn Array Mult Elapsed Time: 0.031 seconds.

Press any key to continue . . .

-------------------------------------------------------------------------------

150:      0     0     0     0     0     0  6.77     0     0     0
151:      0     0     0     0     0  2.61     0     0     0     0
152:      0     0     0     0     0   6.5     0     0     0     0
153:      0     0     0     0     0     0     0     0     0     0
154:      0     0     0     0     0     0     0     0  9.56     0
155:      0     0     0     0  4.82     0     0     0     0     0
156:      0     0     0     0     0     0     0     0  1.71     0
157:      0  9.57     0     0  4.21     0     0     0     0     0
158:      0     0     0     0     0     0     0     0     0     0
159:      0     0     0     0     0     0     0     0     0  8.03


-------------------------------------------------------------------------------


Size = 160 Dyn Array Mult Elapsed Time: 0.075 seconds.

Press any key to continue . . .

-------------------------------------------------------------------------------

360:      0     0     0     0     0     0     0     0     0     0
361:      0     0     0     0     0     0     0     0     0     0
362:   9.78     0     0     0     0     0     0     0     0     0
363:      0     0     0     0     0     0  3.63     0     0     0
364:      0     0     0     0     0     0     0     0     0     0
365:      0     0     0     0     0 0.914     0     0     0     0
366:   3.84     0     0     0     0     0     0     0     0     0
367:      0     0     0     0     0     0     0     0     0     0
368:      0     0     0     0     0     0     0     0     0     0
369:      0     0     0     0  4.45     0     0     0     0     0


-------------------------------------------------------------------------------


Size = 370 Dyn Array Mult Elapsed Time: 0.98 seconds.

Press any key to continue . . .

-------------------------------------------------------------------------------

440:      0     0     0     0     0     0     0     0     0     0
441:      0     0     0     0     0  8.83     0     0     0     0
442:  0.416     0     0     0     0     0     0     0     0     0
443:      0     0     0  6.72     0     0     0     0     0     0
444:      0     0     0     0     0     0     0     0     0     0
445:      0     0     0     0     0     0     0     0     0     0
446:      0     0     0     0     0     0     0     0     0     0
447:      0     0     0     0     0     0     0     0     0     0
448:      0     0     0     0     0     0     0     0     0     0
449:      0     0     0     0     0     0  8.14     0     0     0


-------------------------------------------------------------------------------


Size = 450 Dyn Array Mult Elapsed Time: 2.2 seconds.

Press any key to continue . . .

-------------------------------------------------------------------------------

990:      0     0     0     0     0     0     0     0     0     0
991:      0     0     0     0     0     0     0     0     0     0
992:      0     0     0     0     0     0     0     0     0     0
993:      0     0     0     0     0     0     0  1.19     0     0
994:   2.42     0     0     0     0     0     0     0     0     0
995:      0     0     0     0     0     0     0     0     0     0
996:      0     0     0     0     0     0     0     0     0     0
997:      0     0     0     0     0     0     0     0  2.51     0
998:      0     0     0     0     0     0     0     0     0     0
999:      0     0     0     0     0     0     0     0     0     0


-------------------------------------------------------------------------------


Size = 1000 Dyn Array Mult Elapsed Time: 33 seconds.

Press any key to continue . . .

-------------------------------------------------------------------------------

1990:      0     0     0     0     0     0     0     0     0     0
1991:      0   6.9     0     0     0     0     0     0     0     0
1992:      0     0     0     0     0     0     0  8.48     0     0
1993:      0     0     0     0     0     0     0     0     0     0
1994:      0     0     0     0     0     0     0     0     0     0
1995:      0     0     0     0     0     0     0     0     0     0
1996:      0     0     0     0     0     0     0     0     0  7.61
1997:      0     0     0     0     0     0     0     0     0     0
1998:      0     0     0     0     0     0  6.71     0     0     0
1999:      0     0     0     0     0     0     0     0     0     0


-------------------------------------------------------------------------------


Size = 2000 Dyn Array Mult Elapsed Time: 2.6e+02 seconds.
*/