using System;

namespace Aplicatie_Salarizare.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
/*
 * 
 * f@oreach (var emp in ViewBag.Employees)
    <li>
        Nume - @emp.Lastname | Prenume - @emp.Surname | Functie - @emp.Position | Salariu de baza - @emp.Base_Salary Ron | Spor - @emp.Increase <br>
        Premii Brut - @emp.Gross_Prizes | Brut Total - @emp.Gross_Total | Brut impozitabil - @emp.Taxable_Gross | CAS - @emp.CAS | CASS - @emp.CASS <br>
        Impozit - @emp.Tax | Retineri - @emp.Deductions | Virat Card - @emp.Net_Salary
    </li>

<div class="container">
        <main role="main" class="pb-3" width="900px">
            @RenderBody()
        </main>
    </div>

 */