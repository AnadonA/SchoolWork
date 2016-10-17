//

#ifndef INCL_FHSPARSEMAT_H
#define INCL_FHSPARSEMAT_H

#include <iostream>
#include <iomanip>

#include "FHlist.h"
#include "FHvector.h"

using namespace std;

template <class T>
class SparseMat
{
protected:
  class MatNode;

  typedef FHlist<MatNode>     SMnodeRow;
  typedef FHvector<SMnodeRow> SMnodeCol;

  int    mMaxRows,
         mMaxCols;

  T      mDefaultValue;

  SMnodeCol mMasterCol;

public:
   ~SparseMat();
   SparseMat(int pMaxRows = 100, int pMaxCols = 100, const T &pDefaultValue = T());


   // ACCESSORS
   const int   getMaxRows();
   const int   getMaxCols();

   const T     &getDefaultValue();
   const T     get(int pRow, int pCol) const;


   // MUTATORS
   void        clear();

   bool        set(int pRow, int pCol, const T &pValue);


   // HELPERS
   void        showMatrix(int pCount = 100);
   void        showSubSquare(int pStart = 0, int pSize = 15);
};

// EXCEPTIONS  ----------------------------------------------------------------
class SMillegalAccessException : public exception {};






// CONSTRUCTORS & DESTRUCTORS -------------------------------------------------
template <class T>
SparseMat<T>::~SparseMat()
{
   clear();
}






template <class T>
SparseMat<T>::SparseMat(int pMaxRows, int pMaxCols, const T &pDefaultValue)
   :  mMaxRows(pMaxRows),
      mMaxCols(pMaxCols),
      mDefaultValue(pDefaultValue),
      mMasterCol(SMnodeCol(pMaxCols))
{

}






// ACCESSORS   ----------------------------------------------------------------
template <class T>
const int   SparseMat<T>::getMaxCols() { return mMaxCols; }






template <class T>
const int   SparseMat<T>::getMaxRows() { return mMaxRows; }






template <class T>
const T     &SparseMat<T>::getDefaultValue() { return mDefaultValue; }





template <class T>
const T     SparseMat<T>::get(int pRow, int pCol) const
{
   T ReturnValue = mDefaultValue;
   
   if (pRow < 0 || pRow >= mMaxRows || pCol < 0 || pCol >= mMaxCols)
      throw new SMillegalAccessException();

   if (mMasterCol[pRow].size() > 0)
   {
      SMnodeRow Row = mMasterCol[pRow];
      SMnodeRow::iterator RowIter = Row.begin();
      for (RowIter; RowIter != Row.end(); RowIter++)
      {
         MatNode Node = *RowIter;
         if (Node.getCol() == pCol)
            return Node.Value;
      }
   }

   return ReturnValue;
}






// MUTATORS -------------------------------------------------------------------
template <class T>
void        SparseMat<T>::clear()
{
   SMnodeCol::iterator ColIter = mMasterCol.begin();
   for (ColIter; ColIter != mMasterCol.end(); ColIter++)
      (*ColIter).clear();

   mMasterCol.clear();
}






template <class T>
bool        SparseMat<T>::set(int pRow, int pCol, const T &pValue)
{
   bool ValueSet = false;
   int Value = pValue;

   if (pRow < 0 || pRow >= mMaxRows || pCol < 0 || pCol >= mMaxCols)
      return ValueSet;

   if (pValue != mDefaultValue && mMasterCol[pRow].size() == 0)
   {
      MatNode NewNode = MatNode(pRow, pCol, pValue);
      mMasterCol[pRow].push_back(NewNode);
      ValueSet = true;
   }
   else
   {
      SMnodeRow::iterator RowIter = mMasterCol[pRow].begin();
      for (RowIter; RowIter != mMasterCol[pRow].end(); RowIter++)
      {
         if (pCol == (*RowIter).getCol())
         {
            if (pValue == mDefaultValue)
               mMasterCol[pRow].erase(RowIter);
            else
               (*RowIter).Value = pValue;
            ValueSet = true;
         }
         else if (pValue != mDefaultValue && pCol < (*RowIter).getCol())
         {
            MatNode NewNode = MatNode(pRow, pCol, pValue);
            mMasterCol[pRow].insert(RowIter, NewNode);
            ValueSet = true;
         }

         if (!ValueSet)
         {
            MatNode NewNode = MatNode(pRow, pCol, pValue);
            mMasterCol[pRow].push_back(NewNode);
            ValueSet = true;
         }

         if (ValueSet)
            break;
      }
   }

   

   return ValueSet;
}






// HELPERS  -------------------------------------------------------------------
template <class T>
void        SparseMat<T>::showMatrix(int pMaxLength)
{
   cout << "SPECIFIC MATRIX PRINTOUT" << endl;
   cout << setw(80) << setfill('-') << " " << endl;
   for (int i = 0; i < mMasterCol.size(); i++)
   {
      SMnodeRow CurRow = mMasterCol[i];
      if (CurRow.size() > 0)
         cout << setw(4) << setfill(' ') << i << ": ";

      SMnodeRow::iterator RowIter = CurRow.begin();
      for (RowIter; RowIter != CurRow.end(); RowIter++)
         cout << setw(2) << setfill('0') << (*RowIter).getCol() << " ";

      if (CurRow.size() > 0)
         cout << endl;
   }
}






template <class T>
void        SparseMat<T>::showSubSquare(int pStart, int pSize)
{
   int   StartRow = pStart,
         StartCol = pStart,
         EndRow   = pStart + pSize,
         EndCol   = pStart + pSize;

   EndCol = EndCol < mMaxCols ? EndCol : mMaxCols - 1;
   EndRow = EndRow < mMaxRows ? EndRow : mMaxRows - 1;

   cout << "MATRIX SUB SQUARE (" << StartRow << "," << StartCol << ")x("
      << EndRow << "," << EndCol << ")" << endl;
   cout << setw(80) << setfill('-') << " " << endl;

   int   r = StartRow,
         c = StartCol;

   for (r = StartRow; r <= EndRow; r++)
   {
      cout << setw(4) << setfill('0') << r << ":\t";

      if (mMasterCol[r].size() == 0)
      {
         for (c; c <= EndCol; c++)
            cout << setw(2) << setfill('0') << mDefaultValue << " ";

         c = StartCol;
      }
      else
      { 
         SMnodeRow::iterator RowIter = mMasterCol[r].begin();
         for (RowIter; RowIter != mMasterCol[r].end(); RowIter++)
         {
            int Col = (*RowIter).getCol();
            if (Col >= StartCol && Col <= EndCol)
            {
               for (c; c < Col; c++)
                  cout << setw(2) << setfill('0') << mDefaultValue << " ";

               cout << setw(2) << setfill('0') << (*RowIter).Value << " ";
               c++;
            }
         }

         for (c; c <= EndCol; c++)
            cout << setw(2) << setfill('0') << mDefaultValue << " ";

         c = StartCol;
      }

      cout << endl;
   }

}



// SparseMat<T>::MatNode Object Definition   ----------------------------------
template <class T>
class SparseMat<T>::MatNode
{
protected:
   int   mRow,
         mCol;

public:
   T     Value;

   ~MatNode() {}
   MatNode(int pRow = -1, int pCol = -1, const T &pValue = T())
      :  mRow(pRow),
         mCol(pCol),
         Value(pValue)
   {
   }

   // ACCESSORS   -------------------------------------------------------------
   const int   getRow() { return mRow; }
   const int   getCol() { return mCol; }

   const T     &operator=(const T &pValue) { return (Value = pValue); }
   bool        &operator==(const T &pValue) { return Value == pValue; }
};
#endif
