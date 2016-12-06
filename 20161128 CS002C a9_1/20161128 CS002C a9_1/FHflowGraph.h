#ifndef FHFLOWGRAPH_H
#define FHFLOWGRAPH_H

#include <limits.h>
#include <utility>
#include <vector>
#include <queue>
#include <set>
#include <map>
#include <stack>
#include <iostream>
#include <functional>
using namespace std;

// FHflowVertex CLASS DESCRIPTION   -------------------------------------------
template <class Object, typename CostType>
class FHflowVertex
{
   // internal typedefs to simplify syntax
   typedef FHflowVertex<Object, CostType>* VertPtr;
   typedef map<VertPtr, CostType> EdgePairList;

public:
   static int nSortKey;
   static stack<int> keyStack;
   static enum { SORT_BY_DATA, SORT_BY_DIST } eSortType;
   static bool setNSortType(int whichType);
   static void pushSortKey() { keyStack.push(nSortKey); }
   static void popSortKey() { nSortKey = keyStack.top(); keyStack.pop(); }

   static int const FHINFINITY = INT_MAX;  // defined in limits.h
   Object data;
   CostType dist;
   VertPtr nextInPath;  // used for client-specific info

   FHflowVertex(const Object & x = Object());
   bool operator<(const FHflowVertex<Object, CostType> & rhs) const;
   const FHflowVertex<Object, CostType> & operator=
      (const FHflowVertex<Object, CostType> & rhs);

   //--  Additions and\or Modifications (per assignment instructions)
   EdgePairList flowAdjList, resAdjList;
   void showResAdjList();
   void showFlowAdjList();
   void addToResAdjList(VertPtr neightbor, CostType cost);
   void addToFlowAdjList(VertPtr neightbor, CostType cost);
};

// static const initializations for Vertex --------------
template <class Object, typename CostType>
int FHflowVertex<Object, CostType>::nSortKey
= FHflowVertex<Object, CostType>::SORT_BY_DATA;

template <class Object, typename CostType>
stack<int> FHflowVertex<Object, CostType>::keyStack;
// ------------------------------------------------------

template <class Object, typename CostType>
bool FHflowVertex<Object, CostType>::setNSortType(int whichType)
{
   switch (whichType)
   {
   case SORT_BY_DATA:
   case SORT_BY_DIST:
      nSortKey = whichType;
      return true;
   default:
      return false;
   }
}

template <class Object, typename CostType>
FHflowVertex<Object, CostType>::FHflowVertex(const Object & x)
   : data(x), dist((CostType)FHINFINITY),
   nextInPath(NULL)
{
   // nothing to do
}

template <class Object, typename CostType>
bool FHflowVertex<Object, CostType>::operator<(
   const FHflowVertex<Object, CostType> & rhs) const
{
   switch (nSortKey)
   {
   case SORT_BY_DIST:
      return (dist < rhs.dist);
   case SORT_BY_DATA:
      return (data < rhs.data);
   default:
      return false;
   }
}

template <class Object, typename CostType>
const FHflowVertex<Object, CostType> & FHflowVertex<Object, CostType>::operator=(
   const FHflowVertex<Object, CostType> & rhs)
{
   data = rhs.data;
   dist = rhs.dist;
   nextInPath = rhs.nextInPath;

   resAdjList = rhs.resAdjList;
   flowAdjList = rhs.flowAdjList;

   return *this;
}

// FHflowVertex::addToFlowAdjList
template <class Object, typename CostType>
void FHflowVertex<Object, CostType>::addToFlowAdjList
(FHflowVertex<Object, CostType> *neighbor, CostType cost)
{
   flowAdjList[neighbor] = cost;
}

// FHflowVertex::addToResAdjList
template <class Object, typename CostType>
void FHflowVertex<Object, CostType>::addToResAdjList
(FHflowVertex<Object, CostType> *neighbor, CostType cost)
{
   resAdjList[neighbor] = cost;
}

// FHflowVertex::showFlowAdjList
template <class Object, typename CostType>
void FHflowVertex<Object, CostType>::showFlowAdjList()
{
   typename EdgePairList::iterator iter;
   cout << "Flow Adj List for " << data << ": ";
   for (iter = flowAdjList.begin(); iter != flowAdjList.end(); ++iter)
      cout << iter->first->data << "(" << iter->second << ") ";
   cout << endl;
}

// FHflowVertex::showResAdjList
template <class Object, typename CostType>
void FHflowVertex<Object, CostType>::showResAdjList()
{
   typename EdgePairList::iterator iter;
   cout << "Res Adj List for " << data << ": ";
   for (iter = resAdjList.begin(); iter != resAdjList.end(); ++iter)
      cout << iter->first->data << "(" << iter->second << ") ";
   cout << endl;
}


