using System;

namespace SerialLogCore.Models
{
    public class EventModel
    {
        public Guid Guid { get { return Guid.NewGuid(); } }
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public DateTime DataLastUpdate { get { return DateTime.Now; } }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Local { get; set; }

    }
}
