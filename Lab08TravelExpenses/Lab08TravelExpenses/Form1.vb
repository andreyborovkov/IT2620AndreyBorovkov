Public Class Form1

    Private decDays As Decimal
    Private decMeals As Decimal
    Private decMilesDriven As Decimal
    Private decParkingCharges As Decimal
    Private decTaxiCharges As Decimal
    Private decLodgingCharges As Decimal
    Private decAirfare As Decimal

    Private Function ValidateInputFields() As Boolean 'Checks whether the variables are numeric and positive
        If Not Decimal.TryParse(txtDays.Text, decDays) Or decDays < 1 Then
            lblMessage.Text = "*Number of days must be numberic and more than 0"
            Return False
        End If

        If Not Decimal.TryParse(txtMealsPaidAmount.Text, decMeals) Or decMeals < 0 Then
            lblMessage.Text = "*All values must be numberic and not negative"
            Return False
        End If

        If Not Decimal.TryParse(txtMilesDriven.Text, decMilesDriven) Or decMilesDriven < 0 Then
            lblMessage.Text = "*All values must be numberic and not negative"
            Return False
        End If

        If Not Decimal.TryParse(txtParkingFees.Text, decParkingCharges) Or decParkingCharges < 0 Then
            lblMessage.Text = "*All values must be numberic and not negative"
            Return False
        End If

        If Not Decimal.TryParse(txtTaxiCharges.Text, decTaxiCharges) Or decTaxiCharges < 0 Then
            lblMessage.Text = "*All values must be numberic and not negative"
            Return False
        End If

        If Not Decimal.TryParse(txtLodgingCharges.Text, decLodgingCharges) Or decLodgingCharges < 0 Then
            lblMessage.Text = "*All values must be numberic and not negative"
            Return False
        End If

        If Not Decimal.TryParse(txtAirfareAmount.Text, decAirfare) Or decAirfare < 0 Then
            lblMessage.Text = "*All values must be numberic and not negative"
            Return False
        End If

        Return True
    End Function

    Function CalcMeals(ByVal decDays As Decimal,
                             ByVal decMeals As Decimal) As Decimal
        Dim decCalculatedMeals As Decimal

        If decMeals >= decDays * 37 Then
            decCalculatedMeals = decDays * 37
        Else
            decCalculatedMeals = decMeals 'Reimbursed amount cannot be greater than the amount needed to be paid
        End If

        Return decCalculatedMeals
    End Function

    Function CalcMileage(ByVal decMilesDriven As Decimal) As Decimal
        Dim decCalculatedMiles As Decimal
        decCalculatedMiles = decMilesDriven * 0.27

        Return decCalculatedMiles
    End Function

    Function CalcParkingFees(ByVal decParkingCharges As Decimal,
                                   ByVal decDays As Decimal) As Decimal
        Dim decCalculatedParkingFees As Decimal
        If decParkingCharges >= decDays * 10 Then
            decCalculatedParkingFees = decDays * 10
        Else
            decCalculatedParkingFees = decParkingCharges 'Reimbursed amount cannot be greater than the amount needed to be paid
        End If

        Return decCalculatedParkingFees
    End Function

    Function CalcTaxiFees(ByVal decTaxiCharges As Decimal,
                                   ByVal decDays As Decimal) As Decimal
        Dim decCalculatedTaxiFees As Decimal
        If decTaxiCharges >= decDays * 20 Then
            decCalculatedTaxiFees = decDays * 20
        Else
            decCalculatedTaxiFees = decTaxiCharges 'Reimbursed amount cannot be greater than the amount needed to be paid
        End If

        Return decCalculatedTaxiFees
    End Function


    Function CalcLodging(ByVal decLodginCharges As Decimal,
                                   ByVal decDays As Decimal) As Decimal
        Dim decCalculatedLodging As Decimal
        If decLodgingCharges >= decDays * 95 Then
            decCalculatedLodging = decDays * 95
        Else
            decCalculatedLodging = decTaxiCharges 'Reimbursed amount cannot be greater than the amount needed to be paid
        End If

        Return decCalculatedLodging
    End Function

    Function CalcTotalReimbursement() As Decimal
        Dim decCalculatedTotalReimbursement As Decimal
        Dim decCalculatedMeals As Decimal
        Dim decCalculatedMiles As Decimal
        Dim decCalculatedParkingFees As Decimal
        Dim decCalculatedTaxiFees As Decimal
        Dim decCalculatedLodging As Decimal

        decCalculatedMeals = CalcMeals(decDays, decMeals)
        decCalculatedMiles = CalcMileage(decMilesDriven)
        decCalculatedParkingFees = CalcParkingFees(decParkingCharges, decDays)
        decCalculatedTaxiFees = CalcTaxiFees(decTaxiCharges, decDays)
        decCalculatedLodging = CalcLodging(decLodgingCharges, decDays)

        decCalculatedTotalReimbursement = decCalculatedMeals + decCalculatedMiles + decCalculatedParkingFees + decCalculatedTaxiFees + decCalculatedLodging

        Return decCalculatedTotalReimbursement
    End Function

    Function CalcUnallowed(ByVal decParkingCharges As Decimal,
                                    ByVal decTaxiCharges As Decimal,
                                    ByVal decLodgingCharges As Decimal) As Decimal
        Dim decCalculatedUnallowed
        Dim decCalculatedParkingFees As Decimal
        Dim decCalculatedTaxiFees As Decimal
        Dim decCalculatedLodging As Decimal

        decCalculatedParkingFees = CalcParkingFees(decParkingCharges, decDays)
        decCalculatedTaxiFees = CalcTaxiFees(decTaxiCharges, decDays)
        decCalculatedLodging = CalcLodging(decLodgingCharges, decDays)


        decCalculatedUnallowed = decParkingCharges - decCalculatedParkingFees + decTaxiCharges - decCalculatedTaxiFees + decLodgingCharges - decCalculatedLodging

        If decCalculatedUnallowed < 0 Then
            decCalculatedUnallowed = 0
        End If

        Return decCalculatedUnallowed
    End Function


    Function CalcSaved(ByVal decDays As Decimal,
                       ByVal decMeals As Decimal,
                       ByVal decMilesDriven As Decimal,
                       ByVal decParkingCharges As Decimal,
                       ByVal decTaxiCharges As Decimal,
                       ByVal decLodgingCharges As Decimal,
                       ByVal decAirfare As Decimal) As Decimal

        Dim decAllowed As Decimal
        decAllowed = decDays * 37 + decDays * 10 + decDays * 20 + decDays * 95 + decParkingCharges

        Dim decTotalCharges As Decimal
        decTotalCharges = decMeals + decMilesDriven + decParkingCharges + decTaxiCharges + decLodgingCharges + decAirfare

        Dim decCalculatedSaved As Decimal

        If decTotalCharges < decAllowed Then
            decCalculatedSaved = decAllowed - decTotalCharges
        Else
            decCalculatedSaved = 0
        End If

        Return decCalculatedSaved
    End Function


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decCalculatedMeals As Decimal
        Dim decCalculatedMiles As Decimal
        Dim decCalculatedParkingFees As Decimal
        Dim decCalculatedTaxiFees As Decimal
        Dim decCalculatedLodging As Decimal
        Dim decCalculatedTotalReimbursement As Decimal
        Dim decCalculatedUnallowed As Decimal
        Dim decCalculatedSaved As Decimal

        'Clear any previous message.
        lblMessage.Text = String.Empty

        If ValidateInputFields() Then
            decCalculatedMeals = CalcMeals(decDays, decMeals)
            lblMeals.Text = decCalculatedMeals.ToString("c")

            decCalculatedMiles = CalcMileage(decMilesDriven)
            lblMileage.Text = decCalculatedMiles.ToString("c")

            decCalculatedParkingFees = CalcParkingFees(decParkingCharges, decDays)
            lblParkingFees.Text = decCalculatedParkingFees.ToString("c")

            decCalculatedTaxiFees = CalcTaxiFees(decTaxiCharges, decDays)
            lblTaxiFees.Text = decCalculatedTaxiFees.ToString("c")

            decCalculatedLodging = CalcLodging(decLodgingCharges, decDays)
            lblLodging.Text = decCalculatedLodging.ToString("c")

            decCalculatedTotalReimbursement = CalcTotalReimbursement()
            lblTotalReimbursement.Text = decCalculatedTotalReimbursement.ToString("c")

            decCalculatedUnallowed = CalcUnallowed(decParkingCharges, decTaxiCharges, decLodgingCharges)
            lblUnallowed.Text = decCalculatedUnallowed.ToString("c")

            decCalculatedSaved = CalcSaved(decDays, decMeals, decMilesDriven, decParkingCharges, decTaxiCharges, decLodgingCharges, decAirfare)
            lblSaved.Text = decCalculatedSaved.ToString("c")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
