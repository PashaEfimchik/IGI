#pragma checksum "C:\Users\Павел\Desktop\Labs\5_sem\IGI\LAB_WEB_953505_EFIMCHIK\WEB_953505_EFIMCHIK.Blazor\Server\Views\Autoes\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d126325f5954d2be1b26f9a4863c8adf6988a99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autoes_Create), @"mvc.1.0.view", @"/Views/Autoes/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d126325f5954d2be1b26f9a4863c8adf6988a99", @"/Views/Autoes/Create.cshtml")]
    public class Views_Autoes_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WEB_953505_EFIMCHIK.Entities.Auto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Павел\Desktop\Labs\5_sem\IGI\LAB_WEB_953505_EFIMCHIK\WEB_953505_EFIMCHIK.Blazor\Server\Views\Autoes\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Auto</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""AutoName"" class=""control-label""></label>
                <input asp-for=""AutoName"" class=""form-control"" />
                <span asp-validation-for=""AutoName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Description"" class=""control-label""></label>
                <input asp-for=""Description"" class=""form-control"" />
                <span asp-validation-for=""Description"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Price"" class=""control-label""></label>
                <input asp-for=""Price"" class=""form-control"" />
                <span asp-validation-for=""Price"" class=""text-danger""></span");
            WriteLiteral(@">
            </div>
            <div class=""form-group"">
                <label asp-for=""Image"" class=""control-label""></label>
                <input asp-for=""Image"" class=""form-control"" />
                <span asp-validation-for=""Image"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AutoGroupId"" class=""control-label""></label>
                <select asp-for=""AutoGroupId"" class =""form-control"" asp-items=""ViewBag.AutoGroupId""></select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\Users\Павел\Desktop\Labs\5_sem\IGI\LAB_WEB_953505_EFIMCHIK\WEB_953505_EFIMCHIK.Blazor\Server\Views\Autoes\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WEB_953505_EFIMCHIK.Entities.Auto> Html { get; private set; }
    }
}
#pragma warning restore 1591
