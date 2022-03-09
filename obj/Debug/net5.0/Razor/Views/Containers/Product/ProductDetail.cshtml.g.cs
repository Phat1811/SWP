#pragma checksum "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b16e1f169a13b837eb1d4dce66933cf0705471a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_Product_ProductDetail), @"mvc.1.0.view", @"/Views/Containers/Product/ProductDetail.cshtml")]
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
#line 1 "F:\Trả Nợ\SWP391\Code\Phat\Views\_ViewImports.cshtml"
using MedicalStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Trả Nợ\SWP391\Code\Phat\Views\_ViewImports.cshtml"
using MedicalStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
using MedicalStore.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b16e1f169a13b837eb1d4dce66933cf0705471a5", @"/Views/Containers/Product/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Containers_Product_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MedicalStore.Models.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("space-y-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/product/delete.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
  
    this.ViewData["Title"] = Routers.UpdateProduct.Title;
    var product = (Product)this.ViewData["product"];
    var listProduct = (List<Product>)this.ViewData["listProduct"];
    var categoryName = this.ViewData["categoryName"];
    var shopName = this.ViewData["shopName"];
    var user = (User)this.ViewData["user"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex-1 min-h-screen px-2 py-2 xl:px-8 xl:py-6\">\r\n    <div class=\"flex\">\r\n        ");
#nullable restore
#line 14 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
   Write(await Html.PartialAsync("../../Components/Navbar/NavbarSide.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""content"">
            <div class=""mt-5 intro-y box"">
                <div class=""flex flex-col items-center p-5 border-b border-gray-200 sm:flex-row"">
                    <h2 class=""mt-6 text-3xl font-extrabold text-gray-900"">Product Detail</h2>
                </div>
                <div class=""border-t border-gray-200 px-4 py-5 sm:p-0"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 975, "\"", 998, 1);
#nullable restore
#line 21 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
WriteAttributeValue("", 981, product.ImageUrl, 981, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 999, "\"", 1018, 1);
#nullable restore
#line 21 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
WriteAttributeValue("", 1005, product.Name, 1005, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""300px"" height=""300px""/>
                </div>
                <div>
                    <dl class=""sm:divide-y sm:divide-gray-200"">
                        <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                        <dt class=""text-sm font-medium text-gray-500"">Product ID</dt>
                        <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 27 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
                                                                                Write(product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                </div>
                <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                    <dt class=""text-sm font-medium text-gray-500"">Product Name</dt>
                    <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 31 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
                                                                            Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                </div>
                <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                    <dt class=""text-sm font-medium text-gray-500"">Description</dt>
                    <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 35 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
                                                                            Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                </div>
                <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                    <dt class=""text-sm font-medium text-gray-500"">Original Price</dt>
                    <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 39 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
                                                                            Write(product.OriginalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                </div>
                <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                    <dt class=""text-sm font-medium text-gray-500"">Retail Price</dt>
                    <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 43 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
                                                                            Write(product.RetailPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                </div>
                <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                    <dt class=""text-sm font-medium text-gray-500"">Create Date</dt>
                    <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 47 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
                                                                            Write(product.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                </div>
                <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                    <dt class=""text-sm font-medium text-gray-500"">Status</dt>
                    <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 51 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
                                                                            Write(product.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                </div>
                <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                    <dt class=""text-sm font-medium text-gray-500"">Shop name</dt>
                    <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 55 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
                                                                            Write(shopName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                </div>
                <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                    <dt class=""text-sm font-medium text-gray-500"">Category name</dt>
                    <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 59 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
                                                                            Write(categoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                </div>\r\n            </div>\r\n            <div>\r\n");
#nullable restore
#line 63 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
                 if (user != null && user.RoleId == "2")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 3986, "\"", 4037, 2);
            WriteAttributeValue("", 3993, "/product/update?productId=", 3993, 26, true);
#nullable restore
#line 65 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
WriteAttributeValue("", 4019, product.ProductId, 4019, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
                        Edit
                    </a>
");
#nullable restore
#line 68 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("             </div>\r\n            <div>\r\n");
#nullable restore
#line 71 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
             if (product.Status == ProductStatus.ACTIVE && user != null && user.RoleId != "1")
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b16e1f169a13b837eb1d4dce66933cf0705471a513632", async() => {
                WriteLiteral("\r\n                      <input type=\"hidden\" name=\"productId\" id=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 4636, "\"", 4662, 1);
#nullable restore
#line 74 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
WriteAttributeValue("", 4644, product.ProductId, 4644, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                      <button type=\"submit\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4711, "\"", 4793, 11);
                WriteAttributeValue("", 4721, "return", 4721, 6, true);
                WriteAttributeValue(" ", 4727, "confirm(\'Are", 4728, 13, true);
                WriteAttributeValue(" ", 4740, "you", 4741, 4, true);
                WriteAttributeValue(" ", 4744, "sure?", 4745, 6, true);
                WriteAttributeValue(" ", 4750, "you", 4751, 4, true);
                WriteAttributeValue(" ", 4754, "want", 4755, 5, true);
                WriteAttributeValue(" ", 4759, "to", 4760, 3, true);
                WriteAttributeValue(" ", 4762, "delete", 4763, 7, true);
                WriteAttributeValue(" ", 4769, "Product", 4770, 8, true);
#nullable restore
#line 75 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
WriteAttributeValue(" ", 4777, product.Name, 4778, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4791, "\')", 4791, 2, true);
                EndWriteAttribute();
                WriteLiteral(@"
                                class=""w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
                            Delete
                       </button>
                  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 80 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div>\r\n");
#nullable restore
#line 83 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
                 if (user != null && user.RoleId == "1")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""min-h-full flex "">
                    <div class=""flex-1 flex flex-col justify-center py-12 px-4 sm:px-6 lg:flex-none lg:px-20 xl:px-24"">
                        <div class=""mx-auto w-full max-w-sm lg:w-96"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 5565, "\"", 5615, 2);
            WriteAttributeValue("", 5572, "/report/detail?productId=", 5572, 25, true);
#nullable restore
#line 88 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
WriteAttributeValue("", 5597, product.ProductId, 5597, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
                                   Report
                            </a>
                        </div>
                    </div>
                </div>
");
#nullable restore
#line 94 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Product\ProductDetail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b16e1f169a13b837eb1d4dce66933cf0705471a519007", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MedicalStore.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
