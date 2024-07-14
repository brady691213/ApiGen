using System;

namespace CTSCore.Models;

public class StudyAssistance
{
	public Guid Id { get; set; }

	public Guid? EmployeeId { get; set; }

	public Guid? CourseId { get; set; }

	public DateTime? DateAllocated { get; set; }

	public Guid? InstitutionId { get; set; }

	public DateTime? AcademicYear { get; set; }

	public decimal? BookCost { get; set; }

	public decimal? AccomodationCost { get; set; }

	public decimal? TutionFees { get; set; }

	public decimal? OtherFees { get; set; }

	public decimal? TotalCost { get; set; }

	public Guid? AgreementId { get; set; }

	public bool? IsCompleted { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }
}
