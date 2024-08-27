Imports System.Data.Entity



Public Class ApplicationDbContext
        Inherits DbContext

        Public Sub New()
            MyBase.New("conn")
        End Sub

        ' Define DbSet properties for your entities
        Public Property Usuarios As DbSet(Of Usuarios)

    ' Agrega más DbSets según las tablas de tu base de datos
End Class
