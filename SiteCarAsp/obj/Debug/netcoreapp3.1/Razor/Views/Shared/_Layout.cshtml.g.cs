#pragma checksum "E:\SiteCarAsp\SiteCarAsp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "928eca9f06c85520f30e171e2e096d8a92eadfdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "E:\SiteCarAsp\SiteCarAsp\Views\_ViewImports.cshtml"
using SiteCarAsp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\SiteCarAsp\SiteCarAsp\Views\_ViewImports.cshtml"
using SiteCarAsp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\SiteCarAsp\SiteCarAsp\Views\_ViewImports.cshtml"
using SiteCarAsp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\SiteCarAsp\SiteCarAsp\Views\_ViewImports.cshtml"
using SiteCarAsp.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928eca9f06c85520f30e171e2e096d8a92eadfdb", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"112497ff018096505d949231f04c6b7269aadac0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/cards/css/cards.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/slick-carousel/slick.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/slick-carousel/slick-theme.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icon.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/slick-carousel/slick.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/cards/js/cards.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/filter.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "928eca9f06c85520f30e171e2e096d8a92eadfdb8094", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
#nullable restore
#line 6 "E:\SiteCarAsp\SiteCarAsp\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - SiteCarAsp</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "928eca9f06c85520f30e171e2e096d8a92eadfdb8711", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "928eca9f06c85520f30e171e2e096d8a92eadfdb9889", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "928eca9f06c85520f30e171e2e096d8a92eadfdb11067", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "928eca9f06c85520f30e171e2e096d8a92eadfdb12246", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "928eca9f06c85520f30e171e2e096d8a92eadfdb13425", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "928eca9f06c85520f30e171e2e096d8a92eadfdb15308", async() => {
                WriteLiteral("\r\n    <header>\r\n        <nav class=\"navbar navbar-expand-lg navbar-light bg-light\">\r\n            <a class=\"navbar-brand\"");
                BeginWriteAttribute("href", " href=\"", 689, "\"", 722, 1);
