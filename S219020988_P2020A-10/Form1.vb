Option Strict On
Option Explicit On
Option Infer Off
'*************************************
'Surname Initials: Gulube t
'Student Number: 219020988
'Practical Number: P2020A-10
'*************************************
Public Class frmTTP
    'these are my variable declaretions
    Private Structure OfferRec 'offer record structure
        Public size As Double
        Public SellingPrice As Double
        Public UnitsSold() As Integer
        Public TotalProfit As Double
    End Structure
    Private Structure ProductRec  ' product record structure
        Public ID As String
        Public Cost As Double
        Public offer() As OfferRec
        Public Least As Integer
        Public Rating As String
    End Structure
    Private Products As Integer
    Private Offers As Integer
    Private weeks As Integer
    Private product() As ProductRec

    'sub for labelling grid
    Private Sub LG(ByVal c As Integer, ByVal r As Integer, ByVal t As String)
        grid1.Col = c
        grid1.Row = r
        grid1.Text = t
    End Sub

    Private Sub btnResize_Click(sender As Object, e As EventArgs) Handles btnResize.Click
        'this is where i get the number of products,weeks and offers for the user
        Products = CInt(InputBox("Number of Products", "Sir/Madam"))
        Offers = CInt(InputBox("Number of Offers", "Sir/Madam"))
        weeks = CInt(InputBox("Number of weeks", "Sir/Madam"))

        ' the code below helps me resize my arrays
        ReDim product(Products)
        Dim p, o As Integer
        For p = 1 To Products
            ReDim product(p).offer(Offers)
            For o = 1 To Offers
                ReDim product(p).offer(o).UnitsSold(weeks)
            Next o
        Next p

        'resize the grid
        grid1.Cols = Offers + 3
        grid1.Rows = Products + 1
        'the next code is for labeling the grid
        For p = 1 To Products
            LG(0, p, "Product " & CStr(p))
        Next p
        For o = 1 To Offers
            LG(o, 0, "Offer " & CStr(o) & " Profit")
        Next o
        LG(0, 0, "Product ID")
        LG(Offers + 1, 0, "Least Pro Size")
        LG(Offers + 2, 0, "Ratings")
    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click 'this sub is for capturing information fro the user 
        Dim p, w, o As Integer

        For p = 1 To Products
            product(p).ID = InputBox("Please enter Product " & CStr(p) & " ID")
            product(p).Cost = CDbl(InputBox("How much does it cost to produce a litre of " & product(p).ID))
            For o = 1 To Offers
                product(p).offer(o).size = CDbl(InputBox("Please enter the Size of Offer " & CStr(o) & " for " & product(p).ID))
                product(p).offer(o).SellingPrice = CDbl(InputBox("Please enter the selling price for offer " & CStr(o) & " for " & product(p).ID))
                For w = 1 To weeks
                    product(p).offer(o).UnitsSold(w) = CInt(InputBox("Number of Offer " & CStr(o) & " " & product(p).ID & " paints sold in Week " & CStr(w)))
                Next w
            Next o
            LG(0, p, product(p).ID)
        Next p
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim p, o, w As Integer
        Dim total(Offers) As Integer
        Dim charge(Offers) As Double 'the charge is the same as the cost 
        For p = 1 To Products
            For o = 1 To Offers
                For w = 1 To weeks
                    total(o) += product(p).offer(o).UnitsSold(w) 'this code helps me get the total for each offer
                Next w
            Next o
        Next p

        For p = 1 To Products
            For o = 1 To Offers
                charge(o) = total(o) * product(p).offer(o).size * product(p).Cost ' here i calculate the cost needed to determine the total profit
            Next o
        Next p

        For p = 1 To Products
            For o = 1 To Offers
                product(p).offer(o).TotalProfit = (total(o) - charge(o)) * product(p).offer(o).SellingPrice 'calculation of total profit
                LG(o, p, Format(product(p).offer(o).TotalProfit, "0.00")) ' this is where i display the totalprofit for each offer
            Next o
        Next p

        'the code below helps me determine the least profit for every offer 
        For p = 1 To Products
            Dim index As Integer = CInt(product(p).offer(1).TotalProfit)
            product(p).Least = 1
            For o = 1 To Offers
                Select Case index
                    Case > CInt(product(p).offer(o).TotalProfit)
                        index = CInt(product(p).offer(o).TotalProfit)
                        product(p).Least = o
                End Select
                LG(Offers + 1, p, CStr(product(p).offer(product(p).Least).size)) 'after getting the least i then display the size of the least profit
            Next o
        Next p
    End Sub

    Private Function DevidebyTen(ByVal number As Double) As Double ' this function helps me get 10% of any number i insert  
        Return number * 0.1
    End Function

    Private Sub btnRate_Click(sender As Object, e As EventArgs) Handles btnRate.Click
        Dim p As Integer
        Dim rate(Products) As Double
        For p = 1 To Products
            rate(p) = DevidebyTen(product(p).offer(product(p).Least).TotalProfit) 'using the function i created i get 
        Next p

        For p = 1 To Products
            'the select case below helps me rate all the products according to their profit levels 
            Select Case rate(p)
                Case 0 To 100
                    product(p).Rating = "A"
                Case 100.000000001 To 999.99999999
                    product(p).Rating = "B"
                Case > 1000
                    product(p).Rating = "C"
                Case Else
                    product(p).Rating = "Profits are < 0" 'this line tells the user that they are actually losing money  they will lose money almost all the time
            End Select
            LG(Offers + 2, p, product(p).Rating)
        Next p
    End Sub
End Class