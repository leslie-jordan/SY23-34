﻿Public Class CoinSlot
    Public Event coinreturnevent(d As Integer, q As Integer, dm As Integer, n As Integer)

    Public Event dispense(p As Image)
    Public Property quarters As Integer
    Public Property dimes As Integer
    Public Property nickels As Integer
    Public Property dollars As Integer
    Dim _total As Decimal
    Public ReadOnly Property total As Decimal
        Get
            _total = dollars + quarters * 0.25 + dimes * 0.1 + nickels * 0.05
            Return _total
        End Get
    End Property
    Public Sub coinreturn()
        RaiseEvent coinreturnevent(dollars, quarters, dimes, nickels)
        dollars = 0
        quarters = 0
        dimes = 0
        nickels = 0
    End Sub
    Public Sub insertquarter()
        quarters = quarters + 1
    End Sub

    Public Sub insertdime()
        dimes = dimes + 1
    End Sub

    Public Sub insertnickel()
        nickels = nickels + 1
    End Sub

    Public Sub insertdollar()
        dollars = dollars + 1
    End Sub

    Public Sub insertten()
        dollars = dollars + 10
    End Sub
    Public Sub spin()
        If total >= 1 Then
            _total = total - 1
            dollars = 0
            quarters = 0
            dimes = 0
            nickels = _total / 0.05
        End If
    End Sub
End Class