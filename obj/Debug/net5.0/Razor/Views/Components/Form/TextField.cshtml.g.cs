#pragma checksum "D:\mainv1_SWP\Views\Components\Form\TextField.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bddb0bd4c01be73b76643d4e47fcd7d4f56b53fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_Form_TextField), @"mvc.1.0.view", @"/Views/Components/Form/TextField.cshtml")]
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
#line 1 "D:\mainv1_SWP\Views\_ViewImports.cshtml"
using MedicalStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\mainv1_SWP\Views\_ViewImports.cshtml"
using MedicalStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bddb0bd4c01be73b76643d4e47fcd7d4f56b53fd", @"/Views/Components/Form/TextField.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_Form_TextField : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\mainv1_SWP\Views\Components\Form\TextField.cshtml"
  
    Console.WriteLine(Model.Field);
    var error = $"{Model.Field.ToUpper()}ERROR";
    string value = Model.Value == null ? "" : Model.Value;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"space-y-2 \">\r\n    <input class=\"block px-4 py-3 w-full border-gray-300 intro-x login__input form-control\"");
            BeginWriteAttribute("type", " type=\"", 275, "\"", 293, 1);
#nullable restore
#line 9 "D:\mainv1_SWP\Views\Components\Form\TextField.cshtml"
WriteAttributeValue("", 282, Model.Type, 282, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", "\r\n        name=\"", 294, "\"", 322, 1);
#nullable restore
#line 10 "D:\mainv1_SWP\Views\Components\Form\TextField.cshtml"
WriteAttributeValue("", 310, Model.Field, 310, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 323, "\"", 340, 1);
#nullable restore
#line 10 "D:\mainv1_SWP\Views\Components\Form\TextField.cshtml"
WriteAttributeValue("", 328, Model.Field, 328, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 341, "\"", 355, 1);
#nullable restore
#line 10 "D:\mainv1_SWP\Views\Components\Form\TextField.cshtml"
WriteAttributeValue("", 349, value, 349, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("placeholder", " placeholder=\"", 356, "\"", 382, 1);
#nullable restore
#line 10 "D:\mainv1_SWP\Views\Components\Form\TextField.cshtml"
WriteAttributeValue("", 370, Model.Label, 370, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div");
            BeginWriteAttribute("id", " id=\"", 396, "\"", 407, 1);
#nullable restore
#line 11 "D:\mainv1_SWP\Views\Components\Form\TextField.cshtml"
WriteAttributeValue("", 401, error, 401, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-label=\"");
#nullable restore
#line 11 "D:\mainv1_SWP\Views\Components\Form\TextField.cshtml"
                            Write(Model.Label);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"text-red-500 \"></div>\r\n</div>");
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