// FHflowGraph CLASS DESCRIPTION ----------------------------------------------
template <class Object, typename CostType>
class FHflowGraph
{
   // internal typedefs to simplify syntax
   typedef FHflowVertex<Object, CostType> Vertex;
   typedef FHflowVertex<Object, CostType>* VertPtr;
   typedef map<VertPtr, CostType> EdgePairList;
   typedef set<VertPtr> VertPtrSet;
   typedef set<Vertex> VertexSet;

private:
   VertPtrSet vertPtrSet;
   VertexSet vertexSet;
   VertPtr startVertPtr, endVertPtr;

public:
   FHflowGraph() {}
   void addEdge(const Object &source, const Object &dest, CostType cost);
   VertPtr addToVertexSet(const Object & object);
   void clear();
   
   // Additions and\or Modifications
   void showResAdjTable();
   void showFlowAdjTable();
   bool setEndVert(const Object &Data);
   bool setStartVert(const Object &Data);

   CostType findMaxFlow();
   CostType getLimitingFlowOnResPath();


private:
   VertPtr getVertexWithThisData(const Object & x);

   // Additions and\or Modifications
   bool establishNextFowPath();
   bool adjustPathByCost(CostType cost);
   bool addCostToResEdge(VertPtr src, VertPtr dst, CostType cost);
   bool addCostToFlowEdge(VertPtr src, VertPtr dst, CostType cost);

   CostType getCostOfResEdge(VertPtr src, VertPtr dst);

};

// Unchanged...
template <class Object, typename CostType>
FHflowVertex<Object, CostType>* FHflowGraph<Object, CostType>::addToVertexSet(
   const Object & object)
{
   pair<typename VertexSet::iterator, bool> retVal;
   VertPtr vPtr;

   // save sort key for client
   Vertex::pushSortKey();
   Vertex::setNSortType(Vertex::SORT_BY_DATA);

   // build and insert vertex into master list
   retVal = vertexSet.insert(Vertex(object));

   // get pointer to this vertex and put into vert pointer list
   vPtr = (VertPtr)&*retVal.first;
   vertPtrSet.insert(vPtr);

   Vertex::popSortKey();  // restore client sort key
   return vPtr;
}

// Unchanged...
template <class Object, typename CostType>
void FHflowGraph<Object, CostType>::clear()
{
   vertexSet.clear();
   vertPtrSet.clear();
}

/*
Saved for reference...
template <class Object, typename CostType>
bool FHflowGraph<Object, CostType>::dijkstra(const Object & x)
{
   typename VertPtrSet::iterator vIter;
   typename EdgePairList::iterator edgePrIter;
   VertPtr wPtr, sPtr, vPtr;
   CostType costVW;
   queue<VertPtr> partiallyProcessedVerts;

   sPtr = getVertexWithThisData(x);
   if (sPtr == NULL)
      return false;

   // initialize the vertex list and place the starting vert in p_p_v queue
   for (vIter = vertPtrSet.begin(); vIter != vertPtrSet.end(); ++vIter)
   {
      (*vIter)->dist = Vertex::FHINFINITY;
      (*vIter)->nextInPath = NULL;
   }

   sPtr->dist = 0;
   partiallyProcessedVerts.push(sPtr); // or, FHbinHeap::insert(), e.g.

                                       // outer dijkstra loop
   while (!partiallyProcessedVerts.empty())
   {
      vPtr = partiallyProcessedVerts.front();
      partiallyProcessedVerts.pop();

      // inner dijkstra loop: for each vert adj to v, lower its dist to s if you can
      for (edgePrIter = vPtr->adjList.begin();
         edgePrIter != vPtr->adjList.end();
         edgePrIter++)
      {
         wPtr = edgePrIter->first;
         costVW = edgePrIter->second;
         if (vPtr->dist + costVW < wPtr->dist)
         {
            wPtr->dist = vPtr->dist + costVW;
            wPtr->nextInPath = vPtr;

            // *wPtr now has improved distance, so add wPtr to p_p_v queue
            partiallyProcessedVerts.push(wPtr);
         }
      }
   }
   return true;
}
*/

// Unchanged...
template <class Object, typename CostType>
FHflowVertex<Object, CostType>* FHflowGraph<Object, CostType>::getVertexWithThisData(
   const Object & x)
{
   typename VertexSet::iterator findResult;
   Vertex vert(x);

   Vertex::pushSortKey();  // save client sort key
   Vertex::setNSortType(Vertex::SORT_BY_DATA);
   findResult = vertexSet.find(vert);
   Vertex::popSortKey();  // restore client value

   if (findResult == vertexSet.end())
      return NULL;
   return  (VertPtr)&*findResult;     // the address of the vertex in the set of originals
}

