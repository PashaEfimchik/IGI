#pragma checksum "C:\Users\Павел\Desktop\Labs\5_sem\IGI\WEB_953505_EFIMCHIK\WEB_953505_EFIMCHIK\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d4312ae9203cc63b56c295ca6dd90ff66ff53a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Павел\Desktop\Labs\5_sem\IGI\WEB_953505_EFIMCHIK\WEB_953505_EFIMCHIK\Views\_ViewImports.cshtml"
using WEB_953505_EFIMCHIK;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Павел\Desktop\Labs\5_sem\IGI\WEB_953505_EFIMCHIK\WEB_953505_EFIMCHIK\Views\_ViewImports.cshtml"
using WEB_953505_EFIMCHIK.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d4312ae9203cc63b56c295ca6dd90ff66ff53a8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eebeffdb1404c6c1b91687ddd70915ab9170dbe0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Павел\Desktop\Labs\5_sem\IGI\WEB_953505_EFIMCHIK\WEB_953505_EFIMCHIK\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Main page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\Павел\Desktop\Labs\5_sem\IGI\WEB_953505_EFIMCHIK\WEB_953505_EFIMCHIK\Views\Home\Index.cshtml"
Write(ViewData["Text"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h3>Список</h3>\r\n<div class=\"list\">\r\n    <ol type=\"A\">\r\n");
#nullable restore
#line 10 "C:\Users\Павел\Desktop\Labs\5_sem\IGI\WEB_953505_EFIMCHIK\WEB_953505_EFIMCHIK\Views\Home\Index.cshtml"
         for (int i = 1; i < 5; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>Элемент ");
#nullable restore
#line 12 "C:\Users\Павел\Desktop\Labs\5_sem\IGI\WEB_953505_EFIMCHIK\WEB_953505_EFIMCHIK\Views\Home\Index.cshtml"
                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" списка</li>\r\n");
#nullable restore
#line 13 "C:\Users\Павел\Desktop\Labs\5_sem\IGI\WEB_953505_EFIMCHIK\WEB_953505_EFIMCHIK\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ol>\r\n</div>\r\n<div class=\"dropdown-divider\"></div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d4312ae9203cc63b56c295ca6dd90ff66ff53a85832", async() => {
                WriteLiteral("\r\n    \r\n        <div class=\"selectList\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d4312ae9203cc63b56c295ca6dd90ff66ff53a86148", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 21 "C:\Users\Павел\Desktop\Labs\5_sem\IGI\WEB_953505_EFIMCHIK\WEB_953505_EFIMCHIK\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewData["Lst"] as SelectList;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
        <div class=""checkbox_1"">
            <input type=""checkbox"" id=""checkbox_1"" name=""first_checkbox"" value=""desktop"">
            <label for=""checkbox_1""> Desktop</label>
        </div>
        <div class=""checkbox_2"">
            <input type=""checkbox"" id=""checkbox_2"" name=""second_checkbox"" value=""phone"">
            <label for=""checkbox_2""> Phone</label>
        </div>

        <div class=""radio"">
            <input type=""radio"" id=""choice_1"" name=""choice"" value=""low"">
            <label for=""choice_1"">Low</label>
            <input type=""radio"" id=""choice_2"" name=""choice"" value=""medium"">
            <label for=""choice_2"">Medium</label>
            <input type=""radio"" id=""choice_3"" name=""choice"" value=""high"">
            <label for=""choice_3"">High</label>
        </div>

        <div class=""login"">
            <label for=""userName"">Login: </label>
            <input id=""userName"" type=""text"" name=""login"" placeholder=""Input Login"">
        </div>
        <div clas");
                WriteLiteral(@"s=""password"">
            <label for=""userPassword"">Password: </label>
            <input id=""userPassword"" type=""password"" name=""password"" placeholder=""Input Password"">
        </div>

    <div class=""btn_submit"">
        <button type=""submit"">Отправить <i class=""fa fa-paper-plane""></i></button>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
