using e_commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e_commerce.configurations
{
	public class product_config : IEntityTypeConfiguration<product>
	{
		public void Configure(EntityTypeBuilder<product> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x=>x.Id).IsRequired();
			builder.Property(x => x.Name).IsRequired().HasColumnType("varchar").HasMaxLength(100);
			builder.Property(x=>x.quatity).IsRequired();
			builder.Property(x => x.Price).IsRequired().HasColumnType("int");
			builder.Property(x => x.category_id).IsRequired();
			builder.Property(x => x.Description).IsRequired().HasColumnType("varchar").HasMaxLength(200);

		}
	}
}
