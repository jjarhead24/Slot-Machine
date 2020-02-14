<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.box3 = New System.Windows.Forms.PictureBox()
        Me.box1 = New System.Windows.Forms.PictureBox()
        Me.box2 = New System.Windows.Forms.PictureBox()
        Me.TotalSpins = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.box3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.box1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.box2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(323, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(465, 140)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Credit:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(126, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(103, 20)
        Me.TextBox1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SlotMachine.My.Resources.Resources._spin
        Me.PictureBox1.Location = New System.Drawing.Point(30, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'box3
        '
        Me.box3.Location = New System.Drawing.Point(563, 158)
        Me.box3.Name = "box3"
        Me.box3.Size = New System.Drawing.Size(157, 211)
        Me.box3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.box3.TabIndex = 3
        Me.box3.TabStop = False
        '
        'box1
        '
        Me.box1.Location = New System.Drawing.Point(311, 158)
        Me.box1.Name = "box1"
        Me.box1.Size = New System.Drawing.Size(157, 211)
        Me.box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.box1.TabIndex = 2
        Me.box1.TabStop = False
        '
        'box2
        '
        Me.box2.Location = New System.Drawing.Point(72, 158)
        Me.box2.Name = "box2"
        Me.box2.Size = New System.Drawing.Size(157, 211)
        Me.box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.box2.TabIndex = 1
        Me.box2.TabStop = False
        '
        'TotalSpins
        '
        Me.TotalSpins.AutoSize = True
        Me.TotalSpins.Location = New System.Drawing.Point(161, 62)
        Me.TotalSpins.Name = "TotalSpins"
        Me.TotalSpins.Size = New System.Drawing.Size(39, 13)
        Me.TotalSpins.TabIndex = 7
        Me.TotalSpins.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TotalSpins)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.box3)
        Me.Controls.Add(Me.box1)
        Me.Controls.Add(Me.box2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.box3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.box1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.box2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents box2 As PictureBox
    Friend WithEvents box1 As PictureBox
    Friend WithEvents box3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TotalSpins As Label
End Class
