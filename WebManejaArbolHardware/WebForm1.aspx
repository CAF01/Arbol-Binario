<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebManejaArbolHardware.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BinaryTree</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 800px">
            <div>
                <h1 id="titulo">Arbol binario - Manejo de componentes de Hardware</h1>
                <hr />
                <h2>Christian Alcantara Flores | 9° "B"</h2>
            </div>

            <div>
                <nav>

                </nav>
            </div>

            <div>
                Clave:

                <asp:TextBox ID="TB1" runat="server"></asp:TextBox>
                <br />
                Categoria:

                <asp:TextBox ID="TB2" runat="server"></asp:TextBox>
                <br />
                Marca:

                <asp:TextBox ID="TB3" runat="server"></asp:TextBox>
                <br />
                Modelo:

                <asp:TextBox ID="TB4" runat="server"></asp:TextBox>
                <br />
                Serie:

                <asp:TextBox ID="TB5" runat="server"></asp:TextBox>
                <br />
                Descripción:
                <asp:TextBox ID="TB6" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar Componente" />




            </div>
            
        </div>
    </form>
</body>
</html>
