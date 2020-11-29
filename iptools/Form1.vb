Imports System.Text.RegularExpressions
Public Class frmNav
    'The paragraphs in the document are numbered with SEQ fields, 
    'the SEQ list has the identifier IPT_PARS
    'the format is [0001], wherein the number of leading zeros is determined by the updown control
    Private Sub btnNumberPars_Click(sender As Object, e As EventArgs) Handles btnNumberPars.Click
        Dim doc As Word.Document
        Dim dos As Word.Documents
        Dim par As Word.Paragraph
        Dim partext, strFormat As String
        Dim rg As Word.Range
        Dim sel As Word.Selection
        Dim fld As Word.Field

        On Error GoTo errHandler
        'number paragraphs in the active document

        'no docuemnt open => exit this subroutien
        If Globals.ThisAddIn.Application.Documents.Count = 0 Then
            Exit Sub
        End If
        doc = Globals.ThisAddIn.Application.ActiveDocument

        strFormat = genFormatString()

        Globals.ThisAddIn.Application.ScreenUpdating = False

        For Each par In doc.Paragraphs

            rg = par.Range
            partext = rg.Text

            If IsParagraph(par) Then

                rg.Collapse(Direction:=Word.WdCollapseDirection.wdCollapseStart)
                fld = rg.Fields.Add(rg, Word.WdFieldType.wdFieldEmpty, "SEQ IPT_PARS \# " & strFormat, True)

            End If

        Next

        Globals.ThisAddIn.Application.ScreenUpdating = True
        Exit Sub
errHandler:
        'MsgBox(Err.Description, MsgBoxStyle.Critical)
        Globals.ThisAddIn.Application.ScreenUpdating = True
        If Not Information.IsNothing(par) Then
            Resume Next
        End If
    End Sub

    Function IsParagraph(par As Word.Paragraph)

        Dim parlen As Integer
        Dim text As String

        IsParagraph = True
        text = par.Range.Text
        'remove non-printable characters
        text = Regex.Replace(Text, "[^A-Za-z0-9\-/]", "")
        parlen = Len(Text)
        If parlen = 0 Then IsParagraph = False

    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim doc As Word.Document
        'update the fields

        'no docuemnt open => exit this subroutien
        If Globals.ThisAddIn.Application.Documents.Count = 0 Then
            Exit Sub
        End If
        doc = Globals.ThisAddIn.Application.ActiveDocument

        doc.Fields.Update()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim doc As Word.Document
        Dim fld As Word.Field
        Dim txt As String

        'no docuemnt open => exit this subroutien
        If Globals.ThisAddIn.Application.Documents.Count = 0 Then
            Exit Sub
        End If

        doc = Globals.ThisAddIn.Application.ActiveDocument

        Globals.ThisAddIn.Application.ScreenUpdating = False
        For Each fld In doc.Fields
            If Not Information.IsNothing(fld.Code) Then
                txt = fld.Code.Text
                If InStr(txt, "PARS") > 0 Then
                    fld.Delete()
                End If
            End If

        Next
        Globals.ThisAddIn.Application.ScreenUpdating = True
    End Sub

    Private Sub frmNav_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRemoveThis_Click(sender As Object, e As EventArgs) Handles btnRemoveThis.Click

        Dim sel As Word.Selection
        Dim par As Word.Paragraph
        Dim fld As Word.Field
        Dim txt As String
        Dim i, parcount As Integer

        On Error GoTo errHandler

        If Information.IsNothing(Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow.Selection) Then
            Exit Sub
        End If

        sel = Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow.Selection
        par = sel.Paragraphs(1)
        parcount = sel.Paragraphs.Count

        i = 0
        Do Until i = parcount Or Information.IsNothing(par)

            For Each fld In par.Range.Fields
                If Not Information.IsNothing(fld.Code) Then
                    txt = fld.Code.Text
                    If InStr(txt, "PARS") > 0 Then
                        fld.Delete()
                    End If
                End If
            Next
            i = i + 1
            par = par.Next
        Loop

        Exit Sub
