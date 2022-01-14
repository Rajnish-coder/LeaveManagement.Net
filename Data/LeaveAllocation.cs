using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Net.Data
{
    public class LeaveAllocation: BaseEntity
    { 

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }

        public int LeaveTypeId { get; set; }
        public int NumberOfDays { get; set; }
        public string EmployeeId { get; set; }


    }
}
