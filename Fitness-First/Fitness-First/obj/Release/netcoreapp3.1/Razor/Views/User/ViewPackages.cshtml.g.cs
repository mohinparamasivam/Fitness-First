#pragma checksum "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c831724596b6ea9ebb493e2a233599927230f6b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ViewPackages), @"mvc.1.0.view", @"/Views/User/ViewPackages.cshtml")]
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
#line 1 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\_ViewImports.cshtml"
using Fitness_First;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\_ViewImports.cshtml"
using Fitness_First.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c831724596b6ea9ebb493e2a233599927230f6b1", @"/Views/User/ViewPackages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed01543983efc66478d17bf4879c7800f7f37ab", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_ViewPackages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Fitness_First.Models.GymPackages>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Package Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackages.cshtml"
  
    ViewData["Title"] = "View Packages";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .card {
        position: relative;
        overflow: hidden;
        transition: all 0.3s;
    }

        .card:hover {
            filter: grayscale(100%);
        }

    .card-img-top {
        transition: transform 0.3s;
    }

    .card:hover .card-img-top {
        transform: scale(1.1);
    }

    .card-text {
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
        text-align: center;
        color: #fff; /* Attractive text color */
        font-size: 1.5em;
        width: 100%;
        opacity: 0;
        transition: opacity 0.3s;
    }

    .card:hover .card-text {
        opacity: 1;
    }

    .btn-group {
        display: flex;
        justify-content:center;
        gap: 10px;
        bottom: 0px;
    }

    .btn {
        width: 120px;
        height: 40px;
        font-size: 1em;
    }

</style>

<div class=""container mt-4"">
    <center><h1>Packages Offered</h1></center>");
            WriteLiteral("\n    <br /><br />\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 63 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackages.cshtml"
         foreach (var package in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4 mb-4\">\r\n                <div class=\"card\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c831724596b6ea9ebb493e2a233599927230f6b15784", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1381, "~/uploads/", 1381, 10, true);
#nullable restore
#line 67 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackages.cshtml"
AddHtmlAttributeValue("", 1391, package.PackagePicturePath, 1391, 27, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"card-body\">\r\n                        <center> <h5 class=\"card-title\">");
#nullable restore
#line 69 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackages.cshtml"
                                                   Write(package.PackageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></center>\r\n                        <br>\r\n                        <div class=\"btn-group\" role=\"group\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1722, "\"", 1791, 1);
#nullable restore
#line 72 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackages.cshtml"
WriteAttributeValue("", 1729, Url.Action("ViewPackageInfo", new { id = package.PackageID }), 1729, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"><b>View</b></a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 77 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackages.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Fitness_First.Models.GymPackages>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
