using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TBControl.Business.Models;

namespace TBControl.Data.Mappings
{
    public class InstallmentTypeMap : IEntityTypeConfiguration<InstallmentType>
    {
        public void Configure(EntityTypeBuilder<InstallmentType> builder)
        {
            throw new NotImplementedException();
        }
    }
}
