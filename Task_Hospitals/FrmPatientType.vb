﻿Imports System.Configuration
Imports System.Data.SqlClient

Public Class FrmPatientType
    Private selectedPtTypeId As Integer
    'Private connectionString As String
    ' Retrieve the connection string from App.config
    Dim connectionString = ConfigurationManager.ConnectionStrings("DbConnection").ConnectionString
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDgvPtType()

        ' Set Active checkbox checked by default
        chkIsActive.Checked = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtPtType.Text) Then
            MessageBox.Show("Please fill in the PtType.")
            Return
        End If

        If Not (chkIsActive.Checked Or chkIsDeactive.Checked) Then
            MessageBox.Show("Please select at least one status: Active or Deactive.")
            Return
        End If

        Dim ptTypeName As String = txtPtType.Text.Trim()
        Dim isActive As Boolean = chkIsActive.Checked

        Using con As New SqlConnection(connectionString)
            Try
                con.Open()

                ' Check existing PtType records
                Dim checkQuery As String = "SELECT IsActive FROM mst_PtType WHERE PtType = @PtType"
                Using checkCmd As New SqlCommand(checkQuery, con)
                    checkCmd.Parameters.AddWithValue("@PtType", ptTypeName)

                    Dim hasActive As Boolean = False
                    Dim hasDeactive As Boolean = False

                    Using reader As SqlDataReader = checkCmd.ExecuteReader()
                        While reader.Read()
                            Dim status As Boolean = reader.GetBoolean(0)
                            If status Then
                                hasActive = True
                            Else
                                hasDeactive = True
                            End If
                        End While
                    End Using

                    If hasActive And hasDeactive Then
                        MessageBox.Show("Pt Type already exists both as active and deactive. Cannot insert duplicate data.")
                        Return
                    ElseIf hasActive Then
                        MessageBox.Show("Pt Type is already added and active.")
                        Return
                    ElseIf hasDeactive Then
                        MessageBox.Show("Pt Type exists as deactive and will be added again.")
                    End If
                End Using

                ' Insert new PtType record
                Dim insertQuery As String = "INSERT INTO mst_PtType (PtType, IsActive) VALUES (@PtType, @IsActive)"
                Using insertCmd As New SqlCommand(insertQuery, con)
                    insertCmd.Parameters.AddWithValue("@PtType", ptTypeName)
                    insertCmd.Parameters.AddWithValue("@IsActive", isActive)

                    Dim result As Integer = insertCmd.ExecuteNonQuery()
                    If result > 0 Then
                        MessageBox.Show("Data inserted successfully.")
                        LoadDgvPtType() ' Reload data
                    Else
                        MessageBox.Show("Data insertion failed.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                ClearFields() ' Clear input fields
            End Try
        End Using
    End Sub
    'Data GridView 
    Private Sub LoadDgvPtType()
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM mst_PtType"
            Dim cmd As New SqlCommand(query, con)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()

            Try
                con.Open()
                adapter.Fill(table)

                ' Add a serial number column
                table.Columns.Add("Sr.No", GetType(Integer))
                For i As Integer = 0 To table.Rows.Count - 1
                    table.Rows(i)("Sr.No") = i + 1
                Next

                ' Bind the data to the DataGridView
                dgvPtType.DataSource = table
                dgvPtType.Columns("Sr.No").DisplayIndex = 0
                dgvPtType.Columns("PtTypeId").Visible = False ' Hide the PtTypeId column
                dgvPtType.Columns("Sr.No").ReadOnly = True ' Make Sr.No column read-only
                dgvPtType.Columns("PtType").ReadOnly = True
                dgvPtType.Columns("IsActive").ReadOnly = True
                dgvPtType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub dgvPtType_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPtType.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvPtType.Rows(e.RowIndex)
            txtPtType.Text = selectedRow.Cells("PtType").Value.ToString()
            selectedPtTypeId = CInt(selectedRow.Cells("PtTypeId").Value)
            Dim isActive As Boolean = CBool(selectedRow.Cells("IsActive").Value)
            chkIsActive.Checked = isActive
            chkIsDeactive.Checked = Not isActive
            ' Enable the Update button
            btnUpdate.Enabled = True
        End If
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Validation: Ensure a record is selected
        If selectedPtTypeId = 0 Then
            MessageBox.Show("Please select a record to update.")
            Return
        End If

        ' Validation: Ensure PtType is not empty
        If String.IsNullOrWhiteSpace(txtPtType.Text) Then
            MessageBox.Show("PtType cannot be empty.")
            Return
        End If

        ' Validation: Ensure at least one status is selected
        If Not (chkIsActive.Checked Or chkIsDeactive.Checked) Then
            MessageBox.Show("Please select at least one status: Active or Deactive.")
            Return
        End If

        ' Determine the active status
        Dim isActive As Boolean = chkIsActive.Checked

        ' Step 1: Validate if the same PtType already exists
        Using con As New SqlConnection(connectionString)
            Dim checkCmd As New SqlCommand("SELECT COUNT(*) FROM mst_PtType WHERE PtType = @PtType AND PtTypeId <> @PtTypeId", con)
            checkCmd.Parameters.AddWithValue("@PtType", txtPtType.Text)
            checkCmd.Parameters.AddWithValue("@PtTypeId", selectedPtTypeId)

            Try
                con.Open()
                Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("The same PtType already exists. Please enter a unique PtType.")
                    Return
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while validating PtType: " & ex.Message)
                Return
            End Try
        End Using

        ' Step 2: Proceed with the update
        Using con As New SqlConnection(connectionString)
            Dim updateCmd As New SqlCommand("UPDATE mst_PtType SET PtType = @PtType, IsActive = @IsActive WHERE PtTypeId = @PtTypeId", con)
            updateCmd.Parameters.AddWithValue("@PtType", txtPtType.Text)
            updateCmd.Parameters.AddWithValue("@IsActive", If(isActive, 1, 0))
            updateCmd.Parameters.AddWithValue("@PtTypeId", selectedPtTypeId)

            Try
                con.Open()
                Dim result As Integer = updateCmd.ExecuteNonQuery()

                If result > 0 Then
                    MessageBox.Show("Data updated successfully.")
                    LoadDgvPtType()  ' Reload the DataGridView after successful update
                Else
                    MessageBox.Show("Data update failed.")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub ClearFields()
        txtPtType.Clear()

        ' Set Active checkbox checked by default
        chkIsActive.Checked = True
        chkIsDeactive.Checked = False
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearFields()
        ' Disable the Update button
        btnUpdate.Enabled = False
    End Sub
    Private Sub chkIsActive_CheckedChanged(sender As Object, e As EventArgs) Handles chkIsActive.CheckedChanged
        If chkIsActive.Checked Then
            chkIsDeactive.Checked = False
        End If
    End Sub

    Private Sub chkIsDeactive_CheckedChanged(sender As Object, e As EventArgs) Handles chkIsDeactive.CheckedChanged
        If chkIsDeactive.Checked Then
            chkIsActive.Checked = False
        End If
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSearchPtType_Click(sender As Object, e As EventArgs) Handles btnSearchPtType.Click
        Dim searchText As String = txtSearchPtType.Text.Trim()

        ' If search text is empty, show a message
        'If String.IsNullOrWhiteSpace(searchText) Then
        'MessageBox.Show("Please enter a search term.")
        'Return
        'End If

        ' Using the connection to execute a search query
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM mst_PtType WHERE PtType LIKE @searchText"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()

            Try
                con.Open()
                adapter.Fill(table)

                If table.Rows.Count > 0 Then
                    ' Add a serial number column
                    table.Columns.Add("Sr.No", GetType(Integer))
                    For i As Integer = 0 To table.Rows.Count - 1
                        table.Rows(i)("Sr.No") = i + 1
                    Next

                    ' Bind data to the DataGridView
                    dgvPtType.DataSource = table
                    dgvPtType.Columns("Sr.No").DisplayIndex = 0
                    dgvPtType.Columns("PtTypeId").Visible = False ' Hide PtTypeId column
                    dgvPtType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                Else
                    MessageBox.Show("No records found.")
                    dgvPtType.DataSource = Nothing ' Clear the DataGridView if no results
                End If

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnPtTypeWiseDisc_Click(sender As Object, e As EventArgs) Handles btnPtTypeWiseDisc.Click
        FrmPtTypewiseDisc.Show()
    End Sub
End Class