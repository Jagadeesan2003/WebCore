#pragma checksum "E:\DOTNETCORE\WebCore\Views\Employees\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b4302b4c24ec66b7bfc35964f7f878726fde9f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Index), @"mvc.1.0.view", @"/Views/Employees/Index.cshtml")]
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
#line 1 "E:\DOTNETCORE\WebCore\Views\_ViewImports.cshtml"
using WebCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DOTNETCORE\WebCore\Views\_ViewImports.cshtml"
using WebCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b4302b4c24ec66b7bfc35964f7f878726fde9f8", @"/Views/Employees/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4526315c43cd9efa3325108553415d27ba40a15", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebCore.Models.Domain.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<h1>Employees</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Email</th>
            <th>Salary</th>
            <th>Dob</th>
            <th>Department</th>
            <th> </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "E:\DOTNETCORE\WebCore\Views\Employees\Index.cshtml"
         foreach(var employee in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "E:\DOTNETCORE\WebCore\Views\Employees\Index.cshtml"
           Write(employee.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "E:\DOTNETCORE\WebCore\Views\Employees\Index.cshtml"
           Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "E:\DOTNETCORE\WebCore\Views\Employees\Index.cshtml"
           Write(employee.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "E:\DOTNETCORE\WebCore\Views\Employees\Index.cshtml"
           Write(employee.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "E:\DOTNETCORE\WebCore\Views\Employees\Index.cshtml"
           Write(employee.DOB.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "E:\DOTNETCORE\WebCore\Views\Employees\Index.cshtml"
           Write(employee.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 701, "\"", 735, 2);
            WriteAttributeValue("", 708, "Employees/View/", 708, 15, true);
#nullable restore
#line 30 "E:\DOTNETCORE\WebCore\Views\Employees\Index.cshtml"
WriteAttributeValue("", 723, employee.Id, 723, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "E:\DOTNETCORE\WebCore\Views\Employees\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebCore.Models.Domain.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
