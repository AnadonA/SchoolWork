// File FHsearch_tree.h
// Template definitions for FHsearchTrees, which are general trees
// 20161024 [modifications] Anthony Anadon 
#ifndef FHSEARCHTREE_H
#define FHSEARCHTREE_H

// ---------------------- FHs_treeNode Prototype --------------------------
template <class Comparable>
class FHs_treeNode
{
public:
   FHs_treeNode( const Comparable & d = Comparable(), 
      FHs_treeNode *lt = NULL, 
      FHs_treeNode *rt = NULL)
      : lftChild(lt), rtChild(rt), data(d), deleted(false)
   { }

   FHs_treeNode *lftChild, *rtChild;
   Comparable data;

   // 20161023 aanadon
   // Added for the implementation of soft node deletion.
   bool deleted;

   // for use only with AVL Trees
   virtual int getHeight() const { return 0; }
   virtual bool setHeight(int height) { return true; }
}; 

// ---------------------- FHsearch_tree Prototype --------------------------
template <class Comparable>
class FHsearch_tree
{
protected:
   int mSize, mSizeHard;
   FHs_treeNode<Comparable> *mRoot;

public:
   FHsearch_tree() { mSize = 0; mRoot = NULL; }
   FHsearch_tree(const FHsearch_tree &rhs) 
      { mRoot = NULL; mSize = 0; *this = rhs; }
   ~FHsearch_tree() { clear(); }

   const Comparable &findMin() const;
   const Comparable &findMax() const;
   const Comparable &find(const Comparable &x) const;

   bool empty() const { return (mSize == 0); }
   int size() const { return mSize; }
   int sizeHard() const { return mSizeHard; }
   void clear() { makeEmpty(mRoot); }
   const FHsearch_tree & operator=(const FHsearch_tree &rhs);

   int   collectGarbage();
   bool  insert(const Comparable &x);
   bool  remove(const Comparable &x);
   bool  removeHard(const Comparable &x);
   bool  contains(const Comparable &x) const { return find(mRoot, x) != NULL; }

   template <class Processor>
   void traverse(Processor func) const { traverse(mRoot, func); }
   int showHeight() const { return findHeight(mRoot); }

protected:
   FHs_treeNode<Comparable> *clone( FHs_treeNode<Comparable> *root) const;
   FHs_treeNode<Comparable> *findMin(FHs_treeNode<Comparable> *root) const;
   FHs_treeNode<Comparable> *findMax(FHs_treeNode<Comparable> *root) const;
   FHs_treeNode<Comparable> *find(FHs_treeNode<Comparable> *root,
      const Comparable &x) const;

   int   collectGarbage(FHs_treeNode<Comparable> * &root);
   bool  insert(FHs_treeNode<Comparable> * &root, const Comparable &x);
   bool  remove(FHs_treeNode<Comparable> * &root, const Comparable &x);
   bool  removeHard(FHs_treeNode<Comparable> * &root, const Comparable &x);
   void  makeEmpty(FHs_treeNode<Comparable> * &subtreeToDelete);
   template <class Processor>
   void  traverse(FHs_treeNode<Comparable> *treeNode, 
      Processor func, int level = -1) const;
   int   findHeight(FHs_treeNode<Comparable> *treeNode, int height = -1) const;
   
public:
   // for exception throwing
   class EmptyTreeException {};
   class NotFoundException {};
};

// FHsearch_tree public method definitions -----------------------------
template <class Comparable>
const Comparable & FHsearch_tree<Comparable>::findMin() const
{
   if (mRoot == NULL || mSize == 0)
      throw EmptyTreeException();
   return findMin(mRoot)->data;
}

template <class Comparable>
const Comparable & FHsearch_tree<Comparable>::findMax() const
{
   if (mRoot == NULL || mSize == 0)
      throw EmptyTreeException();
   return findMax(mRoot)->data;
}

template <class Comparable>
const Comparable &FHsearch_tree<Comparable>::find(
   const Comparable &x) const
{ 
   FHs_treeNode<Comparable> *resultNode;
   
   resultNode = find(mRoot, x);
   if (resultNode == NULL)
      throw NotFoundException();
    return resultNode->data;
}

template <class Comparable>
const FHsearch_tree<Comparable> &FHsearch_tree<Comparable>::operator=
   (const FHsearch_tree &rhs)
{
   if (&rhs != this) 
   {
      clear();
      mRoot = clone(rhs.mRoot);
      mSize = rhs.size();
      mSizeHard = rhs.sizeHard();
   }
   return *this;
}

template <class Comparable>
int FHsearch_tree<Comparable>::collectGarbage()
{
   if (mRoot == NULL)
      return -1;

   return collectGarbage(mRoot);
}

template <class Comparable>
bool FHsearch_tree<Comparable>::insert(const Comparable &x)
{
   if (insert(mRoot, x))
   {
      mSize++;
      mSizeHard++;
      return true;
   }
   return false;
}

template <class Comparable>
bool FHsearch_tree<Comparable>::remove(const Comparable &x)
{
   if (remove(mRoot, x))
   {
      mSize--;
      return true;
   }
   return false;
}

template <class Comparable>
bool FHsearch_tree<Comparable>::removeHard(const Comparable &x)
{
   if (removeHard(mRoot, x))
   {
      mSizeHard--;
      return true;
   }
   return false;
}

