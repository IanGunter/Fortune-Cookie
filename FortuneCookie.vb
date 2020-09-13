'Ian Gunter
'Fortune Cookie
'RCET
'Fall 2020
'


Module FortuneCookie

    Sub Main()
        Dim randomNumber As Integer
        Randomize()
        Do



            Console.WriteLine("Press Enter to hear your future.")
            Console.ReadLine()
            randomNumber = GetRandomNumber(1, 2)

            If randomNumber = 1 Then
                Console.WriteLine("Fortune: Beware of creepy crawlers.")
            ElseIf randomNumber = 2 Then
                Console.WriteLine("Fortune: You")
            ElseIf randomNumber = 3 Then
                Console.WriteLine("Fortune: You are going to poop soon ")
            End If

            Console.ReadLine()
            Console.Clear()

        Loop








    End Sub


    Function GetRandomNumber(ByVal minimum As Integer, ByVal maximum As Integer)
        Dim value As Integer
        value = ((maximum - minimum + 1) * Rnd()) + minimum
        Return value

    End Function
End Module




