<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebManejaArbolHardware.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Principal</title>
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


        <div class="form-group">
            <br />
            <br />
            <div class="container-fluid">
                    <div class="text-center">
                        <h1 class="display-4 text-primary">Arbol Binario - Manejo de componentes de Hardware</h1>
                    </div>
                    
                    
                    <div class="row">
                        <div class="col-md-3"></div>

                        <div class="col-md-6">
                            <br />
                            <div class="mb-3">

                                <div>
                                    <h3 class="display-3 text-info fs-2 fw-bolder">Manejo de archivos</h3>
                                </div>
                                <div class="text-center">                               

                                    <nav>
                                          <div class="nav nav-tabs" id="nav-tab" role="tablist">
                                            <button class="nav-link active" id="nav-home-tab" data-bs-toggle="tab" data-bs-target="#nav-home" type="button" role="tab" aria-controls="nav-home" aria-selected="true">Restaurar archivo de datos</button>
                                            <button class="nav-link" id="nav-profile-tab" data-bs-toggle="tab" data-bs-target="#nav-profile" type="button" role="tab" aria-controls="nav-profile" aria-selected="false">Guardar información</button>
                                            <button class="nav-link text-black-50" id="nav-disabled-tab" data-bs-toggle="tab" data-bs-target="#nav-disabled" type="button" role="tab" aria-controls="nav-disabled" aria-selected="false" disabled>Trabajando...</button>
                                          </div>
                                    </nav>
                                    <div class="tab-content" id="nav-tabContent">
                                      <div class="tab-pane fade show active" id="nav-home" role="tabpanel" aria-labelledby="nav-home-tab" tabindex="0">
                                          <br />
                                          <div class="input-group mb-2">
                                                <asp:FileUpload ID="FileUpload1" type="file" class="form-control" runat="server" /><label class="input-group-text" for="FileUpload1">Archivo de Restauración</label>
                                          </div>
                                          <div class="row align-items-start">
                                              <div class="row">
                                                        <div class="d-grid gap-2 col-4 mx-auto">
                                                                <asp:Button ID="Button1" runat="server" class="btn text-warning bg-dark" Text="Restaurar" OnClick="Button1_Click" />
                                                        </div> 
                                              </div>
                                          </div>
                                             
                                                
                                          

                                      
                                      </div>

                                      <div class="tab-pane fade" id="nav-profile" role="tabpanel" aria-labelledby="nav-profile-tab" tabindex="0">
                                          <br />
                                           <div class="form-floating mb-3">
                                                <asp:TextBox ID="TB1" runat="server" type="text" class="form-control" placeholder="acrhivo"></asp:TextBox>
                                                <label for="TB1">Nombre de archivo</label>
                                           </div>

                                           <div class="row align-items-start">
                                              <div class="row">
                                                        <div class="d-grid gap-2 col-4 mx-auto">
                                                                <asp:Button ID="Button2" runat="server" class="btn text-info bg-dark" Text="Guardar información" OnClick="Button2_Click" />
                                                        </div> 
                                              </div>
                                          </div>

                                      </div>
                                    </div>

                                </div>

                            </div>


                            <div class="mb-3">

                                <div>
                                    <h3 class="display-3 text-info fs-2 fw-bolder">Agregar componentes de Hardware</h3>
                                </div>
                                <div class="text-center">                               

                                    <div class="card text-center">
                                              <div class="card-header">
                                                    Novedad
                                              </div>
                                              <div class="card-body">
                                                    <h5 class="card-title">Special title treatment</h5>
                                                    <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                                                    <a href="WebForm1.aspx" class="btn btn-primary">Visitar</a>
                                              </div>
                                              <div class="card-footer text-muted">
                                                 8 days ago
                                              </div>
                                    </div>

                                </div>

                            </div>



                            <div class="mb-3">

                                <div>
                                    <h3 class="display-3 text-info fs-2 fw-bolder">Ver listado de componentes</h3>
                                </div>
                                <div class="text-center">                               

                                    <div class="card text-center">
                                              <div class="card-header">
                                                    Novedad
                                              </div>
                                              <div class="card-body">
                                                    <h5 class="card-title">Special title treatment</h5>
                                                    <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                                                    <a href="WebForm3.aspx" class="btn btn-success">Visitar</a>
                                              </div>
                                              <div class="card-footer text-muted">
                                                 5 days ago
                                              </div>
                                    </div>

                                </div>

                            </div>


                            <div class="mb-3">

                                <div>
                                    <h3 class="display-3 text-info fs-2 fw-bolder">Busqueda de componentes</h3>
                                </div>
                                <div class="text-center">                               

                                    <div class="card text-center">
                                              <div class="card-header">
                                                    Novedad
                                              </div>
                                              <div class="card-body">
                                                    <h5 class="card-title">Special title treatment</h5>
                                                    <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                                                    <a href="#" class="btn btn-danger">Visitar</a>
                                              </div>
                                              <div class="card-footer text-muted">
                                                 2 days ago
                                              </div>
                                    </div>

                                </div>

                            </div>


                            <div class="mb-3">

                                <div>
                                    <h3 class="display-3 text-info fs-2 fw-bolder">Gráfico de componentes</h3>
                                </div>
                                <div class="text-center">                               

                                    <div class="card text-center">
                                              <div class="card-header">
                                                    Novedad
                                              </div>
                                              <div class="card-body">
                                                    <h5 class="card-title">Special title treatment</h5>
                                                    <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                                                    <a href="#" class="btn btn-warning">Visitar</a>
                                              </div>
                                              <div class="card-footer text-muted">
                                                 Today
                                              </div>
                                    </div>

                                </div>

                            </div>
                            
                            

                        </div>


                        <div class="col-md-3"></div>
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
