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
                        <h1 class="display-4 text-primary">Árbol Binario - Manejo de componentes de Hardware</h1>
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
                                            <button class="nav-link text-black-50" id="nav-disabled-tab" data-bs-toggle="tab" data-bs-target="#nav-disabled" type="button" role="tab" aria-controls="nav-disabled" aria-selected="false" disabled>Borrar todo</button>
                                          </div>
                                    </nav>
                                    <div class="tab-content" id="nav-tabContent">
                                      <div class="tab-pane fade show active" id="nav-home" role="tabpanel" aria-labelledby="nav-home-tab" tabindex="0">
                                          <br />
                                          <div class="text-center">
                                              <div class="shadow-lg p-3 mb-5 bg-body rounded">
                                                  <label for="DropDownList1" class="form-label fs-3 fw-semibold">Seleccionar archivo de restauración</label>
                                                  <div class="mb-3">
                                                      <div class="row align-items-start">
                                                          <div class="d-grid gap-2 col-4 mx-auto">
                                                            <asp:Button ID="Button3" class="btn text-light bg-secondary mb-2" runat="server" Text="Mostrar archivos" OnClick="Button3_Click" />
                                                          </div>
                                                      </div>
                                                      <asp:ScriptManager ID="ScriptManager1" ScriptMode="Release" AsyncPostBackTimeout="360000" EnablePageMethods="true" runat="server"> 
    
                                                            <Scripts>
                                                                <asp:ScriptReference Path="~/js/jquery-3.4.1.min.js" />
                                                                <asp:ScriptReference Path="~/Scripts/bootstrap.min.js" />

                                                            </Scripts>
                                                          
                                                      </asp:ScriptManager>
                                                      <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                                          <ContentTemplate>
                                                              <asp:DropDownList ID="DropDownList1" Visible="false" class="dropdown bg-gradient bg-opacity-75 bg-warning" AutoPostBack="true" 
                                                                    AppendDataBoundItems="true"  runat="server" BackColor="#0066CC" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                                                  <asp:ListItem>Seleccionar Archivo</asp:ListItem>

                                                              </asp:DropDownList>
                                                          </ContentTemplate>

                                                          <Triggers>
                                                                <asp:AsyncPostbackTrigger ControlID="DropDownList1" EventName="SelectedIndexChanged" />
                                                          </Triggers>
                                                      </asp:UpdatePanel>
                                                      
                                                      <br />
                                                  </div>

                                                  <div class="row align-items-start">
                                                                <div class="d-grid gap-2 col-4 mx-auto">
                                                                        <asp:Button ID="Button1" runat="server" class="btn text-warning bg-dark" Text="Restaurar" OnClick="Button1_Click" />
                                                                </div> 
                                                  </div>

                                              </div>
                                              
                                               

                                          </div>

                                          <%--<div class="input-group mb-2">
                                                <asp:FileUpload ID="FileUpload1" type="file" class="form-control" runat="server" /><label class="input-group-text" for="FileUpload1">Archivo de Restauración</label>
                                          </div>--%>
                                         
                                             
                                                
                                          

                                      
                                      </div>

                                      <div class="tab-pane fade" id="nav-profile" role="tabpanel" aria-labelledby="nav-profile-tab" tabindex="0">
                                          <br />

                                          <div class="text-center"></div>
                                          <div class="shadow-lg p-3 mb-5 bg-body rounded">
                                                  
                                                <label for="TB1" class="form-label fs-3 fw-semibold">Nombrar archivo de respaldo</label>
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

                            </div>


                            <div class="mb-3">

                                <div>
                                    <%--<h3 class="display-3 text-info fs-2 fw-bolder">Agregar componentes de Hardware</h3>--%>
                                </div>
                                <div class="text-center">                               

                                    <div class="card text-center">
                                              <div class="card-header">
                                                    Novedad
                                              </div>
                                              <div class="card-body">
                                                    <h5 class="card-title">¡Añade componentes!</h5>
                                                    <p class="card-text">Completa los campos, agregando información importante sobre los componentes e incluso asigna imagenes.</p>
                                                    <a href="WebForm1.aspx" class="btn btn-primary">Visitar</a>
                                              </div>
                                              <div class="card-footer text-muted">
                                                 8 days ago
                                              </div>
                                        <br />
                                    </div>

                                </div>

                            </div>



                            <div class="mb-3">

                                <div>
                                    <%--<h3 class="display-3 text-info fs-2 fw-bolder">Ver listado de componentes</h3>--%>
                                </div>
                                <div class="text-center">                               

                                    <div class="card text-center">
                                              <div class="card-header">
                                                    Novedad
                                              </div>
                                              <div class="card-body">
                                                    <h5 class="card-title">¡Consulta los componentes registrados!</h5>
                                                    <p class="card-text">Observa los diferentes recorridos que tiene el árbol binario.</p>
                                                    <a href="WebForm3.aspx" class="btn btn-success">Visitar</a>
                                              </div>
                                              <div class="card-footer text-muted">
                                                 5 days ago
                                              </div>
                                        <br />
                                    </div>

                                </div>

                            </div>


                            <div class="mb-3">

                                <div>
                                    <%--<h3 class="display-3 text-info fs-2 fw-bolder">Busqueda de componentes</h3>--%>
                                </div>
                                <div class="text-center">                               

                                    <div class="card text-center">
                                              <div class="card-header">
                                                    Novedad
                                              </div>
                                              <div class="card-body">
                                                    <h5 class="card-title">¡Busca o elimina componentes!</h5>
                                                    <p class="card-text">Ingresa la clave de algun componente y verifica la información disponible.</p>
                                                    <a href="WebForm4.aspx" class="btn btn-danger">Visitar</a>
                                              </div>
                                              <div class="card-footer text-muted">
                                                 2 days ago
                                              </div>
                                        <br />
                                    </div>

                                </div>

                            </div>


                            <div class="mb-3">

                                <div>
                                    <%--<h3 class="display-3 text-info fs-2 fw-bolder">Gráfico de componentes</h3>--%>
                                </div>
                                <div class="text-center">                               

                                    <div class="card text-center">
                                              <div class="card-header">
                                                    Novedad
                                              </div>
                                              <div class="card-body">
                                                    <h5 class="card-title">¡Consulta el gráfico del árbol binario!</h5>
                                                    <p class="card-text">Ve un agradable y dinamico gráfico de componentes.</p>
                                                    <a href="WebForm5.aspx" class="btn btn-warning">Visitar</a>
                                              </div>
                                              <div class="card-footer text-muted">
                                                 Today
                                              </div>
                                        <br />
                                    </div>

                                </div>

                            </div>
                            
                            

                        </div>


                        <div class="col-md-3"></div>
                    </div>

                     
            </div>
           


        </div>
        


    </form>
</body>
</html>
