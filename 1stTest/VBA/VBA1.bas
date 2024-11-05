Attribute VB_Name = "Module1"
Sub AutoFitAllSheets()
    Dim ws As Worksheet
    
  
    For Each ws In ThisWorkbook.Worksheets
        
        ws.Columns.AutoFit
    Next ws
    
    
End Sub
