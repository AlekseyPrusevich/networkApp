#pragma checksum "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17bae5c0095ca791c43ad7422c7120031b7d2557"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestResult_Index), @"mvc.1.0.view", @"/Views/TestResult/Index.cshtml")]
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
#nullable restore
#line 4 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.ViewModels.TestResult;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bae5c0095ca791c43ad7422c7120031b7d2557", @"/Views/TestResult/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7316a8470aab35e9f06cffd6510345aa656d9ce", @"/Views/_ViewImports.cshtml")]
    public class Views_TestResult_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TestResultModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button result-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InportExcel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
  
    ViewData["Title"] = "Результаты тестирования";

    HashSet<string> fios = new HashSet<string>();
    HashSet<string> testNames = new HashSet<string>();
    HashSet<int> grps = new HashSet<int>();

    if (ViewBag.EmptyQuery != 0)
    {
        foreach (var item in Model)
        {
            foreach (var detail in item.Details)
            {
                testNames.Add(detail.TestName);
            }
        }

        foreach (var item in Model)
        {
            fios.Add(item.FNpLN);
        }

        foreach (var item in Model)
        {
            grps.Add(item.Group);
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17bae5c0095ca791c43ad7422c7120031b7d25576311", async() => {
                WriteLiteral(@"
    <div class=""filter-result"">
        <div class=""form-group filter-result_item"">
            <label class=""filter__label"">Фамилия Имя</label>
            <input class=""filter__input"" type=""text"" list=""fio"" name=""fi"" placeholder=""Введите или выберите из списка"" />
            <datalist class=""filter__datalist"" id=""fio"" name=""fio"">
");
#nullable restore
#line 37 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                 foreach (var fiUser in fios)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17bae5c0095ca791c43ad7422c7120031b7d25577211", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                       WriteLiteral(fiUser);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 40 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </datalist>
        </div>

        <div class=""form-group filter-result_item"">
            <label class=""filter__label"">Группа</label>
            <input class=""filter__input"" type=""text"" list=""group"" name=""group"" placeholder=""Введите или выберите из списка"" />
            <datalist class=""filter__datalist"" id=""group"" name=""group"">
");
#nullable restore
#line 48 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                 foreach (var group in grps)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17bae5c0095ca791c43ad7422c7120031b7d25579713", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                       WriteLiteral(group);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 51 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </datalist>
        </div>

        <div class=""form-group filter-result_item"">
            <label class=""filter__label"">Тест</label>
            <input class=""filter__input"" type=""text"" list=""testName"" name=""testName"" placeholder=""Введите или выберите из списка"" />
            <datalist class=""filter__datalist"" id=""testName"" name=""testName"">
");
#nullable restore
#line 59 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                 foreach (var testName in testNames)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17bae5c0095ca791c43ad7422c7120031b7d255712232", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                       WriteLiteral(testName);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 62 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </datalist>\r\n        </div>\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17bae5c0095ca791c43ad7422c7120031b7d255714139", async() => {
                    WriteLiteral("\r\n            Выбрать\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17bae5c0095ca791c43ad7422c7120031b7d255715605", async() => {
                    WriteLiteral("\r\n        Excel\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 76 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
 if (ViewBag.EmptyQuery != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table result__table"">
        <tr style=""font-weight: 500"">
            <td class=""header-table"">Фамилия Имя</td>
            <td class=""header-table"">Группа</td>
            <td class=""header-table"">Название теста</td>
            <td class=""header-table"">Кол-во вопросов</td>
            <td class=""header-table"">% правильных ответов</td>
            <td class=""header-table"">Время и дата сдачи теста</td>
        </tr>
        <tr>
            <td>");
#nullable restore
#line 88 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
           Write(Model[0].FNpLN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 89 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
           Write(Model[0].Group);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n        </tr>\r\n        <tr>\r\n");
#nullable restore
#line 96 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
             foreach (var detail in Model[0].Details)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"border-bottom: none;\"></td>\r\n                <td class=\"table__cells_center\" style=\"border-bottom: none;\"></td>\r\n                <td>");
#nullable restore
#line 100 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
               Write(detail.TestName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"table__cells_center\">");
#nullable restore
#line 101 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                                           Write(detail.CountAllQuestions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"table__cells_center\">");
#nullable restore
#line 102 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                                           Write(detail.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                <td class=\"table__cells_center\">");
#nullable restore
#line 103 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                                           Write(detail.TestDate.ToString("HH:mm:ss dd:MM:yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";</td>\r\n");
#nullable restore
#line 104 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n\r\n");
#nullable restore
#line 107 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
         for (int i = 1; i < Model.Count; i++)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
             if (Model[i].FNpLN == Model[i - 1].FNpLN && Model[i].Group == Model[i - 1].Group)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 113 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                     foreach (var detail in Model[i].Details)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"table__cells_center\" style=\"border-bottom: none;\"></td>\r\n                        <td style=\"border-bottom: none;\"></td>\r\n                        <td>");
#nullable restore
#line 117 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                       Write(detail.TestName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table__cells_center\">");
#nullable restore
#line 118 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                                                   Write(detail.CountAllQuestions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table__cells_center\">");
#nullable restore
#line 119 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                                                   Write(detail.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                        <td class=\"table__cells_center\">");
#nullable restore
#line 120 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                                                   Write(detail.TestDate.ToString("HH:mm:ss dd:MM:yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";</td>\r\n");
#nullable restore
#line 121 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 124 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 128 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                   Write(Model[i].FNpLN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 129 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                   Write(Model[i].Group);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td></td>\r\n                    <td></td>\r\n                    <td></td>\r\n                    <td></td>\r\n                </tr>\r\n");
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 137 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                     foreach (var detail in Model[i].Details)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"table__cells_center\" style=\"border-bottom: none;\"></td>\r\n                        <td style=\"border-bottom: none;\"></td>\r\n                        <td>");
#nullable restore
#line 141 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                       Write(detail.TestName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table__cells_center\">");
#nullable restore
#line 142 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                                                   Write(detail.CountAllQuestions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table__cells_center\">");
#nullable restore
#line 143 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                                                   Write(detail.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                        <td class=\"table__cells_center\">");
#nullable restore
#line 144 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                                                   Write(detail.TestDate.ToString("HH:mm:ss dd:MM:yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 145 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 147 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 150 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"error-message\">Нет записей удовлетворяющих запросу</p>\r\n");
#nullable restore
#line 154 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TestResultModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
