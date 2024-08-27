@Code
    ViewBag.Title = "Login"
End Code

<!DOCTYPE html>
<html>
<head>
    <title>@ViewBag.Title</title>
    <link rel="stylesheet" type="text/css" href="~/Content/styles.css" />
</head>
<body>
    <div class="container mt-5">
        <h2>Login</h2>
        <div class="row justify-content-center">
            <div class="col-md-6">
              
                <form method="post" action="@Url.Action("Login", "Home")">
                    <div class="form-group">
                        <label for="mail">Email:</label>
                        <input type="text" id="mail" name="mail" class="form-control" required />
                    </div>
                    <div class="form-group">
                        <label for="password">Password:</label>
                        <input type="password" id="password" name="password" class="form-control" required />
                    </div>
                    <button type="submit" class="btn btn-primary">Ingresar</button>
                </form>
                </div>
            
</div>
</div>
</body>
</html>
