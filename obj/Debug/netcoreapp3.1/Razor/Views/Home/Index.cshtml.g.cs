#pragma checksum "C:\Users\ayobami.omosehin\Documents\PowertechApp\WebApplicationOCR\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cd3b0c36a0fc9d94580e4722bc7d843883a506d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\ayobami.omosehin\Documents\PowertechApp\WebApplicationOCR\Views\_ViewImports.cshtml"
using WebApplicationOCR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ayobami.omosehin\Documents\PowertechApp\WebApplicationOCR\Views\_ViewImports.cshtml"
using WebApplicationOCR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cd3b0c36a0fc9d94580e4722bc7d843883a506d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75e6357bae495f15616e103fda07f468d1e65895", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ayobami.omosehin\Documents\PowertechApp\WebApplicationOCR\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    /* Container */
    .container {
        margin: 0 auto;
        border: 0px solid black;
        width: 50%;
        height: 250px;
        border-radius: 3px;
        background-color: ghostwhite;
        text-align: center;
    }
    /* Preview */
    .preview {
        width: 100px;
        height: 100px;
        border: 1px solid black;
        margin: 0 auto;
        background: white;
    }

        .preview img {
            display: none;
        }
    /* Button */
    .button {
        border: 0px;
        background-color: deepskyblue;
        color: white;
        padding: 5px 15px;
        margin-left: 10px;
    }
</style>
<div class=""text-center"">
    <h1 class=""display-4"">Read Ocr Image</h1>
    <div class=""container"">
        <input id=""inputFileToLoad"" type=""file"" onchange=""encodeImageFileAsURL();"" />
        <div id=""imgTest""></div>
    </div>
</div>

<script>
   
</script>");
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
