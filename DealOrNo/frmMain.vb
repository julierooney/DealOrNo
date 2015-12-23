Public Class frmMain
    Public intCounterButtons As Integer
    '3,425,916
    Private strMoney() As String = {"0.01", "1.00", "5.00", "10.00", "25.00", "50.00", "75.00", "100.00",
                                  "200.00", "300.00", "400.00", "500.00", "750.00", "1,000", "5,000",
                                  "10,000", "25,000", "50,000", "75,000", "100,000",
                                  "200,000", "300,000", "400,000", "500,000", "750,000", "1,000,000"}
    Private dblValue As Double = 3418416
    Private dblOffer As Double
    Private dblCase As Double
    Private dblPreOffer As Double
    Public Property strPlayerName As String
    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnStart_Click(sender, e)

        
        lblRound.Visible = True
        lblOpenCase.Visible = False
        intCounterButtons = 0
        btnYourCase.Enabled = False
        Label4.Visible = True
    End Sub

    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        btnYourCase.Visible = False

        Panel1.SendToBack()
        Panel1.Visible = False
        Call resetBoards()
        dblCase = 0
        dblOffer = 0
        btnStart.Visible = False
        Call ShuffleArrayInPlace(strMoney)
        Label3.Text = ""
        ' dblValue = 3425916
        btnYourCase.Enabled = False

       
        btn1.Tag = strMoney(0)
        btn2.Tag = strMoney(1)
        btn3.Tag = strMoney(2)
        btn4.Tag = strMoney(3)
        btn5.Tag = strMoney(4)
        btn6.Tag = strMoney(5)
        btn7.Tag = strMoney(6)
        btn8.Tag = strMoney(7)
        btn9.Tag = strMoney(8)
        btn10.Tag = strMoney(9)
        btn11.Tag = strMoney(10)
        btn12.Tag = strMoney(11)
        btn13.Tag = strMoney(12)
        btn14.Tag = strMoney(13)
        btn15.Tag = strMoney(14)
        btn16.Tag = strMoney(15)
        btn17.Tag = strMoney(16)
        btn18.Tag = strMoney(17)
        btn19.Tag = strMoney(18)
        btn26.Tag = strMoney(19)
        btn20.Tag = strMoney(20)
        btn21.Tag = strMoney(21)
        btn22.Tag = strMoney(22)
        btn23.Tag = strMoney(23)
        btn24.Tag = strMoney(24)
        btn25.Tag = strMoney(25)

       
        btnStart.Enabled = False
        Call enablebuttons()
        lblRound.Text = "Choose your case"
        lblRound.Visible = True
        lblOpenCase.Visible = False
        Label4.Visible = True
        Label4.Text = "if you don't take this deal you will have to "
        intCounterButtons = 0

    End Sub

    Private Sub btnNoDeal_Click(sender As System.Object, e As System.EventArgs) Handles btnNoDeal.Click
        
        btnDeal.Enabled = False
        btnNoDeal.Enabled = False
        Panel1.Visible = False
        Panel1.SendToBack()
        If intCounterButtons = 26 Then
            btnYourCase.Enabled = True
            btnYourCase.Text = btnYourCase.Tag()
            lblYourCaseValue.Visible = True
            lblYourCase.Visible = True
            lblYourCaseValue.Text = btnYourCase.Tag()
            Call disablebuttons()
            Call revealAllCases()
            lblRound.Text = ""
            lblOpenCase.Text = ""
            Panel1.Visible = True
            Panel1.BringToFront()
            btnYourCase.BringToFront()
            If Label5.Text = "Final Offer" Then
                Label5.Text = "Game Over"
                Label4.Visible = True
                Label7.Visible = True
                Label7.Text = frmLogin.strPlayerName
                btnStart.Focus()
                btnStart.Select()
                btnStart.Enabled = True
                btnStart.Text = "Play Again"
                btnStart.Visible = True

                If dblOffer < btnYourCase.Tag Then
                    Label4.Text = "You made a good deal"
                Else
                    Label4.Text = "You made a bad deal"
                End If
            End If

        End If
    End Sub
    Private Sub btnDeal_Click(sender As System.Object, e As System.EventArgs) Handles btnDeal.Click
        btnDeal.Enabled = False
        btnNoDeal.Enabled = False
        lblAccepted.Visible = True
        btnYourCase.Enabled = True
        btnYourCase.Text = btnYourCase.Tag()
        lblYourCaseValue.Visible = True
        lblYourCase.Visible = True
        lblYourCaseValue.Text = btnYourCase.Tag()
        Label5.Text = "Game Over"
        Label7.Visible = True
        Label4.Visible = True
        Label7.Text = frmLogin.strPlayerName
        btnStart.Focus()
        btnStart.Select()
        btnStart.Enabled = True
        btnStart.Text = "Play Again"
        btnStart.Visible = True
        btnYourCase.BringToFront()
        If dblOffer > btnYourCase.Tag Then
            Label4.Text = "You made a good deal"
        Else
            Label4.Text = "You made a bad deal"
        End If


    End Sub
    Private Sub btnYourCase_Click(sender As System.Object, e As System.EventArgs) Handles btnYourCase.Click
        btnYourCase.Text = btnYourCase.Tag()
        btnYourCase.Enabled = False
        btnDeal.Enabled = False
        btnNoDeal.Enabled = False
        MessageBox.Show("Game Over")
        Call clear()
        Call resetLabel()
        lblAccepted.Visible = False
        btnYourCase.Text = "Your Case ???"
        intCounterButtons = 0
        btnStart.Enabled = True
        btnStart.Focus()
        btnStart.Text = "Play Again"
        btnStart.Visible = True
    End Sub

