#pragma checksum "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c2a7354a3503edb185244a7fb251ccc5f70cbe9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Nhom11.QLQC.Pages.Pages_HopDong), @"mvc.1.0.razor-page", @"/Pages/HopDong.cshtml")]
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
#line 1 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Nhom11.QLQC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Nhom11.QLQC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
using global::QLQC.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c2a7354a3503edb185244a7fb251ccc5f70cbe9", @"/Pages/HopDong.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b39bf525f09de2fceaa200944ecf09c0e81b8ae", @"/Pages/_ViewImports.cshtml")]
    public class Pages_HopDong : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    var dataHD = ");
#nullable restore
#line 8 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
            Write(Html.Raw(JsonSerializer.Serialize(Model.lst)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var dataStatic = ");
#nullable restore
#line 9 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
                Write(Html.Raw(JsonSerializer.Serialize(Model.lststatic)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var curPageHD = 1;\r\n    var totalPageHD = ");
#nullable restore
#line 11 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
                 Write(Html.Raw(Model.TotalPage));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</script>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c2a7354a3503edb185244a7fb251ccc5f70cbe94963", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-3 form-group"" style=""margin-left: 30px"">
            <label>Mã hợp đồng:</label>
            <input type=""text"" id=""mhd"" name=""mhd"" class=""form-control"" />
        </div>
        <div class=""col-3 form-group"" style=""margin-left: 30px"">
            <label>Mã nhân viên thực hiện: </label>
            <input type=""text"" id=""mnv"" name=""mnv"" class=""form-control"" />
        </div>
        <div class=""col-3 form-group"" style=""margin-left: 30px"">
            <label>Mã khách hàng: </label>
            <input type=""text"" id=""mkh"" name=""mkh"" class=""form-control"" />
        </div>
        <div class=""col-1 form-group"">
            <br />
            <input style=""margin-top: 5px;margin-left: 70px"" type=""submit"" class=""btn btn-primary"" value=""Tìm kiếm"" />
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
    <h2 style=""display: inline-block""><b>Danh sách Hợp đồng</b></h2>
    <input style=""float: right"" onclick=""openHopDong(null)"" type=""button"" class=""btn btn-outline-success"" value=""Thêm mới"" />
    <div style=""text-align:left"" id=""divModalAdd"" class=""modal"" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Hợp đồng - <span id=""spanidA""></span></h5>
                    <button type=""button"" class=""btn-close"" data-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""txtmhd"">Mã hợp đồng</label>
                        <input type=""text"" class=""form-control"" id=""txtmhdA"" aria-describedby=""Help"" placeholder=""Nhập mã hợp đồng"">
                    </div>
            ");
            WriteLiteral(@"        <div class=""form-group"">
                        <label for=""txtmnk"">Ngày ký </label>
                        <input type=""datetime-local"" class=""form-control"" id=""txtnkA"" />
                    </div>
                    <div class=""form-group"">
                        <label>Mã nhân viên</label>
                        <input type=""text"" class=""form-control"" id=""txtmnvA"" />
                    </div>
                    <div class=""form-group"">
                        <label>Mã khách hàng</label>
                        <input type=""text"" class=""form-control"" id=""txtmkhA"" />
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                        <button type=""button"" onclick=""addHopDong()"" class=""btn btn-outline-success"">Add</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
#nullable restore
#line 71 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
 if (Request.Method.ToUpper() == "GET")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-success table-condensed"">
        <tr style=""text-align:center"">
            <th>Mã hợp đồng</th>
            <th>Ngày ký kết</th>
            <th>Mã nhân viên thực hiện</th>
            <th>Mã đối tác</th>
            <th>Tác vụ</th>
        </tr>
        <tbody id=""tbodyHD"">
");
#nullable restore
#line 82 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
             foreach (HopDongDTO hd in Model.lst)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr id=\"trHd@hd.MaHd\" style=\"text-align:center\">\r\n                    <td>");
#nullable restore
#line 85 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
                   Write(hd.MaHD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 86 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
                   Write(hd.NgayKy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 87 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
                   Write(hd.MaNV);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 88 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
                   Write(hd.MaKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4016, "\"", 4050, 3);
            WriteAttributeValue("", 4026, "openHopDong(\'", 4026, 13, true);
#nullable restore
#line 90 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
WriteAttributeValue("", 4039, hd.MaHD, 4039, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4047, "\');", 4047, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Sửa</button>\r\n                        <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4143, "\"", 4186, 3);
            WriteAttributeValue("", 4153, "deleteHopDong(\'", 4153, 15, true);
#nullable restore
#line 91 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
WriteAttributeValue("", 4168, hd.MaHD.Trim(), 4168, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4183, "\';)", 4183, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Xóa</button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 94 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
    <nav aria-label=""Page navigation example"">
        <ul class=""pagination"">
            <li class=""page-item""><a class=""page-link"" href=""javascript:void(0)"" onclick=""goPrevHD()"">Previous</a></li>
            <li class=""page-item""><a class=""page-link"" href=""javascript:void(0)""> <span id=""spanCurPageHD"">1</span></a></li>
            <li class=""page-item""><a class=""page-link"" href=""javascript:void(0)"" onclick=""goNextHD()"">Next</a></li>
        </ul>
    </nav>
");
#nullable restore
#line 104 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
}

else if (Request.Method.ToUpper() == "POST")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-success table-condensed"">
        <tr  style=""text-align:center"">
            <th>Mã hợp đồng</th>
            <th>Ngày ký kết</th>
            <th>Mã nhân viên thực hiện</th>
            <th>Mã đối tác</th>
            <th>Tác vụ</th>
        </tr>
        <tbody id=""tbodyHD"">
");
#nullable restore
#line 117 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
             foreach (HopDongDTO hd in Model.lst)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"text-align:center\">\r\n                    <td>");
#nullable restore
#line 120 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
                   Write(hd.MaHD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 121 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
                   Write(hd.NgayKy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 122 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
                   Write(hd.MaNV);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 123 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
                   Write(hd.MaKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5517, "\"", 5551, 3);
            WriteAttributeValue("", 5527, "openHopDong(\'", 5527, 13, true);
#nullable restore
#line 125 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
WriteAttributeValue("", 5540, hd.MaHD, 5540, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5548, "\');", 5548, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Sửa</button>\r\n                        <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5644, "\"", 5687, 3);
            WriteAttributeValue("", 5654, "deleteHopDong(\'", 5654, 15, true);
#nullable restore
#line 126 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
WriteAttributeValue("", 5669, hd.MaHD.Trim(), 5669, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5684, "\';)", 5684, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Xóa</button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 129 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 132 "C:\QTM\QLQC.Nhom11\Nhom11.QLQC\Pages\HopDong.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""text-align:left"" id=""divModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Hợp đồng - <span id=""spanid""></span></h5>
                <button type=""button"" class=""btn-close"" data-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <div class=""form-group"">
                    <label for=""txtmhd"">Mã hợp đồng</label>
                    <input type=""text"" class=""form-control"" id=""txtmhd"" aria-describedby=""Help"" placeholder=""Nhập mã hợp đồng"">
                </div>
                <div class=""form-group"">
                    <label for=""txtnk"">Ngày ký </label>
                    <input type=""datetime-local"" class=""form-control"" id=""txtnk"" />
                </div>
                <div class=""form-group"">
                    <label>Mã nhân viên</label>
");
            WriteLiteral(@"                    <input type=""text"" class=""form-control"" id=""txtmnv"" />
                </div>
                <div class=""form-group"">
                    <label>Khách hàng</label>
                    <input type=""text"" class=""form-control"" id=""txtmkh"" />
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" onclick=""saveHopDong()"" class=""btn btn-primary"">Save changes</button>
                </div>
            </div>
        </div>
    </div>
</div>
<div style=""margin-left: 20%"">
    <div id=""columnchart_material"" style=""width: 800px; height: 500px;""></div>
</div>
<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
<script type=""text/javascript"">
      google.charts.load('current', {'packages':['bar']});
      google.charts.setOnLoadCallback(drawChart);
        function drawChart() {
        ");
            WriteLiteral(@"var dataC = [
            ['Year', 'Hợp đồng'],
        ];
        for(var i = 0; i < dataStatic.length;i++){
            var arr = [dataStatic[i].NgayKy,dataStatic[i].SoHopDong];
            dataC.push(arr);
        }
        var data = google.visualization.arrayToDataTable(dataC);
        var options = {
              chart: {
                title: 'Số hợp đồng đã kí của các năm',
              }
            };
        var chart = new google.charts.Bar(document.getElementById('columnchart_material'));
        chart.draw(data, google.charts.Bar.convertOptions(options));
    }
</script>
<script id=""hdTemplate"" type=""text/x-jquery-tmpl"">
    <tr id=""trHD_${maHD}"" style=""text-align:center"">
        <td>${maHD}</td>
        <td>${ngayKy}</td>
        <td>${maNV}</td>
        <td>${maKH}</td>
        <td>
            <button type=""button"" onclick=""openHopDong('${maHD}')"" class=""btn btn-outline-primary"">Sửa</button>
            <button type=""button"" onclick=""deleteHopDong('${maHD}')"" clas");
            WriteLiteral("s=\"btn btn-outline-danger\">Xoá</button>\r\n        </td>\r\n    </tr>\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nhom11.QLQC.Pages.HopDongModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.HopDongModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.HopDongModel>)PageContext?.ViewData;
        public Nhom11.QLQC.Pages.HopDongModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
