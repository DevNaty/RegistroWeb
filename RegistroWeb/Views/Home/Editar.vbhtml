<!DOCTYPE html>
<html>
<head>
    <title>Editar Usuario</title>
    <link rel="stylesheet" href="~/Content/bootstrap.min.css" />
    <script src="~/Scripts/jquery-3.6.0.min.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
</head>
<body>
    <div class="container mt-5">
        <h2>Editar Usuario</h2>
        <div class="row justify-content-center">
            <div class="col-md-6">


                <form action="/Home/Editar" method="post" class="form-horizontal">
                    <input type="hidden" name="ID_USUARIO" value="@Model.ID_USUARIO" />

                    <div class="form-group">
                        <label for="NOMBRE" class="control-label col-md-2">Nombre</label>
                        <div class="col-md-10">
                            <input type="text" name="NOMBRE" class="form-control" value="@Model.NOMBRE" />
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="APELLIDO" class="control-label col-md-2">Apellido</label>
                        <div class="col-md-10">
                            <input type="text" name="APELLIDO" class="form-control" value="@Model.APELLIDO" />
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="MAIL" class="control-label col-md-2">Correo Electrónico</label>
                        <div class="col-md-10">
                            <input type="email" name="MAIL" class="form-control" value="@Model.MAIL" />
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="PASSWORD" class="control-label col-md-2">Contraseña</label>
                        <div class="col-md-10">
                            <input type="password" name="PASSWORD" class="form-control" value="@Model.PASSWORD" />
                        </div>
                    </div>

                    <div class="form-group">
                        <label for="TELEFONO" class="control-label col-md-2">Teléfono</label>
                        <div class="col-md-10">
                            <input type="text" name="TELEFONO" class="form-control" value="@Model.TELEFONO" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="FECHA_NACIMIENTO" class="control-label col-md-2">Fecha de Nacimiento</label>
                        <div class="col-md-10">
                            <input type="text" name="FECHA_NACIMIENTO" class="form-control" value="@Model.FECHA_NACIMIENTO" />
                        </div>
                    </div>
                    <div Class="form-group">
                        <Label for="DNI" class="control-label col-md-2">DNI</Label>
                        <div Class="col-md-10">
                            <input type="text" name="DNI" Class="form-control" value="@Model.DNI" />
                        </div>
                    </div>



                    <div Class="form-group">
                        <div Class="col-md-offset-2 col-md-10">
                            <input type="submit" value="Guardar Cambios" Class="btn btn-primary" />
                        </div>
                    </div>

                </form>
            </div>
        </div>
        </div>
</body>
</html>
