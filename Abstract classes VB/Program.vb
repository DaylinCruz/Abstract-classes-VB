Imports System

Module Program
    Sub Main(args As String())
        Dim caballo As Caballo = New Caballo("Flika")
        caballo.Respirar()
        Dim humano As Humano = New Humano("David")
        Dim gorila As Gorila = New Gorila("Hallu")
        gorila.GetNombre()
        Dim ballena As Ballena = New Ballena("Salet")
        Dim lagartija As Lagartija = New Lagartija("Saora")
        lagartija.GetNombre()
    End Sub
End Module
Interface IMamiferosTerrestres
    Function NumPatas() As Integer
End Interface

Interface IAnimalesYDeportes
    Function TipoDeporte() As String
End Interface

MustInherit Class Animales
    Public Sub Respirar()
        Console.WriteLine("Soy capaz de respirar")
    End Sub

    Public MustOverride Sub GetNombre()
End Class

Class Mamiferos
    Inherits Animales

    Private nombreSerVivo As String

    Public Sub New(ByVal nombre As String)
        nombreSerVivo = nombre
    End Sub

    Public Overridable Sub pensar()
        Console.WriteLine("Pensamiento básico instintivo")
    End Sub

    Public Sub cuidarCrías()
        Console.WriteLine("Cuido a mis crías hasta que se valgan por sí solas")
    End Sub

    Public Overrides Sub GetNombre()
        Console.WriteLine("El nombre del mamífero es: " & nombreSerVivo)
    End Sub
End Class

Class Caballo
    Inherits Mamiferos
    Implements IMamiferosTerrestres, IAnimalesYDeportes

    Public Sub New(ByVal nombre_caballo As String)
        MyBase.New(nombre_caballo)
    End Sub

    Public Sub Galopar()
        Console.WriteLine("Soy capaz de galopar")
    End Sub

    Public Function NumPatas() As Integer
        Return 4
    End Function

    Public Function TipoDeporte() As String
        Return "carreras"
    End Function

    Private Function IMamiferosTerrestres_NumPatas() As Integer Implements IMamiferosTerrestres.NumPatas
        Throw New NotImplementedException()
    End Function

    Private Function IAnimalesYDeportes_TipoDeporte() As String Implements IAnimalesYDeportes.TipoDeporte
        Throw New NotImplementedException()
    End Function
End Class

Class Humano
    Inherits Mamiferos
    Implements IMamiferosTerrestres, IAnimalesYDeportes

    Public Sub New(ByVal nombre_humano As String)
        MyBase.New(nombre_humano)
    End Sub

    Public Overrides Sub pensar()
        Console.WriteLine("Soy capaz de pensar")
    End Sub

    Public Function NumPatas() As Integer
        Return 2
    End Function

    Public Function TipoDeporte() As String
        Return "Atletismo"
    End Function

    Private Function IMamiferosTerrestres_NumPatas() As Integer Implements IMamiferosTerrestres.NumPatas
        Throw New NotImplementedException()
    End Function

    Private Function IAnimalesYDeportes_TipoDeporte() As String Implements IAnimalesYDeportes.TipoDeporte
        Throw New NotImplementedException()
    End Function
End Class

Class Gorila
    Inherits Mamiferos
    Implements IMamiferosTerrestres

    Public Sub New(ByVal nombre_gorila As String)
        MyBase.New(nombre_gorila)
    End Sub

    Public Overrides Sub pensar()
        Console.WriteLine("Pensamiento instintivo avanzado")
    End Sub

    Public Sub Trepar()
        Console.WriteLine("Soy capaz de trepar")
    End Sub

    Public Function NumPatas() As Integer
        Return 2
    End Function

    Private Function IMamiferosTerrestres_NumPatas() As Integer Implements IMamiferosTerrestres.NumPatas
        Throw New NotImplementedException()
    End Function
End Class

Class Ballena
    Inherits Mamiferos

    Public Sub New(ByVal nombre_ballena As String)
        MyBase.New(nombre_ballena)
    End Sub

    Public Sub Nadar()
        Console.WriteLine("Soy capaz de nadar")
    End Sub
End Class

Class Lagartija
    Inherits Animales

    Public Sub New(ByVal nombre As String)
        Nombre_reptil = nombre
    End Sub

    Public Overrides Sub GetNombre()
        Console.WriteLine("El nombre del reptíl es: " & Nombre_reptil)
    End Sub

    Private Nombre_reptil As String
End Class
