#pragma checksum "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewEquipmentInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "682931670e0254fb1668ebbd0e2f9db18e46b5bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ViewEquipmentInfo), @"mvc.1.0.view", @"/Views/User/ViewEquipmentInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"682931670e0254fb1668ebbd0e2f9db18e46b5bc", @"/Views/User/ViewEquipmentInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed01543983efc66478d17bf4879c7800f7f37ab", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_ViewEquipmentInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fitness_First.Models.GymEquipments>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Package Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewEquipmentInfo.cshtml"
  
    ViewData["Title"] = "View Equipment Information";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    body {
        background-color: #f4f4f4;
    }

    .package-info-container {
        display: flex;
        flex-direction: row;
        align-items: center;
        margin: 30px;
        padding: 20px;
        background-color: #ffffff;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        border-radius: 10px;
    }

    .package-image {
        max-width: 40%;
        border-radius: 10px;
        overflow: hidden;
    }

        .package-image img {
            width: 100%;
            height: auto;
        }

    .package-details {
        max-width: 60%;
        padding: 20px;
    }

        .package-details h3 {
            margin-top: 0;
            font-size: 1.5rem;
        }

        .package-details p {
            font-size: 1.2rem;
        }

    .enroll-button {
        margin-top: 20px;
    }

    .timeslots {
        margin-top: 20px;
    }

</style>

<div class=""container"">
    <center><h1>");
#nullable restore
#line 60 "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewEquipmentInfo.cshtml"
           Write(Model.EquipmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1></center>\r\n    <div class=\"package-info-container\">\r\n        <div class=\"package-image\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "682931670e0254fb1668ebbd0e2f9db18e46b5bc5594", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1285, "~/uploads/", 1285, 10, true);
#nullable restore
#line 63 "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewEquipmentInfo.cshtml"
AddHtmlAttributeValue("", 1295, Model.EquipmentPicturePath, 1295, 27, false);

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
            WriteLiteral("\r\n        </div>\r\n        <div class=\"package-details\">\r\n            <center><p style=\"font-size: 16px;\"><b>Equipment:</b> ");
#nullable restore
#line 66 "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewEquipmentInfo.cshtml"
                                                             Write(Model.EquipmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></center>\r\n            <center><p style=\"font-size: 16px;\"><b>Quantity:</b> ");
#nullable restore
#line 67 "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewEquipmentInfo.cshtml"
                                                            Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></center>\r\n            <center><p style=\"font-size: 16px;\"><b>Availability:</b> ");
#nullable restore
#line 68 "C:\Users\Roy\Fitness-First\Fitness-First\Fitness-First\Views\User\ViewEquipmentInfo.cshtml"
                                                                Write(Model.Availability);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p></center>
            <center>
                <p style=""font-size: 16px;"">
                    <b>Location:</b> Asia Pacific University (APU)
                    , Jalan Teknologi 5, Technology Park Malaysia, Bukit Jalil, Kuala Lumpur 57000, Malaysia.
                </p>
            </center>

           <br />
        </div>
    </div>

    
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fitness_First.Models.GymEquipments> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
