#pragma checksum "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b0ed9821df150f6581d6d570ca4c3fcd8d385de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhoneMasters_Index), @"mvc.1.0.view", @"/Views/PhoneMasters/Index.cshtml")]
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
#line 1 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\_ViewImports.cshtml"
using MyWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\_ViewImports.cshtml"
using MyWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b0ed9821df150f6581d6d570ca4c3fcd8d385de", @"/Views/PhoneMasters/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4221c565102d6b4904ec52217f6417507a218be", @"/Views/_ViewImports.cshtml")]
    public class Views_PhoneMasters_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyWeb.Models.PhoneMaster>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgclass"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:300px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
  
    ViewData["Title"] = "比較清單";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    th {
        font-weight: bold;
        color: dodgerblue;
    }

    tr:not(:first-child):hover {
        background-color: lightgrey;
        border-bottom:3px solid black;
    }

    .imgclass:hover {
        -webkit-box-shadow: -3px 3px 5px #dddddd;
        -moz-box-shadow: -3px 3px 5px #dddddd;
        box-shadow: -3px 3px 5px #dddddd;
    }

    .del {
        cursor: pointer;
        position: relative;
        top: -100px;
        right: 0;
        color: skyblue;
    }

        .del:hover {
            background-color: lightgrey;
            border-radius: 5px;
        }

    .nice {
        font-style: italic;
        font-weight: bold;
        color: orangered;
        font-size: larger;
    }

    th {
        cursor: pointer;
    }

    .fc {
        border: dashed 3px grey;
    }
</style>



