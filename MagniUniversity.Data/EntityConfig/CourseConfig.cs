﻿using MagniUniversity.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace MagniUniversity.Data.EntityConfig
{
    public class CourseConfig : EntityTypeConfiguration<Course>
    {
        public CourseConfig()
        {
            ToTable("course");

            HasKey(p => p.CourseId)
                .Property(p => p.CourseId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Computed);

            Property(p => p.Title)
                .IsRequired()
                .HasColumnType("varchar(100)");            
        }
    }
}
