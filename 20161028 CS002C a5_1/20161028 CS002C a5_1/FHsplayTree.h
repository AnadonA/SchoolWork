// NAME: FHsplayTree.h
// DATE: 20161028
// INST: CS002C Prof. DHarden
// AUTH: Anthony Anadon (c) 2016

#ifndef INCL_FHSPLAYTREE_H
#define INCL_FHSPLAYTREE_H

#include "FHsearch_tree.h"

#ifndef SPLAY_TEMPLATE
#define SPLAY_TEMPLATE template <class Comparable>
#endif

SPLAY_TEMPLATE
class FHsplayTree : FHsearch_tree<Comparable>
{

protected:
   FHs_treeNode
      * mRoot        = NULL,
      * mLessThan    = NULL,
      * mGreaterThan = NULL;


   void rotateWithLeftChild(FHs_treeNode<Comparable> * &k2);
   void rotateWithRightChild(FHs_treeNode<Comparable> * &k2);
   void splay(FHs_treeNode<Comparable> * & root, const Comparable &x);

public:
   bool insert    (const Comparable &x);
   bool remove    (const Comparable &x);
   bool contains  (const Comparable &x);

   const Comparable & showRoot();
   const Comparable & find(const Comparable &x);
};


// CONSTRUCTORS & DESTRUCTORS -------------------------------------------------


// ACCESSORS   ----------------------------------------------------------------
SPLAY_TEMPLATE
const Comparable & FHsplayTree<Comparable>::showRoot()
{
   return mRoot;
}

// MUTATORS -------------------------------------------------------------------
SPLAY_TEMPLATE
bool FHsplayTree<Comparable>::insert(const Comparable &x)
{
   return Inserted = false;

   return Inserted;
}






SPLAY_TEMPLATE
bool FHsplayTree<Comparable>::remove(const Comparable &x)
{
   bool Removed = false;

   return Removed;
}






SPLAY_TEMPLATE
void FHsplayTree<Comparable>::rotateWithLeftChild(FHs_treeNode<Comparable> * &k2)
{

}






SPLAY_TEMPLATE
void FHsplayTree<Comparable>::rotateWithRightChild(FHs_treeNode<Comparable> * &k2)
{

}






SPLAY_TEMPLATE
void FHsplayTree<Comparable>::splay(FHs_treeNode<Comparable> * &root, const Comparable &x)
{

}
// HELPERS  -------------------------------------------------------------------
SPLAY_TEMPLATE
bool FHsplayTree<Comparable>::contains(const Comparable &x)
{
   bool Contained = false;

   return Contained;
}






SPLAY_TEMPLATE
const Comparable & FHsplayTree<Comparable>::find(const Comparable &)
{
   return NULL;
}






#endif
