#pragma checksum "C:\Users\Ignas\source2\ToDoFinal\ToDoFinal\Pages\NewUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5db98f6289ef097c79ab40b65ff1435790727f2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ToDoFinal.Pages.Pages_NewUser), @"mvc.1.0.razor-page", @"/Pages/NewUser.cshtml")]
namespace ToDoFinal.Pages
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
#line 1 "C:\Users\Ignas\source2\ToDoFinal\ToDoFinal\Pages\_ViewImports.cshtml"
using ToDoFinal;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5db98f6289ef097c79ab40b65ff1435790727f2f", @"/Pages/NewUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fbfd1a76f747131bf2e909237d29da0b7161199", @"/Pages/_ViewImports.cshtml")]
    public class Pages_NewUser : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Please <a href=\"/Account/Register\">register</a> or <a href=\"/Account/Login\">login</a> to start using our </h1>\r\n        <h1 class=\"display-4\">task management services</h1>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoFinal.web.Pages.NewUserModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ToDoFinal.web.Pages.NewUserModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ToDoFinal.web.Pages.NewUserModel>)PageContext?.ViewData;
        public ToDoFinal.web.Pages.NewUserModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
