#pragma checksum "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffd70e84b9073ab9b04023e5aebff7a7551235e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Nhom11.QLQC.Pages.Pages_QuangCaoVaLoaiQuangCao), @"mvc.1.0.razor-page", @"/Pages/QuangCaoVaLoaiQuangCao.cshtml")]
namespace Nhom11.QLQC.Pages
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
#line 1 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Nhom11.QLQC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
using global::QLQC.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffd70e84b9073ab9b04023e5aebff7a7551235e7", @"/Pages/QuangCaoVaLoaiQuangCao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c31e6a444f522b33e1936fe7fc53ac62294f87d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_QuangCaoVaLoaiQuangCao : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script>\r\n    var dataQc_Lqc = ");
#nullable restore
#line 8 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                Write(Html.Raw(JsonSerializer.Serialize(Model.lst)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd70e84b9073ab9b04023e5aebff7a7551235e74543", async() => {
                WriteLiteral(@"
<div class=""row"">
    <div class=""col-3 form-group"">
        <label>Mã quảng cáo :</label>
        <input  type=""text""  id=""mqc"" name=""mqc"" class=""form-control"" />
    </div>
    <div class=""col-3 form-group"">
        <label style=""margin-left: 50px""  >Mã loại quảng cáo :</label>
        <input style=""margin-left: 50px""  type=""text""  id=""mlqc"" name=""mlqc"" class=""form-control"" />
    </div>
    <div class=""col-3 form-group"">
        <label style=""margin-left: 100px"" >Hình thức :</label>
        <select style=""margin-left: 100px"" id=""ht"" name=""ht"" class=""form-control"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd70e84b9073ab9b04023e5aebff7a7551235e75436", async() => {
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
                WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
             foreach (var item in Model.lst1)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("               ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd70e84b9073ab9b04023e5aebff7a7551235e76901", async() => {
#nullable restore
#line 26 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                                          Write(item.HinhThuc);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                   WriteLiteral(item.HinhThuc);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("  \r\n");
#nullable restore
#line 27 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
            }              

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select> \r\n    </div>\r\n    <div class=\"col-3 form-group\">\r\n            <br />\r\n            <input style=\"margin-top: 5px; margin-left: 150px\" type=\"submit\" class=\"btn btn-primary\" value=\"Tìm kiếm\"/>\r\n    </div>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br />
<div class=""text-center"">
    <h2 style=""display: inline-block""><b>Các quảng cáo và loại quảng cáo</b></h2>
    <input style=""float: right"" onclick=""openModalQuangCao_LoaiQuangCaoAdd()"" type = ""button"" class=""btn btn-outline-success"" value=""Thêm mới""/>
    <div style=""text-align:left"" id=""divModalAdd"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg"" role=""document"">
    <div class=""modal-content"">
        <div class=""modal-header"">
        <h5 class=""modal-title"">Quảng cáo - Loại quảng cáo | Thêm mới</span></h5>
        <button type=""button"" class=""btn-close"" data-dismiss=""modal"" aria-label=""Close""></button>
        </div>
        <div class=""modal-body"">
        <div class=""form-group"">
            <label>Mã quảng cáo : </label>
            <select id=""txtmqcA"" class=""form-control"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd70e84b9073ab9b04023e5aebff7a7551235e711370", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
             foreach (var item in Model.lst2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd70e84b9073ab9b04023e5aebff7a7551235e712772", async() => {
#nullable restore
#line 54 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                                      Write(item.MaQc);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                   WriteLiteral(item.MaQc);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  \r\n");
#nullable restore
#line 55 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
            }              

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Mã loại : </label>\r\n            <select id=\"txtmlqcA\" class=\"form-control\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd70e84b9073ab9b04023e5aebff7a7551235e715018", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
             foreach (var item in Model.lst1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd70e84b9073ab9b04023e5aebff7a7551235e716420", async() => {
#nullable restore
#line 64 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                                        Write(item.MaLoai);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                   WriteLiteral(item.MaLoai);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  \r\n");
#nullable restore
#line 65 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
            }              

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
        <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary""  data-dismiss=""modal"">Close</button>
        <button type=""button"" onclick=""addQuangCao_LoaiQuangCao()"" class=""btn btn-primary"">Save changes</button>
        </div>
    </div>
    </div>
</div>
</div>
");
#nullable restore
#line 76 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
 if (Request.Method.ToUpper() == "GET")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-success table-condensed\">\r\n    <tr style=\"text-align:center\">\r\n        <th>Mã quảng cáo</th>\r\n        <th>Mã loại quảng cáo</th>\r\n        <th>Hình thức</th>\r\n        <th colspan=\"2\">Tác vụ</th>\r\n    </tr>\r\n");
#nullable restore
#line 85 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
     foreach(QC_LQCDTO qc in Model.lst )
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr style=\"text-align:center\">\r\n            <td>");
#nullable restore
#line 88 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
           Write(qc.MaQc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 89 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
           Write(qc.MaLoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 91 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                foreach (var q in Model.lst1)
               {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                     if(String.Compare(@q.MaLoai,@qc.MaLoai) == 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                   Write(q.HinhThuc);

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                                   
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                                 
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                <button  type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3787, "\"", 3852, 5);
            WriteAttributeValue("", 3797, "openModalQuangCao_LoaiQuangCao(\'", 3797, 32, true);
#nullable restore
#line 100 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
WriteAttributeValue("", 3829, qc.MaQc, 3829, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3837, "\',\'", 3837, 3, true);
#nullable restore
#line 100 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
WriteAttributeValue("", 3840, qc.MaLoai, 3840, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3850, "\')", 3850, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\" >Sửa</button>                   \r\n                <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3957, "\"", 4024, 5);
            WriteAttributeValue("", 3967, "deleteModalQuangCao_LoaiQuangCao(\'", 3967, 34, true);
#nullable restore
#line 101 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
WriteAttributeValue("", 4001, qc.MaQc, 4001, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4009, "\',\'", 4009, 3, true);
#nullable restore
#line 101 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
WriteAttributeValue("", 4012, qc.MaLoai, 4012, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4022, "\')", 4022, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\" >Xoá</button>\r\n            </td>\r\n        </tr> \r\n");
#nullable restore
#line 104 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 106 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
}
else if(Request.Method.ToUpper() == "POST") {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-success table-condensed\">\r\n    <tr style=\"text-align:center\">\r\n        <th>Mã quảng cáo</th>\r\n        <th>Mã loại quảng cáo</th>\r\n        <th>Hình thức</th>\r\n        <th colspan=\"2\">Tác vụ</th>\r\n    </tr>        \r\n");
#nullable restore
#line 115 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
     foreach(QC_LQCDTO qc in Model.lst )
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr style=\"text-align:center\">\r\n            <td>");
#nullable restore
#line 118 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
           Write(qc.MaQc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 119 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
           Write(qc.MaLoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 121 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                foreach (var q in Model.lst1)
               {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                     if(String.Compare(@q.MaLoai,@qc.MaLoai) == 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                   Write(q.HinhThuc);

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                                   
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                                 
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                <button  type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4910, "\"", 4975, 5);
            WriteAttributeValue("", 4920, "openModalQuangCao_LoaiQuangCao(\'", 4920, 32, true);
#nullable restore
#line 130 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
WriteAttributeValue("", 4952, qc.MaQc, 4952, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4960, "\',\'", 4960, 3, true);
#nullable restore
#line 130 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
WriteAttributeValue("", 4963, qc.MaLoai, 4963, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4973, "\')", 4973, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\" >Sửa</button>                   \r\n                <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5080, "\"", 5147, 5);
            WriteAttributeValue("", 5090, "deleteModalQuangCao_LoaiQuangCao(\'", 5090, 34, true);
#nullable restore
#line 131 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
WriteAttributeValue("", 5124, qc.MaQc, 5124, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5132, "\',\'", 5132, 3, true);
#nullable restore
#line 131 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
WriteAttributeValue("", 5135, qc.MaLoai, 5135, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5145, "\')", 5145, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\" >Xoá</button>\r\n            </td>\r\n        </tr> \r\n");
#nullable restore
#line 134 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 136 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""text-align:left"" id=""divModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg"" role=""document"">
    <div class=""modal-content"">
        <div class=""modal-header"">
        <h5 class=""modal-title"">Quảng cáo - Loại quảng cáo | <span id=""spanid1""></span> - <span id=""spanid2""></span></h5>
        <button type=""button"" class=""btn-close"" data-dismiss=""modal"" aria-label=""Close""></button>
        </div>
        <div class=""modal-body"">
        <div class=""form-group"">
            <label>Mã quảng cáo : </label>
            <select id=""txtmqc"" class=""form-control"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd70e84b9073ab9b04023e5aebff7a7551235e729345", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 149 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
             foreach (var item in Model.lst2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd70e84b9073ab9b04023e5aebff7a7551235e730748", async() => {
#nullable restore
#line 151 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                                      Write(item.MaQc);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 151 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                   WriteLiteral(item.MaQc);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  \r\n");
#nullable restore
#line 152 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
            }              

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Mã loại : </label>\r\n            <select id=\"txtmlqc\" class=\"form-control\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd70e84b9073ab9b04023e5aebff7a7551235e732996", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 159 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
             foreach (var item in Model.lst1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffd70e84b9073ab9b04023e5aebff7a7551235e734399", async() => {
#nullable restore
#line 161 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                                        Write(item.MaLoai);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 161 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
                   WriteLiteral(item.MaLoai);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  \r\n");
#nullable restore
#line 162 "C:\Users\Thai Tuong\Source\Repos\QLQC.Nhom111\Nhom11.QLQC\Pages\QuangCaoVaLoaiQuangCao.cshtml"
            }              

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
        <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary""  data-dismiss=""modal"">Close</button>
        <button type=""button"" onclick=""saveQuangCao_LoaiQuangCao()"" class=""btn btn-primary"">Save changes</button>
        </div>
    </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nhom11.QLQC.Pages.QuangCaoVaLoaiQuangCaoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.QuangCaoVaLoaiQuangCaoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.QuangCaoVaLoaiQuangCaoModel>)PageContext?.ViewData;
        public Nhom11.QLQC.Pages.QuangCaoVaLoaiQuangCaoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591