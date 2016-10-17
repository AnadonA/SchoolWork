// NAME: a3_1.cpp
// DATE: 20161013
// INST: DHarden CS002C
// AUTH: Anthony Anadon (c) 2106
// DESC:

#define MAX_MAT_SIZE 10000


#include <iostream>
using namespace std;

const int MAT_SIZE = 4;


int main()
{
   typedef float *DynMat[MAT_SIZE];
   DynMat mDyn, nDyn, ansDyn;

   for (int x = 0; x < MAT_SIZE; x++)
   {
      mDyn[x] = new float[MAT_SIZE]();
      nDyn[x] = new float[MAT_SIZE]();
      ansDyn[x] = new float[MAT_SIZE]();
   }


   delete[] mDyn


   return 0;
}
