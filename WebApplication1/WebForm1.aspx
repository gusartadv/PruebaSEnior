<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="row">
                ID
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                <asp:Button ID="BtnConsultarid" runat="server" Text="Consultar por ID" OnClick="BtnConsultarid_Click" />&nbsp
          <asp:Label ID="lblId" runat="server" Text="Label"></asp:Label>
            </div>
            <div class="row">
                      <br/>
                Descripcion
               <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                Tipo
               <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
            </div>
           
            <br/>
            <div class="row">   
                <asp:Button ID="BtnInsertar" runat="server" Text="insertar nuevo" OnClick="BtnInsertar_Click" /> &nbsp
                <asp:Button ID="BtnModificar" runat="server" Text="Modificar" OnClick="BtnModificar_Click" /> &nbsp
                <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" OnClick="BtnEliminar_Click" />&nbsp
                <asp:Button ID="BtnConsultarTodo" runat="server" Text="Consultar Todo" OnClick="BtnConsultarTodo_Click" />&nbsp
            </div>

            <div class="row">
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                <br />
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </div>


        </div>
    </form>
</body>
</html>
