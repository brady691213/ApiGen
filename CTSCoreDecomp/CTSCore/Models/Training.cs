using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class Training
{
	public Guid Id { get; set; }

	public Guid? EmployeeId { get; set; }

	public string? ModuleName { get; set; }

	public Guid? ModuleId { get; set; }

	public DateTime? DateBooked { get; set; }

	public DateTime? DateStarted { get; set; }

	public DateTime? DateCompleted { get; set; }

	public DateTime? DateCaptured { get; set; }

	public Guid? CapturedBy { get; set; }

	public Guid? ProviderId { get; set; }

	public string? ProviderName { get; set; }

	public Guid? CourseTypeId { get; set; }

	public Guid? CostAllocation { get; set; }

	public bool? IsBudget { get; set; }

	public bool? IsPayback { get; set; }

	public bool? Expired { get; set; }

	public DateTime? ExpiryDate { get; set; }

	public bool? DoesExpire { get; set; }

	public decimal? CourseCost { get; set; }

	public decimal? AccomodationCost { get; set; }

	public decimal? TravelCost { get; set; }

	public decimal? OtherCost { get; set; }

	public decimal? TotalCost { get; set; }

	public bool? IsCompetent { get; set; }

	public bool? IsProcessed { get; set; }

	public bool? IsComplete { get; set; }

	public Guid? ChannelId { get; set; }

	public Guid? BatchId { get; set; }

	public string? BatchDescription { get; set; }

	public int? TdaysPractical { get; set; }

	public int? TdaysTheoretical { get; set; }

	public virtual TrainingChannel? Channel { get; set; }

	public virtual CostCentre? CostAllocationNavigation { get; set; }

	public virtual TrainingType? CourseType { get; set; }

	public virtual Employee? Employee { get; set; }

	public virtual TrainingCourse? Module { get; set; }

	public virtual TrainingProvider? Provider { get; set; }

	public virtual ICollection<TrainingModule> TrainingModules { get; set; } = new List<TrainingModule>();

}
