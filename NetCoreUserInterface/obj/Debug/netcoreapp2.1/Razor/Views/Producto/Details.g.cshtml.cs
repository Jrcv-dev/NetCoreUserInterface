#pragma checksum "C:\Users\Curso\source\repos\NetCoreUserInterface\NetCoreUserInterface\Views\Producto\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e721518d18d8d161d76a13c76eacbde621e421d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Details), @"mvc.1.0.view", @"/Views/Producto/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Producto/Details.cshtml", typeof(AspNetCore.Views_Producto_Details))]
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
#line 1 "C:\Users\Curso\source\repos\NetCoreUserInterface\NetCoreUserInterface\Views\_ViewImports.cshtml"
using NetCoreUserInterface;

#line default
#line hidden
#line 2 "C:\Users\Curso\source\repos\NetCoreUserInterface\NetCoreUserInterface\Views\_ViewImports.cshtml"
using NetCoreUserInterface.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e721518d18d8d161d76a13c76eacbde621e421d", @"/Views/Producto/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"742fc0d8196178e95163226c6c0147123c9a6e34", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NetCoreUserInterface.Models.Producto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Curso\source\repos\NetCoreUserInterface\NetCoreUserInterface\Views\Producto\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(90, 221, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Producto</h4>\r\n    <hr />\r\n    <div>\r\n        <hr />\r\n\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 311, "\"", 355, 1);
#line 18 "C:\Users\Curso\source\repos\NetCoreUserInterface\NetCoreUserInterface\Views\Producto\Details.cshtml"
WriteAttributeValue("", 317, Html.DisplayFor(model => model.image), 317, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(356, 106, true);
            WriteLiteral(" />\r\n                </div>\r\n                <div class=\"col-md-6\">\r\n                    <h2 class=\"name\">");
            EndContext();
            BeginContext(463, 36, false);
#line 21 "C:\Users\Curso\source\repos\NetCoreUserInterface\NetCoreUserInterface\Views\Producto\Details.cshtml"
                                Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(499, 69, true);
            WriteLiteral("</h2><br />\r\n                    <p class=\"description\">Descripción: ");
            EndContext();
            BeginContext(569, 43, false);
#line 22 "C:\Users\Curso\source\repos\NetCoreUserInterface\NetCoreUserInterface\Views\Producto\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.description));

#line default
#line hidden
            EndContext();
            BeginContext(612, 62, true);
            WriteLiteral("</p><br />\r\n                    <label class=\"price\">Precio: $");
            EndContext();
            BeginContext(675, 37, false);
#line 23 "C:\Users\Curso\source\repos\NetCoreUserInterface\NetCoreUserInterface\Views\Producto\Details.cshtml"
                                             Write(Html.DisplayFor(model => model.price));

#line default
#line hidden
            EndContext();
            BeginContext(712, 78, true);
            WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(791, 69, false);
#line 27 "C:\Users\Curso\source\repos\NetCoreUserInterface\NetCoreUserInterface\Views\Producto\Details.cshtml"
   Write(Html.ActionLink("Edit Product", "Edit", new { id = Model.IdProduct }));

#line default
#line hidden
            EndContext();
            BeginContext(860, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(871, 73, false);
#line 28 "C:\Users\Curso\source\repos\NetCoreUserInterface\NetCoreUserInterface\Views\Producto\Details.cshtml"
   Write(Html.ActionLink("Delete Product", "Delete", new { id = Model.IdProduct }));

#line default
#line hidden
            EndContext();
            BeginContext(944, 41, true);
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(986, 68, false);
#line 32 "C:\Users\Curso\source\repos\NetCoreUserInterface\NetCoreUserInterface\Views\Producto\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1062, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d226ce836c4545438d22509f4ca5f090", async() => {
                BeginContext(1084, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1100, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetCoreUserInterface.Models.Producto> Html { get; private set; }
    }
}
#pragma warning restore 1591
