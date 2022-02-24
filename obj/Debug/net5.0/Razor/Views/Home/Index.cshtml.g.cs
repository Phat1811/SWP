#pragma checksum "F:\Trả Nợ\SWP391\Code\Tho2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45170fcf6ac23e2c4558c94dd42f71f99aa54d09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "F:\Trả Nợ\SWP391\Code\Tho2\Views\_ViewImports.cshtml"
using MedicalStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Trả Nợ\SWP391\Code\Tho2\Views\_ViewImports.cshtml"
using MedicalStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Home\Index.cshtml"
using MedicalStore.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45170fcf6ac23e2c4558c94dd42f71f99aa54d09", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("order"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-span-12 space-y-2 lg:col-span-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Home\Index.cshtml"
  
    this.ViewData["Title"] = Routers.Home.Title;
    var products = (List<Product>)this.ViewData["products"];
    var cartItems = (List<Product>)this.ViewData["cartItems"];
    var categories = (SelectList)this.ViewData["categories"];
    var min = (string)this.Context.Request.Query["min"];
    var max = (string)this.Context.Request.Query["max"];
    var name = (string)this.Context.Request.Query["name"];
    var categoryId = (string)this.Context.Request.Query["categoryId"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex-1 min-h-screen px-2 py-2 xl:px-8 xl:py-6\">\r\n    <div class=\"flex\">\r\n        <!-- BEGIN: Side Menu -->\r\n        ");
#nullable restore
#line 16 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Home\Index.cshtml"
   Write(await Html.PartialAsync("../Components/Navbar/NavbarSide.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <!-- END: Side Menu -->
        <!-- BEGIN: Content -->
        <div class=""content"">
            <!-- BEGIN: Top Bar -->
            <!-- END: Top Bar -->

            <div class=""grid grid-cols-12 gap-5 mt-5 pos intro-y"">
                <!-- BEGIN: Item List -->
                <div class=""col-span-12 intro-y lg:col-span-7"">
                    <div class=""grid grid-cols-12 gap-5 pt-5 mt-5 border-t border-theme-5"" id=""store"">
");
#nullable restore
#line 27 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Home\Index.cshtml"
                         if (products != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Home\Index.cshtml"
                             foreach (var item in products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\" class=\"block col-span-4 intro-y md:col-span-3\" data-id=\"");
#nullable restore
#line 31 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Home\Index.cshtml"
                                                                                                         Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                    <div class=""relative p-3 rounded-md duration hover:bg-blue-200 box"">
                                        <div class=""relative flex-none block pos-image"">
                                            <div class=""pos-image__preview image-fit"">
                                                <img");
            BeginWriteAttribute("alt", " alt=\"", 1809, "\"", 1825, 1);
#nullable restore
#line 35 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Home\Index.cshtml"
WriteAttributeValue("", 1815, item.Name, 1815, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 1826, "\"", 1846, 1);
#nullable restore
#line 35 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Home\Index.cshtml"
WriteAttributeValue("", 1832, item.ImageUrl, 1832, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("                                            </div>\r\n                                        </div>\r\n                                        <div class=\"block mt-3 font-medium text-center truncate\">");
#nullable restore
#line 39 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Home\Index.cshtml"
                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                        <div class=\"block mt-3 font-medium text-center truncate\">$");
#nullable restore
#line 40 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Home\Index.cshtml"
                                                                                             Write(item.RetailPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    </div>\r\n                                </button>\r\n");
#nullable restore
#line 43 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Home\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <!-- END: Item List -->\r\n                <!-- BEGIN: Ticket -->\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45170fcf6ac23e2c4558c94dd42f71f99aa54d098908", async() => {
                WriteLiteral(@"


                    <div>
                        <div class=""bg-white rounded-r-md intro-y rounded-t-md "">
                            <div class=""p-2 "">
                                <div class=""justify-center pos__tabs nav nav-tabs"" role=""tablist"">
                                    <a id=""ticket-tab"" data-toggle=""tab"" data-target=""#ticket"" href=""javascript:;""
                                        class=""flex-1 py-2 font-semibold text-center rounded-md "" role=""tab""
                                        aria-controls=""ticket"" aria-selected=""false"">My Cart</a>
                                </div>
                            </div>
                        </div>


                        <div class=""p-3 bg-white intro-y "">
                            ");
#nullable restore
#line 65 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Home\Index.cshtml"
                       Write(await Html.PartialAsync("../Components/Form/FormMessage.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            <label>Payment Method</label>
                            <div class=""flex flex-col mt-2 sm:flex-row"">
                                <div class=""mr-2 form-check"">
                                    <input id=""radio-switch-4"" class=""form-check-input"" type=""radio"" name=""payment""
                                        value=""0"" checked=""checked""> <label class=""form-check-label""
                                        for=""radio-switch-4"">Cash</label>
                                </div>
                                <div class=""mt-2 mr-2 form-check sm:mt-0"">
                                    <input id=""radio-switch-5"" class=""form-check-input"" type=""radio"" name=""payment""
                                        value=""1""> <label class=""form-check-label"" for=""radio-switch-5"">Credit
                                        Card</label>
                                </div>

                            </div>
                        </div>

                     ");
                WriteLiteral(@"   <div class=""mb-2 overflow-hidden tab-content"" id=""cart"">
                            <div
                                class=""flex items-center block p-3 transition duration-300 ease-in-out rounded-md cursor-pointer "">
                                <div class=""w-3/6 mr-1 truncate pos__ticket__item-name"">
                                    Total
                                </div>
                                <div class=""flex items-center w-1/6 space-x-2"">

                                </div>
");
                WriteLiteral("                            </div>\r\n                        </div>\r\n\r\n                        ");
#nullable restore
#line 95 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Home\Index.cshtml"
                   Write(await Html.PartialAsync("../Components/Form/FormBtn.cshtml", "Order Product"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n\r\n                ");
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
            WriteLiteral("\r\n                <!-- END: Ticket -->\r\n            </div>\r\n        </div>\r\n        <!-- END: Content -->\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n<script src=\"/js/home.js\"></script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
