// NAME: FHhashQPwFind.h
// DATE: 20161105
// INST: CS002C Prof. DHardeen
// AUTH: Anthony Anadon (c) 2016
// DESC:
//
//

#ifndef INCL_FHHASHQPWFIND_H
#define INCL_FHHASHQPWFIND_H

// HEADER INCLUSIONS ----------------------------------------------------------

#include <exception>
#include "FHhashQP.h"

using namespace std;

// FHHASHQPWFIND OBJECT DESCRIPTION -------------------------------------------
template <class Object, typename KeyType>
class FHhashQPwFind : public FHhashQP<Object>
{
protected:
   int myHashKey(const KeyType &key) const;
   int findPosKey(const KeyType &key) const;

public:
   const Object find(const KeyType &key);


   // Custom Exception Definitions  -------------------------------------------
   class NotFoundException : public exception {};
};

// PROTECTED METHOD DEFINITIONS  ----------------------------------------------
template <class Object, typename KeyType>
int FHhashQPwFind<Object, KeyType>::myHashKey(const KeyType &key) const
{
   int hashVal;

   hashVal = Hash(key) % mTableSize;
   if (hashVal < 0)
      hashVal += mTableSize;

   return hashVal;
}





template <class Object, typename KeyType>
int FHhashQPwFind<Object, KeyType>::findPosKey(const KeyType &key) const
{
   int kthOddNum = 1;
   int index = myHashKey(key);

   while (mArray[index].state != EMPTY)
   {
      index += kthOddNum;  // k squared = (k-1) squared + kth odd #
      kthOddNum += 2;   // compute next odd #
      if (index >= mTableSize)
         index -= mTableSize;
   }

   return index;
}






// PUBLIC METHOD DEFINITIONS  -------------------------------------------------

template <class Object, typename KeyType>
const Object FHhashQPwFind<Object, KeyType>::find(const KeyType &key)
{
   int hash = findPosKey(key);

   if (mArray[hash].state == ACTIVE)
      return mArray[hash].data;

   throw new typename NotFoundException();
}

#endif
