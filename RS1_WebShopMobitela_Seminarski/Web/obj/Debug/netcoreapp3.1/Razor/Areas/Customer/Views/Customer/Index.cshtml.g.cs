#pragma checksum "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8877bf12bc2f38d3f7bc91b09197ed93a7eb7bf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Customer_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Customer/Index.cshtml")]
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
#line 1 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\_ViewImports.cshtml"
using Web.Areas.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\_ViewImports.cshtml"
using Web.Areas.Customer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8877bf12bc2f38d3f7bc91b09197ed93a7eb7bf2", @"/Areas/Customer/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f65fda3ba05ad265f76f03bcd1d86b1aea42701", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Areas.Customer.Models.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sortingForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Mobitel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-lg-3 rounded\">\r\n\r\n            <div class=\"list-group\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8877bf12bc2f38d3f7bc91b09197ed93a7eb7bf26858", async() => {
                WriteLiteral("\r\n                    <!-- Input and Submit elements -->\r\n                    <br />\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8877bf12bc2f38d3f7bc91b09197ed93a7eb7bf27224", async() => {
                    WriteLiteral("\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8877bf12bc2f38d3f7bc91b09197ed93a7eb7bf27516", async() => {
                        WriteLiteral("Odaberite proizvodjaca");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 16 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProizvodjacId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Proizvodjaci;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <br />\r\n                    <h2 class=\"text-center\">Vas budzet</h2>\r\n                    <input type=\"text\" class=\"js-range-slider bg-primary\" name=\"my_range\"");
                BeginWriteAttribute("value", " value=\"", 878, "\"", 886, 0);
                EndWriteAttribute();
                WriteLiteral("\r\n                           data-type=\"double\"\r\n                           data-min=\"0\"\r\n                           data-max=\"");
#nullable restore
#line 24 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
                                Write(Model.PriceTo);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n                           data-grid=\"true\"\r\n                           prefix=\"KM\" />\r\n\r\n                    <br />\r\n                    <div class=\"form-check text-center\">\r\n                        ");
#nullable restore
#line 30 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
                   Write(Html.CheckBoxFor(x => x.PriceDesc, new { @class = "form-check-input" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <label class=""form-check-label"" for=""exampleCheck1"">Cijena Opadajuca</label>
                    </div>

                    <br />
                    <input type=""submit"" value=""Sortiraj"" class=""btn btn-primary btn-block"">
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n\r\n        </div>\r\n        <!-- /.col-lg-3 -->\r\n\r\n        <div class=\"col-lg-9\">\r\n\r\n");
            WriteLiteral("\r\n\r\n            <div class=\"row\">\r\n\r\n");
#nullable restore
#line 52 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
                 foreach (var mobitel in Model.Mobiteli)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 mb-4\">\r\n\r\n                        <div class=\"card h-100\" style=\"border-color:palegoldenrod!important\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8877bf12bc2f38d3f7bc91b09197ed93a7eb7bf214945", async() => {
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 2242, "\"", 2313, 1);
#nullable restore
#line 58 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
WriteAttributeValue("", 2248, mobitel.Slike.FirstOrDefault() ?? "/Customer/slike/iphone.jpg", 2248, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", "   alt=\"", 2314, "\"", 2322, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"card-body\">\r\n                                    <h4 class=\"card-title\">\r\n                                        <a href=\"#\">");
#nullable restore
#line 61 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
                                               Write(mobitel.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </h4>\r\n                                    <h5>");
#nullable restore
#line 63 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
                                   Write(mobitel.Cijena);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                    <p class=""card-text"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Amet numquam aspernatur!</p>
                                </div>
                           
                            <div class=""card-footer"">
                                <button class=""btn btn-primary"">Dodaj <span class=""oi oi-basket"" title=""basket"" aria-hidden=""true""></span></button>
                            </div>
                        </div>

                    </div>
");
#nullable restore
#line 73 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <!-- /.row -->\r\n            <div>\r\n                <ul class=\"pagination\">\r\n");
#nullable restore
#line 79 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
                     for (var i = 1; i <= Model.TotalPages; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 3382, "\"", 3434, 2);
            WriteAttributeValue("", 3390, "page-item", 3390, 9, true);
#nullable restore
#line 81 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
WriteAttributeValue(" ", 3399, i == Model.Page ? "active" : "", 3400, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8877bf12bc2f38d3f7bc91b09197ed93a7eb7bf219799", async() => {
#nullable restore
#line 82 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
                                                                                                                                                                                                                                                                                                     Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
                                                                                                    WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
                                                                                                                              WriteLiteral(Model.SearchName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["SearchName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-SearchName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["SearchName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
                                                                                                                                                                          WriteLiteral(Model.ProizvodjacId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProizvodjacId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ProizvodjacId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProizvodjacId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
                                                                                                                                                                                                                     WriteLiteral(Model.PriceDesc);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PriceDesc"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-PriceDesc", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["PriceDesc"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
                                                                                                                                                                                                                                                           WriteLiteral(Model.my_range);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["my_range"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-my_range", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["my_range"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 84 "C:\Users\sandr\Documents\Fakultet\rs1\webapp\RS1_WebShopMobitela_Seminarski\Web\Areas\Customer\Views\Customer\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n        <!-- /.col-lg-9 -->\r\n       \r\n    </div>\r\n<!-- /.row -->\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Areas.Customer.Models.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
