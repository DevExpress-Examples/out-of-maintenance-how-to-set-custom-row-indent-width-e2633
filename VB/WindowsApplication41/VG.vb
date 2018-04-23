Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.ViewInfo

Namespace WindowsApplication12
	Public Class CVGridControl
		Inherits VGridControl
		Public Sub New()
			MyBase.New()
			_indentWidth = -1
		End Sub

		Protected Overrides Function CreateViewInfo(ByVal isPrinting As Boolean) As BaseViewInfo
			Select Case LayoutStyle
				Case LayoutViewStyle.BandsView
					Return New CBandsViewInfo(Me, isPrinting)
				Case LayoutViewStyle.SingleRecordView
					Return New CSingleRecordViewInfo(Me, isPrinting)
				Case LayoutViewStyle.MultiRecordView
					Return New CMultiRecordViewInfo(Me, isPrinting)
			End Select
			Return Nothing
		End Function

		Private _indentWidth As Integer
		<DefaultValue(-1)> _
		Public Property IndentWidth() As Integer
			Get
				Return _indentWidth
			End Get
			Set(ByVal value As Integer)
				_indentWidth = value
				Me.LayoutChanged()
			End Set
		End Property

	End Class

	Public Class CSingleRecordViewInfo
		Inherits SingleRecordViewInfo
		Public Sub New(ByVal grid As VGridControlBase, ByVal isPrinting As Boolean)
			MyBase.New(grid, isPrinting)
		End Sub
		Protected Overrides Function GetRowIndentWidth() As Integer
			If TypeOf Me.Grid Is CVGridControl Then
				Dim grid As CVGridControl = CType(Me.Grid, CVGridControl)
				If grid.IndentWidth >= 0 Then
					Return grid.IndentWidth
				End If
			End If
			Return MyBase.GetRowIndentWidth()
		End Function
	End Class
	Public Class CMultiRecordViewInfo
		Inherits MultiRecordViewInfo
		Public Sub New(ByVal grid As VGridControlBase, ByVal isPrinting As Boolean)
			MyBase.New(grid, isPrinting)
		End Sub
		Protected Overrides Function GetRowIndentWidth() As Integer
			If TypeOf Me.Grid Is CVGridControl Then
				Dim grid As CVGridControl = CType(Me.Grid, CVGridControl)
				If grid.IndentWidth >= 0 Then
					Return grid.IndentWidth
				End If
			End If
			Return MyBase.GetRowIndentWidth()
		End Function
	End Class
	Public Class CBandsViewInfo
		Inherits BandsViewInfo
		Public Sub New(ByVal grid As VGridControlBase, ByVal isPrinting As Boolean)
			MyBase.New(grid, isPrinting)
		End Sub
		Protected Overrides Function GetRowIndentWidth() As Integer
			If TypeOf Me.Grid Is CVGridControl Then
				Dim grid As CVGridControl = CType(Me.Grid, CVGridControl)
				If grid.IndentWidth >= 0 Then
					Return grid.IndentWidth
				End If
			End If
			Return MyBase.GetRowIndentWidth()
		End Function
	End Class
End Namespace
