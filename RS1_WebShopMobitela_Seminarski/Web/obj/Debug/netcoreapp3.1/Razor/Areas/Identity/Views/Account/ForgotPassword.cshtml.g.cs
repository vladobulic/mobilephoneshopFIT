#pragma checksum "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Identity\Views\Account\ForgotPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2a14ed23047ab0f04eb26eefb511ce047dcd855"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_Account_ForgotPassword), @"mvc.1.0.view", @"/Areas/Identity/Views/Account/ForgotPassword.cshtml")]
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
#line 1 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Identity\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Identity\Views\_ViewImports.cshtml"
using Web.Areas.Identity.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Identity\Views\_ViewImports.cshtml"
using Web.Areas.Identity.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Identity\Views\_ViewImports.cshtml"
using Web.Areas.Identity.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Identity\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2a14ed23047ab0f04eb26eefb511ce047dcd855", @"/Areas/Identity/Views/Account/ForgotPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca2424d585b8aaaa394c85bba921267e8268312c", @"/Areas/Identity/Views/_ViewImports.cshtml")]
    public class Areas_Identity_Views_Account_ForgotPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ForgotPasswordViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Identity\Views\Account\ForgotPassword.cshtml"
  
    ViewData["Title"] = "Forgot your password?";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Identity\Views\Account\ForgotPassword.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h1>\r\n<p>\r\n    For more information on how to enable reset password please see this <a href=\"http://go.microsoft.com/fwlink/?LinkID=532713\">article</a>.\r\n</p>\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Identity\Views\Account\ForgotPassword.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial"); 

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForgotPasswordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591