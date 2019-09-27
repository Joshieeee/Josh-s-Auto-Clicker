Imports System.Windows.Forms
Imports System.Drawing



Public Class Mouse

    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Long)

End Class
