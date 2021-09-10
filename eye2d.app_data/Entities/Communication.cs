using eye2d.app_data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Entities
{
    public class Communication
    {
        public int Id { set; get; }
        public int UserId { set; get; }
        public float Chat { set; get; }
        public float Video { set; get; }
        public CommunicationStatus Status { set; get; }
        public object CommunicationStatus { get; internal set; }
    }
}
