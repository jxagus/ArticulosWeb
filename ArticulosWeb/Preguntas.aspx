<%@ Page Title="Preguntas Frecuentes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Preguntas.aspx.cs" Inherits="ArticulosWeb.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <div class="col-06" style="margin-bottom: 50px;">
            <h2 id="title"><%: Title %></h2>
            <div class="accordion accordion-flush" id="accordionFlushExample">
                <div class="accordion-item">
                    <h2 class="accordion-header">
                        <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseOne" aria-expanded="false" aria-controls="flush-collapseOne">
                            Cuales son los metodos de pago disponible?
                        </button>
                    </h2>
                    <div id="flush-collapseOne" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
                        <div class="accordion-body">Placeholder content for this accordion, which is intended to demonstrate the <code>.accordion-flush</code> class. This is the first item's accordion body.</div>
                    </div>
                </div>
                <div class="accordion-item">
                    <h2 class="accordion-header">
                        <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseTwo" aria-expanded="false" aria-controls="flush-collapseTwo">
                            Cual es el numero para los reclamos?
                        </button>
                    </h2>
                    <div id="flush-collapseTwo" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
                        <div class="accordion-body">Placeholder content for this accordion, which is intended to demonstrate the <code>.accordion-flush</code> class. This is the second item's accordion body. Let's imagine this being filled with some actual content.</div>
                    </div>
                </div>
                <div class="accordion-item">
                    <h2 class="accordion-header">
                        <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseThree" aria-expanded="false" aria-controls="flush-collapseThree">
                            Cuanto tiempo tarda el envio?
                        </button>
                    </h2>
                    <div id="flush-collapseThree" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
                        <div class="accordion-body">Placeholder content for this accordion, which is intended to demonstrate the <code>.accordion-flush</code> class. This is the third item's accordion body. Nothing more exciting happening here in terms of content, but just filling up the space to make it look, at least at first glance, a bit more representative of how this would look in a real-world application.</div>
                    </div>
                </div>
                <div class="accordion-item">
                    <h2 class="accordion-header">
                        <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapseFord" aria-expanded="false" aria-controls="flush-collapseOne">
                            Donde consiguo descuentos?
                        </button>
                    </h2>
                    <div id="flush-collapseFord" class="accordion-collapse collapse" data-bs-parent="#accordionFlushExample">
                        <div class="accordion-body">Placeholder content for this accordion, which is intended to demonstrate the <code>.accordion-flush</code> class. This is the first item's accordion body.</div>
                    </div>
                </div>


            </div>
        </div>
        <!-- Contacto -->
        <div class="contact-form" style="margin-top: 50px;">
            <div class="mb-3" style="margin-top: 50px;">
                <h5>Si desea hacer una pregunta en particular, puede escribirnos a soporte tecnico</h5>
                <label for="txtEmail" class="form-label">Escriba su email</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Placeholder="name@example.com" TextMode="Email"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label class="form-label">Asunto</label>
                <asp:textbox runat="server" ID="txtAsunto" cssclass="form-control"/>
            </div>
            <div class="mb-3">
                <label for="txtMensaje" class="form-label">Escriba un mensaje</label>
                <asp:TextBox ID="txtMensaje" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="3"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Button ID="btnEnviar" runat="server" Text="Enviar" CssClass="btn btn-primary" OnClick="btnEnviar_Click" />
                <asp:Label ID="lblEnviar" runat="server" Text="" CssClass="form-text text-success"></asp:Label>
            </div>
        </div>

    </main>
</asp:Content>
