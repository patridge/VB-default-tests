Option Explicit On
Option Strict On
Module Module1
    Public Function GetDefaultDeclaration(Of T)() As T
        Dim result As T = Nothing
        Return result
    End Function
    Public Function GetDefaultNothingDirect(Of T)() As T
        Return Nothing
    End Function
    Public Function GetDefaultNothingCtype(Of T)() As T
        Return CType(Nothing, T)
    End Function
    Public Function GetDefaultNothingDirectCast(Of T)() As T
        Return DirectCast(Nothing, T)
    End Function

    Public Class TestClass
    End Class
    Public Enum TestEnum
        RequiredValue
    End Enum
    Public Interface TestInterface
    End Interface
    Public MustInherit Class TestAbstractClass
    End Class

    Sub Main()
        Debug.Assert(GetDefaultDeclaration(Of Integer)() = DefaultWrapper.GetDefault(Of Integer)())
        Debug.Assert(GetDefaultNothingDirect(Of Integer)() = DefaultWrapper.GetDefault(Of Integer)())
        Debug.Assert(GetDefaultNothingCtype(Of Integer)() = DefaultWrapper.GetDefault(Of Integer)())
        Debug.Assert(GetDefaultNothingDirectCast(Of Integer)() = DefaultWrapper.GetDefault(Of Integer)())

        Debug.Assert(GetDefaultDeclaration(Of TestClass)() Is Nothing)
        Debug.Assert(GetDefaultNothingDirect(Of TestClass)() Is Nothing)
        Debug.Assert(GetDefaultNothingCtype(Of TestClass)() Is Nothing)
        Debug.Assert(GetDefaultNothingDirectCast(Of TestClass)() Is Nothing)

        Debug.Assert(GetDefaultDeclaration(Of TestEnum)() = DefaultWrapper.GetDefault(Of TestEnum)())
        Debug.Assert(GetDefaultNothingDirect(Of TestEnum)() = DefaultWrapper.GetDefault(Of TestEnum)())
        Debug.Assert(GetDefaultNothingCtype(Of TestEnum)() = DefaultWrapper.GetDefault(Of TestEnum)())
        Debug.Assert(GetDefaultNothingDirectCast(Of TestEnum)() = DefaultWrapper.GetDefault(Of TestEnum)())

        Debug.Assert(GetDefaultDeclaration(Of TestAbstractClass)() Is Nothing)
        Debug.Assert(GetDefaultNothingDirect(Of TestAbstractClass)() Is Nothing)
        Debug.Assert(GetDefaultNothingCtype(Of TestAbstractClass)() Is Nothing)
        Debug.Assert(GetDefaultNothingDirectCast(Of TestAbstractClass)() Is Nothing)

        Console.WriteLine("All tests pass.")
        Console.ReadKey()
    End Sub
End Module