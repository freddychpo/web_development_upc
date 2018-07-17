<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AplicacionWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
		<div class="top">
        &nbsp;<img src="../images/LogoBCP.png" style="height:50px; width: 130px" style="top:80px;">
        <h1 id="title" class="hidden"><span id="logo">Bienvenido</span></h1>
		</div>
		<div class="login-box animated fadeInUp">
			<div class="box-header">
				<h2>Iniciar Sesión</h2>
			</div>
			<label for="username">Usuario</label>
			<br/>
			<input type="text" id="username" runat="server">
			<br/>
			<label for="password">Contraseña</label>
			<br/>
			<input type="password" id="password" runat="server">
			<br/>
			<asp:Button CssClass = "ButtonStyle" ID="BtnIngresar" runat="server" 
                Text="INGRESAR" ForeColor="White" Font-Size="Small" Height="32px" 
                onclick="BtnIngresar_Click" Width="116px" />
			<br/>
            <asp:Label ID="LblError" runat="server" Font-Size="X-Small"></asp:Label>
			<a href="#"><p class="small">Olvidaste tu contraseña?</p></a>
		</div>
	</div>
</asp:Content>
