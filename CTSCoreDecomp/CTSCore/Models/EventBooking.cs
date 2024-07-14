using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class EventBooking
{
	public Guid BookingId { get; set; }

	public int BookingInt { get; set; }

	public Guid EventId { get; set; }

	public string? EventDescription { get; set; }

	public DateTime? StartDate { get; set; }

	public DateTime? EndDate { get; set; }

	public Guid? LocationId { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public int? MinSeats { get; set; }

	public int? MaxSeats { get; set; }

	public int? Label { get; set; }

	public int? ClassCount { get; set; }

	public bool? IsClosed { get; set; }

	public bool? IsCanceled { get; set; }

	public virtual ICollection<Resource> Resources { get; set; } = new List<Resource>();

}
