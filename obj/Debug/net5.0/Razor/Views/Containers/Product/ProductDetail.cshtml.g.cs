#pragma checksum "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "532a1fcd872e8e1e6766916e6148b1ceb4448128"
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
#line 1 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\_ViewImports.cshtml"
using MedicalStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
using MedicalStore.Utils.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
using MedicalStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"532a1fcd872e8e1e6766916e6148b1ceb4448128", @"/Views/Containers/Product/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Containers_Product_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 3 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
  
    this.ViewData["Title"] = Routers.UpdateProduct.Title;
    var product = (Product)this.ViewData["product"];
    var categoryName = this.ViewData["categoryName"];
    var shopName = this.ViewData["shopName"];
    var user = (User)this.ViewData["user"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex-1 min-h-screen px-2 py-2 xl:px-8 xl:py-6\">\r\n    <div class=\"flex\">\r\n        ");
#nullable restore
#line 13 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
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
            BeginWriteAttribute("src", " src=\"", 886, "\"", 909, 1);
#nullable restore
#line 20 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
WriteAttributeValue("", 892, product.ImageUrl, 892, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 910, "\"", 929, 1);
#nullable restore
#line 20 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
WriteAttributeValue("", 916, product.Name, 916, 13, false);

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
#line 26 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
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
#line 30 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
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
#line 34 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
                                                                            Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                </div>\r\n");
#nullable restore
#line 36 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
                 if(user.RoleId != "1"){                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6\">\r\n                    <dt class=\"text-sm font-medium text-gray-500\">Create Date</dt>\r\n                    <dd class=\"mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2\">");
#nullable restore
#line 39 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
                                                                            Write(product.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                </div>
                <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                    <dt class=""text-sm font-medium text-gray-500"">Original Price</dt>
                    <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 43 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
                                                                            Write(product.OriginalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                </div>\r\n");
#nullable restore
#line 45 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6\">\r\n                    <dt class=\"text-sm font-medium text-gray-500\">Retail Price</dt>\r\n                    <dd class=\"mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2\">");
#nullable restore
#line 48 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
                                                                            Write(product.RetailPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                </div>
                <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                    <dt class=""text-sm font-medium text-gray-500"">Status</dt>
                    <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 52 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
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
#line 56 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
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
#line 60 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
                                                                            Write(categoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                </div>\r\n\r\n            </div>\r\n             <div>\r\n");
#nullable restore
#line 65 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
                 if (user != null && user.RoleId == "2")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 3977, "\"", 4028, 2);
            WriteAttributeValue("", 3984, "/product/update?productId=", 3984, 26, true);
#nullable restore
#line 67 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
WriteAttributeValue("", 4010, product.ProductId, 4010, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
                        Edit
                    </a>
");
#nullable restore
#line 70 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
                 if ((user.RoleId == "2" || user.RoleId == "0"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "532a1fcd872e8e1e6766916e6148b1ceb444812814026", async() => {
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"productId\" id=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 4561, "\"", 4587, 1);
#nullable restore
#line 74 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
WriteAttributeValue("", 4569, product.ProductId, 4569, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 75 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
                         if(product.Status == ProductStatus.ACTIVE){

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button  type=\"submit\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4709, "\"", 4790, 11);
                WriteAttributeValue("", 4719, "return", 4719, 6, true);
                WriteAttributeValue(" ", 4725, "confirm(\'Are", 4726, 13, true);
                WriteAttributeValue(" ", 4738, "you", 4739, 4, true);
                WriteAttributeValue(" ", 4742, "sura", 4743, 5, true);
                WriteAttributeValue(" ", 4747, "you", 4748, 4, true);
                WriteAttributeValue(" ", 4751, "want", 4752, 5, true);
                WriteAttributeValue(" ", 4756, "to", 4757, 3, true);
                WriteAttributeValue(" ", 4759, "delete", 4760, 7, true);
                WriteAttributeValue(" ", 4766, "Product", 4767, 8, true);
#nullable restore
#line 76 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
WriteAttributeValue(" ", 4774, product.Name, 4775, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4788, "\')", 4788, 2, true);
                EndWriteAttribute();
                WriteLiteral(@"
                                class=""w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
                              Delete Product
                        </button>
");
#nullable restore
#line 80 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
                          if(product.Status == ProductStatus.INACTIVE){

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"submit\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5257, "\"", 5337, 11);
                WriteAttributeValue("", 5267, "return", 5267, 6, true);
                WriteAttributeValue(" ", 5273, "confirm(\'Are", 5274, 13, true);
                WriteAttributeValue(" ", 5286, "you", 5287, 4, true);
                WriteAttributeValue(" ", 5290, "sura", 5291, 5, true);
                WriteAttributeValue(" ", 5295, "you", 5296, 4, true);
                WriteAttributeValue(" ", 5299, "want", 5300, 5, true);
                WriteAttributeValue(" ", 5304, "to", 5305, 3, true);
                WriteAttributeValue(" ", 5307, "Unban", 5308, 6, true);
                WriteAttributeValue(" ", 5313, "Product", 5314, 8, true);
#nullable restore
#line 81 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
WriteAttributeValue(" ", 5321, product.Name, 5322, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5335, "\')", 5335, 2, true);
                EndWriteAttribute();
                WriteLiteral(@"
                                class=""w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
                              Unban Product
                        </button>
");
#nullable restore
#line 85 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
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
#line 87 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
                 if (user != null && user.RoleId == "1")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""min-h-full flex "">
                    <div class=""flex-1 flex flex-col justify-center py-12 px-4 sm:px-6 lg:flex-none lg:px-20 xl:px-24"">
                        <div class=""mx-auto w-full max-w-sm lg:w-96"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 6107, "\"", 6157, 2);
            WriteAttributeValue("", 6114, "/report/detail?productId=", 6114, 25, true);
#nullable restore
#line 93 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
WriteAttributeValue("", 6139, product.ProductId, 6139, 18, false);

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
#line 99 "F:\Trả Nợ\SWP391\Code\Deverlop1\Views\Containers\Product\ProductDetail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "532a1fcd872e8e1e6766916e6148b1ceb444812821818", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
