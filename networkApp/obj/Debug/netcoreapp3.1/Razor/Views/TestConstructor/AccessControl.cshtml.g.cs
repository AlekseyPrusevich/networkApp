#pragma checksum "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87f8adc286dcd6b0594ad3172b236ee7705e05c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestConstructor_AccessControl), @"mvc.1.0.view", @"/Views/TestConstructor/AccessControl.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87f8adc286dcd6b0594ad3172b236ee7705e05c5", @"/Views/TestConstructor/AccessControl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7316a8470aab35e9f06cffd6510345aa656d9ce", @"/Views/_ViewImports.cshtml")]
    public class Views_TestConstructor_AccessControl : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("groupList-btn accessControl-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetTestAccessByGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("get"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("groupSelect-btn accessControl-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveAcsessTests", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SecectAccessGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
  
    int numTest = 0;
    int numGroup = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"accessControl__container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87f8adc286dcd6b0594ad3172b236ee7705e05c57324", async() => {
                WriteLiteral("\r\n        <div class=\"group__menu\">\r\n            <h2>Группы</h2>\r\n            <div>\r\n                <select type=\"text\" name=\"group\" placeholder=\"Введите или выберите из списка\"");
                BeginWriteAttribute("value", " value=\"", 295, "\"", 326, 1);
#nullable restore
#line 11 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
WriteAttributeValue("", 303, ViewBag.ChooseGroupNum, 303, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87f8adc286dcd6b0594ad3172b236ee7705e05c58208", async() => {
                    WriteLiteral("Выберете группу");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                     foreach (var group in ViewBag.GroupList)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87f8adc286dcd6b0594ad3172b236ee7705e05c510419", async() => {
#nullable restore
#line 15 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                                                                        Write(group.GroupNum);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
AddHtmlAttributeValue("", 533, group.GroupNum, 533, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                                                WriteLiteral(group.GroupNum);

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
#line 16 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                         if (group.GroupNum == ViewBag.ChooseGroupNum)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <script>\r\n                                let group_");
#nullable restore
#line 19 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                                     Write(group.GroupNum);

#line default
#line hidden
#nullable disable
                WriteLiteral(" = document.getElementById(\'");
#nullable restore
#line 19 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                                                                                Write(group.GroupNum);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').remove();\r\n                            </script>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87f8adc286dcd6b0594ad3172b236ee7705e05c514022", async() => {
#nullable restore
#line 21 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                                                                                           Write(group.GroupNum);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 930, "group_", 930, 6, true);
#nullable restore
#line 21 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
AddHtmlAttributeValue("", 936, group.GroupNum, 936, 15, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                                                          WriteLiteral(group.GroupNum);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n                \r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87f8adc286dcd6b0594ad3172b236ee7705e05c517473", async() => {
                    WriteLiteral("Выбрать");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
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
                WriteLiteral("\r\n                <a class=\"groupList-btn accessControl-btn\" onclick=\"showGroupPanel()\">Экспортировать настройки доступа</a>\r\n            </div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87f8adc286dcd6b0594ad3172b236ee7705e05c520040", async() => {
                WriteLiteral("\r\n        <div class=\"test__list\">\r\n            <h2>Доступные тесты</h2>\r\n            <input type=\"text\" id=\"chooseGroup\" name=\"chooseGroup\"");
                BeginWriteAttribute("value", " value=\"", 1562, "\"", 1593, 1);
#nullable restore
#line 35 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
WriteAttributeValue("", 1570, ViewBag.ChooseGroupNum, 1570, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 36 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                 foreach (var key in ViewBag.TestSpecialize)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"test__specoalize\">\r\n                        <h3>");
#nullable restore
#line 39 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                       Write(key.Key);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                        <ul class=\"test__items\" id=\"test__items\">\r\n");
#nullable restore
#line 41 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                             foreach (var value in key.Value)
                            {
                                numTest++;

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"test__item\">\r\n                                <label");
                BeginWriteAttribute("for", " for=\"", 2071, "\"", 2090, 2);
                WriteAttributeValue("", 2077, "test-", 2077, 5, true);
#nullable restore
#line 45 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
WriteAttributeValue("", 2082, numTest, 2082, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 45 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                                                      Write(value.FilePath.Substring(6).Replace("_", " ").Replace(".xml", ""));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 2222, "\"", 2240, 2);
                WriteAttributeValue("", 2227, "test-", 2227, 5, true);
#nullable restore
#line 46 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
WriteAttributeValue("", 2232, numTest, 2232, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"testName\"");
                BeginWriteAttribute("value", " value=\"", 2257, "\"", 2331, 1);
#nullable restore
#line 46 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
WriteAttributeValue("", 2265, value.FilePath.Substring(6).Replace("_", " ").Replace(".xml", ""), 2265, 66, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 47 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                                 foreach (var name in ViewBag.TestName)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                                     if (name == value.FilePath.Substring(6).Replace("_", " ").Replace(".xml", ""))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <script>\r\n                                            let input_");
#nullable restore
#line 52 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                                                 Write(numTest);

#line default
#line hidden
#nullable disable
                WriteLiteral(" = document.getElementById(\'test-");
#nullable restore
#line 52 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                                                                                          Write(numTest);

#line default
#line hidden
#nullable disable
                WriteLiteral("\').remove();\r\n                                        </script>\r\n                                        <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 2881, "\"", 2899, 2);
                WriteAttributeValue("", 2886, "test-", 2886, 5, true);
#nullable restore
#line 54 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
WriteAttributeValue("", 2891, numTest, 2891, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"testName\"");
                BeginWriteAttribute("value", " value=\"", 2916, "\"", 2990, 1);
#nullable restore
#line 54 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
WriteAttributeValue("", 2924, value.FilePath.Substring(6).Replace("_", " ").Replace(".xml", ""), 2924, 66, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked/>\r\n");
#nullable restore
#line 55 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </li>\r\n");
#nullable restore
#line 58 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 61 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87f8adc286dcd6b0594ad3172b236ee7705e05c527603", async() => {
                    WriteLiteral("Сохранить изменения");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87f8adc286dcd6b0594ad3172b236ee7705e05c530099", async() => {
                WriteLiteral("\r\n        <div class=\"group_list__panel\" id=\"group_list__panel\">\r\n            <ul class=\"group__list\" id=\"group__list\">\r\n");
#nullable restore
#line 69 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                 foreach (var group in ViewBag.GroupList)
                {
                    numGroup++;

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li class=\"group__item\">\r\n                        <span");
                BeginWriteAttribute("id", " id=\"", 3714, "\"", 3734, 2);
                WriteAttributeValue("", 3719, "group-", 3719, 6, true);
#nullable restore
#line 73 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
WriteAttributeValue("", 3725, numGroup, 3725, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 73 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                                              Write(group.GroupNum);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 3803, "\"", 3823, 2);
                WriteAttributeValue("", 3808, "group-", 3808, 6, true);
#nullable restore
#line 74 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
WriteAttributeValue("", 3814, numGroup, 3814, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"group\"");
                BeginWriteAttribute("value", " value=\"", 3837, "\"", 3860, 1);
#nullable restore
#line 74 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
WriteAttributeValue("", 3845, group.GroupNum, 3845, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </li>\r\n");
#nullable restore
#line 76 "C:\Users\GENSEC-Notebook\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </ul>\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87f8adc286dcd6b0594ad3172b236ee7705e05c532923", async() => {
                    WriteLiteral("Выбрать доступ группы");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

    <script>

        function showGroupPanel() {
            document.getElementById(""group_list__panel"").setAttribute(""style"", ""display: block"");
        }

        function addTest(num) {
            let str = '\<span id=""test-'+ num +'"">Тест № '+ num +'</span>\
                        <input type=""checkbox"" id=""test-'+num+'"" name=""test"" value=""ТЕСТ_'+ num +'""/>';           

            let childComp = document.getElementById(""test__items"");
            let li = document.createElement('li');
            li.innerHTML = str;
            childComp.appendChild(li).setAttribute(""class"", ""test__item"");

            event.preventDefault();
        }

        function addGroup(num) {
            let str = '\<span id=""group-'+ num +'"">Группа_'+ num +'</span>\
                        <input type=""radio"" id=""group-'+ num +'"" name=""group"" value=""Группа_'+ num +'""/>';           

            let childComp = document.getElementById(""group__list"");
            let li = document.createElement('");
            WriteLiteral("li\');\r\n            li.innerHTML = str;\r\n            childComp.appendChild(li).setAttribute(\"class\", \"group__item\");\r\n\r\n            event.preventDefault();\r\n        }\r\n    </script>\r\n</div>\r\n");
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
