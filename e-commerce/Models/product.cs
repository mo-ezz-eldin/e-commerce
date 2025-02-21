namespace e_commerce.Models
{
	public class product
	{
		public int Id { get; set; }
		public int category_id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Price { get; set; }
		public int quatity { get; set; }
		public category cat { get; set; }
	}
}
