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
//    Additions and\or modifications were covered in the header comment(s).
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
   void rotateWithLeftChild( FHs_treeNode<Comparable> * & k2 );
   void rotateWithRightChild( FHs_treeNode<Comparable> * & k2 );

   void splay(FHs_treeNode<Comparable> * &root, const Comparable &x);

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
   bool contains(const Comparable &x);
   const Comparable &find(const Comparable &x);
};

// PRIVATE METHOD DEFINITIONS -------------------------------------------------
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






template <class Comparable>
void FHsplayTree<Comparable>::splay(FHs_treeNode<Comparable> * &root, 
   const Comparable &x)
{
   FHs_treeNode<Comparable>
      * LtMax  = NULL,
      * RtMin  = NULL,
      * LtSide = NULL,
      * RtSide = NULL;
      

   while (NULL != this->mRoot)
   {
      if (x < this->mRoot->data)
      {
         if (NULL == this->mRoot->lftChild)
            break;

         rotateWithLeftChild(this->mRoot);

         if (NULL == this->mRoot->lftChild)
            break;

         FHs_treeNode<Comparable> * TempNode = mRoot;
         this->mRoot = this->mRoot->lftChild;

         if (NULL == RtSide)
            RtSide = TempNode;
         else
            RtMin->lftChild = TempNode;
         
         TempNode->lftChild = NULL;
         RtMin = TempNode;

      }
      else if (this->mRoot->data < x)
      {
         if (NULL == this->mRoot->rtChild)
            break;

         rotateWithRightChild(this->mRoot);

         if (NULL == this->mRoot->rtChild)
            break;

         FHs_treeNode<Comparable> * TempNode = mRoot;
         this->mRoot = this->mRoot->rtChild; 

         if (NULL == LtSide)
            LtSide = TempNode;
         else
            LtMax->rtChild = TempNode;

         TempNode->rtChild = NULL;
         LtMax = TempNode;
      }

      else
      {
         break;
      }
   }

   // Re-Hang the splayed trees
   if (NULL != LtSide)
   {
      if (NULL != this->mRoot->lftChild)
         LtMax = this->mRoot->lftChild;
      this->mRoot->lftChild = LtSide;
   }

   if (NULL != RtSide)
   {
      if (NULL != this->mRoot->rtChild)
         RtMin = this->mRoot->rtChild;
      this->mRoot->rtChild = RtSide;
   }
}

// PUBLIC METHOD DEFINITIONS  -------------------------------------------------
template <class Comparable>
const Comparable &FHsplayTree<Comparable>::showRoot()
{
   if (NULL == this->mRoot)
      throw typename FHsearch_tree<Comparable>::NotFoundException();

   return this->mRoot->data;
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






template <class Comparable>
const Comparable &FHsplayTree<Comparable>::find(const Comparable &x)
{
   if (NULL == this->mRoot)
      throw typename FHsearch_tree<Comparable>::NotFoundException();

   splay(this->mRoot, x);

   if (x != this->mRoot->data)
      throw typename FHsearch_tree<Comparable>::NotFoundException();

   return this->mRoot->data;
}






template <class Comparable>
bool FHsplayTree<Comparable>::insert(const Comparable &x )
{
   if (NULL == this->mRoot)
   {
      mRoot = new FHs_treeNode<Comparable>(x);
      return true;
   }

   splay(this->mRoot, x);

   if (x < this->mRoot->data)
   {
      FHs_treeNode<Comparable> *NewNode = new FHs_treeNode<Comparable>(x);
      NewNode->lftChild = this->mRoot->lftChild;
      NewNode->rtChild = this->mRoot;
      this->mRoot = NewNode;
      return true;
   }
   else if (this->mRoot->data < x)
   {
      FHs_treeNode<Comparable> *NewNode = new FHs_treeNode<Comparable>(x);
      NewNode->rtChild = this->mRoot->rtChild;
      NewNode->lftChild = this->mRoot;
      this->mRoot = NewNode;
      return true;
   }

   return false;
}






template <class Comparable>
bool FHsplayTree<Comparable>::remove(const Comparable &x )
{
   if (NULL == this->mRoot)
      return false;

   splay(this->mRoot, x);

   if (x != this->mRoot->data)
      return false;

   FHs_treeNode<Comparable> * NewRoot = NULL;

   if (NULL == this->mRoot->lftChild)
      NewRoot = this->mRoot->rtChild;
   else
   {
      NewRoot = this->mRoot->lftChild;
      splay(NewRoot, x);
      NewRoot->rtChild = this->mRoot->rtChild;
   }

   delete this->mRoot;
   mRoot = NewRoot;

   return true;
}






template <class Comparable>
bool FHsplayTree<Comparable>::contains(const Comparable &x)
{
   return false;
}
#endif