#pragma checksum "C:\Users\yllek\source\repos\Lab 21\Lab 21\Views\Movie\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38b268045bafad52e293429b71edb6d834e93489"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Summary), @"mvc.1.0.view", @"/Views/Movie/Summary.cshtml")]
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
#line 1 "C:\Users\yllek\source\repos\Lab 21\Lab 21\Views\_ViewImports.cshtml"
using Lab_21;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yllek\source\repos\Lab 21\Lab 21\Views\_ViewImports.cshtml"
using Lab_21.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b268045bafad52e293429b71edb6d834e93489", @"/Views/Movie/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c0ba241406914a0726fad3a25e1178dbc8eb6be", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\yllek\source\repos\Lab 21\Lab 21\Views\Movie\Summary.cshtml"
  
    ViewData["Title"] = "Summary";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Summary</h1>\r\n\r\n<h2>");
#nullable restore
#line 10 "C:\Users\yllek\source\repos\Lab 21\Lab 21\Views\Movie\Summary.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is Registered!</h2>\r\n<h2>Here\'s a little bit of info about the movie registered: ");
#nullable restore
#line 11 "C:\Users\yllek\source\repos\Lab 21\Lab 21\Views\Movie\Summary.cshtml"
                                                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" stars ");
#nullable restore
#line 11 "C:\Users\yllek\source\repos\Lab 21\Lab 21\Views\Movie\Summary.cshtml"
                                                                          Write(Model.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral(", & was directed by ");
#nullable restore
#line 11 "C:\Users\yllek\source\repos\Lab 21\Lab 21\Views\Movie\Summary.cshtml"
                                                                                                           Write(Model.Directors);

#line default
#line hidden
#nullable disable
            WriteLiteral(". </h2>\r\n<h2>");
#nullable restore
#line 12 "C:\Users\yllek\source\repos\Lab 21\Lab 21\Views\Movie\Summary.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" was released on ");
#nullable restore
#line 12 "C:\Users\yllek\source\repos\Lab 21\Lab 21\Views\Movie\Summary.cshtml"
                            Write(Model.Year.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" and from the looks of it has at least one fan.</h2>\r\n<h2>Thanks for that, take care!</h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
