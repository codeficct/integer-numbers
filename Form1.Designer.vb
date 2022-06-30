<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrimeNumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccesNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sum2DigitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sum3DigitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Sum4DigitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReverseNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlyEvenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Result = New System.Windows.Forms.Label()
        Me.OnlyDoddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Hack Nerd Font", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(229, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Integer Numbers"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(246, 184)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.Menu2ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(573, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrimeNumbersToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'PrimeNumbersToolStripMenuItem
        '
        Me.PrimeNumbersToolStripMenuItem.Name = "PrimeNumbersToolStripMenuItem"
        Me.PrimeNumbersToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.PrimeNumbersToolStripMenuItem.Text = "Prime Numbers"
        '
        'Menu2ToolStripMenuItem
        '
        Me.Menu2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccesNumberToolStripMenuItem, Me.Sum2DigitToolStripMenuItem, Me.Sum3DigitsToolStripMenuItem, Me.Sum4DigitsToolStripMenuItem, Me.ReverseNumberToolStripMenuItem, Me.OnlyEvenToolStripMenuItem, Me.OnlyDoddToolStripMenuItem})
        Me.Menu2ToolStripMenuItem.Name = "Menu2ToolStripMenuItem"
        Me.Menu2ToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.Menu2ToolStripMenuItem.Text = "Acces Number"
        '
        'AccesNumberToolStripMenuItem
        '
        Me.AccesNumberToolStripMenuItem.Name = "AccesNumberToolStripMenuItem"
        Me.AccesNumberToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AccesNumberToolStripMenuItem.Text = "Sum 1 digits"
        '
        'Sum2DigitToolStripMenuItem
        '
        Me.Sum2DigitToolStripMenuItem.Name = "Sum2DigitToolStripMenuItem"
        Me.Sum2DigitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Sum2DigitToolStripMenuItem.Text = "Sum 2 digits"
        '
        'Sum3DigitsToolStripMenuItem
        '
        Me.Sum3DigitsToolStripMenuItem.Name = "Sum3DigitsToolStripMenuItem"
        Me.Sum3DigitsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Sum3DigitsToolStripMenuItem.Text = "Sum 3 digits"
        '
        'Sum4DigitsToolStripMenuItem
        '
        Me.Sum4DigitsToolStripMenuItem.Name = "Sum4DigitsToolStripMenuItem"
        Me.Sum4DigitsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Sum4DigitsToolStripMenuItem.Text = "Sum 4 digits"
        '
        'ReverseNumberToolStripMenuItem
        '
        Me.ReverseNumberToolStripMenuItem.Name = "ReverseNumberToolStripMenuItem"
        Me.ReverseNumberToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReverseNumberToolStripMenuItem.Text = "Verify if is capicua"
        '
        'OnlyEvenToolStripMenuItem
        '
        Me.OnlyEvenToolStripMenuItem.Name = "OnlyEvenToolStripMenuItem"
        Me.OnlyEvenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OnlyEvenToolStripMenuItem.Text = "Only Even"
        '
        'Result
        '
        Me.Result.AutoSize = True
        Me.Result.Location = New System.Drawing.Point(256, 260)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(79, 15)
        Me.Result.TabIndex = 3
        Me.Result.Text = "Result..."
        '
        'OnlyDoddToolStripMenuItem
        '
        Me.OnlyDoddToolStripMenuItem.Name = "OnlyDoddToolStripMenuItem"
        Me.OnlyDoddToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OnlyDoddToolStripMenuItem.Text = "Only Dodd"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 450)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Hack Nerd Font", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrimeNumbersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Result As Label
    Friend WithEvents Menu2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccesNumberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sum2DigitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sum3DigitsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Sum4DigitsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReverseNumberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnlyEvenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnlyDoddToolStripMenuItem As ToolStripMenuItem
End Class
