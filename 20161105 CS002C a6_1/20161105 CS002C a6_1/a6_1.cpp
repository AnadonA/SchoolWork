// NAME: a6_1.cpp
// DATE: 20161105
// INST: CS002C Prof. DHardeen
// AUTH: Anthony Anadon (c) 2016

// HEADER INCLUSIONS ----------------------------------------------------------
#include <iostream>
#include <iomanip>

#include "EBookEntry.h"
#include "FHhashQPwFind.h"

using namespace std;


int Hash(const int &);
int Hash(const EBookEntry &);
int getKey(const EBookEntry &);
int getKeyText(const EBookEntry &);

void displayOneEBook(EBookEntry);


// MAIN ENTRY POINT DEFINITION   ----------------------------------------------
int main()
{
   int k, arraySize;

   // how we read the data from files
   EBookEntryReader bookInput("catalog-short4.txt");

   // how we test the success of the read:
   if (bookInput.readError())
   {
      cout << "couldn't open " << bookInput.getFileName() << " for input.\n";
      exit(1);
   }

   // create an array of objects for our own use:
   arraySize = bookInput.getNumBooks();

   FHhashQPwFind<EBookEntry, int> hashTable;

   for (k = 0; k < arraySize; k++)
      hashTable.insert(bookInput[k]);

   for (k = 0; k < 25; k++)
   {
      int randomNum = rand() % arraySize;
      EBookEntry EBook = bookInput[k];

      try
      {
         EBookEntry Found = hashTable.find(EBook.getETextNum());
         if (Found == EBook)
            cout << "Book " << EBook.getETextNum() << " found successfully" << endl;
      }
      catch (...)
      {
         cout << "Book " << EBook.getETextNum() << " not found..." << endl;
      }
   }


   return 0;
}

int Hash(const int &item)
{
   return item % 33;
}

int Hash(const EBookEntry &item)
{
   int hashKey = getKey(item);

   return hashKey;
}

// used for ID equality
int getKey(const EBookEntry & item)
{
   return item.getETextNum();
}

int getKeyText(const EBookEntry & item)
{
   int titleValue = 0;

   string title = item.getTitle();

   int
      index    = 0,
      length   = 0,
      maxLen   = strlen(title.c_str());


   while (index < maxLen && length < 13)
   {
      titleValue += title.c_str()[index];

      // Use every other letter in the title to avoid similar title clashes
      index += 2;
      length++;
   }
   
   return titleValue;
}

void displayOneEBook(EBookEntry book)
{
   cout << "   # " << book.getETextNum() << "  ---------------" << endl;
   cout << "   \"" << book.getTitle() << "\"" << endl;
   cout << "   by " << book.getCreator() << endl;
   cout << "   re: " << book.getSubject() << endl << endl;
}