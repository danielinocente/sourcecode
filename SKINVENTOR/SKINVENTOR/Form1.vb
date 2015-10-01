Imports System
Imports System.IO
Imports System.Xml
Imports System.Data
Imports System.Collections

Imports Inventor

''' <summary>
''' Close the window
''' </summary>
Public Class Form1

    Private inv As InventorController
    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Run something
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button_Run_Click(sender As Object, e As EventArgs) Handles Button_Run.Click
        Dim m_path As String = TextBox_Path.Text

        Dim m_sw As StreamReader = New StreamReader(m_path)
        Dim m_xmlstring As String = m_sw.ReadToEnd

        Dim m_xmldoc As XmlDocument = New XmlDocument()
        m_xmldoc.LoadXml(m_xmlstring)

        ''' get the first point
        Dim m_nodesA As XmlNodeList = m_xmldoc.GetElementsByTagName("PointA")
        Dim m_nodesB As XmlNodeList = m_xmldoc.GetElementsByTagName("PointB")

        Dim pointsA As New List(Of clsPoints)
        Dim pointsB As New List(Of clsPoints)
        Dim PointClassList As New List(Of clsPoints)
        For Each x As XmlNode In m_nodesA
            Dim str As String = x.InnerText

            Dim PointClass As New clsPoints(str)
            pointsA.Add(PointClass)
        Next

        For Each x As XmlNode In m_nodesB
            Dim str As String = x.InnerText

            Dim PointClass As New clsPoints(str)
            pointsB.Add(PointClass)
        Next



        Dim sketch As Inventor.Sketch3D

        inv.DeleteExistingSketches()
        sketch = inv.MakeSketch()
        sketch.DeferUpdates = True

        For i = 0 To pointsA.Count - 1
            inv.InsertPanel(sketch, "path to panel", pointsA(i), pointsB(i))
        Next
        sketch.DeferUpdates = False


        Button_Run.Text = "Refresh"

    End Sub

    Private Sub ButtonDialog_Click(sender As Object, e As EventArgs) Handles ButtonDialog.Click

        If (OpenFileDialog1.ShowDialog()) Then
            TextBox_Path.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inv = New InventorController()

        inv.Connect()
        inv.Load()
    End Sub

    Private Sub TextBox_Path_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Path.TextChanged

    End Sub
End Class
