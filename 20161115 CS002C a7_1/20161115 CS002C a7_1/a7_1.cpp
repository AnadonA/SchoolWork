// NAME: a7_1.cpp
// DATE: 20161115
// INST: DHarden CS002C
// AUTH: Anthony Anadon (c) 2016
// DESC: Modifies the shellSort function to recieve a gap sequence as an 
//       input parameter. The gap sequence will be a raw array of integers.


#include <iostream>
#include <iomanip>
#include <vector>
#include <time.h>

#include "FHvector.h"

using namespace std;

#define GAP_LENGTH 30
#define ARRAY_SIZE 31250


// Copied from the lesson text...
template <typename Comparable>
void shellSort1(FHvector<Comparable> & pVector)
{
   int k, pos, arraySize, gap;
   Comparable tmp;

   arraySize = pVector.size();
   for (gap = arraySize / 2; gap > 0; gap /= 2)
      for (pos = gap; pos < arraySize; pos++)
      {
         tmp = pVector[pos];
         for (k = pos; k >= gap && tmp < pVector[k - gap]; k -= gap)
            pVector[k] = pVector[k - gap];
         pVector[k] = tmp;
      }

   /*
   The following [commented] code was used to test the shellSortX function
   against the shellSort1 function to ensure that the output was ordered in the
   same manner.
   ----------------------------------------------------------------------------
   cout << endl << "ShellSort1:\t";
   for (int i = 0; i < 10; i++)
      cout << pVector.at(i) << "\t";
   cout << endl;
   */
}


template <typename Comparable>
void shellSortX(FHvector<Comparable> & pVector, int pGap[], int pGapLength)
{
   int k, pos, arraySize, gap, gapIndex;
   Comparable tmp;

   gapIndex = pGapLength - 1;
   arraySize = pVector.size();

   // Avoid using invalid gap values
   gap = pGap[gapIndex];
   while (gap <0 || gap > arraySize / 2)
      gap = pGap[gapIndex--];

   for (gap = pGap[gapIndex]; gap > 0; gap = pGap[gapIndex--])
      for (pos = gap; pos < arraySize; pos ++)
      {
         tmp = pVector[pos];
         for (k = pos; k >= gap && tmp < pVector[k - gap]; k -= gap)
            pVector[k] = pVector[k - gap];
         pVector[k] = tmp;
      }

   /*
   The following [commented] code was used to test the shellSortX function 
   against the shellSort1 function to ensure that the output was ordered in the
   same manner.
   ----------------------------------------------------------------------------
   cout << endl << "ShellSortX:\t";
   for (int i = 0; i < 20; i++)
      cout << pVector[i] << "\t";
   cout << endl;
   */
}


