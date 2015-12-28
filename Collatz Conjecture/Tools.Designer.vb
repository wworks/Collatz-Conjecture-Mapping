<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tools
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.CustomTreeLineWidthTrackBar = New System.Windows.Forms.TrackBar()
        Me.NodeGeneratingMode = New System.Windows.Forms.CheckBox()
        Me.FillTreeViewButton = New System.Windows.Forms.Button()
        Me.CustomTreeViewButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Horizontal = New System.Windows.Forms.RadioButton()
        Me.Vertical = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Steps = New System.Windows.Forms.Label()
        CType(Me.CustomTreeLineWidthTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 36)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(190, 20)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "27"
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(15, 85)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(190, 41)
        Me.StartButton.TabIndex = 5
        Me.StartButton.Text = "Generate Map"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'CustomTreeLineWidthTrackBar
        '
        Me.CustomTreeLineWidthTrackBar.Location = New System.Drawing.Point(6, 51)
        Me.CustomTreeLineWidthTrackBar.Maximum = 30
        Me.CustomTreeLineWidthTrackBar.Minimum = 1
        Me.CustomTreeLineWidthTrackBar.Name = "CustomTreeLineWidthTrackBar"
        Me.CustomTreeLineWidthTrackBar.Size = New System.Drawing.Size(190, 45)
        Me.CustomTreeLineWidthTrackBar.TabIndex = 10
        Me.CustomTreeLineWidthTrackBar.Value = 3
        '
        'NodeGeneratingMode
        '
        Me.NodeGeneratingMode.AutoSize = True
        Me.NodeGeneratingMode.Location = New System.Drawing.Point(17, 62)
        Me.NodeGeneratingMode.Name = "NodeGeneratingMode"
        Me.NodeGeneratingMode.Size = New System.Drawing.Size(191, 17)
        Me.NodeGeneratingMode.TabIndex = 11
        Me.NodeGeneratingMode.Text = "Add nodes instead of regenerating."
        Me.NodeGeneratingMode.UseVisualStyleBackColor = True
        '
        'FillTreeViewButton
        '
        Me.FillTreeViewButton.Location = New System.Drawing.Point(20, 401)
        Me.FillTreeViewButton.Name = "FillTreeViewButton"
        Me.FillTreeViewButton.Size = New System.Drawing.Size(197, 41)
        Me.FillTreeViewButton.TabIndex = 12
        Me.FillTreeViewButton.Text = "Fill Standard TreeView"
        Me.FillTreeViewButton.UseVisualStyleBackColor = True
        '
        'CustomTreeViewButton
        '
        Me.CustomTreeViewButton.Location = New System.Drawing.Point(8, 152)
        Me.CustomTreeViewButton.Name = "CustomTreeViewButton"
        Me.CustomTreeViewButton.Size = New System.Drawing.Size(197, 41)
        Me.CustomTreeViewButton.TabIndex = 13
        Me.CustomTreeViewButton.Text = "Fill Custom TreeView"
        Me.CustomTreeViewButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Size of custom TreeView"
        '
        'Horizontal
        '
        Me.Horizontal.AutoSize = True
        Me.Horizontal.Checked = True
        Me.Horizontal.Location = New System.Drawing.Point(18, 97)
        Me.Horizontal.Name = "Horizontal"
        Me.Horizontal.Size = New System.Drawing.Size(72, 17)
        Me.Horizontal.TabIndex = 15
        Me.Horizontal.TabStop = True
        Me.Horizontal.Text = "Horizontal"
        Me.Horizontal.UseVisualStyleBackColor = True
        '
        'Vertical
        '
        Me.Vertical.AutoSize = True
        Me.Vertical.Location = New System.Drawing.Point(18, 120)
        Me.Vertical.Name = "Vertical"
        Me.Vertical.Size = New System.Drawing.Size(60, 17)
        Me.Vertical.TabIndex = 16
        Me.Vertical.Text = "Vertical"
        Me.Vertical.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CustomTreeViewButton)
        Me.GroupBox1.Controls.Add(Me.Vertical)
        Me.GroupBox1.Controls.Add(Me.CustomTreeLineWidthTrackBar)
        Me.GroupBox1.Controls.Add(Me.Horizontal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 190)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 205)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Custom TreeView Options"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Steps)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.NodeGeneratingMode)
        Me.GroupBox2.Controls.Add(Me.StartButton)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 172)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Generating Map"
        '
        'Steps
        '
        Me.Steps.AutoSize = True
        Me.Steps.Location = New System.Drawing.Point(15, 139)
        Me.Steps.Name = "Steps"
        Me.Steps.Size = New System.Drawing.Size(46, 13)
        Me.Steps.TabIndex = 15
        Me.Steps.Text = "Steps: 0"
        '
        'Tools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 463)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FillTreeViewButton)
        Me.Name = "Tools"
        Me.Text = "Tools"
        CType(Me.CustomTreeLineWidthTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents CustomTreeLineWidthTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents NodeGeneratingMode As System.Windows.Forms.CheckBox
    Friend WithEvents FillTreeViewButton As System.Windows.Forms.Button
    Friend WithEvents CustomTreeViewButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Horizontal As System.Windows.Forms.RadioButton
    Friend WithEvents Vertical As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Steps As System.Windows.Forms.Label
End Class
