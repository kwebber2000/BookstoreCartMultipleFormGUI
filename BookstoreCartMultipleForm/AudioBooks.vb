Public Class AudioBooks

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lstSelectAudioBooks_DoubleClick(sender As Object, e As EventArgs) Handles lstSelectAudioBooks.DoubleClick
        If lstSelectAudioBooks.SelectedIndex <> -1 Then
            Dim subTotal, tax, shipping, total As Decimal

            'add item to shopping cart list
            ShoppingCart.lstProductsSelected.Items.Add(lstSelectAudioBooks.SelectedItem)

            'add book cost to subtotal
            AddBookCost(lstSelectAudioBooks.SelectedIndex)

            'get updated shopping cart amounts
            subTotal = BookstoreModule.subTotal
            tax = BookstoreModule.CalculateTax(BookstoreModule.subTotal)
            shipping = BookstoreModule.CalculateShipping(ShoppingCart.lstProductsSelected.Items.Count)
            total = subTotal + tax + shipping

            'set shopping cart labels
            UpdateShoppingCart(subTotal, tax, shipping, total)
        End If
    End Sub

    Private Sub btnAddBookToCart_Click(sender As Object, e As EventArgs) Handles btnAddBookToCart.Click
        If lstSelectAudioBooks.SelectedIndex <> -1 Then
            Dim subTotal, tax, shipping, total As Decimal

            'add item to shopping cart list
            ShoppingCart.lstProductsSelected.Items.Add(lstSelectAudioBooks.SelectedItem)

            'add book cost to subtotal
            AddBookCost(lstSelectAudioBooks.SelectedIndex)

            'get updated shopping cart amounts
            subTotal = BookstoreModule.subTotal
            tax = BookstoreModule.CalculateTax(BookstoreModule.subTotal)
            shipping = BookstoreModule.CalculateShipping(ShoppingCart.lstProductsSelected.Items.Count)
            total = subTotal + tax + shipping

            'set shopping cart labels
            UpdateShoppingCart(subTotal, tax, shipping, total)
        End If
    End Sub

    Sub AddBookCost(ByVal itemNumber As Integer)
        Select Case itemNumber
            Case 0
                BookstoreModule.AddItem(BookstoreModule.A_LCIOD)
            Case 1
                BookstoreModule.AddItem(BookstoreModule.A_THOS)
            Case 2
                BookstoreModule.AddItem(BookstoreModule.A_TSOBL)
            Case 3
                BookstoreModule.AddItem(BookstoreModule.A_RT)
        End Select
    End Sub

    Private Sub UpdateShoppingCart(ByVal subTotal As Decimal, ByVal tax As Decimal, ByVal shipping As Decimal, ByVal total As Decimal)
        ShoppingCart.lblSubtotal.Text = subTotal.ToString("c")
        ShoppingCart.lblTax.Text = tax.ToString("c")
        ShoppingCart.lblShipping.Text = shipping.ToString("c")
        ShoppingCart.lblTotal.Text = total.ToString("c")
    End Sub
End Class