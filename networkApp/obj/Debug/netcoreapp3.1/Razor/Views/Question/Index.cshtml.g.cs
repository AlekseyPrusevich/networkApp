#pragma checksum "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\Question\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6a2b5b630b220b1fa30ff57364050d6951846ebf328fe123670e51387090ac5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_Index), @"mvc.1.0.view", @"/Views/Question/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.ViewModels.TestConstructor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.ViewModels.TestResult;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6a2b5b630b220b1fa30ff57364050d6951846ebf328fe123670e51387090ac5e", @"/Views/Question/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"14ee5556e88e4c4219a9381f842063057c2337ca4a18fe04b00999d0d8441014", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Question_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("questions__form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Result", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\Question\Index.cshtml"
  
    ViewBag.Title = ViewBag.TestName;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"questions__container\">\r\n    <h2 class=\"questions__title\">");
#nullable restore
#line 6 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\Question\Index.cshtml"
                            Write(ViewBag.TestName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p class=\"questions__description\">Количество вопросов — ");
#nullable restore
#line 7 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\Question\Index.cshtml"
                                                       Write(ViewBag.Questions.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a2b5b630b220b1fa30ff57364050d6951846ebf328fe123670e51387090ac5e5694", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\Question\Index.cshtml"
         foreach (var questions in ViewBag.Questions)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <p class=\"question__title\">");
#nullable restore
#line 13 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\Question\Index.cshtml"
                                  Write(questions.Num);

#line default
#line hidden
#nullable disable
                WriteLiteral(". <span>");
#nullable restore
#line 13 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\Question\Index.cshtml"
                                                        Write(questions.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n            <table class=\"table questions__table\">\r\n");
#nullable restore
#line 15 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\Question\Index.cshtml"
                 for (Int32 i = 0; i < questions.CountAnswer.Count; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <label>");
#nullable restore
#line 19 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\Question\Index.cshtml"
                              Write(questions.AnswerList[i].Num);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>. <input");
                BeginWriteAttribute("type", " type=\"", 740, "\"", 776, 1);
#nullable restore
#line 19 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\Question\Index.cshtml"
WriteAttributeValue("", 747, questions.AnswerList[i].Type, 747, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 777, "\"", 807, 3);
                WriteAttributeValue("", 784, "answers[", 784, 8, true);
#nullable restore
#line 19 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\Question\Index.cshtml"
WriteAttributeValue("", 792, questions.Num, 792, 14, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 806, "]", 806, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 808, "\"", 845, 1);
#nullable restore
#line 19 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\Question\Index.cshtml"
WriteAttributeValue("", 816, questions.AnswerList[i].Text, 816, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />  ");
#nullable restore
#line 19 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\Question\Index.cshtml"
                                                                                                                                                                                         Write(questions.AnswerList[i].Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 22 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\Question\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n");
#nullable restore
#line 24 "C:\Users\GENSEC-PC\Documents\GitHub\networkApp\networkApp\Views\Question\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <button type=\"submit\" class=\"button btn btn-primary\">Ответить на тест</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
