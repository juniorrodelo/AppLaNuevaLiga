<%@ Page Title="" Language="C#" MasterPageFile="~/Web/Web.Master" AutoEventWireup="true" CodeBehind="CreatePersonaje.aspx.cs" Inherits="AppLaNuevaLigaASP.Web.CreatePersonaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
	<div class="row">
        <div class="col-sm-12">
        
        </div>
        <!-- panel preview -->
        <div class="col-sm-5">
            <h4>Create personaje:</h4>
            <div class="panel panel-default">
                <div class="panel-body form-horizontal payment-form">


                    <div class="form-group">
                        <asp:Label CssClass="col-sm-3 control-label" ID="Label1" runat="server" Text="Nombre"></asp:Label>
                        <div class="col-sm-9">
                            <asp:TextBox CssClass="form-control" ID="tbNombre" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group">
                          
                        <asp:Label CssClass="col-sm-3 control-label" ID="Label10" runat="server" Text="Genero"></asp:Label>
                        <div class="col-sm-9">
                        <asp:DropDownList CssClass="form-control" ID="dlGenero" runat="server">
                            <asp:ListItem Value="M">Masculino</asp:ListItem>
                            <asp:ListItem Value="F">Femenino</asp:ListItem>
                        </asp:DropDownList>
                        </div>
                    </div>

                    <div class="form-group">
                    <asp:Label CssClass="col-sm-3 control-label" ID="Label14" runat="server" Text="Liga"></asp:Label>
                        <div class="col-sm-9">
                            <asp:RadioButtonList ID="rbLiga" runat="server" 
                                RepeatDirection="Horizontal" RepeatLayout="Table">
                                <asp:ListItem Text="Liga Master" Value="Master"></asp:ListItem>
                                <asp:ListItem Text="Liga Local" Value="Local"></asp:ListItem>
                            </asp:RadioButtonList>   
                        </div>         
                    </div>

                    <div class="form-group">
                        <asp:Label CssClass="col-sm-3 control-label" ID="Label12" runat="server" Text="Nacionalidad"></asp:Label>
                        <div class="col-sm-9">
                            <asp:TextBox CssClass="form-control" ID="tbNacionalidad" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    
                    <div class="form-group">
                          
                        <asp:Label CssClass="col-sm-3 control-label" ID="Label11" runat="server" Text="Clase"></asp:Label>
                        <div class="col-sm-9">
                        <asp:DropDownList onChange="javascript:mostrar(this.value);" CssClass="form-control" ID="TypePersonaje" runat="server">
                            <asp:ListItem Value="humano">Humano</asp:ListItem>
                            <asp:ListItem Value="shumano">Super Humano</asp:ListItem>
                            <asp:ListItem Value="aliens">Aliens</asp:ListItem>
                            <asp:ListItem Value="artificiales">Artificiales</asp:ListItem>
                        </asp:DropDownList>
                        </div>
                    </div> 

                    <div id="Div1" style="display: none;" class="form-group">                        
                        <asp:Label CssClass="col-sm-3 control-label" ID="Label4" runat="server" Text="Version"></asp:Label>
                        <div class="col-sm-9">
                            <asp:TextBox CssClass="form-control" ID="tbVersion" runat="server"></asp:TextBox>
                        </div>
                    </div>

                    <div class="form-group">
                    <asp:Label CssClass="col-sm-3 control-label" ID="Label15" runat="server" Text="Armas"></asp:Label>
                        <div class="col-sm-9">
                        <asp:CheckBox ID="chCatana" runat="server" Text="Catana" /> <br />
                        <asp:CheckBox ID="chAk47" runat="server" AutoPostBack="True" Text="AK47"/> <br />
                        <asp:CheckBox ID="chManun" runat="server" Text="Manun 40" /> <br />
                        <asp:CheckBox ID="chEspada" runat="server" Text="Espada" />
                        </div>
                    </div>


                    <div class="form-group">
                    <asp:Label CssClass="col-sm-3 control-label" ID="Label13" runat="server" Text="Poderes"></asp:Label>
                        <div class="col-sm-9">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Rayos Lazer" /> <br />
                        <asp:CheckBox id="checkbox2" runat="server" AutoPostBack="True" Text="Lanza Llama"/> <br />
                        <asp:CheckBox ID="CheckBox3" runat="server" Text="Golpe Mortal" /> <br />
                        <asp:CheckBox ID="CheckBox4" runat="server" Text="Volar" />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label CssClass="col-sm-3 control-label" ID="Label3" runat="server" Text="Enemigos"></asp:Label>
                            <div class="col-sm-9">
                            <asp:CheckBox ID="CheckBox5" runat="server" Text="Superman" /> <br />
                            <asp:CheckBox id="checkbox6" runat="server" Text="Flash"/> <br />
                            <asp:CheckBox ID="CheckBox7" runat="server" Text="Mujer Marvilla" /> <br />
                            <asp:CheckBox ID="CheckBox8" runat="server" Text="Volar" />
                            </div>
                        </div>


                 <!--   <div class="form-group">
                          
                        <asp:Label CssClass="col-sm-3 control-label" ID="Label2" runat="server" Text="Shipping type"></asp:Label>
                        <div class="col-sm-9">
                        <asp:DropDownList onChange="javascript:mostrar(this.value);" CssClass="form-control" ID="type" runat="server">
                            <asp:ListItem Value="0">Select shiiping</asp:ListItem>
                            <asp:ListItem Value="twodaypackage">Two Day Package</asp:ListItem>
                            <asp:ListItem Value="ordanypackage">Ordany Package</asp:ListItem>
                            <asp:ListItem Value="overnightpackage">Over Night Package</asp:ListItem>
                        </asp:DropDownList>
                        </div>
                    </div> 

                    <div id="twodaypackage" style="display: none;" class="form-group">                        
                        <asp:Label CssClass="col-sm-3 control-label" ID="Label7" runat="server" Text="Fixed Fee"></asp:Label>
                        <div class="col-sm-9">
                            <asp:TextBox CssClass="form-control" ID="tbFixedFee" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    
                    <div id="ordanypackage" style="display: none;" class="form-group">                        
                        <asp:Label CssClass="col-sm-3 control-label" ID="Label9" runat="server" Text="Days"></asp:Label>
                        <div class="col-sm-9">
                            <asp:TextBox CssClass="form-control" ID="tbDays" runat="server"></asp:TextBox>
                        </div>
                    </div> 

                    <div id="overnightpackage" style="display: none;" class="form-group">                        
                        <asp:Label CssClass="col-sm-3 control-label" ID="Label8" runat="server" Text="Additional Charge "></asp:Label>
                        <div class="col-sm-9">
                            <asp:TextBox CssClass="form-control" ID="tbAdditionalCharge" runat="server"></asp:TextBox>
                        </div>
                    </div> 

                    <div class="form-group">                        
                        <asp:Label CssClass="col-sm-3 control-label" ID="Label5" runat="server" Text="Weight in grams"></asp:Label>
                        <div class="col-sm-9">
                            <asp:TextBox CssClass="form-control" ID="tbWeight" runat="server"></asp:TextBox>
                        </div>
                    </div> 

                    <div class="form-group">
                        <asp:Label CssClass="col-sm-3 control-label" ID="Label6" runat="server" Text="Cost x gram"></asp:Label>
                        <div class="col-sm-9">
                            <asp:TextBox CssClass="form-control" ID="tbCosG" runat="server"></asp:TextBox>
                        </div>
                    </div>-->

                   
                    <div class="form-group">
                        <div class="col-sm-12 text-right">
                                <asp:Button CssClass="btn btn-default preview-add-button" ID="Button1" runat="server" OnClick="btnEnviar_Click" Text="Enviar" />
             
                        </div>
                    </div>
                </div>
            </div>            
        </div> <!-- / panel preview -->
	</div>

    </div>



       
    <div>
        <br />

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="Genero" HeaderText="Genero" SortExpression="Genero" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="getPersonaje" TypeName="AppLaNuevaLigaASP.Datos.PersonajesRepositories"></asp:ObjectDataSource>

    </div>



</asp:Content>

