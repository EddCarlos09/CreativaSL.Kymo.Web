<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div class="box-login">
					<h3>Iniciar sesi&oacute;n</h3>
					<p>
						Introduzca su nombre y contraseña para iniciar sesión.
					</p>
					<form name="Elecciones" class="form-login" method="post" >
						<div class="errorHandler alert alert-danger no-display">
							<i class="fa fa-remove-sign"></i> Hay errores en la captura de información. Revise los datos ingresados.
						</div>
                        <input hidden="hidden" name="hfReturn" id="hfReturn" runat="server" />
						<fieldset>
							<div class="form-group">
								<span class="input-icon">
									<input type="text" class="form-control" name="username" placeholder="Usuario"/>
									<i class="fa fa-user"></i> </span>
							</div>
							<div class="form-group form-actions">
								<span class="input-icon">
									<input type="password" class="form-control password" name="password" placeholder="Contraseña"/>
									<i class="fa fa-lock"></i>
									<a class="forgot" href="#">
										Olvid&eacute; mi contraseña
									</a> </span>
							</div>
							<div class="form-actions">
								<label for="remember" class="checkbox-inline">
									<input type="checkbox"  class="grey remember" id="remember" name="remember"/>
									Mantenerme conectado
								</label>
								<button type="submit" formmethod="post" class="btn btn-green pull-right">
									Iniciar sesi&oacute;n <i class="fa fa-arrow-circle-right"></i>
								</button>
							</div>
							<div class="new-account">
								¿No tienes una cuenta? 
								<a href="#" class="register">
									Crear cuenta
								</a>
							</div>
						</fieldset>
					</form>

					<!-- start: COPYRIGHT -->
					<div class="copyright">
						2017 &copy; Creativa SoftLine.
					</div>
					<!-- end: COPYRIGHT -->
				</div>
</body>
</html>
