#pragma checksum "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c3e78b6b3a74e8878e6d721ea0deee7d7871f0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_Index), @"mvc.1.0.view", @"/Views/Articles/Index.cshtml")]
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
#line 1 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\_ViewImports.cshtml"
using C200_Official;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\_ViewImports.cshtml"
using C200_Official.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c3e78b6b3a74e8878e6d721ea0deee7d7871f0e", @"/Views/Articles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b5921a4f3ed607177d9cd2be51ba8e1072264d", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<C200_Official.Models.Article>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-ViewName", "Articles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PrintArticlesByMember", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PrintArticlesByRating", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Full Articles</h1>\r\n");
#nullable restore
#line 8 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
 if (TempData["Message"] != null)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 211, "\"", 261, 4);
            WriteAttributeValue("", 219, "alert", 219, 5, true);
            WriteAttributeValue(" ", 224, "alert-", 225, 7, true);
#nullable restore
#line 11 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
WriteAttributeValue("", 231, TempData["MsgType"], 231, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 251, "col-sm-12", 252, 10, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
#nullable restore
#line 12 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
   Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
              
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n");
#nullable restore
#line 18 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c3e78b6b3a74e8878e6d721ea0deee7d7871f0e6656", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ViewName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ViewName"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
         if (User.IsInRole("Admin"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a>|</a>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c3e78b6b3a74e8878e6d721ea0deee7d7871f0e8657", async() => {
                WriteLiteral("Print Articles grouped by Member and Category");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <a>|</a>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c3e78b6b3a74e8878e6d721ea0deee7d7871f0e9887", async() => {
                WriteLiteral("Print Articles grouped by Rating");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
         

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</p>\r\n<table id=\"mainTable\" class=\"table table-hover table-striped\" width=\"100%\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.SubmittedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Member));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 65 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
             if (item.Status.Equals("Published"))
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 1856, "\"", 1911, 3);
            WriteAttributeValue("", 1866, "window.location=\'/Articles/Details/", 1866, 35, true);
#nullable restore
#line 70 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
WriteAttributeValue("", 1901, item.Id, 1901, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1909, "\';", 1909, 2, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor: pointer;\">\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 73 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 76 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
                   Write(item.Content.Abbreviate());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 79 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
                          
                            if (item.Picture != "")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 2341, "\"", 2370, 2);
            WriteAttributeValue("", 2347, "/pictures/", 2347, 10, true);
#nullable restore
#line 82 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
WriteAttributeValue("", 2357, item.Picture, 2357, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" />\r\n");
#nullable restore
#line 83 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img src=\"/pictures/NoImage.jpeg\" width=\"100\" />\r\n");
#nullable restore
#line 87 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 92 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
                         if (item.Status.Equals("Pending"))
                        {
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("Pending");
#nullable restore
#line 94 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
                                                
                        }
                        else if (item.Status.Equals("Published"))
                        {
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("Published");
#nullable restore
#line 98 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
                                                  
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 103 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SubmittedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 107 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 110 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Member.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 110 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
                                                                        Write(Html.DisplayFor(modelItem => item.Member.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 114 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Articles\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<C200_Official.Models.Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591