template <class Comparable>
template <class Processor>
void FHsearch_tree<Comparable>::traverse( FHs_treeNode<Comparable> *treeNode,
   Processor func, int level) const
{
   if (treeNode == NULL)
      return;

   // we're not doing anything with level but its there in case we want it
   traverse(treeNode->lftChild, func, level + 1);
   func(treeNode->data, treeNode->deleted);
   traverse(treeNode->rtChild, func, level + 1);
}


// FHsearch_tree private method definitions -----------------------------
template <class Comparable>
FHs_treeNode<Comparable> *FHsearch_tree<Comparable>::clone(
   FHs_treeNode<Comparable> *root) const
{
   FHs_treeNode<Comparable> *newNode;
   if (root == NULL)
      return NULL;

   newNode =  new FHs_treeNode<Comparable>(
      root->data, 
      clone(root->lftChild), clone(root->rtChild));
   return newNode;
}

template <class Comparable>
FHs_treeNode<Comparable> *FHsearch_tree<Comparable>::findMin(
   FHs_treeNode<Comparable> *root) const
{
   if (root == NULL)
      return NULL;
   if (root->lftChild == NULL)
      return root;
   return findMin(root->lftChild);
}

template <class Comparable>
FHs_treeNode<Comparable> *FHsearch_tree<Comparable>::findMax(
   FHs_treeNode<Comparable> *root) const
{
   if (root == NULL)
      return NULL;
   if (root->rtChild == NULL)
      return root;
   return findMax(root->rtChild);
}

template <class Comparable>
FHs_treeNode<Comparable>* FHsearch_tree<Comparable>::find(
   FHs_treeNode<Comparable> *root, const Comparable &x) const
{
   if (root == NULL)
      return NULL;

   if (x < root->data)
      return find(root->lftChild, x);
   if (root->data < x)
      return find(root->rtChild, x);
   return root;
}

template <class Comparable>
int FHsearch_tree<Comparable>::collectGarbage(
   FHs_treeNode<Comparable> * &treeNode)
{
   // For testing||debugging purposes
   static int CollectedGarbageCount = 0;

   // All done with this branch
   if (treeNode == NULL)
      return CollectedGarbageCount;

   collectGarbage(treeNode->lftChild);
   collectGarbage(treeNode->rtChild);

   if (treeNode->deleted)
   {
      CollectedGarbageCount++;
      removeHard(treeNode->data);
   }

   return CollectedGarbageCount;
}

// 20161024 aanadon
// Modified to 'undelete' lazily deleted nodes that have been re-inserted. This
// returns true: as if the node was actually inserted (instead of 'un-deleted')
template <class Comparable>
bool FHsearch_tree<Comparable>::insert(
   FHs_treeNode<Comparable> * &root, const Comparable &x)
{
   if (root == NULL)
   {
      root = new FHs_treeNode<Comparable>(x, NULL, NULL);
      return true;
   }
   else if (x < root->data)
      return insert(root->lftChild, x);
   else if (root->data < x)
      return insert(root->rtChild, x);
   else if (root->deleted)
   {
      root->deleted = false;
      mSize++;
   }

   return false; // duplicate
}

// 20161023 aanadon
// Modified to incorporate lazy deletion of tree nodes.
template <class Comparable>
bool FHsearch_tree<Comparable>::remove(
   FHs_treeNode<Comparable> * &root, const Comparable &x)
{
   if (root == NULL)
      return false;

   if (x < root->data)
      return remove(root->lftChild, x);
   if (root->data < x)
      return remove(root->rtChild, x);

   // Target node found. Only process the deletion if it hasn't previously been
   // 'deleted'. This will help to avoid multiple delete calls affecting the 
   // 'soft' size counter.
   if (!root->deleted)
   {
      root->deleted = true;
      return true;
   }
   return false;
}

// 20161023 aanadon
// Copied from the original FHsearch_tree<Comparable>::remove(...) function
template <class Comparable>
bool FHsearch_tree<Comparable>::removeHard(
   FHs_treeNode<Comparable> * &root, const Comparable &x)
{
   if (root == NULL)
      return false;

   if (x < root->data)
      return removeHard(root->lftChild, x);
   if (root->data < x)
      return removeHard(root->rtChild, x);

   // found the node
   if (root->lftChild != NULL && root->rtChild != NULL)
   {
      FHs_treeNode<Comparable> *minNode = findMin(root->rtChild);
      root->data = minNode->data;
      removeHard(root->rtChild, minNode->data);
   }
   else
   {
      FHs_treeNode<Comparable> *nodeToRemove = root;
      if (!root->deleted)
         mSize--;
      root = (root->lftChild != NULL) ? root->lftChild : root->rtChild;
      delete nodeToRemove;
   }
   return true;
}

template <class Comparable>
void FHsearch_tree<Comparable>::makeEmpty(
   FHs_treeNode<Comparable> * &subtreeToDelete)
{
   if (subtreeToDelete == NULL)
      return;

   // remove children
   makeEmpty(subtreeToDelete->lftChild);
   makeEmpty(subtreeToDelete->rtChild);


   if (!subtreeToDelete->deleted)
      mSize--;
   --mSizeHard;

   // clear client's pointer
   delete subtreeToDelete;
   subtreeToDelete = NULL;
}

template <class Comparable>
int FHsearch_tree<Comparable>::findHeight( FHs_treeNode<Comparable> *treeNode,
   int height ) const
{
   int leftHeight, rightHeight;

   if (treeNode == NULL)
      return height;
   height++;
   leftHeight = findHeight(treeNode->lftChild, height);
   rightHeight = findHeight(treeNode->rtChild, height);
   return (leftHeight > rightHeight)? leftHeight : rightHeight;
}
#endif