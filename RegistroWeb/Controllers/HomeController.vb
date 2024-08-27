Imports System.Data.Entity

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Private db As New ApplicationDbContext()

    ' Acción para registrar un usuario
    <HttpPost>
    Public Function RegistrarUsuario(Formulario As FormCollection) As ActionResult
        Try
            ' Crear una nueva instancia del modelo Usuario
            Dim nuevoUsuario As New Usuarios With {
                .NOMBRE = Formulario("nombre"),
                .APELLIDO = Formulario("apellido"),
                .MAIL = Formulario("mail"),
                .PASSWORD = Formulario("password"),
                .TELEFONO = Formulario("telefono"),
                .FECHA_NACIMIENTO = If(String.IsNullOrEmpty(Formulario("fecha_nacimiento")), CType(Nothing, DateTime?), DateTime.Parse(Formulario("fecha_nacimiento"))),
                .DNI = Formulario("dni")
            }

            ' Validar si el email ya existe
            Dim existeUsuario = db.Usuarios.FirstOrDefault(Function(u) u.MAIL = nuevoUsuario.MAIL)
            If existeUsuario IsNot Nothing Then
                ViewBag.Message = "El email ya está registrado."
                Return View("Index")
            End If

            ' Guardar el usuario en la base de datos
            db.Usuarios.Add(nuevoUsuario)
            db.SaveChanges()

            ViewBag.Message = "Registro exitoso."
            Return RedirectToAction("Bienvenido", New With {.id = nuevoUsuario.ID_USUARIO})
        Catch ex As Exception
            ViewBag.Message = "Error al registrar: " & ex.Message
            Return View("Index")
        End Try
    End Function

    ' Acción para mostrar la vista de login
    <HttpGet>
    Public Function Login() As ActionResult
        Return View()
    End Function

    ' Acción para procesar el login
    <HttpPost>
    Public Function Login(mail As String, password As String) As ActionResult
        Dim usuario = db.Usuarios.SingleOrDefault(Function(u) u.MAIL = mail AndAlso u.PASSWORD = password)
        If usuario IsNot Nothing Then
            Return RedirectToAction("Bienvenido", New With {.id = usuario.ID_USUARIO})
        Else
            ViewBag.Message = "Email o contraseña inválidos."
            Return View("Login")
        End If
    End Function

    ' Acción para mostrar la vista de bienvenida
    Public Function Bienvenido(id As Integer) As ActionResult
        Dim usuario = db.Usuarios.SingleOrDefault(Function(u) u.ID_USUARIO = id)
        If usuario IsNot Nothing Then
            Return View(usuario)
        Else
            Return HttpNotFound()
        End If
    End Function

    ' Acción para mostrar la vista de edición

    Public Function Editar(id As Integer) As ActionResult
        Dim usuario = db.Usuarios.SingleOrDefault(Function(u) u.ID_USUARIO = id)
        If usuario IsNot Nothing Then
            Return View(usuario)
        Else
            Return HttpNotFound()
        End If
    End Function


    <HttpPost>
    Public Function Editar(ID_USUARIO As Integer, NOMBRE As String, APELLIDO As String, MAIL As String, PASSWORD As String, TELEFONO As String, FECHA_NACIMIENTO As String, DNI As String) As ActionResult
        Dim usuario = db.Usuarios.SingleOrDefault(Function(u) u.ID_USUARIO = ID_USUARIO)
        If usuario IsNot Nothing Then
            usuario.NOMBRE = NOMBRE
            usuario.APELLIDO = APELLIDO
            usuario.MAIL = MAIL
            usuario.PASSWORD = PASSWORD
            usuario.TELEFONO = TELEFONO
            usuario.FECHA_NACIMIENTO = FECHA_NACIMIENTO
            usuario.DNI = DNI

            db.Entry(usuario).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Bienvenido", New With {.id = usuario.ID_USUARIO})
        Else
            Return HttpNotFound()
        End If
    End Function

    ' Acción para mostrar la vista de eliminación
    <HttpGet>
    Public Function Eliminar(id As Integer) As ActionResult
        Dim usuario = db.Usuarios.SingleOrDefault(Function(u) u.ID_USUARIO = id)
        If usuario IsNot Nothing Then
            Return View(usuario)
        Else
            Return HttpNotFound()
        End If
    End Function

    ' Acción para procesar la eliminación
    <HttpPost>
    Public Function EliminarConfirmed(id As Integer) As ActionResult
        Dim usuario = db.Usuarios.SingleOrDefault(Function(u) u.ID_USUARIO = id)
        If usuario IsNot Nothing Then
            db.Usuarios.Remove(usuario)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If
        Return HttpNotFound()
    End Function

    ' Acción para mostrar la vista de inicio
    Function Index() As ActionResult
        Return View()
    End Function

    ' Acción para mostrar la vista "About"
    Function About() As ActionResult
        ViewData("Message") = "Your application description page."
        Return View()
    End Function

    ' Acción para mostrar la vista "Contact"
    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."
        Return View()
    End Function

End Class
