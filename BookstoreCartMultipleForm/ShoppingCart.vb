Public Class ShoppingCart

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click

        'Clear listbox and labels
        lstProductsSelected.Items.Clear()
        lblShipping.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Close the application
        Me.Close()
    End Sub

    Private Sub PrintBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintBooksToolStripMenuItem.Click
        PrintBooks.Show()
    End Sub

    Private Sub AudioBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioBooksToolStripMenuItem.Click
        AudioBooks.Show()
    End Sub
   
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Display a simple about box
        MessageBox.Show("About the bookstore")
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        Dim itemIndex As Integer
        Dim subTotal, tax, shipping, total As Decimal

        itemIndex = lstProductsSelected.SelectedIndex
        If itemIndex <> -1 Then
            BookstoreModule.SubtractItem(lstProductsSelected.SelectedItem)
            lstProductsSelected.Items.RemoveAt(itemIndex)

            'get updated shopping cart amounts
            subTotal = BookstoreModule.subTotal
            tax = BookstoreModule.CalculateTax(BookstoreModule.subTotal)
            shipping = BookstoreModule.CalculateShipping(lstProductsSelected.Items.Count)
            total = subTotal + tax + shipping

            'set shopping cart labels
            UpdateShoppingCart(subTotal, tax, shipping, total)
        End If
    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click

        'Clear listbox, labels and reset subtotal
        lstProductsSelected.Items.Clear()
        BookstoreModule.subTotal = 0D
        lblSubtotal.Text = 0D
        lblShipping.Text = 0D
        lblTax.Text = 0D
        lblTotal.Text = 0D
    End Sub

    Private Sub UpdateShoppingCart(ByVal subTotal As Decimal, ByVal tax As Decimal, ByVal shipping As Decimal, ByVal total As Decimal)
        lblSubtotal.Text = subTotal.ToString("c")
        lblTax.Text = tax.ToString("c")
        lblShipping.Text = shipping.ToString("c")
        lblTotal.Text = total.ToString("c")
    End Sub
End Class
