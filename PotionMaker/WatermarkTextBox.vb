Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Friend Class WatermarkTextBox
    Inherits TextBox

    Public Sub New()
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        UpdateStyles()
    End Sub

    <Localizable(True)> _
    Public Property TextCue() As String
        Get
            Return Me.mTextCue
        End Get
        Set(value As String)
            Me.mTextCue = value
            Me.updateCue()
        End Set
    End Property

    Private Sub updateCue()
        If Me.IsHandleCreated AndAlso mTextCue IsNot Nothing Then
            SendMessage(Me.Handle, &H1501, CType(1, IntPtr), mTextCue)
        End If
    End Sub
    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        Me.updateCue()
    End Sub
    Private mTextCue As String

    ' PInvoke
    <DllImport("user32.dll", CharSet:=CharSet.Unicode)> _
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wp As IntPtr, lp As String) As IntPtr
    End Function
End Class