ErrHandler:
        MsgBox(Err.Description)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim par As Word.Paragraph
        Dim sel As Word.Selection
        On Error GoTo ErrHandler

        If Information.IsNothing(Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow.Selection) Then
            Exit Sub
        End If

        sel = Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow.Selection
        par = sel.Paragraphs(sel.Paragraphs.Count)

        If Information.IsNothing(par.Next) Then
            Exit Sub
        End If
        par = par.Previous
        par.Range.Select()
        Exit Sub

ErrHandler:
        MsgBox(Err.Description)
    End Sub

    Private Sub btnFwd_Click(sender As Object, e As EventArgs) Handles btnFwd.Click
        Dim par As Word.Paragraph
        Dim sel As Word.Selection
        On Error GoTo errHandler

        If Information.IsNothing(Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow.Selection) Then
            Exit Sub
        End If

        sel = Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow.Selection
        par = sel.Paragraphs(sel.Paragraphs.Count)

        If Information.IsNothing(par.Next) Then
            Exit Sub
        End If
        par = par.Next
        par.Range.Select()
        Exit Sub
ErrHandler:
        MsgBox(Err.Description)
    End Sub

    Private Sub btnRewind_Click(sender As Object, e As EventArgs) Handles btnRewind.Click
        Dim sel As Word.Selection
        Dim par, prevPar As Word.Paragraph
        On Error GoTo ErrHandler

        If Information.IsNothing(Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow.Selection) Then
            Exit Sub
        End If

        sel = Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow.Selection
        par = sel.Paragraphs(1)

        For i = 1 To 5


            If Information.IsNothing(par.Previous) Then
                Exit Sub
            End If

            par = par.Previous
            par.Range.Select()
        Next

        Exit Sub
ErrHandler:
        MsgBox(Err.Description)
    End Sub

    Private Sub btnffwd_Click(sender As Object, e As EventArgs) Handles btnffwd.Click
        Dim sel As Word.Selection
        Dim par As Word.Paragraph
        On Error GoTo ErrHandler

        If Information.IsNothing(Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow.Selection) Then
            Exit Sub
        End If

        sel = Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow.Selection
        par = sel.Paragraphs(sel.Paragraphs.Count)

        For i = 1 To 5


            If Information.IsNothing(par.Next) Then
                Exit Sub
            End If

            par = par.Next
            par.Range.Select()
        Next

        Exit Sub
ErrHandler:
        MsgBox(Err.Description)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Dim strdisp As String
        strdisp = "00001"
        strdisp = strdisp.Substring(strdisp.Length - NumericUpDown1.Value, NumericUpDown1.Value)
        strdisp = "[" & strdisp & "]"

        lblPreview.Text = strdisp
    End Sub

    Private Function genFormatString() As String

        Dim strformat As String
        strformat = "00000"
        strFormat = strFormat.Substring(strFormat.Length - NumericUpDown1.Value, NumericUpDown1.Value)
        strFormat = Chr(34) & "[" & strFormat & "] " & Chr(34)

        genFormatString = strformat

    End Function

    Private Sub btnAddNumberSel_Click(sender As Object, e As EventArgs) Handles btnAddNumberSel.Click

        Dim rg As Word.Range
        Dim sel As Word.Selection
        Dim par As Word.Paragraph
        Dim fld As Word.Field
        Dim partext, strformat As String
        Dim pars As Word.Paragraphs
        Dim i, parcount As Integer

        On Error GoTo errHandler

        If Information.IsNothing(Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow.Selection) Then
            Exit Sub
        End If

        strformat = genFormatString()

        sel = Globals.ThisAddIn.Application.ActiveDocument.ActiveWindow.Selection
        pars = sel.Paragraphs

        parcount = sel.Paragraphs.Count
        par = sel.Paragraphs(1)

        i = 0
        Do Until i = parcount Or Information.IsNothing(par)

            rg = par.Range
            partext = rg.Text

            If IsParagraph(par) Then

                rg.Collapse(Direction:=Word.WdCollapseDirection.wdCollapseStart)
                fld = rg.Fields.Add(rg, Word.WdFieldType.wdFieldEmpty, "SEQ IPT_PARS \# " & strformat, True)

            End If
            i = i + 1
            par = par.Next

        Loop

        Exit Sub
errHandler:
        MsgBox(Err.Description)
    End Sub
End Class