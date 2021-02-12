Imports System.Data.SqlClient
Imports RetailPoint.clsPublic
Imports System.Runtime.InteropServices
Public Class frm_100_RH_ItemsList

    Public myParent As frm_100_DRList
    Public drcode As String

#Region "View Item function"

    Dim dec As Integer


#End Region

    Sub ComputeAllRows()
        Dim sum As Double
        With dgDetailsItems
            For i = 0 To .RowCount - 1
                sum = sum + NZ(.Item("colAmount", i).Value)
            Next
            txtTotalAmount.Text = String.Format("{0:N" + CStr(dec) + "}", (NZ(sum)))
        End With
        lblCountSub.Text = CountGridRows(dgDetailsItems)
    End Sub
    Private Sub Frm_100_RH_ItemsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Item List By DR Code: " + drcode.ToString()

        FillGrid(dgDetailsItems, "select ItemCode, ItemName, ItemDescription, BrandType, drQty, UOM, drCost, drAmount from v_dr_item where drCode='" + drcode + "'", "v_dr_item")
        ComputeAllRows()
    End Sub



End Class