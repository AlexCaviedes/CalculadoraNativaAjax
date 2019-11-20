<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCalculadora.aspx.cs" Inherits="AjaxCalculator.Vista.FrmCalculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous"/>
    <script src="https://code.jquery.com/jquery-3.4.1.js"integrity="sha256-WpOohJOqMqqyKL9FccASB9O0KwACQJpFTUBLTYOVvVU="crossorigin="anonymous"></script>
    </head>
<body>
     <center>
    <div class="container my-4">
        <div class="row">
            <div class="col">
        <div class="card" style="width:470px; height:350px;">
    <form id="form2" runat="server" method="POST">
            <h3 class="card-title text-center my-4">Calculadora básica</h3>
        <div>
            <p>
                <asp:TextBox ID="TextBox1" runat="server" MaxLength="99999999" MinLength="1"></asp:TextBox>
            </p>
            <p>
                <asp:TextBox ID="TextBox2" runat="server" MaxLength="99999999" MinLength="1"></asp:TextBox>
            </p>
        </div>
        <p>
            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <a id="btnSuma" type="button" runat="server" class="btn btn-outline-success">Sumar</a>__
            <a id="btnResta" type="button" runat="server" class="btn btn-outline-warning">Restar</a>__
            <a id="btnMul" type="button" runat="server" class="btn btn-outline-danger">Multiplicar</a>__
            <a id="btnDiv" type="button" runat="server" class="btn btn-outline-info">Dividir</a>
            </p>
            &nbsp;<p>
            &nbsp;</p>
    </form>
            </div>
                <div class="card-footer" style="width:470px">
                    
                </div>
            </div>
        </div>
        </div>
         </center>
   
        <script type="text/javascript" src="../Js/Ajax.js"></script>
     
</body>

</html>
