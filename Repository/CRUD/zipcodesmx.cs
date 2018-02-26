using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    partial class zipcodesmx
    {
        public List<zipcodesmx> List()
        {
            try
            {
                using (CFDIContext context = new CFDIContext())
                {
                    if (!string.IsNullOrEmpty(this.codigo))
                        return context.zipcodesmxes.Where(x => x.codigo == this.codigo).ToList();

                    return context.zipcodesmxes.ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
