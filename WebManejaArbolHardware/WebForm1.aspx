<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebManejaArbolHardware.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BinaryTree</title>
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
                    <a class="nav-link active" aria-current="page" href="WebForm1.aspx">Insertar componentes</a>
                  </li>
                  <li class="nav-item">
                    <a class="nav-link" href="WebForm3.aspx">Recorridos</a>
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

        <div style="height: 800px">
            <div class="form-group">
                <br />
                <br />
                <div class="row-cols-2">
                    <div></div>
                    <div class="container-fluid">
                    
                        <div class="text-center">
                        <h1 class="display-4 text-primary">Agregar componentes</h1>

                        <br />
                        </div>
                        <div class="form-floating mb-3">
                            <asp:TextBox ID="TB1" runat="server" type="number" class="form-control" placeholder="15" TextMode="Number"></asp:TextBox>
                            <label for="TB1">Clave</label>
                        </div>
                        <div class="form-floating mb-3">
                            <asp:TextBox ID="TB2" runat="server" type="text" class="form-control" placeholder="Perífericos"></asp:TextBox>
                            <label for="TB2">Categoria</label>
                        </div>
                        <div class="form-floating mb-3">
                            <asp:TextBox ID="TB3" runat="server" type="text" class="form-control" placeholder="Corsair"></asp:TextBox>
                            <label for="floatingMarca">Marca</label>
                        </div>
                        <div class="form-floating mb-3">
                            <asp:TextBox ID="TB4" runat="server" type="text" class="form-control" placeholder="HS-45"></asp:TextBox>
                            <label for="TB4">Modelo</label>
                        </div>
                        <div class="form-floating mb-3">
                            <asp:TextBox ID="TB5" runat="server" type="text" class="form-control" placeholder="A000-1052"></asp:TextBox>
                            <label for="TB5">Serie</label>
                        </div>
                        <div class="form-floating mb-3">
                            <asp:TextBox ID="TB6" runat="server" type="text" class="form-control" placeholder="Auriculares de Diadema para PC con Sonido Envolvente 7.1 Virtual Surround con USB "></asp:TextBox>
                            <label for="TB6">Descripción</label>
                        </div>

                        <%--sadsak--%>
                
                        <div class="accordion mb-3" id="accordionExample">
                              <div class="accordion-item">
                                <h2 class="accordion-header" id="headingOne">
                                  <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                                    Agregar imágen #1
                                  </button>
                                </h2>
                                <div id="collapseOne" class="accordion-collapse collapse show bg-primary" aria-labelledby="headingOne" data-bs-parent="#accordionExample">
                                  <div class="accordion-body">
                                    <div class="input-group mb-3">
                                        <asp:FileUpload ID="FileUpload1" runat="server" type="file" class="form-control" accept="image/*"  /><label class="input-group-text" for="FileUpload1">Subir 1° Imagen</label>
                                    </div>
                                  </div>
                                </div>
                              </div>
                              <div class="accordion-item">
                                <h2 class="accordion-header" id="headingTwo">
                                  <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
                                    Agregar imágen #2</button>
                                </h2>
                                <div id="collapseTwo" class="accordion-collapse collapse bg-warning" aria-labelledby="headingTwo" data-bs-parent="#accordionExample" >
                                  <div class="accordion-body ">
                                      <div class="input-group mb-3">
                                          <asp:FileUpload ID="FileUpload2" runat="server" type="file" class="form-control" accept="image/*" /><label class="input-group-text" for="FileUpload2">Subir 2° Imagen</label>
                                      </div>
                                  </div>
                                </div>
                              </div>
                        </div>

                        <%--sadasas--%>
                        <hr />
                        <div class="d-grid gap-2 col-6 mx-auto">
                               <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" type="button" class="btn text-light bg-success" Text="Agregar Componente" />
                        </div>
                        
                    </div>

                    <div></div>

                </div>
                
            </div>




            
            

            <div>

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
