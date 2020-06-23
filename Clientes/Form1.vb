

Public Class Form1

    Dim gripe As String = "Fiebre Tos Dolor de garganta"


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub


    ' Private Sub Button1_Click(sender As Object, e As EventArgs)
    'For i = 0 To TxtLista.SelectedItems.Count - 1
    '  ListaBox2.Items.Add(TxtLista.SelectedItems(i))
    '  TxtLista.Items.Remove(TxtLista.SelectedItems(i))
    '   Next
    ' End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtLista_DoubleClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        '  For i = 0 To ListaBox2.SelectedItems.Count - 1
        '  TxtLista.Items.Add(ListaBox2.SelectedItems(i))
        ' ListaBox2.Items.Remove(ListaBox2.SelectedItems(i))
        ' Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim gripe() As String = {"Fiebre", "Tos", "Llagas"}

        ListBox1.Items.Clear()

        Dim cont As Integer = 0

        For i = 0 To Sintomas.Items.Count - 1

            Dim ItemStr As String = CType(Sintomas.Items(i), String)
            If Sintomas.GetItemChecked(i) Then
                TextBox1.Text = ItemStr
                cont = cont + 1
                TextBox1.Text = cont
                ListBox1.Items.Add(ItemStr)


            End If



        Next
        For x = 0 To ListBox1.Items.Count - 1
            If ListBox1.Items(x) = "Fiebre" Then
                Label4.Text = "Deacuerdo a sus sintomas usted puede tener Gripe "
            End If
            If ListBox1.Items(x) = "Fatiga" Then
                Label4.Text = "Deacuerdo a sus sintomas usted podria tener Gripe "
            End If
            If ListBox1.Items(x) = "Diarrea" Then
                Label4.Text = "Deacuerdo a sus sintomas usted puede tener problemas hepaticos "
            End If
            If cont = 6 Then
                Label4.Text = "Usted tiene muchos sintomas deberia consultar un medico urgentemente"

            End If
            If ListBox1.Items(x) = "Dificultad para respirar" Then
                Label4.Text = "Deacuerdo a sus sintomas usted puede tener Asma o Gripe"


            End If
                If ListBox1.Items(x) = "Dificultad para respirar" Then
                Label4.Text = "Deacuerdo a sus sintomas usted puede tener Asma o Gripe"

            End If
            If ListBox1.Items(x) = "Dolor de garganta" Then
                Label4.Text = "Deacuerdo a sus sintomas usted puede tener llagas"

            End If
            If ListBox1.Items(x) = "Vomitos" Then
                Label4.Text = "Deacuerdo a sus sintomas usted puede tener problemas hepaticos "
            End If
            If ListBox1.Items(x) = "Tos" Then
                Label4.Text = "Deacuerdo a sus sintomas usted puede tener gripe o llagas"

            End If
            If ListBox1.Items(x) = "Mareos" Then
                Label4.Text = "Deacuerdo a sus sintomas usted puede tener falta de azucar"

            End If
            If ListBox1.Items(x) = "Debilidad general" Then
                Label4.Text = "Puede tener falta de azucar o por tener una gripe"

            End If
            If cont = 2 Then
                Label4.Text = "Deacuerdo a sus sintomas usted puede tener algun tipo de gripe consulte al medico"

            End If
            If cont = 4 Then
                Label4.Text = "Deacuerdo a sus sintomas usted puede tener Diabetes"

            End If
            If cont = 5 Then
                Label4.Text = "Deacuerdo a sus sintomas usted puede tener Neumonia"

            End If
        Next



    End Sub
    Private Sub respaldo()
        Dim cont As Integer = 0
        If cont = 1 Then
            Label4.Text = "Deacuerdo a sus sintomas usted puede tener Gripe "

        End If
        If cont = 2 Then
            Label4.Text = "Deacuerdo a sus sintomas usted puede tener Estres o alguna enfermedad Hepatica"

        End If
        If cont = 3 Then
            Label4.Text = "Deacuerdo a sus sintomas usted puede tener Asma o Gripe"

        End If
        If cont = 4 Then
            Label4.Text = "Deacuerdo a sus sintomas usted puede tener Diabetes"

        End If
        If cont = 5 Then
            Label4.Text = "Deacuerdo a sus sintomas usted puede tener Neumonia"

        End If
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
