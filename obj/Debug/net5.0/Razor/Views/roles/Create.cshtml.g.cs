#pragma checksum "/home/oem/ASP/aspbiblio/Views/roles/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b4827b3a53497378cf67176a70b5fed916a7cc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_roles_Create), @"mvc.1.0.view", @"/Views/roles/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b4827b3a53497378cf67176a70b5fed916a7cc5", @"/Views/roles/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5daf4c1dbd097a780b95f90d17c53c725213052", @"/Views/_ViewImports.cshtml")]
    public class Views_roles_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md-12 stretch-card\">\n        <div class=\"card\">\n            <div class=\"card-body\">\n");
#nullable restore
#line 10 "/home/oem/ASP/aspbiblio/Views/roles/Create.cshtml"
                 using(Html.BeginForm("Save","Roles",FormMethod.Post)){ 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""form-group"">
                        <label for=""libelle"">Libelle</label>
                        <input type=""text"" name=""libelle"" class=""form-control"" id=""libelle"" placeholder=""Libelle"">
                    </div>
                    <div class=""form-group"">
                        <label for=""description"">Description</label>
                        <input type=""text"" name=""description"" class=""form-control"" id=""description""  placeholder=""Description"">
                    </div>  
                    <button type=""submit"" class=""btn btn-primary mr-2"">Enregistrer</button>
");
#nullable restore
#line 20 "/home/oem/ASP/aspbiblio/Views/roles/Create.cshtml"
                } 

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</div>");
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