#pragma checksum "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "970184ed2b456c4a40638350b95829a0e9e7f92e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970184ed2b456c4a40638350b95829a0e9e7f92e", @"/Views/TestConstructor/AccessControl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7316a8470aab35e9f06cffd6510345aa656d9ce", @"/Views/_ViewImports.cshtml")]
    public class Views_TestConstructor_AccessControl : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("groupSelect-btn accessControl-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SecectTest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SecectAccessGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
  
    int numTest = 0;
    int numGroup = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"accessControl__container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "970184ed2b456c4a40638350b95829a0e9e7f92e5909", async() => {
                WriteLiteral("\r\n        <div class=\"group__menu\">\r\n            <h2>Группы</h2>\r\n            <div>\r\n                <input type=\"text\" list=\"group\" name=\"group\" placeholder=\"Введите или выберите из списка\" />\r\n                <datalist id=\"group\">\r\n");
#nullable restore
#line 13 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                     foreach (var group in ViewBag.GroupList)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "970184ed2b456c4a40638350b95829a0e9e7f92e6739", async() => {
#nullable restore
#line 15 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                           Write(group.GroupNum);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 16 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </datalist>

                <a class=""groupList-btn accessControl-btn"" onclick=""showGroupPanel()"">Экспортировать настройки доступа</a>
                <!--
                <a class=""groupList-btn accessControl-btn"" onclick=""addTest(2)"">Добавить тест</a>
                <a class=""groupList-btn accessControl-btn"" onclick=""addGroup(2)"">Добавить группу</a>
                -->
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "970184ed2b456c4a40638350b95829a0e9e7f92e9679", async() => {
                WriteLiteral("\r\n        <div class=\"test__list\">\r\n            <h2>Доступные тесты</h2>\r\n");
#nullable restore
#line 31 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                 foreach (var key in ViewBag.TestSpecialize)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"test__specoalize\">\r\n                        <h3>");
#nullable restore
#line 34 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                       Write(key.Key);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                        <ul class=\"test__items\" id=\"test__items\">\r\n");
#nullable restore
#line 36 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                             foreach (var value in key.Value)
                            {
                                numTest++;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"test__item\">\r\n                                    <span");
                BeginWriteAttribute("id", " id=\"", 1546, "\"", 1564, 2);
                WriteAttributeValue("", 1551, "test-", 1551, 5, true);
#nullable restore
#line 40 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
WriteAttributeValue("", 1556, numTest, 1556, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 40 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                                                        Write(value.FilePath.Substring(6).Replace("_", " ").Replace(".xml", ""));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                    <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 1699, "\"", 1717, 2);
                WriteAttributeValue("", 1704, "test-", 1704, 5, true);
#nullable restore
#line 41 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
WriteAttributeValue("", 1709, numTest, 1709, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"tests\"");
                BeginWriteAttribute("value", " value=\"", 1731, "\"", 1805, 1);
#nullable restore
#line 41 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
WriteAttributeValue("", 1739, value.FilePath.Substring(6).Replace("_", " ").Replace(".xml", ""), 1739, 66, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                </li>\r\n");
#nullable restore
#line 43 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 46 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "970184ed2b456c4a40638350b95829a0e9e7f92e13538", async() => {
                    WriteLiteral("Сохранить изменения");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "970184ed2b456c4a40638350b95829a0e9e7f92e16034", async() => {
                WriteLiteral("\r\n        <div class=\"group_list__panel\" id=\"group_list__panel\">\r\n            <ul class=\"group__list\" id=\"group__list\">\r\n");
#nullable restore
#line 54 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                 foreach (var group in ViewBag.GroupList)
                {
                    numGroup++;

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li class=\"group__item\">\r\n                        <span");
                BeginWriteAttribute("id", " id=\"", 2447, "\"", 2467, 2);
                WriteAttributeValue("", 2452, "group-", 2452, 6, true);
#nullable restore
#line 58 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
WriteAttributeValue("", 2458, numGroup, 2458, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 58 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                                              Write(group.GroupNum);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 2536, "\"", 2556, 2);
                WriteAttributeValue("", 2541, "group-", 2541, 6, true);
#nullable restore
#line 59 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
WriteAttributeValue("", 2547, numGroup, 2547, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"group\"");
                BeginWriteAttribute("value", " value=\"", 2570, "\"", 2593, 1);
#nullable restore
#line 59 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
WriteAttributeValue("", 2578, group.GroupNum, 2578, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </li>\r\n");
#nullable restore
#line 61 "E:\gensec\Documents\GitHub\networkApp\networkApp\Views\TestConstructor\AccessControl.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </ul>\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "970184ed2b456c4a40638350b95829a0e9e7f92e18768", async() => {
                    WriteLiteral("Выбрать доступ группы");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            let li = document.createElement('li");
            WriteLiteral("\');\r\n            li.innerHTML = str;\r\n            childComp.appendChild(li).setAttribute(\"class\", \"group__item\");\r\n\r\n            event.preventDefault();\r\n        }\r\n    </script>\r\n</div>\r\n");
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
