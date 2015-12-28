Imports Collatz_Conjecture.CollatzConjectureMainFunctions

Public Class Tools
    Dim PreviousStartNumber = 1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If NodeGeneratingMode.Checked Then
            FillRootnode(PreviousStartNumber, PreviousStartNumber + CInt(TextBox1.Text))
            PreviousStartNumber += TextBox1.Text
        Else
            FillRootnode(1, CInt(TextBox1.Text))
            PreviousStartNumber = CInt(TextBox1.Text)
        End If

        Steps.Text = "Steps: " & PreviousStartNumber

    End Sub


    Private Sub FillTreeViewButton_Click(sender As Object, e As EventArgs) Handles FillTreeViewButton.Click
        TreeViewForm.TreeView1.Nodes.Clear()

        Dim TreeNode As New TreeNode
        TreeNode.Text = 1
        TreeViewForm.PrintNodeTreeView(Rootnode, TreeNode)
        TreeNode.ExpandAll()
        TreeViewForm.TreeView1.Nodes.Add(TreeNode)

        TreeViewForm.Show()
    End Sub

    Private Sub CustomTreeViewButton_Click(sender As Object, e As EventArgs) Handles CustomTreeViewButton.Click
        CustomTreeView.Show()
        If Vertical.Checked Then
            CustomTreeView.Draw(Rootnode, CustomTreeView.DrawDirection.Vertical, CustomTreeLineWidthTrackBar.Value)
        Else
            CustomTreeView.Draw(Rootnode, CustomTreeView.DrawDirection.Horizontal, CustomTreeLineWidthTrackBar.Value)
        End If

    End Sub
End Class