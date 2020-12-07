Public Class frmNumberSentences
    Private Sub btnNumberStcs_Click(sender As Object, e As EventArgs) Handles btnNumberStcs.Click

        Dim rg As Word.Range
        Dim sel As Word.Selection
        Dim fld As Word.Field
        Dim doc As Word.Document
        Dim app As Word.Application = Globals.ThisAddIn.Application
        Dim stctext As String

        On Error GoTo errHandler
        'number paragraphs in the active document

        'no document open => exit this subroutine
        If Globals.ThisAddIn.Application.Documents.Count = 0 Then
            Exit Sub
        End If
        doc = app.ActiveDocument

        Globals.ThisAddIn.Application.ScreenUpdating = False

        For Each stc As Word.Range In doc.Sentences

            stctext = stc.Text

            If IsSentence(stctext) Then

                stc.InsertBefore(" ")
                stc.Collapse(Direction:=Word.WdCollapseDirection.wdCollapseStart)
                fld = doc.Fields.Add(stc, Word.WdFieldType.wdFieldEmpty, "SEQ IPT_STC", True)
                fld.Result.Font.Superscript = True

            End If

        Next

        Globals.ThisAddIn.Application.ScreenUpdating = True
        Exit Sub
errHandler:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
        Globals.ThisAddIn.Application.ScreenUpdating = True

    End Sub

    Public Function IsSentence(stctext As String) As Boolean
        Return True
    End Function

End Class