<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="AngelMaldonado.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>

    <address>


        <asp:Label ID="Label1" runat="server" Text="Nombre:      "></asp:Label>


        <asp:TextBox ID="TextBox1" runat="server" Width="263px"></asp:TextBox>


    </address>

    <address>


        <asp:Label ID="Label2" runat="server" Text="Email:"></asp:Label>


        <asp:TextBox ID="TextBox2" runat="server" Width="281px"></asp:TextBox>


    </address>
    <address>


        <asp:Label ID="Label3" runat="server" Text="Comentarios:"></asp:Label>


    </address>
    <address>


        <asp:TextBox ID="TextBox3" runat="server" Height="143px" Width="319px"></asp:TextBox>


    </address>
    <address>

        <asp:Button ID="Button1" runat="server" Text="Enviar Datos" Width="342px" />


    </address>

    <script language="javascript" type="text/javascript">
        function verificar() {
            
            if (document.getElementById("<%=TextBox2.ClientID%>").value == "abel.pech@gmail.com") {
                alert('Tu email es: ' + document.getElementById("<%=TextBox2.ClientID%>").value + ' \nTu nombre es: '+ document.getElementById("<%=TextBox1.ClientID%>").value);
        
            }
            else
            {
                alert('E-mail no valido: ingrese un email correcto.');
            }
        }
    </script>

    <script runat="server">
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Button1.Attributes.Add("OnClick", "javascript:return verificar();");
        }
    </script>

</asp:Content>
