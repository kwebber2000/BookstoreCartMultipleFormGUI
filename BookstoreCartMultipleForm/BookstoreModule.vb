Module BookstoreModule

    Const decSHIPPING_CHARGE As Decimal = 2D
    Const decTAX_RATE As Decimal = 0.06D

    ' Print (P) Book costs 
    Public Const P_IDIYW As Decimal = 11.95D
    Public Const P_THOS As Decimal = 14.5D
    Public Const P_LCIOD As Decimal = 29.95D
    Public Const P_FTS As Decimal = 18.5D

    ' Audio (A) Book costs
    Public Const A_LCIOD As Decimal = 29.95D
    Public Const A_THOS As Decimal = 14.5D
    Public Const A_TSOBL As Decimal = 12.95D
    Public Const A_RT As Decimal = 11.5D

    Public subTotal As Decimal = 0D

    Sub AddItem(ByVal amount As Decimal)
        BookstoreModule.subTotal = BookstoreModule.subTotal + amount
    End Sub

    Sub SubtractItem(ByVal itemName As String)
        Dim amount As Decimal

        Select Case itemName
            Case "I Did It Your Way (Print)"
                amount = P_IDIYW
            Case "The History of Scotland (Print)"
                amount = P_THOS
            Case "Learn Calclus in One Day (Print)"
                amount = P_LCIOD
            Case "Feel the Stress (Print)"
                amount = P_FTS
            Case "Learn Calculus In One Day (Audio)"
                amount = A_LCIOD
            Case "Relaxation Techniques(Audio)"
                amount = A_RT
            Case "The History of Scotland (Audio)"
                amount = A_THOS
            Case "The Science of Body Language (Audio)"
                amount = A_TSOBL
        End Select

        If BookstoreModule.subTotal > 0 Then
            BookstoreModule.subTotal = BookstoreModule.subTotal - amount
        End If

    End Sub


    Function CalculateTax(ByVal amount As Decimal) As Decimal
        Return decTAX_RATE * amount
    End Function

    Function CalculateShipping(ByVal items As Integer) As Decimal
        Return decSHIPPING_CHARGE * items
    End Function

End Module
