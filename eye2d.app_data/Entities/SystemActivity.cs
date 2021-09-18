using System;
using System.Collections.Generic;
using System.Text;

namespace eye2d.app_data.Entities
{
   public class SystemActivity
    {
        public int Id { set; get; }
        public string ActionName { set; get; }
        public DateTime ActionDate { set; get; }
        public int FunctionId { set; get; }
        public Guid UserId { set; get; }
        public int ClientIP { set; get; }

    }
}
