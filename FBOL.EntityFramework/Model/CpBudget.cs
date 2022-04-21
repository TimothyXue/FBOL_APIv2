using System;
using System.Collections.Generic;

#nullable disable

namespace FBOL.EntityFramework.Model
{
    public partial class CpBudget
    {
        public long ItemId { get; set; }
        public int ParticipantId { get; set; }
        public string Item { get; set; }
        public int? BudgetAllocated { get; set; }
        public int? Expenditure1 { get; set; }
        public int? Expenditure2 { get; set; }
        public int? Expenditure3 { get; set; }
        public int? Expenditure4 { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
