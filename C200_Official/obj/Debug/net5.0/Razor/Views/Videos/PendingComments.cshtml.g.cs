#pragma checksum "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a02acdefa9e966289a7e573a1abd12a8037da00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Videos_PendingComments), @"mvc.1.0.view", @"/Views/Videos/PendingComments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a02acdefa9e966289a7e573a1abd12a8037da00", @"/Views/Videos/PendingComments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b5921a4f3ed607177d9cd2be51ba8e1072264d", @"/Views/_ViewImports.cshtml")]
    public class Views_Videos_PendingComments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<C200_Official.Models.VideoComment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Videos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PendingCommentsDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("View Details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApproveComments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RejectComments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml"
 if (TempData["Message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 103, "\"", 153, 4);
            WriteAttributeValue("", 111, "alert", 111, 5, true);
            WriteAttributeValue(" ", 116, "alert-", 117, 7, true);
#nullable restore
#line 5 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml"
WriteAttributeValue("", 123, TempData["MsgType"], 123, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 143, "col-sm-12", 144, 10, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
#nullable restore
#line 6 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml"
   Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 8 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Pending Video Comments</h1>\r\n\r\n<table class=\"table table-striped table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Category\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml"
           Write(Html.DisplayNameFor(model => model.Video));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Description of Comments\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml"
           Write(Html.DisplayNameFor(model => model.Member));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th colspan=\"3\" style=\"text-align:center\">\r\n                Action\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml"
         foreach (var item in Model)
        {
            if (item.Status.Equals("Pending"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 919, "\"", 989, 5);
            WriteAttributeValue("", 929, "window.location", 929, 15, true);
            WriteAttributeValue(" ", 944, "=", 945, 2, true);
            WriteAttributeValue(" ", 946, "\'/Videos/PendingCommentsDetails/", 947, 33, true);
#nullable restore
#line 39 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml"
WriteAttributeValue("", 979, item.Id, 979, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 987, "\';", 987, 2, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor: pointer;\" width=\"100%\">\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml"
           Write(Html.DisplayFor(modelItem => item.Video.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml"
           Write(item.Video.Description.Abbreviate());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml"
           Write(Html.DisplayFor(modelItem => item.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml"
           Write(Html.DisplayFor(modelItem => item.Member.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 50 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml"
                                                                Write(Html.DisplayFor(modelItem => item.Member.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a02acdefa9e966289a7e573a1abd12a8037da0010726", async() => {
                WriteLiteral("<span style=\"float:right;\"><i class=\"fa fa-align-left\"></i></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml"
                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a02acdefa9e966289a7e573a1abd12a8037da0013391", async() => {
                WriteLiteral("<span style=\"float:right;\" title=\"Approve\"><i class=\"fa fa-check\"></i></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a02acdefa9e966289a7e573a1abd12a8037da0015979", async() => {
                WriteLiteral("<span style=\"float:right;\" title=\"Reject\"><i class=\"fa fa-times\"></i></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml"
                                                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 62 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Videos\PendingComments.cshtml"
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<C200_Official.Models.VideoComment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
