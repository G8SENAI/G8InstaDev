#pragma checksum "C:\Users\olive\Desktop\G8InstaDev\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b7c46124ca82a76ec511784c2a09ff3de9f2671"
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
#line 1 "C:\Users\olive\Desktop\G8InstaDev\Views\_ViewImports.cshtml"
using G8InstaDev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\olive\Desktop\G8InstaDev\Views\_ViewImports.cshtml"
using G8InstaDev.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b7c46124ca82a76ec511784c2a09ff3de9f2671", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"401fea3524580f9033322c433dd6492eef4bb2d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\olive\Desktop\G8InstaDev\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
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
            <img src=""imgs/storys/tony_stark 1.png"" alt=""foto do usuário"" class=""foto-story"">
            <br>
            <img src=""imgs/story");
            WriteLiteral(@"s/adriano_stark.png"" alt=""Nome do usuario"" class=""espacamento"">
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
            <img src=""imgs/storys/chaves_metal.png"" alt=""Nome do usuario"" class=""espacamento"">
        </div>
    </div>
</section>

<div class=""fotoUSUARIO"">
    <a href=""../Perfil/Index.html""><img src=""imgs/storys/thank-you 2.png"" alt=""foto de perfil do usuario logado""
");
            WriteLiteral(@"            class=""descida""></a>

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


        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b7c46124ca82a76ec511784c2a09ff3de9f26717117", async() => {
                WriteLiteral(@"

            <label>Legenda</label>
            <input type=""text"" name=""Legenda"" />

            <label>Imagem</label>
            <input type=""file"" name=""Imagem"" />


            <button class=""gradient btn"" type=""submit""> Cadastrar </button>
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
#line 68 "C:\Users\olive\Desktop\G8InstaDev\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2671, Url.Action("Cadastrar"), 2671, 24, false);

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
            WriteLiteral("\r\n\r\n</section>\r\n\r\n");
#nullable restore
#line 82 "C:\Users\olive\Desktop\G8InstaDev\Views\Home\Index.cshtml"
 foreach (Feed feed in ViewBag.Feeds)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section class=""postAdicionado flex-bt-center content"">
        <div class=""card"">

            <div class=""perfil"">
                <img class=""foto-perfil"" src=""imgs/postAdicionado/gabigordo 2.png"" alt=""Foto de perfil do usuário"">
                <img");
            BeginWriteAttribute("src", " src=\"", 3321, "\"", 3349, 2);
            WriteAttributeValue("", 3327, "/img/Feed/", 3327, 10, true);
#nullable restore
#line 89 "C:\Users\olive\Desktop\G8InstaDev\Views\Home\Index.cshtml"
WriteAttributeValue("", 3337, feed.Imagem, 3337, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3350, "\"", 3384, 4);
            WriteAttributeValue("", 3356, "Imagem", 3356, 6, true);
            WriteAttributeValue(" ", 3362, "do", 3363, 3, true);
            WriteAttributeValue(" ", 3365, "post", 3366, 5, true);
#nullable restore
#line 89 "C:\Users\olive\Desktop\G8InstaDev\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 3370, feed.Legenda, 3371, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"700\">\r\n\r\n                <div class=\"icones\">\r\n                    <img id=\"imagem_curtida\"");
            BeginWriteAttribute("src", " src=\"", 3484, "\"", 3490, 0);
            EndWriteAttribute();
            WriteLiteral(" onclick=\"curtiu()\" alt=\"Icone curtida\">\r\n                    <img src=\"imgs/postAdicionado/Vector (1).png\" alt=\"icone comentario\" class=\"comentario\">\r\n                    <input type=\"text\" placeholder=\"Comentar...\" ");
#nullable restore
#line 94 "C:\Users\olive\Desktop\G8InstaDev\Views\Home\Index.cshtml"
                                                            Write(feed.Legenda);

#line default
#line hidden
#nullable disable
            WriteLiteral(" class=\"comentario\">\r\n                </div>\r\n\r\n                <p class=\"texto-comentario flutuando\"><b>");
#nullable restore
#line 97 "C:\Users\olive\Desktop\G8InstaDev\Views\Home\Index.cshtml"
                                                    Write(feed.Legenda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n            </div>\r\n    </section>\r\n");
#nullable restore
#line 100 "C:\Users\olive\Desktop\G8InstaDev\Views\Home\Index.cshtml"
}

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
            imagem_curtida.src = ""imgs/postAdicionado/coracaopintado.png""
            div_mens.innerHTML = `${2078}`
        } else {
            imagem_curtida.src = ""imgs/postAdicionado/Vector.png""
            div_mens.innerHTML = `${2077}`
        }
    }
</script>
");
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
