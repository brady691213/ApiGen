using System;

namespace CTSCore.Models;

public class Transaction
{
	public Guid Id { get; set; }

	public Guid? ContraId { get; set; }

	public Guid? ContraType { get; set; }

	public string? TransactionDescription { get; set; }

	public decimal? Amount { get; set; }

	public Guid? CurrnecyId { get; set; }

	public decimal? Debit { get; set; }

	public decimal? Credit { get; set; }

	public DateTime? TransactionDate { get; set; }

	public DateTime? DateCaptured { get; set; }

	public Guid? CapturedBy { get; set; }
}
