@ModelType Usuarios
@Code
    ViewBag.Title = "Bienvenido"
End Code

<h2>@ViewBag.Title</h2>

<div class="container mt-5">
    <div class="row">
        <div class="col-md-8 offset-md-2">
            <div class="card">
                <div class="card-header">
                    Bienvenido, @Model.Nombre
                </div>
                <div class="card-body">
                    <h5 class="card-title">¡Gracias por registrarte!</h5>
                    <p class="card-text">
                        Aquí están tus datos registrados:
                    </p>
                    <ul class="list-group">
                        <li class="list-group-item"><strong>Nombre:</strong> @Model.Nombre</li>
                        <li class="list-group-item"><strong>Apellido:</strong> @Model.Apellido</li>
                        <li class="list-group-item"><strong>Email:</strong> @Model.Mail</li>
                        <li class="list-group-item"><strong>Teléfono:</strong> @Model.Telefono</li>
                        <li class="list-group-item"><strong>Fecha de Nacimiento:</strong> @Model.FECHA_NACIMIENTO.ToString()</li>
                        <li class="list-group-item"><strong>DNI:</strong> @Model.DNI</li>
                    </ul>
                </div>
                <div class="card-footer text-center">
                    <a href="@Url.Action("Editar", "Home", New With {.id = Model.ID_USUARIO})" class="btn btn-primary">Modificar Datos</a>
                    <a href="@Url.Action("Eliminar", "Home", New With {.id = Model.ID_USUARIO})" class="btn btn-danger" onclick="return confirm('¿Estás seguro de que deseas eliminar tu cuenta?')">Eliminar Cuenta</a>
                </div>
            </div>
        </div>
    </div>
</div>




