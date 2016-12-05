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

   static int const INFINITY_FH = INT_MAX;  // defined in limits.h
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
   : data(x), dist((CostType)INFINITY_FH),
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

   // algorithms
   bool dijkstra(const Object & x);
   bool showShortestPath(const Object & x1, const Object &  x2);
   bool showDistancesTo(const Object & x);

private:
   VertPtr getVertexWithThisData(const Object & x);
};

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

template <class Object, typename CostType>
void FHflowGraph<Object, CostType>::clear()
{
   vertexSet.clear();
   vertPtrSet.clear();
}

template <class Object, typename CostType>
void FHflowGraph<Object, CostType>::addEdge(
   const Object &source, const Object &dest, CostType cost)
{
   VertPtr src, dst;

   // put both source and dest into vertex list(s) if not already there
   src = addToVertexSet(source);
   dst = addToVertexSet(dest);

   // add dest to source's adjacency list
   src->addToAdjList(dst, cost);
}

template <class Object, typename CostType>
void FHflowGraph<Object, CostType>::showAdjTable()
{
   typename VertPtrSet::iterator iter;

   cout << "------------------------ \n";
   for (iter = vertPtrSet.begin(); iter != vertPtrSet.end(); ++iter)
      (*iter)->showAdjList();
   cout << endl;
}

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
      (*vIter)->dist = Vertex::INFINITY_FH;
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

// applies dijkstra, prints all distances - could be modified to skip dijkstra
template <class Object, typename CostType>
bool FHflowGraph<Object, CostType>::showDistancesTo(const Object & x)
{
   typename VertPtrSet::iterator vIter;

   if (!dijkstra(x))
      return false;

   cout << "Dist to " << x << " ----------- \n";
   for (vIter = vertPtrSet.begin(); vIter != vertPtrSet.end(); ++vIter)
   {
      cout << (*vIter)->data << " " << (*vIter)->dist << endl;
   }
   return true;
}

// applies dijkstra, prints shortest path - could be modified to skip dijkstra
template <class Object, typename CostType>
bool FHflowGraph<Object, CostType>::showShortestPath(const Object & x1,
   const Object & x2)
{
   VertPtr vp, start, stop;
   stack<VertPtr> pathStack;

   start = getVertexWithThisData(x1);
   stop = getVertexWithThisData(x2);
   if (start == NULL || stop == NULL)
      return false;

   // perhaps add argument indicating choice to skip this if pre-computed
   dijkstra(x1);

   for (vp = stop; vp != start; vp = vp->nextInPath)
   {
      if (vp->nextInPath == NULL)
      {
         cout << "No path found to from " << x1
            << " to " << x2 << endl;
         return false;
      }
      pathStack.push(vp);
   }
   pathStack.push(vp);

   cout << "Cost of shortest path from " << x1 << " to " << x2 << ": "
      << stop->dist << endl;
   while (true)
   {
      vp = pathStack.top();
      pathStack.pop();
      if (pathStack.empty())
      {
         cout << vp->data << endl;
         break;
      }
      cout << vp->data << " --> ";
   }
   return true;
}

#endif
