Module Info
    Public Sub Loginfo(ByVal str As String)
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("[")
        Console.ForegroundColor = ConsoleColor.Blue
        Console.Write("信息")
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("]")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(str)
        Console.ResetColor() ' 重置为默认颜色
    End Sub
    Public Sub Logerr(ByVal str As String)
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("[")
        Console.ForegroundColor = ConsoleColor.Red
        Console.Write("错误")
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("]")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(str)
        Console.ResetColor() ' 重置为默认颜色
    End Sub
    Public Sub Login(ByVal str As String)
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("[")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write("需要用户输入")
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("]")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(str)
        Console.ResetColor() ' 重置为默认颜色
    End Sub

    Public Sub Logcho(ByVal str As String, num As String)
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("（")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write(num)
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("）")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine(str)
        Console.ResetColor() ' 重置为默认颜色
    End Sub
End Module
