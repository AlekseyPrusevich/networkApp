#pragma checksum "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b043e6485a5a072c2be3bc8489534cbe7e70e787"
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
#line 1 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.ViewModels.TestConstructor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.ViewModels.TestResult;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b043e6485a5a072c2be3bc8489534cbe7e70e787", @"/Views/TestResult/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7316a8470aab35e9f06cffd6510345aa656d9ce", @"/Views/_ViewImports.cshtml")]
    public class Views_TestResult_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TestResultModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Volvo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Saab", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Mercedes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Audi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "#1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "#2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
  
    ViewData["Title"] = "Результаты тестирования";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
 if (Model.Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""filter-result"" style=""display: flex"">
        <div class=""form-group filter-result_item"">
            <label>Выберете автомобиль</label>
            <input type=""text"" list=""cars"" />
            <datalist id=""cars"" name=""carChoose"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b043e6485a5a072c2be3bc8489534cbe7e70e7876074", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b043e6485a5a072c2be3bc8489534cbe7e70e7877208", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b043e6485a5a072c2be3bc8489534cbe7e70e7878342", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b043e6485a5a072c2be3bc8489534cbe7e70e7879476", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </datalist>\r\n        </div>\r\n        <div class=\"form-group filter-result_item\">\r\n            <label>Выберете Фамилию Имя</label>\r\n            <select name=\"nameChoose\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b043e6485a5a072c2be3bc8489534cbe7e70e78710807", async() => {
                WriteLiteral("#1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b043e6485a5a072c2be3bc8489534cbe7e70e78711979", async() => {
                WriteLiteral("#2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </select>\r\n        </div>\r\n        <div class=\"form-group filter-result_item\">\r\n            <label>Выберете группу</label>\r\n            <select name=\"groupChoose\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b043e6485a5a072c2be3bc8489534cbe7e70e78713342", async() => {
                WriteLiteral("#1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b043e6485a5a072c2be3bc8489534cbe7e70e78714514", async() => {
                WriteLiteral("#2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </select>\r\n        </div>\r\n        <div class=\"form-group filter-result_item\">\r\n            <label>Выберете тест</label>\r\n            <select name=\"testChoose\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b043e6485a5a072c2be3bc8489534cbe7e70e78715874", async() => {
                WriteLiteral("#1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b043e6485a5a072c2be3bc8489534cbe7e70e78717046", async() => {
                WriteLiteral("#2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </select>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral(@"    <table class=""table"">
        <tr>
            <td class=""header-table"">Фамилия Имя</td>
            <td class=""header-table"">Группа</td>
            <td class=""header-table"">Название теста</td>
            <td class=""header-table"">Кол-во вопросов</td>
            <td class=""header-table"">% правильных ответов</td>
            <td class=""header-table"">Дата выполнения теста</td>
        </tr>
        <tr>
            <td>");
#nullable restore
#line 52 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
           Write(Model[0].FNpLN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 53 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
           Write(Model[0].Group);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n        </tr>\r\n        <tr>\r\n");
#nullable restore
#line 60 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
             foreach (var detail in Model[0].Details)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"border-bottom: none;\"></td>\r\n                <td style=\"border-bottom: none;\"></td>\r\n                <td>");
#nullable restore
#line 64 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
               Write(detail.TestName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"table__cells_center\">");
#nullable restore
#line 65 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                                           Write(detail.CountAllQuestions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"table__cells_center\">");
#nullable restore
#line 66 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                                           Write(detail.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                <td>");
#nullable restore
#line 67 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
               Write(detail.TestDate.ToString("hh:mm:ss dd:mm:yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";</td>\r\n");
#nullable restore
#line 68 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n\r\n");
#nullable restore
#line 71 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
         for (int i = 1; i < Model.Count; i++)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
             if (Model[i].FNpLN == Model[i - 1].FNpLN && Model[i].Group == Model[i - 1].Group)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 77 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                     foreach (var detail in Model[i].Details)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"border-bottom: none;\"></td>\r\n                        <td style=\"border-bottom: none;\"></td>\r\n                        <td>");
#nullable restore
#line 81 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                       Write(detail.TestName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table__cells_center\">");
#nullable restore
#line 82 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                                                   Write(detail.CountAllQuestions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table__cells_center\">");
#nullable restore
#line 83 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                                                   Write(detail.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                        <td>");
#nullable restore
#line 84 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                       Write(detail.TestDate.ToString("hh:mm:ss dd:mm:yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";</td>\r\n");
#nullable restore
#line 85 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 88 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 92 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                   Write(Model[i].FNpLN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 93 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                   Write(Model[i].Group);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td></td>\r\n                    <td></td>\r\n                    <td></td>\r\n                    <td></td>\r\n                </tr>\r\n");
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 101 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                     foreach (var detail in Model[i].Details)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td style=\"border-bottom: none;\"></td>\r\n                        <td style=\"border-bottom: none;\"></td>\r\n                        <td>");
#nullable restore
#line 105 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                       Write(detail.TestName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table__cells_center\">");
#nullable restore
#line 106 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                                                   Write(detail.CountAllQuestions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"table__cells_center\">");
#nullable restore
#line 107 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                                                   Write(detail.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n                        <td>");
#nullable restore
#line 108 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                       Write(detail.TestDate.ToString("hh:mm:ss dd:mm:yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";</td>\r\n");
#nullable restore
#line 109 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 111 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 114 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Записи отсутствуют</h1>\r\n");
#nullable restore
#line 118 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestResult\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
