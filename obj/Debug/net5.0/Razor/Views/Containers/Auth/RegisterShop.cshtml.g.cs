#pragma checksum "C:\Users\LENOVO-PC\Desktop\New folder\Fix sheller\SWP\Views\Containers\Auth\RegisterShop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "093f775f15b8804764b3233834406deac477d789"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_Auth_RegisterShop), @"mvc.1.0.view", @"/Views/Containers/Auth/RegisterShop.cshtml")]
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
#line 1 "C:\Users\LENOVO-PC\Desktop\New folder\Fix sheller\SWP\Views\_ViewImports.cshtml"
using MedicalStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO-PC\Desktop\New folder\Fix sheller\SWP\Views\_ViewImports.cshtml"
using MedicalStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\LENOVO-PC\Desktop\New folder\Fix sheller\SWP\Views\Containers\Auth\RegisterShop.cshtml"
using MedicalStore.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"093f775f15b8804764b3233834406deac477d789", @"/Views/Containers/Auth/RegisterShop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_Auth_RegisterShop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("registerShopForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\LENOVO-PC\Desktop\New folder\Fix sheller\SWP\Views\Containers\Auth\RegisterShop.cshtml"
  
    this.ViewData["Title"] = Routers.RegisterShop.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""min-h-full flex "">
    <div class=""flex-1 flex flex-col justify-center py-12 px-4 sm:px-6 lg:flex-none lg:px-20 xl:px-24"">
        <div class=""mx-auto w-full max-w-sm lg:w-96"">
            <div>
                <img class=""h-12 w-auto"" src=""https://tailwindui.com/img/logos/workflow-mark-indigo-600.svg""
                    alt=""Workflow"" />
                <h2 class=""mt-6 text-3xl font-extrabold text-gray-900"">Sign up new shop account</h2>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "093f775f15b8804764b3233834406deac477d7895332", async() => {
                WriteLiteral("\r\n\r\n                    <div class=\"space-y-1\">\r\n                        ");
#nullable restore
#line 28 "C:\Users\LENOVO-PC\Desktop\New folder\Fix sheller\SWP\Views\Containers\Auth\RegisterShop.cshtml"
                   Write(await Html.PartialAsync("../../Components/Form/FormMessage.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <div class=\"space-y-2 \">\r\n                            <input class=\"block px-4 py-3 w-full border-gray-300 intro-x login__input form-control\"\r\n                                type=\"text\" name=\"name\" id=\"name\"");
                BeginWriteAttribute("value", " value=\"", 1374, "\"", 1382, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Shop Name"" />
                            <div id=""NAMERROR"" data-label="""" class=""text-red-500 ""></div>
                        </div>
                        <div class=""space-y-2 "">
                            <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                type=""text"" name=""username"" id=""username""");
                BeginWriteAttribute("value", " value=\"", 1775, "\"", 1783, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Username"" />
                            <div id=""USERNAMEERROR"" data-label="""" class=""text-red-500 ""></div>
                        </div>
                        <div class=""space-y-2 "">
                            <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                type=""password"" name=""password"" id=""password""");
                BeginWriteAttribute("value", " value=\"", 2184, "\"", 2192, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Password"" />
                            <div id=""PASSWORDERROR"" data-label="""" class=""text-red-500 ""></div>
                        </div>
                        <div class=""space-y-2 "">
                            <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                type=""password"" name=""confirmPassword"" id=""confirmPassword""");
                BeginWriteAttribute("value", " value=\"", 2607, "\"", 2615, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                                placeholder=""Confirm Password"" />
                            <div id=""CONFIRMPASSWORDERROR"" data-label="""" class=""text-red-500 ""></div>
                        </div>
                        <div class=""space-y-2 "">
                            <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                type=""text"" name=""phone"" id=""phone""");
                BeginWriteAttribute("value", " value=\"", 3054, "\"", 3062, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Phone"" />
                            <div id=""PHONEERROR"" data-label="""" class=""text-red-500 ""></div>
                        </div>
                        <div class=""space-y-2 "">
                            <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                type=""text"" name=""email"" id=""email""");
                BeginWriteAttribute("value", " value=\"", 3447, "\"", 3455, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Email"" />
                            <div id=""EMAILERROR"" data-label="""" class=""text-red-500 ""></div>
                        </div>
                        <div class=""space-y-2 "">
                            <input class=""block px-4 py-3 w-full border-gray-300 intro-x login__input form-control""
                                type=""text"" name=""address"" id=""address""");
                BeginWriteAttribute("value", " value=\"", 3844, "\"", 3852, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Address"" />
                            <div id=""ADDRESSERROR"" data-label="""" class=""text-red-500 ""></div>
                        </div>
                    </div>
                    <div>
                        <button type=""submit""
                            class=""w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-green-500 hover:bg-green-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
                            Sign up
                        </button>
                        <a");
                BeginWriteAttribute("href", " href=\"", 4466, "\"", 4492, 1);
#nullable restore
#line 71 "C:\Users\LENOVO-PC\Desktop\New folder\Fix sheller\SWP\Views\Containers\Auth\RegisterShop.cshtml"
WriteAttributeValue("", 4473, Routers.Login.Link, 4473, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"
                            class=""w-full flex justify-center py-2 my-4 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">Sign
                            in</a>
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
            BeginWriteAttribute("alt", "\r\n        alt=\"", 5173, "\"", 5188, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n<script src=\"/js/registerShop.js\"></script>\r\n\r\n");
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