#Region "procedures"
    Private Sub enablebuttons()
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
        btn10.Enabled = True
        btn11.Enabled = True
        btn12.Enabled = True
        btn13.Enabled = True
        btn14.Enabled = True
        btn15.Enabled = True
        btn16.Enabled = True
        btn17.Enabled = True
        btn18.Enabled = True
        btn19.Enabled = True
        btn20.Enabled = True
        btn21.Enabled = True
        btn22.Enabled = True
        btn23.Enabled = True
        btn24.Enabled = True
        btn25.Enabled = True
        btn26.Enabled = True
        btn17.Enabled = True

    End Sub
    Private Sub disablebuttons()
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
        btn10.Enabled = False
        btn11.Enabled = False
        btn12.Enabled = False
        btn13.Enabled = False
        btn14.Enabled = False
        btn15.Enabled = False
        btn16.Enabled = False
        btn17.Enabled = False
        btn18.Enabled = False
        btn19.Enabled = False
        btn20.Enabled = False
        btn21.Enabled = False
        btn22.Enabled = False
        btn23.Enabled = False
        btn24.Enabled = False
        btn25.Enabled = False
        btn26.Enabled = False


    End Sub
    Private Sub revealAllCases()
        btn1.Text = btn1.Tag()
        btn2.Text = btn2.Tag()
        btn3.Text = btn3.Tag()
        btn4.Text = btn4.Tag()
        btn5.Text = btn5.Tag()
        btn6.Text = btn6.Tag()
        btn7.Text = btn7.Tag()
        btn8.Text = btn8.Tag()
        btn9.Text = btn9.Tag()
        btn10.Text = btn10.Tag()
        btn11.Text = btn11.Tag()
        btn12.Text = btn12.Tag()
        btn13.Text = btn13.Tag()
        btn14.Text = btn14.Tag()
        btn15.Text = btn15.Tag()
        btn16.Text = btn16.Tag()
        btn17.Text = btn17.Tag()
        btn18.Text = btn18.Tag()
        btn19.Text = btn19.Tag()
        btn20.Text = btn20.Tag()
        btn21.Text = btn21.Tag()
        btn22.Text = btn22.Tag()
        btn23.Text = btn23.Tag()
        btn24.Text = btn24.Tag()
        btn25.Text = btn25.Tag()
        btn26.Text = btn26.Tag()
       


    End Sub
    Private Sub resetBoards()
        dblCase = 0
        btn1.BackColor = Color.Gold
        btn2.BackColor = Color.Gold
        btn3.BackColor = Color.Gold
        btn4.BackColor = Color.Gold
        btn5.BackColor = Color.Gold
        btn6.BackColor = Color.Gold
        btn7.BackColor = Color.Gold
        btn8.BackColor = Color.Gold
        btn9.BackColor = Color.Gold
        btn10.BackColor = Color.Gold
        btn11.BackColor = Color.Gold
        btn12.BackColor = Color.Gold
        btn13.BackColor = Color.Gold
        btn14.BackColor = Color.Gold
        btn15.BackColor = Color.Gold
        btn16.BackColor = Color.Gold
        btn17.BackColor = Color.Gold
        btn18.BackColor = Color.Gold
        btn19.BackColor = Color.Gold
        btn20.BackColor = Color.Gold
        btn21.BackColor = Color.Gold
        btn22.BackColor = Color.Gold
        btn23.BackColor = Color.Gold
        btn24.BackColor = Color.Gold
        btn25.BackColor = Color.Gold
        btn26.BackColor = Color.Gold

        lblPenny.BackColor = Color.Yellow
        lbl1.BackColor = Color.Yellow
        lbl5.BackColor = Color.Yellow
        lbl10.BackColor = Color.Yellow
        lbl25.BackColor = Color.Yellow
        lbl50.BackColor = Color.Yellow
        lbl75.BackColor = Color.Yellow
        lbl100.BackColor = Color.Yellow
        lbl200.BackColor = Color.Yellow
        lbl300.BackColor = Color.Yellow
        lbl400.BackColor = Color.Yellow
        lbl500.BackColor = Color.Yellow
        lbl750.BackColor = Color.Yellow
        lbl1k.BackColor = Color.Yellow
        lbl5k.BackColor = Color.Yellow
        lbl10k.BackColor = Color.Yellow
        lbl25k.BackColor = Color.Yellow
        lbl50k.BackColor = Color.Yellow
        lbl75k.BackColor = Color.Yellow
        lbl100k.BackColor = Color.Yellow
        lbl200k.BackColor = Color.Yellow
        lbl300k.BackColor = Color.Yellow
        lbl400k.BackColor = Color.Yellow
        lbl500k.BackColor = Color.Yellow
        lbl750k.BackColor = Color.Yellow
        lbl1m.BackColor = Color.Yellow

        btn1.Text = "1"
        btn2.Text = "2"
        btn3.Text = "3"
        btn4.Text = "4"
        btn5.Text = "5"
        btn6.Text = "6"
        btn7.Text = "7"
        btn8.Text = "8"
        btn9.Text = "9"
        btn10.Text = "10"
        btn11.Text = "11"
        btn12.Text = "12"
        btn13.Text = "13"
        btn14.Text = "14"
        btn15.Text = "15"
        btn16.Text = "16"
        btn17.Text = "17"
        btn18.Text = "18"
        btn19.Text = "19"
        btn20.Text = "20"
        btn21.Text = "21"
        btn22.Text = "22"
        btn23.Text = "23"
        btn24.Text = "24"
        btn25.Text = "25"
        btn26.Text = "26"
        btnYourCase.Text = "Your Case $"

        ListBox1.Items.Clear()
        lblAccepted.Visible = False
        lblYourCaseValue.Text = "???"

    End Sub


    Private Sub clear()
        lblOffer.Text = ""
    End Sub
