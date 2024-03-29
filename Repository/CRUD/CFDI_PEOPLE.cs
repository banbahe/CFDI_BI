﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Repository
{
    partial class CFDI_PEOPLE
    {
        public List<CFDI_PEOPLE> List()
        {
            try
            {
                using (CFDIContext context = new CFDIContext())
                {
                    return context.CFDI_PEOPLE.Include(x => x.CFDI_ADDRESS).ToList<CFDI_PEOPLE>();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public bool AddSet()
        {
            bool flag = false;
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
                flag = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("CFDI_PEOPLE AddSet {0}  ==> {1}", ex.Message, ex.InnerException));
            }
            return flag;
        }
        public bool Exist()
        {
            bool flag = false;
            try
            {
                using (CFDIContext context = new CFDIContext())
                {
                    flag = context.CFDI_PEOPLE.SingleOrDefault(x => x.RFC == this.RFC) == null ? false : true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return flag;
        }
        public CFDI_PEOPLE Get()
        {
            try
            {
                using (CFDIContext context = new CFDIContext())
                {
                    if (this.Id > 0)
                    {
                        return context.CFDI_PEOPLE.Include(fk => fk.CFDI_ADDRESS)
                          .FirstOrDefault(x => x.Id == this.Id);
                    }
                    if (string.IsNullOrEmpty(this.RFC))
                    {
                        throw new Exception("Es requerido el RFC");
                    }
                    else if (this.RFC == "XAXX010101000" || this.RFC == "XEXX010101000")
                    {
                        return null;
                    }

                    else
                    {
                        return context.CFDI_PEOPLE.Include(fk => fk.CFDI_ADDRESS)
                              .FirstOrDefault(x => x.RFC == this.RFC && x.Tipo == this.Tipo);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            return null;
        }

    }
}
