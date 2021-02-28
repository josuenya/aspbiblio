#pragma checksum "/home/oem/aspbiblio/Views/Tasks/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8033a34b70621e4457057f6a5fdec7bb318f0288"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks_index), @"mvc.1.0.view", @"/Views/Tasks/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8033a34b70621e4457057f6a5fdec7bb318f0288", @"/Views/Tasks/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5daf4c1dbd097a780b95f90d17c53c725213052", @"/Views/_ViewImports.cshtml")]
    public class Views_Tasks_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/oem/aspbiblio/Views/Tasks/index.cshtml"
  
  ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<script>\n    function Click(id, action) {\n      if(action !== \"Archive\" || confirm(\'Are you sure you want to archive this task?\')) {\n        $.ajax({\n          url: (\'");
#nullable restore
#line 9 "/home/oem/aspbiblio/Views/Tasks/index.cshtml"
            Write(Url.Action("REPLACE", "Tasks"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'.replace('REPLACE', action)),
          type: 'POST',
          data: { TaskId: id }
        }).done(function () {
          if (action === 'Archive'){
            document.getElementById('tr_' + id).style.display = ""none"";
          } else if (action === 'Complete') {
            document.getElementById('td_complete_' + id).style.display = """";
            document.getElementById('td_incomplete_' + id).style.display = ""none"";
          } else if (action === 'Incomplete') {
            document.getElementById('td_complete_' + id).style.display = ""none"";
            document.getElementById('td_incomplete_' + id).style.display = """";
          }
        });
      }
    }
</script>

<div class=""row"">
  <!-- List of Tasks -->
  <h2>Tasks</h2>
  <div class=""table-responsive"">
  <table class=""table"">
  <thead>
  <tr class=""header"">
  <td class=""empty""></td>
  <td class=""empty""></td>
  <td>Description</td>
  </tr>
  </thead>
    <tbody>

");
#nullable restore
#line 41 "/home/oem/aspbiblio/Views/Tasks/index.cshtml"
       if (Model != null)
    {
      var added = false;
      foreach (var t in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("id", " id=\"", 1290, "\"", 1307, 2);
            WriteAttributeValue("", 1295, "tr_", 1295, 3, true);
#nullable restore
#line 46 "/home/oem/aspbiblio/Views/Tasks/index.cshtml"
WriteAttributeValue("", 1298, t.TaskId, 1298, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n          <td><i class=\"fas fa-archive\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1349, "\"", 1385, 3);
            WriteAttributeValue("", 1359, "Click(", 1359, 6, true);
#nullable restore
#line 47 "/home/oem/aspbiblio/Views/Tasks/index.cshtml"
WriteAttributeValue("", 1365, t.TaskId, 1365, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1374, ",\'Archive\')", 1374, 11, true);
            EndWriteAttribute();
            WriteLiteral("></i></td>\n          <td");
            BeginWriteAttribute("id", " id=\"", 1410, "\"", 1438, 2);
            WriteAttributeValue("", 1415, "td_incomplete_", 1415, 14, true);
#nullable restore
#line 48 "/home/oem/aspbiblio/Views/Tasks/index.cshtml"
WriteAttributeValue("", 1429, t.TaskId, 1429, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 1439, "\"", 1492, 3);
            WriteAttributeValue("", 1447, "display:", 1447, 8, true);
#nullable restore
#line 48 "/home/oem/aspbiblio/Views/Tasks/index.cshtml"
WriteAttributeValue("", 1455, t.Completed == null ? "" : "none", 1455, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1491, ";", 1491, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n            <i class=\"far fa-square\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1531, "\"", 1568, 3);
            WriteAttributeValue("", 1541, "Click(", 1541, 6, true);
#nullable restore
#line 49 "/home/oem/aspbiblio/Views/Tasks/index.cshtml"
WriteAttributeValue("", 1547, t.TaskId, 1547, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1556, ",\'Complete\')", 1556, 12, true);
            EndWriteAttribute();
            WriteLiteral("></i>\n          </td>\n          <td");
            BeginWriteAttribute("id", " id=\"", 1604, "\"", 1630, 2);
            WriteAttributeValue("", 1609, "td_complete_", 1609, 12, true);
#nullable restore
#line 51 "/home/oem/aspbiblio/Views/Tasks/index.cshtml"
WriteAttributeValue("", 1621, t.TaskId, 1621, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 1631, "\"", 1684, 3);
            WriteAttributeValue("", 1639, "display:", 1639, 8, true);
#nullable restore
#line 51 "/home/oem/aspbiblio/Views/Tasks/index.cshtml"
WriteAttributeValue("", 1647, t.Completed == null ? "none" : "", 1647, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1683, ";", 1683, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n            <i class=\"far fa-check-square\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1729, "\"", 1768, 3);
            WriteAttributeValue("", 1739, "Click(", 1739, 6, true);
#nullable restore
#line 52 "/home/oem/aspbiblio/Views/Tasks/index.cshtml"
WriteAttributeValue("", 1745, t.TaskId, 1745, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1754, ",\'Incomplete\')", 1754, 14, true);
            EndWriteAttribute();
            WriteLiteral("></i>\n          </td>\n          <td>");
#nullable restore
#line 54 "/home/oem/aspbiblio/Views/Tasks/index.cshtml"
         Write(t.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 56 "/home/oem/aspbiblio/Views/Tasks/index.cshtml"

        added = true;
      }

      if (!added)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n          <td></td>\n          <td></td>\n          <td style=\"display:none;\"></td>\n          <td>No tasks found.</td>\n        </tr>\n");
#nullable restore
#line 68 "/home/oem/aspbiblio/Views/Tasks/index.cshtml"
      }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n\n</div>\n</div>\n");
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