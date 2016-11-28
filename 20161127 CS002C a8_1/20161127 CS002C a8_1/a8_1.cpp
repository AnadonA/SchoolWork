

#include <iostream>
#include <iomanip>

#include <time.h>

#include "FHsort.h"
#include "FHvector.h"

using namespace std;

template <typename Comparable>
void quickSortX(FHvector<Comparable> & pVector, int pLeft, int pRight, int pRecursionLimit);

template <typename Comparable>
void quickSortX(FHvector<Comparable> & pVector, int pRecursionLimit = 15);

int main() {

   srand(time(NULL));

   FHvector<int> fhVectorOfInts;
   clock_t StartTime, EndTime;

   int   MaxValues = 40000, 
         RecursionLimit = 2;

   cout << "Value Count,Recursion Limit,Elapsed Time (in seconds)" << endl;

   for (int i = 0; i < 10; i++)
   {
      MaxValues = i * ((900000 - 40000) / 10) + 40000;

      for (RecursionLimit = 2; RecursionLimit <= 300; RecursionLimit += 2)
      {
         cout << MaxValues << "," << RecursionLimit << ",";

         for (int i = 0; i < MaxValues; i++)
            fhVectorOfInts.push_back(rand());

         StartTime = clock();
         quickSortX(fhVectorOfInts, 31);
         EndTime = clock();

         cout << (EndTime - StartTime) / (double)CLOCKS_PER_SEC << endl;

         // Prepare for the next go-round
         fhVectorOfInts.clear();
      }
   }

   return 0;
}

template <typename Comparable>
void quickSortX(FHvector<Comparable> & pVector, int pRecursionLimit)
{
   // Correct for the possibility of invalid recursion limits
   pRecursionLimit = pRecursionLimit < 2 ? 2 : pRecursionLimit;

   quickSortX(pVector, 0, pVector.size() - 1, pRecursionLimit);
}

template <typename Comparable>
void quickSortX(FHvector<Comparable> & pVector, int pLeft, int pRight, int pRecursionLimit)
{
   Comparable pivot;
   int x, y;

   if (pLeft + pRecursionLimit <= pRight)
   {
      pivot = median3(pVector, pLeft, pRight);
      for (x = pLeft, y = pRight - 1; ; )
      {
         while (pVector[++x] < pivot)
            ;
         while (pivot < pVector[--y])
            ;
         if (x < y)
            mySwapFH(pVector[x], pVector[y]);
         else
            break;
      }

      mySwapFH(pVector[x], pVector[pRight - 1]);   // Restore the pivot

      quickSortX(pVector, pLeft, x - 1, pRecursionLimit);
      quickSortX(pVector, x + 1, pRight, pRecursionLimit);
   }
   else
      insertionSort(pVector, pLeft, pRight);
}


/*
In the data (table below) it seemed that each of the specific value counts would
trigger a relative increase in time. Other than that, I would say the quicksort 
algorithm really didn't respond to the different settings. But, this could be a
fluke, since my children were also using the computer for other non-homework
related items while the 1500 loops were being performed.

I will say, the time to sort doubled when the number of elements went from 40000 
to 126000. There is no other spot when the difference was this spacious. Even
though each iteration includes ~ 86000 values than its predecessor. Still yet,
1.5 seconds to sort 814000 items is pretty quick!

ValueCount	RecursionLimit	ElapsedTime (in seconds)
40000	      2	            0.089
126000	   2	            0.180
212000	   2	            0.306
212000	   38	            0.361
212000	   194	         0.451
298000	   72	            0.605
384000	   8	            0.688
384000	   248	         0.773
384000	   262	         0.887
642000	   14	            0.995
642000	   16	            1.075
642000	   18	            1.294
814000	   224	         1.518
*/