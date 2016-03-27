<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintBooks
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstSelectPrintBooks = New System.Windows.Forms.ListBox()
        Me.btnAddBookToCart = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstSelectPrintBooks)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 164)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Print Book"
        '
        'lstSelectPrintBooks
        '
        Me.lstSelectPrintBooks.FormattingEnabled = True
        Me.lstSelectPrintBooks.Items.AddRange(New Object() {"I Did It Your Way (Print)", "The History of Scotland (Print)", "Learn Calclus in One Day (Print)", "Feel the Stress (Print)"})
        Me.lstSelectPrintBooks.Location = New System.Drawing.Point(26, 29)
        Me.lstSelectPrintBooks.Name = "lstSelectPrintBooks"
        Me.lstSelectPrintBooks.Size = New System.Drawing.Size(356, 108)
        Me.lstSelectPrintBooks.TabIndex = 0
        '
        'btnAddBookToCart
        '
        Me.btnAddBookToCart.Location = New System.Drawing.Point(102, 209)
        Me.btnAddBookToCart.Name = "btnAddBookToCart"
        Me.btnAddBookToCart.Size = New System.Drawing.Size(106, 34)
        Me.btnAddBookToCart.TabIndex = 1
        Me.btnAddBookToCart.Text = "Add Book to Cart"
        Me.btnAddBookToCart.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(243, 208)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(106, 34)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PrintBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 262)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddBookToCart)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PrintBooks"
        Me.Text = "PrintBooks"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstSelectPrintBooks As System.Windows.Forms.ListBox
    Friend WithEvents btnAddBookToCart As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
