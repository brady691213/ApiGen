using System;

namespace CTSCore.Models;

public class Resource
{
	public Guid Id { get; set; }

	public Guid? EventId { get; set; }

	public Guid? EmpId { get; set; }

	public string? EmpRef { get; set; }

	public string? ResourceName { get; set; }

	public int? Color { get; set; }

	public byte[]? Image { get; set; }

	public string? CustomField1 { get; set; }

	public bool? IsDocumentationOk { get; set; }

	public bool? IsPresent { get; set; }

	public Guid? Status { get; set; }

	public bool? IsTransferred { get; set; }

	public DateTime? TransferDate { get; set; }

	public string? Notes { get; set; }

	public bool? IsPlaceholder { get; set; }

	public bool? IsClosed { get; set; }

	public string? BookedFrom { get; set; }

	public string? BookedBy { get; set; }

	public Guid? BookedById { get; set; }

	public DateTime? DateBooked { get; set; }

	public bool? IsDeleted { get; set; }

	public bool? IsRefresher { get; set; }

	public bool? IsInitial { get; set; }

	public string? Idnumber { get; set; }

	public string? Occupation { get; set; }

	public string? Workplace { get; set; }

	public string? Gender { get; set; }

	public string? Race { get; set; }

	public string? Company { get; set; }

	public virtual EventBooking? Event { get; set; }
}
