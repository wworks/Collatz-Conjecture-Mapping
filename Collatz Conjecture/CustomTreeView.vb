Public Class CustomTreeView
    Public DrawGrid(500, 500)

    'Relations for LineDrawing
    Public Relations As New Dictionary(Of Integer, String)
    Public graphics As Graphics


    Public Sub Draw(Rootnode As Node, Direction As Integer, Spacing As Integer)
        Me.Refresh()
        Relations.Clear()
        Array.Clear(DrawGrid, 0, DrawGrid.Length)
        graphics = Me.CreateGraphics

        'Maps all nodes and subnodes to a 2d grid:
        FillDrawGrid(Rootnode, 0, 0, Direction)

        'Draw all the lines:
        For i = 0 To DrawGrid.GetLength(0) - 1
            For j = 0 To DrawGrid.GetLength(0) - 1
                If DrawGrid(i, j) = 0 Then
                    Continue For
                End If

                Dim RelationText = relations(DrawGrid(i, j))
                Dim split = RelationText.Split(",")
                For Relation = 0 To split.Length - 1
                    If split(Relation) <> "" Then
                        graphics.DrawLine(Pens.Blue, New Point(i * Spacing, j * Spacing), getDrawGridLocation(CInt(split(Relation)), Spacing))

                        'Draw Numbers:
                        ' Dim font As New Font("Microsoft Sans Serif", 5)
                        ' graphics.DrawString(DrawGrid(i, j), font, Brushes.Black, New Point(i * spacing, j * spacing))
                        ' graphics.DrawString(split(r), font, Brushes.Black, getDrawGridLocation(CInt(split(r)), spacing))

                    End If

                Next

            Next
        Next
    End Sub
    Public Function getDrawGridLocation(number As Integer, Spacing As Integer) As Point
        Dim Location As New Point

        For i = 0 To DrawGrid.GetLength(0) - 1
            For j = 0 To DrawGrid.GetLength(0) - 1
                If DrawGrid(i, j) = number Then
                    Location.X = i * Spacing
                    Location.Y = j * Spacing
                    Return Location
                End If

            Next
        Next


    End Function
    Public Sub FillDrawGrid(node As Node, x As Integer, y As Integer, Direction As Integer)
        Select Case Direction
            Case DrawDirection.Horizontal
                If DrawGrid(x + 1, y) = 0 Then
                    DrawGrid(x + 1, y) = node.NodeValue
                    x = x + 1
                ElseIf DrawGrid(x, y + 1) = 0 Then
                    DrawGrid(x, y + 1) = node.NodeValue
                    y = y + 1
                ElseIf DrawGrid(x, y + 2) = 0 Then
                    DrawGrid(x, y + 2) = node.NodeValue
                    y += 2
                Else
                    While DrawGrid(x, y) <> 0
                        y += 1

                    End While
                    DrawGrid(x, y) = node.NodeValue
                End If

            Case DrawDirection.Vertical
                If DrawGrid(x, y + 1) = 0 Then
                    DrawGrid(x, y + 1) = node.NodeValue
                    y += 1
                ElseIf DrawGrid(x + 1, y) = 0 Then
                    DrawGrid(x + 1, y) = node.NodeValue
                    x += 1
                ElseIf DrawGrid(x + 2, y) = 0 Then
                    DrawGrid(x + 2, y) = node.NodeValue
                    x += 2
                Else
                    While DrawGrid(x, y) <> 0
                        x += 1

                    End While
                    DrawGrid(x, y) = node.NodeValue
                End If
        End Select



        Dim relationText = ""


        For Each noden As Node In node.ListOutwardNodes
            relationText &= "," & noden.NodeValue
            FillDrawGrid(noden, x, y, Direction)

        Next

        relations.Add(node.NodeValue, relationText)
    End Sub
    Public Enum DrawDirection
        Horizontal = 0
        Vertical = 1
    End Enum


End Class

