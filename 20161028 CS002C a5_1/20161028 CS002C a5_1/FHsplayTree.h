// NAME: FHsplayTree.h
// INST: CS02C Prof. DHardeen
// DESC: 
//

#ifndef INCL_SPLAYTREE_H
#define INCL_SPLAYTREE_H
#include "FHsearch_tree.h"

// ----------------------------------------------------------------------------
// FHsplayTree class definition
// -> NOTE: Most of this class has been copied from the FHavlTree.h file
// ----------------------------------------------------------------------------
template <class Comparable>
class FHsplayTree : public FHsearch_tree<Comparable>
{
protected:

   inline int max(int a, int b) { return (a < b) ? b : a; }

   // static because the node whose height we want might be null
   static int heightOf(FHs_treeNode<Comparable> *t)
   {
      return t == NULL ? -1 : t->getHeight();
   }

   FHs_treeNode<Comparable> *clone( FHs_treeNode<Comparable> *root) const;

   bool insert( const Comparable & x, FHs_treeNode<Comparable> * & root );
   bool remove( const Comparable & x, FHs_treeNode<Comparable> * & root );
   void rotateWithLeftChild( FHs_treeNode<Comparable> * & k2 );
   void doubleWithLeftChild( FHs_treeNode<Comparable> * & k3 );
   void rotateWithRightChild( FHs_treeNode<Comparable> * & k2 );
   void doubleWithRightChild( FHs_treeNode<Comparable> * & k3 );


public:
   // Custom default constructor
   FHsplayTree() : FHsearch_tree<Comparable>() 
   { 
   }

   // Custom copy constructor
   FHsplayTree(const FHsplayTree &rhs)
   {
      this->mSize = 0;
      this->mRoot = NULL; 

      *this = rhs;
   }

   const FHsplayTree & operator=(const FHsplayTree &rhs);

   const Comparable &showRoot();

   // override base class insert/remove
   bool insert(const Comparable &x);
   bool remove(const Comparable &x);


   // a fun and informative touch
   int showHeight() const { return heightOf(this->mRoot); }
};

// FHsplayTree method definitions -------------------
// private utilities for member methods
template <class Comparable>
bool FHsplayTree<Comparable>::insert( const Comparable & x, 
   FHs_treeNode<Comparable> * & root )
{
   if( root == NULL )
   {
      // found a place to hang new node
      root = new FHs_treeNode<Comparable>(x);
      return true;
   }
   else if( x < root->data )
   {
      if ( !insert(x, root->lftChild) )
         return false;
      if(heightOf(root->lftChild) - heightOf(root->rtChild) == 2)
         if( x < root->lftChild->data )
            rotateWithLeftChild(root);
         else
            doubleWithLeftChild(root);
   }
   else if(root->data < x)
   {
      if ( !insert(x, root->rtChild) )
         return false;
      if(heightOf(root->rtChild) - heightOf(root->lftChild) == 2)
         if(root->rtChild->data < x)
            rotateWithRightChild(root);
         else
            doubleWithRightChild(root);
   }
   else
      return false;

   // successfully inserted at this or lower level; adjust height
   root->setHeight( max(heightOf(root->lftChild), heightOf(root->rtChild)) + 1);
   return true;
}