// MODIFIED FUNCTIONS   -------------------------------------------------------
template <class Object, typename CostType>
void FHflowGraph<Object, CostType>::addEdge(
   const Object &source, const Object &dest, CostType cost)
{
   VertPtr src, dst;

   // put both source and dest into vertex list(s) if not already there
   src = addToVertexSet(source);
   dst = addToVertexSet(dest);

   // add dest to source's adjacency list
   // Modified to the Res & Flow Adjacency lists and includes the reverse edge
   src->addToResAdjList(dst, cost);
   dst->addToResAdjList(src, 0);
   src->addToFlowAdjList(dst, 0);
}

// ADDED FUNCTIONS   ----------------------------------------------------------
template <class Object, typename CostType>
void FHflowGraph<Object, CostType>::showFlowAdjTable()
{
   typename VertPtrSet::iterator iter;
   cout << "-----\tFLOW ADJACENCY TABLE\t-----\n";
   for (iter = vertPtrSet.begin(); iter != vertPtrSet.end(); ++iter)
      (*iter)->showFlowAdjList();
   cout << endl;
}

template <class Object, typename CostType>
void FHflowGraph<Object, CostType>::showResAdjTable()
{
   typename VertPtrSet::iterator iter;
   cout << "-----\tRES ADJACENCY TABLE\t-----\n";
   for (iter = vertPtrSet.begin(); iter != vertPtrSet.end(); ++iter)
      (*iter)->showResAdjList();
   cout << endl;
}

template <class Object, typename CostType>
bool FHflowGraph<Object, CostType>::establishNextFowPath()
{
   // Don't even try if there is no starting vertex
   if (NULL == startVertPtr)
      return false;

   typename VertPtrSet::iterator vertItr;
   typename EdgePairList::iterator edgeItr;
   VertPtr ptrX, ptrY;
   CostType cost;
   queue<VertPtr> processedVerts;

   for (vertItr = vertPtrSet.begin(); vertItr != vertPtrSet.end(); ++vertItr)
   {
      (*vertItr)->dist = Vertex::FHINFINITY;
      (*vertItr)->nextInPath = NULL;
   }

   startVertPtr->dist = 0;


   processedVerts.push(startVertPtr);
   while (!processedVerts.empty())
   {
      ptrY = processedVerts.front();
      processedVerts.pop();

      for (edgeItr = ptrY->resAdjList.begin(); edgeItr != ptrY->resAdjList.end(); edgeItr++)
      {
         ptrX = edgeItr->first;
         cost = edgeItr->second;
         if (cost == 0)
            continue;
         if (ptrY->dist + cost < ptrX->dist)
         {
            ptrX->dist = ptrY->dist + cost;
            ptrX->nextInPath = ptrY;

            processedVerts.push(ptrX);
         }

         if (ptrX == endVertPtr)
            return true;
      }
   }

   // Failed to locate the previously set end vert
   return false;
}

template <class Object, typename CostType>
bool FHflowGraph<Object, CostType>::setEndVert(const Object &Data)
{
   VertPtr temp = getVertexWithThisData(Data);
   if (NULL == temp)
      return false;
   endVertPtr = temp;
   return (endVertPtr->data == Data);
}

template <class Object, typename CostType>
bool FHflowGraph<Object, CostType>::adjustPathByCost(CostType cost)
{
   // If there are no start or end vertices then don't bother
   if (NULL == startVertPtr || NULL == endVertPtr)
      return false;

   VertPtr ptr;

   for (ptr = endVertPtr; ptr != startVertPtr; ptr = ptr->nextInPath)
   {
      // Discontinue processing if there are no vertices left to process
      if (NULL == ptr->nextInPath)
         break;


      if (!addCostToResEdge(ptr->nextInPath, ptr, cost) || !addCostToFlowEdge(ptr->nextInPath, ptr, cost))
         return false;
   }

   return true;
}

template <class Object, typename CostType>
bool FHflowGraph<Object, CostType>::setStartVert(const Object &Data)
{
   VertPtr temp = getVertexWithThisData(Data);
   if (NULL == temp)
      return false;

   startVertPtr = temp;
   return (startVertPtr->data == Data);
}

template <class Object, typename CostType>
CostType FHflowGraph<Object, CostType>::getCostOfResEdge(VertPtr src, VertPtr dst)
{
   typename VertPtrSet::iterator vertIter;
   typename EdgePairList::iterator edgeIter;

   vertIter = vertPtrSet.find(src);
   if (NULL == src || dst == NULL || vertIter == vertPtrSet.end())
      return Vertex::FHINFINITY;

   VertPtr ptr = *vertIter;

   for (edgeIter = ptr->resAdjList.begin(); edgeIter != ptr->resAdjList.end(); edgeIter++)
   {
      if (edgeIter->first == dst)
         return edgeIter->second;
   }

   return Vertex::FHINFINITY;
}

