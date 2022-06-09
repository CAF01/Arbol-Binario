<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebManejaArbolHardware.WebForm51" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gráfico</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/sweetalert2.min.js"></script>
    <link rel="Content/stylesheet" href="sweetalert2.min.css"/>
    <script src="//cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</head>
<body>
    <form id="form1" runat="server">
        <script>
                        function registro(alerta,mensaje, tipo)
                        {
                            Swal.fire(
                                alerta,
                                mensaje,
                                tipo
                            )
                        }                       
        </script>
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
            <div class="container-fluid">
               <a class="navbar-brand" href="WebForm2.aspx">
                    <img src="img/style/hard.png" alt="" width="50" height="37" class="d-inline-block align-text-top"/>
                        Árbol Binario - Hardware
               </a>
              <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
              </button>
              <div class="collapse navbar-collapse" id="navbarColor01">
                <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                  <li class="nav-item">
                    <a class="nav-link" aria-current="page" href="WebForm1.aspx">Agregar componentes</a>
                  </li>
                  <li class="nav-item">
                    <a class="nav-link" href="WebForm3.aspx">Recorridos</a>
                  </li>
                  <li class="nav-item">
                    <a class="nav-link" href="WebForm4.aspx">Buscar & eliminar</a>
                  </li>
                  <li class="nav-item">
                    <a class="nav-link active" href="WebForm5.aspx">Graficación</a>
                  </li>
                </ul>
              </div>
            </div>
          </nav>


        <br />
            <br />
            <div class="container-fluid">
                    <div class="text-center">
                        <h1 class="display-4 text-primary">Gráfico de Árbol binario</h1>

                    </div>
                    <br />

                <div class="text-center">


                    <div class="row">
                        <div class="col-md-1"></div>

                        <div class="col-md-10">

                            <div class="form-group">
                                <asp:Image ID="Image1" class="img-fluid" runat="server" />
                            </div>

                        </div>

                        <div class="col-md-1"></div>

                    </div>


                </div>
                
                
            </div>


        <asp:ScriptManager ID="smrTemplate" ScriptMode="Release" AsyncPostBackTimeout="360000" EnablePageMethods="true" runat="server"> 
    
                <Scripts>
                    <asp:ScriptReference Path="~/js/jquery-3.4.1.min.js" />
                    <asp:ScriptReference Path="~/Scripts/bootstrap.min.js" />

                </Scripts>

        </asp:ScriptManager>
    </form>
</body>
</html>
