using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class CoursePack
{
	public Guid Id { get; set; }

	public string? Name { get; set; }

	public string? Description { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public Guid? CreatedBy { get; set; }

	public DateTime? DateCreated { get; set; }

	public Guid? ModifiedBy { get; set; }

	public DateTime? DateModified { get; set; }

	public virtual ICollection<CoursePackTemplate> CoursePackTemplates { get; set; } = new List<CoursePackTemplate>();

}
