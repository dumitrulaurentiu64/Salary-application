#pragma checksum "C:\OneDrive\OneDrive - Arggo\Desktop\SA\Aplicatie Salarizare\Aplicatie Salarizare\Views\Home\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74195264d587118d1bc9e89f0333bb1611221f05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Delete), @"mvc.1.0.view", @"/Views/Home/Delete.cshtml")]
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
#line 1 "C:\OneDrive\OneDrive - Arggo\Desktop\SA\Aplicatie Salarizare\Aplicatie Salarizare\Views\_ViewImports.cshtml"
using Aplicatie_Salarizare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\OneDrive\OneDrive - Arggo\Desktop\SA\Aplicatie Salarizare\Aplicatie Salarizare\Views\_ViewImports.cshtml"
using Aplicatie_Salarizare.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74195264d587118d1bc9e89f0333bb1611221f05", @"/Views/Home/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca85c01ce6ace39814f595faba08521c0265fa8a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Aplicatie_Salarizare.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\OneDrive\OneDrive - Arggo\Desktop\SA\Aplicatie Salarizare\Aplicatie Salarizare\Views\Home\Delete.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--");
            WriteLiteral(@"@using (Html.BeginForm(""delete"", ""home""))
    {-->
<div id=""main-cntn"">
    <div class=""text-center"">
        <h2 class=""display-4"">Stergere Angajati</h2>
    </div>
    <div class=""row"" style=""margin-left: 165px;"">
        <div class=""col-md-3"">
            <p>
                <label name=""surname"">Prenume</label>
                <input id=""surname"" name=""surname"" type=""text""");
            BeginWriteAttribute("value", " value =\"", 555, "\"", 564, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control"" placeholder=""Introdu prenumele angajatului..."" />
            </p>
        </div>

        <div class=""col-md-3"">
            <p>
                <label for=""lastname"">Nume</label>
                <input id=""lastname"" name=""lastname"" type=""text""");
            BeginWriteAttribute("value", " value =\"", 839, "\"", 848, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" placeholder=\"Introdu numele angajatului...\" />\r\n            </p>\r\n        </div>\r\n\r\n        <div class=\"col-md-3\">\r\n            <div class=\"add-btn\">\r\n                <a class=\"button-search\"");
            BeginWriteAttribute("href", " href=\"", 1062, "\"", 1098, 1);
#nullable restore
#line 30 "C:\OneDrive\OneDrive - Arggo\Desktop\SA\Aplicatie Salarizare\Aplicatie Salarizare\Views\Home\Delete.cshtml"
WriteAttributeValue("", 1069, Url.Action("Delete", "Home"), 1069, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cautare angajat</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <br />\r\n\r\n    <div class=\"employees\">\r\n");
#nullable restore
#line 37 "C:\OneDrive\OneDrive - Arggo\Desktop\SA\Aplicatie Salarizare\Aplicatie Salarizare\Views\Home\Delete.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\OneDrive\OneDrive - Arggo\Desktop\SA\Aplicatie Salarizare\Aplicatie Salarizare\Views\Home\Delete.cshtml"
             if (@Model.First().Lastname == "UserNotFound")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <script>\r\n                    alert(\"Angajatul nu a fost gasit!\");\r\n                </script>\r\n");
#nullable restore
#line 44 "C:\OneDrive\OneDrive - Arggo\Desktop\SA\Aplicatie Salarizare\Aplicatie Salarizare\Views\Home\Delete.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table id=""content-table"" style=""margin-left: 50px;"">
                    <thead>
                        <tr>
                            <th>Prenume</th>
                            <th>Nume</th>
                            <th>Functie</th>
                            <th>Salariu de baza</th>
                            <th>Spor</th>
                            <th>Premii brute</th>
                            <th>Brut total</th>
                            <th>Brut Impozitabil</th>
                            <th>Retineri</th>
                            <th>Salariu Net</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 64 "C:\OneDrive\OneDrive - Arggo\Desktop\SA\Aplicatie Salarizare\Aplicatie Salarizare\Views\Home\Delete.cshtml"
                         foreach (var employee in Model)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\OneDrive\OneDrive - Arggo\Desktop\SA\Aplicatie Salarizare\Aplicatie Salarizare\Views\Home\Delete.cshtml"
                       Write(await Html.PartialAsync("_EmployeeDelete", employee));

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\OneDrive\OneDrive - Arggo\Desktop\SA\Aplicatie Salarizare\Aplicatie Salarizare\Views\Home\Delete.cshtml"
                                                                                 
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tbody>\r\n                </table>\r\n");
#nullable restore
#line 70 "C:\OneDrive\OneDrive - Arggo\Desktop\SA\Aplicatie Salarizare\Aplicatie Salarizare\Views\Home\Delete.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\OneDrive\OneDrive - Arggo\Desktop\SA\Aplicatie Salarizare\Aplicatie Salarizare\Views\Home\Delete.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>
<script>
    $('#main-cntn').on('click', '.add-btn a', function () {
        var lastname = $(""#lastname"").val();
        var surname = $(""#surname"").val();
        var notFirst = true;
        var url = $(this).attr('href');
        $('#main-cntn').load(url, { lastname: lastname, surname: surname, notFirst: notFirst});

        return false;
    })
</script>

<!--
<script>

    $(document).ready(function () {
        $(""#deleteform"").submit(function (e) {
            e.preventDefault();
            $.ajax({
                type: ""POST"",
                data: $('#deleteform').serialize(),
                success: function (response) {
                    alert(""success"");
                },
                error: function (response) {
                    alert(""error"");
                }
            });
        });
    }

    $(document).ready(function () {
        f@oreach (var item in Model)
            {
                <text>
                    emplo");
            WriteLiteral(@"yees.Lastname = 'i@tem.Lastname';
                </text>
             }


        $(""#searchBtn"").click(function (e) {
            var employees = new Array();
            f@oreach (var item in Model)
            {
                <text>
                    employees.Lastname = '");
            WriteLiteral("@i@tem.Lastname\';\r\n                    employees.Surname = \'");
            WriteLiteral("@i@tem.Lastname\';\r\n                    employees.Position = \'");
            WriteLiteral("@i@tem.Lastname\';\r\n                    employees.Base_Salary = \'");
            WriteLiteral("@it@em.Lastname\';\r\n                    employees.Increase = \'");
            WriteLiteral("@item.Lastname\';\r\n                    employees.Gross_Prizes = \'");
            WriteLiteral("@item.Lastname\';\r\n                    employees.Gross_Total = \'");
            WriteLiteral("@item.Lastname\';\r\n                    employees.Taxable_Gross = \'");
            WriteLiteral("@item.Lastname\';\r\n                    employees.Deductions = \'");
            WriteLiteral(@"@item.Lastname';
                </text>
             }


        });
    });

    /*var lastname = $(""#lastname"").val();
    var surname = $(""#surname"").val();
    console.log(lastname, surname);

    //Create an input type dynamically.
    var element = document.createElement(""input"");

    //Create Labels
    var label = document.createElement(""Lastname"");
    label.innerHTML = ""New Label"";

    //Assign different attributes to the element.
    element.setAttribute(""type"", ""text"");
    element.setAttribute(""value"", surname);
    element.setAttribute(""name"", ""Test Name"");
    element.setAttribute(""style"", ""width:200px"");

    label.setAttribute(""style"", ""font-weight:normal"");

    // 'foobar' is the div id, where new fields are to be added
    var foo = document.getElementById(""content-table"");

    //Append the element in page (in span).
    foo.appendChild(label);
    foo.appendChild(element);*/
</script>



<div id=""content-table"">





<!--
u@sing (Html.BeginF");
            WriteLiteral(@"orm())
{
    <p>
        Surname: H@tml.TextBox(""Surname"") <br />
        Lastname: H@tml.TextBox(""Lastname"") <br />

        <input type=""submit"" id=""SubmitButton"" value=""Filter"" />
    </p>
}

<div id=""employeeTable"">
    if (Model != null)
    {
    foreach (var emp in Model)
    {
    await Html.PartialAsync(""_employeeTable"", emp)
    }
    }
</div>
-->
<!--


    /*
    $(document).ready(function () {
        var formData = form.serialize();
        $(""#deleteform"").submit(function (e) {
            var formData = form.serialize();
            e.preventDefault();
            $.ajax({
                type: ""POST"",
                url: U@rl.Action(""onSubmitEmployee"", ""Home""),
                data: formData,
                success: function (response) {
                    console.log(response);

                },
                error: function (response) {
                    alert(""error"")
                }
            });
        });
    });
    */
</script>");
            WriteLiteral(@"







<!--
<script type=""text/javascript"">
    var _url = ""/home/onSubmitEmployee""
    $(""#deleteform"").submit(function (e) {
        e.preventDefault();
        $.ajax({
            type: ""POST"",
            data: $('#deleteform').serialize(),
            success: function (response) {
                $('#employeeTable').load(_url);
                alert('success')
            },
            error: function (response) {
                alert(""error"")
            }
        });
    });
</script>

    u@sing (Html.BeginForm(""onSubmitEmployee"", ""home"", FormMethod.Post, new { id = ""deleteform"" }))
{
    <p>
        Surname: H@tml.TextBox(""Surname"") <br />
        Lastname: H@tml.TextBox(""Lastname"") <br />

        <input type=""submit"" id=""SubmitButton"" value=""Filter"" />
    </p>
}

    -->
<!--
using (Html.BeginForm())
{
    u@sing (Ajax.BeginForm(""onSubmitEmployee"", ""home"", new AjaxOptions { HttpMethod = ""POST"", UpdateTargetId = ""CreateAddress"", InsertionMode = Insertio");
            WriteLiteral(@"nMode.Replace }))
    Html.AntiForgeryToken();
    <div class=""row"" style=""margin-left: 50px;"">
        <div class=""col-md-3"">
            <p>
                <label name=""surname"">Prenume</label>
                <input id=""surname"" name=""surname"" type=""text"" class=""form-control"" placeholder=""Introdu prenumele angajatului..."" />
            </p>
        </div>

        <div class=""col-md-3"">
            <p>
                <label for=""lastname"">Nume</label>
                <input id=""lastname"" name=""lastname"" type=""text"" class=""form-control"" placeholder=""Introdu numele angajatului..."" />
            </p>
        </div>

        <div class=""col-md-3"">
            <div class=""add-btn"">
                <button type=""submit"" id=""SubmitButton"">Cauta angajat</button>
            </div>
        </div>
    </div>
}

<div id=""employeeTable"">
    Html.Partial(""_employeeTable"", Model)
</div>
<!--
<section id=""content-to-delete"">
    if (Model != null)
    {
        <h3 style=""margin-left:");
            WriteLiteral(@" 50px"">You should be able to see this message!</h3>

        <table id=""content-table"" style=""margin-left: 50px;"">
            <thead>
                <tr>
                    <th>Prenume</th>
                    <th>Nume</th>
                    <th>Functie</th>
                    <th>Salariu de baza</th>
                    <th>Spor</th>
                    <th>Premii brute</th>
                    <th>Brut total</th>
                    <th>Brut Impozitabil</th>
                    <th>Retineri</th>
                    <th>Salariu Net</th>
                </tr>
            </thead>
            <tbody>

                foreach (var emp in Model)
                {
                    <tr class=""table-row"">
                        <th>emp.Surname </th>
                        <th>emp.Lastname</th>
                        <th>emp.Position</th>
                        <th>emp.Base_Salary</th>
                        <th>emp.Increase</th>
                        <th>emp.Gross_Prizes</");
            WriteLiteral(@"th>
                        <th>emp.Gross_Total</th>
                        <th>emp.Taxable_Gross</th>
                        <th>emp.Deductions</th>
                        <th>emp.Net_Salary</th>
                    </tr>
                }
            </tbody>

        </table>
        }
</section>

<script type=""text/javascript"">
    $(""#main-content"").submit(function (e) {
        e.preventDefault();
        $.ajax({
            type: ""POST"",
            url: 'delete',
            data: $('#deleteform').serialize(),
            success: function (response) {
                alert('success')
            },
            error: function (response) {
                alert(""error"")
            }
        });
    });
</script>
<!--<script>
    $(function () {
        $('#main-content').on('click', '#subtm', function () {

            var url = $(this).attr('href');
            console.log(url);
            $('#main-content').load(url);

            return false;
        })");
            WriteLiteral(@"
    });

</script>-->

<style>
    .button-search {
        display: block;
        width: 200px;
        height: 38px;
        background: #4E9CAF;
        padding-top: 5px;
        text-align: center;
        margin-top: 15px;
        border-radius: 5px;
        color: white;
        font-weight: bold;
        line-height: 25px;
    }

    .text-center {
        margin-bottom: 50px;
        margin-right: 130px;
    }



    .col-md-3 {
        align-self: center;
    }

    #content-table {
        border: 1px solid;
    }

        #content-table th {
            min-width: 100px;
            text-align: center;
        }

        #content-table thead {
            border-bottom: 1px solid;
        }

    .table-row {
        padding-top: 25px;
    }
</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Aplicatie_Salarizare.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
