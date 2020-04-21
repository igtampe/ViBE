''' <summary>Form to show details of an item</summary>
Public Class EzTaxDetails

    '--------------------------------[Variables]--------------------------------
    Public myItem As IncomeRegistryItem

    '--------------------------------[Initialization]--------------------------------
    Public Sub New(Item As IncomeRegistryItem)
        InitializeComponent()
        myItem = Item

        ItemNameLabel.Text = myItem.Name
        ItemLocationLabel.Text = "Located in: " & myItem.Location

        DetailsTXB.Text = myItem.ToString
    End Sub

    '--------------------------------[Buttons]--------------------------------

    Private Sub ClickOKtoOK() Handles OKBTN.Click
        Close()
    End Sub


    Private Sub Encore() Handles RecertifyButton.Click
        Dim RecertWindow As EzTaxCertify = New EzTaxCertify(myItem)
        RecertWindow.ShowDialog()

    End Sub

    '--------------------------------[Window Moving Functions]--------------------------------

    ''' <summary>This has to do with moving the window</summary>
    Public WindowIsmoving As Boolean
    Public DX As Integer
    Public DY As Integer

    Public Sub TimeToMove() Handles EzTaxTopLabel.MouseDown
        WindowIsmoving = True
        DX = Location.X - MousePosition.X
        DY = Location.Y - MousePosition.Y
    End Sub

    Private Sub ImMoving(sender As Object, e As MouseEventArgs) Handles EzTaxTopLabel.MouseMove
        If WindowIsmoving Then
            Me.SetDesktopLocation(DX + MousePosition.X, DY + MousePosition.Y)
        End If
    End Sub

    Public Sub OktimeToStop() Handles EzTaxTopLabel.MouseUp
        WindowIsmoving = False
    End Sub

End Class