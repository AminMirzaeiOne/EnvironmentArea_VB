﻿Module Module1

    Sub Main()

        Dim choice As String
        Dim shape As String
        Dim result As Double
        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Calculate area or perimeter? (a/A for area, p/P for perimeter) : ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        choice = System.Console.ReadLine().ToLower()

        If choice = "a" OrElse choice = "p" Then
            System.Console.ForegroundColor = ConsoleColor.Blue
            System.Console.Write("Which shape? (")
            System.Console.ForegroundColor = ConsoleColor.White
            System.Console.BackgroundColor = ConsoleColor.DarkGreen
            System.Console.Write("square")
            System.Console.ResetColor()
            System.Console.Write(", ")
            System.Console.ForegroundColor = ConsoleColor.White
            System.Console.BackgroundColor = ConsoleColor.Red
            System.Console.Write("rectangle")
            System.Console.ResetColor()
            System.Console.Write(", ")
            System.Console.ForegroundColor = ConsoleColor.White
            System.Console.BackgroundColor = ConsoleColor.Magenta
            System.Console.Write("circle")
            System.Console.ResetColor()
            System.Console.Write(", ")
            System.Console.ForegroundColor = ConsoleColor.White
            System.Console.BackgroundColor = ConsoleColor.DarkYellow
            System.Console.Write("rhombus")
            System.Console.ResetColor()
            System.Console.Write(", ")
            System.Console.ForegroundColor = ConsoleColor.White
            System.Console.BackgroundColor = ConsoleColor.DarkCyan
            System.Console.Write("triangle")
            System.Console.BackgroundColor = ConsoleColor.Black
            System.Console.ForegroundColor = ConsoleColor.Blue
            System.Console.Write(") : ")
            System.Console.ResetColor()
            shape = System.Console.ReadLine().ToLower()

            Select Case shape
                Case "square"
                    Dim side As Double
                    System.Console.Write("Enter the side of the square: ")
                    side = System.Convert.ToDouble(System.Console.ReadLine())
                    If choice = "a" Then
                        result = side * side
                    Else
                        result = 4 * side
                    End If

                Case "rectangle"
                    Dim length As Double, width As Double
                    System.Console.Write("Enter the length of the rectangle: ")
                    length = Convert.ToDouble(System.Console.ReadLine())
                    System.Console.Write("Enter the width of the rectangle: ")
                    width = System.Convert.ToDouble(System.Console.ReadLine())
                    If choice = "a" Then
                        result = length * width
                    Else
                        result = 2 * (length + width)
                    End If

                Case "circle"
                    Dim radius As Double
                    System.Console.Write("Enter the radius of the circle: ")
                    radius = System.Convert.ToDouble(System.Console.ReadLine())
                    If choice = "a" Then
                        result = System.Math.PI * radius * radius
                    Else
                        result = 2 * System.Math.PI * radius
                    End If

                Case "rhombus"
                    Dim diagonal1 As Double, diagonal2 As Double
                    System.Console.Write("Enter the first diagonal of the rhombus: ")
                    diagonal1 = System.Convert.ToDouble(System.Console.ReadLine())
                    System.Console.Write("Enter the second diagonal of the rhombus: ")
                    diagonal2 = System.Convert.ToDouble(System.Console.ReadLine())
                    If choice = "a" Then
                        result = 0.5 * diagonal1 * diagonal2
                    Else
                        ' Calculate perimeter of rhombus (requires side length)
                        ' ... (calculate side length using Pythagorean theorem)
                    End If

                Case "triangle"
                    Dim baseLength As Double, height As Double
                    System.Console.Write("Enter the base of the triangle: ")
                    baseLength = System.Convert.ToDouble(System.Console.ReadLine())
                    System.Console.Write("Enter the height of the triangle: ")
                    height = System.Convert.ToDouble(System.Console.ReadLine())
                    If choice = "a" Then
                        result = 0.5 * baseLength * height
                    Else
                        ' Calculate perimeter of triangle (requires all side lengths)
                        ' ... (if sufficient information is provided)
                    End If

                Case Else
                    System.Console.WriteLine("Invalid shape.")
            End Select

            If result <> 0 Then
                System.Console.WriteLine("Result: " & result)
            End If

        Else
            System.Console.WriteLine("Invalid choice.")
        End If

        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")

        System.Console.ReadKey()
    End Sub
End Module

