#pragma checksum "D:\networkApp\networkApp\Views\TestConstructor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f31ba663c23e218cd681f7a5956ff9757e4bb624"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestConstructor_Index), @"mvc.1.0.view", @"/Views/TestConstructor/Index.cshtml")]
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
#line 1 "D:\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\networkApp\networkApp\Views\_ViewImports.cshtml"
using networkApp.ViewModels.TestConstructor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f31ba663c23e218cd681f7a5956ff9757e4bb624", @"/Views/TestConstructor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d6c952e48a44dda6cabce3871e10de9c195598e", @"/Views/_ViewImports.cshtml")]
    public class Views_TestConstructor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetTest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\networkApp\networkApp\Views\TestConstructor\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f31ba663c23e218cd681f7a5956ff9757e4bb6244171", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label>Введите название теста</label>
            <input type=""text"" name=""testName""/>
        </div>
        <div>
            <div id=""baseContainer"">
                <button onclick=""createQuestion()"">Добавить вопрос</button>               

            </div>
        </div>

        <script>
            
            let numQuestion = 0;
            let numAnswer = 0;
            function createQuestion() {
                
                numQuestion++;
                let str = '\<div id=""q' + numQuestion + '""><input type=""text"" name=""nameQuestion"" placeholder=""Введите вопрос""/>\
                    <select name=""type"" id=""type' + numQuestion +'"">\
                        <option value=""radio"">Один из списка</option>\
                        <option value=""checkbox"">Несколько из списка</option>\
                    </select>\
                    <button onclick=""createAnswer('+ numQuestion + ')"">Добавить ответ</button>\
              ");
                WriteLiteral(@"      <button onclick=""deleteQuestion('+ numQuestion + ')"">Удалить</button>\
                    </div>';
                let childComp = document.getElementById(""baseContainer"");
                let div = document.createElement('div');
                div.innerHTML = str;
                childComp.appendChild(div);
                event.preventDefault();                
            }
            
            function createAnswer(num) {
                numAnswer++;
                console.log()
                let str = '\<div id=""ans' + numAnswer + '"" style=""display:inline;""><input id=""ka' + numAnswer + '""  value=""' + numAnswer + '"" type=""' + getType(num) + '"" name=""isTrue[' + num + ']""/>\
                    <input id=""ia' + numAnswer + '"" type=""text"" placeholder=""Введите ответ"" name=""answer[' + num + ']"" />\
                    <button onclick=""deleteAnswer('+ numAnswer +')"">Удалить</button></div>';

                let childComp = document.getElementById(""q"" + num);
                let d");
                WriteLiteral(@"iv = document.createElement('div');
                div.innerHTML = str;
                childComp.appendChild(div);
                let typeElement = document.getElementById(""type"" + num);
                typeElement.style.display=""none"";
                event.preventDefault();
            }

            function getType(num) {
                let e = document.getElementById(""type"" + num);
                return e.options[e.selectedIndex].value;
            }
            
            function deleteAnswer(num) {
                document.getElementById(""ans"" + num).remove();                
                event.preventDefault();                
            }

            function deleteQuestion(num) {
                document.getElementById(""q"" + num).remove();
                event.preventDefault();
            }

            function apply()
            {
                for (var i = 1; i <= numAnswer; i++) {                  
                    document.getElementById(""ka"" + i).");
                WriteLiteral(@"value = document.getElementById(""ia"" + i).value;                    
                }
                document.getElementById(""sbtn"").style.visibility = ""visible"";
                event.preventDefault();
            }
        </script>
        <div>
            <button onclick=""apply()"">Сохранить</button>
            <input id=""sbtn"" style=""visibility:hidden"" type=""submit"" />
        </div>
       
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
