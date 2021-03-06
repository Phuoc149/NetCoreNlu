﻿using NetProject.Context;
using NetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetProject.DbAccessor
{
    public class BillData : DataProvider
    {
        public BillData(OurDbContext context) : base(context)
        {
        }
        public void AddBill(Bill bill) {
            _context.Bills.Add(bill);
            _context.SaveChanges();
        }
    }
}
