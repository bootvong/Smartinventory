﻿Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmreportstockoutdetail
    Dim cn As New connectdb
    Dim da As New SqlDataAdapter
    Dim dt, dt1, dt2 As New DataTable
    Dim cm As New SqlCommand
    Dim cate As New tbcategory
    Dim subcate As New tbsubcategory

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Frmreport_Sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cate.combocategory1(cbcategory)
            cbcategory.SelectedValue = 0
            If cbcategory.SelectedValue > 0 Then
                subcate.combocategory(cbcategory.SelectedValue, cbsupcategory)
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcategory.SelectedIndexChanged
        Try
            If cbcategory.SelectedValue = 0 Then
            Else
                subcate.combocategory(cbcategory.SelectedValue, cbsupcategory)
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btncry_Click(sender As Object, e As EventArgs) Handles btncry.Click
        Try
            Dim subname As String = Nothing
            If cbcategory.SelectedValue = 0 Then
                subname = "%"
            Else
                Dim rows As DataRowView = cbsupcategory.SelectedItem
                Dim row As DataRow = rows.Row
                subname = row(3).ToString
            End If
            dt.Clear()
            cn.connect()
            cm = New SqlCommand("select * from viewstockoutdetail where date_out>='" & Format(CDate(date1.Text), "MM/dd/yyyy") & "'and date_out<='" & Format(CDate(date2.Text), "MM/dd/yyyy") & "' and  subname like N'%" & subname & "%' and statusid<>4 and approve='YES' ORDER BY stockoutNO ASC", cn.conn)
            With da
                .SelectCommand = cm
                .Fill(dt)
            End With
            Dim cry As New reportsumarybilloutstockdetail
            cry.SetDatabaseLogon(cn.user, cn.password)
            cry.SetDataSource(dt)
            cry.SetParameterValue("dt1", date1.Text)
            cry.SetParameterValue("dt2", date2.Text)
            CrystalReportViewer1.ReportSource = cry
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class