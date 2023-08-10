#pragma checksum "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackagesEnrolled.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "087b498d75e453356735cca2c177f103fc2b5512"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ViewPackagesEnrolled), @"mvc.1.0.view", @"/Views/User/ViewPackagesEnrolled.cshtml")]
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
#line 1 "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\_ViewImports.cshtml"
using Fitness_First;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\_ViewImports.cshtml"
using Fitness_First.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"087b498d75e453356735cca2c177f103fc2b5512", @"/Views/User/ViewPackagesEnrolled.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed01543983efc66478d17bf4879c7800f7f37ab", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_ViewPackagesEnrolled : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Fitness_First.Models.PackageEnrollment>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Package Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveEnrollment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackagesEnrolled.cshtml"
  
    ViewData["Title"] = "View Enrolled Packages";
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
    <center><h1>Packages Currently Enrolled</h1");
            WriteLiteral("></center>\r\n    <br /><br />\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 63 "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackagesEnrolled.cshtml"
         foreach (var package in Model)
        {
            if (package.MemberEmail == User.Identity.Name) // Filter by current user's email
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 mb-4\">\r\n                    <div class=\"card\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "087b498d75e453356735cca2c177f103fc2b55126766", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1528, "~/uploads/", 1528, 10, true);
#nullable restore
#line 69 "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackagesEnrolled.cshtml"
AddHtmlAttributeValue("", 1538, package.PackagePicturePath, 1538, 27, false);

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
            WriteLiteral("\r\n                        <div class=\"card-body\">\r\n                            <center><h5 class=\"card-title\">");
#nullable restore
#line 71 "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackagesEnrolled.cshtml"
                                                      Write(package.PackageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></center>\r\n                            <br />\r\n                            <div class=\"btn-group\" role=\"group\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1890, "\"", 1965, 1);
#nullable restore
#line 74 "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackagesEnrolled.cshtml"
WriteAttributeValue("", 1897, Url.Action("ViewEnrollmentInfo", new { id = package.EnrollmentID }), 1897, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\"><b>View</b></a>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "087b498d75e453356735cca2c177f103fc2b55129520", async() => {
                WriteLiteral("\r\n                                    <button type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2218, "\"", 2264, 3);
                WriteAttributeValue("", 2228, "submitForm(\'", 2228, 12, true);
#nullable restore
#line 76 "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackagesEnrolled.cshtml"
WriteAttributeValue("", 2240, package.EnrollmentID, 2240, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2261, "\');", 2261, 3, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-danger\"><b>Quit</b></button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2050, "form-", 2050, 5, true);
#nullable restore
#line 75 "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackagesEnrolled.cshtml"
AddHtmlAttributeValue("", 2055, package.EnrollmentID, 2055, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackagesEnrolled.cshtml"
                                                                                                      WriteLiteral(package.EnrollmentID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 82 "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackagesEnrolled.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<script>\r\n    function submitForm(formId) {\r\n        var form = document.getElementById(\'form-\' + formId);\r\n        form.submit();\r\n    }\r\n</script>\r\n\r\n");
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
