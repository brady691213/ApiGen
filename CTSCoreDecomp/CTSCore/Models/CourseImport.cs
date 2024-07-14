using System;

namespace CTSCore.Models;

public class CourseImport
{
	public int Id { get; set; }

	public string? CourseName { get; set; }

	public DateOnly? Startdate { get; set; }

	public DateOnly? Enddate { get; set; }

	public int? Minseat { get; set; }

	public int? MaxSeat { get; set; }
}
