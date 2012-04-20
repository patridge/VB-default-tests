VB-default-tests
================

Confirming the various ways of doing C#&#39;s `default(T)` in VB are all equivalent.

Methods tested [using simple Debug.Assert on a command line app]:

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