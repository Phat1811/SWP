#pragma checksum "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa3529d26b22cd2c708b03c168b34e0467586b74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_User_Manage), @"mvc.1.0.view", @"/Views/Containers/User/Manage.cshtml")]
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
#line 1 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\Manage.cshtml"
using MedicalStore.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa3529d26b22cd2c708b03c168b34e0467586b74", @"/Views/Containers/User/Manage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    public class Views_Containers_User_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formFilter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\Manage.cshtml"
  
    this.ViewData["Title"] = Routers.ManageAccount.Title;

    var listUser = (List<User>)this.ViewData["listUser"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex-1 min-h-screen px-2 py-2 xl:px-8 xl:py-6\">\r\n    <div class=\"flex\">\r\n        ");
#nullable restore
#line 11 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\Manage.cshtml"
   Write(await Html.PartialAsync("../../Components/Navbar/NavbarSide.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""container"">
            <div class=""mt-5 intro-y box"">
                <div class=""flex flex-col items-center p-5 border-b border-gray-200 sm:flex-row"">
                    <h2 class=""mr-auto text-base font-medium"">
                        All Categories
                    </h2>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa3529d26b22cd2c708b03c168b34e0467586b744816", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 20 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\Manage.cshtml"
               Write(await Html.PartialAsync("../../Components/Form/FormHidden.cshtml",
                    new { Name = "pageSize", Value = (string)this.Context.Request.Query["pageSize"] ?? "12" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 22 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\Manage.cshtml"
               Write(await Html.PartialAsync("../../Components/Form/FormHidden.cshtml",
                    new { Name = "pageIndex", Value = (string)this.Context.Request.Query["pageIndex"] ?? "0" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""p-5"" id=""hoverable-table"">
                    <div class=""preview"">
                        <div class=""overflow-x-auto"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">#</th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Name</th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Phone</th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Address</th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Status</th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Role</th>
                       ");
            WriteLiteral("                 <th class=\"border border-b-2 dark:border-dark-5 whitespace-nowrap\">Profile</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\Manage.cshtml"
                                     for (int i = 0; i < listUser.Count; i++)
                                    {
                                        var item = listUser[i];
                                        var link = $"{Routers.UserProfile.Link}?userId={item.UserId}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"hover:bg-gray-200\">\r\n                                            <td class=\"border\">");
#nullable restore
#line 46 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\Manage.cshtml"
                                                           Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 47 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\Manage.cshtml"
                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 48 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\Manage.cshtml"
                                                          Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 49 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\Manage.cshtml"
                                                          Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 50 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\Manage.cshtml"
                                                          Write(await Html.PartialAsync("../../Components/Table/Status.cshtml", item.Status == UserStatus.ACTIVE));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 51 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\Manage.cshtml"
                                                          Write(item.RoleId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 3418, "\"", 3430, 1);
#nullable restore
#line 53 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\Manage.cshtml"
WriteAttributeValue("", 3425, link, 3425, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""mb-2 mr-1 btn btn-primary"">
                                                    <i data-feather=""shopping-bag"" class=""w-5 h-5""></i>
                                                </a>
                                            </td>
                                        </tr>
");
#nullable restore
#line 58 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\Manage.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                            ");
#nullable restore
#line 61 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Containers\User\Manage.cshtml"
                       Write(await Html.PartialAsync("../../Components/Common/Pagination.cshtml",
                            new
                                 {
                                     PageIndex = (string)this.Context.Request.Query["pageIndex"] ?? "0",
                                     PageSize =
                            (string)
                            this.Context.Request.Query["pageSize"] ?? "12",
                                     Total = listUser.Count
                                 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
