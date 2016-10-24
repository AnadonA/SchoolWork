// NAME: 
// DATE: 20161023
// INST: DHarden CS002C
// AUTH: Anthony Anadon (c) 2016

#include <iostream>
#include <string>
#include <stack>
#include "FHlazySearchTree.h"
using namespace std;

template <typename Object>
class PrintObject
{
public:
   void operator()(Object obj)
   {
      cout << obj << " ";
   }
};

int main()
{
   int k;
   FHsearch_tree<int> searchTree;
   PrintObject<int> intPrinter;

   searchTree.traverse(intPrinter);

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
   searchTree.collectGarbage();
   cout << "tree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl;

   // test assignment operator
   FHsearch_tree<int> searchTree2 = searchTree;

   cout << "\n\nAttempting 1 removal: \n";
   if (searchTree.remove(20))
      cout << "removed " << 20 << endl;
   cout << "tree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl;

   cout << "Collecting Garbage - should clean 1 item. " << endl;
   searchTree.collectGarbage();
   cout << "tree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl;

   cout << "Collecting Garbage again - no change expected. " << endl;
   searchTree.collectGarbage();
   cout << "tree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl;

   // test soft insertion and deletion:

   cout << "Adding 'hard' 22 - should see new sizes. " << endl;
   searchTree.insert(22);
   searchTree.traverse(intPrinter);
   cout << "\ntree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl;

   cout << "\nAfter soft removal. " << endl;
   searchTree.remove(22);
   searchTree.traverse(intPrinter);
   cout << "\ntree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl;

   cout << "Repeating soft removal. Should see no change. " << endl;
   searchTree.remove(22);
   searchTree.traverse(intPrinter);
   cout << "\ntree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl;

   cout << "Soft insertion. Hard size should not change. " << endl;
   searchTree.insert(22);
   searchTree.traverse(intPrinter);
   cout << "\ntree 1 size: " << searchTree.size()
      << "  Hard size: " << searchTree.sizeHard() << endl;

   cout << "\n\nAttempting 100 removals: \n";
   for (k = 100; k > 0; k--)
   {
      if (searchTree.remove(k))
         cout << "removed " << k << endl;
   }
   searchTree.collectGarbage();

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
