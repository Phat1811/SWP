#pragma checksum "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad254cfdc75d79da9930cfe08bc2c014213cd712"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_User_UserProfile), @"mvc.1.0.view", @"/Views/Containers/User/UserProfile.cshtml")]
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
#line 1 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\_ViewImports.cshtml"
using MedicalStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\_ViewImports.cshtml"
using MedicalStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml"
using MedicalStore.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad254cfdc75d79da9930cfe08bc2c014213cd712", @"/Views/Containers/User/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_User_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("banForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("space-y-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/user/ban.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml"
  
    this.ViewData["Title"] = Routers.UserProfile.Title;
    var user = (User)this.ViewData["user"];
    var userProfile = (User)this.ViewData["userProfile"];
    int check = (int)this.ViewData["check"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex-1 min-h-screen px-2 py-2 xl:px-8 xl:py-6\">\r\n    <div class=\"flex\">\r\n        ");
#nullable restore
#line 11 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml"
   Write(await Html.PartialAsync("../../Components/Navbar/NavbarSide.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""container"">
            <div class=""mt-5 intro-y box"">
                <div class=""flex flex-col items-center p-5 border-b border-gray-200 sm:flex-row"">
                    <h2 class=""mr-auto text-base font-medium"">
                        ");
#nullable restore
#line 16 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml"
                   Write(userProfile.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Profile
                    </h2>
                </div>
                <div>
                    <dl class=""mt-2 divide-y divide-gray-200"">
                        <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                        <dt class=""text-sm font-medium text-gray-500"">Username</dt>
                        <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 23 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml"
                                                                                Write(userProfile.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                </div>
                <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                    <dt class=""text-sm font-medium text-gray-500"">FullName</dt>
                    <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 27 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml"
                                                                            Write(userProfile.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                </div>
                <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                    <dt class=""text-sm font-medium text-gray-500"">Email address</dt>
                    <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 31 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml"
                                                                            Write(userProfile.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                </div>
                <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                    <dt class=""text-sm font-medium text-gray-500"">Phone Number</dt>
                    <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 35 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml"
                                                                            Write(userProfile.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                </div>
                <div class=""py-4 sm:py-5 sm:grid sm:grid-cols-3 sm:gap-4 sm:px-6"">
                    <dt class=""text-sm font-medium text-gray-500"">Address</dt>
                    <dd class=""mt-1 text-sm text-gray-900 sm:mt-0 sm:col-span-2"">");
#nullable restore
#line 39 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml"
                                                                            Write(userProfile.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                </div>\r\n                </dl>\r\n            </div>\r\n");
#nullable restore
#line 43 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml"
             if (user != null &&  check == 1 && user.RoleId == "0")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""min-h-full flex "">
                    <div class=""flex-1 flex flex-col justify-center py-12 px-4 sm:px-6 lg:flex-none lg:px-20 xl:px-24"">
                        <div class=""mx-auto w-full max-w-sm lg:w-96"">
                            <div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad254cfdc75d79da9930cfe08bc2c014213cd7129720", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"userId\" id=\"userId\"");
                BeginWriteAttribute("value", " value=\"", 2901, "\"", 2928, 1);
#nullable restore
#line 50 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml"
WriteAttributeValue("", 2909, userProfile.UserId, 2909, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 51 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml"
                                     if (userProfile.Status == UserStatus.ACTIVE)
                                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <button type=\"submit\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3119, "\"", 3203, 12);
                WriteAttributeValue("", 3129, "return", 3129, 6, true);
                WriteAttributeValue(" ", 3135, "confirm(\'Are", 3136, 13, true);
                WriteAttributeValue(" ", 3148, "you", 3149, 4, true);
                WriteAttributeValue(" ", 3152, "sura", 3153, 5, true);
                WriteAttributeValue(" ", 3157, "you", 3158, 4, true);
                WriteAttributeValue(" ", 3161, "want", 3162, 5, true);
                WriteAttributeValue(" ", 3166, "to", 3167, 3, true);
                WriteAttributeValue(" ", 3169, "ban", 3170, 4, true);
                WriteAttributeValue(" ", 3173, "this", 3174, 5, true);
                WriteAttributeValue(" ", 3178, "user", 3179, 5, true);
#nullable restore
#line 54 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml"
WriteAttributeValue(" ", 3183, userProfile.Name, 3184, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3201, "\')", 3201, 2, true);
                EndWriteAttribute();
                WriteLiteral(@"
                                                class=""w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
                                            Ban User
                                        </button>
");
#nullable restore
#line 58 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <button type=\"submit\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3773, "\"", 3859, 12);
                WriteAttributeValue("", 3783, "return", 3783, 6, true);
                WriteAttributeValue(" ", 3789, "confirm(\'Are", 3790, 13, true);
                WriteAttributeValue(" ", 3802, "you", 3803, 4, true);
                WriteAttributeValue(" ", 3806, "sura", 3807, 5, true);
                WriteAttributeValue(" ", 3811, "you", 3812, 4, true);
                WriteAttributeValue(" ", 3815, "want", 3816, 5, true);
                WriteAttributeValue(" ", 3820, "to", 3821, 3, true);
                WriteAttributeValue(" ", 3823, "unban", 3824, 6, true);
                WriteAttributeValue(" ", 3829, "this", 3830, 5, true);
                WriteAttributeValue(" ", 3834, "user", 3835, 5, true);
#nullable restore
#line 61 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml"
WriteAttributeValue(" ", 3839, userProfile.Name, 3840, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3857, "\')", 3857, 2, true);
                EndWriteAttribute();
                WriteLiteral(@"
                                                class=""w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
                                            UnBan User
                                        </button>
");
#nullable restore
#line 65 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
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
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 71 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\UserProfile.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad254cfdc75d79da9930cfe08bc2c014213cd71216317", async() => {
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
