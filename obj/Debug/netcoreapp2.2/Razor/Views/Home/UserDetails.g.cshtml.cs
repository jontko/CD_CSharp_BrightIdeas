#pragma checksum "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Home/UserDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5d54324382e0aaa3ec3bb3c9b4e8dd40a7f6b62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserDetails), @"mvc.1.0.view", @"/Views/Home/UserDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserDetails.cshtml", typeof(AspNetCore.Views_Home_UserDetails))]
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
#line 1 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/_ViewImports.cshtml"
using BrightIdeas;

#line default
#line hidden
#line 2 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/_ViewImports.cshtml"
using BrightIdeas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5d54324382e0aaa3ec3bb3c9b4e8dd40a7f6b62", @"/Views/Home/UserDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3089d01e8107546353dc71acbeb0ef609963fe45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Home/UserDetails.cshtml"
  
    ViewData["Title"] = "User Info";

#line default
#line hidden
            BeginContext(54, 9, true);
            WriteLiteral("<p>Name: ");
            EndContext();
            BeginContext(64, 10, false);
#line 5 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Home/UserDetails.cshtml"
    Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(74, 15, true);
            WriteLiteral("</p>\n<p>Alias: ");
            EndContext();
            BeginContext(90, 11, false);
#line 6 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Home/UserDetails.cshtml"
     Write(Model.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(101, 15, true);
            WriteLiteral("</p>\n<p>Email: ");
            EndContext();
            BeginContext(117, 11, false);
#line 7 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Home/UserDetails.cshtml"
     Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(128, 10, true);
            WriteLiteral("</p>\n<hr>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591