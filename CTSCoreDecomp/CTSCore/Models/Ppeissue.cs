using System;

namespace CTSCore.Models;

public class Ppeissue
{
	public Guid Id { get; set; }

	public Guid ItemId { get; set; }

	public Guid EmployeeId { get; set; }

	public Guid BatchId { get; set; }

	public DateOnly DateIssued { get; set; }

	public DateTime DateCaptured { get; set; }

	public Guid IssuedBy { get; set; }

	public Guid UserId { get; set; }

	public string? Size { get; set; }

	public Guid? SizeId { get; set; }

	public int QuantityIssued { get; set; }

	public bool? CollectedOld { get; set; }

	public string? ReasonOrNote { get; set; }

	public bool? SpecialPurpose { get; set; }

	public Guid? IssuedToEmployeeId { get; set; }

	public virtual Employee Employee { get; set; }

	public virtual Ppeitem Item { get; set; }
}
