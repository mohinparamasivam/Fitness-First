#pragma checksum "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\Admin\ViewPackageEnrollment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53fd7f53be1f8b359dfd0f5f83107a464dbb497d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ViewPackageEnrollment), @"mvc.1.0.view", @"/Views/Admin/ViewPackageEnrollment.cshtml")]
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
#line 1 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\_ViewImports.cshtml"
using Fitness_First;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\_ViewImports.cshtml"
using Fitness_First.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53fd7f53be1f8b359dfd0f5f83107a464dbb497d", @"/Views/Admin/ViewPackageEnrollment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed01543983efc66478d17bf4879c7800f7f37ab", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_ViewPackageEnrollment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Fitness_First.Models.PackageEnrollment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\Admin\ViewPackageEnrollment.cshtml"
  
    ViewData["Title"] = "View Package Enrollment";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mt-4\">\r\n    <center><h1>Members Enrolled in ");
#nullable restore
#line 9 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\Admin\ViewPackageEnrollment.cshtml"
                               Write(ViewBag.PackageName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1></center>
    <br /><br />
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th class=text-center>Member Name</th>
                <th class =text-center>Member Email</th>
                <th class=text-center>Enrollment Date</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\Admin\ViewPackageEnrollment.cshtml"
             foreach (var enrollment in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=text-center>");
#nullable restore
#line 23 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\Admin\ViewPackageEnrollment.cshtml"
                                     Write(enrollment.MemberName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=text-center>");
#nullable restore
#line 24 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\Admin\ViewPackageEnrollment.cshtml"
                                     Write(enrollment.MemberEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=text-center>");
#nullable restore
#line 25 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\Admin\ViewPackageEnrollment.cshtml"
                                     Write(enrollment.EnrolledAt.ToString("yyyy-MM-dd HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\Admin\ViewPackageEnrollment.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Fitness_First.Models.PackageEnrollment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
