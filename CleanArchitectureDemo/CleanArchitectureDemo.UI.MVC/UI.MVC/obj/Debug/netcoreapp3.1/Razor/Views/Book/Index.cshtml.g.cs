#pragma checksum "C:\Users\renau\source\GitHub\DotNetCleanArchitecture\CleanArchitectureDemo\CleanArchitectureDemo.UI.MVC\UI.MVC\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faef821c64c8f233e8ac47b427671a5d32dfc414"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
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
#line 1 "C:\Users\renau\source\GitHub\DotNetCleanArchitecture\CleanArchitectureDemo\CleanArchitectureDemo.UI.MVC\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\renau\source\GitHub\DotNetCleanArchitecture\CleanArchitectureDemo\CleanArchitectureDemo.UI.MVC\UI.MVC\Views\_ViewImports.cshtml"
using UI.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faef821c64c8f233e8ac47b427671a5d32dfc414", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8ea135b7da2bced915af909ed829e56536b857", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CleanArchitectureDemo.Application.ViewModels.BookViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table id=\"book\" class=\"table table-bordered table-hover\">\r\n    <thead>\r\n        <tr");
            BeginWriteAttribute("class", " class=\"", 153, "\"", 161, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <th>Name</th>\r\n            <th>ISBN</th>\r\n            <th>Author</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 12 "C:\Users\renau\source\GitHub\DotNetCleanArchitecture\CleanArchitectureDemo\CleanArchitectureDemo.UI.MVC\UI.MVC\Views\Book\Index.cshtml"
         foreach (var book in Model.Books)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"height: 60px;\">\r\n                <td>");
#nullable restore
#line 15 "C:\Users\renau\source\GitHub\DotNetCleanArchitecture\CleanArchitectureDemo\CleanArchitectureDemo.UI.MVC\UI.MVC\Views\Book\Index.cshtml"
               Write(book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\renau\source\GitHub\DotNetCleanArchitecture\CleanArchitectureDemo\CleanArchitectureDemo.UI.MVC\UI.MVC\Views\Book\Index.cshtml"
               Write(book.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\renau\source\GitHub\DotNetCleanArchitecture\CleanArchitectureDemo\CleanArchitectureDemo.UI.MVC\UI.MVC\Views\Book\Index.cshtml"
               Write(book.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 19 "C:\Users\renau\source\GitHub\DotNetCleanArchitecture\CleanArchitectureDemo\CleanArchitectureDemo.UI.MVC\UI.MVC\Views\Book\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CleanArchitectureDemo.Application.ViewModels.BookViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
