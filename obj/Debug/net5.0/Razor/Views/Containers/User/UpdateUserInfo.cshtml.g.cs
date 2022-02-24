#pragma checksum "F:\Trả Nợ\SWP391\Code\Tho2\Views\Containers\User\UpdateUserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b8194373eff80b6b8543cd64082c75355fb5060"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_User_UpdateUserInfo), @"mvc.1.0.view", @"/Views/Containers/User/UpdateUserInfo.cshtml")]
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
#line 1 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Containers\User\UpdateUserInfo.cshtml"
using MedicalStore.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b8194373eff80b6b8543cd64082c75355fb5060", @"/Views/Containers/User/UpdateUserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_User_UpdateUserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formUpdateUser"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Containers\User\UpdateUserInfo.cshtml"
  
    this.ViewData["Title"] = Routers.UpdateUserInfo.Title;
    var user = (User)this.ViewData["user"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""min-h-full flex "">
    <div class=""flex-1 flex flex-col justify-center py-12 px-4 sm:px-6 lg:flex-none lg:px-20 xl:px-24"">
        <div class=""mx-auto w-full max-w-sm lg:w-96"">
            <div>
                <img class=""h-12 w-auto"" src=""https://tailwindui.com/img/logos/workflow-mark-indigo-600.svg""
                     alt=""Workflow"" width=""250"" height=""200"" />
                <h2 class=""mt-6 text-3xl font-extrabold text-gray-900"">Update User Info</h2>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b8194373eff80b6b8543cd64082c75355fb50605269", async() => {
                WriteLiteral(@"
                    <div class=""space-y-1"">
                        <label htmlFor=""name"" class=""block text-sm font-medium text-gray-700"">
                            Name
                        </label>
                        <div class=""mt-1"">
                            <input id=""name"" name=""name"" type=""text""");
                BeginWriteAttribute("autoComplete", " autoComplete=\"", 1376, "\"", 1391, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1392, "\"", 1410, 1);
#nullable restore
#line 30 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Containers\User\UpdateUserInfo.cshtml"
WriteAttributeValue("", 1400, user.Name, 1400, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required
                                   class=""appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"" />
                            <div id=""NAMERROR"" data-label=""Name"" class=""text-red-500 ""></div>
                        </div>
                    </div>

                    <div class=""space-y-1"">
                        <label htmlFor=""phone"" class=""block text-sm font-medium text-gray-700"">
                            Phone
                        </label>
                        <div class=""mt-1"">
                            <input id=""phone"" name=""phone"" type=""text""");
                BeginWriteAttribute("autoComplete", " autoComplete=\"", 2131, "\"", 2146, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2147, "\"", 2166, 1);
#nullable restore
#line 41 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Containers\User\UpdateUserInfo.cshtml"
WriteAttributeValue("", 2155, user.Phone, 2155, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required
                                   class=""appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"" />
                            <div id=""PHONEERROR"" data-label=""Phone"" class=""text-red-500 ""></div>
                        </div>
                    </div>

                    <div class=""space-y-1"">
                        <label htmlFor=""address"" class=""block text-sm font-medium text-gray-700"">
                            Address
                        </label>
                        <div class=""mt-1"">
                            <input id=""address"" name=""address"" type=""text""");
                BeginWriteAttribute("autoComplete", " autoComplete=\"", 2898, "\"", 2913, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2914, "\"", 2935, 1);
#nullable restore
#line 52 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Containers\User\UpdateUserInfo.cshtml"
WriteAttributeValue("", 2922, user.Address, 2922, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required
                                   class=""appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"" />
                            <div id=""ADDRESSERROR"" data-label=""Address"" class=""text-red-500 ""></div>
                        </div>
                    </div>

                    <div class=""space-y-1"">
                        <label htmlFor=""email"" class=""block text-sm font-medium text-gray-700"">
                            Email
                        </label>
                        <div class=""mt-1"">
                            <input id=""email"" name=""email"" type=""email"" autoComplete=""email"" required");
                BeginWriteAttribute("value", " value=\"", 3694, "\"", 3713, 1);
#nullable restore
#line 63 "F:\Trả Nợ\SWP391\Code\Tho2\Views\Containers\User\UpdateUserInfo.cshtml"
WriteAttributeValue("", 3702, user.Email, 3702, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                                   class=""appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"" />
                            <div id=""EMAILERROR"" data-label=""Email"" class=""text-red-500 ""></div>
                        </div>

                    </div>
                    <div>
                        <button type=""submit""
                                class=""w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
                            Update Information
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n<script src=\"/js/user/updateinfo.js\"></script>\r\n\r\n");
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
