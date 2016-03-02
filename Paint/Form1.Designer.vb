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
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.pbCanvas = New System.Windows.Forms.PictureBox()
        Me.tbBrushsize = New System.Windows.Forms.TextBox()
        Me.btnBrush = New System.Windows.Forms.Button()
        Me.btnPencil = New System.Windows.Forms.Button()
        Me.pbRed = New System.Windows.Forms.PictureBox()
        Me.pbBlue = New System.Windows.Forms.PictureBox()
        Me.pbGreen = New System.Windows.Forms.PictureBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.pbColors = New System.Windows.Forms.PictureBox()
        Me.pbPurple = New System.Windows.Forms.PictureBox()
        Me.pbYellow = New System.Windows.Forms.PictureBox()
        Me.pbBlack = New System.Windows.Forms.PictureBox()
        Me.btnEraser = New System.Windows.Forms.Button()
        Me.pbCC = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbBrushsize = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cbRadius = New System.Windows.Forms.ComboBox()
        Me.cbRotation = New System.Windows.Forms.ComboBox()
        Me.btnCanvasColor = New System.Windows.Forms.Button()
        Me.lbRotation = New System.Windows.Forms.Label()
        Me.lbSize = New System.Windows.Forms.Label()
        Me.btnTriangle = New System.Windows.Forms.Button()
        Me.btnRectangle = New System.Windows.Forms.Button()
        Me.btnPentagon = New System.Windows.Forms.Button()
        Me.btnHexagon = New System.Windows.Forms.Button()
        Me.btnHeptagon = New System.Windows.Forms.Button()
        Me.btnOctagon = New System.Windows.Forms.Button()
        Me.btnNonagon = New System.Windows.Forms.Button()
        Me.btnDecagon = New System.Windows.Forms.Button()
        Me.btnLineP = New System.Windows.Forms.Button()
        Me.btnFillP = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.pbCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbColors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPurple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbYellow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBlack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(4, 514)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(23, 13)
        Me.lblX.TabIndex = 0
        Me.lblX.Text = "X ="
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(4, 536)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(23, 13)
        Me.lblY.TabIndex = 1
        Me.lblY.Text = "Y ="
        '
        'pbCanvas
        '
        Me.pbCanvas.BackColor = System.Drawing.Color.White
        Me.pbCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbCanvas.Cursor = System.Windows.Forms.Cursors.Cross
        Me.pbCanvas.Location = New System.Drawing.Point(72, 73)
        Me.pbCanvas.Name = "pbCanvas"
        Me.pbCanvas.Size = New System.Drawing.Size(742, 501)
        Me.pbCanvas.TabIndex = 2
        Me.pbCanvas.TabStop = False
        '
        'tbBrushsize
        '
        Me.tbBrushsize.Location = New System.Drawing.Point(7, 91)
        Me.tbBrushsize.Name = "tbBrushsize"
        Me.tbBrushsize.Size = New System.Drawing.Size(50, 20)
        Me.tbBrushsize.TabIndex = 3
        '
        'btnBrush
        '
        Me.btnBrush.BackgroundImage = CType(resources.GetObject("btnBrush.BackgroundImage"), System.Drawing.Image)
        Me.btnBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBrush.Location = New System.Drawing.Point(10, 26)
        Me.btnBrush.Name = "btnBrush"
        Me.btnBrush.Size = New System.Drawing.Size(32, 35)
        Me.btnBrush.TabIndex = 4
        Me.btnBrush.UseVisualStyleBackColor = True
        '
        'btnPencil
        '
        Me.btnPencil.BackgroundImage = CType(resources.GetObject("btnPencil.BackgroundImage"), System.Drawing.Image)
        Me.btnPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPencil.Location = New System.Drawing.Point(47, 26)
        Me.btnPencil.Name = "btnPencil"
        Me.btnPencil.Size = New System.Drawing.Size(32, 35)
        Me.btnPencil.TabIndex = 5
        Me.btnPencil.UseVisualStyleBackColor = True
        '
        'pbRed
        '
        Me.pbRed.BackColor = System.Drawing.Color.Red
        Me.pbRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbRed.Location = New System.Drawing.Point(288, 41)
        Me.pbRed.Name = "pbRed"
        Me.pbRed.Size = New System.Drawing.Size(20, 21)
        Me.pbRed.TabIndex = 11
        Me.pbRed.TabStop = False
        '
        'pbBlue
        '
        Me.pbBlue.BackColor = System.Drawing.Color.Blue
        Me.pbBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbBlue.Location = New System.Drawing.Point(313, 41)
        Me.pbBlue.Name = "pbBlue"
        Me.pbBlue.Size = New System.Drawing.Size(20, 21)
        Me.pbBlue.TabIndex = 12
        Me.pbBlue.TabStop = False
        '
        'pbGreen
        '
        Me.pbGreen.BackColor = System.Drawing.Color.Green
        Me.pbGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbGreen.Location = New System.Drawing.Point(288, 14)
        Me.pbGreen.Name = "pbGreen"
        Me.pbGreen.Size = New System.Drawing.Size(20, 21)
        Me.pbGreen.TabIndex = 13
        Me.pbGreen.TabStop = False
        '
        'pbColors
        '
        Me.pbColors.BackColor = System.Drawing.SystemColors.HotTrack
        Me.pbColors.BackgroundImage = CType(resources.GetObject("pbColors.BackgroundImage"), System.Drawing.Image)
        Me.pbColors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbColors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbColors.Location = New System.Drawing.Point(359, 13)
        Me.pbColors.Name = "pbColors"
        Me.pbColors.Size = New System.Drawing.Size(53, 49)
        Me.pbColors.TabIndex = 14
        Me.pbColors.TabStop = False
        '
        'pbPurple
        '
        Me.pbPurple.BackColor = System.Drawing.Color.Purple
        Me.pbPurple.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbPurple.Location = New System.Drawing.Point(338, 41)
        Me.pbPurple.Name = "pbPurple"
        Me.pbPurple.Size = New System.Drawing.Size(20, 21)
        Me.pbPurple.TabIndex = 15
        Me.pbPurple.TabStop = False
        '
        'pbYellow
        '
        Me.pbYellow.BackColor = System.Drawing.Color.Yellow
        Me.pbYellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbYellow.Location = New System.Drawing.Point(313, 13)
        Me.pbYellow.Name = "pbYellow"
        Me.pbYellow.Size = New System.Drawing.Size(20, 21)
        Me.pbYellow.TabIndex = 16
        Me.pbYellow.TabStop = False
        '
        'pbBlack
        '
        Me.pbBlack.BackColor = System.Drawing.Color.Black
        Me.pbBlack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbBlack.Location = New System.Drawing.Point(338, 13)
        Me.pbBlack.Name = "pbBlack"
        Me.pbBlack.Size = New System.Drawing.Size(20, 21)
        Me.pbBlack.TabIndex = 17
        Me.pbBlack.TabStop = False
        '
        'btnEraser
        '
        Me.btnEraser.BackColor = System.Drawing.Color.White
        Me.btnEraser.BackgroundImage = CType(resources.GetObject("btnEraser.BackgroundImage"), System.Drawing.Image)
        Me.btnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEraser.Location = New System.Drawing.Point(85, 26)
        Me.btnEraser.Name = "btnEraser"
        Me.btnEraser.Size = New System.Drawing.Size(32, 35)
        Me.btnEraser.TabIndex = 18
        Me.btnEraser.UseVisualStyleBackColor = False
        '
        'pbCC
        '
        Me.pbCC.BackColor = System.Drawing.Color.Black
        Me.pbCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbCC.Location = New System.Drawing.Point(214, 28)
        Me.pbCC.Name = "pbCC"
        Me.pbCC.Size = New System.Drawing.Size(66, 33)
        Me.pbCC.TabIndex = 19
        Me.pbCC.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Current Color"
        '
        'lbBrushsize
        '
        Me.lbBrushsize.AutoSize = True
        Me.lbBrushsize.Location = New System.Drawing.Point(4, 74)
        Me.lbBrushsize.Name = "lbBrushsize"
        Me.lbBrushsize.Size = New System.Drawing.Size(57, 13)
        Me.lbBrushsize.TabIndex = 21
        Me.lbBrushsize.Text = "Brush Size"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(814, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.LoadToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cbRadius
        '
        Me.cbRadius.FormattingEnabled = True
        Me.cbRadius.Items.AddRange(New Object() {"10", "15", "20", "25", "50", "100"})
        Me.cbRadius.Location = New System.Drawing.Point(597, 50)
        Me.cbRadius.Margin = New System.Windows.Forms.Padding(2)
        Me.cbRadius.Name = "cbRadius"
        Me.cbRadius.Size = New System.Drawing.Size(49, 21)
        Me.cbRadius.TabIndex = 25
        '
        'cbRotation
        '
        Me.cbRotation.FormattingEnabled = True
        Me.cbRotation.Items.AddRange(New Object() {"45", "90", "135", "180", "225", "270", "315", "360"})
        Me.cbRotation.Location = New System.Drawing.Point(596, 17)
        Me.cbRotation.Margin = New System.Windows.Forms.Padding(2)
        Me.cbRotation.Name = "cbRotation"
        Me.cbRotation.Size = New System.Drawing.Size(49, 21)
        Me.cbRotation.TabIndex = 27
        '
        'btnCanvasColor
        '
        Me.btnCanvasColor.Location = New System.Drawing.Point(152, 25)
        Me.btnCanvasColor.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCanvasColor.Name = "btnCanvasColor"
        Me.btnCanvasColor.Size = New System.Drawing.Size(46, 36)
        Me.btnCanvasColor.TabIndex = 29
        Me.btnCanvasColor.Text = "Set BG Color"
        Me.btnCanvasColor.UseVisualStyleBackColor = True
        '
        'lbRotation
        '
        Me.lbRotation.AutoSize = True
        Me.lbRotation.Location = New System.Drawing.Point(577, 0)
        Me.lbRotation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbRotation.Name = "lbRotation"
        Me.lbRotation.Size = New System.Drawing.Size(88, 13)
        Me.lbRotation.TabIndex = 43
        Me.lbRotation.Text = "Polygon Rotation"
        '
        'lbSize
        '
        Me.lbSize.AutoSize = True
        Me.lbSize.Location = New System.Drawing.Point(588, 34)
        Me.lbSize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSize.Name = "lbSize"
        Me.lbSize.Size = New System.Drawing.Size(68, 13)
        Me.lbSize.TabIndex = 44
        Me.lbSize.Text = "Polygon Size"
        '
        'btnTriangle
        '
        Me.btnTriangle.BackgroundImage = CType(resources.GetObject("btnTriangle.BackgroundImage"), System.Drawing.Image)
        Me.btnTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTriangle.Location = New System.Drawing.Point(442, 5)
        Me.btnTriangle.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTriangle.Name = "btnTriangle"
        Me.btnTriangle.Size = New System.Drawing.Size(29, 31)
        Me.btnTriangle.TabIndex = 45
        Me.btnTriangle.UseVisualStyleBackColor = True
        '
        'btnRectangle
        '
        Me.btnRectangle.BackgroundImage = CType(resources.GetObject("btnRectangle.BackgroundImage"), System.Drawing.Image)
        Me.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRectangle.Location = New System.Drawing.Point(476, 5)
        Me.btnRectangle.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRectangle.Name = "btnRectangle"
        Me.btnRectangle.Size = New System.Drawing.Size(29, 31)
        Me.btnRectangle.TabIndex = 46
        Me.btnRectangle.UseVisualStyleBackColor = True
        '
        'btnPentagon
        '
        Me.btnPentagon.BackColor = System.Drawing.Color.White
        Me.btnPentagon.BackgroundImage = CType(resources.GetObject("btnPentagon.BackgroundImage"), System.Drawing.Image)
        Me.btnPentagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPentagon.Location = New System.Drawing.Point(509, 5)
        Me.btnPentagon.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPentagon.Name = "btnPentagon"
        Me.btnPentagon.Size = New System.Drawing.Size(29, 31)
        Me.btnPentagon.TabIndex = 47
        Me.btnPentagon.UseVisualStyleBackColor = False
        '
        'btnHexagon
        '
        Me.btnHexagon.BackgroundImage = CType(resources.GetObject("btnHexagon.BackgroundImage"), System.Drawing.Image)
        Me.btnHexagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHexagon.Location = New System.Drawing.Point(543, 5)
        Me.btnHexagon.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHexagon.Name = "btnHexagon"
        Me.btnHexagon.Size = New System.Drawing.Size(29, 31)
        Me.btnHexagon.TabIndex = 48
        Me.btnHexagon.UseVisualStyleBackColor = True
        '
        'btnHeptagon
        '
        Me.btnHeptagon.BackgroundImage = CType(resources.GetObject("btnHeptagon.BackgroundImage"), System.Drawing.Image)
        Me.btnHeptagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHeptagon.Location = New System.Drawing.Point(442, 39)
        Me.btnHeptagon.Margin = New System.Windows.Forms.Padding(2)
        Me.btnHeptagon.Name = "btnHeptagon"
        Me.btnHeptagon.Size = New System.Drawing.Size(29, 31)
        Me.btnHeptagon.TabIndex = 49
        Me.btnHeptagon.UseVisualStyleBackColor = True
        '
        'btnOctagon
        '
        Me.btnOctagon.BackColor = System.Drawing.Color.White
        Me.btnOctagon.BackgroundImage = CType(resources.GetObject("btnOctagon.BackgroundImage"), System.Drawing.Image)
        Me.btnOctagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOctagon.Location = New System.Drawing.Point(476, 39)
        Me.btnOctagon.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOctagon.Name = "btnOctagon"
        Me.btnOctagon.Size = New System.Drawing.Size(29, 31)
        Me.btnOctagon.TabIndex = 50
        Me.btnOctagon.UseVisualStyleBackColor = False
        '
        'btnNonagon
        '
        Me.btnNonagon.BackgroundImage = CType(resources.GetObject("btnNonagon.BackgroundImage"), System.Drawing.Image)
        Me.btnNonagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNonagon.Location = New System.Drawing.Point(509, 39)
        Me.btnNonagon.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNonagon.Name = "btnNonagon"
        Me.btnNonagon.Size = New System.Drawing.Size(29, 31)
        Me.btnNonagon.TabIndex = 51
        Me.btnNonagon.UseVisualStyleBackColor = True
        '
        'btnDecagon
        '
        Me.btnDecagon.BackgroundImage = CType(resources.GetObject("btnDecagon.BackgroundImage"), System.Drawing.Image)
        Me.btnDecagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDecagon.Location = New System.Drawing.Point(543, 39)
        Me.btnDecagon.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDecagon.Name = "btnDecagon"
        Me.btnDecagon.Size = New System.Drawing.Size(29, 31)
        Me.btnDecagon.TabIndex = 52
        Me.btnDecagon.UseVisualStyleBackColor = True
        '
        'btnLineP
        '
        Me.btnLineP.Location = New System.Drawing.Point(660, 17)
        Me.btnLineP.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLineP.Name = "btnLineP"
        Me.btnLineP.Size = New System.Drawing.Size(35, 19)
        Me.btnLineP.TabIndex = 53
        Me.btnLineP.Text = "Line"
        Me.btnLineP.UseVisualStyleBackColor = True
        '
        'btnFillP
        '
        Me.btnFillP.Location = New System.Drawing.Point(660, 38)
        Me.btnFillP.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFillP.Name = "btnFillP"
        Me.btnFillP.Size = New System.Drawing.Size(35, 19)
        Me.btnFillP.TabIndex = 54
        Me.btnFillP.Text = "Fill"
        Me.btnFillP.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(0, 557)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 17)
        Me.CheckBox1.TabIndex = 55
        Me.CheckBox1.Text = "Hide X  Y"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 576)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnFillP)
        Me.Controls.Add(Me.btnLineP)
        Me.Controls.Add(Me.btnDecagon)
        Me.Controls.Add(Me.btnNonagon)
        Me.Controls.Add(Me.btnOctagon)
        Me.Controls.Add(Me.btnHeptagon)
        Me.Controls.Add(Me.btnHexagon)
        Me.Controls.Add(Me.btnPentagon)
        Me.Controls.Add(Me.btnRectangle)
        Me.Controls.Add(Me.btnTriangle)
        Me.Controls.Add(Me.lbSize)
        Me.Controls.Add(Me.lbRotation)
        Me.Controls.Add(Me.btnCanvasColor)
        Me.Controls.Add(Me.cbRotation)
        Me.Controls.Add(Me.cbRadius)
        Me.Controls.Add(Me.lbBrushsize)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbCC)
        Me.Controls.Add(Me.btnEraser)
        Me.Controls.Add(Me.pbBlack)
        Me.Controls.Add(Me.pbYellow)
        Me.Controls.Add(Me.pbPurple)
        Me.Controls.Add(Me.pbColors)
        Me.Controls.Add(Me.pbGreen)
        Me.Controls.Add(Me.pbBlue)
        Me.Controls.Add(Me.pbRed)
        Me.Controls.Add(Me.btnPencil)
        Me.Controls.Add(Me.btnBrush)
        Me.Controls.Add(Me.tbBrushsize)
        Me.Controls.Add(Me.pbCanvas)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbColors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPurple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbYellow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBlack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents pbCanvas As System.Windows.Forms.PictureBox
    Friend WithEvents tbBrushsize As System.Windows.Forms.TextBox
    Friend WithEvents btnBrush As System.Windows.Forms.Button
    Friend WithEvents btnPencil As System.Windows.Forms.Button
    Friend WithEvents pbRed As System.Windows.Forms.PictureBox
    Friend WithEvents pbBlue As System.Windows.Forms.PictureBox
    Friend WithEvents pbGreen As System.Windows.Forms.PictureBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents pbColors As System.Windows.Forms.PictureBox
    Friend WithEvents pbPurple As System.Windows.Forms.PictureBox
    Friend WithEvents pbYellow As System.Windows.Forms.PictureBox
    Friend WithEvents pbBlack As System.Windows.Forms.PictureBox
    Friend WithEvents btnEraser As System.Windows.Forms.Button
    Friend WithEvents pbCC As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbBrushsize As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cbRadius As System.Windows.Forms.ComboBox
    Friend WithEvents cbRotation As System.Windows.Forms.ComboBox
    Friend WithEvents btnCanvasColor As System.Windows.Forms.Button
    Friend WithEvents lbRotation As System.Windows.Forms.Label
    Friend WithEvents lbSize As System.Windows.Forms.Label
    Friend WithEvents btnTriangle As System.Windows.Forms.Button
    Friend WithEvents btnRectangle As System.Windows.Forms.Button
    Friend WithEvents btnPentagon As System.Windows.Forms.Button
    Friend WithEvents btnHexagon As System.Windows.Forms.Button
    Friend WithEvents btnHeptagon As System.Windows.Forms.Button
    Friend WithEvents btnOctagon As System.Windows.Forms.Button
    Friend WithEvents btnNonagon As System.Windows.Forms.Button
    Friend WithEvents btnDecagon As System.Windows.Forms.Button
    Friend WithEvents btnLineP As System.Windows.Forms.Button
    Friend WithEvents btnFillP As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
