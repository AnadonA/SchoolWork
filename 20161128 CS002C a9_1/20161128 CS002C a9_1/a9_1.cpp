// client file --------------------------------------------------
// FHflowGraph client
// CS002C Foothill College

#include <iostream>
#include <iomanip>
#include <string>

using namespace std;
#include "FHflowGraph.h"

// --------------- main ---------------
int main()
{
   int finalFlow;

   // build graph
   FHflowGraph<string, int> myG;

   myG.addEdge("s", "a", 3);    myG.addEdge("s", "b", 2);
   myG.addEdge("a", "b", 1);    myG.addEdge("a", "c", 3); myG.addEdge("a", "d", 4);
   myG.addEdge("b", "d", 2);
   myG.addEdge("c", "t", 2);
   myG.addEdge("d", "t", 3);

   // show the original flow graph
   myG.showResAdjTable();
   myG.showFlowAdjTable();

   myG.setStartVert("s");
   myG.setEndVert("t");
   finalFlow = myG.findMaxFlow();

   cout << "Final flow: " << finalFlow << endl;

   myG.showResAdjTable();
   myG.showFlowAdjTable();

   return 0;
}