#nullable restore
#line 16 "E:\SiteCarAsp\SiteCarAsp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 696, Url.Action("Index","Car"), 696, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "928eca9f06c85520f30e171e2e096d8a92eadfdb16052", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""credit_info"" title=""?????????????? ???????????? ??????????????????????."">
                <span>????????????  26 700 ?? ?? ??????????</span>
                <div class=""certified""></div>
                <a href=""javascript:void(0)"" class=""credit_info_link"" onclick=""showCreditInfoPopup('13,25', ' 26 700')"">
                    <svg width=""4"" height=""14"" viewBox=""0 0 4 14"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                        <path d=""M3.14508 3.71999C3.30508 3.89999 3.36509 4.17999 3.30509 4.41999L1.82509 12C2.18509 11.88 2.6051 12.0199 2.7851 12.3599C3.0051 12.7399 2.8651 13.24 2.4851 13.44L1.9851 13.72C1.7851 13.82 1.5851 13.8799 1.3651 13.8799C1.1051 13.8799 0.845087 13.8 0.625087 13.62C0.225088 13.32 0");
                WriteLiteral(@".0250879 12.82 0.125088 12.32L1.54508 4.97995H1.20509C0.765092 4.97995 0.405093 4.61995 0.405093 4.17995C0.405093 3.73995 0.765092 3.37995 1.20509 3.37995H2.52509C2.76509 3.39995 2.98508 3.53999 3.14508 3.71999ZM2.7851 0.279949C2.2651 0.279949 1.84508 0.699988 1.84508 1.21999C1.84508 1.73999 2.2651 2.15993 2.7851 2.15993C3.3051 2.15993 3.72509 1.73999 3.72509 1.21999C3.72509 0.699988 3.3051 0.279949 2.7851 0.279949Z"" fill=""#666666""></path>
                    </svg>
                </a>
            </div>
            <div class=""credit_info"" title=""?????????????? ???????????? ??????????????????????."">
                <span>????????????  50 792 ?? ?? ??????????</span>
                <div class=""certified""></div>
                <a href=""javascript:void(0)"" class=""credit_info_link"" onclick=""showLeasingCreditInfoPopup(' 50 792')"">
                    <svg width=""4"" height=""14"" viewBox=""0 0 4 14"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                        <path d=""M3.14508 3.71999C3.30508 3.89999 3.36509 4.17999 3.30509 4.41999");
                WriteLiteral(@"L1.82509 12C2.18509 11.88 2.6051 12.0199 2.7851 12.3599C3.0051 12.7399 2.8651 13.24 2.4851 13.44L1.9851 13.72C1.7851 13.82 1.5851 13.8799 1.3651 13.8799C1.1051 13.8799 0.845087 13.8 0.625087 13.62C0.225088 13.32 0.0250879 12.82 0.125088 12.32L1.54508 4.97995H1.20509C0.765092 4.97995 0.405093 4.61995 0.405093 4.17995C0.405093 3.73995 0.765092 3.37995 1.20509 3.37995H2.52509C2.76509 3.39995 2.98508 3.53999 3.14508 3.71999ZM2.7851 0.279949C2.2651 0.279949 1.84508 0.699988 1.84508 1.21999C1.84508 1.73999 2.2651 2.15993 2.7851 2.15993C3.3051 2.15993 3.72509 1.73999 3.72509 1.21999C3.72509 0.699988 3.3051 0.279949 2.7851 0.279949Z"" fill=""#666666""></path>
                    </svg>
                </a>
            </div>

            </div>
            <div class=""detal"">
                <div class=""detal_item"">
                    <div class=""detal_key"">??????????</div>
                    <div class=""detal_value"">?????????????????????? ??????????</div>
                </div>
                <div class=""detal_item"">
       ");
                WriteLiteral(@"             <div class=""detal_key"">??????????</div>
                    <div class=""detal_value""></div>
                </div>
            </div>
            </div>
            </div>
            <div class=""product_actions"">
                <a class=""compare-icon js-icon"" data-car-id='642545' data-is-run-car=""false"" href=""#"" title=""???????????????? ?? ??????????????????"">
                    <svg width=""16"" height=""16"" viewBox=""0 0 16 16"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                        <path d=""M0.600098 5.39999C0.600098 5.69999 0.900098 5.99999 1.3001 5.99999H4.7001L4.3001 6.79999C4.1001 7.09999 4.2001 7.49999 4.5001 7.69999C4.6001 7.79999 4.7001 7.79999 4.8001 7.79999C5.0001 7.79999 5.3001 7.69999 5.4001 7.49999L6.4001 5.79999C6.4001 5.79999 6.4001 5.69999 6.4001 5.59999C6.4001 5.49999 6.4001 5.49999 6.4001 5.39999C6.4001 5.29999 6.4001 5.29999 6.4001 5.19999C6.4001 5.09999 6.4001 5.09999 6.4001 4.99999L5.4001 3.29999C5.2001 2.99999 4.8001 2.89999 4.5001 3.09999C4.2001 3.19999 4.1001 3.59999 4.3");
                WriteLiteral(@"001 3.89999L4.7001 4.69999H1.3001C0.900098 4.69999 0.600098 4.99999 0.600098 5.39999Z"" fill=""#333333""></path>
                        <path d=""M14.7 10H11.3L11.7 9.2C11.9 8.9 11.8 8.5 11.4 8.3C11.1 8.1 10.7 8.2 10.5 8.6L9.5 10.3C9.5 10.3 9.5 10.4 9.5 10.5C9.5 10.6 9.5 10.6 9.5 10.7C9.5 10.8 9.5 10.8 9.5 10.9C9.5 11 9.5 11 9.5 11.1L10.5 12.8C10.6 13 10.8 13.1 11.1 13.1C11.2 13.1 11.3 13.1 11.4 13C11.7 12.8 11.8 12.4 11.7 12.1L11.3 11.3H14.7C15.1 11.3 15.4 11 15.4 10.6C15.4 10.2 15.1 10 14.7 10Z"" fill=""#333333""></path>
                        <path d=""M14.7001 13.9H7.2001V7.4H14.7001C15.1001 7.4 15.4001 7.1 15.4001 6.7C15.4001 6.3 15.1001 6 14.7001 6H10.0001V1.4C10.0001 0.999997 9.7001 0.699997 9.3001 0.699997H1.3001C0.900098 0.699997 0.600098 0.999997 0.600098 1.4C0.600098 1.8 0.900098 2.1 1.3001 2.1H8.8001V6.1H6.6001C6.2001 6.1 5.9001 6.4 5.9001 6.8V8.7H1.3001C0.900098 8.7 0.600098 9 0.600098 9.4C0.600098 9.8 0.900098 10.1 1.3001 10.1H6.0001V14.7C6.0001 15.1 6.3001 15.4 6.7001 15.4H14.8001C15.2001 15.4 15.5");
                WriteLiteral(@"001 15.1 15.5001 14.7C15.5001 14.3 15.1001 13.9 14.7001 13.9Z"" fill=""#333333""></path>
                    </svg>
                </a>
                <a class=""star-icon js-icon"" data-car-id='642545' href=""#"" title=""???????????????? ?? ??????????????????"">
                    <svg width=""16"" height=""15"" viewBox=""0 0 16 15"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                        <path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M7.99986 0.666656C8.2536 0.666656 8.48535 0.810705 8.59766 1.03824L10.5027 4.89763L14.7629 5.52033C15.014 5.55703 15.2224 5.73303 15.3007 5.97437C15.3789 6.21571 15.3134 6.48054 15.1317 6.65756L12.0495 9.65957L12.7769 13.9006C12.8198 14.1508 12.717 14.4035 12.5117 14.5527C12.3064 14.7018 12.0342 14.7215 11.8096 14.6034L7.99986 12.5999L4.19016 14.6034C3.96555 14.7215 3.69335 14.7018 3.48803 14.5527C3.28272 14.4035 3.17989 14.1508 3.22278 13.9006L3.95018 9.65957L0.868035 6.65756C0.686289 6.48054 0.620774 6.21571 0.699026 5.97437C0.777278 5.73303 0.985731 5.55703 1.23677 5.52033L5.49702 ");
                WriteLiteral(@"4.89763L7.40205 1.03824C7.51437 0.810705 7.74611 0.666656 7.99986 0.666656ZM7.99986 2.83949L6.53766 5.80174C6.44064 5.9983 6.25318 6.13461 6.03628 6.16631L2.76546 6.64439L5.13168 8.94909C5.28893 9.10225 5.3607 9.323 5.3236 9.53935L4.76531 12.7944L7.68956 11.2566C7.88381 11.1545 8.1159 11.1545 8.31016 11.2566L11.2344 12.7944L10.6761 9.53935C10.639 9.323 10.7108 9.10225 10.868 8.94909L13.2342 6.64439L9.96344 6.16631C9.74654 6.13461 9.55908 5.9983 9.46205 5.80174L7.99986 2.83949Z"" fill=""#333333""></path>
                    </svg>
                </a>
            </div>
            </div>

            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item"">
                        <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 7710, "\"", 7743, 1);
#nullable restore
#line 71 "E:\SiteCarAsp\SiteCarAsp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7717, Url.Action("Index","Car"), 7717, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">&#171;??????????????&#187 </a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 7883, "\"", 7918, 1);
#nullable restore
#line 74 "E:\SiteCarAsp\SiteCarAsp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7890, Url.Action("NewCars","Car"), 7890, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">?????????? ????????????????????</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 8055, "\"", 8091, 1);
#nullable restore
#line 77 "E:\SiteCarAsp\SiteCarAsp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8062, Url.Action("UsedCars","Car"), 8062, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">?????????????????????? ????????</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 8228, "\"", 8267, 1);
#nullable restore
#line 80 "E:\SiteCarAsp\SiteCarAsp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8235, Url.Action("Index","TestDrive"), 8235, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">???????????? ???? ????????-??????????</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 8408, "\"", 8445, 1);
#nullable restore
#line 83 "E:\SiteCarAsp\SiteCarAsp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8415, Url.Action("Index","Credits"), 8415, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">???????????? ???? ????????????</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a class=\"nav-link\"");
                BeginWriteAttribute("href", " href=\"", 8582, "\"", 8618, 1);
#nullable restore
#line 86 "E:\SiteCarAsp\SiteCarAsp\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8589, Url.Action("AboutUs","Home"), 8589, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">?? ??????</a>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </nav>\r\n    </header>\r\n\r\n    ");
#nullable restore
#line 93 "E:\SiteCarAsp\SiteCarAsp\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <footer class=\"border-top footer text-muted\">\r\n        <p class=\"text-center w-100\">\r\n            ?? 2019-");
#nullable restore
#line 97 "E:\SiteCarAsp\SiteCarAsp\Views\Shared\_Layout.cshtml"
              Write(DateTime.Today.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ?????????????????? ??.??. ??????????-118\r\n        </p>\r\n    </footer>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "928eca9f06c85520f30e171e2e096d8a92eadfdb28112", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "928eca9f06c85520f30e171e2e096d8a92eadfdb29212", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "928eca9f06c85520f30e171e2e096d8a92eadfdb30312", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "928eca9f06c85520f30e171e2e096d8a92eadfdb31412", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <! -- ???????????????????? ???????????? ???? js-->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "928eca9f06c85520f30e171e2e096d8a92eadfdb32553", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 106 "E:\SiteCarAsp\SiteCarAsp\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
