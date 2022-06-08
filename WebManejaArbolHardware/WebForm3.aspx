<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebManejaArbolHardware.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recorridos</title>
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
                                            Arbol Binario - Hardware
                                   </a>
                                  <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
                                    <span class="navbar-toggler-icon"></span>
                                  </button>
                                  <div class="collapse navbar-collapse" id="navbarColor01">
                                        <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                                          <li class="nav-item">
                                            <a class="nav-link" aria-current="page" href="WebForm1.aspx">Insertar componentes</a>
                                          </li>
                                          <li class="nav-item">
                                            <a class="nav-link active" href="WebForm3.aspx">Recorridos</a>
                                          </li>
                                          <li class="nav-item">
                                            <a class="nav-link" href="#">Buscar & eliminar</a>
                                          </li>
                                          <li class="nav-item">
                                            <a class="nav-link" href="#">Graficación</a>
                                          </li>
                                        </ul>
                                  </div>
                            </div>
                </nav>
        
        <div class="form-group">
            <br />
            <br />
            <div class="container-fluid">
                    <div class="text-center">
                        <h1 class="display-4 text-primary">Recorridos</h1>


                    </div>



                <div class="row">
                        <div class="col-md-2"></div>

                        <div class="col-md-8">
                            <br />
                            <div class="card mb-3">
                                  <div class="card-body">
                                    <h5 class="card-title">Pre-Order</h5>
                                    <p class="card-text">En el orden <strong>Pre-Order</strong> se recorre de la siguiente manera: raíz, subárbol izquierdo, subárbol derecho.
                                      </p>
                                  </div>
                                  <asp:Image ID="Image1" class="card-img-bottom" runat="server" />  
                            </div>


                             <div class="card mb-3">
                                  <div class="card-body">
                                    <h5 class="card-title">In-Order</h5>
                                    <p class="card-text">En el orden <strong>In-Order</strong> se recorre de la siguiente manera: subárbol izquierdo, raíz, subárbol derecho.</p>
                                  </div>
                                  <asp:Image ID="Image2" class="card-img-bottom" runat="server" />
                            </div>


                             <div class="card mb-3">
                                  <div class="card-body">
                                    <h5 class="card-title">Post-Order</h5>
                                    <p class="card-text">En el orden <strong>Post-Order</strong> se recorre de la siguiente manera: subárbol izquierdo, subárbol derecho, raíz.</p>
                                  </div>
                                  <asp:Image ID="Image3" class="card-img-bottom" runat="server" />
                            </div>
                            
                            
                        </div>


                        <div class="col-md-2"></div>
                    </div>




                    <div>
                        
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
