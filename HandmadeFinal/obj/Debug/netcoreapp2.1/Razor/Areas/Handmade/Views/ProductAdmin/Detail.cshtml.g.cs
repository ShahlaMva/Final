#pragma checksum "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\ProductAdmin\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ac1e1eda072d91e22d9ba5e3068bbf58979411e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Handmade_Views_ProductAdmin_Detail), @"mvc.1.0.view", @"/Areas/Handmade/Views/ProductAdmin/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Handmade/Views/ProductAdmin/Detail.cshtml", typeof(AspNetCore.Areas_Handmade_Views_ProductAdmin_Detail))]
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
#line 1 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\_ViewImports.cshtml"
using HandmadeFinal;

#line default
#line hidden
#line 2 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\_ViewImports.cshtml"
using HandmadeFinal.Models;

#line default
#line hidden
#line 3 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\_ViewImports.cshtml"
using HandmadeFinal.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ac1e1eda072d91e22d9ba5e3068bbf58979411e", @"/Areas/Handmade/Views/ProductAdmin/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a9d34bb5578907ddca8932935a35dd559f1669b", @"/Areas/Handmade/Views/_ViewImports.cshtml")]
    public class Areas_Handmade_Views_ProductAdmin_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\ProductAdmin\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(58, 173, true);
            WriteLiteral("\r\n    <div class=\"container-fluid\" style=\"margin-top:90px;\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h5>Name</h5>\r\n                <p>");
            EndContext();
            BeginContext(232, 10, false);
#line 10 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\ProductAdmin\Detail.cshtml"
              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(242, 63, true);
            WriteLiteral("</p>\r\n                <h5>Description</h5>\r\n                <p>");
            EndContext();
            BeginContext(306, 17, false);
#line 12 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\ProductAdmin\Detail.cshtml"
              Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(323, 56, true);
            WriteLiteral("</p>\r\n                <h5>Text</h5>\r\n                <p>");
            EndContext();
            BeginContext(380, 10, false);
#line 14 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\ProductAdmin\Detail.cshtml"
              Write(Model.Text);

#line default
#line hidden
            EndContext();
            BeginContext(390, 57, true);
            WriteLiteral("</p>\r\n                <h5>Count</h5>\r\n                <p>");
            EndContext();
            BeginContext(448, 11, false);
#line 16 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\ProductAdmin\Detail.cshtml"
              Write(Model.Count);

#line default
#line hidden
            EndContext();
            BeginContext(459, 57, true);
            WriteLiteral("</p>\r\n                <h5>Price</h5>\r\n                <p>");
            EndContext();
            BeginContext(517, 11, false);
#line 18 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\ProductAdmin\Detail.cshtml"
              Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(528, 60, true);
            WriteLiteral("</p>\r\n                <h5>Category</h5>\r\n                <p>");
            EndContext();
            BeginContext(589, 27, false);
#line 20 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\ProductAdmin\Detail.cshtml"
              Write(Model.Category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(616, 54, true);
            WriteLiteral("</p>\r\n                <h5>Image</h5>\r\n                ");
            EndContext();
            BeginContext(670, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ffe4e47480154c96962750070eff5fc9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 680, "~/img/category/", 680, 15, true);
#line 22 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\ProductAdmin\Detail.cshtml"
AddHtmlAttributeValue("", 695, Model.ProductImages.FirstOrDefault()?.Image, 695, 44, false);

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
            BeginContext(757, 117, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n\r\n            <div class=\"col-12\">\r\n                ");
            EndContext();
            BeginContext(874, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b637828fa94649afbce7f42719b50b0b", async() => {
                BeginContext(896, 7, true);
                WriteLiteral("Go Back");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(907, 52, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
