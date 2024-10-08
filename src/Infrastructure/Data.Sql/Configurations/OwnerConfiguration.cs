﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Data.Sql.Configurations
{
    public class OwnerConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.ToTable("Owners");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(o => o.LastName).IsRequired().HasMaxLength(50);
            builder.Property(o => o.PhoneNumber).IsRequired().HasMaxLength(20);
            builder.Property(o => o.Email).HasMaxLength(100);

        }

        //private static bool IsValidEmail(string email)
        //{
        //    if (string.IsNullOrWhiteSpace(email)) return false;
        //    try
        //    {
        //        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase,
        //            TimeSpan.FromMicroseconds(250));
        //    }
        //    catch (RegexMatchTimeoutException ex)
        //    {
        //        return false;
        //    }
        //}
    }
}
