#pragma checksum "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d55404a8681e6232b71981655e4917769b706d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pjesma_Index), @"mvc.1.0.view", @"/Views/Pjesma/Index.cshtml")]
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
#line 1 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\_ViewImports.cshtml"
using AtomicFitness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\_ViewImports.cshtml"
using AtomicFitness.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d55404a8681e6232b71981655e4917769b706d3", @"/Views/Pjesma/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c6e79929bcf1e6349fbe2d6b291d77e17d566e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Pjesma_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AtomicFitness.Models.Pjesma>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning musicedit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info musicdet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger musicdel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
  
    ViewData["Title"] = "Music";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Music</h1>\r\n");
#nullable restore
#line 8 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
 if (User.IsInRole("Administrator")) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d55404a8681e6232b71981655e4917769b706d36399", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 12 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"margin-bottom: 10px\">\r\n");
#nullable restore
#line 15 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
     using (Html.BeginForm("Index", "Pjesma", FormMethod.Get))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"margin-bottom: 10px\">\r\n            <b style=\"margin-right: 10px\">Search By:</b>\r\n            ");
#nullable restore
#line 19 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
       Write(Html.RadioButton("SearchBy", "Naziv", new { @class = "form-check-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"margin-right: 10px\">Name</span>\r\n            ");
#nullable restore
#line 20 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
       Write(Html.RadioButton("SearchBy", "Pjevaci", new { @class = "form-check-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"margin-right: 10px\">Singers</span>\r\n            ");
#nullable restore
#line 21 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
       Write(Html.RadioButton("SearchBy", "Zanr", new { @class = "form-check-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span style=\"margin-right: 10px\">Genre</span>\r\n        </div>\r\n");
#nullable restore
#line 23 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
   Write(Html.TextBox("Search", "", new { @class = "form-control me-sm-2", @style = "display: inline-block; width: 30%" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input type=\"submit\" value=\"Search\" class=\"btn btn-outline-light my-2 my-sm-0\" />\r\n        <br />\r\n        <small class=\"form-text text-muted\">For more than one song use comma as a delimiter</small>\r\n");
#nullable restore
#line 27 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 30 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td colspan=\"5\">No rows match search criteria</td>\r\n    </tr>\r\n");
#nullable restore
#line 35 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container cont-music\">\r\n        <div class=\"row \">\r\n");
#nullable restore
#line 41 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-12"">
                    <div class=""card border-2 border-primary card-music"">
                        <div class=""imgparent-music"">

                            <img src=""https://ak.picdn.net/shutterstock/videos/1038536891/thumb/11.jpg?ip=x480"" class=""card-img-top"" alt=""Image"">
                            <div class=""fa fa-plus img-overlay""></div>
                        </div>
                        <div class=""card-body-music"">
                            <h5 class=""card-title"">");
#nullable restore
#line 51 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.Naziv));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <div class=\"music-desc\">\r\n\r\n                                Artist: ");
#nullable restore
#line 54 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Pjevaci));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                                Year: ");
#nullable restore
#line 55 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.GodinaIzdanja));

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;&nbsp;&nbsp; Genre: ");
#nullable restore
#line 55 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
                                                                                                             Write(Html.DisplayFor(modelItem => item.Zanr));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </div>\r\n                            <div class=\"buttons-music\">\r\n");
#nullable restore
#line 59 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
                                 if (User.IsInRole("Administrator"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d55404a8681e6232b71981655e4917769b706d313639", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
                                                           WriteLiteral(item.PjesmaID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d55404a8681e6232b71981655e4917769b706d316201", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
                                                          WriteLiteral(item.PjesmaID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
                                 if (User.IsInRole("Administrator"))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d55404a8681e6232b71981655e4917769b706d318839", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
                                                             WriteLiteral(item.PjesmaID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 67 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 72 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 75 "C:\Users\tarik\Source\Repos\Grupa9-AtomicFitness\AtomicFitness\AtomicFitness\Views\Pjesma\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AtomicFitness.Models.Pjesma>> Html { get; private set; }
    }
}
#pragma warning restore 1591
