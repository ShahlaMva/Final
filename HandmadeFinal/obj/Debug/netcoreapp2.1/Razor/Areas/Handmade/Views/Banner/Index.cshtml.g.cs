#pragma checksum "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\Banner\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c8b28c4536554ff3a65d6de4d149d7fdb41211e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Handmade_Views_Banner_Index), @"mvc.1.0.view", @"/Areas/Handmade/Views/Banner/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Handmade/Views/Banner/Index.cshtml", typeof(AspNetCore.Areas_Handmade_Views_Banner_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c8b28c4536554ff3a65d6de4d149d7fdb41211e", @"/Areas/Handmade/Views/Banner/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a9d34bb5578907ddca8932935a35dd559f1669b", @"/Areas/Handmade/Views/_ViewImports.cshtml")]
    public class Areas_Handmade_Views_Banner_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HomeBanner>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;margin-top:20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Banner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("More"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\Banner\Index.cshtml"
  
    ViewData["Title"] = "Index";
    

#line default
#line hidden
            BeginContext(81, 567, true);
            WriteLiteral(@"
<div class=""row "" style=""margin-top:90px;"">
    <div class=""col-md-12 "">
       <div class=""table-data__tool"">
            
            <div class=""table-data__tool-left"">
                <button  class=""au-btn au-btn-icon au-btn--green au-btn--small"">
                    <i class=""zmdi zmdi-plus""></i>  <a style=""color:white;"" href=""Banner/AddItem"">add item</a> 
                </button>
                <div class=""rs-select2--dark rs-select2--sm rs-select2--dark2"">
                    <select class=""js-select2"" name=""type"">
                        ");
            EndContext();
            BeginContext(648, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "106ab3ada6af45afaaca617e2ae7fb23", async() => {
                BeginContext(676, 6, true);
                WriteLiteral("Export");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(691, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(717, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6804096a2954c198c3f4b9f781cedca", async() => {
                BeginContext(734, 8, true);
                WriteLiteral("Option 1");
                EndContext();
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
            EndContext();
            BeginContext(751, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(777, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3dd05ddc7e0b449e9bb22c2850f800d6", async() => {
                BeginContext(794, 8, true);
                WriteLiteral("Option 2");
                EndContext();
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
            EndContext();
            BeginContext(811, 695, true);
            WriteLiteral(@"
                    </select>
                    <div class=""dropDownSelect2""></div>
                </div>
            </div>
        </div>
        <div class=""table-responsive table-responsive-data2"">
            <table class=""table table-data2"">
                <thead>
                    <tr>
                        <th  scope=""col""># </th>
                        <th scope=""col"">Title</th>
                        <th scope=""col"">Subtitle</th>
                        <th scope=""col"">Image</th>
                        <th scope=""col""></th>
                       
                       
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 40 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\Banner\Index.cshtml"
                      int count = 1; 

#line default
#line hidden
            BeginContext(1546, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 41 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\Banner\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1619, 94, true);
            WriteLiteral("                        <tr>\r\n                            \r\n                            <td > ");
            EndContext();
            BeginContext(1714, 5, false);
#line 45 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\Banner\Index.cshtml"
                             Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(1719, 70, true);
            WriteLiteral("</td>   \r\n                          \r\n                            <td>");
            EndContext();
            BeginContext(1790, 10, false);
#line 47 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\Banner\Index.cshtml"
                           Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1800, 41, true);
            WriteLiteral("</td>\r\n\r\n                            <td>");
            EndContext();
            BeginContext(1842, 13, false);
#line 49 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\Banner\Index.cshtml"
                           Write(item.Subtitle);

#line default
#line hidden
            EndContext();
            BeginContext(1855, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1894, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9826a3e744a4db79a162fd951beda94", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1904, "~/img/", 1904, 6, true);
#line 50 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\Banner\Index.cshtml"
AddHtmlAttributeValue("", 1910, item.Image, 1910, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1983, 382, true);
            WriteLiteral(@"</td>
                            <td>
                                <div class=""table-data-feature"">
                                    <button class=""item"" data-toggle=""tooltip"" data-placement=""top"" title=""Send"">
                                        <i class=""zmdi zmdi-mail-send""></i>
                                    </button>
                                    ");
            EndContext();
            BeginContext(2365, 254, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f768791f30bd4f37b7a140908bd4b01f", async() => {
                BeginContext(2505, 110, true);
                WriteLiteral("\r\n                                        <i class=\"zmdi zmdi-edit\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\Banner\Index.cshtml"
                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2619, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2657, 259, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ce0c6d70ccc47ecbbd59a9a447d1072", async() => {
                BeginContext(2800, 112, true);
                WriteLiteral("\r\n                                        <i class=\"zmdi zmdi-delete\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\Banner\Index.cshtml"
                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2916, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2954, 254, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e0bd255b07243ba87e53912c7203dc2", async() => {
                BeginContext(3094, 110, true);
                WriteLiteral("\r\n                                        <i class=\"zmdi zmdi-more\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\Banner\Index.cshtml"
                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3208, 108, true);
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 68 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\Banner\Index.cshtml"
                                count++;

#line default
#line hidden
            BeginContext(3358, 50, true);
            WriteLiteral("                        <tr class=\"spacer\"></tr>\r\n");
            EndContext();
#line 70 "C:\Users\acer\Desktop\Final-Demo\HandmadeFinal\Areas\Handmade\Views\Banner\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3431, 90, true);
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HomeBanner>> Html { get; private set; }
    }
}
#pragma warning restore 1591
