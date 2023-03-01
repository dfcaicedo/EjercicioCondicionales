Module Module1

    Sub Main()
        Console.WriteLine("Esto es Basic")
        Dim a As Int32, b As Int32, c As Int32 ' Declaración de variables
        a = Console.ReadLine() 'Recibir el valor del teclado
        b = Console.ReadLine()
        c = Console.ReadLine()
        If a > b Then
            'Este es el valor del si
            If b > c Then
                Console.WriteLine("a,b,c")
            Else
                'Este es el lado del no
                If a > c Then
                    Console.WriteLine("a,c,b")
                Else
                    Console.WriteLine("c,a,b")
                End If
            End If
        Else
            If a > c Then
                Console.WriteLine("b,a,c")
            Else
                If b > c Then
                    Console.WriteLine("b,c,a")
                Else
                    Console.WriteLine("c,b,a")
                End If
            End If
        End If
    End Sub

End Module
