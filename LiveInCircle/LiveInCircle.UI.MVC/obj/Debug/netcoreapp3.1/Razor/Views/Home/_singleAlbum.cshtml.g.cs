#pragma checksum "C:\Users\MURATUS\Desktop\BitirmeProjesi\LiveInCircle\LiveInCircle.UI.MVC\Views\Home\_singleAlbum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2a55d6fd0ec23ee1612329641a479bca21fdb0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__singleAlbum), @"mvc.1.0.view", @"/Views/Home/_singleAlbum.cshtml")]
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
#line 1 "C:\Users\MURATUS\Desktop\BitirmeProjesi\LiveInCircle\LiveInCircle.UI.MVC\Views\_ViewImports.cshtml"
using LiveInCircle.UI.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MURATUS\Desktop\BitirmeProjesi\LiveInCircle\LiveInCircle.UI.MVC\Views\_ViewImports.cshtml"
using LiveInCircle.UI.MVC.Models.Cart;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2a55d6fd0ec23ee1612329641a479bca21fdb0f", @"/Views/Home/_singleAlbum.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d8c29628737d480ff23ae783783c94ddad4e38c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__singleAlbum : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AlbumVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\MURATUS\Desktop\BitirmeProjesi\LiveInCircle\LiveInCircle.UI.MVC\Views\Home\_singleAlbum.cshtml"
     foreach (AlbumVM item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- Single Album -->\r\n        <div class=\"single-album\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 158, "\"", 181, 1);
#nullable restore
#line 10 "C:\Users\MURATUS\Desktop\BitirmeProjesi\LiveInCircle\LiveInCircle.UI.MVC\Views\Home\_singleAlbum.cshtml"
WriteAttributeValue("", 164, item.AlbumArtUrl, 164, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 182, "\"", 188, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"album-info\">\r\n                <a href=\"#\">\r\n                    <h4>");
#nullable restore
#line 13 "C:\Users\MURATUS\Desktop\BitirmeProjesi\LiveInCircle\LiveInCircle.UI.MVC\Views\Home\_singleAlbum.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h5>");
#nullable restore
#line 14 "C:\Users\MURATUS\Desktop\BitirmeProjesi\LiveInCircle\LiveInCircle.UI.MVC\Views\Home\_singleAlbum.cshtml"
                   Write(item.ArtistName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </a>\r\n                <p>");
#nullable restore
#line 16 "C:\Users\MURATUS\Desktop\BitirmeProjesi\LiveInCircle\LiveInCircle.UI.MVC\Views\Home\_singleAlbum.cshtml"
              Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\MURATUS\Desktop\BitirmeProjesi\LiveInCircle\LiveInCircle.UI.MVC\Views\Home\_singleAlbum.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AlbumVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
