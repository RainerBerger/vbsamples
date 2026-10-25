Imports System

Module Program
    Sub Main(args As String())

        Dim fi as New System.IO.StreamReader("ch5_in.txt",System.Text.Encoding.Default)
        Dim fo as System.IO.StreamWriter = System.IO.File.CreateText("ch5_out.txt")
        Dim sid, sname, buf as String
        Dim e_score, math_score, tot_score, min, max, accum, i, n as Integer
        Dim average as Double
        min = 9999
        max = -9999
        accum = 0
        i = 1
        Do Until fi.Peek = -1
            buf = fi.ReadLine()
            sid = TakeAndCut(buf)
            e_score = CInt(TakeAndCut(buf))
            math_score = CInt(TakeAndCut(buf))
            sname = buf

            tot_score = e_score + math_score
            accum = accum + tot_score
            If (min > tot_score) Then
                min = tot_score
            End If
            If (max < tot_score) Then
                max = tot_score
            End If

            Console.WriteLine("{0} {1} {2} {3}, Total score = {4}", sid, e_score, math_score, sname, tot_score)
            fo.WriteLine("{0} {1} {2} {3}, Total score = {4}", sid, e_score, math_score, sname, tot_score)
            i = i + 1
        Loop
        n = i-1
        average = accum / n 
        fo.WriteLine("Number of students: {0} ", n)
        fo.WriteLine("Average of total: {0}, Minimum = {1}, Maximum = {2}", average, min, max)
        fi.Close()
        fo.Close()
    End Sub

    Private Function TakeAndCut(ByRef buf as String) As String
        Dim j as Integer
        Dim dataTaken as String
        buf = buf.Trim
        ' j = buf.IndexOf(" ")
        j = InStr(buf, " ")
        if (j >= 0) then
            dataTaken = Mid(buf, 1, j)
            buf = buf.Remove(0, j)
        else
            dataTaken = "0"
        end if
        Return dataTaken
    End Function    
End Module
