#pragma checksum "/home/oem/ASP/aspbiblio/Views/Autor/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "067e5b7de3c0cdc6015e90655d41ebd75ee33e36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autor_index), @"mvc.1.0.view", @"/Views/Autor/index.cshtml")]
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
#line 1 "/home/oem/ASP/aspbiblio/Views/_ViewImports.cshtml"
using aspbiblio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/oem/ASP/aspbiblio/Views/_ViewImports.cshtml"
using aspbiblio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"067e5b7de3c0cdc6015e90655d41ebd75ee33e36", @"/Views/Autor/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5daf4c1dbd097a780b95f90d17c53c725213052", @"/Views/_ViewImports.cshtml")]
    public class Views_Autor_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<aspbiblio.Models.Autor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \n");
            WriteLiteral("\n<div class=\"row\">\n  <div class=\"col-md-12 stretch-card\">\n    <div class=\"card\">\n      <div class=\"card-body\">\n");
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "067e5b7de3c0cdc6015e90655d41ebd75ee33e364093", async() => {
                WriteLiteral("Ajouter Un Nouveau Auteur de livre");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div class=""table-responsive"">
          <table id=""recent-purchases-listing"" class=""table"">
            <thead>
              <tr>
                  <th>Nom</th> 
                  <th>Telephone</th>
                  <th>Creer le:</th>
                  <th>Modifier le:</th>
                  <th>Action</th>
              </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 22 "/home/oem/ASP/aspbiblio/Views/Autor/index.cshtml"
               foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 25 "/home/oem/ASP/aspbiblio/Views/Autor/index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 28 "/home/oem/ASP/aspbiblio/Views/Autor/index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 31 "/home/oem/ASP/aspbiblio/Views/Autor/index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.created_at));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 34 "/home/oem/ASP/aspbiblio/Views/Autor/index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.updated_at));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 37 "/home/oem/ASP/aspbiblio/Views/Autor/index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id=item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                        ");
#nullable restore
#line 38 "/home/oem/ASP/aspbiblio/Views/Autor/index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id=item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  |\n                        ");
#nullable restore
#line 39 "/home/oem/ASP/aspbiblio/Views/Autor/index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id=item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n                    </td>\n                </tr>\n");
#nullable restore
#line 42 "/home/oem/ASP/aspbiblio/Views/Autor/index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n          </table>\n        </div>\n      </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<aspbiblio.Models.Autor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
