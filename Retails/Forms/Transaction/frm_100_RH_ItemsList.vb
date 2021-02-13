Imports System.Data.SqlClient
Imports RetailPoint.clsPublic
Imports System.Runtime.InteropServices
Public Class frm_100_RH_ItemsList

    Public myParent As frm_100_DRList
    Public maincode As String
    Public transactionName As String
#Region "View Item function"

    Dim dec As Integer


#End Region

    Sub ComputeAllRows()
        Dim sum As Double
        Select Case transactionName
            Case "DRCODE"
                With dgDetailsItems
                    For i = 0 To .RowCount - 1
                        sum = sum + NZ(.Item("colAmount", i).Value)
                    Next
                    txtTotalAmount.Text = String.Format("{0:N" + CStr(dec) + "}", (NZ(sum)))
                End With
                lblCountSub.Text = CountGridRows(dgDetailsItems)
            Case "WR CODE"
                With dtgv_wrlist
                    For i = 0 To .RowCount - 1
                        sum = sum + NZ(.Item("wrAmount", i).Value)
                    Next
                    txtTotalAmount.Text = String.Format("{0:N" + CStr(dec) + "}", (NZ(sum)))
                End With
                lblCountSub.Text = CountGridRows(dtgv_wrlist)
            Case "RETURN ID"
                With dtgv_returnlist
                    For i = 0 To .RowCount - 1
                        sum = sum + NZ(.Item("rtAmount", i).Value)
                    Next
                    txtTotalAmount.Text = String.Format("{0:N" + CStr(dec) + "}", (NZ(sum)))
                End With
                lblCountSub.Text = CountGridRows(dtgv_returnlist)
        End Select



    End Sub
    Private Sub Frm_100_RH_ItemsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Select Case transactionName
                Case "DRCODE"
                    Me.Text = transactionName.ToString() + ": " + maincode.ToString()
                    dgDetailsItems.Visible = True
                    dtgv_wrlist.Visible = False
                    dtgv_returnlist.Visible = False

                    FillGrid(dgDetailsItems, "select ItemCode, ItemName, ItemDescription, BrandType, drQty, UOM, drCost, drAmount from v_dr_item where drCode='" + maincode + "'", "v_dr_item")
                    ComputeAllRows()
                Case "WR CODE"
                    Me.Text = transactionName.ToString() + ": " + maincode.ToString()
                    dgDetailsItems.Visible = False
                    dtgv_wrlist.Visible = True
                    dtgv_returnlist.Visible = False

                    dtgv_wrlist.Location = New Point(4, 12)
                    dtgv_wrlist.ColumnHeadersHeight = 21
                    dtgv_wrlist.Size = New Size(859, 339)
                    FillGrid(dtgv_wrlist, "select ItemCode, ItemName, ItemDescription, BrandType, Qty, UOM, Cost, Amount from v_wr_item where wrId='" + maincode + "'", "v_wr_item")
                    ComputeAllRows()
                Case "RETURN ID"
                    dgDetailsItems.Visible = False
                    dtgv_wrlist.Visible = False
                    dtgv_returnlist.Visible = True

                    dtgv_returnlist.Location = New Point(4, 12)
                    dtgv_returnlist.ColumnHeadersHeight = 21
                    dtgv_returnlist.Size = New Size(859, 339)
                    Me.Text = transactionName.ToString() + ": " + maincode.ToString()
                    FillGrid(dtgv_returnlist, "select ItemCode, ItemName, ItemDescription, BrandType, Qty, UOM, UnitPrice, Amount from v_return_item where returnId='" + maincode + "'", "v_return_item")
                    ComputeAllRows()
            End Select



        Catch ex As Exception

        End Try

    End Sub



End Class