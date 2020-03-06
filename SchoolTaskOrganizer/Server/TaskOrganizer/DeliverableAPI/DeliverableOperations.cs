using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolTaskOrganizer.Shared.Models;

namespace SchoolTaskOrganizer.Server.TaskOrganizer.DeliverableAPI{
    public class DeliverableOperations
    {
        DeliverableContext d = new DeliverableContext();

        public IEnumerable<Deliverable> GetAllDeliverables()
        {
            try
            {
                return d._deliverable.ToList();
            }
            catch
            {
                Deliverable temp = new Deliverable();
                return (new List<Deliverable> { temp }  );
            }
        }

        public void AddDeliverable(Deliverable deliverable)
        {
            try
            {
                d._deliverable.Add(deliverable);
            }
            catch { }
        }

        public void UpdateDeliverable(Deliverable deliverable)
        {
            try
            {
                d.Entry(deliverable).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                d.SaveChanges();
            }
            catch { }
        }

        public void DeleteDeliverable(Deliverable deliverable)
        {
            try
            {
                d._deliverable.Remove(deliverable);
                d.SaveChanges();
            }
            catch { }
        }

    }
}
