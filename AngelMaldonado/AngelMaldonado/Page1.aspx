<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="AngelMaldonado.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
    <h1>Calculadora</h1>
        </div>
        <asp:Panel ID="Panel1" runat="server" >
            <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" text="Sumar" AutoPostBack="true" />
            <asp:RadioButton ID="RadioButton2" runat="server" text="Restar" OnCheckedChanged="RadioButton2_CheckedChanged" AutoPostBack="true"/>
            <asp:RadioButton ID="RadioButton3" runat="server" text="Multiplicar" OnCheckedChanged="RadioButton3_CheckedChanged" AutoPostBack="true"/>
            <asp:RadioButton ID="RadioButton4" runat="server" text="Division" OnCheckedChanged="RadioButton4_CheckedChanged" AutoPostBack="true"/>
        </asp:Panel>
        <asp:Label ID="Label1" runat="server" Text="Valor 1: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Valor 2: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Operacion" Width="191px" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Resultado: "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="LIMPIAR" OnClick="Button2_Click" Width="358px" />

        
           <script type="text/javascript" language="javascript">
                function CopyToClipboard() 
                { 
                    var controlValue = document.getElementById('<%=TextBox3.ClientID%>').value;
                        window.clipboardData.setData('Text', controlValue);
                        alert('El texto copiado a Clipboard es: ' + controlValue);     
                }
            </script>

            <script runat="server">
                protected void Page_Load(object sender, EventArgs e)
                {
                    this.Button2.Attributes.Add("OnClick", "javascript:return CopyToClipboard();");
                }
            </script>

    </form>
</body>
</html>
