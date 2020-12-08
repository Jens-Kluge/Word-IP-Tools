Public Class frmNumberSentences
    Private Sub btnNumberStcs_Click(sender As Object, e As EventArgs) Handles btnNumberStcs.Click


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


        Dim i As Integer = 0
        Dim numSentences As Integer = doc.Sentences.Count
        ToolStripProgressBar1.Maximum = numSentences
        ToolStripProgressBar1.Minimum = 0
        ToolStripProgressBar1.Value = 0

        For Each stc As Word.Range In doc.Sentences

            stctext = stc.Text

            If IsSentence(stctext) Then

                stc.Collapse(Direction:=Word.WdCollapseDirection.wdCollapseStart)
                fld = doc.Fields.Add(stc, Word.WdFieldType.wdFieldEmpty, "SEQ IPT_STC", True)
                fld.Result.Font.Superscript = True
                fld.Result.InsertAfter(" ")

            End If

            i = i + 1
            ToolStripProgressBar1.Value = i
            ToolStripStatusLabel1.Text = FormatNumber(100 * i / numSentences, 0) & " %"
            StatusStrip1.Update()

        Next

        'pause for half a second to show the final status bar value
        System.Threading.Thread.Sleep(500)
        ToolStripProgressBar1.Value = 0
        ToolStripStatusLabel1.Text = ""

        Globals.ThisAddIn.Application.ScreenUpdating = True
        Exit Sub
