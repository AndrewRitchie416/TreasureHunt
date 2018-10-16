'Name: Andrew Ritchie
'Student #: 21800567
'Version 1.8
'Date: 25/09/2018
Public Class scrn1

    'Declaring Name and Numbers
    Dim Name As String
    Dim numbers = New Integer() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}

'Intro screen requires player to enter name before beginning
    Private Sub scrn1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnHuntAgain.Visible = False
        btnHunt.Visible = False
        txtLocation.Visible = False
        lblSelectTreasure.Visible = False
    End Sub



    'Takes and stores the user's name.  Re-arranges screen for Hunt.
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Name = txtName.Text
        lblDisplay.Text = "Welcome " + Name + ". Enter your guess."
        lblEnterName.Visible = False
        lblWouldYou.Visible = False
        txtName.Visible = False
        btnHuntAgain.Visible = False
        btnPlay.Visible = False
        btnHunt.Visible = True
        txtLocation.Visible = True
        lblSelectTreasure.Visible = True
    End Sub

    'Calculating if the user's guess finds a jewel
    Private Sub btnHunt_Click(sender As Object, e As EventArgs) Handles btnHunt.Click
        btnHuntAgain.Visible = True
        btnPlay.Visible = False
        Dim Count As Integer = 0

        If txtLocation.Text > 20 Then
            lblDisplay.Text = "Please enter a number between 1 - 20"
        End If



        If txtLocation.Text = "1" Then
            txtLocation.Text = ""
            lblJewel1.Visible = True
            lblDisplay.Text = " JEWEL !"
            lblCounter.Text = Val(lblCounter.Text) + 1
        End If

        If txtLocation.Text = "2" Then
            txtLocation.Text = ""
            lblNoJewel1.Visible = True
            lblDisplay.Text = " MISSED !"
        End If

        If txtLocation.Text = "3" Then
            txtLocation.Text = ""
            lblJewel2.Visible = True
            lblDisplay.Text = " JEWEL !"
            lblCounter.Text = Val(lblCounter.Text) + 1
        End If

        If txtLocation.Text = "4" Then
            txtLocation.Text = ""
            lblNoJewel2.Visible = True
            lblDisplay.Text = " MISSED !"
        End If

        If txtLocation.Text = "5" Then
            txtLocation.Text = ""
            lblNoJewel3.Visible = True
            lblDisplay.Text = " MISSED !"
        End If

        If txtLocation.Text = "6" Then
            txtLocation.Text = ""
            lblNoJewel4.Visible = True
            lblDisplay.Text = " MISSED !"
        End If

        If txtLocation.Text = "7" Then
            txtLocation.Text = ""
            lblNoJewel5.Visible = True
            lblDisplay.Text = " MISSED !"
        End If

        If txtLocation.Text = "8" Then
            txtLocation.Text = ""
            lblJewel3.Visible = True
            lblDisplay.Text = " JEWEL !"
            lblCounter.Text = Val(lblCounter.Text) + 1
        End If

        If txtLocation.Text = "9" Then
            txtLocation.Text = ""
            lblJewel4.Visible = True
            lblDisplay.Text = " JEWEL !"
            lblCounter.Text = Val(lblCounter.Text) + 1
        End If

        If txtLocation.Text = "10" Then
            txtLocation.Text = ""
            lblNoJewel6.Visible = True
            lblDisplay.Text = " MISSED !"
        End If

        If txtLocation.Text = "11" Then
            txtLocation.Text = ""
            lblNoJewel7.Visible = True
            lblDisplay.Text = " MISSED !"
        End If

        If txtLocation.Text = "12" Then
            txtLocation.Text = ""
            lblNoJewel8.Visible = True
            lblDisplay.Text = " MISSED !"
        End If

        If txtLocation.Text = "13" Then
            txtLocation.Text = ""
            lblJewel5.Visible = True
            lblDisplay.Text = " JEWEL !"
            lblCounter.Text = Val(lblCounter.Text) + 1
        End If

        If txtLocation.Text = "14" Then
            txtLocation.Text = ""
            lblNoJewel9.Visible = True
            lblDisplay.Text = " MISSED !"
        End If

        If txtLocation.Text = "15" Then
            txtLocation.Text = ""
            lblNoJewel10.Visible = True
            lblDisplay.Text = " MISSED !"
        End If

        If txtLocation.Text = "16" Then
            txtLocation.Text = ""
            lblNoJewel11.Visible = True
            lblDisplay.Text = " MISSED !"
        End If

        If txtLocation.Text = "17" Then
            txtLocation.Text = ""
            lblJewel6.Visible = True
            lblDisplay.Text = " JEWEL !"
            lblCounter.Text = Val(lblCounter.Text) + 1
        End If

        If txtLocation.Text = "18" Then
            txtLocation.Text = ""
            lblNoJewel12.Visible = True
            lblDisplay.Text = " MISSED !"
        End If

        If txtLocation.Text = "19" Then
            txtLocation.Text = ""
            lblNoJewel13.Visible = True
            lblDisplay.Text = " MISSED !"
        End If

        If txtLocation.Text = "20" Then
            txtLocation.Text = ""
            lblJewel7.Visible = True
            lblDisplay.Text = "JEWEL !"
            lblCounter.Text = Val(lblCounter.Text) + 1
        End If

        If lblCounter.Text = "7" Then
            lblDisplay.Text = "CONGRATULATIONS! YOU WIN!"
            btnHunt.Visible = False

        End If
    End Sub


    'Allows User to start a new game
    Private Sub btnHuntAgain_Click(sender As Object, e As EventArgs) Handles btnHuntAgain.Click
        lblDisplay.Text = "Welcome " + Name + ". Enter your guess."
        btnPlay.Visible = False
        btnHuntAgain.Visible = False
        lblCounter.Text = 0


        lblJewel1.Visible = False
        lblJewel2.Visible = False
        lblJewel3.Visible = False
        lblJewel4.Visible = False
        lblJewel5.Visible = False
        lblJewel6.Visible = False
        lblJewel7.Visible = False
        lblNoJewel1.Visible = False
        lblNoJewel2.Visible = False
        lblNoJewel3.Visible = False
        lblNoJewel4.Visible = False
        lblNoJewel5.Visible = False
        lblNoJewel6.Visible = False
        lblNoJewel7.Visible = False
        lblNoJewel8.Visible = False
        lblNoJewel9.Visible = False
        lblNoJewel10.Visible = False
        lblNoJewel11.Visible = False
        lblNoJewel12.Visible = False
        lblNoJewel13.Visible = False

    End Sub

    'Button to close the application
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub


End Class
