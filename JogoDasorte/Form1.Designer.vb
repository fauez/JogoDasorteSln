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
        Dim BtnSair As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Num1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Num2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Num3 = New System.Windows.Forms.Label()
        Me.BtbPlayer = New System.Windows.Forms.Button()
        Me.ImageResult = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        BtnSair = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.ImageResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSair
        '
        BtnSair.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BtnSair.Image = CType(resources.GetObject("BtnSair.Image"), System.Drawing.Image)
        BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        BtnSair.Location = New System.Drawing.Point(704, 403)
        BtnSair.Name = "BtnSair"
        BtnSair.Size = New System.Drawing.Size(71, 35)
        BtnSair.TabIndex = 4
        BtnSair.Text = "Sair"
        BtnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        BtnSair.UseVisualStyleBackColor = True
        AddHandler BtnSair.Click, AddressOf Me.Button2_Click
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Num1)
        Me.Panel1.Location = New System.Drawing.Point(200, 141)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 100)
        Me.Panel1.TabIndex = 1
        '
        'Num1
        '
        Me.Num1.AutoSize = True
        Me.Num1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num1.ForeColor = System.Drawing.Color.Black
        Me.Num1.Location = New System.Drawing.Point(32, 28)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(28, 32)
        Me.Num1.TabIndex = 0
        Me.Num1.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Num2)
        Me.Panel3.Location = New System.Drawing.Point(350, 141)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(100, 100)
        Me.Panel3.TabIndex = 2
        '
        'Num2
        '
        Me.Num2.AutoSize = True
        Me.Num2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num2.ForeColor = System.Drawing.Color.Black
        Me.Num2.Location = New System.Drawing.Point(26, 28)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(28, 32)
        Me.Num2.TabIndex = 0
        Me.Num2.Text = "0"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Num3)
        Me.Panel4.Location = New System.Drawing.Point(500, 141)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(100, 100)
        Me.Panel4.TabIndex = 2
        '
        'Num3
        '
        Me.Num3.AutoSize = True
        Me.Num3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num3.ForeColor = System.Drawing.Color.Black
        Me.Num3.Location = New System.Drawing.Point(32, 28)
        Me.Num3.Name = "Num3"
        Me.Num3.Size = New System.Drawing.Size(28, 32)
        Me.Num3.TabIndex = 0
        Me.Num3.Text = "0"
        '
        'BtbPlayer
        '
        Me.BtbPlayer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtbPlayer.Image = CType(resources.GetObject("BtbPlayer.Image"), System.Drawing.Image)
        Me.BtbPlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtbPlayer.Location = New System.Drawing.Point(50, 350)
        Me.BtbPlayer.Name = "BtbPlayer"
        Me.BtbPlayer.Size = New System.Drawing.Size(73, 31)
        Me.BtbPlayer.TabIndex = 3
        Me.BtbPlayer.Text = "Jogar"
        Me.BtbPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtbPlayer.UseVisualStyleBackColor = True
        '
        'ImageResult
        '
        Me.ImageResult.Location = New System.Drawing.Point(226, 277)
        Me.ImageResult.Name = "ImageResult"
        Me.ImageResult.Size = New System.Drawing.Size(330, 130)
        Me.ImageResult.TabIndex = 5
        Me.ImageResult.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(338, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ImageResult)
        Me.Controls.Add(BtnSair)
        Me.Controls.Add(Me.BtbPlayer)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Jogo da Sorte"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.ImageResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Num1 As Label
    Friend WithEvents Num2 As Label
    Friend WithEvents Num3 As Label
    Friend WithEvents BtbPlayer As Button
    Friend WithEvents ImageResult As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
