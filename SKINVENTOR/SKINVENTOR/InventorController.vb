Imports Inventor
Public Class InventorController

    Private App As Inventor.Application
    Private Doc As Inventor.Document

    Public Sub Connect()
        Dim inventorAppType As Type


        inventorAppType = System.Type.GetTypeFromProgID("Inventor.Application")

        App = System.Activator.CreateInstance(inventorAppType)
        App.Visible = True

    End Sub

    Public Sub Load()
        Doc = App.Documents.Add(Inventor.DocumentTypeEnum.kPartDocumentObject, "", True)

    End Sub

    Public Sub DeleteExistingSketches()
        Dim oPart As PartDocument
        Dim oComp As PartComponentDefinition
        Dim oSketch As Sketch3D
        Dim tg As TransientGeometry
        oPart = Doc

        oComp = oPart.ComponentDefinition

        For Each oSketch In oComp.Sketches3D
            oSketch.Delete()
        Next
    End Sub
    Public Function MakeSketch()
        Dim oPart As PartDocument
        Dim oComp As PartComponentDefinition
        Dim oSketch As Sketch3D
        Dim tg As TransientGeometry
        oPart = Doc

        oComp = oPart.ComponentDefinition

        oSketch = oComp.Sketches3D.Add()
        Return oSketch
    End Function

    Public Sub InsertPanel(oSketch As Sketch3D, path As String, PA As clsPoints, PB As clsPoints)

        'Dim oPart As PartDocument
        'Dim oComp As PartComponentDefinition
        'Dim oSketch As Sketch3D
        Dim tg As TransientGeometry
        'oPart = Doc

        'oComp = oPart.ComponentDefinition

        'oSketch = oComp.Sketches3D.Add()

        tg = App.TransientGeometry

        Dim p1 As Point
        Dim p2 As Point
        p1 = tg.CreatePoint(PA.X, PA.Y, PA.Z)
        p2 = tg.CreatePoint(PB.X, PB.Y, PB.Z)

        If p1.DistanceTo(p2) > 0.01 Then


            oSketch.SketchLines3D.AddByTwoPoints(p1, p2)
        End If


        'oAsmComp.Features.
        'Dim oiFeatureDef As Inventor.iFeatureDefinition
        'oiFeatureDef = oFeatures.iFeatures.CreateiFeatureDefinition(path)
        ''"C:\Users\User\AppData\Local\Autodesk\Autodesk Sync\Cloud\dinocente@hksinc.com\04_Training\01_Inventor Training\iCopy\Panel iCopy Factory Assembly.iam")

        '' Set the input.
        'Dim oInput As Inventor.iFeatureInput
        'For Each oInput In oiFeatureDef.iFeatureInputs
        '    Dim oParamInput As iFeatureParameterInput
        '    Select Case oInput.Name
        '        Case "Sketch Plane"
        '            Dim oPlaneInput As iFeatureSketchPlaneInput
        '        Set oPlaneInput = oInput
        '        oPlaneInput.PlaneInput = oFace
        '        Case "Diameter"
        '        Set oParamInput = oInput
        '        oParamInput.Expression = "1 in"
        '        Case "Depth"
        '        Set oParamInput = oInput
        '        oParamInput.Expression = "0.5 in"
        '    End Select
        'Next

        ' Create the iFeature.
        Dim oiFeature As iFeature
        'Set oiFeature = oFeatures.iFeatures.Add(oiFeatureDef)

    End Sub
End Class
