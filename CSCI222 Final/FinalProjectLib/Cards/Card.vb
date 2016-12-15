Imports System.Drawing

Public Class cCard
   Private mFace As Image

   '  PROPERTY DEFINITIONS ----------------------------------------------------
   ''' <summary>
   ''' 
   ''' </summary>
   ''' <returns></returns>
   Public ReadOnly Property Face
      Get
         Return mFace
      End Get
   End Property


   '  SUB|FUNCTION DEFINITIONS   ----------------------------------------------
   Public Sub New(pFace As Image)
      mFace = pFace
   End Sub
End Class
