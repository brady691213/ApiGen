using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class SmartClickCourse
{
	public Guid Id { get; set; }

	public Guid LocalCourseId { get; set; }

	public string? CourseName { get; set; }

	public DateTime? CourseDate { get; set; }

	public string? Teacher { get; set; }

	public Guid? EmployeeId { get; set; }

	public DateTime? DateSynced { get; set; }

	public string? SyncedFrom { get; set; }

	public int? ValidityMonths { get; set; }

	public bool? IsDeleted { get; set; }

	public string? EmployeeRef { get; set; }

	public float? PassMark { get; set; }

	public string? Result { get; set; }

	public float? Score { get; set; }

	public bool? IsModerated { get; set; }

	public string? Moderator { get; set; }

	public Guid? ModeraredBy { get; set; }

	public string? ModeratorComments { get; set; }

	public DateTime? DateModerated { get; set; }

	public Guid? TemplateId { get; set; }

	public Guid? DesignCourseId { get; set; }

	public string? TestType { get; set; }

	public virtual ICollection<ESignature> ESignatures { get; set; } = new List<ESignature>();


	public virtual Employee? Employee { get; set; }

	public virtual ICollection<SmartClickCourseResponce> SmartClickCourseResponces { get; set; } = new List<SmartClickCourseResponce>();

}
