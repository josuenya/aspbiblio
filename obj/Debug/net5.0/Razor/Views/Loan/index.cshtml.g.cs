#pragma checksum "/home/oem/ASP/aspbiblio/Views/Loan/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af7cf9a933d60dfb67331ab9a964d3cb24cf476a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loan_index), @"mvc.1.0.view", @"/Views/Loan/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af7cf9a933d60dfb67331ab9a964d3cb24cf476a", @"/Views/Loan/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5daf4c1dbd097a780b95f90d17c53c725213052", @"/Views/_ViewImports.cshtml")]
    public class Views_Loan_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<aspbiblio.Models.Loan>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\n            <div class=\"col-md-12 stretch-card\">\n              <div class=\"card\">\n                <div class=\"card-body\">\n");
            WriteLiteral(@"                  <button type=""button"" class=""btn btn-primary"">Ajouter Un Nouveau Emprunt</button>
                  <div class=""table-responsive"">
                    <table id=""recent-purchases-listing"" class=""table"">
                      <thead>
                        <tr>
                            <th>Nom</th> 
                            <th>Books</th>
                            <th>Status</th>
                            <th>Date de retour</th>
                            <th>Date d'emprunt</th>
                            <th>Modifier le:</th>
                            <th>Action</th>
                        </tr>
                      </thead>
                      <tbody>
");
#nullable restore
#line 22 "/home/oem/ASP/aspbiblio/Views/Loan/index.cshtml"
                         foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <tr>\n                                  <td>\n                                      ");
#nullable restore
#line 25 "/home/oem/ASP/aspbiblio/Views/Loan/index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.users_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                  </td>\n                                  <td>\n                                      ");
#nullable restore
#line 28 "/home/oem/ASP/aspbiblio/Views/Loan/index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.libelle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                  </td>\n                                  <td>\n                                      ");
#nullable restore
#line 31 "/home/oem/ASP/aspbiblio/Views/Loan/index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                  </td>\n                                  <td>\n                                      ");
#nullable restore
#line 34 "/home/oem/ASP/aspbiblio/Views/Loan/index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.return_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                  </td>\n                                  <td>\n                                      ");
#nullable restore
#line 37 "/home/oem/ASP/aspbiblio/Views/Loan/index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.created_at));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                  </td>\n                                  <td>\n                                      ");
#nullable restore
#line 40 "/home/oem/ASP/aspbiblio/Views/Loan/index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.updated_at));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                  </td>\n                                  <td>\n                                      ");
#nullable restore
#line 43 "/home/oem/ASP/aspbiblio/Views/Loan/index.cshtml"
                                 Write(Html.ActionLink("Edit", "Edit", new { id=item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                                      ");
#nullable restore
#line 44 "/home/oem/ASP/aspbiblio/Views/Loan/index.cshtml"
                                 Write(Html.ActionLink("Details", "Details", new { id=item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  |\n                                      ");
#nullable restore
#line 45 "/home/oem/ASP/aspbiblio/Views/Loan/index.cshtml"
                                 Write(Html.ActionLink("Delete", "Delete", new { id=item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n                                  </td>\n                              </tr>\n");
#nullable restore
#line 48 "/home/oem/ASP/aspbiblio/Views/Loan/index.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("                      </tbody>\n                    </table>\n                  </div>\n                </div>\n              </div>\n            </div>\n          </div>\n        </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<aspbiblio.Models.Loan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
