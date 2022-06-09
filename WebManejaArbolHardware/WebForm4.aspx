<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebManejaArbolHardware.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Buscar y eliminar</title>
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
                                            <a class="nav-link active" href="WebForm4.aspx">Buscar & eliminar</a>
                                          </li>
                                          <li class="nav-item">
                                            <a class="nav-link" href="WebForm5.aspx">Graficación</a>
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
                        <h1 class="display-4 text-primary">Buscar y eliminar</h1>

                    </div>



                <div class="row">
                    <div class="col-md-3">

                    </div>

                    
                    <div class="col-md-6">
                        <br />
                        <div class="card bg-opacity-25 bg-gradient bg-info">
                              <div class="card-body">
                                    <h5 class="card-title">Busqueda de componentes</h5>
                                    <%--<p class="card-text">With supporting text below as a natural lead-in to additional content.</p>--%>
                                    <div class="form-group">
                                        <div class="mb-3">
                                          <label for="TextBox1" class="form-label">Clave de componente</label>
                                            <asp:TextBox ID="TextBox1" runat="server" type="text" class="form-control" placeholder="example: 117"></asp:TextBox>
                                        </div>

                                        <div class="d-grid gap-2 col-3 mx-auto">
                                             <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Buscar" OnClick="Button1_Click" />
                                        </div>
                                        <hr />
                                    </div>
                                    
                                    <div class="form-group">
                                        


                                        <div class="text-center">
                                        <div class="row">
                                            <div class="col-md-2">
                                                <asp:Image ID="Image1" class="rounded float-start" runat="server" Height="150px" Width="150px" />
                                            </div>
                                            <div class="col-md-8">
                                                <div class="form-floating mb-3">
                                                      <asp:TextBox ID="TBClave" class="form-control" type="text" runat="server" aria-label="Disabled input example" disabled readonly></asp:TextBox>
                                                      <label for="TBClave">Clave</label>
                                                </div>
                                                <div class="form-floating mb-3">
                                                      <asp:TextBox ID="TBCategoria" class="form-control" type="text" runat="server" aria-label="Disabled input example" disabled readonly></asp:TextBox>
                                                      <label for="TBCategoria">Categoria</label>
                                                </div>
                                                <div class="form-floating mb-3">
                                                      <asp:TextBox ID="TBMarca" class="form-control" type="text" runat="server" aria-label="Disabled input example" disabled readonly></asp:TextBox>
                                                      <label for="TBMarca">Marca</label>
                                                </div>
                                                <div class="form-floating mb-3">
                                                      <asp:TextBox ID="TBModelo" class="form-control" type="text" runat="server" aria-label="Disabled input example" disabled readonly></asp:TextBox>
                                                      <label for="TBModelo">Modelo</label>
                                                </div>
                                                <div class="form-floating mb-3">
                                                      <asp:TextBox ID="TBSerie" class="form-control" type="text" runat="server" aria-label="Disabled input example" disabled readonly></asp:TextBox>
                                                      <label for="TBSerie">Serie</label>
                                                </div>
                                                <div class="form-floating mb-3">
                                                      <asp:TextBox ID="TBDesc" class="form-control" type="text" runat="server" aria-label="Disabled input example" disabled readonly></asp:TextBox>
                                                      <label for="TBDesc">Descripción</label>
                                                </div>

                                            </div>
                                            <div class="col-md-2">
                                                <asp:Image ID="Image2" class="rounded float-end" runat="server" Height="150px" Width="150px" />

                                            </div>
                                        </div>
                                        

                                    </div>

                                        
                                    </div>
                              </div>
                        </div>

                        <hr />


                        <div class="card bg-opacity-25 bg-danger">
                              <div class="card-body">
                                    <h5 class="card-title">Eliminar componente</h5>
                                    <%--<p class="card-text">With supporting text below as a natural lead-in to additional content.</p>--%>
                                    <div class="form-group">
                                        <div class="mb-3">
                                          <label for="TextBox2" class="form-label">Clave de componente</label>
                                          <asp:TextBox ID="TextBox2" runat="server" type="text" class="form-control" placeholder="example: 117"></asp:TextBox>
                                        </div>

                                        <div class="d-grid gap-2 col-3 mx-auto">
                                                <asp:Button ID="Button2" runat="server" class="btn btn-danger" Text="Eliminar" OnClick="Button2_Click" />
                                        </div>
                                    </div>
                              </div>
                        </div>

                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                    </div>

                    
                    <div class="col-md-3">

                    </div>
                
                
                
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
