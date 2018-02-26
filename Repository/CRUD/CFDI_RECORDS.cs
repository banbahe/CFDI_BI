using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Repository
{
    public partial class CFDI_RECORDS
    {

        public bool AddSet()
        {
            try
            {
                using (CFDIContext context = new CFDIContext())
                {
                    if (this.Id > 0)
                        context.Entry(this).State = EntityState.Modified;
                    else
                        context.Entry(this).State = EntityState.Added;

                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public bool Remove()
        {
            try
            {
                using (CFDIContext context = new CFDIContext())
                {
                    context.Entry(this).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return true;
        }

        public bool Exist()
        {
            bool flag;
            try
            {
                using (CFDIContext context = new CFDIContext())
                {
                    flag = context.CFDI_RECORDS.SingleOrDefault(x => x.UUID == this.UUID) == null ? false : true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Exist {0} detail: ", ex.Message, ex.InnerException.Message));
                flag = false;
            }
            return flag;
        }

        public List<CFDI_RECORDS> List()
        {
            try
            {
                using (CFDIContext context = new CFDIContext())
                {
                    return context.CFDI_RECORDS.ToList<CFDI_RECORDS>();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<CFDI_RECORDS> Get()
        {

            try
            {
                using (CFDIContext context = new CFDIContext())
                {
                    if (!string.IsNullOrEmpty(UUID))
                    {
                        return await context.CFDI_RECORDS.SingleOrDefaultAsync(x => x.UUID == UUID);
                    }

                    if (this.Id > 0)
                        return await context.CFDI_RECORDS.SingleOrDefaultAsync(x => x.Id == Id);

                }
                throw new Exception("No cumplio filtro");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }
        }

    }
}
