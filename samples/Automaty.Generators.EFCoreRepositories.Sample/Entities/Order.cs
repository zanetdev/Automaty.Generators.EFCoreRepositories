namespace Automaty.Generators.EFCoreRepositories.Sample.Entities
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Order
	{
		[Required]
		[StringLength(70, MinimumLength = 3)]
		public string Address { get; set; }

		[Required]
		[StringLength(40)]
		public string City { get; set; }

		[Required]
		[StringLength(40)]
		public string Country { get; set; }

		[Required]
		[Display(Name = "Email Address")]
		[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email is not valid.")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required]
		[Display(Name = "First Name")]
		[StringLength(160)]
		public string FirstName { get; set; }

		[Required]
		[Display(Name = "Last Name")]
		[StringLength(160)]
		public string LastName { get; set; }

		[ScaffoldColumn(false)]
		public DateTime OrderDate { get; set; }

		public List<OrderDetail> OrderDetails { get; set; }

		[ScaffoldColumn(false)]
		public int OrderId { get; set; }

		[Required]
		[StringLength(24)]
		[DataType(DataType.PhoneNumber)]
		public string Phone { get; set; }

		[Required]
		[Display(Name = "Postal Code")]
		[StringLength(10, MinimumLength = 5)]
		public string PostalCode { get; set; }

		[Required]
		[StringLength(40)]
		public string State { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal Total { get; set; }

		public string Username { get; set; }
	}
}