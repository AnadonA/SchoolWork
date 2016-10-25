// NAME: 
// DATE: 20161023
// INST: DHarden CS002C
// AUTH: Anthony Anadon (c) 2016

#include <iostream>
#include <string>
#include <stack>
#include <ctime>
#include "FHlazySearchTree.h"
using namespace std;

template <typename Object>
class PrintObject
{
public:
   void operator()(Object obj, bool deleted = false)
   {
      if (deleted)
         cout << "(" << obj << ") ";
      else
         cout << obj << " ";
   }
};

int main()
{

   int k;
   FHsearch_tree<int> searchTree;
   PrintObject<int> intPrinter;
   searchTree.traverse(intPrinter);

   /* Code I used to test out my modifications. It used [mostly] random values
      for insert, remove, removeHard and other method testing.
   srand(time(NULL));

   cout << "Randomly creating a BST of 20 objects \n{ ";
   for (int i = 0; i < 20; i++)
   {
      int value = rand() % 50;
      searchTree.insert(value);
      cout << value << " ";
   }
   cout << "}\n";
   searchTree.traverse(intPrinter);
   cout << "\ntree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl;
   cout << endl << endl;
   
   cout << "Attempting to removeHard 10 random objects \n{ ";
   for (int i = 0; i < 10; i++)
   {
      int value = rand() % 20;
      if (searchTree.removeHard(value))
         cout << "(" << value << ") ";
      else
         cout << value << " ";
   }
   cout << "}\n";
   searchTree.traverse(intPrinter);
   cout << "\ntree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl;
   cout << endl << endl;

   cout << "Attempting to remove 10 random objects \n{ ";
   for (int i = 0; i <= 10; i++)
   {
      int value = rand() % 20;
      if (searchTree.remove(value))
         cout << "(" << value << ") ";
      else
         cout << value << " ";
   }
   cout << "}\n";
   searchTree.traverse(intPrinter);
   cout << "\ntree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl;
   cout << endl << endl;

   cout << "Attempting to add 10 random objects\n{ ";
   for (int i = 0; i <= 10; i++)
   {
      int value = rand() % 20;
      if (searchTree.insert(value))
         cout << "(" << value << ") ";
      else
         cout << value << " ";
   }
   cout << "}\n";
   searchTree.traverse(intPrinter);
   cout << "\ntree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl;
   cout << endl << endl;

   cout << "Collecting the Garbage..." << endl;
   searchTree.collectGarbage();
   cout << "Garbage Collection Results:" << endl;
   searchTree.traverse(intPrinter);
   cout << "\ntree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl;
   cout << endl;

   searchTree.clear();
   searchTree.traverse(intPrinter);
   cout << "\ntree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl;
   cout << endl;

   */
   cout << "\ninitial size: " << searchTree.size() << endl;
   searchTree.insert(50);
   searchTree.insert(20);
   searchTree.insert(30);
   searchTree.insert(70);
   searchTree.insert(10);
   searchTree.insert(60);

   cout << "After populating -- traversal and sizes: \n";
   searchTree.traverse(intPrinter);
   cout << "\ntree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl;

   cout << "Collecting garbage on new tree - should be no garbage." << endl;
   cout << "-> \t Collected Garbage: " << searchTree.collectGarbage() << endl;
   cout << "tree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl << endl;

   // test assignment operator
   FHsearch_tree<int> searchTree2 = searchTree;

   cout << "\n\nAttempting 1 removal: \n";
   if (searchTree.remove(20))
      cout << "removed " << 20 << endl;
   cout << "tree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl << endl;

   cout << "Collecting Garbage - should clean 1 item. " << endl;
   cout << "-> \t Collected Garbage: " << searchTree.collectGarbage() << endl;
   cout << "tree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl << endl;

   cout << "Collecting Garbage again - no change expected. " << endl;
   cout << "-> \t Collected Garbage: " << searchTree.collectGarbage() << endl;
   cout << "tree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl;

   // test soft insertion and deletion:

   cout << "Adding 'hard' 22 - should see new sizes. " << endl;
   searchTree.insert(22);
   searchTree.traverse(intPrinter);
   cout << "\ntree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl << endl;

   cout << "\nAfter soft removal. " << endl;
   searchTree.remove(22);
   searchTree.traverse(intPrinter);
   cout << "\ntree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl << endl;

   cout << "Repeating soft removal. Should see no change. " << endl;
   searchTree.remove(22);
   searchTree.traverse(intPrinter);
   cout << "\ntree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl << endl;

   cout << "Soft insertion. Hard size should not change. " << endl;
   searchTree.insert(22);
   searchTree.traverse(intPrinter);
   cout << "\ntree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl << endl;

   cout << "\n\nAttempting 100 removals: \n";
   for (k = 100; k > 0; k--)
   {
      if (searchTree.remove(k))
         cout << "removed " << k << endl;
   }

   searchTree.find(60);

   cout << "-> \t Collected Garbage: " << searchTree.collectGarbage() << endl;

   cout << "\nsearchTree now:\n";
   searchTree.traverse(intPrinter);
   cout << "\ntree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl;

   searchTree2.insert(500);
   searchTree2.insert(200);
   searchTree2.insert(300);
   searchTree2.insert(700);
   searchTree2.insert(100);
   searchTree2.insert(600);
   cout << "\nsearchTree2:\n";
   searchTree2.traverse(intPrinter);
   cout << "\ntree 2 size: " << searchTree2.size()
      << "  Hard size: " << searchTree2.sizeHard() << endl;

   return 0;
}

/* CONSOLE OUTPUT -------------------------------------------------------------

initial size: 0
After populating -- traversal and sizes:
10 20 30 50 60 70
tree 1 size: 6  Hard size: 6
Collecting garbage on new tree - should be no garbage.
->       Collected Garbage: 0
tree 1 size: 6  Hard size: 6



Attempting 1 removal:
removed 20
tree 1 size: 5  Hard size: 6

Collecting Garbage - should clean 1 item.
->       Collected Garbage: 1
tree 1 size: 4  Hard size: 5

Collecting Garbage again - no change expected.
->       Collected Garbage: 2
tree 1 size: 4  Hard size: 4
Adding 'hard' 22 - should see new sizes.
10 22 50 60 70
tree 1 size: 5  Hard size: 5


After soft removal.
10 (22) 50 60 70
tree 1 size: 4  Hard size: 5

Repeating soft removal. Should see no change.
10 (22) 50 60 70
tree 1 size: 4  Hard size: 5

Soft insertion. Hard size should not change.
10 22 50 60 70
tree 1 size: 5  Hard size: 5



Attempting 100 removals:
removed 70
removed 60
removed 50
removed 22
removed 10
->       Collected Garbage: 7

searchTree now:

tree 1 size: 0  Hard size: 0

searchTree2:
10 20 30 50 60 70 100 200 300 500 600 700
tree 2 size: 12  Hard size: 12
Press any key to continue . . .
*/