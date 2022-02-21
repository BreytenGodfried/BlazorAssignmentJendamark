using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssemblyLine4.Data;
using Microsoft.EntityFrameworkCore;

namespace AssemblyLine4.Services
{
    public class AssemblyLineServices
    {
        protected readonly AssemblyLineDbContext _dbcontext;
        public AssemblyLineServices(AssemblyLineDbContext _db)
        {
            _dbcontext = _db;
        }

        public async Task<List<Operation>> GetOperation()
        {
            var data = await _dbcontext.OPERATION.OrderBy(c=> c.OrderInWhichToPerform).ToListAsync();
            return data;
        }

        public async Task<List<Device>> GetDevices()
        {
            var data1 = await _dbcontext.DEVICE.ToListAsync();

            return data1;
        }

        public bool Insertrec(Operation op)
        {
         

            try
            {
                int maxOrder = _dbcontext.OPERATION.Max(p => p.OrderInWhichToPerform);
                op.OrderInWhichToPerform = maxOrder + 1;
            }
            catch
            {
                op.OrderInWhichToPerform = 1;
            }


            _dbcontext.OPERATION.Add(op);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool InsertDev(Device dev)
        {

            _dbcontext.DEVICE.Add(dev);
            _dbcontext.SaveChanges();
            
            return true;
        }

        public bool Editrec(Operation op, int id)
        {
            var operation = _dbcontext.OPERATION.Find(id);
            _dbcontext.Entry(operation).State = EntityState.Modified;
            _dbcontext.SaveChanges();
            return true;
        }


        public bool Deleterec(int id)
        {
            var op = _dbcontext.OPERATION.Where(d => d.OperationID == id).First();
            _dbcontext.OPERATION.Remove(op);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
