using System;

namespace CTSCore.Models;

public class TrainingIndexold
{
	public bool? DoesExpire { get; set; }

	public DateTime? ExpiryDate { get; set; }

	public bool? Expired { get; set; }

	public DateTime? DateCompleted { get; set; }

	public DateTime? DateStarted { get; set; }

	public DateTime? DateBooked { get; set; }

	public string? ModuleName { get; set; }

	public string RefNum { get; set; }

	public string? Initials { get; set; }

	public string IdNum { get; set; }

	public string Surname { get; set; }

	public string FullNames { get; set; }

	public Guid Id { get; set; }

	public string? Grading { get; set; }

	public string Name { get; set; }

	public string Race { get; set; }

	public bool? IsComplete { get; set; }

	public bool? IsCompetent { get; set; }

	public bool? IsProcessed { get; set; }

	public string? Workplace { get; set; }

	public string Gender { get; set; }

	public string Department { get; set; }

	public string? CourseName { get; set; }
}
