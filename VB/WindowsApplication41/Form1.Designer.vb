Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication41
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.cvGridControl1 = New WindowsApplication12.CVGridControl()
			Me.categoryRow4 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.categoryRow1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.multiEditorRow1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
			Me.multiEditorRow2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
			Me.multiEditorRow3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
			Me.categoryRow2 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.editorRow1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.categoryRow3 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.editorRow5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow6 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.categoryRow5 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.editorRow7 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow8 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow10 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow11 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow9 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			CType(Me.cvGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' cvGridControl1
			' 
			Me.cvGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.cvGridControl1.IndentWidth = 0
			Me.cvGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.cvGridControl1.Name = "cvGridControl1"
			Me.cvGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.categoryRow4, Me.categoryRow5})
			Me.cvGridControl1.Size = New System.Drawing.Size(498, 494)
			Me.cvGridControl1.TabIndex = 0
			' 
			' categoryRow4
			' 
			Me.categoryRow4.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.categoryRow1})
			Me.categoryRow4.Height = 19
			Me.categoryRow4.Name = "categoryRow4"
			' 
			' categoryRow1
			' 
			Me.categoryRow1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.multiEditorRow1, Me.multiEditorRow2, Me.multiEditorRow3, Me.categoryRow2})
			Me.categoryRow1.Name = "categoryRow1"
			' 
			' multiEditorRow1
			' 
			Me.multiEditorRow1.Name = "multiEditorRow1"
			' 
			' multiEditorRow2
			' 
			Me.multiEditorRow2.Name = "multiEditorRow2"
			' 
			' multiEditorRow3
			' 
			Me.multiEditorRow3.Name = "multiEditorRow3"
			' 
			' categoryRow2
			' 
			Me.categoryRow2.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.editorRow1, Me.editorRow4, Me.categoryRow3})
			Me.categoryRow2.Name = "categoryRow2"
			' 
			' editorRow1
			' 
			Me.editorRow1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.editorRow2, Me.editorRow3})
			Me.editorRow1.Name = "editorRow1"
			' 
			' editorRow2
			' 
			Me.editorRow2.Name = "editorRow2"
			' 
			' editorRow3
			' 
			Me.editorRow3.Name = "editorRow3"
			' 
			' editorRow4
			' 
			Me.editorRow4.Name = "editorRow4"
			' 
			' categoryRow3
			' 
			Me.categoryRow3.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.editorRow5, Me.editorRow6})
			Me.categoryRow3.Name = "categoryRow3"
			' 
			' editorRow5
			' 
			Me.editorRow5.Name = "editorRow5"
			' 
			' editorRow6
			' 
			Me.editorRow6.Name = "editorRow6"
			' 
			' categoryRow5
			' 
			Me.categoryRow5.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.editorRow7, Me.editorRow9})
			Me.categoryRow5.Name = "categoryRow5"
			' 
			' editorRow7
			' 
			Me.editorRow7.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.editorRow8, Me.editorRow10, Me.editorRow11})
			Me.editorRow7.Name = "editorRow7"
			' 
			' editorRow8
			' 
			Me.editorRow8.Name = "editorRow8"
			' 
			' editorRow10
			' 
			Me.editorRow10.Name = "editorRow10"
			' 
			' editorRow11
			' 
			Me.editorRow11.Name = "editorRow11"
			' 
			' editorRow9
			' 
			Me.editorRow9.Height = 16
			Me.editorRow9.Name = "editorRow9"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(498, 494)
			Me.Controls.Add(Me.cvGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.cvGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private cvGridControl1 As WindowsApplication12.CVGridControl
		Private categoryRow1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private multiEditorRow1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
		Private multiEditorRow2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
		Private multiEditorRow3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
		Private categoryRow2 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private editorRow1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow3 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private editorRow5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow6 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow4 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private categoryRow5 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private editorRow7 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow8 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow10 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow11 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow9 As DevExpress.XtraVerticalGrid.Rows.EditorRow

	End Class
End Namespace

