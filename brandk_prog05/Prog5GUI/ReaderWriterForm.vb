'----------------------------------------------
' Name: Kody Brand
' Date: 3/8/2016
' Description: Program5
'              Class FormClassThread
'                 
'----------------------------------------------

Imports UWPCS3340
Imports System.Windows.Forms

Public Class ReaderWriterForm
    Private _reader As Reader
    Private _writer As Writer


    Private Sub btnReader_Click(sender As Object, e As EventArgs) Handles btnReader.Click
        Try
            _reader = New Reader
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnWriter_Click(sender As Object, e As EventArgs) Handles btnWriter.Click
        Try
            _writer = New Writer
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class