template <class Object, typename CostType>
bool FHflowGraph<Object, CostType>::addCostToResEdge(VertPtr src, VertPtr dst, CostType cost)
{
   typename VertPtrSet::iterator vertIter;
   typename EdgePairList::iterator edgeIter;

   vertIter = vertPtrSet.find(src);
   if (NULL == src || NULL == dst || vertIter == vertPtrSet.end())
      return false;

   VertPtr ptr = *vertIter;
   for (edgeIter = ptr->resAdjList.begin(); edgeIter != ptr->resAdjList.end(); edgeIter++)
   {
      if (edgeIter->first == dst)
      {
         edgeIter->second -= cost;
         ptr = edgeIter->first;

         for (edgeIter = ptr->resAdjList.begin(); edgeIter != ptr->resAdjList.end(); edgeIter++)
         {
            if (edgeIter->first == src)
            {
               edgeIter->second += cost;
               return true;
            }
         }
      }
   }

   // Failed to locate either the src and\or dst vertices
   return false;
}

template <class Object, typename CostType>
bool FHflowGraph<Object, CostType>::addCostToFlowEdge(VertPtr src, VertPtr dst, CostType cost)
{
   typename VertPtrSet::iterator vertIter;
   typename EdgePairList::iterator edgeIter;

   vertIter = vertPtrSet.find(src);
   if (NULL == src || NULL == dst || vertIter == vertPtrSet.end())
      return false;

   VertPtr ptr = *vertIter;
   for (edgeIter = ptr->flowAdjList.begin(); edgeIter != ptr->flowAdjList.end(); edgeIter++)
   {
      if (edgeIter->first == dst)
      {
         edgeIter->second += cost;
         return true;
      }
   }

   ptr = edgeIter->first;
   for (edgeIter = ptr->flowAdjList.begin(); edgeIter != ptr->flowAdjList.end(); edgeIter++)
   {
      if (edgeIter->first == src)
      {
         edgeIter->second -= cost;
         return true;
      }
   }

   // Failed to locate either the src and\or dst vertices
   return false;
}


template <class Object, typename CostType>
CostType FHflowGraph<Object, CostType>::findMaxFlow()
{
   CostType TotalCost = 0;
   typename EdgePairList::iterator iter;

   while (establishNextFowPath())
      adjustPathByCost(getLimitingFlowOnResPath());

   for (iter = startVertPtr->flowAdjList.begin(); iter != startVertPtr->flowAdjList.end(); iter++)
      TotalCost += iter->second;

   return TotalCost;
}

template <class Object, typename CostType>
CostType FHflowGraph<Object, CostType>::getLimitingFlowOnResPath()
{
   // If there are no start or end vertices the don't bother
   if (NULL == startVertPtr || NULL == endVertPtr)
      return Vertex::FHINFINITY;

   CostType currFlow, minFlow = Vertex::FHINFINITY;
   VertPtr ptr;

   for (ptr = endVertPtr; ptr != startVertPtr; ptr = ptr->nextInPath)
   {
      // Discontinue processing the loop if there exists no next vertex
      if (NULL == ptr->nextInPath)
         break;

      currFlow = getCostOfResEdge(ptr->nextInPath, ptr);
      minFlow = (currFlow < minFlow) ? currFlow : minFlow;
   }

   return minFlow;
}
#endif


/* 
CONSOLE OUTPUT ----------------------------------------------------------------
-------------------------------------------------------------------------------

-----   RES ADJACENCY TABLE     -----
Res Adj List for s: b(2) a(3)
Res Adj List for b: s(0) a(0) d(2)
Res Adj List for c: a(0) t(2)
Res Adj List for a: s(0) b(1) c(3) d(4)
Res Adj List for d: b(0) a(0) t(3)
Res Adj List for t: c(0) d(0)

-----   FLOW ADJACENCY TABLE    -----
Flow Adj List for s: b(0) a(0)
Flow Adj List for b: d(0)
Flow Adj List for c: t(0)
Flow Adj List for a: b(0) c(0) d(0)
Flow Adj List for d: t(0)
Flow Adj List for t:

Final flow: 5

-----   RES ADJACENCY TABLE     -----
Res Adj List for s: b(0) a(0)
Res Adj List for b: s(2) a(0) d(0)
Res Adj List for c: a(2) t(0)
Res Adj List for a: s(3) b(1) c(1) d(3)
Res Adj List for d: b(2) a(1) t(0)
Res Adj List for t: c(2) d(3)

-----   FLOW ADJACENCY TABLE    -----
Flow Adj List for s: b(2) a(3)
Flow Adj List for b: d(2)
Flow Adj List for c: t(2)
Flow Adj List for a: b(0) c(2) d(1)
Flow Adj List for d: t(3)
Flow Adj List for t:


*/