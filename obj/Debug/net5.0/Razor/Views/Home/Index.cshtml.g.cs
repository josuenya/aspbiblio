#pragma checksum "/home/oem/aspbiblio/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c1413d3d186d64c0a033ffb9e8b2a5b849be543"
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
#line 1 "/home/oem/aspbiblio/Views/_ViewImports.cshtml"
using aspbiblio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/oem/aspbiblio/Views/_ViewImports.cshtml"
using aspbiblio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c1413d3d186d64c0a033ffb9e8b2a5b849be543", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5daf4c1dbd097a780b95f90d17c53c725213052", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""card"">
  <div class=""card-body"">
    <p class=""card-title"">Etats des Livres Emprunter</p>
  <div class=""table-responsive"">
  <table id=""recent-purchases-listing"" class=""table"">
  <thead>
  <tr>
      <th>Nom</th>
      <th class=""empty"">Type</th>
      <th>Nom du Livre</th> 
      <th>Date Emprunt</th>
      <th>Date De Retour</th>
      <th>Gross amount</th>
  </tr>
  </thead> 
  <tbody>
  <tr>");
#nullable restore
#line 17 "/home/oem/aspbiblio/Views/Home/Index.cshtml"
       if (Model != null)
  {
  var added = false;
  foreach (var t in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("  <tr");
            BeginWriteAttribute("id", " id=\"", 512, "\"", 529, 2);
            WriteAttributeValue("", 517, "tr_", 517, 3, true);
#nullable restore
#line 22 "/home/oem/aspbiblio/Views/Home/Index.cshtml"
WriteAttributeValue("", 520, t.TaskId, 520, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <td><i class=\"mdi mdi-archive\"");
            BeginWriteAttribute("onclick", " onclick=\"", 567, "\"", 603, 3);
            WriteAttributeValue("", 577, "Click(", 577, 6, true);
#nullable restore
#line 23 "/home/oem/aspbiblio/Views/Home/Index.cshtml"
WriteAttributeValue("", 583, t.TaskId, 583, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 592, ",\'Archive\')", 592, 11, true);
            EndWriteAttribute();
            WriteLiteral("></i></td>\r\n    <td");
            BeginWriteAttribute("id", " id=\"", 623, "\"", 651, 2);
            WriteAttributeValue("", 628, "td_incomplete_", 628, 14, true);
#nullable restore
#line 24 "/home/oem/aspbiblio/Views/Home/Index.cshtml"
WriteAttributeValue("", 642, t.TaskId, 642, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 652, "\"", 705, 3);
            WriteAttributeValue("", 660, "display:", 660, 8, true);
#nullable restore
#line 24 "/home/oem/aspbiblio/Views/Home/Index.cshtml"
WriteAttributeValue("", 668, t.Completed == null ? "" : "none", 668, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 704, ";", 704, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n      <i class=\"mdi mdi-archive\"");
            BeginWriteAttribute("onclick", " onclick=\"", 741, "\"", 778, 3);
            WriteAttributeValue("", 751, "Click(", 751, 6, true);
#nullable restore
#line 25 "/home/oem/aspbiblio/Views/Home/Index.cshtml"
WriteAttributeValue("", 757, t.TaskId, 757, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 766, ",\'Complete\')", 766, 12, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n    </td>\r\n    <td");
            BeginWriteAttribute("id", " id=\"", 804, "\"", 830, 2);
            WriteAttributeValue("", 809, "td_complete_", 809, 12, true);
#nullable restore
#line 27 "/home/oem/aspbiblio/Views/Home/Index.cshtml"
WriteAttributeValue("", 821, t.TaskId, 821, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 831, "\"", 884, 3);
            WriteAttributeValue("", 839, "display:", 839, 8, true);
#nullable restore
#line 27 "/home/oem/aspbiblio/Views/Home/Index.cshtml"
WriteAttributeValue("", 847, t.Completed == null ? "none" : "", 847, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 883, ";", 883, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n      <i class=\"far fa-check-square\"");
            BeginWriteAttribute("onclick", " onclick=\"", 924, "\"", 963, 3);
            WriteAttributeValue("", 934, "Click(", 934, 6, true);
#nullable restore
#line 28 "/home/oem/aspbiblio/Views/Home/Index.cshtml"
WriteAttributeValue("", 940, t.TaskId, 940, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 949, ",\'Incomplete\')", 949, 14, true);
            EndWriteAttribute();
            WriteLiteral("></i>\r\n    </td>\r\n    <td>");
#nullable restore
#line 30 "/home/oem/aspbiblio/Views/Home/Index.cshtml"
   Write(t.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  </tr>\r\n");
#nullable restore
#line 32 "/home/oem/aspbiblio/Views/Home/Index.cshtml"
  added = true;
  }

  if (!added)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("  <tr>\r\n  <td></td>\r\n  <td></td>\r\n  <td style=\"display:none;\"></td>\r\n  <td>No tasks found.</td>\r\n  </tr>\r\n");
#nullable restore
#line 43 "/home/oem/aspbiblio/Views/Home/Index.cshtml"
  }
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tr>\r\n  </tbody>\r\n  </table>\r\n  </div>\r\n  </div>\r\n</div>");
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