<div class=""container"">
    <main role=""main"" class=""pb-3"" style=""font-size:larger"">
        <h1>比較清單</h1>
        <br />

        <div class");
            WriteLiteral("=\"container\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b0ed9821df150f6581d6d570ca4c3fcd8d385de5745", async() => {
                WriteLiteral("\r\n                <table class=\"table col col-md-12\">\r\n                    <tbody class=\"col-lg-12 \">\r\n                        <tr>\r\n                            <th></th>\r\n");
#nullable restore
#line 65 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                             foreach (var item in Model)
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td class=\"justify-content-center\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2b0ed9821df150f6581d6d570ca4c3fcd8d385de6584", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1579, "~/images/", 1579, 9, true);
#nullable restore
#line 69 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
AddHtmlAttributeValue("", 1588, item.Image, 1588, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("                                    <i class=\"del far fa-trash-alt\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1809, "\"", 1842, 3);
                WriteAttributeValue("", 1819, "DeleteCompare(", 1819, 14, true);
#nullable restore
#line 71 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
WriteAttributeValue("", 1833, item.Id, 1833, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1841, ")", 1841, 1, true);
                EndWriteAttribute();
                WriteLiteral("></i>\r\n                                </td>\r\n");
#nullable restore
#line 73 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n                        <tr>\r\n                            <th>手機型號</th>\r\n");
#nullable restore
#line 77 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td class=\"justify-content-center\">");
#nullable restore
#line 79 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                              Write(item.PhoneType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 80 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n                        <tr>\r\n                            <th>廠牌</th>\r\n");
#nullable restore
#line 84 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td class=\"justify-content-center\">");
#nullable restore
#line 86 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                              Write(item.Brand);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 87 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n                        <tr>\r\n                            <th>發售時間</th>\r\n");
#nullable restore
#line 91 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td class=\"justify-content-center\">");
#nullable restore
#line 93 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                              Write(item.ReleaseDate.ToString("yyyy/MM"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 94 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n                        <tr>\r\n                            <th onclick=\"priceClick()\">官方價格<i class=\"fas fa-crown\"></i></th>\r\n");
#nullable restore
#line 98 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                              

                                int min = 1000000;
                                foreach (var item in Model)
                                {
                                    if (min > item.Price)
                                    {
                                        min = item.Price;
                                    }

                                }

                                foreach (var item in Model)
                                {
                                    if (item.Price == min)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td id=\"minPrice\" class=\"justify-content-center\">$ ");
#nullable restore
#line 114 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                                                      Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 115 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td class=\"justify-content-center\">$ ");
#nullable restore
#line 118 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                                        Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 119 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n                        <tr>\r\n                            <th>作業系統</th>\r\n");
#nullable restore
#line 125 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td class=\"justify-content-center\">");
#nullable restore
#line 127 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                              Write(item.RunSystem);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 128 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n                        <tr>\r\n                            <th>處理器型號</th>\r\n");
#nullable restore
#line 132 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td class=\"justify-content-center\">");
#nullable restore
#line 134 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                              Write(item.RunType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 135 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n                        <tr>\r\n                            <th onclick=\"ramClick()\">Ram<i class=\"fas fa-crown\"></i></th>\r\n");
#nullable restore
#line 139 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                              

                                int max = 0;
                                foreach (var item in Model)
                                {
                                    if (max < Convert.ToInt32(item.Ram))
                                    {
                                        max = Convert.ToInt32(item.Ram);
                                    }

                                }

                                foreach (var item in Model)
                                {
                                    if (int.Parse(item.Ram) == max)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td id=\"maxRam\" class=\"justify-content-center\">");
#nullable restore
#line 155 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                                                  Write(item.Ram);

#line default
#line hidden
#nullable disable
                WriteLiteral(" GB</td>\r\n");
#nullable restore
#line 156 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td class=\"justify-content-center\">");
#nullable restore
#line 159 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                                      Write(item.Ram);

#line default
#line hidden
#nullable disable
                WriteLiteral(" GB</td>\r\n");
#nullable restore
#line 160 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </tr>\r\n                        <tr>\r\n                            <th onclick=\"romClick()\">Rom<i class=\"fas fa-crown\"></i></th>\r\n");
#nullable restore
#line 167 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                              

                                int Rommax = 0;
                                foreach (var item in Model)
                                {
                                    if (Rommax < Convert.ToInt32(item.Rom))
                                    {
                                        Rommax = Convert.ToInt32(item.Rom);
                                    }

                                }

                                foreach (var item in Model)
                                {
                                    if (int.Parse(item.Rom) == Rommax)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td id=\"maxRom\" class=\"justify-content-center\">");
#nullable restore
#line 183 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                                                  Write(item.Rom);

#line default
#line hidden
#nullable disable
                WriteLiteral(" GB</td>\r\n");
#nullable restore
#line 184 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td class=\"justify-content-center\">");
#nullable restore
#line 187 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                                      Write(item.Rom);

#line default
#line hidden
#nullable disable
                WriteLiteral(" GB</td>\r\n");
#nullable restore
#line 188 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n                        <tr>\r\n                            <th onclick=\"batteryClick()\">電池容量<i class=\"fas fa-crown\"></i></th>\r\n");
#nullable restore
#line 194 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                              

                                int batmax = 0;
                                foreach (var item in Model)
                                {
                                    if (batmax < Convert.ToInt32(item.Battery))
                                    {
                                        batmax = Convert.ToInt32(item.Battery);
                                    }

                                }

                                foreach (var item in Model)
                                {
                                    if (int.Parse(item.Battery) == batmax)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td id=\"maxBattery\" class=\"justify-content-center\">");
#nullable restore
#line 210 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                                                      Write(item.Battery);

#line default
#line hidden
#nullable disable
                WriteLiteral(" mAh</td>\r\n");
#nullable restore
#line 211 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td class=\"justify-content-center\">");
#nullable restore
#line 214 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                                      Write(item.Battery);

#line default
#line hidden
#nullable disable
                WriteLiteral(" mAh</td>\r\n");
#nullable restore
#line 215 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n                        <tr>\r\n                            <th>螢幕解析度</th>\r\n");
#nullable restore
#line 221 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td class=\"justify-content-center\">");
#nullable restore
#line 223 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                              Write(item.ScreenRes);

#line default
#line hidden
#nullable disable
                WriteLiteral(" pixels</td>\r\n");
#nullable restore
#line 224 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n                        <tr>\r\n                            <th>主鏡頭畫素</th>\r\n");
#nullable restore
#line 228 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td class=\"justify-content-center\">");
#nullable restore
#line 230 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                              Write(item.BackCamRes);

#line default
#line hidden
#nullable disable
                WriteLiteral(" 萬畫素</td>\r\n");
#nullable restore
#line 231 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n                        <tr>\r\n                            <th>前置鏡頭畫素</th>\r\n");
#nullable restore
#line 235 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td class=\"justify-content-center\">");
#nullable restore
#line 237 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                              Write(item.FrontCamRes);

#line default
#line hidden
#nullable disable
                WriteLiteral(" 萬畫素</td>\r\n");
#nullable restore
#line 238 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n                        <tr>\r\n                            <th>傳輸埠</th>\r\n");
#nullable restore
#line 242 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td class=\"justify-content-center\">");
#nullable restore
#line 244 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                              Write(item.TransPort);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 245 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n                        <tr>\r\n                            <th onclick=\"wClick()\">手機重量<i class=\"fas fa-crown\"></i></th>\r\n");
#nullable restore
#line 249 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                              

                                int Wmin = 10000;
                                foreach (var item in Model)
                                {
                                    if (Wmin > int.Parse(item.Weight))
                                    {
                                        Wmin = int.Parse(item.Weight);
                                    }

                                }

                                foreach (var item in Model)
                                {
                                    if (int.Parse(item.Weight) == Wmin)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td id=\"minWeight\" class=\"justify-content-center\">");
#nullable restore
#line 265 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                                                     Write(item.Weight);

#line default
#line hidden
#nullable disable
                WriteLiteral(" g</td>\r\n");
#nullable restore
#line 266 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td class=\"justify-content-center\">");
#nullable restore
#line 269 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                                                      Write(item.Weight);

#line default
#line hidden
#nullable disable
                WriteLiteral(" g</td>\r\n");
#nullable restore
#line 270 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </main>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
            var fcbool = true;
            var rambool = true;
            function ramClick() {
                if (rambool) {
                    $(""#maxRam"").addClass(""nice"");
                    rambool = false;
                }
                else {
                    $(""#maxRam"").removeClass(""nice"");
                    rambool = true;
                }
            }

        var rombool = true;
        function romClick() {
            if (rombool) {
                $(""#maxRom"").addClass(""nice"");
                rombool = false;
            }
            else {
                $(""#maxRom"").removeClass(""nice"");
                rombool = true;
            }
        }

            var pricebool = true;
            function priceClick() {
                if (pricebool) {
                    $(""#minPrice"").addClass(""nice"");
                    pricebool = false;
                }
                else {
                    $(""#minPrice"").removeClass(""nice"");");
                WriteLiteral(@"
                    pricebool = true;
                }
            }

        var batbool = true;
        function batteryClick() {
            if (batbool) {
                $(""#maxBattery"").addClass(""nice"");
                batbool = false;
            }
            else {
                $(""#maxBattery"").removeClass(""nice"");
                batbool = true;
            }
        }

        var wbool = true;
        function wClick() {
            if (wbool) {
                $(""#minWeight"").addClass(""nice"");
                wbool = false;
            }
            else {
                $(""#minWeight"").removeClass(""nice"");
                wbool = true;
            }
        }

        //$(""th"").click(function () {
        //    if (fcbool) {
        //        $(this).parent().addClass(""fc"");
        //        fcbool = false;
        //    } else {
        //        $(this).parent().removeClass(""fc"");
        //        fcbool = true;
        //    }
        //});


");
                WriteLiteral(@"


        function DeleteCompare(pid) {
                swal({
                    title: '確認移出清單?',
                    type: 'question',
                    showCancelButton: true,
                    cancelButtonText: '取消',
                    confirmButtonText: '確定',
                    //focusConfirm: false,
                    //async: false,
                }).then(function (result) {
                    if (result) {
                        fetch(`");
#nullable restore
#line 373 "D:\coding\Project\李路亞-MVC_MatchMyPhone\MyWeb\MyWeb\Views\PhoneMasters\Index.cshtml"
                          Write(Url.Content("~/api/MyProductLists/delete"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/${pid}`)
                            .then(response => {
                                if (response.statusText == ""OK"") {
                                    location.reload();
                                }
                            })
                            //FETCH後.then要用箭頭函式，不然執行序會亂掉
                            //.then(
                            //    item => {
                            //        console.log(item);
                            //        location.reload();
                            //    }
                            //);
                    }
                });

        };
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyWeb.Models.PhoneMaster>> Html { get; private set; }
    }
}
#pragma warning restore 1591
