using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class Employee
{
	public Guid Id { get; set; }

	public string? UserName { get; set; }

	public Guid CompanyId { get; set; }

	public Guid DepartmentId { get; set; }

	public Guid? WorkplaceId { get; set; }

	public Guid StatusId { get; set; }

	public string RefNum { get; set; }

	public Guid TitleId { get; set; }

	public string? Initials { get; set; }

	public string IdNum { get; set; }

	public string Surname { get; set; }

	public string FullNames { get; set; }

	public DateTime DateOfBirth { get; set; }

	public Guid JobTitleId { get; set; }

	public Guid GenderId { get; set; }

	public Guid RaceId { get; set; }

	public Guid LanguageId { get; set; }

	public Guid CountryId { get; set; }

	public Guid JobLevelId { get; set; }

	public Guid? GradeId { get; set; }

	public string? PostalAddress { get; set; }

	public string? PostalSuburb { get; set; }

	public string? PostalCity { get; set; }

	public string? PostalCode { get; set; }

	public string? TelHome { get; set; }

	public string? TelWork { get; set; }

	public string? TelWorkExt { get; set; }

	public string? Fax { get; set; }

	public string? Cell { get; set; }

	public string? Email { get; set; }

	public byte[]? Photo { get; set; }

	public string? Notes { get; set; }

	public bool IsDeleted { get; set; }

	public Guid? EmployeeType { get; set; }

	public string? CustomField1 { get; set; }

	public string? CustomField2 { get; set; }

	public string? CustomField3 { get; set; }

	public virtual ICollection<AssessmentInstance> AssessmentInstances { get; set; } = new List<AssessmentInstance>();


	public virtual Company Company { get; set; }

	public virtual Country Country { get; set; }

	public virtual ICollection<CourseInstance> CourseInstanceEmployees { get; set; } = new List<CourseInstance>();


	public virtual ICollection<CourseInstance> CourseInstanceInstructors { get; set; } = new List<CourseInstance>();


	public virtual Department Department { get; set; }

	public virtual ICollection<EmployeeCompliance> EmployeeCompliances { get; set; } = new List<EmployeeCompliance>();


	public virtual ICollection<EmployeeImage> EmployeeImages { get; set; } = new List<EmployeeImage>();


	public virtual ICollection<EmployeeJobRequirement> EmployeeJobRequirements { get; set; } = new List<EmployeeJobRequirement>();


	public virtual EmployeeType? EmployeeTypeNavigation { get; set; }

	public virtual Gender Gender { get; set; }

	public virtual Grading? Grade { get; set; }

	public virtual JobLevel JobLevel { get; set; }

	public virtual JobTitle JobTitle { get; set; }

	public virtual Language Language { get; set; }

	public virtual ICollection<License> Licenses { get; set; } = new List<License>();


	public virtual ICollection<Ppeissue> Ppeissues { get; set; } = new List<Ppeissue>();


	public virtual Race Race { get; set; }

	public virtual ICollection<SmartClickCourse> SmartClickCourses { get; set; } = new List<SmartClickCourse>();


	public virtual EmployeeStatus Status { get; set; }

	public virtual Title Title { get; set; }

	public virtual ICollection<Training> Training { get; set; } = new List<Training>();


	public virtual ICollection<User> Users { get; set; } = new List<User>();


	public virtual Workplace? Workplace { get; set; }
}
