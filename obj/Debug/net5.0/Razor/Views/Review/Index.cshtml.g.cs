#pragma checksum "C:\Users\ibrah\source\repos\reviewProject\reviewProject\Views\Review\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "555a383ee4ea11edd74d07d1b7b2873a8035f099"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Review_Index), @"mvc.1.0.view", @"/Views/Review/Index.cshtml")]
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
#line 1 "C:\Users\ibrah\source\repos\reviewProject\reviewProject\Views\_ViewImports.cshtml"
using reviewProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ibrah\source\repos\reviewProject\reviewProject\Views\_ViewImports.cshtml"
using reviewProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"555a383ee4ea11edd74d07d1b7b2873a8035f099", @"/Views/Review/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9d01987f2f27cffb3c8c12119508bd26fb9e88d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Review_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<reviewProject.ViewModels.QuestionReviewViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ibrah\source\repos\reviewProject\reviewProject\Views\Review\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    td#rangeContainer {\r\n        display: flex;\r\n        justify-content: space-evenly;\r\n    }\r\n</style>\r\n\r\n<h1>التقييم</h1>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 21 "C:\Users\ibrah\source\repos\reviewProject\reviewProject\Views\Review\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>");
#nullable restore
#line 23 "C:\Users\ibrah\source\repos\reviewProject\reviewProject\Views\Review\Index.cshtml"
    Write(item.Questions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 24 "C:\Users\ibrah\source\repos\reviewProject\reviewProject\Views\Review\Index.cshtml"
    for (var i = 0; i < 5; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"radio\" class=\"allRadioBtns\"");
            BeginWriteAttribute("name", " name=\"", 409, "\"", 444, 2);
            WriteAttributeValue("", 416, "radioOfQuesID-", 416, 14, true);
#nullable restore
#line 26 "C:\Users\ibrah\source\repos\reviewProject\reviewProject\Views\Review\Index.cshtml"
WriteAttributeValue("", 430, item.QuesId, 430, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 445, "\"", 459, 1);
#nullable restore
#line 26 "C:\Users\ibrah\source\repos\reviewProject\reviewProject\Views\Review\Index.cshtml"
WriteAttributeValue("", 453, i+1, 453, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <label>");
#nullable restore
#line 27 "C:\Users\ibrah\source\repos\reviewProject\reviewProject\Views\Review\Index.cshtml"
           Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 28 "C:\Users\ibrah\source\repos\reviewProject\reviewProject\Views\Review\Index.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br>
<button id=""btnSubmit"" class=""btn btn-primary"">تـــم</button>


<script>
    let result = new Array();
    

    $(document).ready(function () {
        $(""#btnSubmit"").click(function () {
            $("".allRadioBtns"").each(function () {
                if ($(this).prop(""checked"")) {
                    let item = {};
                    console.log(""item.QuesId:["", ($(this).attr('name')).split(""-"")[1], ""] \nvalue:["", $(this).val(), ""]"");
                    item.quesId = ($(this).attr('name')).split(""-"")[1];
                    item.range = $(this).val(); 
                    result.push(item);
                    
                }
                

            })
            console.log(JSON.stringify(result));
            $.ajax({
                contentType: ""application/JSON; charset=utf-8"",
                dataType: 'json',
                type: 'POST',
                url: '/Review/Index',
                data: JSON.stringify(result),
                success: functio");
            WriteLiteral("n () { console.log(\"Worked\") },\r\n                error: function () { console.log(\"failed\") }\r\n            })\r\n        })\r\n    })\r\n\r\n\r\n\r\n</script>\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("</tbody>\r\n\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<reviewProject.ViewModels.QuestionReviewViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
