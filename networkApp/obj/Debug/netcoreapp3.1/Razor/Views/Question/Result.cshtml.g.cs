#pragma checksum "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f566cb6016356a24a97d06e8d5a689447bdc0686"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_Result), @"mvc.1.0.view", @"/Views/Question/Result.cshtml")]
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
#line 1 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.ViewModels.TestConstructor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f566cb6016356a24a97d06e8d5a689447bdc0686", @"/Views/Question/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d6c952e48a44dda6cabce3871e10de9c195598e", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-1 p-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
  
    ViewBag.Title = "Test #1";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Результат - ");
#nullable restore
#line 5 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
           Write(ViewBag.Ball);

#line default
#line hidden
#nullable disable
            WriteLiteral(" баллов</h3>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f566cb6016356a24a97d06e8d5a689447bdc06864816", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 8 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
     foreach (var questions in ViewBag.Questions)
    {
        var repeatFlag = false; 


#line default
#line hidden
#nullable disable
                WriteLiteral("        <p>");
#nullable restore
#line 12 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
      Write(questions.Num);

#line default
#line hidden
#nullable disable
                WriteLiteral(". ");
#nullable restore
#line 12 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
                      Write(questions.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <table class=\"table\">\r\n");
#nullable restore
#line 14 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
             for (Int32 i = 0; i < questions.CountAnswer.Count; i++)
            {
                var flag = false;

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
                 foreach (var key in ViewBag.ResultAnswers)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
                     foreach (var item in key.Value)
                    {
                        if (@questions.Num.ToString() == key.Key && @questions.AnswerList[i].Text == item && @questions.AnswerList[i].ValueAnswer == "true" && flag == false)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td style=\"background-color: rgba(40, 255, 40, 0.4);\">\r\n                                    ");
#nullable restore
#line 26 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
                               Write(questions.AnswerList[i].Num);

#line default
#line hidden
#nullable disable
                WriteLiteral(". <input");
                BeginWriteAttribute("type", " type=\"", 991, "\"", 1027, 1);
#nullable restore
#line 26 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
WriteAttributeValue("", 998, questions.AnswerList[i].Type, 998, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1028, "\"", 1058, 3);
                WriteAttributeValue("", 1035, "answers[", 1035, 8, true);
#nullable restore
#line 26 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
WriteAttributeValue("", 1043, questions.Num, 1043, 14, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1057, "]", 1057, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1059, "\"", 1096, 1);
#nullable restore
#line 26 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
WriteAttributeValue("", 1067, questions.AnswerList[i].Text, 1067, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked=\"checked\" />  ");
#nullable restore
#line 26 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
                                                                                                                                                                                                    Write(questions.AnswerList[i].Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 29 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
                            flag = true;
                        }
                        else if (@questions.Num.ToString() == key.Key && @questions.AnswerList[i].Text == item && @questions.AnswerList[i].ValueAnswer == "false")
                        {
                            flag = true;

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td style=\"background-color: rgba(255, 20, 20, 0.3);\">\r\n                                    ");
#nullable restore
#line 36 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
                               Write(questions.AnswerList[i].Num);

#line default
#line hidden
#nullable disable
                WriteLiteral(". <input");
                BeginWriteAttribute("type", " type=\"", 1721, "\"", 1757, 1);
#nullable restore
#line 36 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
WriteAttributeValue("", 1728, questions.AnswerList[i].Type, 1728, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1758, "\"", 1788, 3);
                WriteAttributeValue("", 1765, "answers[", 1765, 8, true);
#nullable restore
#line 36 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
WriteAttributeValue("", 1773, questions.Num, 1773, 14, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1787, "]", 1787, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1789, "\"", 1826, 1);
#nullable restore
#line 36 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
WriteAttributeValue("", 1797, questions.AnswerList[i].Text, 1797, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked=\"checked\" />  ");
#nullable restore
#line 36 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
                                                                                                                                                                                                    Write(questions.AnswerList[i].Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 39 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
                 
                if (flag == false)
                {
                    if (@questions.AnswerList[i].ValueAnswer == "true")
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td style=\"background-color: rgba(40, 255, 40, 0.4);\">\r\n                                ");
#nullable restore
#line 48 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
                           Write(questions.AnswerList[i].Num);

#line default
#line hidden
#nullable disable
                WriteLiteral(". <input");
                BeginWriteAttribute("type", " type=\"", 2357, "\"", 2393, 1);
#nullable restore
#line 48 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
WriteAttributeValue("", 2364, questions.AnswerList[i].Type, 2364, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2394, "\"", 2424, 3);
                WriteAttributeValue("", 2401, "answers[", 2401, 8, true);
#nullable restore
#line 48 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
WriteAttributeValue("", 2409, questions.Num, 2409, 14, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2423, "]", 2423, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2425, "\"", 2462, 1);
#nullable restore
#line 48 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
WriteAttributeValue("", 2433, questions.AnswerList[i].Text, 2433, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />  ");
#nullable restore
#line 48 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
                                                                                                                                                                              Write(questions.AnswerList[i].Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 51 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 56 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
                           Write(questions.AnswerList[i].Num);

#line default
#line hidden
#nullable disable
                WriteLiteral(". <input");
                BeginWriteAttribute("type", " type=\"", 2769, "\"", 2805, 1);
#nullable restore
#line 56 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
WriteAttributeValue("", 2776, questions.AnswerList[i].Type, 2776, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2806, "\"", 2836, 3);
                WriteAttributeValue("", 2813, "answers[", 2813, 8, true);
#nullable restore
#line 56 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
WriteAttributeValue("", 2821, questions.Num, 2821, 14, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2835, "]", 2835, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2837, "\"", 2874, 1);
#nullable restore
#line 56 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
WriteAttributeValue("", 2845, questions.AnswerList[i].Text, 2845, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />  ");
#nullable restore
#line 56 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
                                                                                                                                                                              Write(questions.AnswerList[i].Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 59 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
                    }

                }

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n");
#nullable restore
#line 65 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\Question\Result.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n\r\n");
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
