'Ian Gunter
'Fortune Cookie
'RCET 0265
'Fall 2020
'https://github.com/IanGunter/Fortune-Cookie.git

Option Strict On
Option Compare Text
Option Explicit On


Module FortuneCookie

    Sub Main()
        Dim randomNumber As Integer
        Randomize()
        Do



            Console.WriteLine("Press Enter to hear your future.")
            Console.ReadLine()
            'GetRandomNumber(1,2) sets the random number maximum and minimum values
            randomNumber = GetRandomNumber(1, 2)

            If randomNumber = 1 Then
                Console.WriteLine("Fortune: Beware of creepy crawlers.")
            ElseIf randomNumber = 2 Then
                Console.WriteLine("Fortune: Sleep is in your future.")
            ElseIf randomNumber = 3 Then
                Console.WriteLine("Fortune: You do not want to sell me death sticks. ")
            End If

            Console.ReadLine()
            Console.Clear()

        Loop








    End Sub

    'Function Below creates a randomly generated number between 1 and 3.
    Function GetRandomNumber(ByVal minimum As Integer, ByVal maximum As Integer) As Integer
        Dim value As Single
        'Rnd picks a number between 0 and 1.
        value = ((maximum - minimum + 1) * Rnd()) + minimum
        Return CInt(value)

    End Function
End Module




