using System;
using System.Collections.Generic;

namespace Vend
{
	/// <summary>
	/// An item for sale.
	/// </summary>
	public class Product : BaseApiObject
	{
		/// <summary>
		/// Gets or sets the source identifier.
		/// </summary>
		/// <value>The source identifier.</value>
		public string SourceId { get; set; }

		/// <summary>
		/// Gets or sets the variant source identifier.
		/// </summary>
		/// <value>The variant source identifier.</value>
		public string VariantSourceId { get; set; }
		
		/// <summary>
		/// Gets or sets the handle.
		/// </summary>
		/// <value>The handle.</value>
		public string Handle { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>The type.</value>
		public string Type { get; set; }

		/// <summary>
		/// Gets or sets the variant parent identifier.
		/// </summary>
		/// <value>The variant parent identifier.</value>
		public string VariantParentId { get; set; }

		/// <summary>
		/// Gets or sets the name of the variant option one.
		/// </summary>
		/// <value>The name of the variant option one.</value>
		public string VariantOptionOneName { get; set; }

		/// <summary>
		/// Gets or sets the variant option one value.
		/// </summary>
		/// <value>The variant option one value.</value>
		public string VariantOptionOneValue { get; set; }

		/// <summary>
		/// Gets or sets the name of the variant option two.
		/// </summary>
		/// <value>The name of the variant option two.</value>
		public string VariantOptionTwoName { get; set; }

		/// <summary>
		/// Gets or sets the variant option two value.
		/// </summary>
		/// <value>The variant option two value.</value>
		public string VariantOptionTwoValue { get; set; }

		/// <summary>
		/// Gets or sets the name of the variant option three.
		/// </summary>
		/// <value>The name of the variant option three.</value>
		public string VariantOptionThreeName { get; set; }

		/// <summary>
		/// Gets or sets the variant option three value.
		/// </summary>
		/// <value>The variant option three value.</value>
		public string VariantOptionThreeValue { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Vend.Product"/> is active.
		/// </summary>
		/// <value><c>true</c> if active; otherwise, <c>false</c>.</value>
		public bool Active { get; set; }
		
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }
		
		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		/// <value>The description.</value>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the image.
		/// </summary>
		/// <value>The image.</value>
		public string Image { get; set; }

		/// <summary>
		/// Gets or sets the image large.
		/// </summary>
		/// <value>The image large.</value>
		public string ImageLarge { get; set; }

		/// <summary>
		/// Gets or sets the sku.
		/// </summary>
		/// <value>The sku.</value>
		public string Sku { get; set; }

		/// <summary>
		/// Gets or sets the source.
		/// </summary>
		/// <value>The source.</value>
		public string Source { get; set; }

		/// <summary>
		/// Gets or sets the tags.
		/// </summary>
		/// <value>The tags.</value>
		public string Tags { get; set; }

		/// <summary>
		/// Gets or sets the brand identifier.
		/// </summary>
		/// <value>The brand identifier.</value>
		public string BrandId { get; set; }

		/// <summary>
		/// Gets or sets the name of the brand.
		/// </summary>
		/// <value>The name of the brand.</value>
		public string BrandName { get; set; }

		/// <summary>
		/// Gets or sets the name of the supplier.
		/// </summary>
		/// <value>The name of the supplier.</value>
		public string SupplierName { get; set; }

		/// <summary>
		/// Gets or sets the supplier code.
		/// </summary>
		/// <value>The supplier code.</value>
		public string SupplierCode { get; set; }

		/// <summary>
		/// Gets or sets the supply price.
		/// </summary>
		/// <value>The supply price.</value>
		public float SupplyPrice { get; set; }

		/// <summary>
		/// Gets or sets the account code purchase.
		/// </summary>
		/// <value>The account code purchase.</value>
		public string AccountCodePurchase { get; set; }

		/// <summary>
		/// Gets or sets the account code sales.
		/// </summary>
		/// <value>The account code sales.</value>
		public string AccountCodeSales { get; set; }

		/// <summary>
		/// Gets or sets the brand.
		/// </summary>
		/// <value>The brand.</value>
		public ProductBrand Brand { get; set; }

		/// <summary>
		/// Gets or sets the inventory.
		/// </summary>
		/// <value>The inventory.</value>
		public List<ProductInventoryItem> Inventory { get; set; }

		/// <summary>
		/// Gets or sets the pricebook entries.
		/// </summary>
		/// <value>The pricebook entries.</value>
		public List<ProductPricebookEntry> PricebookEntries { get; set; }

		/// <summary>
		/// Gets or sets the price.
		/// </summary>
		/// <value>The price.</value>
		public float Price { get; set; }

		/// <summary>
		/// Gets or sets the tax value.
		/// </summary>
		/// <value>The tax value.</value>
		public float Tax { get; set; }

		/// <summary>
		/// Gets or sets the tax identifier.
		/// </summary>
		/// <value>The tax identifier.</value>
		public string TaxId { get; set; }

		/// <summary>
		/// Gets or sets the tax rate.
		/// </summary>
		/// <value>The tax rate.</value>
		public float TaxRate { get; set; }

		/// <summary>
		/// Gets or sets the name of the tax.
		/// </summary>
		/// <value>The name of the tax.</value>
		public string TaxName { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Vend.Product"/> displays retail price tax inclusive.
		/// </summary>
		/// <value><c>true</c> if display retail price tax inclusive; otherwise, <c>false</c>.</value>
		public bool DisplayRetailPriceTaxInclusive { get; set; }

		/// <summary>
		/// Gets or sets the updated at.
		/// </summary>
		/// <value>The updated at.</value>
		public DateTime UpdatedAt { get; set; }

		/// <summary>
		/// Gets or sets the deleted at.
		/// </summary>
		/// <value>The deleted at.</value>
		public DateTime DeletedAt { get; set; }
	}
}
