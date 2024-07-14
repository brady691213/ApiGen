using System;

namespace CTSCore.Models;

public class TrainingCredit
{
	public Guid TrainingCreditId { get; set; }

	public Guid? TrainingCourseId { get; set; }

	public Guid? CreditSourceId { get; set; }

	public Guid? CreditSourceChannel { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }
}
