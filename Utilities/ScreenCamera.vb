Imports System.Drawing.Imaging
Imports System.IO

''' <summary>A screen camera</summary>
Public Class ScreenCamera

    ''' <summary>
    ''' Takes a screenshot of the screen
    ''' </summary>
    ''' <param name="Width">Width of the screenshot</param>
    ''' <param name="Height">Height of the screenshot</param>
    ''' <param name="Xdim">The left X Coordinate</param>
    ''' <param name="YDim">The Top y Coordinate</param>
    ''' <param name="ScreenshotSize">Size of the window</param>
    Public Shared Sub TakeScreenshot(Width As Integer, Height As Integer, Xdim As Integer, YDim As Integer, ScreenshotSize As Size)
        Dim bmpScreenShot As Bitmap
        Dim gfxScreenshot As Graphics

        bmpScreenShot = New Bitmap(Width, Height, PixelFormat.Format32bppArgb)

        gfxScreenshot = Graphics.FromImage(bmpScreenShot)
        gfxScreenshot.CopyFromScreen(Xdim, YDim, 0, 0, ScreenshotSize, CopyPixelOperation.SourceCopy)
        If File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\ViBEScrSHT.png") Then File.Delete(My.Computer.FileSystem.SpecialDirectories.Temp & "\ViBEScrSHT.png")
        bmpScreenShot.Save(My.Computer.FileSystem.SpecialDirectories.Temp & "\ViBEScrSHT.png", ImageFormat.Png)

        Dim Coso As Image
        Coso = Image.FromFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\ViBEScrSHT.png")
        My.Computer.Clipboard.SetImage(Coso)
        Coso.Dispose()

        Dim Notif As QuickNotif = New QuickNotif("Copied to Clipboard!")
        Notif.Show()
    End Sub

End Class
