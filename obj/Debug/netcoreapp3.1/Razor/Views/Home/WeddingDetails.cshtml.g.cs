#pragma checksum "C:\Users\jenny\OneDrive\Desktop\weddingPlanner\WeddingPlanner\Views\Home\WeddingDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4553a2e30a4acc3daa3940ff6b66882d434a2d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WeddingDetails), @"mvc.1.0.view", @"/Views/Home/WeddingDetails.cshtml")]
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
#line 1 "C:\Users\jenny\OneDrive\Desktop\weddingPlanner\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jenny\OneDrive\Desktop\weddingPlanner\WeddingPlanner\Views\_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4553a2e30a4acc3daa3940ff6b66882d434a2d8", @"/Views/Home/WeddingDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9e38482b8beecdb199b7be73dfa5c3d6a2f574", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WeddingDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wrapper>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4553a2e30a4acc3daa3940ff6b66882d434a2d83327", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Wedding Details!</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4553a2e30a4acc3daa3940ff6b66882d434a2d84446", async() => {
                WriteLiteral("\r\n    <div>\r\n        <h1>");
#nullable restore
#line 12 "C:\Users\jenny\OneDrive\Desktop\weddingPlanner\WeddingPlanner\Views\Home\WeddingDetails.cshtml"
       Write(Model.Wedding.WedderOne);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\jenny\OneDrive\Desktop\weddingPlanner\WeddingPlanner\Views\Home\WeddingDetails.cshtml"
                                Write(Model.Wedding.WedderTwo);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Wedding!</h1>\r\n        <a href=\"dashboard\">Dashboard</a>\r\n        <a href=\"logOut\">Log out</a>\r\n    </div>\r\n    <h2>Date: ");
#nullable restore
#line 16 "C:\Users\jenny\OneDrive\Desktop\weddingPlanner\WeddingPlanner\Views\Home\WeddingDetails.cshtml"
         Write(Model.Wedding.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n    <h3>Guests</h3>\r\n    <ul>\r\n");
#nullable restore
#line 19 "C:\Users\jenny\OneDrive\Desktop\weddingPlanner\WeddingPlanner\Views\Home\WeddingDetails.cshtml"
         foreach(var guest in @Model.Wedding.RSVPList)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>");
#nullable restore
#line 21 "C:\Users\jenny\OneDrive\Desktop\weddingPlanner\WeddingPlanner\Views\Home\WeddingDetails.cshtml"
           Write(guest.User.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\jenny\OneDrive\Desktop\weddingPlanner\WeddingPlanner\Views\Home\WeddingDetails.cshtml"
                                 Write(guest.User.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 22 "C:\Users\jenny\OneDrive\Desktop\weddingPlanner\WeddingPlanner\Views\Home\WeddingDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n\r\n");
                WriteLiteral("    <div>\r\n        <iframe width=\"600\" height=\"450\" frameborder=\"0\" style=\"border:0\"");
                BeginWriteAttribute("src", "\r\n        src=\"", 767, "\"", 887, 3);
                WriteAttributeValue("", 782, "https://www.google.com/maps/embed/v1/place?q=", 782, 45, true);
#nullable restore
#line 28 "C:\Users\jenny\OneDrive\Desktop\weddingPlanner\WeddingPlanner\Views\Home\WeddingDetails.cshtml"
WriteAttributeValue("", 827, ViewBag.Address, 827, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 843, "&key=AIzaSyD7zP1OZqgyWOHy9ALazSLDV3LiKzC_WuE", 843, 44, true);
                EndWriteAttribute();
                WriteLiteral(" allowfullscreen></iframe>\r\n    </div>\r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wrapper> Html { get; private set; }
    }
}
#pragma warning restore 1591
