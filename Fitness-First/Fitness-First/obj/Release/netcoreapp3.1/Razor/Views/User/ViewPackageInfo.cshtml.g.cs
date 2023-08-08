#pragma checksum "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackageInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e24bcf709f6917c98d10289c41cd078bcac44adb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ViewPackageInfo), @"mvc.1.0.view", @"/Views/User/ViewPackageInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e24bcf709f6917c98d10289c41cd078bcac44adb", @"/Views/User/ViewPackageInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed01543983efc66478d17bf4879c7800f7f37ab", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_ViewPackageInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fitness_First.Models.GymPackages>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Package Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnrollPackage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Member", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackageInfo.cshtml"
  
    ViewData["Title"] = "View Package Information";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .package-info-container {
        display: flex;
        flex-direction: row;
        justify-content: space-between;
        align-items: center;
        margin: 50px;
    }

    .package-image {
        max-width: 50%;
    }

    .package-details {
        max-width: 45%;
        padding: 20px;
        border: 1px solid #ccc;
        border-radius: 10px;
    }

        .package-details h3 {
            margin-top: 0;
        }

    .enroll-button {
        margin-top: 20px;
    }

    .timeslots {
        margin-top: 20px;
    }
</style>

<div class=""container"">
    <h1>");
#nullable restore
#line 42 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackageInfo.cshtml"
   Write(Model.PackageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"package-info-container\">\r\n        <div class=\"package-image\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e24bcf709f6917c98d10289c41cd078bcac44adb6490", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 903, "~/uploads/", 903, 10, true);
#nullable restore
#line 45 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackageInfo.cshtml"
AddHtmlAttributeValue("", 913, Model.PackagePicturePath, 913, 25, false);

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
            WriteLiteral("\r\n        </div>\r\n        <div class=\"package-details\">\r\n            <h3>Package Details:</h3>\r\n            <p><b>Price:</b> RM@Model.PackagePrice</p>\r\n            <p><b>Instructor:</b> ");
#nullable restore
#line 50 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackageInfo.cshtml"
                             Write(Model.InstructorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            <div class=\"timeslots\">\r\n                <h4>Time Slots:</h4>\r\n                <ul>\r\n                    <li><b>Week 1:</b> Session 1: ");
#nullable restore
#line 55 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackageInfo.cshtml"
                                             Write(Model.Session1.ToString("dddd, dd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li><b>Week 1:</b> Session 2: ");
#nullable restore
#line 56 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackageInfo.cshtml"
                                             Write(Model.Session2.ToString("dddd, dd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li><b>Week 2:</b> Session 1: ");
#nullable restore
#line 57 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackageInfo.cshtml"
                                             Write(Model.Session3.ToString("dddd, dd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li><b>Week 2:</b> Session 2: ");
#nullable restore
#line 58 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackageInfo.cshtml"
                                             Write(Model.Session4.ToString("dddd, dd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li><b>Week 3:</b> Session 2: ");
#nullable restore
#line 59 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackageInfo.cshtml"
                                             Write(Model.Session5.ToString("dddd, dd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li><b>Week 3:</b> Session 2: ");
#nullable restore
#line 60 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackageInfo.cshtml"
                                             Write(Model.Session6.ToString("dddd, dd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li><b>Week 4:</b> Session 2: ");
#nullable restore
#line 61 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackageInfo.cshtml"
                                             Write(Model.Session7.ToString("dddd, dd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li><b>Week 4:</b> Session 2: ");
#nullable restore
#line 62 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackageInfo.cshtml"
                                             Write(Model.Session8.ToString("dddd, dd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e24bcf709f6917c98d10289c41cd078bcac44adb11938", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"packageId\"");
                BeginWriteAttribute("value", " value=\"", 2347, "\"", 2371, 1);
#nullable restore
#line 67 "C:\Users\Mohin Paramasivam\Desktop\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewPackageInfo.cshtml"
WriteAttributeValue("", 2355, Model.PackageID, 2355, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <button type=\"submit\" class=\"btn btn-primary enroll-button\">Enroll Now</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fitness_First.Models.GymPackages> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