#End Region
#Region "counter/round1"
    Private Sub counter()
        Dim intvalue As Integer

        ' Dim dbloffer As Double
        If intCounterButtons = 0 Then
            lblRound.Text = "Round 1"
            lblOpenCase.Visible = True
            lblOpenCase.Text = "Open 6 cases"
            Label5.Text = "Open 6 cases"
        End If
        intCounterButtons += 1

        If intCounterButtons = 7 Then
            Timer1.Enabled = True
            
            btnDeal.Enabled = True
            btnNoDeal.Enabled = True
            lblRound.Text = "Round 2"
            lblOpenCase.Text = "Open 5 cases"
            Label5.Text = "Open 5 more cases"
           
            dblOffer = (dblValue - dblCase) / 100
            '  dblOffer = dblOffer * 0.1
            intvalue = dblOffer / 100
            intvalue = intvalue * 100
            lblOffer.Text = intvalue.ToString("C2")
            ListBox1.Items.Add(intvalue.ToString("C2"))
            ' lblOffer.Text = dbloffer.ToString("C2")

            ' ListBox1.Items.Add(dbloffer.ToString("C2"))
            Label7.Text = frmLogin.strPlayerName & ","

        End If
        If intCounterButtons = 12 Then
            Timer1.Enabled = True
            
            btnDeal.Enabled = True
            btnNoDeal.Enabled = True
            lblRound.Text = "Round 3"
            lblOpenCase.Text = "Open 4 cases"
            Label5.Text = "Open 4 more cases"
            dblOffer = (dblValue - dblCase) / 60
            ' dblOffer = dblOffer * 0.15
            intvalue = dblOffer / 100
            intvalue = intvalue * 100
            lblOffer.Text = intvalue.ToString("C2")
            ListBox1.Items.Add(intvalue.ToString("C2"))

            ' lblOffer.Text = dbloffer.ToString("C2")

            ' ListBox1.Items.Add(dbloffer.ToString("C2"))
            Label7.Text = frmLogin.strPlayerName & ","

        End If
        If intCounterButtons = 16 Then
            Timer1.Enabled = True
            
            btnDeal.Enabled = True
            btnNoDeal.Enabled = True
            lblRound.Text = "Round 4"
            lblOpenCase.Text = "Open 3 cases"
            Label5.Text = "Open 3 more cases"

            dblOffer = (dblValue - dblCase) / 40
            ' dblOffer = dblOffer * 0.2
            intvalue = dblOffer / 100
            intvalue = intvalue * 100
            lblOffer.Text = intvalue.ToString("C2")
            ListBox1.Items.Add(intvalue.ToString("C2"))
            ' lblOffer.Text = dbloffer.ToString("C2")
            ' ListBox1.Items.Add(dbloffer.ToString("C2"))
            Label7.Text = frmLogin.strPlayerName & ","

        End If

        If intCounterButtons = 19 Then
            Timer1.Enabled = True
            
            btnDeal.Enabled = True
            btnNoDeal.Enabled = True
            lblRound.Text = "Round 5"
            lblOpenCase.Text = "Open 2 cases"
            Label5.Text = "Open 2 more cases"

            dblOffer = (dblValue - dblCase) / 25
            '  dblOffer = dblOffer * 0.25
            intvalue = dblOffer / 100
            intvalue = intvalue * 100
            If intvalue = 0.0 Then
                intvalue = 5.0
            End If
            lblOffer.Text = intvalue.ToString("C2")
            ListBox1.Items.Add(intvalue.ToString("C2"))

            ' lblOffer.Text = dbloffer.ToString("C2")

            ' ListBox1.Items.Add(dbloffer.ToString("C2"))
            Label7.Text = frmLogin.strPlayerName & ","

        End If
        If intCounterButtons = 21 Then
            Timer1.Enabled = True
           
            btnDeal.Enabled = True
            btnNoDeal.Enabled = True
            lblRound.Text = "Round 6"
            lblOpenCase.Text = "Open 2 cases"
            Label5.Text = "Open 2 more cases"
            dblOffer = (dblValue - dblCase) / 10
            ' dblOffer = dblOffer * 0.3
            intvalue = dblOffer / 100
            intvalue = intvalue * 100
            If intvalue = 0.0 Then
                intvalue = 5.0
            End If
            lblOffer.Text = intvalue.ToString("C2")
            ListBox1.Items.Add(intvalue.ToString("C2"))

            ' lblOffer.Text = dbloffer.ToString("C2")

            '  ListBox1.Items.Add(dbloffer.ToString("C2"))
            Label7.Text = frmLogin.strPlayerName & ","

        End If
        If intCounterButtons = 23 Then
            Timer1.Enabled = True
            '  Panel1.Visible = True
            '  Panel1.BringToFront()
            btnDeal.Enabled = True
            btnNoDeal.Enabled = True
            lblRound.Text = "Round 7"
            lblOpenCase.Text = "Open 1 case"
            Label5.Text = "Open 1 more case"
            dblOffer = (dblValue - dblCase) / 6
            ' dblOffer = dblOffer * 0.35
            intvalue = dblOffer / 100
            intvalue = intvalue * 100
            If intvalue = 0.0 Then
                intvalue = 5.0
            End If
            lblOffer.Text = intvalue.ToString("C2")
            ListBox1.Items.Add(intvalue.ToString("C2"))
            '  lblOffer.Text = dbloffer.ToString("C2")

            '  ListBox1.Items.Add(dbloffer.ToString("C2"))
            Label7.Text = frmLogin.strPlayerName & ","

        End If
        If intCounterButtons = 24 Then
            Timer1.Enabled = True
            '  Panel1.Visible = True
            '  Panel1.BringToFront()
            btnDeal.Enabled = True
            btnNoDeal.Enabled = True
            lblRound.Text = "Round 8"
            lblOpenCase.Text = "Open 1 case"
            Label5.Text = "Open 1 more case"
            dblOffer = (dblValue - dblCase) / 4
            '  dblOffer = dblOffer * 0.4
            intvalue = dblOffer / 100
            intvalue = intvalue * 100
            If intvalue = 0.0 Then
                intvalue = 5.0
            End If

            lblOffer.Text = intvalue.ToString("C2")
            ListBox1.Items.Add(intvalue.ToString("C2"))

            ' lblOffer.Text = dbloffer.ToString("C2")

            ' ListBox1.Items.Add(dbloffer.ToString("C2"))
            Label7.Text = frmLogin.strPlayerName & ","

        End If
        If intCounterButtons = 25 Then
            Timer1.Enabled = True
            
            btnDeal.Enabled = True
            btnNoDeal.Enabled = True
            lblRound.Text = ""
            intCounterButtons += 1
            dblOffer = (dblValue - dblCase) / 2
            ' dblOffer = dblOffer * 0.45
            intvalue = dblOffer / 100
            intvalue = intvalue * 100
            If intvalue = 0.0 Then
                intvalue = 5.0
            End If
            lblOffer.Text = intvalue.ToString("C2")
            ListBox1.Items.Add(intvalue.ToString("C2"))
            ' lblOffer.Text = dblOffer.ToString("C2")
            Label5.Text = "Final Offer"
            Label4.Visible = False

            ' ListBox1.Items.Add(dblOffer.ToString("C2"))
            btnStart.Enabled = True
            btnStart.Focus()
            btnStart.Select()
            btnStart.Text = "Play Again"
            btnStart.Visible = True
            Label7.Text = ""

        End If
        
    End Sub
    Private Sub roundone()
        lblOpenCase.Visible = True
        lblRound.Text = "Round One"
        lblOpenCase.Text = "Open 6 Cases"
    End Sub