template <class Comparable>
bool FHsplayTree<Comparable>::remove( const Comparable & x, 
   FHs_treeNode<Comparable> * & root )
{
   if (root == NULL)
      return false;

   if (x < root->data)
   {
      if ( !remove(x, root->lftChild) )
         return false;

      // rebalance - shortened left branch so right may now be higher by 2
      if(heightOf(root->rtChild) - heightOf(root->lftChild) == 2)
         if(heightOf(root->rtChild->rtChild) < heightOf(root->rtChild->lftChild))
            doubleWithRightChild(root);
         else
            rotateWithRightChild(root);
   }
   else if (root->data < x)
   {
      if ( !remove(x, root->rtChild) )
         return false;

      // rebalance - shortened right branch so left may now be higher by 2
      if(heightOf(root->lftChild) - heightOf(root->rtChild) == 2)
         if(heightOf(root->lftChild->lftChild) < heightOf(root->lftChild->rtChild))
            doubleWithLeftChild(root);
         else
            rotateWithLeftChild(root);
   }

   // found the node
   else if (root->lftChild != NULL && root->rtChild != NULL)
   {
      // first simply copy min right data into the node marked for deletion
      FHs_treeNode<Comparable> *minNode = this->findMin(root->rtChild);
      root->data = minNode->data;

      // now  do a real deletion:  the old min is still in the right sub-tree
      remove(minNode->data, root->rtChild);

      // rebalance - shortened right branch so left may now be higher by 2
      if(heightOf(root->lftChild) - heightOf(root->rtChild) == 2)
         if(heightOf(root->lftChild->lftChild) < heightOf(root->lftChild->rtChild))
            doubleWithLeftChild(root);
         else
            rotateWithLeftChild(root);
   }
   else
   {
      // no rebalancing needed at this external (1+ NULL children) node
      FHs_treeNode<Comparable> *nodeToRemove = root;
      root = (root->lftChild != NULL)? root->lftChild : root->rtChild;
      delete nodeToRemove;
      return true;

   }
   // successfully removed and rebalanced at this and lower levels; 
   // now adjust height
   root->setHeight(max(heightOf(root->lftChild), heightOf(root->rtChild)) + 1);
   return true;
}

template <class Comparable>
void FHsplayTree<Comparable>::rotateWithLeftChild( 
   FHs_treeNode<Comparable> * & k2 )
{
   FHs_treeNode<Comparable> *k1 = k2->lftChild;
   k2->lftChild = k1->rtChild;
   k1->rtChild = k2;
   k2->setHeight( max( heightOf(k2->lftChild),  heightOf(k2->rtChild) ) + 1 );
   k1->setHeight( max( heightOf(k1->lftChild),  k2->getHeight() ) + 1 );
   k2 = k1;
}

template <class Comparable>
void FHsplayTree<Comparable>::doubleWithLeftChild( 
   FHs_treeNode<Comparable> * & k3 )
{
   rotateWithRightChild(k3->lftChild);
   rotateWithLeftChild(k3);
}

template <class Comparable>
void FHsplayTree<Comparable>::rotateWithRightChild( 
   FHs_treeNode<Comparable> * & k2 )
{
   FHs_treeNode<Comparable> *k1 = k2->rtChild;
   k2->rtChild = k1->lftChild;
   k1->lftChild = k2;
   k2->setHeight( max( heightOf(k2->lftChild), heightOf(k2->rtChild) ) + 1 );
   k1->setHeight( max( heightOf(k1->rtChild), k2->getHeight() ) + 1 );
   k2 = k1;
}

template <class Comparable>
void FHsplayTree<Comparable>::doubleWithRightChild( 
   FHs_treeNode<Comparable> * & k3 )
{
   rotateWithLeftChild(k3->rtChild);
   rotateWithRightChild(k3);
}

// FHsearch_tree private method definitions -----------------------------
template <class Comparable>
FHs_treeNode<Comparable> *FHsplayTree<Comparable>::clone(
   FHs_treeNode<Comparable> *root) const
{
   FHs_treeNode<Comparable> *newNode;
   if (root == NULL)
      return NULL;

   newNode =  new FHs_treeNode<Comparable>(
      root->data, 
      clone(root->lftChild), clone(root->rtChild), root->getHeight());
   return newNode;
}

// public interface
template <class Comparable>
const Comparable &FHsplayTree<Comparable>::showRoot()
{
   return this->mRoot->data;
}

template <class Comparable>
bool FHsplayTree<Comparable>::insert( const Comparable &x )
{
   if (insert(x, this->mRoot))
   {
      this->mSize++;
      return true;
   }
   return false;
}

template <class Comparable>
bool FHsplayTree<Comparable>::remove( const Comparable &x )
{

   if (remove(x, this->mRoot))
   {
      this->mSize--;
      return true;
   }
   return false;
}

template <class Comparable>
const FHsplayTree<Comparable> &FHsplayTree<Comparable>::operator=
   (const FHsplayTree &rhs)
{
   if (&rhs != this) 
   {
      this->clear();
      this->mRoot = clone(rhs.mRoot);
      this->mSize = rhs.size();
   }
   return *this;
}
#endif