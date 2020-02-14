Imports System.IO
Public Class Form1
    Public Rolls As New Dictionary(Of String, Integer)

    Public Bankrupcys As New Dictionary(Of String, Integer)

    Public CurrentUser As String = Environment.UserName

    Public Property Bankr As Integer
        Get
            Dim scrcccc = 0
            Bankrupcys.TryGetValue(CurrentUser, scrcccc)
            Return scrcccc
        End Get
        Set(value As Integer)
            Bankrupcys(CurrentUser) = value
        End Set
    End Property

    Public Property Roll As Integer
        Get
            Dim rolllll = 0
            Dim scrcccc = 0
            Rolls.TryGetValue(CurrentUser, scrcccc, rolllll)
            Return rollllll
        End Get
        Set(value As Integer)
            Bankrupcys(CurrentUser) = value
        End Set
    End Property

    Public Sub LoadFromFile()
        Dim contents As String()
        Try
            contents = System.IO.File.ReadAllLines("scores.txt")
        Catch ex As FileNotFoundException
            contents = {$"{Environment.UserName}:0"}
        End Try
        For Each line As String In contents
            line = line.TrimEnd()
            Dim split = line.Split(":")
            Bankrupcys(split(0)) = Integer.Parse(split(1))
            Rolls(split(0)) = Integer.Parse(split(2))
        Next
    End Sub

    Public Sub SaveToFile()
        Dim contents = ""
        For Each keypair In Bankrupcys
            contents += $"{keypair.Key}:{keypair.Value}{Environment.NewLine}"
        Next
        For Each keypair In Rolls
            contents += $"{keypair.Key}:{keypair.Value}{Environment.NewLine}"
        Next
        System.IO.File.WriteAllText("scores.txt", contents)
    End Sub


    Private Structure Symbol
        Dim number As Integer
    End Structure
    Dim credit As Integer = 100
    Dim symbol1 As Symbol
    Dim symbol2 As Symbol
    Dim symbol3 As Symbol

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadFromFile()
        TotalSpins.Text = "Your total rolls are: " & Bankr

        TextBox1.Text = credit

        TextBox1.Enabled = False
        RichTextBox1.Enabled = False
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RollMachine()

        TotalSpins.Text = "Your total rolls are: " & Bankr
        SaveToFile()
        Dim counter As Integer
        Dim r As New Random
        Dim imgtobox As String = Nothing
        Dim BoxList As New List(Of PictureBox) From {box1, box2, box3}
        credit = credit - 20
        symbol1.number = r.Next(1, 5)
        symbol2.number = r.Next(1, 5)
        symbol3.number = r.Next(1, 5)
        Dim symbolList As New List(Of Symbol) From {symbol1, symbol2, symbol3}
        'bells are shown by a 2
        'skulls are shown by a 5 
        For x = 0 To BoxList.Count - 1
            If symbolList(x).number = 1 Then
                imgtobox = "_cherry"
            ElseIf symbolList(x).number = 2 Then
                imgtobox = "_bell"
            ElseIf symbolList(x).number = 5 Then
                imgtobox = "_lemon"
            ElseIf symbolList(x).number = 4 Then
                imgtobox = "_star"
            ElseIf symbolList(x).number = 3 Then
                imgtobox = "_skull"
            End If
            BoxList(x).Image = My.Resources.ResourceManager.GetObject(imgtobox)
        Next

        If (symbol1.number = symbol2.number Or symbol1.number = symbol3.number Or symbol2.number = symbol3.number) And symbol1.number <> 3 And symbol3.number <> 3 And symbol2.number <> 3 Then
            If symbol1.number = symbol2.number = symbol3.number Then
                If Not symbol1.number = 2 Then
                    credit = credit + 100
                Else
                    credit = credit + 500
                End If
            Else
                credit = credit + 50
            End If
        Else
            If symbol1.number = 3 Then
                counter += 1
            End If
            If symbol2.number = 3 Then
                counter += 1
            End If
            If symbol3.number = 3 Then
                counter += 1
            End If
            If counter = 2 Then
                credit = credit - 100
            End If
            If counter = 3 Then
                credit = 0
            End If
        End If
        TextBox1.Text = credit

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If credit <= 0 Then
            Bankr = Bankr + 1
            SaveToFile()
            MsgBox("you have no money")
            Me.Close()
        End If
        RollMachine()
    End Sub
End Class