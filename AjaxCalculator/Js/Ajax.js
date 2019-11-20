$(document).ready(function () {
    $("#btnSuma").click(function (e) {
        var suma = {
            a: $("#TextBox1").val(),
            b: $("#TextBox2").val()
        };
        var parameters = JSON.stringify(suma);
        $.ajax({
            type: "POST",                                              
            url: '../Controlador/ServicioWeb.asmx/suma',
            data: parameters,                                               
                                                                         
            contentType: "application/json; charset=utf-8",            
            dataType: "JSON",  
            async: true,                                                  
            success: function (resultado) {
                console.log(resultado);
                var sum = resultado.d;
                $('#lblMensaje').text(sum);
            }
        });
    });
});

$(document).ready(function () {
    $('#btnResta').click(function (e) {
        var resta = {
            a: $('#TextBox1').val(),
            b: $('#TextBox2').val()
        };
        var parameters = JSON.stringify(resta);
        $.ajax({
            type: "POST",
            url: '../Controlador/ServicioWeb.asmx/resta',
            data: parameters,

            contentType: "application/json; charset=utf-8",
            dataType: "JSON",
            success: function (resultado) {
                console.log(resultado);
                var rest = resultado.d;
                $("#lblMensaje").text(rest);
            }
        });
    });
});

$(document).ready(function () {
    $('#btnMul').click(function (e) {
        var mul = {
            a: $('#TextBox1').val(),
            b: $('#TextBox2').val()
        }
        var parameters = JSON.stringify(mul);
        $.ajax({
            type: "POST",
            url: '../Controlador/ServicioWeb.asmx/multiplica',
            data: parameters,

            contentType: "application/json; charset=utf-8",
            dataType: "JSON",
            success: function (resultado) {
                console.log(resultado);
                var mul = resultado.d;
                $('#lblMensaje').text(mul);
            }
        });
    });
});

$(document).ready(function () {
    $('#btnDiv').click(function (e) {
        var mul = {
            a: $('#TextBox1').val(),
            b: $('#TextBox2').val()
        }
        var parameters = JSON.stringify(mul);
        $.ajax({
            type: "POST",
            url: '../Controlador/ServicioWeb.asmx/divida',
            data: parameters,

            contentType: "application/json; charset=utf-8",
            dataType: "JSON",
            success: function (resultado) {
                console.log(resultado);
                var mul = resultado.d;
                $('#lblMensaje').text(mul);
            }
        });
    });
});