#pragma checksum "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0cb09c7c644e637ffe07676508eb5b30b1d3a0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Videos_IndexVideoAdmin), @"mvc.1.0.view", @"/Views/Videos/IndexVideoAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0cb09c7c644e637ffe07676508eb5b30b1d3a0a", @"/Views/Videos/IndexVideoAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b5921a4f3ed607177d9cd2be51ba8e1072264d", @"/Views/_ViewImports.cshtml")]
    public class Views_Videos_IndexVideoAdmin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<C200_Official.Models.Video>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/font-awesome/css/fontawesome.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/font-awesome/css/brands.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/font-awesome/css/solid.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Videos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminApproveVideos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return ConfirmApproval()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AdminDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApprovalOfVideos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexMember", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0cb09c7c644e637ffe07676508eb5b30b1d3a0a8686", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0cb09c7c644e637ffe07676508eb5b30b1d3a0a8948", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0cb09c7c644e637ffe07676508eb5b30b1d3a0a10126", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0cb09c7c644e637ffe07676508eb5b30b1d3a0a11226", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0cb09c7c644e637ffe07676508eb5b30b1d3a0a12326", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0cb09c7c644e637ffe07676508eb5b30b1d3a0a13505", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0cb09c7c644e637ffe07676508eb5b30b1d3a0a14684", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>
        function ConfirmArchive() {
            if (confirm(""Are you sure you want to archive?"") == false) {
                event.preventDefault();
                event.stopPropagation();
                return false;
            }
        }

        function ConfirmUnarchive() {
            if (confirm(""Are you sure you want to unarchive?"") == false) {
                event.preventDefault();
                event.stopPropagation();
                return false;
            }
        }

        function ConfirmDelete() {
            if (confirm(""Are you sure you want to delete?"") == false) {
                event.preventDefault();
                event.stopPropagation();
                return false;
            }
        }
    </script>

");
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
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 42 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n<div>\r\n\r\n    <hr />\r\n    <dl class=\"row\">\r\n");
#nullable restore
#line 48 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
         if (TempData["Message"] != null)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 1538, "\"", 1588, 4);
            WriteAttributeValue("", 1546, "alert", 1546, 5, true);
            WriteAttributeValue(" ", 1551, "alert-", 1552, 7, true);
#nullable restore
#line 51 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
WriteAttributeValue("", 1558, TempData["MsgType"], 1558, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1578, "col-sm-12", 1579, 10, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 52 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
           Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 54 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
                      
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 59 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
              

                var videoURL = @Model.Link;
                var words = videoURL.ToString().Split("www.youtube.com/watch?v=");
                var subwords = words[1].ToString().Split("&");
                var updatedVideoURL = words[0] + "www.youtube.com" + "/embed/" + subwords[0];

            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <iframe width=\"560\"\r\n                    height=\"315\"");
            BeginWriteAttribute("src", "\r\n                    src=\"", 2155, "\"", 2198, 1);
#nullable restore
#line 71 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
WriteAttributeValue("", 2182, updatedVideoURL, 2182, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                    frameborder=\"0\"\r\n                    allowfullscreen></iframe>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n\r\n");
#nullable restore
#line 86 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
             if (Model.Status.Equals("ArchivedByUser"))
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("Archived");
#nullable restore
#line 88 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
                                     
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
           Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
                                                       
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
       Write(Html.DisplayNameFor(model => model.SubmittedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
       Write(Html.DisplayFor(model => model.SubmittedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            Published Date\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
       Write(Html.DisplayFor(model => model.DatePublished));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
       Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
       Write(Html.DisplayNameFor(model => model.Member));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
            WriteLiteral("            ");
#nullable restore
#line 120 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
       Write(Model.Member.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 120 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
                               Write(Model.Member.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n        <!--USER ENTER COMMENTS-->\r\n");
#nullable restore
#line 125 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
         if (User.Identity.IsAuthenticated)
        {

            if (User.IsInRole("Admin") && Model.Status.Equals("Pending"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0cb09c7c644e637ffe07676508eb5b30b1d3a0a26747", async() => {
                WriteLiteral(@"

                    <div class=""form-group"">
                        <div class=""col-sm-6"">
                            <input type=""submit"" value=""Approve Video"" class=""btn btn-primary"" />
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 130 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
                                                                                WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0cb09c7c644e637ffe07676508eb5b30b1d3a0a29885", async() => {
                WriteLiteral(@"

                    <div class=""form-group"">
                        <div class=""col-sm-6"">
                            <input type=""submit"" value=""Delete Video"" class=""btn btn-danger"" onclick=""return ConfirmDelete()"" />
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 139 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
                                                                         WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 147 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        <!--SHOW COMMENTS PART-->\r\n");
            WriteLiteral("            <dt class=\"col-sm-12\">Comments</dt>\r\n            <hr />\r\n");
#nullable restore
#line 157 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
            foreach (VideoComment item in Model.VideoComments)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 162 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
               Write(item.Comments);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                    by ");
#nullable restore
#line 163 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
                  Write(item.Member.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    on ");
#nullable restore
#line 165 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
                  Write(item.CommentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <hr />\r\n                </dd>\r\n");
#nullable restore
#line 168 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"

            }

        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n\r\n");
#nullable restore
#line 178 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
     if (User.IsInRole("Admin") && Model.Status.Equals("Pending"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0cb09c7c644e637ffe07676508eb5b30b1d3a0a35454", async() => {
                WriteLiteral("Back to list of pending video posts");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 181 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0cb09c7c644e637ffe07676508eb5b30b1d3a0a36929", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 185 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\IndexVideoAdmin.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<C200_Official.Models.Video> Html { get; private set; }
    }
}
#pragma warning restore 1591
