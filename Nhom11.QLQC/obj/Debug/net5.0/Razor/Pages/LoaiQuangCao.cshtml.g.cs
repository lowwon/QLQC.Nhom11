<<<<<<< HEAD
#pragma checksum "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c385b6b026299597695f545baa6e40e6aaa0c11"
=======
#pragma checksum "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3eaa92174ea2df53aeec3672ec3c933272309a30"
>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5
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
<<<<<<< HEAD
#line 1 "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
=======
#line 1 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5
using Nhom11.QLQC;

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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eaa92174ea2df53aeec3672ec3c933272309a30", @"/Pages/LoaiQuangCao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c31e6a444f522b33e1936fe7fc53ac62294f87d", @"/Pages/_ViewImports.cshtml")]
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
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c385b6b026299597695f545baa6e40e6aaa0c114587", async() => {
=======
            WriteLiteral("<script>\r\n    var dataLqc = ");
#nullable restore
#line 9 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
             Write(Html.Raw(JsonSerializer.Serialize(Model.lst)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eaa92174ea2df53aeec3672ec3c933272309a305268", async() => {
>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5
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
<<<<<<< HEAD
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c385b6b026299597695f545baa6e40e6aaa0c115215", async() => {
=======
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eaa92174ea2df53aeec3672ec3c933272309a305894", async() => {
>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5
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
<<<<<<< HEAD
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c385b6b026299597695f545baa6e40e6aaa0c116405", async() => {
                    WriteLiteral("KOL");
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
                WriteLiteral("            \r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c385b6b026299597695f545baa6e40e6aaa0c117649", async() => {
                    WriteLiteral("Page");
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
                WriteLiteral(" \r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c385b6b026299597695f545baa6e40e6aaa0c118883", async() => {
                    WriteLiteral("Youtube");
=======
                WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
             foreach (var item in Model.lst2)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("               ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eaa92174ea2df53aeec3672ec3c933272309a307361", async() => {
#nullable restore
#line 23 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                                          Write(item.HinhThuc);

#line default
#line hidden
#nullable disable
>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5
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
                WriteLiteral("  \n");
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
                </div>
                <div class=""form-group"">
                    <label>Hình thức");
            WriteLiteral(@" : </label>
                    <input type=""text"" class=""form-control"" id=""txthtA""/> 
                </div>
                <div class=""form-group"">
                    <label>Mô tả</label>
                    <textarea rows=""5"" class=""form-control"" id=""txtmtA""></textarea>
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
<<<<<<< HEAD
#line 32 "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
=======
#line 67 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5
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
<<<<<<< HEAD
#line 49 "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
=======
#line 77 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
         foreach (LoaiQcDTO lqc in Model.lst)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"text-align:center\">\r\n                <td>");
#nullable restore
#line 80 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.MaLoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 81 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.HinhThuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 82 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 84 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                    foreach (var q in Model.lst1)
                  {
                        if(String.Compare(@q.MaLoai,@lqc.MaLoai) == 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                       Write(q.MaQc);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 89 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                        }
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eaa92174ea2df53aeec3672ec3c933272309a3015330", async() => {
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
            BeginWriteAttribute("onclick", " onclick=\"", 3675, "\"", 3721, 3);
            WriteAttributeValue("", 3685, "openModalLoaiQuangCao(\'", 3685, 23, true);
#nullable restore
#line 94 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
WriteAttributeValue("", 3708, lqc.MaLoai, 3708, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3719, "\')", 3719, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-outline-primary\" >Sửa</button>                   \r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3844, "\"", 3887, 3);
            WriteAttributeValue("", 3854, "deleteLoaiQuangCao(\'", 3854, 20, true);
#nullable restore
#line 95 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
WriteAttributeValue("", 3874, lqc.MaLoai, 3874, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3885, "\')", 3885, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\" >Xoá</button>\r\n                </td>\r\n            </tr>\n");
#nullable restore
#line 98 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n</table>\r\n");
#nullable restore
#line 101 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5
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
<<<<<<< HEAD
#line 60 "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
=======
#line 111 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
     foreach (LoaiQcDTO lqc in Model.lst)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"text-align:center\">\r\n                <td>");
#nullable restore
#line 114 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.MaLoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 115 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.HinhThuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 116 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 118 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                    foreach (var q in Model.lst1)
                  {
                        if(String.Compare(@q.MaLoai,@lqc.MaLoai) == 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                       Write(q.MaQc);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 123 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                        }
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eaa92174ea2df53aeec3672ec3c933272309a3020945", async() => {
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
            BeginWriteAttribute("onclick", " onclick=\"", 4975, "\"", 5021, 3);
            WriteAttributeValue("", 4985, "openModalLoaiQuangCao(\'", 4985, 23, true);
#nullable restore
#line 128 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
WriteAttributeValue("", 5008, lqc.MaLoai, 5008, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5019, "\')", 5019, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-outline-primary\" >Sửa</button>                   \r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5144, "\"", 5187, 3);
            WriteAttributeValue("", 5154, "deleteLoaiQuangCao(\'", 5154, 20, true);
#nullable restore
#line 129 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
WriteAttributeValue("", 5174, lqc.MaLoai, 5174, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5185, "\')", 5185, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\" >Xoá</button>\r\n                </td>\r\n            </tr>\n");
#nullable restore
#line 132 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 134 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5
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
        </div>
        <div class=""form-group"">
            <label>Mô tả</label>
            <textarea rows=""5"" class=""form-control"" id=""txtmt""></textarea>
        </div>
        <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary""  data-dismiss=""modal"">Close</button>
        <button type=""button"" onclick=""saveLoaiQuangCao()"" class=""btn btn-primary"">Save changes</button>
        </div>
    </div>
    ");
            WriteLiteral("</div>\r\n</div>");
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