errHandler:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
        Globals.ThisAddIn.Application.ScreenUpdating = True

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim doc As Word.Document
        Dim fld As Word.Field
        Dim txt As String

        'no document open => exit this subroutine
        If Globals.ThisAddIn.Application.Documents.Count = 0 Then
            Exit Sub
        End If

        doc = Globals.ThisAddIn.Application.ActiveDocument

        Globals.ThisAddIn.Application.ScreenUpdating = False

        For Each fld In doc.Fields
            If Not Information.IsNothing(fld.Code) Then
                txt = fld.Code.Text
                If InStr(txt, "IPT_STC") > 0 Then
                    fld.Delete()
                End If
            End If

        Next
        Globals.ThisAddIn.Application.ScreenUpdating = True
    End Sub

    Private Sub btnFwd_Click(sender As Object, e As EventArgs) Handles btnFwd.Click

        If rbStc.Checked Then
            moveFwdSentences(1)
        ElseIf rbfld.Checked Then
            MoveFwdFields(1)
        End If

    End Sub

    Private Sub moveFwdSentences(numSentences As Integer)

        Dim sel As Word.Selection
        Dim app As Word.Application = Globals.ThisAddIn.Application

        If Information.IsNothing(app.ActiveDocument.ActiveWindow.Selection) Then
            Exit Sub
        End If

        Try
            sel = app.ActiveDocument.ActiveWindow.Selection

            For i = 1 To numSentences
                sel.MoveRight(Unit:=Word.WdUnits.wdSentence, Count:=1, Extend:=Word.WdMovementType.wdMove)
                sel.MoveRight(Unit:=Word.WdUnits.wdSentence, Count:=1, Extend:=Word.WdMovementType.wdExtend)

                While Not IsSentence(sel.Text)
                    sel.MoveRight(Unit:=Word.WdUnits.wdSentence, Count:=1, Extend:=Word.WdMovementType.wdMove)
                    sel.MoveRight(Unit:=Word.WdUnits.wdSentence, Count:=1, Extend:=Word.WdMovementType.wdExtend)
                End While
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MoveFwdFields(numFields As Integer)
        Dim sel As Word.Selection
        Dim app As Word.Application = Globals.ThisAddIn.Application
        Dim fld As Word.Field

        If Information.IsNothing(app.ActiveDocument.ActiveWindow.Selection) Then
            Exit Sub
        End If

        Try
            For i = 1 To numFields
                sel = app.ActiveDocument.ActiveWindow.Selection

                fld = sel.NextField
                If fld Is Nothing Then Exit Sub
                fld.Select()

                While Not IsStcNumber(fld)
                    fld = fld.Next
                    If fld Is Nothing Then
                        Exit While
                    End If
                    fld.Select()
                End While
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MoveBackFields(numFields As Integer)
        Dim sel As Word.Selection
        Dim app As Word.Application = Globals.ThisAddIn.Application
        Dim fld As Word.Field

        If Information.IsNothing(app.ActiveDocument.ActiveWindow.Selection) Then
            Exit Sub
        End If

        For i = 1 To numFields
            sel = app.ActiveDocument.ActiveWindow.Selection

            fld = sel.PreviousField
            If fld Is Nothing Then Exit Sub
            fld.Select()

            While Not IsStcNumber(fld)
                fld = fld.Previous
                If fld Is Nothing Then
                    Exit While
                End If
                fld.Select()
            End While
        Next
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        If rbStc.Checked Then
            MoveBackSentences(1)
        ElseIf rbfld.Checked Then
            MoveBackFields(1)
        End If

    End Sub

    Private Sub MoveBackSentences(numSentences As Integer)
        Dim sel As Word.Selection
        Dim app As Word.Application = Globals.ThisAddIn.Application

        If Information.IsNothing(app.ActiveDocument.ActiveWindow.Selection) Then
            Exit Sub
        End If

        Try
            sel = app.ActiveDocument.ActiveWindow.Selection

            For i = 1 To numSentences


                sel.MoveLeft(Unit:=Word.WdUnits.wdSentence, Count:=1, Extend:=Word.WdMovementType.wdMove)
                sel.MoveLeft(Unit:=Word.WdUnits.wdSentence, Count:=1, Extend:=Word.WdMovementType.wdExtend)

                While Not IsSentence(sel.Text)
                    sel.MoveLeft(Unit:=Word.WdUnits.wdSentence, Count:=1, Extend:=Word.WdMovementType.wdMove)
                    sel.MoveLeft(Unit:=Word.WdUnits.wdSentence, Count:=1, Extend:=Word.WdMovementType.wdExtend)
                End While
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Remove non-printable chars from a string
    ''' </summary>
    ''' <param name="str"></param>
    ''' <returns></returns>
    Private Function Remove(str As String) As String
        Remove = str

        Dim x As Long
        ' remove all non-printable characters
        While InStr(Remove, vbCrLf) > 0
            Remove = Replace(Remove, vbCrLf, String.Empty)
        End While

        While InStr(Remove, vbTab) > 0
            Remove = Replace(Remove, vbTab, String.Empty)
        End While

        For x = 0 To 31
            While InStr(Remove, Chr(x)) > 0
                Remove = Replace(Remove, Chr(x), String.Empty)
            End While
        Next x

        For x = 127 To 255
            While InStr(Remove, Chr(x)) > 0
                Remove = Replace(Remove, Chr(x), String.Empty)
            End While
        Next x

    End Function

    Private Function IsSentence(str As String) As Boolean
        IsSentence = True
        str = Remove(str)
        If str.Length = 0 Then
            IsSentence = False
        End If
    End Function

    Private Sub btnffwd_Click(sender As Object, e As EventArgs) Handles btnffwd.Click

        If rbStc.Checked Then
            moveFwdSentences(5)
        ElseIf rbfld.Checked Then
            MoveFwdFields(5)
        End If

    End Sub

    Private Sub btnRewind_Click(sender As Object, e As EventArgs) Handles btnRewind.Click

        If rbStc.Checked Then
            MoveBackSentences(5)
        Else
            MoveBackFields(5)
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnRemoveNumSelStcs_Click(sender As Object, e As EventArgs) Handles btnRemoveNumSelStcs.Click
        Dim sel As Word.Selection
        Dim fld As Word.Field
        Dim txt As String

        Dim app As Word.Application = Globals.ThisAddIn.Application

        On Error GoTo ErrHandler

        If app.ActiveDocument.ActiveWindow.Selection Is Nothing Then
            Exit Sub
        End If

        sel = app.ActiveDocument.ActiveWindow.Selection

        For Each fld In sel.Fields

            If IsStcNumber(fld) Then
                fld.Delete()
            End If

        Next fld

        Exit Sub
ErrHandler:
        MsgBox(Err.Description)
    End Sub

    ''' <summary>
    ''' Tests whether the field is a sentence number generated by this addin
    ''' </summary>
    ''' <param name="fld"></param>
    ''' <returns></returns>
    Private Function IsStcNumber(fld As Word.Field) As Boolean

        IsStcNumber = False
        If fld Is Nothing Then
            Exit Function
        End If

        If InStr(fld.Code.Text, "IPT_STC") > 0 Then
            IsStcNumber = True
        End If

    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim doc As Word.Document
        'update the fields

        'no document open => exit this subroutine
        If Globals.ThisAddIn.Application.Documents.Count = 0 Then
            Exit Sub
        End If
        doc = Globals.ThisAddIn.Application.ActiveDocument

        doc.Fields.Update()
    End Sub

    Private Sub btnAddNumSelStcs_Click(sender As Object, e As EventArgs) Handles btnAddNumSelStcs.Click
        Dim sel As Word.Selection
        Dim stc As Word.Range
        Dim stcs As Word.Sentences
        Dim fld As Word.Field
        Dim doc As Word.Document
        Dim app As Word.Application = Globals.ThisAddIn.Application
        Dim stctext As String


        On Error GoTo errHandler
        'number paragraphs in the active document

        'no document open => exit this subroutine
        If app.Documents.Count = 0 Then
            Exit Sub
        End If
        doc = app.ActiveDocument

        Globals.ThisAddIn.Application.ScreenUpdating = False

        sel = app.ActiveDocument.ActiveWindow.Selection
        stcs = sel.Sentences
        For Each stc In stcs

            stctext = stc.Text

            If IsSentence(stctext) Then

                stc.Collapse(Direction:=Word.WdCollapseDirection.wdCollapseStart)
                fld = doc.Fields.Add(stc, Word.WdFieldType.wdFieldEmpty, "SEQ IPT_STC", True)
                fld.Result.Font.Superscript = True
                fld.Result.InsertAfter(" ")

            End If

        Next

        Globals.ThisAddIn.Application.ScreenUpdating = True
        Exit Sub
errHandler:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
        Globals.ThisAddIn.Application.ScreenUpdating = True
    End Sub

    Private Sub frmNumberSentences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbStc.Checked = True
    End Sub
End Class