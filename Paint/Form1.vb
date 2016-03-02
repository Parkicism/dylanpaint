Public Class Form1
    Dim mousePos As Point
    Dim DrawBitmap As Bitmap
    Dim g As Graphics = Me.CreateGraphics
    Dim drawOn As Boolean = False

    Dim brushSize As Integer = 10   'sets the default brush size to 10

    Dim triangle As Boolean = False 'booleans for the polygon
    Dim rectangle As Boolean = False
    Dim pentagon As Boolean = False
    Dim hexagon As Boolean = False
    Dim heptagon As Boolean = False
    Dim octagon As Boolean = False
    Dim nonagon As Boolean = False
    Dim decagon As Boolean = False


    Dim eraser As Boolean = False 'boolean for eraser  '
    Dim erasersize As Integer = 15

    Dim fill As Boolean = False 'boolean to see whether polygon fill is ture or false

    Dim smootherlocation As New Point(0, 0) 'a point for smoothing line

    Dim Brush As Boolean = False    'booleans for bursh and pencil
    Dim Pencil As Boolean = False

    Dim penColor As New Pen(Color.Black) 'declares the pencolor variable with a default color of black
    Dim brushColor As New SolidBrush(Color.Black) 'declares the brush color variable with a default color of black

    Dim colorPick As Color = Color.Black



    Private Sub pbCanvas_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbCanvas.MouseMove



        mousePos.X = e.X 'tracks the x position of the mouse cursor
        mousePos.Y = e.Y 'tracks the y position of the mouse cursor
        lblX.Text = "X = " & mousePos.X 'displays a text representing the x-position of the mouse cursor
        lblY.Text = "Y = " & mousePos.Y 'displays a text representing the y-position of the mouse cursor

        Dim eraserColor As New SolidBrush(pbCanvas.BackColor)

        Dim fixedDrawPoint As Point 'this is to make the brush draw exactly on the middle of the cursor
        fixedDrawPoint.X = e.X - (brushSize / 2)
        fixedDrawPoint.Y = e.Y - (brushSize / 2)

        Dim localBrush As New System.Drawing.Pen(brushColor, brushSize) 'variable to fit in the drawline code


        If drawOn = True Then

            If Brush = True Then

                g.FillEllipse(brushColor, fixedDrawPoint.X, fixedDrawPoint.Y, brushSize, brushSize) 'draws a filled circle
                pbCanvas.Image = DrawBitmap

                If Not smootherlocation = New Point(0, 0) Then
                    g.DrawLine(localBrush, smootherlocation.X, smootherlocation.Y, e.X, e.Y)
                End If

                smootherlocation = New Point(e.X, e.Y)

            End If

            If Pencil = True Then

                g.FillEllipse(brushColor, fixedDrawPoint.X, fixedDrawPoint.Y, brushSize, brushSize) 'draws a thin line
                pbCanvas.Image = DrawBitmap

                If Not smootherlocation = New Point(0, 0) Then
                    g.DrawLine(localBrush, smootherlocation.X, smootherlocation.Y, e.X, e.Y)
                End If

                smootherlocation = New Point(e.X, e.Y)
            End If

            If eraser = True Then
                g.FillEllipse(eraserColor, fixedDrawPoint.X, fixedDrawPoint.Y, brushSize, brushSize)    'eraser tool
                pbCanvas.Image = DrawBitmap

                If Not smootherlocation = New Point(0, 0) Then
                    g.DrawLine(localBrush, smootherlocation.X, smootherlocation.Y, e.X, e.Y)
                End If

                smootherlocation = New Point(e.X, e.Y)
            End If

            If triangle = True Then

                If cbRadius.Text = Nothing Then 'If there is nothing in cbRadius, the size will automatically convert to 15 instead of crashing
                    cbRadius.Text = "15"
                End If

                If cbRotation.Text = Nothing Then   'if there is nothing in cbRotation, the rotation will automatically be 0 to prevent crash
                    cbRotation.Text = "0"
                End If

                Dim pointList As New List(Of Point)
                Dim SideNumber As Double = 3               'set the number of sides on the polygon relative to the combobox text
                Dim radius As Double = CInt(cbRadius.Text)                     'set the radius of the figurative circle around the polygon, or the radius to each angle. 
                Dim InternalAngle As Double = (360 / SideNumber) * (Math.PI / 180)   'splits the figurative circle into segments of degrees based on the amount of sides 
                Dim rotation As Double = CInt(cbRotation.Text) * (Math.PI / 180)


                For PointLoop As Integer = 0 To SideNumber - 1

                    Dim xPointVal As Integer
                    Dim yPointVal As Integer

                    xPointVal = e.X + CInt(radius * Math.Cos(InternalAngle * PointLoop + rotation))        'defines the point in which each point will be 
                    yPointVal = e.Y + CInt(radius * Math.Sin(InternalAngle * PointLoop + rotation))
                    pointList.Add(New Point(xPointVal, yPointVal))
                Next

                If fill = True Then 'if fill is true then it fills inside the polygon with the brushcolor
                    g.FillPolygon(brushColor, pointList.ToArray) ' when the points are set the polygon is drawn between them then it is fill
                    pointList.Clear()
                Else
                    g.DrawPolygon(penColor, pointList.ToArray) 'if fill is false then there will only be an outline of polygon
                    pointList.Clear()
                End If
                pbCanvas.Image = DrawBitmap
            End If

            If rectangle = True Then

                If cbRadius.Text = Nothing Then
                    cbRadius.Text = "15"
                End If

                If cbRotation.Text = Nothing Then
                    cbRotation.Text = "0"
                End If

                Dim pointList As New List(Of Point)
                Dim SideNumber As Double = 4               'set the number of sides on the polygon relative to the combobox text
                Dim radius As Double = CInt(cbRadius.Text)                     'set the radius of the figurative circle around the polygon, or the radius to each angle. 
                Dim InternalAngle As Double = (360 / SideNumber) * (Math.PI / 180)   'splits the figurative circle into segments of degrees based on the amount of sides 
                Dim rotation As Double = CInt(cbRotation.Text) * (Math.PI / 180)


                For PointLoop As Integer = 0 To SideNumber - 1

                    Dim xPointVal As Integer
                    Dim yPointVal As Integer

                    xPointVal = e.X + CInt(radius * Math.Cos(InternalAngle * PointLoop + rotation))        'defines the point in which each point will be 
                    yPointVal = e.Y + CInt(radius * Math.Sin(InternalAngle * PointLoop + rotation))
                    pointList.Add(New Point(xPointVal, yPointVal))
                Next

                If fill = True Then
                    g.FillPolygon(brushColor, pointList.ToArray) ' when the points are set the polygon is drawn between them then it is fill
                    pointList.Clear()
                Else
                    g.DrawPolygon(penColor, pointList.ToArray)
                    pointList.Clear()
                End If
                pbCanvas.Image = DrawBitmap
            End If

            If pentagon = True Then

                If cbRadius.Text = Nothing Then
                    cbRadius.Text = "15"
                End If

                If cbRotation.Text = Nothing Then
                    cbRotation.Text = "0"
                End If

                Dim pointList As New List(Of Point)
                Dim SideNumber As Double = 5               'set the number of sides on the polygon relative to the combobox text
                Dim radius As Double = CInt(cbRadius.Text)                     'set the radius of the figurative circle around the polygon, or the radius to each angle. 
                Dim InternalAngle As Double = (360 / SideNumber) * (Math.PI / 180)   'splits the figurative circle into segments of degrees based on the amount of sides 
                Dim rotation As Double = CInt(cbRotation.Text) * (Math.PI / 180)


                For PointLoop As Integer = 0 To SideNumber - 1

                    Dim xPointVal As Integer
                    Dim yPointVal As Integer

                    xPointVal = e.X + CInt(radius * Math.Cos(InternalAngle * PointLoop + rotation))        'defines the point in which each point will be 
                    yPointVal = e.Y + CInt(radius * Math.Sin(InternalAngle * PointLoop + rotation))
                    pointList.Add(New Point(xPointVal, yPointVal))
                Next

                If fill = True Then
                    g.FillPolygon(brushColor, pointList.ToArray) ' when the points are set the polygon is drawn between them then it is fill
                    pointList.Clear()
                Else
                    g.DrawPolygon(penColor, pointList.ToArray)
                    pointList.Clear()
                End If
                pbCanvas.Image = DrawBitmap
            End If

            If hexagon = True Then

                If cbRadius.Text = Nothing Then
                    cbRadius.Text = "15"
                End If

                If cbRotation.Text = Nothing Then
                    cbRotation.Text = "0"
                End If

                Dim pointList As New List(Of Point)
                Dim SideNumber As Double = 6               'set the number of sides on the polygon relative to the combobox text
                Dim radius As Double = CInt(cbRadius.Text)                     'set the radius of the figurative circle around the polygon, or the radius to each angle. 
                Dim InternalAngle As Double = (360 / SideNumber) * (Math.PI / 180)   'splits the figurative circle into segments of degrees based on the amount of sides 
                Dim rotation As Double = CInt(cbRotation.Text) * (Math.PI / 180)


                For PointLoop As Integer = 0 To SideNumber - 1

                    Dim xPointVal As Integer
                    Dim yPointVal As Integer

                    xPointVal = e.X + CInt(radius * Math.Cos(InternalAngle * PointLoop + rotation))        'defines the point in which each point will be 
                    yPointVal = e.Y + CInt(radius * Math.Sin(InternalAngle * PointLoop + rotation))
                    pointList.Add(New Point(xPointVal, yPointVal))
                Next

                If fill = True Then
                    g.FillPolygon(brushColor, pointList.ToArray) ' when the points are set the polygon is drawn between them then it is fill
                    pointList.Clear()
                Else
                    g.DrawPolygon(penColor, pointList.ToArray)
                    pointList.Clear()
                End If
                pbCanvas.Image = DrawBitmap
            End If

            If heptagon = True Then

                If cbRadius.Text = Nothing Then
                    cbRadius.Text = "15"
                End If

                If cbRotation.Text = Nothing Then
                    cbRotation.Text = "0"
                End If

                Dim pointList As New List(Of Point)
                Dim SideNumber As Double = 7                'set the number of sides on the polygon relative to the combobox text
                Dim radius As Double = CInt(cbRadius.Text)                     'set the radius of the figurative circle around the polygon, or the radius to each angle. 
                Dim InternalAngle As Double = (360 / SideNumber) * (Math.PI / 180)   'splits the figurative circle into segments of degrees based on the amount of sides 
                Dim rotation As Double = CInt(cbRotation.Text) * (Math.PI / 180)


                For PointLoop As Integer = 0 To SideNumber - 1

                    Dim xPointVal As Integer
                    Dim yPointVal As Integer

                    xPointVal = e.X + CInt(radius * Math.Cos(InternalAngle * PointLoop + rotation))        'defines the point in which each point will be 
                    yPointVal = e.Y + CInt(radius * Math.Sin(InternalAngle * PointLoop + rotation))
                    pointList.Add(New Point(xPointVal, yPointVal))
                Next

                If fill = True Then
                    g.FillPolygon(brushColor, pointList.ToArray) ' when the points are set the polygon is drawn between them then it is fill
                    pointList.Clear()
                Else
                    g.DrawPolygon(penColor, pointList.ToArray)
                    pointList.Clear()
                End If
                pbCanvas.Image = DrawBitmap
            End If

            If octagon = True Then

                If cbRadius.Text = Nothing Then
                    cbRadius.Text = "15"
                End If

                If cbRotation.Text = Nothing Then
                    cbRotation.Text = "0"
                End If

                Dim pointList As New List(Of Point)
                Dim SideNumber As Double = 8                'set the number of sides on the polygon relative to the combobox text
                Dim radius As Double = CInt(cbRadius.Text)                     'set the radius of the figurative circle around the polygon, or the radius to each angle. 
                Dim InternalAngle As Double = (360 / SideNumber) * (Math.PI / 180)   'splits the figurative circle into segments of degrees based on the amount of sides 
                Dim rotation As Double = CInt(cbRotation.Text) * (Math.PI / 180)

                For PointLoop As Integer = 0 To SideNumber - 1

                    Dim xPointVal As Integer
                    Dim yPointVal As Integer

                    xPointVal = e.X + CInt(radius * Math.Cos(InternalAngle * PointLoop + rotation))        'defines the point in which each point will be 
                    yPointVal = e.Y + CInt(radius * Math.Sin(InternalAngle * PointLoop + rotation))
                    pointList.Add(New Point(xPointVal, yPointVal))
                Next

                If fill = True Then
                    g.FillPolygon(brushColor, pointList.ToArray) ' when the points are set the polygon is drawn between them then it is fill
                    pointList.Clear()
                Else
                    g.DrawPolygon(penColor, pointList.ToArray)
                    pointList.Clear()
                End If
                pbCanvas.Image = DrawBitmap
            End If

            If nonagon = True Then

                If cbRadius.Text = Nothing Then
                    cbRadius.Text = "15"
                End If

                If cbRotation.Text = Nothing Then
                    cbRotation.Text = "0"
                End If

                Dim pointList As New List(Of Point)
                Dim SideNumber As Double = 9               'set the number of sides on the polygon relative to the combobox text
                Dim radius As Double = CInt(cbRadius.Text)                     'set the radius of the figurative circle around the polygon, or the radius to each angle. 
                Dim InternalAngle As Double = (360 / SideNumber) * (Math.PI / 180)   'splits the figurative circle into segments of degrees based on the amount of sides 
                Dim rotation As Double = CInt(cbRotation.Text) * (Math.PI / 180)


                For PointLoop As Integer = 0 To SideNumber - 1

                    Dim xPointVal As Integer
                    Dim yPointVal As Integer

                    xPointVal = e.X + CInt(radius * Math.Cos(InternalAngle * PointLoop + rotation))        'defines the point in which each point will be 
                    yPointVal = e.Y + CInt(radius * Math.Sin(InternalAngle * PointLoop + rotation))
                    pointList.Add(New Point(xPointVal, yPointVal))
                Next

                If fill = True Then
                    g.FillPolygon(brushColor, pointList.ToArray) ' when the points are set the polygon is drawn between them then it is fill
                    pointList.Clear()
                Else
                    g.DrawPolygon(penColor, pointList.ToArray)
                    pointList.Clear()
                End If
                pbCanvas.Image = DrawBitmap
            End If

            If decagon = True Then

                If cbRadius.Text = Nothing Then
                    cbRadius.Text = "15"
                End If

                If cbRotation.Text = Nothing Then
                    cbRotation.Text = "0"
                End If

                Dim pointList As New List(Of Point)
                Dim SideNumber As Double = 10                'set the number of sides on the polygon relative to the combobox text
                Dim radius As Double = CInt(cbRadius.Text)                     'set the radius of the figurative circle around the polygon, or the radius to each angle. 
                Dim InternalAngle As Double = (360 / SideNumber) * (Math.PI / 180)   'splits the figurative circle into segments of degrees based on the amount of sides 
                Dim rotation As Double = CInt(cbRotation.Text) * (Math.PI / 180)


                For PointLoop As Integer = 0 To SideNumber - 1

                    Dim xPointVal As Integer
                    Dim yPointVal As Integer

                    xPointVal = e.X + CInt(radius * Math.Cos(InternalAngle * PointLoop + rotation))        'defines the point in which each point will be 
                    yPointVal = e.Y + CInt(radius * Math.Sin(InternalAngle * PointLoop + rotation))
                    pointList.Add(New Point(xPointVal, yPointVal))
                Next



                If fill = True Then
                    g.FillPolygon(brushColor, pointList.ToArray) ' when the points are set the polygon is drawn between them then it is fill
                    pointList.Clear()
                Else
                    g.DrawPolygon(penColor, pointList.ToArray)
                    pointList.Clear()
                End If
                pbCanvas.Image = DrawBitmap
            End If

        End If

       





    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DrawBitmap = New Bitmap(pbCanvas.Width, pbCanvas.Height)
        g = Graphics.FromImage(DrawBitmap)
        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality 'makes line a lot smoother and high quality

        For x As Integer = 0 To pbCanvas.Width - 1  'makes every single pixel on pbcanvas to white (basically clear)
            For y As Integer = 0 To pbCanvas.Height - 1
                DrawBitmap.SetPixel(x, y, Color.White)
            Next
        Next

        Brush = True 'as soon as the form loads, brush = true

    End Sub


    Private Sub pbCanvas_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbCanvas.MouseDown

        drawOn = True

    End Sub

    Private Sub pbCanvas_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbCanvas.MouseUp

        drawOn = False
        smootherlocation = New Point(0, 0)

    End Sub

    Private Sub tbBrushsize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBrushsize.TextChanged

        Try
            brushSize = Double.Parse(tbBrushsize.Text)
        Catch ex As Exception
            MessageBox.Show("invalid input")
        End Try

    End Sub


    Private Sub btnBrush_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrush.Click

        Brush = True    'if brush is true, all other boolean tools are set to false
        Pencil = False
        eraser = False

        If brushColor.Color = pbCanvas.BackColor Then
            brushColor.Color = Color.Black
            pbCC.BackColor = Color.Black
        Else
            brushColor.Color = brushColor.Color
        End If

        If brushSize = 15 Or brushSize = 1 Then ' if brushsize is the same as eraser or pencil, it changes the size to 15, but if the size is manually inputed, it stays that way
            brushSize = 10
            tbBrushsize.Text = "10"
        Else
            brushSize = brushSize
        End If

        triangle = False
        rectangle = False
        pentagon = False
        hexagon = False
        heptagon = False
        octagon = False
        nonagon = False
        decagon = False

    End Sub

    Private Sub btnPencil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPencil.Click

        Pencil = True
        Brush = False
        eraser = False

        If brushColor.Color = pbCanvas.BackColor Then
            brushColor.Color = Color.Black
            pbCC.BackColor = Color.Black
        Else
            brushColor.Color = brushColor.Color
        End If

        If brushSize = 10 Or 15 Then
            brushSize = 1
            tbBrushsize.Text = "1"
        Else
            brushSize = brushSize
        End If

        triangle = False
        rectangle = False
        pentagon = False
        hexagon = False
        heptagon = False
        octagon = False
        nonagon = False
        decagon = False

    End Sub

    Private Sub pbCanvas_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pbCanvas.MouseClick

        Dim fixedDrawPoint As Point
        fixedDrawPoint.X = e.X - (brushSize / 2)
        fixedDrawPoint.Y = e.Y - (brushSize / 2)

        Dim eraserColor As New SolidBrush(pbCanvas.BackColor)

        If drawOn = True Then

            If Brush = True Then
                g.FillEllipse(brushColor, fixedDrawPoint.X, fixedDrawPoint.Y, brushSize, brushSize)
                pbCanvas.Image = DrawBitmap
            End If

            If Pencil = True Then
                brushSize = 1
                g.FillEllipse(brushColor, fixedDrawPoint.X, fixedDrawPoint.Y, brushSize, brushSize)
                pbCanvas.Image = DrawBitmap
            End If


            If eraser = True Then
                g.FillEllipse(eraserColor, fixedDrawPoint.X, fixedDrawPoint.Y, brushSize, brushSize)
                pbCanvas.Image = DrawBitmap
            End If

        End If

        If triangle = True Then

            If cbRadius.Text = Nothing Then
                cbRadius.Text = "15"
            End If

            If cbRotation.Text = Nothing Then
                cbRotation.Text = "0"
            End If

            Dim pointList As New List(Of Point)
            Dim SideNumber As Double = 3               'set the number of sides on the polygon relative to the combobox text
            Dim radius As Double = CInt(cbRadius.Text)                     'set the radius of the figurative circle around the polygon, or the radius to each angle. 
            Dim InternalAngle As Double = (360 / SideNumber) * (Math.PI / 180)   'splits the figurative circle into segments of degrees based on the amount of sides 
            Dim rotation As Double = CInt(cbRotation.Text) * (Math.PI / 180)


            For PointLoop As Integer = 0 To SideNumber - 1

                Dim xPointVal As Integer
                Dim yPointVal As Integer

                xPointVal = e.X + CInt(radius * Math.Cos(InternalAngle * PointLoop + rotation))        'defines the point in which each point will be 
                yPointVal = e.Y + CInt(radius * Math.Sin(InternalAngle * PointLoop + rotation))
                pointList.Add(New Point(xPointVal, yPointVal))
            Next

            If fill = True Then
                g.FillPolygon(brushColor, pointList.ToArray) ' when the points are set the polygon is drawn between them then it is fill
                pointList.Clear()
            Else
                g.DrawPolygon(penColor, pointList.ToArray)
                pointList.Clear()
            End If
            pbCanvas.Image = DrawBitmap
        End If

        If rectangle = True Then

            If cbRadius.Text = Nothing Then
                cbRadius.Text = "15"
            End If

            If cbRotation.Text = Nothing Then
                cbRotation.Text = "0"
            End If

            Dim pointList As New List(Of Point)
            Dim SideNumber As Double = 4               'set the number of sides on the polygon relative to the combobox text
            Dim radius As Double = CInt(cbRadius.Text)                     'set the radius of the figurative circle around the polygon, or the radius to each angle. 
            Dim InternalAngle As Double = (360 / SideNumber) * (Math.PI / 180)   'splits the figurative circle into segments of degrees based on the amount of sides 
            Dim rotation As Double = CInt(cbRotation.Text) * (Math.PI / 180)


            For PointLoop As Integer = 0 To SideNumber - 1

                Dim xPointVal As Integer
                Dim yPointVal As Integer

                xPointVal = e.X + CInt(radius * Math.Cos(InternalAngle * PointLoop + rotation))        'defines the point in which each point will be 
                yPointVal = e.Y + CInt(radius * Math.Sin(InternalAngle * PointLoop + rotation))
                pointList.Add(New Point(xPointVal, yPointVal))
            Next

            If fill = True Then
                g.FillPolygon(brushColor, pointList.ToArray) ' when the points are set the polygon is drawn between them then it is fill
                pointList.Clear()
            Else
                g.DrawPolygon(penColor, pointList.ToArray)
                pointList.Clear()
            End If
            pbCanvas.Image = DrawBitmap
        End If

        If pentagon = True Then
            If cbRadius.Text = Nothing Then
                cbRadius.Text = "15"
            End If

            If cbRotation.Text = Nothing Then
                cbRotation.Text = "0"
            End If

            Dim pointList As New List(Of Point)
            Dim SideNumber As Double = 5               'set the number of sides on the polygon relative to the combobox text
            Dim radius As Double = CInt(cbRadius.Text)                     'set the radius of the figurative circle around the polygon, or the radius to each angle. 
            Dim InternalAngle As Double = (360 / SideNumber) * (Math.PI / 180)   'splits the figurative circle into segments of degrees based on the amount of sides 
            Dim rotation As Double = CInt(cbRotation.Text) * (Math.PI / 180)


            For PointLoop As Integer = 0 To SideNumber - 1

                Dim xPointVal As Integer
                Dim yPointVal As Integer

                xPointVal = e.X + CInt(radius * Math.Cos(InternalAngle * PointLoop + rotation))        'defines the point in which each point will be 
                yPointVal = e.Y + CInt(radius * Math.Sin(InternalAngle * PointLoop + rotation))
                pointList.Add(New Point(xPointVal, yPointVal))
            Next

            If fill = True Then
                g.FillPolygon(brushColor, pointList.ToArray) ' when the points are set the polygon is drawn between them then it is fill
                pointList.Clear()
            Else
                g.DrawPolygon(penColor, pointList.ToArray)
                pointList.Clear()
            End If
            pbCanvas.Image = DrawBitmap
        End If

        If hexagon = True Then

            If cbRadius.Text = Nothing Then
                cbRadius.Text = "15"
            End If

            If cbRotation.Text = Nothing Then
                cbRotation.Text = "0"
            End If
            Dim pointList As New List(Of Point)
            Dim SideNumber As Double = 6               'set the number of sides on the polygon relative to the combobox text
            Dim radius As Double = CInt(cbRadius.Text)                     'set the radius of the figurative circle around the polygon, or the radius to each angle. 
            Dim InternalAngle As Double = (360 / SideNumber) * (Math.PI / 180)   'splits the figurative circle into segments of degrees based on the amount of sides 
            Dim rotation As Double = CInt(cbRotation.Text) * (Math.PI / 180)


            For PointLoop As Integer = 0 To SideNumber - 1

                Dim xPointVal As Integer
                Dim yPointVal As Integer

                xPointVal = e.X + CInt(radius * Math.Cos(InternalAngle * PointLoop + rotation))        'defines the point in which each point will be 
                yPointVal = e.Y + CInt(radius * Math.Sin(InternalAngle * PointLoop + rotation))
                pointList.Add(New Point(xPointVal, yPointVal))
            Next

            If fill = True Then
                g.FillPolygon(brushColor, pointList.ToArray) ' when the points are set the polygon is drawn between them then it is fill
                pointList.Clear()
            Else
                g.DrawPolygon(penColor, pointList.ToArray)
                pointList.Clear()
            End If
            pbCanvas.Image = DrawBitmap
        End If

        If heptagon = True Then

            If cbRadius.Text = Nothing Then
                cbRadius.Text = "15"
            End If

            If cbRotation.Text = Nothing Then
                cbRotation.Text = "0"
            End If
            Dim pointList As New List(Of Point)
            Dim SideNumber As Double = 7                'set the number of sides on the polygon relative to the combobox text
            Dim radius As Double = CInt(cbRadius.Text)                     'set the radius of the figurative circle around the polygon, or the radius to each angle. 
            Dim InternalAngle As Double = (360 / SideNumber) * (Math.PI / 180)   'splits the figurative circle into segments of degrees based on the amount of sides 
            Dim rotation As Double = CInt(cbRotation.Text) * (Math.PI / 180)


            For PointLoop As Integer = 0 To SideNumber - 1

                Dim xPointVal As Integer
                Dim yPointVal As Integer

                xPointVal = e.X + CInt(radius * Math.Cos(InternalAngle * PointLoop + rotation))        'defines the point in which each point will be 
                yPointVal = e.Y + CInt(radius * Math.Sin(InternalAngle * PointLoop + rotation))
                pointList.Add(New Point(xPointVal, yPointVal))
            Next

            If fill = True Then
                g.FillPolygon(brushColor, pointList.ToArray) ' when the points are set the polygon is drawn between them then it is fill
                pointList.Clear()
            Else
                g.DrawPolygon(penColor, pointList.ToArray)
                pointList.Clear()
            End If
            pbCanvas.Image = DrawBitmap
        End If

        If octagon = True Then

            If cbRadius.Text = Nothing Then
                cbRadius.Text = "15"
            End If

            If cbRotation.Text = Nothing Then
                cbRotation.Text = "0"
            End If

            Dim pointList As New List(Of Point)
            Dim SideNumber As Double = 8                'set the number of sides on the polygon relative to the combobox text
            Dim radius As Double = CInt(cbRadius.Text)                     'set the radius of the figurative circle around the polygon, or the radius to each angle. 
            Dim InternalAngle As Double = (360 / SideNumber) * (Math.PI / 180)   'splits the figurative circle into segments of degrees based on the amount of sides 
           Dim rotation As Double = CInt(cbRotation.Text) * (Math.PI / 180)

            For PointLoop As Integer = 0 To SideNumber - 1

                Dim xPointVal As Integer
                Dim yPointVal As Integer

                xPointVal = e.X + CInt(radius * Math.Cos(InternalAngle * PointLoop + rotation))        'defines the point in which each point will be 
                yPointVal = e.Y + CInt(radius * Math.Sin(InternalAngle * PointLoop + rotation))
                pointList.Add(New Point(xPointVal, yPointVal))
            Next

            If fill = True Then
                g.FillPolygon(brushColor, pointList.ToArray) ' when the points are set the polygon is drawn between them then it is fill
                pointList.Clear()
            Else
                g.DrawPolygon(penColor, pointList.ToArray)
                pointList.Clear()
            End If
            pbCanvas.Image = DrawBitmap
        End If

        If nonagon = True Then

            If cbRadius.Text = Nothing Then
                cbRadius.Text = "15"
            End If

            If cbRotation.Text = Nothing Then
                cbRotation.Text = "0"
            End If

            Dim pointList As New List(Of Point)
            Dim SideNumber As Double = 9               'set the number of sides on the polygon relative to the combobox text
            Dim radius As Double = CInt(cbRadius.Text)                     'set the radius of the figurative circle around the polygon, or the radius to each angle. 
            Dim InternalAngle As Double = (360 / SideNumber) * (Math.PI / 180)   'splits the figurative circle into segments of degrees based on the amount of sides 
            Dim rotation As Double = CInt(cbRotation.Text) * (Math.PI / 180)


            For PointLoop As Integer = 0 To SideNumber - 1

                Dim xPointVal As Integer
                Dim yPointVal As Integer

                xPointVal = e.X + CInt(radius * Math.Cos(InternalAngle * PointLoop + rotation))        'defines the point in which each point will be 
                yPointVal = e.Y + CInt(radius * Math.Sin(InternalAngle * PointLoop + rotation))
                pointList.Add(New Point(xPointVal, yPointVal))
            Next

            If fill = True Then
                g.FillPolygon(brushColor, pointList.ToArray) ' when the points are set the polygon is drawn between them then it is fill
                pointList.Clear()
            Else
                g.DrawPolygon(penColor, pointList.ToArray)
                pointList.Clear()
            End If
            pbCanvas.Image = DrawBitmap
        End If

        If decagon = True Then

            If cbRadius.Text = Nothing Then
                cbRadius.Text = "15"
            End If

            If cbRotation.Text = Nothing Then
                cbRotation.Text = "0"
            End If

            Dim pointList As New List(Of Point)
            Dim SideNumber As Double = 10                'set the number of sides on the polygon relative to the combobox text
            Dim radius As Double = CInt(cbRadius.Text)                     'set the radius of the figurative circle around the polygon, or the radius to each angle. 
            Dim InternalAngle As Double = (360 / SideNumber) * (Math.PI / 180)   'splits the figurative circle into segments of degrees based on the amount of sides 
            Dim rotation As Double = CInt(cbRotation.Text) * (Math.PI / 180)


            For PointLoop As Integer = 0 To SideNumber - 1

                Dim xPointVal As Integer
                Dim yPointVal As Integer

                xPointVal = e.X + CInt(radius * Math.Cos(InternalAngle * PointLoop + rotation))        'defines the point in which each point will be 
                yPointVal = e.Y + CInt(radius * Math.Sin(InternalAngle * PointLoop + rotation))
                pointList.Add(New Point(xPointVal, yPointVal))
            Next

            
            If fill = True Then
                g.FillPolygon(brushColor, pointList.ToArray) ' when the points are set the polygon is drawn between them then it is fill
                pointList.Clear()
            Else
                g.DrawPolygon(penColor, pointList.ToArray)
                pointList.Clear()
            End If
            pbCanvas.Image = DrawBitmap
        End If

    End Sub

    Private Sub pbRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRed.Click

        brushColor = New SolidBrush(Color.Red)  'brushcolor, pencolor, and current color picture box all changes to red
        penColor = New Pen(Color.Red)
        pbCC.BackColor = Color.Red

        If eraser = True Then   'If pbRed is clicked, then eraser = false and enables brush tool
            eraser = False
            brushColor.Color = Color.Red
            pbCC.BackColor = Color.Red
            Brush = True
        Else
            brushColor = brushColor
        End If

    End Sub

    Private Sub pbGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbGreen.Click

        brushColor = New SolidBrush(Color.Green)
        penColor = New Pen(Color.Green)
        pbCC.BackColor = Color.Green

        If eraser = True Then
            eraser = False
            brushColor.Color = Color.Green
            pbCC.BackColor = Color.Green
            Brush = True
        Else
            brushColor = brushColor
        End If

    End Sub

    Private Sub pbBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbBlue.Click

        brushColor = New SolidBrush(Color.Blue)
        penColor = New Pen(Color.Blue)
        pbCC.BackColor = Color.Blue

        If eraser = True Then
            eraser = False
            brushColor.Color = Color.Blue
            pbCC.BackColor = Color.Blue
            Brush = True
        Else
            brushColor = brushColor
        End If

    End Sub

    Private Sub pbBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbBlack.Click

        brushColor = New SolidBrush(Color.Black)
        penColor = New Pen(Color.Black)
        pbCC.BackColor = Color.Black

        If eraser = True Then
            eraser = False
            brushColor.Color = Color.Black
            pbCC.BackColor = Color.Black
            Brush = True
        Else
            brushColor = brushColor
        End If

    End Sub

    Private Sub pbPurple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbPurple.Click

        brushColor = New SolidBrush(Color.Purple)
        penColor = New Pen(Color.Purple)
        pbCC.BackColor = Color.Purple

        If eraser = True Then
            eraser = False
            brushColor.Color = Color.Purple
            pbCC.BackColor = Color.Purple
            Brush = True
        Else
            brushColor = brushColor
        End If

    End Sub

    Private Sub pbYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbYellow.Click

        brushColor = New SolidBrush(Color.Yellow)
        penColor = New Pen(Color.Yellow)
        pbCC.BackColor = Color.Yellow

        If eraser = True Then
            eraser = False
            brushColor.Color = Color.Yellow
            pbCC.BackColor = Color.Yellow
            Brush = True
        Else
            brushColor = brushColor
        End If

    End Sub

    Private Sub pbColors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbColors.Click

        Me.ColorDialog1.ShowDialog()        'brings up color dialog box
        colorPick = ColorDialog1.Color      'assigns choice to "colorPick"

        penColor = New Pen(colorPick)       'assigns new color to pencolor
        brushColor = New SolidBrush(colorPick)      'assigns new color to brushcolor
        pbCC.BackColor = (colorPick)

        If eraser = True Then
            eraser = False
            brushColor.Color = colorPick
            pbCC.BackColor = colorPick
            Brush = True
        Else
            brushColor = brushColor
        End If

    End Sub

    Private Sub btnEraser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEraser.Click

        eraser = True
        Brush = False
        Pencil = False

        brushColor = New SolidBrush(pbCanvas.BackColor)

        If brushSize = 10 Or brushSize = 1 Then
            brushSize = 15
            tbBrushsize.Text = "15"
        Else
            brushSize = brushSize
        End If

        pbCC.BackColor = pbCanvas.BackColor

        triangle = False
        rectangle = False
        pentagon = False
        hexagon = False
        heptagon = False
        octagon = False
        nonagon = False
        decagon = False
        Brush = False


    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click

        DrawBitmap = Nothing            'basically clear button
        pbCanvas.Image = DrawBitmap
        DrawBitmap = New Bitmap(pbCanvas.Width, pbCanvas.Height)
        g = Graphics.FromImage(DrawBitmap)

        For x As Integer = 0 To pbCanvas.Width - 1
            For y As Integer = 0 To pbCanvas.Height - 1
                DrawBitmap.SetPixel(x, y, Color.White)
            Next
        Next
        pbCanvas.BackColor = Color.White
        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click

        Me.SaveFileDialog1.ShowDialog() 'brings up the dialog

        DrawBitmap.Save(SaveFileDialog1.FileName & ".bmp", System.Drawing.Imaging.ImageFormat.Bmp) 'saves

    End Sub

    Private Sub LoadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadToolStripMenuItem.Click

        Me.OpenFileDialog1.ShowDialog() 'opens and loads images to the program

        pbCanvas.Image = Image.FromFile(OpenFileDialog1.FileName)

        DrawBitmap = Image.FromFile(OpenFileDialog1.FileName)

        g = Graphics.FromImage(DrawBitmap)


    End Sub

    Private Sub btnCanvasColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCanvasColor.Click
        'set background color to the same as brushcolor as clicking on any of the colors will convert the brushcolor to equall that clicked color
        For x As Integer = 0 To pbCanvas.Width - 1
            For y As Integer = 0 To pbCanvas.Height - 1
                DrawBitmap.SetPixel(x, y, brushColor.Color)
            Next
        Next

        'making the backcolor equal brushcolor, so the eraser can function easily
        pbCanvas.BackColor = brushColor.Color

    End Sub
    Private Sub btnTriangle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTriangle.Click
        triangle = True
        rectangle = False
        pentagon = False
        hexagon = False
        heptagon = False
        octagon = False
        nonagon = False
        decagon = False
        Brush = False
        Pencil = False
        eraser = False
    End Sub

    Private Sub btnRectangle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRectangle.Click
        rectangle = True
        triangle = False
        pentagon = False
        hexagon = False
        heptagon = False
        octagon = False
        nonagon = False
        decagon = False
        Brush = False
        Pencil = False
        eraser = False
    End Sub

    Private Sub btnPentagon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPentagon.Click
        pentagon = True
        rectangle = False
        triangle = False
        hexagon = False
        heptagon = False
        octagon = False
        nonagon = False
        decagon = False
        Brush = False
        Pencil = False
        eraser = False
    End Sub

    Private Sub btnHexagon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHexagon.Click
        hexagon = True
        rectangle = False
        pentagon = False
        triangle = False
        heptagon = False
        octagon = False
        nonagon = False
        decagon = False
        Brush = False
        Pencil = False
        eraser = False
    End Sub

    Private Sub btnHeptagon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeptagon.Click
        heptagon = True
        rectangle = False
        pentagon = False
        hexagon = False
        triangle = False
        octagon = False
        nonagon = False
        decagon = False
        Brush = False
        Pencil = False
        eraser = False
    End Sub

    Private Sub btnOctagon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOctagon.Click
        octagon = True
        rectangle = False
        pentagon = False
        hexagon = False
        heptagon = False
        triangle = False
        nonagon = False
        decagon = False
        Brush = False
        Pencil = False
        eraser = False
    End Sub

    Private Sub btnNonagon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNonagon.Click
        nonagon = True
        rectangle = False
        pentagon = False
        hexagon = False
        heptagon = False
        octagon = False
        triangle = False
        decagon = False
        Brush = False
        Pencil = False
        eraser = False
    End Sub

    Private Sub btnDecagon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecagon.Click
        decagon = True
        rectangle = False
        pentagon = False
        hexagon = False
        heptagon = False
        octagon = False
        nonagon = False
        triangle = False
        Brush = False
        Pencil = False
        eraser = False
    End Sub

    Private Sub btnLineP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLineP.Click
        'fill for polygon
        fill = False
    End Sub

    Private Sub btnFillP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFillP.Click
        'fill for polygon
        fill = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        ' hides or show X and Y labels
        If CheckBox1.Checked Then
            lblX.Hide()
            lblY.Hide()
        Else
            lblX.Show()
            lblY.Show()
        End If
    End Sub
End Class
