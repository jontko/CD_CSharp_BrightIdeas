#pragma checksum "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Shared/PartialIdeaScroll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad699661a2a47ec1d1c933a93fb2409b1553c0cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PartialIdeaScroll), @"mvc.1.0.view", @"/Views/Shared/PartialIdeaScroll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/PartialIdeaScroll.cshtml", typeof(AspNetCore.Views_Shared_PartialIdeaScroll))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad699661a2a47ec1d1c933a93fb2409b1553c0cd", @"/Views/Shared/PartialIdeaScroll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3089d01e8107546353dc71acbeb0ef609963fe45", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialIdeaScroll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Idea>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 283, true);
            WriteLiteral(@"
<div class=""scrollwindow"">
<h1>This is where the ideas will scroll. </h1>
</div>

Table>
    <thead>
        <th>Alias/th>
        <th>Idea</th>
        <th>Like and Likes</th>
    </thead>
    <tbody>
        <!-- Declare type, element name, where you are getting element from -->
");
            EndContext();
#line 15 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Shared/PartialIdeaScroll.cshtml"
         foreach(Idea idea in Model){

#line default
#line hidden
            BeginContext(340, 40, true);
            WriteLiteral("            <tr>\n                <td> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 380, "\"", 412, 2);
            WriteAttributeValue("", 387, "/UserDetails/", 387, 13, true);
#line 17 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Shared/PartialIdeaScroll.cshtml"
WriteAttributeValue("", 400, idea.UserId, 400, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(413, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(416, 20, false);
#line 17 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Shared/PartialIdeaScroll.cshtml"
                                                     Write(idea.IdeaOwner.Alias);

#line default
#line hidden
            EndContext();
            BeginContext(436, 30, true);
            WriteLiteral("</a></td>\n                <td>");
            EndContext();
            BeginContext(467, 12, false);
#line 18 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Shared/PartialIdeaScroll.cshtml"
               Write(idea.Concept);

#line default
#line hidden
            EndContext();
            BeginContext(479, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(506, 16, false);
#line 19 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Shared/PartialIdeaScroll.cshtml"
               Write(idea.Likes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(522, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 20 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Shared/PartialIdeaScroll.cshtml"
                     if(ViewBag.Id == @idea.IdeaOwner.UserId)
                {

#line default
#line hidden
            BeginContext(608, 27, true);
            WriteLiteral("                    <td> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 635, "\"", 666, 2);
            WriteAttributeValue("", 642, "/deleteidea/", 642, 12, true);
#line 22 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Shared/PartialIdeaScroll.cshtml"
WriteAttributeValue("", 654, idea.IdeaId, 654, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(667, 21, true);
            WriteLiteral(">| Delete |</a></td>\n");
            EndContext();
#line 23 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Shared/PartialIdeaScroll.cshtml"
                }
                else {
                    bool check = true;
                    foreach(Like like in Model){
                        if(idea.UserId == ViewBag.Id){
                            check = false;
                        }
                    }
                    if(check == true){

#line default
#line hidden
            BeginContext(1002, 31, true);
            WriteLiteral("                        <td> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1033, "\"", 1062, 2);
            WriteAttributeValue("", 1040, "/Likeidea/", 1040, 10, true);
#line 32 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Shared/PartialIdeaScroll.cshtml"
WriteAttributeValue("", 1050, idea.IdeaId, 1050, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1063, 19, true);
            WriteLiteral(">| Like |</a></td>\n");
            EndContext();
#line 33 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Shared/PartialIdeaScroll.cshtml"
                    }
                    else{

#line default
#line hidden
            BeginContext(1130, 31, true);
            WriteLiteral("                        <td> <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1161, "\"", 1193, 2);
            WriteAttributeValue("", 1168, "/Un-Likeidea/", 1168, 13, true);
#line 35 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Shared/PartialIdeaScroll.cshtml"
WriteAttributeValue("", 1181, idea.IdeaId, 1181, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1194, 23, true);
            WriteLiteral(">| Un-Like |</a> </td>\n");
            EndContext();
#line 36 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Shared/PartialIdeaScroll.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(1257, 18, true);
            WriteLiteral("            </tr>\n");
            EndContext();
#line 39 "/Users/joshuaontko/CodingDojo/C#/ORM/BrightIdeas/Views/Shared/PartialIdeaScroll.cshtml"
        }

#line default
#line hidden
            BeginContext(1285, 21, true);
            WriteLiteral("    </tbody>\n</Table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Idea>> Html { get; private set; }
    }
}
#pragma warning restore 1591