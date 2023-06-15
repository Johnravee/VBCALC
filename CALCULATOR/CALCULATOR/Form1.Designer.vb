<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CALC
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CALC))
        display = New TextBox()
        num1 = New TextBox()
        arith = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button0 = New Button()
        div = New Button()
        multi = New Button()
        subs = New Button()
        add = New Button()
        deci = New Button()
        equal = New Button()
        Del = New Button()
        CE = New Button()
        nega = New Button()
        landi = New Label()
        SuspendLayout()
        ' 
        ' display
        ' 
        display.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        display.BorderStyle = BorderStyle.None
        display.Enabled = False
        display.Font = New Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point)
        display.ForeColor = Color.White
        display.Location = New Point(93, 67)
        display.Name = "display"
        display.ReadOnly = True
        display.Size = New Size(185, 46)
        display.TabIndex = 0
        display.TextAlign = HorizontalAlignment.Right
        ' 
        ' num1
        ' 
        num1.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        num1.BorderStyle = BorderStyle.None
        num1.Enabled = False
        num1.Font = New Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point)
        num1.ForeColor = Color.White
        num1.Location = New Point(13, 67)
        num1.Name = "num1"
        num1.ReadOnly = True
        num1.Size = New Size(44, 46)
        num1.TabIndex = 1
        num1.TextAlign = HorizontalAlignment.Center
        ' 
        ' arith
        ' 
        arith.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        arith.BorderStyle = BorderStyle.None
        arith.Enabled = False
        arith.Font = New Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point)
        arith.ForeColor = Color.White
        arith.Location = New Point(51, 67)
        arith.Margin = New Padding(0)
        arith.Name = "arith"
        arith.ReadOnly = True
        arith.Size = New Size(48, 46)
        arith.TabIndex = 2
        arith.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.Gainsboro
        Button1.Location = New Point(12, 197)
        Button1.Name = "Button1"
        Button1.Size = New Size(62, 51)
        Button1.TabIndex = 3
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.Gainsboro
        Button2.Location = New Point(82, 197)
        Button2.Name = "Button2"
        Button2.Size = New Size(62, 51)
        Button2.TabIndex = 4
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        Button3.BackgroundImageLayout = ImageLayout.None
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ForeColor = Color.Gainsboro
        Button3.Location = New Point(148, 197)
        Button3.Name = "Button3"
        Button3.Size = New Size(62, 51)
        Button3.TabIndex = 5
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        Button4.BackgroundImageLayout = ImageLayout.None
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ForeColor = Color.Gainsboro
        Button4.Location = New Point(12, 254)
        Button4.Name = "Button4"
        Button4.Size = New Size(62, 51)
        Button4.TabIndex = 6
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        Button5.BackgroundImageLayout = ImageLayout.None
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.ForeColor = Color.Gainsboro
        Button5.Location = New Point(82, 254)
        Button5.Name = "Button5"
        Button5.Size = New Size(62, 51)
        Button5.TabIndex = 7
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        Button6.BackgroundImageLayout = ImageLayout.None
        Button6.FlatStyle = FlatStyle.Popup
        Button6.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.ForeColor = Color.Gainsboro
        Button6.Location = New Point(148, 254)
        Button6.Name = "Button6"
        Button6.Size = New Size(62, 51)
        Button6.TabIndex = 8
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        Button7.BackgroundImageLayout = ImageLayout.None
        Button7.FlatStyle = FlatStyle.Popup
        Button7.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button7.ForeColor = Color.Gainsboro
        Button7.Location = New Point(12, 311)
        Button7.Name = "Button7"
        Button7.Size = New Size(62, 51)
        Button7.TabIndex = 9
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        Button8.BackgroundImageLayout = ImageLayout.None
        Button8.FlatStyle = FlatStyle.Popup
        Button8.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button8.ForeColor = Color.Gainsboro
        Button8.Location = New Point(82, 311)
        Button8.Name = "Button8"
        Button8.Size = New Size(62, 51)
        Button8.TabIndex = 10
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        Button9.BackgroundImageLayout = ImageLayout.None
        Button9.FlatStyle = FlatStyle.Popup
        Button9.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button9.ForeColor = Color.Gainsboro
        Button9.Location = New Point(148, 311)
        Button9.Name = "Button9"
        Button9.Size = New Size(62, 51)
        Button9.TabIndex = 11
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button0
        ' 
        Button0.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        Button0.BackgroundImageLayout = ImageLayout.None
        Button0.FlatStyle = FlatStyle.Popup
        Button0.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button0.ForeColor = Color.Gainsboro
        Button0.Location = New Point(12, 368)
        Button0.Name = "Button0"
        Button0.Size = New Size(62, 51)
        Button0.TabIndex = 12
        Button0.Text = "0"
        Button0.UseVisualStyleBackColor = False
        ' 
        ' div
        ' 
        div.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        div.FlatStyle = FlatStyle.Popup
        div.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point)
        div.ForeColor = Color.Gainsboro
        div.Location = New Point(215, 143)
        div.Name = "div"
        div.Size = New Size(62, 51)
        div.TabIndex = 13
        div.Text = "÷"
        div.UseVisualStyleBackColor = False
        ' 
        ' multi
        ' 
        multi.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        multi.FlatStyle = FlatStyle.Popup
        multi.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point)
        multi.ForeColor = Color.Gainsboro
        multi.Location = New Point(216, 197)
        multi.Name = "multi"
        multi.Size = New Size(62, 51)
        multi.TabIndex = 14
        multi.Text = "x"
        multi.UseVisualStyleBackColor = False
        ' 
        ' subs
        ' 
        subs.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        subs.FlatStyle = FlatStyle.Popup
        subs.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point)
        subs.ForeColor = Color.Gainsboro
        subs.Location = New Point(216, 254)
        subs.Name = "subs"
        subs.Size = New Size(62, 51)
        subs.TabIndex = 15
        subs.Text = "-"
        subs.UseVisualStyleBackColor = False
        ' 
        ' add
        ' 
        add.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        add.FlatStyle = FlatStyle.Popup
        add.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point)
        add.ForeColor = Color.Gainsboro
        add.Location = New Point(216, 311)
        add.Name = "add"
        add.Size = New Size(62, 108)
        add.TabIndex = 16
        add.Text = "+"
        add.UseVisualStyleBackColor = False
        ' 
        ' deci
        ' 
        deci.BackColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        deci.FlatStyle = FlatStyle.Popup
        deci.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point)
        deci.ForeColor = Color.Gainsboro
        deci.Location = New Point(80, 368)
        deci.Name = "deci"
        deci.Size = New Size(62, 51)
        deci.TabIndex = 17
        deci.Text = "."
        deci.UseVisualStyleBackColor = False
        ' 
        ' equal
        ' 
        equal.BackColor = Color.FromArgb(CByte(212), CByte(94), CByte(4))
        equal.FlatStyle = FlatStyle.Popup
        equal.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point)
        equal.ForeColor = Color.Gainsboro
        equal.Location = New Point(148, 368)
        equal.Name = "equal"
        equal.Size = New Size(62, 51)
        equal.TabIndex = 18
        equal.Text = "="
        equal.UseVisualStyleBackColor = False
        ' 
        ' Del
        ' 
        Del.BackColor = Color.FromArgb(CByte(212), CByte(94), CByte(4))
        Del.FlatStyle = FlatStyle.Popup
        Del.Font = New Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Del.ForeColor = Color.Gainsboro
        Del.Location = New Point(12, 144)
        Del.Name = "Del"
        Del.Size = New Size(62, 48)
        Del.TabIndex = 19
        Del.Text = "C"
        Del.UseVisualStyleBackColor = False
        ' 
        ' CE
        ' 
        CE.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        CE.FlatStyle = FlatStyle.Popup
        CE.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point)
        CE.ForeColor = Color.Gainsboro
        CE.Location = New Point(148, 143)
        CE.Margin = New Padding(0)
        CE.Name = "CE"
        CE.Size = New Size(62, 51)
        CE.TabIndex = 20
        CE.Text = "↢"
        CE.UseVisualStyleBackColor = False
        ' 
        ' nega
        ' 
        nega.BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        nega.FlatStyle = FlatStyle.Popup
        nega.Font = New Font("Microsoft Sans Serif", 8.2F, FontStyle.Regular, GraphicsUnit.Point)
        nega.ForeColor = Color.Gainsboro
        nega.Location = New Point(80, 144)
        nega.Name = "nega"
        nega.Size = New Size(62, 48)
        nega.TabIndex = 21
        nega.Text = "Negative"
        nega.UseVisualStyleBackColor = False
        ' 
        ' landi
        ' 
        landi.AutoSize = True
        landi.Font = New Font("Times New Roman", 17F, FontStyle.Regular, GraphicsUnit.Point)
        landi.ForeColor = SystemColors.ControlDarkDark
        landi.Location = New Point(6, 9)
        landi.Name = "landi"
        landi.Size = New Size(0, 26)
        landi.TabIndex = 22
        ' 
        ' CALC
        ' 
        AutoScaleDimensions = New SizeF(9F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(15))
        ClientSize = New Size(290, 435)
        Controls.Add(landi)
        Controls.Add(nega)
        Controls.Add(CE)
        Controls.Add(Del)
        Controls.Add(equal)
        Controls.Add(deci)
        Controls.Add(add)
        Controls.Add(subs)
        Controls.Add(multi)
        Controls.Add(div)
        Controls.Add(Button0)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(arith)
        Controls.Add(num1)
        Controls.Add(display)
        Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        Name = "CALC"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CALCULATOR"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents display As TextBox
    Friend WithEvents num1 As TextBox
    Friend WithEvents arith As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents div As Button
    Friend WithEvents multi As Button
    Friend WithEvents subs As Button
    Friend WithEvents add As Button
    Friend WithEvents deci As Button
    Friend WithEvents equal As Button
    Friend WithEvents Del As Button
    Friend WithEvents CE As Button
    Friend WithEvents nega As Button
    Friend WithEvents landi As Label
End Class
