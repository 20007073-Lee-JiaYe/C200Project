#pragma checksum "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19026d9dbf4388259160da4ac77050e828808540"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Details), @"mvc.1.0.view", @"/Views/Questions/Details.cshtml")]
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
#nullable restore
#line 3 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
using Microsoft.AspNetCore.Authentication.Cookies;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19026d9dbf4388259160da4ac77050e828808540", @"/Views/Questions/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27b5921a4f3ed607177d9cd2be51ba8e1072264d", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<C200_Official.Models.Question>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/font-awesome/css/fontawesome.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/font-awesome/css/brands.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/font-awesome/css/solid.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddRating", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Questions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddAnswer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 7 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19026d9dbf4388259160da4ac77050e8288085408949", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "19026d9dbf4388259160da4ac77050e8288085409211", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19026d9dbf4388259160da4ac77050e82880854010389", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19026d9dbf4388259160da4ac77050e82880854011489", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "19026d9dbf4388259160da4ac77050e82880854012589", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "19026d9dbf4388259160da4ac77050e82880854013768", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "19026d9dbf4388259160da4ac77050e82880854014947", async() => {
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

        function ConfirmDelete() {
            if (confirm(""Are you sure you want to delete?"") == false) {
                event.preventDefault();
                event.stopPropagation();
                return false;
            }
        }
        function ConfirmUnarchive() {
            if (confirm(""Are you sure you want to show on profile?"") == false) {
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
            WriteLiteral("\r\n<div>\r\n    <h4>Details of Question</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n");
#nullable restore
#line 48 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
         if (TempData["Message"] != null)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 1661, "\"", 1711, 4);
            WriteAttributeValue("", 1669, "alert", 1669, 5, true);
            WriteAttributeValue(" ", 1674, "alert-", 1675, 7, true);
#nullable restore
#line 51 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
WriteAttributeValue("", 1681, TempData["MsgType"], 1681, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1701, "col-sm-12", 1702, 10, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 52 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
           Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 54 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
                      
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n\r\n            ");
#nullable restore
#line 62 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 66 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 69 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 72 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Member));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 75 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
       Write(Html.DisplayFor(model => model.Member.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 75 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
                                                          Write(Html.DisplayFor(model => model.Member.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 79 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 82 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n");
#nullable restore
#line 85 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
         if (User.Identity.IsAuthenticated)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
             if ((int)ViewData["rm"] == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dd class=\"col-sm-10\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19026d9dbf4388259160da4ac77050e82880854023399", async() => {
                WriteLiteral(@"

                        <div class=""form-group row"">
                            <label class=""control-label col-sm-3"">Your Rating : </label>
                            <div class=""col-sm-6"">
                                <div class=""form-check form-check-inline"">
                                    <input type=""radio"" class=""form-check-input""
                                           id=""1"" name=""rating"" value=""1"" />
                                    <label class=""form-check-label"" for=""1"">1</label>
                                </div>
                                <div class=""form-check form-check-inline"">
                                    <input type=""radio"" class=""form-check-input""
                                           id=""2"" name=""rating"" value=""2"" />
                                    <label class=""form-check-label"" for=""2"">2</label>
                                </div>
                                <div class=""form-check form-check-inline"">
                      ");
                WriteLiteral(@"              <input type=""radio"" class=""form-check-input""
                                           id=""3"" name=""rating"" value=""3"" />
                                    <label class=""form-check-label"" for=""3"">3</label>
                                </div>
                                <div class=""form-check form-check-inline"">
                                    <input type=""radio"" class=""form-check-input""
                                           id=""4"" name=""rating"" value=""4"" />
                                    <label class=""form-check-label"" for=""4"">4</label>
                                </div>
                                <div class=""form-check form-check-inline"">
                                    <input type=""radio"" class=""form-check-input""
                                           id=""5"" name=""rating"" value=""5"" />
                                    <label class=""form-check-label"" for=""5"">5</label>
                                </div>
                            </div");
                WriteLiteral(@">
                        </div>
                        <div class=""form-group"">
                            <input type=""submit"" value=""Rate Question"" class=""btn btn-primary  offset-sm-10 col-sm-2"" />
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-QuestionID", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
                                                                                      WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["QuestionID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-QuestionID", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["QuestionID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </dd>\r\n");
#nullable restore
#line 128 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
            }
            else
            {
                int a = (int)ViewData["rm"];
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-2\">\r\n                    Your Rating:\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 137 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
               Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n");
#nullable restore
#line 139 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd class=\"col-sm-10\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19026d9dbf4388259160da4ac77050e82880854029813", async() => {
                WriteLiteral(@"

                    <div class=""form-group"">
                        <pre>


                                 </pre>
                        <label for=""description"" class=""control-label"">Post Answer Below:</label>
                        <input name=""description"" class=""form-control"" />
                    </div>

                    <div class=""form-group"">
                        <input type=""submit"" value=""Insert Answer"" class=""btn btn-primary offset-10 col-sm-2"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-QuestionID", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 142 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
                                                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["QuestionID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-QuestionID", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["QuestionID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </dd>\r\n");
#nullable restore
#line 160 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
                     
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <!--ANSWER PART-->\r\n");
            WriteLiteral("            <dt class=\"col-sm-12\">Answers</dt>\r\n            <hr />\r\n");
#nullable restore
#line 167 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"

            foreach (Answer item in Model.Answers)

            {
                if (item.Status.Equals("Published")) // published article
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 174 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                        by ");
#nullable restore
#line 175 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
                      Write(item.Member.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        on ");
#nullable restore
#line 176 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
                      Write(item.AnsweredDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <hr />\r\n                    </dd>\r\n");
#nullable restore
#line 179 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
                }
                else
                {
                    //use a var to hold the id first
                    int theRealUserID = 0;

                    //put the real user id inside
                    var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

                    if (userId != null)
                    {
                        theRealUserID = Int32.Parse(userId);
                        if (item.MemberId == theRealUserID) //if this person is the writer
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <dd class=\"col-sm-10\">\r\n                                ");
#nullable restore
#line 194 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                by ");
#nullable restore
#line 195 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
                              Write(item.Member.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                on ");
#nullable restore
#line 196 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
                              Write(item.AnsweredDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"alert-danger col-sm-3 text-center\"> ");
#nullable restore
#line 197 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
                                                                           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <hr />\r\n                            </dd>\r\n");
#nullable restore
#line 200 "C:\Users\20007073\Desktop\RP\Y2 Sem 2\C200 Special Project\Presentation\V5_C200_Official (2)\C200_Official\Views\Questions\Details.cshtml"
                        }
                    }

                }
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19026d9dbf4388259160da4ac77050e82880854037922", async() => {
                WriteLiteral("Back to Questions List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<C200_Official.Models.Question> Html { get; private set; }
    }
}
#pragma warning restore 1591