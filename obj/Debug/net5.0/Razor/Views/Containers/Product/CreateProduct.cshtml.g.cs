#pragma checksum "C:\Users\huuth\OneDrive\Documents\swp_Tho\add view user complete 2\Views\Containers\Product\CreateProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28dc3baadebb7cf0d8ee88590cd3b0f35e7584dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_Product_CreateProduct), @"mvc.1.0.view", @"/Views/Containers/Product/CreateProduct.cshtml")]
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
#line 1 "C:\Users\huuth\OneDrive\Documents\swp_Tho\add view user complete 2\Views\_ViewImports.cshtml"
using MedicalStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\huuth\OneDrive\Documents\swp_Tho\add view user complete 2\Views\_ViewImports.cshtml"
using MedicalStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\huuth\OneDrive\Documents\swp_Tho\add view user complete 2\Views\Containers\Product\CreateProduct.cshtml"
using MedicalStore.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28dc3baadebb7cf0d8ee88590cd3b0f35e7584dd", @"/Views/Containers/Product/CreateProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_Product_CreateProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MedicalStore.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("createForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("space-y-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\huuth\OneDrive\Documents\swp_Tho\add view user complete 2\Views\Containers\Product\CreateProduct.cshtml"
      
    this.ViewData["Title"] = Routers.CreateProduct.Title;
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>Product detail</h1>


<div class=""min-h-full flex "">
    <div class=""flex-1 flex flex-col justify-center py-12 px-4 sm:px-6 lg:flex-none lg:px-20 xl:px-24"">
        <div class=""mx-auto w-full max-w-sm lg:w-96"">
            <div>
                <img class=""h-12 w-auto"" src=""https://tailwindui.com/img/logos/workflow-mark-indigo-600.svg""
                    alt=""Workflow"" />
                <h2 class=""mt-6 text-3xl font-extrabold text-gray-900"">Create product</h2>
            </div>

            <div class=""mt-8"">

                <div class=""mt-6 relative"">
                    <div class=""absolute inset-0 flex items-center"" aria-hidden=""true"">
                        <div class=""w-full border-t border-gray-300 mb-2"" />
                    </div>
                </div>
            </div>

            <div class=""mt-6"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28dc3baadebb7cf0d8ee88590cd3b0f35e7584dd5480", async() => {
                WriteLiteral("\r\n\r\n                    <div class=\"space-y-1\">\r\n                        ");
#nullable restore
#line 31 "C:\Users\huuth\OneDrive\Documents\swp_Tho\add view user complete 2\Views\Containers\Product\CreateProduct.cshtml"
                   Write(await Html.PartialAsync("../../Components/Form/FormMessage.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"space-y-2 \">\r\n                                <input class=\"block px-4 py-3 w-full border-gray-300 intro-x login__input form-control\"\r\n                                       type=\"text\" name=\"name\" id=\"name\"");
                BeginWriteAttribute("value", " value=\"", 1454, "\"", 1462, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Name"" />
                                <div id=""NAMERROR"" data-label=""Name"" class=""text-red-500 ""></div>
                            </div>
                            <div class=""space-y-2 "">
                                <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                       type=""text"" name=""description"" id=""description""");
                BeginWriteAttribute("value", " value=\"", 1883, "\"", 1891, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Description"" />
                                <div id=""DESCRIPTIONERROR"" data-label=""Description"" class=""text-red-500 ""></div>
                            </div>
                            <div class=""space-y-2 "">
                                <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                       type=""text"" name=""originalprice"" id=""originalPrice""");
                BeginWriteAttribute("value", " value=\"", 2338, "\"", 2346, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""OriginalPrice"" />
                                <div id=""ORIGINALPRICEERROR"" data-label=""OriginalPrice"" class=""text-red-500 ""></div>
                            </div>
                            <div class=""space-y-2 "">
                                <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                       type=""text"" name=""retailprice"" id=""retailPrice""");
                BeginWriteAttribute("value", " value=\"", 2795, "\"", 2803, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""RetailPrice"" />
                                <div id=""RETAILPRICEERROR"" data-label=""RetailPrice"" class=""text-red-500 ""></div>
                            </div>

                            <div class=""space-y-2 "">
                                <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                       type=""text"" name=""quantity"" id=""quantity""");
                BeginWriteAttribute("value", " value=\"", 3242, "\"", 3250, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Quantity"" />
                                <div id=""QUANTITYERROR"" data-label=""Quantity"" class=""text-red-500 ""></div>
                            </div>
                            <div class=""space-y-2 "">
                                <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                       type=""text"" name=""imageurl"" id=""imageUrl""");
                BeginWriteAttribute("value", " value=\"", 3678, "\"", 3686, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""ImageUrl"" />
                                <div id=""IMAGEURLERROR"" data-label=""ImageUrl"" class=""text-red-500 ""></div>
                            </div>
                            <div class=""space-y-2 "">
                                <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                       type=""text"" name=""category"" id=""categoryId""");
                BeginWriteAttribute("value", " value=\"", 4116, "\"", 4124, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Category"" />
                                <div id=""CATEGORYERROR"" data-label=""Category"" class=""text-red-500 ""></div>
                            </div>
                    <div>
                        <button type=""submit""
                            class=""w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
                            Create
                        </button>
                        
                    </div>
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
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>
<div class=""hidden lg:block relative w-0 flex-1"">
    <img class=""absolute inset-0 h-screen w-full object-cover""
        src=""https://images.unsplash.com/photo-1505904267569-f02eaeb45a4c?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1908&q=80""");
            BeginWriteAttribute("alt", "\r\n        alt=\"", 5101, "\"", 5116, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        \r\n        <script src=\"/js/product/create.js\"></script>\r\n    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MedicalStore.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
