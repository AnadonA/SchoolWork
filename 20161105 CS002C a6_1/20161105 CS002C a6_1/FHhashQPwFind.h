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
#include "FHhashQP.h"

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
   class NotFoundException : public Exception {};
};

// PROTECTED METHOD DEFINITIONS  ----------------------------------------------
template <class Object, typename KeyType>
int FHhashQPwFind<Object, KeyType>::myHashKey(const KeyType &key) const
{
   return 0;
}






template <class Object, typename KeyType>
int FHhashQPwFind<Object, KeyType>::findPosKey(const KeyType &key) const
{
   return 0;
}






// PUBLIC METHOD DEFINITIONS  -------------------------------------------------

template <class Object, typename KeyType>
const Object FHhashQPwFind<Object, KeyType>::find(const KeyType &key)
{
   throw new typename NotFoundException();

   return NULL;
}

#endif