int main()
{

   // Create the integer vectors
   FHvector<int> fhVectorOfInts1;
   FHvector<int> fhVectorOfInts2;
   FHvector<int> fhVectorOfInts3;
   FHvector<int> fhVectorOfInts4;

   // Create the Gaps
   int prattArray[GAP_LENGTH]       = { 1 };
   int hibbardsArray[GAP_LENGTH]    = { 1 };
   int sedgewickArray[GAP_LENGTH]   = { 1 };

   for (int i = 1; i < GAP_LENGTH; i++)
   {
      // Calculate the different gaps
      hibbardsArray[i] = pow(2, i);
      prattArray[i] = (pow(3, i) - 1) / 2;
   }

   int index = 0;
   while (index < GAP_LENGTH)
   {
      int x = floor((index + 1) / 2);
      if (index % 2 != 0)
      {
         // I know I'm missing something uber-simple; But I added this to 
         // ensure correct positioning of the sedgewick array values.
         int y = x + 1;
         sedgewickArray[index] = pow(4, y) - 3 * pow(2, y) + 1;    
      }
      else
         sedgewickArray[index] = 9 * pow(4, x) - 9 * pow(2, x) + 1;
      
      index++;
   }


   srand(time(NULL));
   clock_t startTime, stopTime;

   int maxValues = 5000,
      difference = (400000 - 5000) / 10;

   cout << "MAX VALUES" << "\t| IMPLIED\t| EXPLICIT\t| SEDGEWICK\t| PRATT\t\t|" << endl
      << "----------------------------------------------------------------------------------"
      << endl;

   // Create the test loop.
   for (int i = 0; i < 10; i++)
   {
      // Clear the vectors
      fhVectorOfInts1.clear();
      fhVectorOfInts2.clear();
      fhVectorOfInts3.clear();
      fhVectorOfInts4.clear();

      // Fill the vectors
      for (int i = 0; i < maxValues; i++)
      {
         int randomNum = rand();
         fhVectorOfInts1.push_back(randomNum);
         fhVectorOfInts2.push_back(randomNum);
         fhVectorOfInts3.push_back(randomNum);
         fhVectorOfInts4.push_back(randomNum);
      }

      // Perform shell sorts
      cout << maxValues << "\t\t| ";


      startTime = clock();
      shellSort1(fhVectorOfInts1);
      stopTime = clock();
      cout << fixed << setprecision(4) << (double)(stopTime - startTime) / (double)CLOCKS_PER_SEC
         << "\t| ";

      startTime = clock();
      shellSortX(fhVectorOfInts2, hibbardsArray, GAP_LENGTH);
      stopTime = clock();
      cout << fixed << setprecision(4) << (double)(stopTime - startTime) / (double)CLOCKS_PER_SEC
         << "\t| ";

      startTime = clock();
      shellSortX(fhVectorOfInts3, sedgewickArray, GAP_LENGTH);
      stopTime = clock();
      cout << fixed << setprecision(4) << (double)(stopTime - startTime) / (double)CLOCKS_PER_SEC
         << "\t| ";

      startTime = clock();
      shellSortX(fhVectorOfInts4, prattArray, GAP_LENGTH);
      stopTime = clock();
      cout << fixed << setprecision(4) << (double)(stopTime - startTime) / (double)CLOCKS_PER_SEC
         << "\t| ";

      cout << endl
         << "---------------------------------------------------------------------------------"
         << endl;

      maxValues += difference;
   }

   return 0;
}

/*
TABLE OF TIMES (created from within the test loop...)

MAX VALUES      | IMPLIED       | EXPLICIT      | SEDGEWICK     | PRATT         |
----------------------------------------------------------------------------------
5000            | 0.0200        | 0.0430        | 0.0180        | 0.0240        |
---------------------------------------------------------------------------------
44500           | 0.2150        | 0.7360        | 0.1310        | 0.1890        |
---------------------------------------------------------------------------------
84000           | 0.4350        | 1.5190        | 0.2640        | 0.3780        |
---------------------------------------------------------------------------------
123500          | 0.6680        | 3.2650        | 0.4020        | 0.6490        |
---------------------------------------------------------------------------------
163000          | 0.8600        | 4.3040        | 0.5420        | 0.9480        |
---------------------------------------------------------------------------------
202500          | 1.1830        | 5.3740        | 0.8330        | 1.0840        |
---------------------------------------------------------------------------------
242000          | 1.3630        | 6.9280        | 0.8350        | 1.4210        |
---------------------------------------------------------------------------------
281500          | 1.6490        | 9.2040        | 1.0110        | 1.5660        |
---------------------------------------------------------------------------------
321000          | 1.7670        | 13.6740       | 1.1210        | 1.9250        |
---------------------------------------------------------------------------------
360500          | 4.0390        | 14.3610       | 1.2600        | 2.4330        |
---------------------------------------------------------------------------------
Press any key to continue . . .

QUESTION ANSWERS
1) Perhaps because it performs its sort based on the actual number of objects in the
vector; whereas the explicit gap is not.
2) The shellSort1 seems to be faster. This could be due to the answer listed above, or
perhaps I programmed the shellSortX function incorrectly... However, I only received 
the listed times after quite a bit of tweaking and re-tweaking and un-tweaking...
*/