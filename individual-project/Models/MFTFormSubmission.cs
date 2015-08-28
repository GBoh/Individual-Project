using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Individual_project.Models
{
    public class MFTFormSubmission
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? ClockHours { get; set; }
        public IList<Event> Events { get; set; }
        public IList<Group> GroupLocations { get; set; }
        public IList<ObservableData> ObservableData { get; set; }
        public IList<Supervisor> Supervisors { get; set; }
        public string SupervisorEmail { get; set; }
        public bool SupervisorApproved { get; set; }
        public string SupervisorInitials { get; set; }
        public string Comments { get; set; }
    }
}