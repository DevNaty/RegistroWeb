@ModelType Usuarios

@Code
    ViewBag.Title = "Eliminar Usuario"
End Code

<!DOCTYPE html>
<html>
<head>
    <title>@ViewBag.Title</title>
    <link rel="stylesheet" href="~/Content/bootstrap.min.css" />
</head>
<body>

    <div class="container mt-5">
        <div class="row">
            <div class="col-md-8 offset-md-2">
                <div class="card">
                    <div class="card-header">
                        @Model.Nombre Estas por eliminar tu cuenta!
                    </div>
                    <div class="card-body">
                        <h5 class="card-title">¡¿Estás seguro de que deseas eliminar tu cuenta?!</h5>
                        <p class="card-text">
                            Aquí están tus datos registrados:
                        </p>
                        <ul class="list-group">
                            <li class="list-group-item"><strong>Nombre:</strong> @Model.NOMBRE</li>
                            <li class="list-group-item"><strong>Apellido:</strong> @Model.APELLIDO</li>
                            <li class="list-group-item"><strong>Email:</strong> @Model.MAIL</li>
                            <li class="list-group-item"><strong>Teléfono:</strong> @Model.TELEFONO</li>
                            <li class="list-group-item"><strong>Fecha de Nacimiento:</strong> @Model.FECHA_NACIMIENTO</li>
                            <li class="list-group-item"><strong>DNI:</strong> @Model.DNI</li>
                        </ul>

                        <form action="@Url.Action("EliminarConfirmed", "Home", New With {.id = Model.ID_USUARIO})" method="post">
                            <input type="submit" value="Eliminar" class="btn btn-danger" />
                            <a href="@Url.Action("Bienvenido", "Home", New With {.id = Model.ID_USUARIO})" class="btn btn-secondary">Cancelar</a>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>



</body>
</html>