#End Region
#Region "money Labels"
    Private Sub resetLabel()
        lbl1.BackColor = Color.Yellow
        lbl10.BackColor = Color.Yellow
        lbl100.BackColor = Color.Yellow
        lbl1k.BackColor = Color.Yellow
    End Sub
#End Region
#Region "money buttons"

    Private Sub btn20_Click(sender As System.Object, e As System.EventArgs) Handles btn20.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn20.Text
            btn20.BackColor = Color.LightGoldenrodYellow
            btn20.Enabled = False
            Call roundone()

            Call counter()
            btnYourCase.Tag = btn20.Tag()
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn20.Text = btn20.Tag()

            btn20.BackColor = Color.Gray
            btn20.Enabled = False
            If lblPenny.Tag = btn20.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn20.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn20.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn20.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn20.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn20.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn20.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn20.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn20.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn20.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn20.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn20.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn20.Tag Then
                lbl750.BackColor = Color.Gray
            ElseIf lbl1k.Tag = btn20.Tag Then
                lbl1k.BackColor = Color.Gray
           
            ElseIf lbl5k.Tag = btn20.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn20.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn20.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn20.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn20.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn20.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn20.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn20.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn20.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn20.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn20.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn20.Tag Then
                lbl1m.BackColor = Color.Gray

            End If
            'This code after $ display 
            dblCase += btn20.Tag()

            Call counter()


            '   Timer1.Enabled = True
        End If
    End Sub


    Private Sub btn21_Click(sender As System.Object, e As System.EventArgs) Handles btn21.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn21.Text
            btn21.BackColor = Color.LightGoldenrodYellow
            btn21.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn21.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else

            ' If intCounterButtons > 0 Then
            btn21.Text = btn21.Tag()
            btn21.BackColor = Color.Gray
            btn21.Enabled = False
            If lblPenny.Tag = btn21.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn21.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn21.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn21.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn21.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn21.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn21.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn21.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn21.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn21.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn21.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn21.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn21.Tag Then
                lbl750.BackColor = Color.Gray
            
            ElseIf lbl1k.Tag = btn21.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn21.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn21.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn21.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn21.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn21.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn21.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn21.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn21.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn21.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn21.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn21.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn21.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn21.Tag()
            '  Timer1.Enabled = True
            Call counter()
            End If
    End Sub

    Private Sub btn22_Click(sender As System.Object, e As System.EventArgs) Handles btn22.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn22.Text
            btn22.BackColor = Color.LightGoldenrodYellow
            btn22.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn22.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else

            btn22.Text = btn22.Tag()
            btn22.BackColor = Color.Gray
            btn22.Enabled = False
            If lblPenny.Tag = btn22.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn22.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn22.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn22.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn22.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn22.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn22.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn22.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn22.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn22.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn22.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn22.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn22.Tag Then
                lbl750.BackColor = Color.Gray
           
            ElseIf lbl1k.Tag = btn22.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn22.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn22.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn22.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn22.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn22.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn22.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn22.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn22.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn22.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn22.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn22.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn22.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn22.Tag()
            '  Timer1.Enabled = True
            Call counter()

        End If
    End Sub

    Private Sub btn23_Click(sender As System.Object, e As System.EventArgs) Handles btn23.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn23.Text
            btn23.BackColor = Color.LightGoldenrodYellow
            btn23.Enabled = False
            Call roundone()
            Call counter()
            btnYourCase.Tag = btn23.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else


            btn23.Text = btn23.Tag()
            btn23.BackColor = Color.Gray
            btn23.Enabled = False
            If lblPenny.Tag = btn23.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn23.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn23.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn23.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn23.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn23.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn23.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn23.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn23.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn23.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn23.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn23.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn23.Tag Then
                lbl750.BackColor = Color.Gray
           
            ElseIf lbl1k.Tag = btn23.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn23.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn23.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn23.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn23.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn23.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn23.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn23.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn23.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn23.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn23.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn23.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn23.Tag Then
                lbl1m.BackColor = Color.Gray

            End If


            dblCase += btn23.Tag()
            '   Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn24_Click(sender As System.Object, e As System.EventArgs) Handles btn24.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn24.Text
            btn24.BackColor = Color.LightGoldenrodYellow
            btn24.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn24.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn24.Text = btn24.Tag()
            btn24.BackColor = Color.Gray
            btn24.Enabled = False
            If lblPenny.Tag = btn24.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn24.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn24.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn24.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn24.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn24.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn24.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn24.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn24.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn24.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn24.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn24.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn24.Tag Then
                lbl750.BackColor = Color.Gray
            
            ElseIf lbl1k.Tag = btn24.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn24.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn24.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn24.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn24.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn24.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn24.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn24.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn24.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn24.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn24.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn24.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn24.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn24.Tag()
            '  Timer1.Enabled = True
            Call counter()

        End If
    End Sub

    Private Sub btn25_Click(sender As System.Object, e As System.EventArgs) Handles btn25.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn25.Text
            btn25.BackColor = Color.LightGoldenrodYellow
            btn25.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn25.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn25.Text = btn25.Tag()
            btn25.BackColor = Color.Gray
            btn25.Enabled = False

            If lblPenny.Tag = btn25.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn25.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn25.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn25.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn25.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn25.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn25.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn25.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn25.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn25.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn25.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn25.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn25.Tag Then
                lbl750.BackColor = Color.Gray
            
            ElseIf lbl1k.Tag = btn25.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn25.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn25.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn25.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn25.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn25.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn25.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn25.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn25.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn25.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn25.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn25.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn25.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn25.Tag()
            '   Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn26_Click(sender As System.Object, e As System.EventArgs) Handles btn26.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn26.Text
            btn26.BackColor = Color.LightGoldenrodYellow
            btn26.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn26.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else


            btn26.Text = btn26.Tag()
            btn26.BackColor = Color.Gray
            btn26.Enabled = False
            If lblPenny.Tag = btn26.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn26.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn26.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn26.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn26.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn26.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn26.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn26.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn26.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn26.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn26.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn26.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn26.Tag Then
                lbl750.BackColor = Color.Gray
            
            ElseIf lbl1k.Tag = btn26.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn26.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn26.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn26.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn26.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn26.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn26.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn26.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn26.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn26.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn26.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn26.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn26.Tag Then
                lbl1m.BackColor = Color.Gray

            End If


            dblCase += btn26.Tag()
            '   Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn13_Click(sender As System.Object, e As System.EventArgs) Handles btn13.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn13.Text
            btn13.BackColor = Color.LightGoldenrodYellow
            btn13.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn13.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn13.Text = btn13.Tag()
            btn13.BackColor = Color.Gray
            btn13.Enabled = False

            If lblPenny.Tag = btn13.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn13.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn13.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn13.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn13.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn13.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn13.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn13.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn13.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn13.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn13.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn13.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn13.Tag Then
                lbl750.BackColor = Color.Gray
            
            ElseIf lbl1k.Tag = btn13.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn13.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn13.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn13.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn13.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn13.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn13.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn13.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn13.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn13.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn13.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn13.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn13.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn13.Tag()
            '   Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn14_Click(sender As System.Object, e As System.EventArgs) Handles btn14.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn14.Text
            btn14.BackColor = Color.LightGoldenrodYellow
            btn14.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn14.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn14.Text = btn14.Tag()
            btn14.BackColor = Color.Gray
            btn14.Enabled = False
            If lblPenny.Tag = btn14.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn14.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn14.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn14.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn14.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn14.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn14.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn14.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn14.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn14.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn14.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn14.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn14.Tag Then
                lbl750.BackColor = Color.Gray
            
            ElseIf lbl1k.Tag = btn14.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn14.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn14.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn14.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn14.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn14.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn14.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn14.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn14.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn14.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn14.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn14.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn14.Tag Then
                lbl1m.BackColor = Color.Gray

            End If


            dblCase += btn14.Tag()
            '   Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn15_Click(sender As System.Object, e As System.EventArgs) Handles btn15.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn15.Text
            btn15.BackColor = Color.LightGoldenrodYellow
            btn15.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn15.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn15.Text = btn15.Tag()
            btn15.BackColor = Color.Gray
            btn15.Enabled = False
            If lblPenny.Tag = btn15.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn15.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn15.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn15.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn15.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn15.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn15.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn15.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn15.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn15.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn15.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn15.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn15.Tag Then
                lbl750.BackColor = Color.Gray
           
            ElseIf lbl1k.Tag = btn15.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn15.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn15.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn15.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn15.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn15.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn15.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn15.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn15.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn15.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn15.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn15.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn15.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn15.Tag()
            '   Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn16_Click(sender As System.Object, e As System.EventArgs) Handles btn16.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn16.Text
            btn16.BackColor = Color.LightGoldenrodYellow
            btn16.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn16.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else

            btn16.Text = btn16.Tag()
            btn16.BackColor = Color.Gray
            btn16.Enabled = False
            If lblPenny.Tag = btn16.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn16.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn16.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn16.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn16.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn16.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn16.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn16.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn16.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn16.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn16.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn16.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn16.Tag Then
                lbl750.BackColor = Color.Gray
           
            ElseIf lbl1k.Tag = btn16.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn16.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn16.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn16.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn16.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn16.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn16.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn16.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn16.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn16.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn16.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn16.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn16.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn16.Tag()
            '  Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn17_Click(sender As System.Object, e As System.EventArgs) Handles btn17.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn17.Text
            btn17.BackColor = Color.LightGoldenrodYellow
            btn17.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn17.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn17.Text = btn17.Tag()
            btn17.BackColor = Color.Gray
            btn17.Enabled = False
            If lblPenny.Tag = btn17.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn17.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn17.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn17.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn17.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn17.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn17.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn17.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn17.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn17.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn17.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn17.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn17.Tag Then
                lbl750.BackColor = Color.Gray
           
            ElseIf lbl1k.Tag = btn17.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn17.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn17.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn17.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn17.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn17.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn17.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn17.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn17.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn17.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn17.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn17.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn17.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn17.Tag()
            '    Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn18_Click(sender As System.Object, e As System.EventArgs) Handles btn18.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn18.Text
            btn18.BackColor = Color.LightGoldenrodYellow
            btn18.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn18.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn18.Text = btn18.Tag()
            btn18.BackColor = Color.Gray
            btn18.Enabled = False
            If lblPenny.Tag = btn18.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn18.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn18.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn18.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn18.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn18.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn18.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn18.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn18.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn18.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn18.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn18.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn18.Tag Then
                lbl750.BackColor = Color.Gray
            
            ElseIf lbl1k.Tag = btn18.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn18.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn18.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn18.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn18.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn18.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn18.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn18.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn18.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn18.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn18.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn18.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn18.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn18.Tag()
            '   Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn19_Click(sender As System.Object, e As System.EventArgs) Handles btn19.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn19.Text
            btn19.BackColor = Color.LightGoldenrodYellow
            btn19.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn19.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn19.Text = btn19.Tag()
            btn19.BackColor = Color.Gray
            btn19.Enabled = False

            If lblPenny.Tag = btn19.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn19.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn19.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn19.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn19.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn19.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn19.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn19.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn19.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn19.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn19.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn19.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn19.Tag Then
                lbl750.BackColor = Color.Gray
            
            ElseIf lbl1k.Tag = btn19.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn19.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn19.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn19.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn19.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn19.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn19.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn19.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn19.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn19.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn19.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn19.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn19.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn19.Tag()
            '    Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn7_Click(sender As System.Object, e As System.EventArgs) Handles btn7.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn7.Text
            btn7.BackColor = Color.LightGoldenrodYellow
            btn7.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn7.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn7.Text = btn7.Tag()
            btn7.BackColor = Color.Gray
            btn7.Enabled = False
            If lblPenny.Tag = btn7.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn7.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn7.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn7.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn7.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn7.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn7.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn7.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn7.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn7.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn7.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn7.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn7.Tag Then
                lbl750.BackColor = Color.Gray
            
            ElseIf lbl1k.Tag = btn7.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn7.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn7.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn7.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn7.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn7.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn7.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn7.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn7.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn7.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn7.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn7.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn7.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn7.Tag()
            '    Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn8_Click(sender As System.Object, e As System.EventArgs) Handles btn8.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn8.Text
            btn8.BackColor = Color.LightGoldenrodYellow
            btn8.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn8.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn8.Text = btn8.Tag()
            btn8.BackColor = Color.Gray
            btn8.Enabled = False
            If lblPenny.Tag = btn8.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn8.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn8.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn8.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn8.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn8.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn8.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn8.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn8.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn8.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn8.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn8.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn8.Tag Then
                lbl750.BackColor = Color.Gray
            ElseIf lbl1k.Tag = btn8.Tag Then
                lbl1k.BackColor = Color.Gray

            ElseIf lbl5k.Tag = btn8.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn8.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn8.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn8.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn8.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn8.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn8.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn8.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn8.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn8.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn8.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn8.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn8.Tag()
            '    Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn9_Click(sender As System.Object, e As System.EventArgs) Handles btn9.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn9.Text
            btn9.BackColor = Color.LightGoldenrodYellow
            btn9.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn9.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn9.Text = btn9.Tag()
            btn9.BackColor = Color.Gray
            btn9.Enabled = False
            If lblPenny.Tag = btn9.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn9.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn9.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn9.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn9.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn9.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn9.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn9.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn9.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn9.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn9.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn9.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn9.Tag Then
                lbl750.BackColor = Color.Gray
            
            ElseIf lbl1k.Tag = btn9.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn9.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn9.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn9.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn9.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn9.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn9.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn9.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn9.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn9.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn9.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn9.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn9.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn9.Tag()
            '    Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn10_Click(sender As System.Object, e As System.EventArgs) Handles btn10.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn10.Text
            btn10.BackColor = Color.LightGoldenrodYellow
            btn10.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn10.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn10.Text = btn10.Tag()
            btn10.BackColor = Color.Gray
            btn10.Enabled = False
            If lblPenny.Tag = btn10.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn10.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn10.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn10.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn10.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn10.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn10.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn10.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn10.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn10.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn10.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn10.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn10.Tag Then
                lbl750.BackColor = Color.Gray
            
            ElseIf lbl1k.Tag = btn10.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn10.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn10.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn10.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn10.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn10.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn10.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn10.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn10.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn10.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn10.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn10.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn10.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn10.Tag()
            '     Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn11_Click(sender As System.Object, e As System.EventArgs) Handles btn11.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn11.Text
            btn11.BackColor = Color.LightGoldenrodYellow
            btn11.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn11.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn11.Text = btn11.Tag()
            btn11.BackColor = Color.Gray
            btn11.Enabled = False
            If lblPenny.Tag = btn11.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn11.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn11.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn11.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn11.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn11.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn11.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn11.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn11.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn11.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn11.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn11.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn11.Tag Then
                lbl750.BackColor = Color.Gray
           
            ElseIf lbl1k.Tag = btn11.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn11.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn11.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn11.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn11.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn11.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn11.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn11.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn11.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn11.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn11.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn11.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn11.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn11.Tag()
            '   Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn12_Click(sender As System.Object, e As System.EventArgs) Handles btn12.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn12.Text
            btn12.BackColor = Color.LightGoldenrodYellow
            btn12.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn12.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else

            btn12.Text = btn12.Tag()
            btn12.BackColor = Color.Gray
            btn12.Enabled = False
            If lblPenny.Tag = btn12.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn12.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn12.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn12.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn12.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn12.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn12.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn12.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn12.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn12.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn12.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn12.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn12.Tag Then
                lbl750.BackColor = Color.Gray
           
            ElseIf lbl1k.Tag = btn12.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn12.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn12.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn12.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn12.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn12.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn12.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn12.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn12.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn12.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn12.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn12.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn12.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn12.Tag()
            '     Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn1.Text
            btn1.BackColor = Color.LightGoldenrodYellow
            btn1.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn1.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn1.Text = btn1.Tag()
            btn1.BackColor = Color.Gray
            btn1.Enabled = False
            If lblPenny.Tag = btn1.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn1.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn1.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn1.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn1.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn1.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn1.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn1.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn1.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn1.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn1.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn1.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn1.Tag Then
                lbl750.BackColor = Color.Gray
            
            ElseIf lbl1k.Tag = btn1.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn1.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn1.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn1.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn1.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn1.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn1.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn1.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn1.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn1.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn1.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn1.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn1.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn1.Tag()
            '     Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn2.Text
            btn2.BackColor = Color.LightGoldenrodYellow
            btn2.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn2.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn2.Text = btn2.Tag()
            btn2.BackColor = Color.Gray
            btn2.Enabled = False
            If lblPenny.Tag = btn2.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn2.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn2.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn2.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn2.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn2.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn2.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn2.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn2.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn2.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn2.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn2.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn2.Tag Then
                lbl750.BackColor = Color.Gray
           
            ElseIf lbl1k.Tag = btn2.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn2.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn2.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn2.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn2.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn2.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn2.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn2.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn2.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn2.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn2.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn2.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn2.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn2.Tag()
            '       Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btn3.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn3.Text
            btn3.BackColor = Color.LightGoldenrodYellow
            btn3.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn3.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn3.Text = btn3.Tag()
            btn3.BackColor = Color.Gray
            btn3.Enabled = False
            If lblPenny.Tag = btn3.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn3.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn3.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn3.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn3.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn3.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn3.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn3.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn3.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn3.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn3.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn3.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn3.Tag Then
                lbl750.BackColor = Color.Gray
            
            ElseIf lbl1k.Tag = btn3.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn3.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn3.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn3.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn3.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn3.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn3.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn3.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn3.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn3.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn3.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn3.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn3.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn3.Tag()
            '     Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn4_Click(sender As System.Object, e As System.EventArgs) Handles btn4.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn4.Text
            btn4.BackColor = Color.LightGoldenrodYellow
            btn4.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn4.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn4.Text = btn4.Tag()
            btn4.BackColor = Color.Gray
            btn4.Enabled = False
            If lblPenny.Tag = btn4.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn4.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn4.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn4.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn4.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn4.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn4.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn4.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn4.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn4.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn4.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn4.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn4.Tag Then
                lbl750.BackColor = Color.Gray
            ElseIf lbl1k.Tag = btn4.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl1k.Tag = btn4.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn4.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn4.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn4.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn4.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn4.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn4.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn4.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn4.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn4.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn4.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn4.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn4.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn4.Tag()
            '     Timer1.Enabled = True
            Call counter()
        End If
    End Sub

    Private Sub btn5_Click(sender As System.Object, e As System.EventArgs) Handles btn5.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn5.Text
            btn5.BackColor = Color.LightGoldenrodYellow
            btn5.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn5.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn5.Text = btn5.Tag()
            btn5.BackColor = Color.Gray
            btn5.Enabled = False
            If lblPenny.Tag = btn5.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn5.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn5.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn5.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn5.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn5.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn5.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn5.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn5.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn5.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn5.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn5.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn5.Tag Then
                lbl750.BackColor = Color.Gray
            
            ElseIf lbl1k.Tag = btn5.Tag Then
                lbl1k.BackColor = Color.Gray
            ElseIf lbl5k.Tag = btn5.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn5.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn5.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn5.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn5.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn5.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn5.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn5.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn5.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn5.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn5.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn5.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn5.Tag()
            '   Timer1.Enabled = True
            Call counter()

        End If
    End Sub

    Private Sub btn6_Click(sender As System.Object, e As System.EventArgs) Handles btn6.Click
        If intCounterButtons = 0 Then
            btnYourCase.Text = btn6.Text
            btn6.BackColor = Color.LightGoldenrodYellow
            btn6.Enabled = False
            Call roundone()
            Call counter()

            btnYourCase.Tag = btn6.Tag
            btnYourCase.Visible = True
            Label3.Text = frmLogin.strPlayerName & ", you chose case # " & btnYourCase.Text
        Else
            btn6.Text = btn6.Tag()
            btn6.BackColor = Color.Gray
            btn6.Enabled = False
            If lblPenny.Tag = btn6.Tag Then
                lblPenny.BackColor = Color.Gray
            ElseIf lbl1.Tag = btn6.Tag Then
                lbl1.BackColor = Color.Gray
            ElseIf lbl5.Tag = btn6.Tag Then
                lbl5.BackColor = Color.Gray
            ElseIf lbl10.Tag = btn6.Tag Then
                lbl10.BackColor = Color.Gray
            ElseIf lbl25.Tag = btn6.Tag Then
                lbl25.BackColor = Color.Gray
            ElseIf lbl50.Tag = btn6.Tag Then
                lbl50.BackColor = Color.Gray
            ElseIf lbl75.Tag = btn6.Tag Then
                lbl75.BackColor = Color.Gray
            ElseIf lbl100.Tag = btn6.Tag Then
                lbl100.BackColor = Color.Gray
            ElseIf lbl200.Tag = btn6.Tag Then
                lbl200.BackColor = Color.Gray
            ElseIf lbl300.Tag = btn6.Tag Then
                lbl300.BackColor = Color.Gray
            ElseIf lbl400.Tag = btn6.Tag Then
                lbl400.BackColor = Color.Gray
            ElseIf lbl500.Tag = btn6.Tag Then
                lbl500.BackColor = Color.Gray
            ElseIf lbl750.Tag = btn6.Tag Then
                lbl750.BackColor = Color.Gray
            ElseIf lbl1k.Tag = btn6.Tag Then
                lbl1k.BackColor = Color.Gray
            
            ElseIf lbl5k.Tag = btn6.Tag Then
                lbl5k.BackColor = Color.Gray
            ElseIf lbl10k.Tag = btn6.Tag Then
                lbl10k.BackColor = Color.Gray
            ElseIf lbl25k.Tag = btn6.Tag Then
                lbl25k.BackColor = Color.Gray
            ElseIf lbl50k.Tag = btn6.Tag Then
                lbl50k.BackColor = Color.Gray
            ElseIf lbl75k.Tag = btn6.Tag Then
                lbl75k.BackColor = Color.Gray
            ElseIf lbl100k.Tag = btn6.Tag Then
                lbl100k.BackColor = Color.Gray
            ElseIf lbl200k.Tag = btn6.Tag Then
                lbl200k.BackColor = Color.Gray
            ElseIf lbl300k.Tag = btn6.Tag Then
                lbl300k.BackColor = Color.Gray
            ElseIf lbl400k.Tag = btn6.Tag Then
                lbl400k.BackColor = Color.Gray
            ElseIf lbl500k.Tag = btn6.Tag Then
                lbl500k.BackColor = Color.Gray
            ElseIf lbl750k.Tag = btn6.Tag Then
                lbl750k.BackColor = Color.Gray
            ElseIf lbl1m.Tag = btn6.Tag Then
                lbl1m.BackColor = Color.Gray

            End If

            dblCase += btn6.Tag()
            '     Timer1.Enabled = True
            Call counter()
        End If
    End Sub


    
#End Region

   
    Sub ShuffleArrayInPlace(InArray() As Object)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' ShuffleArrayInPlace
        ' This shuffles InArray to random order, randomized in place.
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim N As Long
        Dim Temp As Object
        Dim J As Long

        Randomize()
        For N = LBound(InArray) To UBound(InArray)
            J = CLng(((UBound(InArray) - N) * Rnd) + N)
            If N <> J Then
                Temp = InArray(N)
                InArray(N) = InArray(J)
                InArray(J) = Temp
            End If
        Next N
    End Sub
    


#Region "Menubar"

    Private Sub QuitGameToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles QuitGameToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NewGameToolStripMenuItem.Click
        Label3.Text = ""
        btnStart_Click(sender, e)

    End Sub
#End Region

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim t As New Timer()
        Timer1.Interval = 750
        ' Timer1.Enabled = True
        Panel1.Visible = False
        Panel1.SendToBack()
        Timer1.Enabled = False
        Panel1.Visible = True
        Panel1.BringToFront()
        ' Call counter()

    End Sub
End Class
