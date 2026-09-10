Imports System

Module Program
    Sub Main(args As String())
        Dim convert As String
        Dim num As Integer
        Dim dig1 As Integer
        Dim dig2 As Integer

        Console.WriteLine("Enter 1 for denary to hex, enter 2 for hex to denary, enter 3 for denary to binary or enter 4 for binary to denary")
        convert = Console.ReadLine()


        If convert = 1 Then
            Console.WriteLine("enter a number between 0 and 255")
            num = Console.ReadLine()

            dig1 = num / 16
            dig2 = num Mod 16

            If dig1 > 9 Then
                dig1 = DtoH(dig1)
            End If

            If dig2 > 9 Then
                dig2 = DtoH(dig2)
            End If

            Console.WriteLine("your hex value is " + Str(dig1) + Str(dig2))
        End If


        If convert = 2 Then
            Console.WriteLine("enter a hex value between 0 and FF")
            num = Console.ReadLine()

            dig1 = Left(num, 0)
            dig2 = Right(num, 0)

            If Not (dig1 = 0 Or 1 Or 2 Or 3 Or 4 Or 5 Or 6 Or 7 Or 8 Or 9) Then
                dig1 = HtoD(dig1)
            End If
        Else dig1 /= 16

            If Not (dig2 = 0 Or 1 Or 2 Or 3 Or 4 Or 5 Or 6 Or 7 Or 8 Or 9) Then
                dig2 = HtoD(dig2)
            End If

            Console.WriteLine("your denary number is " + dig1 + dig2)
        End If


        If convert = 3 Then
            Console.WriteLine("enter a denary number between 0 and 255")
            num = Console.ReadLine()
        End If


        If convert = 4 Then
            Console.WriteLine("enter an 8 bit binary number between 00000000 and 11111111")
            num = Console.ReadLine
        End If


    End Sub

    Function DtoH(ByVal num As Integer)

        num += 55
        Return (Chr(num))

    End Function

    Function HtoD(ByVal num As Integer)

        num = AscW(num)
        num -= num
        Return (num)

    End Function
End Module