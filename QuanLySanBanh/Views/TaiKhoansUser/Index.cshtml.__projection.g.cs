//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Optimization;
using System.Web.Routing;
using QuanLySanBanh;

public class _Page_Views_TaiKhoansUser_Index_cshtml : System.Web.Mvc.WebViewPage<IEnumerable<QuanLySanBanh.Models.TaiKhoan>> {
private static object @__o;
#line hidden
public _Page_Views_TaiKhoansUser_Index_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
private void @__RazorDesignTimeHelpers__() {
#pragma warning disable 219

#line 1 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       IEnumerable<QuanLySanBanh.Models.TaiKhoan> __inheritsHelper = null;


#line default
#line hidden
#pragma warning restore 219
}
public override void Execute() {

#line 2 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout2.cshtml";


#line default
#line hidden

#line 3 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
__o = Html.ActionLink("Create New", "Create");


#line default
#line hidden

#line 4 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.TenTK);


#line default
#line hidden

#line 5 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.MatKhau);


#line default
#line hidden

#line 6 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.Email);


#line default
#line hidden

#line 7 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.HoTen);


#line default
#line hidden

#line 8 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.SDT);


#line default
#line hidden

#line 9 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.DiaChi);


#line default
#line hidden

#line 10 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.Vip);


#line default
#line hidden

#line 11 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.DiemTich);


#line default
#line hidden

#line 12 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayNameFor(model => model.Quyen);


#line default
#line hidden

#line 13 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
foreach (var item in Model) {
    

#line default
#line hidden

#line 14 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.TenTK);


#line default
#line hidden

#line 15 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.MatKhau);


#line default
#line hidden

#line 16 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.Email);


#line default
#line hidden

#line 17 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.HoTen);


#line default
#line hidden

#line 18 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.SDT);


#line default
#line hidden

#line 19 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.DiaChi);


#line default
#line hidden

#line 20 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.Vip);


#line default
#line hidden

#line 21 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.DiemTich);


#line default
#line hidden

#line 22 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.DisplayFor(modelItem => item.Quyen);


#line default
#line hidden

#line 23 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.ActionLink("Edit", "Edit", new { id=item.MaTK });


#line default
#line hidden

#line 24 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.ActionLink("Details", "Details", new { id=item.MaTK });


#line default
#line hidden

#line 25 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
       __o = Html.ActionLink("Delete", "Delete", new { id=item.MaTK });


#line default
#line hidden

#line 26 "C:\Users\anhla\AppData\Local\Temp\6AAA22EDCCC09F98D58EB2BFF1C8ABDE01FA\2\QuanLySanBanh\QuanLySanBanh\Views\TaiKhoansUser\Index.cshtml"
         
}

#line default
#line hidden
}
}
}
