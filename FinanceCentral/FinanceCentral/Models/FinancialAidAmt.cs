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
    
    public partial class FinancialAidAmt
    {
        public string finAidName { get; set; }
        public string finAidType { get; set; }
        public Nullable<decimal> finAidAmount { get; set; }
    
        public virtual FinancialAidType FinancialAidType { get; set; }
    }
}