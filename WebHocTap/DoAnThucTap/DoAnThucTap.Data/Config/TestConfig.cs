using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnThucTap.Data.Entites;

namespace DoAnThucTap.Data.Config
{
    public class TestConfig : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.HasOne(m => m.lesson)
            .WithMany(m => m.tests)
            .HasForeignKey(m => m.IdLesson);
        }
    }
}
