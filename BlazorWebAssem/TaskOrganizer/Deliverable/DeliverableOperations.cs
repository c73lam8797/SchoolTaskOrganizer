﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssem.TaskOrganizer.Deliverable
{
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
                return (new List<Deliverable> {new Deliverable()} ); 
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

        public void UpdateDeliverable (Deliverable deliverable)
        {
            try
            {
                d.Entry(deliverable).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                d.SaveChanges();
            }
            catch { }
        }

        public void DeleteDeliverable (Deliverable deliverable)
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
