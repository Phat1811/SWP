#pragma checksum "C:\Users\LENOVO-PC\Desktop\SWP\Fix\SWP\Views\Containers\Product\CreateProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3b24b5a05b63a4ee5161d892aedea173778a9b6"
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
#line 1 "C:\Users\LENOVO-PC\Desktop\SWP\Fix\SWP\Views\_ViewImports.cshtml"
using MedicalStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO-PC\Desktop\SWP\Fix\SWP\Views\_ViewImports.cshtml"
using MedicalStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\LENOVO-PC\Desktop\SWP\Fix\SWP\Views\Containers\Product\CreateProduct.cshtml"
using MedicalStore.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3b24b5a05b63a4ee5161d892aedea173778a9b6", @"/Views/Containers/Product/CreateProduct.cshtml")]
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
#line 3 "C:\Users\LENOVO-PC\Desktop\SWP\Fix\SWP\Views\Containers\Product\CreateProduct.cshtml"
  
    this.ViewData["Title"] = Routers.CreateProduct.Title;
    var listCategory = (SelectList)this.ViewData["listCategory"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex-1 min-h-screen px-2 py-2 xl:px-8 xl:py-6\">\r\n    <div class=\"flex\">\r\n        ");
#nullable restore
#line 10 "C:\Users\LENOVO-PC\Desktop\SWP\Fix\SWP\Views\Containers\Product\CreateProduct.cshtml"
   Write(await Html.PartialAsync("../../Components/Navbar/NavbarSide.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""content"">
            <div class=""mt-5 intro-y box"">
                <div class=""flex flex-col items-center p-5 border-b border-gray-200 sm:flex-row"">
                    <h2 class=""mt-6 text-3xl font-extrabold text-gray-900"">Update product</h2>
                </div>

                <dl class=""mt-2 divide-y divide-gray-200"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3b24b5a05b63a4ee5161d892aedea173778a9b65271", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 19 "C:\Users\LENOVO-PC\Desktop\SWP\Fix\SWP\Views\Containers\Product\CreateProduct.cshtml"
                   Write(await Html.PartialAsync("../../Components/Form/FormMessage.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6 "">
                            <dt class=""text-sm font-medium text-gray-500"">Product Name</dt>
                            <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">
                                <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                    type=""text"" name=""name"" id=""name""");
                BeginWriteAttribute("value", " value=\"", 1361, "\"", 1369, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Name"" />
                                <div id=""NAMEERROR"" data-label=""Name"" class=""text-red-500 ""></div>
                            </dd>
                        </div>
                        <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                            <dt class=""text-sm font-medium text-gray-500"">Description</dt>
                            <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">
                                <textarea
                                    class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                    name=""description"" id=""description"" rows=""10"" cols=""70""></textarea>
                                <div id=""DESCRIPTIONERROR"" data-label=""Description"" class=""text-red-500 ""></div>
                            </dd>
                        </div>
                        <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6 "">
                  ");
                WriteLiteral(@"          <dt class=""text-sm font-medium text-gray-500"">Original Price</dt>
                            <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">
                                <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                    type=""number"" name=""originalPrice"" id=""originalPrice""");
                BeginWriteAttribute("value", " value=\"", 2772, "\"", 2780, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                                    placeholder=""OriginalPrice"" />
                                <div id=""ORIGINALPRICEERROR"" data-label=""OriginalPrice"" class=""text-red-500 ""></div>
                            </dd>
                        </div>
                        <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6 "">
                            <dt class=""text-sm font-medium text-gray-500"">Retai Price</dt>
                            <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">
                                <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                    type=""number"" name=""retailPrice"" id=""retailPrice""");
                BeginWriteAttribute("value", " value=\"", 3518, "\"", 3526, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                                    placeholder=""RetailPrice"" />
                                <div id=""RETAILPRICEERROR"" data-label=""RetailPrice"" class=""text-red-500 ""></div>
                            </dd>
                        </div>
                        <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6 "">
                            <dt class=""text-sm font-medium text-gray-500"">Quantity</dt>
                            <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">
                                <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                    type=""number"" name=""quantity"" id=""quantity""");
                BeginWriteAttribute("value", " value=\"", 4249, "\"", 4257, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Quantity"" />
                                <div id=""QUANTITYERROR"" data-label=""Quantity"" class=""text-red-500 ""></div>
                            </dd>
                        </div>
                        <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6 "">
                            <dt class=""text-sm font-medium text-gray-500"">Image Url</dt>
                            <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">
                                <div class=""space-y-2"">
                                    <img alt=""image"" id=""image-preview"" class=""object-cover w-24 h-24 ""
                                        src=""/images/default.png"">
                                    <input type=""file"" id=""image"" />
                                    <div id=""IMAGEERROR"" data-label=""Image"" class=""text-red-500 ""></div>
                                </div>
                            </dd>
                        </div>
                        <div class");
                WriteLiteral(@"=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6 "">
                            <dt class=""text-sm font-medium text-gray-500"">Category</dt>
                            <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">
                                ");
#nullable restore
#line 77 "C:\Users\LENOVO-PC\Desktop\SWP\Fix\SWP\Views\Containers\Product\CreateProduct.cshtml"
                           Write(await Html.PartialAsync("../../Components/Form/SelectList.cshtml", new
                                {
                                Label = "Category",
                                Values = listCategory,
                                Value = "",
                                Field = "categoryId"
                                }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </dd>
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
            WriteLiteral("\r\n                </dl>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n<script src=\"/js/product/create.js\"></script>\r\n");
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
