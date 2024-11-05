Attribute VB_Name = "Module2"
Sub ChangeDataTypeToTime()
    Dim ws As Worksheet
    
    
    For Each ws In ThisWorkbook.Worksheets
        
        ws.Columns("C").NumberFormat = "hh:mm:ss" ' Формат времени
        
        ws.Columns("F").NumberFormat = "hh:mm:ss" ' Формат времени
    Next ws
    
    
End Sub

