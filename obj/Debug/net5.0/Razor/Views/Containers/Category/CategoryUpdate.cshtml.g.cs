#pragma checksum "C:\Users\LENOVO-PC\Desktop\SWP\order\SWP\Views\Containers\Category\CategoryUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c0c2bc3c3ba79af7fccbd1e7cd574516c4e29ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_Category_CategoryUpdate), @"mvc.1.0.view", @"/Views/Containers/Category/CategoryUpdate.cshtml")]
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
#line 1 "C:\Users\LENOVO-PC\Desktop\SWP\order\SWP\Views\_ViewImports.cshtml"
using MedicalStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO-PC\Desktop\SWP\order\SWP\Views\_ViewImports.cshtml"
using MedicalStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\LENOVO-PC\Desktop\SWP\order\SWP\Views\Containers\Category\CategoryUpdate.cshtml"
using MedicalStore.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c0c2bc3c3ba79af7fccbd1e7cd574516c4e29ea", @"/Views/Containers/Category/CategoryUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_Category_CategoryUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("updateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("space-y-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/category/update.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\LENOVO-PC\Desktop\SWP\order\SWP\Views\Containers\Category\CategoryUpdate.cshtml"
  
    this.ViewData["Title"] = Routers.CategoryUpdate.Title;
    var category = (Category)this.ViewData["category"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""min-h-full flex "">
    <div class=""flex-1 flex flex-col justify-center py-12 px-4 sm:px-6 lg:flex-none lg:px-20 xl:px-24"">
        <div class=""mx-auto w-full max-w-sm lg:w-96"">
            <div>
                <img class=""h-12 w-auto"" src=""https://tailwindui.com/img/logos/workflow-mark-indigo-600.svg""
                     alt=""Workflow"" width=""250"" height=""200"" />
                <h2 class=""mt-6 text-3xl font-extrabold text-gray-900"">Update Category</h2>
            </div>

            <div class=""mt-8"">
                <div class=""mt-6 relative"">
                    <div class=""absolute inset-0 flex items-center"" aria-hidden=""true"">
                        <div class=""w-full border-t border-gray-300"" />
                    </div>
                </div>
            </div>

            <div class=""mt-6"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c0c2bc3c3ba79af7fccbd1e7cd574516c4e29ea5895", async() => {
                WriteLiteral(@"
                    <div class=""space-y-1"">
                        <div class=""space-y-2"">
                            Id: <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                       type=""text"" name=""categoryId"" id=""categoryId""");
                BeginWriteAttribute("value", " value=\"", 1363, "\"", 1391, 1);
#nullable restore
#line 29 "C:\Users\LENOVO-PC\Desktop\SWP\order\SWP\Views\Containers\Category\CategoryUpdate.cshtml"
WriteAttributeValue("", 1371, category.CategoryId, 1371, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""CategoryId"" readonly />
                        </div>
                        <div class=""space-y-2"">
                            Name: <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                         type=""text"" name=""name"" id=""name""");
                BeginWriteAttribute("value", " value=\"", 1709, "\"", 1731, 1);
#nullable restore
#line 33 "C:\Users\LENOVO-PC\Desktop\SWP\order\SWP\Views\Containers\Category\CategoryUpdate.cshtml"
WriteAttributeValue("", 1717, category.Name, 1717, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required placeholder=""Name"" />
                                  <div id=""NAMEERROR"" data-label=""Name"" class=""text-red-500 ""></div>
                        </div>
                        <div class=""space-y-2 "">
                            Description:<textarea class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                                 name=""description"" id=""description"" rows=""10"" cols=""70"">");
#nullable restore
#line 38 "C:\Users\LENOVO-PC\Desktop\SWP\order\SWP\Views\Containers\Category\CategoryUpdate.cshtml"
                                                                                                    Write(category.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>                   
                            <div id=""DESCRIPTIONERROR"" class=""text-red-500 ""></div>
                        </div>
                        <div class=""space-y-2 "">
                            Create Date: <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                                type=""text"" name=""createDate"" id=""createDate""");
                BeginWriteAttribute("value", " value=\"", 2629, "\"", 2657, 1);
#nullable restore
#line 43 "C:\Users\LENOVO-PC\Desktop\SWP\order\SWP\Views\Containers\Category\CategoryUpdate.cshtml"
WriteAttributeValue("", 2637, category.CreateDate, 2637, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""CreateDate"" readonly />
                        </div>
                        <div class=""space-y-2 "">
                            Status: <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                   type=""text"" name=""status"" id=""status""");
                BeginWriteAttribute("value", " value=\"", 2976, "\"", 3000, 1);
#nullable restore
#line 47 "C:\Users\LENOVO-PC\Desktop\SWP\order\SWP\Views\Containers\Category\CategoryUpdate.cshtml"
WriteAttributeValue("", 2984, category.Status, 2984, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Status\" readonly />\r\n                        </div>\r\n                    </div>\r\n                    <div>\r\n                        <button type=\"submit\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3168, "\"", 3251, 11);
                WriteAttributeValue("", 3178, "return", 3178, 6, true);
                WriteAttributeValue(" ", 3184, "confirm(\'Are", 3185, 13, true);
                WriteAttributeValue(" ", 3197, "you", 3198, 4, true);
                WriteAttributeValue(" ", 3201, "sura", 3202, 5, true);
                WriteAttributeValue(" ", 3206, "you", 3207, 4, true);
                WriteAttributeValue(" ", 3210, "want", 3211, 5, true);
                WriteAttributeValue(" ", 3215, "to", 3216, 3, true);
                WriteAttributeValue(" ", 3218, "Update", 3219, 7, true);
                WriteAttributeValue(" ", 3225, "Category", 3226, 9, true);
#nullable restore
#line 51 "C:\Users\LENOVO-PC\Desktop\SWP\order\SWP\Views\Containers\Category\CategoryUpdate.cshtml"
WriteAttributeValue(" ", 3234, category.Name, 3235, 14, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3249, "\')", 3249, 2, true);
                EndWriteAttribute();
                WriteLiteral(@"
                                class=""w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
                            Update Category
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
            BeginWriteAttribute("alt", "\r\n         alt=\"", 3974, "\"", 3990, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c0c2bc3c3ba79af7fccbd1e7cd574516c4e29ea13372", async() => {
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
