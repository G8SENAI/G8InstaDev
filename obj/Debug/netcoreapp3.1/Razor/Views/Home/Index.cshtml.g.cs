<<<<<<< HEAD
#pragma checksum "C:\Users\Pichau\OneDrive\Desktop\instadev\G8InstaDev\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a36a5370598521528781bdc01391bf8164da7b4"
=======
#pragma checksum "C:\Users\olive\Desktop\G8InstaDev\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "957ad09de40656564a5ceda59d964c5bb9373805"
>>>>>>> f277d73f43da3c91a463e0b0bc212d9a59e91a78
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Pichau\OneDrive\Desktop\instadev\G8InstaDev\Views\_ViewImports.cshtml"
using G8InstaDev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pichau\OneDrive\Desktop\instadev\G8InstaDev\Views\_ViewImports.cshtml"
using G8InstaDev.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"957ad09de40656564a5ceda59d964c5bb9373805", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"401fea3524580f9033322c433dd6492eef4bb2d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Link para excluir uma publicacao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Excluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Pichau\OneDrive\Desktop\instadev\G8InstaDev\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<element onclick=\"myScript\">\r\n\r\n\r\n");
            WriteLiteral(@"    <link rel=""stylesheet"" href=""../Feed/css/style.css"">



    <section class=""storys content flex-bt-center"">
        <div class=""barra"">
            <div class=""fotoUM"">
                <img src=""imgs/storys/vin-diesel 1.png"" alt=""foto do usuário"" class=""foto-story"">
                <br>
                <img src=""imgs/storys/vin_diesel.png"" alt=""Nome do usuario"" class=""espacamento"">
            </div>

            <div class=""fotoDOIS"">
                <img src=""imgs/storys/gabigordo 1.png"" alt=""foto do usuário"" class=""foto-story"">
                <br>
                <img src=""imgs/storys/gabigordo.png"" alt=""Nome do usuario"" class=""espacamento"">
            </div>

            <div class=""fotoTRES"">
                <img src=""imgs/storys/will-baiano 1.png"" alt=""foto do usuário"" class=""foto-story"">
                <br>
                <img src=""imgs/storys/will_baiano.png"" alt=""Nome do usuario"" class=""espacamento"">
            </div>

            <div class=""fotoQUATRO"">
           ");
            WriteLiteral(@"     <img src=""imgs/storys/tony_stark 1.png"" alt=""foto do usuário"" class=""foto-story"">
                <br>
                <img src=""imgs/storys/adriano_stark.png"" alt=""Nome do usuario"" class=""espacamento"">
            </div>

            <div class=""fotoCINCO"">
                <img src=""imgs/storys/pele 1.png"" alt=""foto do usuário"" class=""foto-story"">
                <br>
                <img src=""imgs/storys/king_pele.png"" alt=""Nome do usuario"" class=""espacamento"">
            </div>

            <div class=""fotoSEIS"">
                <img src=""imgs/storys/samuel-rosa-bebê 1.png"" alt=""foto do usuário"" class=""foto-story"">
                <br>
                <img src=""imgs/storys/samuel_rosa.png"" alt=""Nome do usuario"" class=""espacamento"">
            </div>

            <div class=""fotoSETE"">
                <img src=""imgs/storys/chaves_metal 1.png"" alt=""foto do usuário"" class=""foto-story"">
                <br>
                <img src=""imgs/storys/chaves_metal.png"" alt=""Nome do usuario""");
            WriteLiteral(@" class=""espacamento"">
            </div>
        </div>
    </section>

    <div class=""fotoUSUARIO"">
        <a href=""../Perfil/Index.html""><img src=""imgs/storys/thank-you 2.png"" alt=""foto de perfil do usuario logado""
                class=""descida""></a>

        <img src=""imgs/storys/yes_baby.png"" alt=""nome do usuario"" class=""sobe"">
        <br>
        <img src=""imgs/storys/Marcos Jeeves.png"" alt=""nome original do usuario"" class=""espacao"">
    </div>

    <section class=""postar flex-bt-center content"">
        <div class=""retangulo"">
            <div class=""imagem-postar"">
                <img src=""imgs/Postar/thank-you 3.png"" alt=""foto de perfil do usuario"">
                <img src=""imgs/Postar/Postar.png"" alt=""texto Postar"" class=""espaco"">
            </div>


<<<<<<< HEAD
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a36a5370598521528781bdc01391bf8164da7b47290", async() => {
=======
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "957ad09de40656564a5ceda59d964c5bb93738058530", async() => {
>>>>>>> f277d73f43da3c91a463e0b0bc212d9a59e91a78
                WriteLiteral(@"

                <input type=""text"" placeholder=""Digite a descrição da imagem..."" class=""descricaoImagem"" name=""Legenda"">

                <label for=""arquivo"">Escolha a imagem</label>
                <input type=""file"" name=""Imagem""  id=""arquivo""/>

                <button class=""btnpostar"" type=""submit""> Postar </button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
<<<<<<< HEAD
#line 74 "C:\Users\Pichau\OneDrive\Desktop\instadev\G8InstaDev\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2832, Url.Action("Cadastrar"), 2832, 24, false);
=======
#line 76 "C:\Users\olive\Desktop\G8InstaDev\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3088, Url.Action("Cadastrar"), 3088, 24, false);
>>>>>>> f277d73f43da3c91a463e0b0bc212d9a59e91a78

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </section>\r\n");
#nullable restore
<<<<<<< HEAD
#line 88 "C:\Users\Pichau\OneDrive\Desktop\instadev\G8InstaDev\Views\Home\Index.cshtml"
 foreach (Feed feed in ViewBag.Feeds)
{
=======
#line 87 "C:\Users\olive\Desktop\G8InstaDev\Views\Home\Index.cshtml"
     foreach (Feed feed in ViewBag.Feeds)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <section class=""postAdicionado flex-bt-center content"">
            <div class=""card"">
                <div class=""perfil"">
                    <img class=""foto-perfil"" src=""imgs/postAdicionado/gabigordo 2.png"" alt=""Foto de perfil do usuário"">
                   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "957ad09de40656564a5ceda59d964c5bb937380511472", async() => {
                WriteLiteral("<img src=\"imgs/lixo.png\" alt=\"Lixeira\" class=\"lixo\">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 93 "C:\Users\olive\Desktop\G8InstaDev\Views\Home\Index.cshtml"
                                                                                                               WriteLiteral(feed.IdPublicacao);
>>>>>>> f277d73f43da3c91a463e0b0bc212d9a59e91a78

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 4048, "\"", 4076, 2);
            WriteAttributeValue("", 4054, "/img/Feed/", 4054, 10, true);
#nullable restore
<<<<<<< HEAD
#line 94 "C:\Users\Pichau\OneDrive\Desktop\instadev\G8InstaDev\Views\Home\Index.cshtml"
WriteAttributeValue("", 3496, feed.Imagem, 3496, 12, false);
=======
#line 94 "C:\Users\olive\Desktop\G8InstaDev\Views\Home\Index.cshtml"
WriteAttributeValue("", 4064, feed.Imagem, 4064, 12, false);
>>>>>>> f277d73f43da3c91a463e0b0bc212d9a59e91a78

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4077, "\"", 4111, 4);
            WriteAttributeValue("", 4083, "Imagem", 4083, 6, true);
            WriteAttributeValue(" ", 4089, "do", 4090, 3, true);
            WriteAttributeValue(" ", 4092, "post", 4093, 5, true);
#nullable restore
<<<<<<< HEAD
#line 94 "C:\Users\Pichau\OneDrive\Desktop\instadev\G8InstaDev\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3529, feed.Legenda, 3530, 13, false);
=======
#line 94 "C:\Users\olive\Desktop\G8InstaDev\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4097, feed.Legenda, 4098, 13, false);
>>>>>>> f277d73f43da3c91a463e0b0bc212d9a59e91a78

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"700\">\r\n                </div>\r\n\r\n                <div class=\"icones\">\r\n                    <img id=\"imagem_curtida\"");
            BeginWriteAttribute("src", " src=\"", 4235, "\"", 4241, 0);
            EndWriteAttribute();
            WriteLiteral(@" onclick=""curtiu()"" alt=""icone curtida"">
                    <img src=""imgs/postAdicionado/Vector (1).png"" alt=""icone comentario"" class=""comentario"">
                    <input type=""text"" placeholder=""Comentar..."" class=""comentario"">
                    <div class=""texto-comentario"" id=""div_mens"">2077</div>
                </div>
                <div class=""comentario-adicionado"">
                    <p class=""texto-comentario""><b>gabigordo</b> ");
#nullable restore
<<<<<<< HEAD
#line 103 "C:\Users\Pichau\OneDrive\Desktop\instadev\G8InstaDev\Views\Home\Index.cshtml"
                                                    Write(feed.Legenda);
=======
#line 104 "C:\Users\olive\Desktop\G8InstaDev\Views\Home\Index.cshtml"
                                                            Write(feed.Legenda);
>>>>>>> f277d73f43da3c91a463e0b0bc212d9a59e91a78

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                   </div>\r\n            </div>\r\n        </section>\r\n");
#nullable restore
<<<<<<< HEAD
#line 107 "C:\Users\Pichau\OneDrive\Desktop\instadev\G8InstaDev\Views\Home\Index.cshtml"
}
=======
#line 108 "C:\Users\olive\Desktop\G8InstaDev\Views\Home\Index.cshtml"
    }
>>>>>>> f277d73f43da3c91a463e0b0bc212d9a59e91a78

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <script>
        var curtidas = 2077;
        imagem_curtida.src = ""imgs/postAdicionado/Vector.png"";

        function curtiu() {
            curtidas++;
            div_mens.innerHTML = `${curtidas}`;
            if (curtidas % 2 == 0) {
                imagem_curtida.src = ""imgs/postAdicionado/Vector.png""
                div_mens.innerHTML = `${2078}`
            } else {
                imagem_curtida.src = ""imgs/postAdicionado/coracaopintado.png""
                div_mens.innerHTML = `${2077}`
            }
        }
    </script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
