using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HominiMVC.DAL
{
    public class POCContext : DbContext
    {
        public POCContext() : base("POCContext")
        {

        }
    }
}