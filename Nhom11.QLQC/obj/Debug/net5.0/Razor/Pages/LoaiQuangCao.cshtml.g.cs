#pragma checksum "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c1a39f55ac2048daca4ab3fcb672548e6d9092e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Nhom11.QLQC.Pages.Pages_LoaiQuangCao), @"mvc.1.0.razor-page", @"/Pages/LoaiQuangCao.cshtml")]
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
#line 1 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Nhom11.QLQC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Nhom11.QLQC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
using global::QLQC.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c1a39f55ac2048daca4ab3fcb672548e6d9092e", @"/Pages/LoaiQuangCao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b39bf525f09de2fceaa200944ecf09c0e81b8ae", @"/Pages/_ViewImports.cshtml")]
    public class Pages_LoaiQuangCao : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/QuangCaoVaLoaiQuangCao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script>\r\n    var dataLqc = ");
#nullable restore
#line 9 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
             Write(Html.Raw(JsonSerializer.Serialize(Model.lst)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c1a39f55ac2048daca4ab3fcb672548e6d9092e5687", async() => {
                WriteLiteral(@"
<div class=""row"">
    <div class=""col-5 form-group"">
        <label>      Mã loại quảng cáo :    </label>
        <input type=""text""  id=""mlqc"" name=""mlqc"" class=""form-control"" />
    </div>
    <div class=""col-5 form-group"">
        <label>Hình thức quảng cáo : </label>
        <select  id=""ht"" name=""ht"" class=""form-control"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c1a39f55ac2048daca4ab3fcb672548e6d9092e6313", async() => {
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
#line 21 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
             foreach (var item in Model.lst2)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("               ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c1a39f55ac2048daca4ab3fcb672548e6d9092e7782", async() => {
#nullable restore
#line 23 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
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
#line 23 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
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
#line 24 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
            }              

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>          \r\n    </div>\r\n        \r\n    <div class=\"col-2 form-group\">\r\n            <br />\r\n            <input style=\"margin-top: 5px; margin-left: 70px\" type=\"submit\" class=\"btn btn-primary\" value=\"Tìm kiếm\"/>\r\n    </div>\r\n</div>\r\n");
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
    <h2 style=""display: inline-block""><b>Danh sách loại quảng cáo</b></h2>
    <input style=""float: right"" onclick=""openModalLoaiQuangCaoAdd()"" type = ""button"" class=""btn btn-outline-success"" value=""Thêm mới""/>
        <div style=""text-align:left"" id=""divModalAdd"" class=""modal"" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                <h5 class=""modal-title"">Quảng cáo - <span id=""spanid""></span></h5>
                <button type=""button"" class=""btn-close"" data-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                    <label>Mã loại : </label>
                    <input type=""text"" class=""form-control"" id=""txtmlqcA""/> 
                    <small class=""form-text text-muted"">Mã loại không được trống !</small>
          ");
            WriteLiteral(@"      </div>
                <div class=""form-group"">
                    <label>Hình thức : </label>
                    <input type=""text"" class=""form-control"" id=""txthtA""/> 
                    <small class=""form-text text-muted"">Hình thức không được trống !</small>
                </div>
                <div class=""form-group"">
                    <label>Mô tả : </label>
                    <textarea rows=""5"" class=""form-control"" id=""txtmtA""></textarea>
                    <small class=""form-text text-muted"">Mô tả không được trống !</small>
                </div>
                <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary""  data-dismiss=""modal"">Close</button>
                <button type=""button"" onclick=""addLoaiQuangCao()"" class=""btn btn-primary"">Save changes</button>
                </div>
            </div>
        </div>
    </div>
</div>
    
");
#nullable restore
#line 70 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
 if (Request.Method.ToUpper() == "GET")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-success table-condensed"">
    <tr style=""text-align:center"">
        <th>Mã loại quảng cáo</th>
        <th>Hình thức quảng cáo</th>
        <th>Mô tả</th>
        <th>Các dự án quảng cáo</th>
        <th >Tác vụ</th>
    </tr>
");
#nullable restore
#line 80 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
         foreach (LoaiQcDTO lqc in Model.lst)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"text-align:center\">\r\n                <td>");
#nullable restore
#line 83 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.MaLoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 84 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.HinhThuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 85 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 87 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                    foreach (var q in Model.lst1)
                  {
                        if(String.Compare(@q.MaLoai,@lqc.MaLoai) == 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                       Write(q.MaQc);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 92 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                        }
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c1a39f55ac2048daca4ab3fcb672548e6d9092e16043", async() => {
                WriteLiteral("Chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                 <td>\r\n                    <button style=\"margin-bottom:5px\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3962, "\"", 4008, 3);
            WriteAttributeValue("", 3972, "openModalLoaiQuangCao(\'", 3972, 23, true);
#nullable restore
#line 97 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
WriteAttributeValue("", 3995, lqc.MaLoai, 3995, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4006, "\')", 4006, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-outline-primary\" >Sửa</button>                   \r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4131, "\"", 4174, 3);
            WriteAttributeValue("", 4141, "deleteLoaiQuangCao(\'", 4141, 20, true);
#nullable restore
#line 98 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
WriteAttributeValue("", 4161, lqc.MaLoai, 4161, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4172, "\')", 4172, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\" >Xoá</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 101 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n</table>\r\n");
#nullable restore
#line 104 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
}
else if(Request.Method.ToUpper() == "POST") {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-success table-condensed"">
    <tr style=""text-align:center"">
        <th>Mã loại quảng cáo</th>
        <th>Hình thức quảng cáo</th>
        <th>Mô tả</th>
        <th>Các dự án quảng cáo</th>
        <th>Tác vụ</th>
    </tr>     
");
#nullable restore
#line 114 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
     foreach (LoaiQcDTO lqc in Model.lst)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"text-align:center\">\r\n                <td>");
#nullable restore
#line 117 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.MaLoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 118 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.HinhThuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 119 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 121 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                    foreach (var q in Model.lst1)
                  {
                        if(String.Compare(@q.MaLoai,@lqc.MaLoai) == 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                       Write(q.MaQc);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 126 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                        }
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c1a39f55ac2048daca4ab3fcb672548e6d9092e21666", async() => {
                WriteLiteral("Chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                 <td>\r\n<button style=\"margin-bottom:5px\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5268, "\"", 5314, 3);
            WriteAttributeValue("", 5278, "openModalLoaiQuangCao(\'", 5278, 23, true);
#nullable restore
#line 131 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
WriteAttributeValue("", 5301, lqc.MaLoai, 5301, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5312, "\')", 5312, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-outline-primary\" >Sửa</button>                   \r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5437, "\"", 5480, 3);
            WriteAttributeValue("", 5447, "deleteLoaiQuangCao(\'", 5447, 20, true);
#nullable restore
#line 132 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
WriteAttributeValue("", 5467, lqc.MaLoai, 5467, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5478, "\')", 5478, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\" >Xoá</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 135 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 137 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""text-align:left"" id=""divModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg"" role=""document"">
    <div class=""modal-content"">
        <div class=""modal-header"">
        <h5 class=""modal-title"">Quảng cáo - <span id=""spanid""></span></h5>
        <button type=""button"" class=""btn-close"" data-dismiss=""modal"" aria-label=""Close""></button>
        </div>
        <div class=""modal-body"">
        <div class=""form-group"">
            <label>Hình thức : </label>
            <input type=""text"" class=""form-control"" id=""txtht""/> 
            <small class=""form-text text-muted"">Hình thức không được trống !</small>
        </div>
        <div class=""form-group"">
            <label>Mô tả : </label>
            <textarea rows=""5"" class=""form-control"" id=""txtmt""></textarea>
            <small class=""form-text text-muted"">Mô tả không được trống !</small>
        </div>
        <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary""  data");
            WriteLiteral("-dismiss=\"modal\">Close</button>\r\n        <button type=\"button\" onclick=\"saveLoaiQuangCao()\" class=\"btn btn-primary\">Save changes</button>\r\n        </div>\r\n    </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nhom11.QLQC.Pages.LoaiQuangCaoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.LoaiQuangCaoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.LoaiQuangCaoModel>)PageContext?.ViewData;
        public Nhom11.QLQC.Pages.LoaiQuangCaoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
