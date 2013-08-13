using System;

namespace Vend
{
	/// <summary>
	/// Register.
	/// </summary>
	public class Register : BaseApiObject
	{
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Vend.Register"/> should print the recept.
		/// </summary>
		/// <value><c>true</c> if it should print the recept; otherwise, <c>false</c>.</value>
		public string PrintRecept { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Vend.Register"/> should email the receipt.
		/// </summary>
		/// <value><c>true</c> if it should email the receipt; otherwise, <c>false</c>.</value>
		public string EmailReceipt { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Vend.Register"/> asks for note on save.
		/// </summary>
		/// <value><c>true</c> if asks for note on save; otherwise, <c>false</c>.</value>
		public string AskForNoteOnSave { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Vend.Register"/> prints a note on receipt.
		/// </summary>
		/// <value><c>true</c> if it prints a note on receipt; otherwise, <c>false</c>.</value>
		public string PrintNoteOnReceipt { get; set; }


		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Vend.Register"/> should ask for a user on sale.
		/// </summary>
		/// <value><c>true</c> if asks for a user on sale; otherwise, <c>false</c>.</value>
		public string AskForUserOnSale { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Vend.Register"/> show discounts on receipt.
		/// </summary>
		/// <value><c>true</c> if show discounts on receipt; otherwise, <c>false</c>.</value>
		public string ShowDiscountsOnReceipt { get; set; }

		/// <summary>
		/// Gets or sets the receipt header.
		/// </summary>
		/// <value>The receipt header.</value>
		public string ReceiptHeader { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Vend.Register"/> receipt is barcoded.
		/// </summary>
		/// <value><c>true</c> if receipt is barcoded; otherwise, <c>false</c>.</value>
		public string ReceiptBarcoded { get; set; }

		/// <summary>
		/// Gets or sets the receipt footer.
		/// </summary>
		/// <value>The receipt footer.</value>
		public string ReceiptFooter { get; set; }

		/// <summary>
		/// Gets or sets the receipt style class.
		/// </summary>
		/// <value>The receipt style class.</value>
		public string ReceiptStyleClass { get; set; }

		/// <summary>
		/// Gets or sets the invoice prefix.
		/// </summary>
		/// <value>The invoice prefix.</value>
		public string InvoicePrefix { get; set; }
	
		/// <summary>
		/// Gets or sets the invoice suffix.
		/// </summary>
		/// <value>The invoice suffix.</value>
		public string InvoiceSuffix { get; set; }

		/// <summary>
		/// Gets or sets the invoice sequence.
		/// </summary>
		/// <value>The invoice sequence.</value>
		public int InvoiceSequence { get; set; }


		/// <summary>
		/// Gets or sets the register open count sequence.
		/// </summary>
		/// <value>The register open count sequence.</value>
		public int RegisterOpenCountSequence { get; set; }

		/// <summary>
		/// Gets or sets the open time.
		/// </summary>
		/// <value>The open time.</value>
		public DateTime OpenTime { get; set; }

		/// <summary>
		/// Gets or sets the close time.
		/// </summary>
		/// <value>The close time.</value>
		public DateTime CloseTime { get; set; }

		// TODO: This is bullshit now
		public string QuickKeysTemplate { get; set; }

		// TODO: Load of crock. Fix it man!
		public string Receipt { get; set; }

	}
}
