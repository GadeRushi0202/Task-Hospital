Imports System.Configuration
Imports System.Data.SqlClient

Public Class FrmPtTypewiseDisc
    'Private connectionString As String
    ' Retrieve the connection string from App.config
    Dim connectionString = ConfigurationManager.ConnectionStrings("DbConnection").ConnectionString
    Private Sub FrmPtTypewiseDisc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCmbPtTypeWiseDisc()
        LoadDgvPtTypeWiseDisc()
        ' Set Active checkbox checked by default
        chkIsActive.Checked = True
    End Sub
    Private Sub LoadCmbPtTypeWiseDisc()
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("get_trn_ActivePtTypes", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()

            Try
                con.Open()
                adapter.Fill(table)

                ' Bind the data to the ComboBox
                cmbPtTypeWiseDiscount.DataSource = table
                cmbPtTypeWiseDiscount.DisplayMember = "PtType"
                cmbPtTypeWiseDiscount.ValueMember = "PtTypeId"
                cmbPtTypeWiseDiscount.SelectedIndex = -1 ' No selection by default
            Catch ex As Exception
                MessageBox.Show("An error occurred while loading data: " & ex.Message)
            End Try
        End Using
    End Sub
    Dim opIpType As Boolean

    Private Sub rbtnOPD_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnOPD.CheckedChanged
        opIpType = rbtnOPD.Checked
    End Sub

    Private Sub rbtnIPD_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnIPD.CheckedChanged
        opIpType = Not rbtnIPD.Checked
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Check if a PtType is selected
        If cmbPtTypeWiseDiscount.SelectedIndex = -1 Then
            MessageBox.Show("Please select a PtType.")
            Return
        End If

        ' Check if a valid discount value is entered
        Dim discountValue As Integer
        If Not Integer.TryParse(txtDiscount.Text, discountValue) Then
            MessageBox.Show("Please enter a valid discount value.")
            Return
        End If

        ' Check if either OPD or IPD is selected
        If Not rbtnOPD.Checked AndAlso Not rbtnIPD.Checked Then
            MessageBox.Show("Please select either OPD or IPD.")
            Return
        End If

        ' Validate Active/Deactive selection
        If Not (chkIsActive.Checked Or chkIsDeactive.Checked) Then
            MessageBox.Show("Please select at least one status: Active or Deactive.")
            Return
        End If

        ' Get selected values
        Dim selectedPtTypeId As Integer = CInt(cmbPtTypeWiseDiscount.SelectedValue)
        Dim isActive As Boolean = chkIsActive.Checked
        Dim opIpType As Boolean = rbtnOPD.Checked ' OPD is true, IPD is false

        Using con As New SqlConnection(connectionString)
            ' Validate if the combination of OpIpType and PtTypeId already exists
            Dim validationCmd As New SqlCommand("check_trn_PtTypeWiseDiscountExists", con)
            validationCmd.CommandType = CommandType.StoredProcedure
            validationCmd.Parameters.AddWithValue("@OpIpType", opIpType)
            validationCmd.Parameters.AddWithValue("@PtTypeId", selectedPtTypeId)

            Try
                con.Open()
                Dim count As Integer = Convert.ToInt32(validationCmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("The same PtType and Op-Ip Type combination already exists. Please use a unique combination.")
                    Return
                End If

                ' If validation passes, insert the record
                Dim insertCmd As New SqlCommand("inst_trn_PtTypeWiseDiscountMaster", con)
                insertCmd.CommandType = CommandType.StoredProcedure
                insertCmd.Parameters.AddWithValue("@OpIpType", opIpType)
                insertCmd.Parameters.AddWithValue("@PtTypeId", selectedPtTypeId)
                insertCmd.Parameters.AddWithValue("@Discount", discountValue)
                insertCmd.Parameters.AddWithValue("@IsActive", If(isActive, 1, 0))

                Dim result As Integer = insertCmd.ExecuteNonQuery()

                If result > 0 Then
                    MessageBox.Show("Data inserted successfully.")
                    LoadDgvPtTypeWiseDisc()
                Else
                    MessageBox.Show("Data insertion failed.")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub
    Private Sub LoadDgvPtTypeWiseDisc()
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("get_trn_PtTypeWiseDiscountList", con)
            cmd.CommandType = CommandType.StoredProcedure
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()

            Try
                con.Open()
                adapter.Fill(table)

                ' Add "Sr.No" column
                table.Columns.Add("Sr.No", GetType(Integer))
                For i As Integer = 0 To table.Rows.Count - 1
                    table.Rows(i)("Sr.No") = i + 1
                Next

                dgvPtTypeWiseDiscount.DataSource = table

                ' Set display order and visibility of columns
                dgvPtTypeWiseDiscount.Columns("Sr.No").DisplayIndex = 0
                dgvPtTypeWiseDiscount.Columns("Id").Visible = False
                dgvPtTypeWiseDiscount.Columns("PtTypeId").Visible = False

                dgvPtTypeWiseDiscount.Columns("Sr.No").ReadOnly = True
                dgvPtTypeWiseDiscount.Columns("OpIpType").ReadOnly = True
                dgvPtTypeWiseDiscount.Columns("PatientType").ReadOnly = True
                dgvPtTypeWiseDiscount.Columns("Discount").ReadOnly = True
                dgvPtTypeWiseDiscount.Columns("IsActive").ReadOnly = True

                dgvPtTypeWiseDiscount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub
    Private selectedPtTypeId As Integer
    Private Sub dgvPtTypeWiseDiscount_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPtTypeWiseDiscount.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvPtTypeWiseDiscount.Rows(e.RowIndex)
            btnUpdate.Enabled = True
            btnSave.Enabled = False
            Dim ptTypeId As Object = selectedRow.Cells("PtTypeId").Value
            If ptTypeId IsNot Nothing AndAlso IsNumeric(ptTypeId) Then
                cmbPtTypeWiseDiscount.SelectedValue = Convert.ToInt32(ptTypeId)
            Else
                MessageBox.Show("Invalid Patient Type ID.")
                Return
            End If

            selectedPtTypeId = CInt(selectedRow.Cells("Id").Value)

            Dim opIpTypeValue As Object = selectedRow.Cells("OpIpType").Value
            If opIpTypeValue IsNot Nothing Then
                If opIpTypeValue.ToString() = "OPD" Then
                    rbtnOPD.Checked = True
                    rbtnIPD.Checked = False
                ElseIf opIpTypeValue.ToString() = "IPD" Then
                    rbtnOPD.Checked = False
                    rbtnIPD.Checked = True
                End If
            End If

            Dim discountValue As Object = selectedRow.Cells("Discount").Value
            If discountValue IsNot Nothing Then
                txtDiscount.Text = Convert.ToString(discountValue)
            End If

            ' Handle Active/Deactive checkbox selection
            Dim isActiveValue As Object = selectedRow.Cells("IsActive").Value
            If isActiveValue IsNot DBNull.Value Then
                Dim isActive As Boolean = Convert.ToBoolean(isActiveValue)
                chkIsActive.Checked = isActive
                chkIsDeactive.Checked = Not isActive
            Else
                chkIsActive.Checked = False
                chkIsDeactive.Checked = False
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedPtTypeId = 0 Then
            MessageBox.Show("Please select a record to update.")
            Return
        End If
        If Not (chkIsActive.Checked Or chkIsDeactive.Checked) Then
            MessageBox.Show("Please select at least one status: Active or Deactive.")
            Return
        End If

        Dim opIpType As Boolean = rbtnOPD.Checked
        Dim ptTypeId As Integer
        Dim discountValue As Integer

        If cmbPtTypeWiseDiscount.SelectedValue IsNot Nothing Then
            ptTypeId = Convert.ToInt32(cmbPtTypeWiseDiscount.SelectedValue)
        Else
            MessageBox.Show("Please select a valid PtType from the ComboBox.")
            Return
        End If

        If Not Integer.TryParse(txtDiscount.Text, discountValue) Then
            MessageBox.Show("Please enter a valid discount value.")
            Return
        End If

        Using con As New SqlConnection(connectionString)
            Try
                con.Open()

                ' Check for duplicates only if the status is Active
                If chkIsActive.Checked Then
                    Dim validationCmd As New SqlCommand("check_trn_PtTypeWiseDiscountDuplicate", con)
                    validationCmd.CommandType = CommandType.StoredProcedure
                    validationCmd.Parameters.AddWithValue("@PtTypeId", ptTypeId)
                    validationCmd.Parameters.AddWithValue("@OpIpType", opIpType)
                    validationCmd.Parameters.AddWithValue("@Id", selectedPtTypeId)

                    Dim count As Integer = Convert.ToInt32(validationCmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("The same PtType and Op-Ip Type combination already exists and cannot be activated.")
                        Return
                    End If
                End If

                Dim cmd As New SqlCommand("edit_trn_PtTypeWiseDiscountMaster", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@PtTypeId", ptTypeId)
                cmd.Parameters.AddWithValue("@OpIpType", opIpType)
                cmd.Parameters.AddWithValue("@Discount", discountValue)
                cmd.Parameters.AddWithValue("@IsActive", chkIsActive.Checked)
                cmd.Parameters.AddWithValue("@Id", selectedPtTypeId)

                Dim result As Integer = cmd.ExecuteNonQuery()

                If result > 0 Then
                    MessageBox.Show("Data updated successfully.")
                    LoadDgvPtTypeWiseDisc()
                Else
                    MessageBox.Show("Data update failed.")
                End If

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub


    Private Sub CheckBoxActive_CheckedChanged(sender As Object, e As EventArgs) Handles chkIsActive.CheckedChanged
        If chkIsActive.Checked Then
            chkIsDeactive.Checked = False
        End If
    End Sub

    Private Sub CheckBoxDeactive_CheckedChanged(sender As Object, e As EventArgs) Handles chkIsDeactive.CheckedChanged
        If chkIsDeactive.Checked Then
            chkIsActive.Checked = False
        End If
    End Sub
    Private Sub ClearFields()
        cmbPtTypeWiseDiscount.SelectedIndex = -1
        txtDiscount.Clear()
        rbtnOPD.Checked = False
        rbtnIPD.Checked = False
        chkIsActive.Checked = True
        chkIsDeactive.Checked = False
        selectedPtTypeId = 0
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearFields()
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnSearchPtType_Click(sender As Object, e As EventArgs) Handles btnSearchPtType.Click
        Dim searchText As String = txtSearchPtType.Text.Trim()

        'If String.IsNullOrWhiteSpace(searchText) Then
        'MessageBox.Show("Please enter a search term.")
        'Return
        'End If

        ' Use the connection string retrieved from App.config
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("get_trn_PtTypeWiseDiscountSearchList", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()

            Try
                con.Open()
                adapter.Fill(table)

                If table.Rows.Count > 0 Then
                    table.Columns.Add("Sr.No", GetType(Integer))
                    For i As Integer = 0 To table.Rows.Count - 1
                        table.Rows(i)("Sr.No") = i + 1
                    Next
                    dgvPtTypeWiseDiscount.DataSource = table

                    dgvPtTypeWiseDiscount.Columns("Sr.No").DisplayIndex = 0
                    dgvPtTypeWiseDiscount.Columns("Id").Visible = False
                    dgvPtTypeWiseDiscount.Columns("PtTypeId").Visible = False
                    dgvPtTypeWiseDiscount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                Else
                    MessageBox.Show("No matching records found.")
                    dgvPtTypeWiseDiscount.DataSource = Nothing
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class