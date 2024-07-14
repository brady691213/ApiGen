using System;

namespace CTSCore.Models;

public class VwBookingEvent
{
	public Guid? BookingId { get; set; }

	public Guid? EventId { get; set; }

	public string? EventDescription { get; set; }

	public DateTime? StartDate { get; set; }

	public bool? IsClosed { get; set; }

	public bool? IsCanceled { get; set; }

	public int? ClassCount { get; set; }

	public int? MaxSeats { get; set; }

	public Guid? EmpId { get; set; }

	public string? EmpRef { get; set; }

	public string? ResourceName { get; set; }

	public int? BookingInt { get; set; }

	public Guid Id { get; set; }

	public Guid? Expr1 { get; set; }

	public DateTime? EndDate { get; set; }

	public int? MinSeats { get; set; }

	public bool? IsDocumentationOk { get; set; }

	public bool? IsPresent { get; set; }

	public Guid? Status { get; set; }

	public bool? IsTransferred { get; set; }

	public DateTime? TransferDate { get; set; }

	public string? Notes { get; set; }

	public bool? Expr2 { get; set; }

	public string? BookedFrom { get; set; }

	public string? BookedBy { get; set; }

	public DateTime? DateBooked { get; set; }

	public string? Idnumber { get; set; }

	public string? Occupation { get; set; }

	public string? Workplace { get; set; }

	public string? Gender { get; set; }

	public string? Race { get; set; }

	public string? Company { get; set; }
}
