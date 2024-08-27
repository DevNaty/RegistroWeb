
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema




<Table("USUARIOS")>
    Public Class Usuarios

        <Key>
        Public Property ID_USUARIO As Integer

        Public Property NOMBRE As String
        Public Property APELLIDO As String
        Public Property MAIL As String
        Public Property PASSWORD As String
        Public Property TELEFONO As String
    Public Property FECHA_NACIMIENTO As String
    Public Property DNI As String


    End Class
