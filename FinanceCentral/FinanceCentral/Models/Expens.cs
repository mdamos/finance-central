//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanceCentral.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Expens
    {
        public int expenseID { get; set; }
        public string expenseName { get; set; }
        public Nullable<decimal> amount { get; set; }
        public string category { get; set; }
        public string month { get; set; }
        public Nullable<int> day { get; set; }
        public Nullable<int> year { get; set; }
        public Nullable<int> incomeID { get; set; }
    
        public virtual Income Income { get; set; }
    }
}
