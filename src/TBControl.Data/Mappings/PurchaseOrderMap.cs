﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TBControl.Business.Models;

namespace TBControl.Data.Mappings
{
    public class PurchaseOrderMap : IEntityTypeConfiguration<PurchaseOrder>
    {
        public void Configure(EntityTypeBuilder<PurchaseOrder> builder)
        {
            throw new NotImplementedException();
        }
    }
}