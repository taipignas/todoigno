#pragma checksum "C:\Users\Ignas\source\repos\ToDoFinal\ToDoFinal\Pages\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91e94230a6b1a2810ef63a78f59e1bee6e6ef9dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ToDoFinal.Pages.Account.Pages_Account_Index), @"mvc.1.0.razor-page", @"/Pages/Account/Index.cshtml")]
namespace ToDoFinal.Pages.Account
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
#line 1 "C:\Users\Ignas\source\repos\ToDoFinal\ToDoFinal\Pages\_ViewImports.cshtml"
using ToDoFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ignas\source\repos\ToDoFinal\ToDoFinal\Pages\Account\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ignas\source\repos\ToDoFinal\ToDoFinal\Pages\Account\Index.cshtml"
using ToDoFinal.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91e94230a6b1a2810ef63a78f59e1bee6e6ef9dd", @"/Pages/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fbfd1a76f747131bf2e909237d29da0b7161199", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Account_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome ");
#nullable restore
#line 10 "C:\Users\Ignas\source\repos\ToDoFinal\ToDoFinal\Pages\Account\Index.cshtml"
                             Write(UserManager.GetUserName(User));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>You can view your tasks <a href=\"/index\">here</a>.</p>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ToDoUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ToDoUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoFinal.web.Pages.Account.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ToDoFinal.web.Pages.Account.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ToDoFinal.web.Pages.Account.IndexModel>)PageContext?.ViewData;
        public ToDoFinal.web.Pages.Account.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591