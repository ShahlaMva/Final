#pragma checksum "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43518a4b967e2bbbd04dfa25d5c52e263eab9afd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\_ViewImports.cshtml"
using HandmadeFinal;

#line default
#line hidden
#line 2 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\_ViewImports.cshtml"
using HandmadeFinal.Models;

#line default
#line hidden
#line 3 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\_ViewImports.cshtml"
using HandmadeFinal.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43518a4b967e2bbbd04dfa25d5c52e263eab9afd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4f468e4b0201fb09912fe11447d362796b95ce4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn_1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Ana Səhifə";

#line default
#line hidden
            BeginContext(60, 29, true);
            WriteLiteral("\n<section class=\"banner_part\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 89, "\"", 163, 4);
            WriteAttributeValue("", 97, "background-image:", 97, 17, true);
            WriteAttributeValue(" ", 114, "url(\'img/", 115, 10, true);
#line 6 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml"
WriteAttributeValue("", 124, Model.HomeBanners.ElementAt(0).Image, 124, 37, false);

#line default
#line hidden
            WriteAttributeValue("", 161, "\')", 161, 2, true);
            EndWriteAttribute();
            BeginContext(164, 354, true);
            WriteLiteral(@">
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-lg-7"">
                <div class=""banner_slider"">
                    <div class=""single_banner_slider"">
                        <div class=""banner_text"">
                            <div class=""banner_text_iner"">
                                <h5>");
            EndContext();
            BeginContext(519, 39, false);
#line 14 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml"
                               Write(Model.HomeBanners.ElementAt(0).Subtitle);

#line default
#line hidden
            EndContext();
            BeginContext(558, 42, true);
            WriteLiteral("</h5>\n                                <h1>");
            EndContext();
            BeginContext(601, 36, false);
#line 15 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml"
                               Write(Model.HomeBanners.ElementAt(0).Title);

#line default
#line hidden
            EndContext();
            BeginContext(637, 38, true);
            WriteLiteral("</h1>\n                                ");
            EndContext();
            BeginContext(675, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bdafeb97fa74236b0135ac111174974", async() => {
                BeginContext(735, 7, true);
                WriteLiteral("İndi Al");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(746, 279, true);
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""shipping_details section_padding "">
    <div class=""container"">
        <div class=""row"">
");
            EndContext();
#line 28 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml"
             foreach (var item in Model.ShippingDetails)
            {

#line default
#line hidden
            BeginContext(1096, 130, true);
            WriteLiteral("                <div class=\"col-lg-3 col-sm-6\">\n                    <div class=\"single_shopping_details\">\n                        ");
            EndContext();
            BeginContext(1226, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9c5968a8a59d4e729deb52959843e839", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1236, "~/img/icon/", 1236, 11, true);
#line 32 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1247, item.Icon, 1247, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1266, 29, true);
            WriteLiteral("\n                        <h4>");
            EndContext();
            BeginContext(1296, 10, false);
#line 33 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml"
                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1306, 33, true);
            WriteLiteral("</h4>\n                        <p>");
            EndContext();
            BeginContext(1340, 16, false);
#line 34 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml"
                      Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1356, 55, true);
            WriteLiteral("</p>\n                    </div>\n                </div>\n");
            EndContext();
#line 37 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1425, 206, true);
            WriteLiteral("\n\n        </div>\n    </div>\n</section>\n<section class=\"feature_part pt-4\">\n    <div class=\"container-fluid p-lg-0 overflow-hidden\">\n        <div class=\"row align-items-center justify-content-between mb-5\">\n");
            EndContext();
#line 46 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml"
             foreach (var category in Model.Categories)
            {

#line default
#line hidden
            BeginContext(1701, 136, true);
            WriteLiteral("                <div class=\"col-lg-4 col-sm-6 mb-3\">\n                    <div class=\"single_feature_post_text\">\n                        ");
            EndContext();
            BeginContext(1837, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "80b5582ffca04d8fb9c64e19ad9b4977", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1847, "~/img/", 1847, 6, true);
#line 50 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1853, category.CategoryImage, 1853, 23, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1886, 80, true);
            WriteLiteral("\n                        <div class=\"hover_text\">\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1966, "\"", 2011, 2);
            WriteAttributeValue("", 1973, "/Product/Index?categoryid=", 1973, 26, true);
#line 52 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml"
WriteAttributeValue("", 1999, category.Id, 1999, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2012, 15, true);
            WriteLiteral(" class=\"btn_2\">");
            EndContext();
            BeginContext(2028, 21, false);
#line 52 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml"
                                                                                      Write(category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(2049, 86, true);
            WriteLiteral("</a>\n                        </div>\n                    </div>\n                </div>\n");
            EndContext();
#line 56 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2149, 176, true);
            WriteLiteral("\n\n        </div>\n    </div>\n</section>\n<section id=\"brand-logo\">\n    <div class=\"container\">\n        <div class=\" row mt-5 mb-5 owl-carousel brands align-items-center d-flex\">\n");
            EndContext();
#line 65 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml"
             foreach (var icon in Model.BrandIcons)
            {

#line default
#line hidden
            BeginContext(2391, 62, true);
            WriteLiteral("                <div class=\" col-sm-8 \">\n\n                    ");
            EndContext();
            BeginContext(2453, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "efd4db7684b4460cba4a547751ed609e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2463, "~/img/", 2463, 6, true);
#line 69 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2469, icon.Icon, 2469, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2488, 25, true);
            WriteLiteral("\n\n                </div>\n");
            EndContext();
#line 72 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Home\Index.cshtml"


            }

#line default
#line hidden
            BeginContext(2529, 39, true);
            WriteLiteral("\n        </div>\n    </div>\n</section>\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591