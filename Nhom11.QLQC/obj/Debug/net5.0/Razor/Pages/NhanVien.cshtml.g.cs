#pragma checksum "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84bc68489dccc6df10dffd5fe55d8d279349acb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Nhom11.QLQC.Pages.Pages_NhanVien), @"mvc.1.0.razor-page", @"/Pages/NhanVien.cshtml")]
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
#line 1 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Nhom11.QLQC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Nhom11.QLQC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
using global::QLQC.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
using Microsoft.AspNetCore.Antiforgery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84bc68489dccc6df10dffd5fe55d8d279349acb0", @"/Pages/NhanVien.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b39bf525f09de2fceaa200944ecf09c0e81b8ae", @"/Pages/_ViewImports.cshtml")]
    public class Pages_NhanVien : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2014", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2018", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2021", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 7 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
  
    var token = antiforgery.GetAndStoreTokens(HttpContext).RequestToken;

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n    var dataNv = ");
#nullable restore
#line 14 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
            Write(Html.Raw(JsonSerializer.Serialize(Model.lst)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var dataNvx = ");
#nullable restore
#line 15 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
             Write(Html.Raw(JsonSerializer.Serialize(Model.lst2)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var curPageNv = 1;\r\n    var totPageNv = ");
#nullable restore
#line 17 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
               Write(Html.Raw(Model.totalPageNv));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var lststatic1 = ");
#nullable restore
#line 18 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
                Write(Html.Raw(JsonSerializer.Serialize(Model.lststatic1)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var lststatic2 = ");
#nullable restore
#line 19 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
                Write(Html.Raw(JsonSerializer.Serialize(Model.lststatic2)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84bc68489dccc6df10dffd5fe55d8d279349acb07526", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-3 form-group"">
            <label>Mã nhân viên : </label>
            <input type=""text"" id=""mnv"" name=""mnv"" class=""form-control"" />
        </div>
        <div class=""col-2 form-group"">
            <label>      Mã nhóm :    </label>
            <select id=""mn"" name=""mn"" class=""form-control"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84bc68489dccc6df10dffd5fe55d8d279349acb08167", async() => {
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
#line 32 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
                 foreach (var item in Model.lst1)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84bc68489dccc6df10dffd5fe55d8d279349acb09630", async() => {
#nullable restore
#line 34 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
                                            Write(item.MaNhom);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
                       WriteLiteral(item.MaNhom);

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
                WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </select>
        </div>
        <div class=""col-3 form-group"">
            <label>Tên nhân viên : </label>
            <input type=""text"" id=""tnv"" name=""tnv"" class=""form-control"" />
        </div>
        <div class=""col-2 form-group"">
            <label>      Năm vào làm:     </label>
            <select id=""nvl"" name=""nvl"" class=""form-control"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84bc68489dccc6df10dffd5fe55d8d279349acb012115", async() => {
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
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84bc68489dccc6df10dffd5fe55d8d279349acb013310", async() => {
                    WriteLiteral("Trước năm 2014");
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
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84bc68489dccc6df10dffd5fe55d8d279349acb014558", async() => {
                    WriteLiteral("Trước năm 2014");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84bc68489dccc6df10dffd5fe55d8d279349acb015806", async() => {
                    WriteLiteral("Từ năm 2021");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </select>\r\n        </div>\r\n        <div class=\"col-2 form-group\">\r\n            <br />\r\n            <input style=\"margin-top: 5px; margin-left: 70px\" type=\"submit\" class=\"btn btn-primary\" value=\"Tìm kiếm\" />\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n<div class=\"text-center\">\r\n    <h2 style=\"display: inline-block\"><b>Danh sách nhân viên</b></h2>\r\n    <button style=\"float: right\" type=\"button\" onclick=\"openModalNV(null);\" class=\"btn btn-outline-success\"> Thêm mới</button>\r\n</div>\r\n\r\n");
#nullable restore
#line 64 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
 if (Request.Method.ToUpper() == "GET")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table id=""tbNV"" class=""table table-success table-condensed"">
        <tr>
            <th>Mã nhân viên</th>
            <th>Tên nhân viên</th>
            <th>Mã nhóm</th>
            <th>Ngày sinh</th>
            <th>Ngày vào làm</th>
            <th>Email</th>
            <th>Giới tính</th>
        </tr>
        <tbody id=""tbodyNv"">
");
#nullable restore
#line 77 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
             foreach (NhanVienDTO nv in Model.lst2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("id", " id=\"", 2834, "\"", 2852, 2);
            WriteAttributeValue("", 2839, "trNv_", 2839, 5, true);
#nullable restore
#line 79 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
WriteAttributeValue("", 2844, nv.MaNv, 2844, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-align:center\">\r\n                    <td>");
#nullable restore
#line 80 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
                   Write(nv.MaNv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 81 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
                   Write(nv.TenNv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 82 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
                   Write(nv.MaNhom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 83 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
                   Write(nv.NgSinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 84 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
                   Write(nv.NgVaoLam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 85 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
                   Write(nv.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 86 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
                   Write(nv.Gt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n                        <button style=\"margin-bottom:5px\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3262, "\"", 3296, 3);
            WriteAttributeValue("", 3272, "openModalNV(\'", 3272, 13, true);
#nullable restore
#line 89 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
WriteAttributeValue("", 3285, nv.MaNv, 3285, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3293, "\');", 3293, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Sửa</button>\r\n                        <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3389, "\"", 3426, 3);
            WriteAttributeValue("", 3399, "deleteNhanVien(\'", 3399, 16, true);
#nullable restore
#line 90 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
WriteAttributeValue("", 3415, nv.MaNv, 3415, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3423, "\');", 3423, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Xoá</button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 93 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
    <nav aria-label=""Page navigation example"">
        <ul class=""pagination"">
            <li class=""page-item""><a class=""page-link"" onclick=""goPrevNv();"" href=""javascript:void(0);"">Previous</a></li>
            <li class=""page-item""><a class=""page-link"" href=""javascript:void(0);""> <span id=""spanCurrentPageNv"">1</span></a></li>
            <li class=""page-item""><a class=""page-link"" onclick=""goNextNv();"" href=""javascript:void(0);"">Next</a></li>
        </ul>
    </nav>
");
#nullable restore
#line 103 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
}
else if (Request.Method.ToUpper() == "POST")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table id=""tbNV"" class=""table table-success table-condensed"">
        <tr>
            <th>Mã nhân viên</th>
            <th>Tên nhân viên</th>
            <th>Mã nhóm</th>
            <th>Ngày sinh</th>
            <th>Ngày vào làm</th>
            <th>Email</th>
            <th>Giới tính</th>
        </tr>
");
#nullable restore
#line 116 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
         foreach (NhanVienDTO nv in Model.lst)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 4501, "\"", 4519, 2);
            WriteAttributeValue("", 4506, "trNv_", 4506, 5, true);
#nullable restore
#line 118 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
WriteAttributeValue("", 4511, nv.MaNv, 4511, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-align:center\">\r\n                <td>");
#nullable restore
#line 119 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
               Write(nv.MaNv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 120 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
               Write(nv.TenNv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 121 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
               Write(nv.MaNhom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 122 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
               Write(nv.NgSinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 123 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
               Write(nv.NgVaoLam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 124 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
               Write(nv.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 125 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
               Write(nv.Gt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    <button style=\"margin-bottom:5px\" type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4893, "\"", 4927, 3);
            WriteAttributeValue("", 4903, "openModalNV(\'", 4903, 13, true);
#nullable restore
#line 128 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
WriteAttributeValue("", 4916, nv.MaNv, 4916, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4924, "\');", 4924, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Sửa</button>\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5016, "\"", 5053, 3);
            WriteAttributeValue("", 5026, "deleteNhanVien(\'", 5026, 16, true);
#nullable restore
#line 129 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
WriteAttributeValue("", 5042, nv.MaNv, 5042, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5050, "\');", 5050, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Xoá</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 132 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 134 "C:\Users\quoch\OneDrive\Máy tính\QLQC.Nhom11\Nhom11.QLQC\Pages\NhanVien.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""margin-left:-150px"" class=""rows"">
    <div class=""col-6"" style="" display: inline-block"">
        <div id=""piechart1"" style=""width: 900px; height: 500px;""></div>
    </div>
    <div class=""col-3"" style=""display: inline-block"">
        <div id=""piechart2"" style=""width: 900px; height: 500px;""></div>
    </div>
</div>

<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
<script type=""text/javascript"">
    google.charts.load('current', { 'packages': ['corechart'] });
    google.charts.setOnLoadCallback(drawChart1);
    google.charts.setOnLoadCallback(drawChart2);
    function drawChart1() {
        var dataC = [
            ['Year', 'Hours per Day'],

        ];
        for (var i = 0; i < lststatic1.length; i++) {
            var arr = [lststatic1[i].Year, lststatic1[i].NumberEmpl];
            dataC.push(arr);
        }
        var data = google.visualization.arrayToDataTable(dataC);
        var options = {
            title: 'Phần trăm nhâ");
            WriteLiteral(@"n viên mới vào làm hăng năm'
        };
        var chart = new google.visualization.PieChart(document.getElementById('piechart1'));
        chart.draw(data, options);
    }
    function drawChart2() {
        var dataC = [
            ['Task', 'Hours per Day'],

        ];
        for (var i = 0; i < lststatic2.length; i++) {
            var arr = [lststatic2[i].MaNhom, lststatic2[i].NumberEmpl];
            dataC.push(arr);
        }
        var data = google.visualization.arrayToDataTable(dataC);
        var options = {
            title: 'Tỉ lệ nhân viên ở mỗi nhóm'
        };

        var chart = new google.visualization.PieChart(document.getElementById('piechart2'));

        chart.draw(data, options);
    }
</script>
<div id=""divModalNV"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Thêm nhân viên - <span id=""");
            WriteLiteral(@"spanIdNv""></span></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""form-group"">
                    <label  for=""txtMaNv"">Mã nhân viên</label>
                    <input type=""text"" class=""form-control"" id=""txtMaNv"" aria-describedby=""MaNvHelp"">
                    <small id=""MaNvHelp"" class=""form-text text-muted"">Mã nhân viên không được trống !</small>
                </div>
                <div class=""form-group"">
                    <label for=""txtTenNv"">Tên nhân viên</label>
                    <input type=""text"" class=""form-control"" id=""txtTenNv"" aria-describedby=""TenNvHelp"">
                    <small id=""TenNvHelp"" class=""form-text text-muted"">Tên nhân viên không được trống !</small>
                </div>
                <div class=""form-group"">
                    <labe");
            WriteLiteral(@"l for=""txtMaNhom"">Mã nhóm</label>
                    <input type=""text"" class=""form-control"" id=""txtMaNhom"" aria-describedby=""MaNhomHelp"">
                    <small id=""MaNhomHelp"" class=""form-text text-muted"">Mã nhóm không được trống !</small>
                </div>
                <div class=""form-group"">
                    <label for=""txtNgVaoLam"">Ngày vào làm</label>
                    <input type=""date"" class=""form-control"" id=""txtNgVaoLam"" aria-describedby=""NgVaoLamHelp"">
                    <small id=""NgVaoLamHelp"" class=""form-text text-muted"">Ngày vào làm không được trống !.</small>
                </div>
                <div class=""form-group"">
                    <label for=""txtNgSinh"">Ngày sinh </label>
                    <input type=""date"" class=""form-control"" id=""txtNgSinh"" aria-describedby=""MaNhomHelp"">
                    <small id=""NgSinhHelp"" class=""form-text text-muted"">Ngày sinh không được trống !.</small>
                </div>
                <div class=""form-group"">
 ");
            WriteLiteral(@"                   <label for=""txtEmail"">Email</label>
                    <input type=""text"" class=""form-control"" id=""txtEmail"" aria-describedby=""EmailHelp"">
                </div>
                <div class=""form-group"">
                    <label for=""txtGt"">Giới tính</label>
                    <input type=""text"" class=""form-control"" id=""txtGt"" aria-describedby=""GtHelp"" />
                    <small id=""GtHelp"" class=""form-text text-muted"">Giới tính không được trống !.</small>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" onclick=""saveNhanVien();"" class=""btn btn-primary"">Lưu</button>
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Thoát</button>
            </div>
        </div>
    </div>
</div>

<script id=""nvTemplate"" type=""text/x-jquery-tmpl"">
    <tr id=""trNv_${maNv}"" style=""text-align:center"">
        <td>${maNv}</td>
        <td>${tenNv}</td>
        <td>${maNhom}</td>");
            WriteLiteral(@"
        <td>${ngSinh}</td>
        <td>${ngVaoLam}</td>
        <td>${email}</td>
        <td>${gt}</td>

        <td>
            <button style=""margin-bottom:5px"" type=""button"" onclick=""openModalNV('${maNv}');"" type=""button"" class=""btn btn-outline-primary"">Sửa</button>
            <button type=""button"" onclick=""deleteNhanVien('${maNv}');"" class=""btn btn-outline-danger"">Xoá</button>
        </td>
    </tr>
</script>


");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAntiforgery antiforgery { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nhom11.QLQC.Pages.NhanVienModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.NhanVienModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.NhanVienModel>)PageContext?.ViewData;
        public Nhom11.QLQC.Pages.NhanVienModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
