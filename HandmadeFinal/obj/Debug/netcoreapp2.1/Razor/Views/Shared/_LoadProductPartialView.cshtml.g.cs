#pragma checksum "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Shared\_LoadProductPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01a1418c1920539441b7cc519996c523265ba44b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoadProductPartialView), @"mvc.1.0.view", @"/Views/Shared/_LoadProductPartialView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LoadProductPartialView.cshtml", typeof(AspNetCore.Views_Shared__LoadProductPartialView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01a1418c1920539441b7cc519996c523265ba44b", @"/Views/Shared/_LoadProductPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4f468e4b0201fb09912fe11447d362796b95ce4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoadProductPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SingleProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Shared\_LoadProductPartialView.cshtml"
 foreach (var product in Model.Products)
{

#line default
#line hidden
            BeginContext(68, 180, true);
            WriteLiteral("    <div class=\"col-lg-4 col-sm-6\">\r\n        <div class=\"single_category_product\">\r\n            <div class=\"single_category_img\">\r\n                <input type=\"hidden\" id=\"cate-id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 248, "\"", 276, 1);
#line 8 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Shared\_LoadProductPartialView.cshtml"
WriteAttributeValue("", 256, product.Category.Id, 256, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(277, 21, true);
            WriteLiteral(" />\r\n                ");
            EndContext();
            BeginContext(298, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3e157ac1bebe4c5a8dd0416db163ef1f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 308, "~/img/", 308, 6, true);
#line 9 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Shared\_LoadProductPartialView.cshtml"
AddHtmlAttributeValue("", 314, product.ProductImages.FirstOrDefault()?.Image, 314, 46, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(369, 113, true);
            WriteLiteral("\r\n                <div class=\"category_social_icon\">\r\n                    <ul>\r\n                        <li><a><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 482, "\"", 507, 1);
#line 12 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Shared\_LoadProductPartialView.cshtml"
WriteAttributeValue("", 490, product.IconLike, 490, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(508, 75, true);
            WriteLiteral("></i></a></li>\r\n                        <li><a class=\"add-basket\" data-id=\"");
            EndContext();
            BeginContext(584, 10, false);
#line 13 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Shared\_LoadProductPartialView.cshtml"
                                                      Write(product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(594, 201, true);
            WriteLiteral("\" @*href=\"/Product/addbasket/@product.Id\"*@><i class=\"ti-bag\"></i></a></li>\r\n                    </ul>\r\n                </div>\r\n                <div class=\"category_product_text\">\r\n                    ");
            EndContext();
            BeginContext(795, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0082dafb627a4cd19a5f9c7325be77c4", async() => {
                BeginContext(877, 4, true);
                WriteLiteral("<h5>");
                EndContext();
                BeginContext(882, 12, false);
#line 17 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Shared\_LoadProductPartialView.cshtml"
                                                                                                     Write(product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(894, 5, true);
                WriteLiteral("</h5>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Shared\_LoadProductPartialView.cshtml"
                                                                             WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(903, 25, true);
            WriteLiteral("\r\n                    <p>");
            EndContext();
            BeginContext(929, 13, false);
#line 18 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Shared\_LoadProductPartialView.cshtml"
                  Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(942, 87, true);
            WriteLiteral(" AZN</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n   \r\n    </div>\r\n");
            EndContext();
#line 24 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Views\Shared\_LoadProductPartialView.cshtml"

}

#line default
#line hidden
            BeginContext(1034, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsView> Html { get; private set; }
    }
}
#pragma warning restore 1591