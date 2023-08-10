#pragma checksum "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9e6da48d0aec3b41a295c7da528b817be1f6523"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_PurchaseSummary), @"mvc.1.0.view", @"/Views/User/PurchaseSummary.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9e6da48d0aec3b41a295c7da528b817be1f6523", @"/Views/User/PurchaseSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed01543983efc66478d17bf4879c7800f7f37ab", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_PurchaseSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fitness_First.Models.PurchaseSummaryViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelProductPurchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml"
  
    ViewData["Title"] = "Purchase Summary";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container mt-4"">
    <center><h1>Purchase Summary</h1></center>

    <!-- Top Part: Product Purchases -->
    <h2>Product Purchases</h2>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th class=""text-center"">Product Name</th>
                <th class=""text-center"">Product Type</th>
                <th class=""text-center"">Quantity</th>
                <th class=""text-center"">Price</th>
                <th class=""text-center"">Purchase Date</th>
                <th class=""text-center"">Cancel Purchase</th> <!-- New column for Cancel button -->
            </tr>
        </thead>
        <tbody>
            <!-- Loop through product purchases from the database -->
");
#nullable restore
#line 26 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml"
             foreach (var productPurchase in Model.ProductPurchases)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 29 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml"
                                       Write(productPurchase.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 30 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml"
                                       Write(productPurchase.ProductType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 31 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml"
                                       Write(productPurchase.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">RM ");
#nullable restore
#line 32 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml"
                                           Write(productPurchase.ProductPrice * productPurchase.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 33 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml"
                                       Write(productPurchase.PurchaseTime.ToString("yyyy-MM-dd HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9e6da48d0aec3b41a295c7da528b817be1f65237261", async() => {
                WriteLiteral("\r\n                            <button type=\"submit\" class=\"btn btn-danger\">Cancel</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-purchaseId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml"
                                                                           WriteLiteral(productPurchase.PurchaseID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["purchaseId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-purchaseId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["purchaseId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <!-- Display the sum of product prices -->\r\n    <div class=\"text-right\">\r\n        <h5><b>Product Total: RM ");
#nullable restore
#line 46 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml"
                            Write(Model.ProductSum);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></h5>
    </div>

    <!-- Bottom Part: Package Purchases -->
    <h2>Package Purchases</h2>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th class=""text-center"">Package Name</th>
                <th class=""text-center"">Package Price</th>
                <th class=""text-center"">Enrollment Date</th>
            </tr>
        </thead>
        <tbody>
            <!-- Loop through package purchases from the database -->
");
#nullable restore
#line 61 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml"
             foreach (var packagePurchase in Model.PackagePurchases)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 64 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml"
                                       Write(packagePurchase.PackageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">RM ");
#nullable restore
#line 65 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml"
                                          Write(packagePurchase.PackagePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 66 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml"
                                       Write(packagePurchase.EnrolledAt.ToString("yyyy-MM-dd HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 68 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <!-- Display the sum of package prices -->\r\n    <div class=\"text-right\">\r\n        <h5><b>Package Total: RM ");
#nullable restore
#line 74 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml"
                            Write(Model.PackageSum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h5>\r\n    </div>\r\n    <br />\r\n\r\n    <!-- Display the total sum to be paid -->\r\n    <div class=\"text-center\">\r\n        <hr class=\"my-2\"> <!-- Horizontal line -->\r\n        <h2><b>Total Amount: RM ");
#nullable restore
#line 81 "C:\Users\Rin\source\repos\Fitness-First\Fitness-First\Fitness-First\Views\User\PurchaseSummary.cshtml"
                           Write(Model.TotalAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n        <hr class=\"my-2\"> <!-- Horizontal line -->\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fitness_First.Models.PurchaseSummaryViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591