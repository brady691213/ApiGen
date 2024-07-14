using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CTSCore.Models;

public class CTSDBContext : DbContext
{
	public virtual DbSet<Activeemp> Activeemps { get; set; }

	public virtual DbSet<ApplicationLicense> ApplicationLicenses { get; set; }

	public virtual DbSet<Appointment> Appointments { get; set; }

	public virtual DbSet<AssessmentEvidence> AssessmentEvidences { get; set; }

	public virtual DbSet<AssessmentInstance> AssessmentInstances { get; set; }

	public virtual DbSet<AssessmentInstanceIndex> AssessmentInstanceIndices { get; set; }

	public virtual DbSet<AssessmentInstanceOutcome> AssessmentInstanceOutcomes { get; set; }

	public virtual DbSet<AssessmentInstanceResultDetail> AssessmentInstanceResultDetails { get; set; }

	public virtual DbSet<AssessmentInstanceResultSummary> AssessmentInstanceResultSummaries { get; set; }

	public virtual DbSet<AssessmentInstanceSection> AssessmentInstanceSections { get; set; }

	public virtual DbSet<AssessmentInstanceSpecificOutcome> AssessmentInstanceSpecificOutcomes { get; set; }

	public virtual DbSet<AssessmentPack> AssessmentPacks { get; set; }

	public virtual DbSet<AssessmentPackTemplate> AssessmentPackTemplates { get; set; }

	public virtual DbSet<AssessmentResult> AssessmentResults { get; set; }

	public virtual DbSet<AssessmentStatus> AssessmentStatuses { get; set; }

	public virtual DbSet<AssessmentTemplate> AssessmentTemplates { get; set; }

	public virtual DbSet<AssessmentTemplateIndex> AssessmentTemplateIndices { get; set; }

	public virtual DbSet<AssessmentTemplateOutcome> AssessmentTemplateOutcomes { get; set; }

	public virtual DbSet<AssessmentTemplateSection> AssessmentTemplateSections { get; set; }

	public virtual DbSet<AssessmentTemplateSpecificOutcome> AssessmentTemplateSpecificOutcomes { get; set; }

	public virtual DbSet<AtrQualification> AtrQualifications { get; set; }

	public virtual DbSet<AtrSpecialisation> AtrSpecialisations { get; set; }

	public virtual DbSet<AuditLog> AuditLogs { get; set; }

	public virtual DbSet<Company> Companies { get; set; }

	public virtual DbSet<Compliance> Compliances { get; set; }

	public virtual DbSet<ComplianceSaco> ComplianceSacos { get; set; }

	public virtual DbSet<ComplianceType> ComplianceTypes { get; set; }

	public virtual DbSet<ContentType> ContentTypes { get; set; }

	public virtual DbSet<CostCentre> CostCentres { get; set; }

	public virtual DbSet<Country> Countries { get; set; }

	public virtual DbSet<CourseImport> CourseImports { get; set; }

	public virtual DbSet<CourseInstance> CourseInstances { get; set; }

	public virtual DbSet<CourseInstanceContent> CourseInstanceContents { get; set; }

	public virtual DbSet<CourseInstanceEvent> CourseInstanceEvents { get; set; }

	public virtual DbSet<CourseInstanceExam> CourseInstanceExams { get; set; }

	public virtual DbSet<CourseInstanceIndex> CourseInstanceIndices { get; set; }

	public virtual DbSet<CourseInstanceQuestion> CourseInstanceQuestions { get; set; }

	public virtual DbSet<CoursePack> CoursePacks { get; set; }

	public virtual DbSet<CoursePackTemplate> CoursePackTemplates { get; set; }

	public virtual DbSet<CourseStructureItem> CourseStructureItems { get; set; }

	public virtual DbSet<CourseTemplate> CourseTemplates { get; set; }

	public virtual DbSet<CourseTemplateContent> CourseTemplateContents { get; set; }

	public virtual DbSet<CourseTemplateExam> CourseTemplateExams { get; set; }

	public virtual DbSet<CourseTemplateIndex> CourseTemplateIndices { get; set; }

	public virtual DbSet<CourseTemplateMaster> CourseTemplateMasters { get; set; }

	public virtual DbSet<CourseTemplateQuestion> CourseTemplateQuestions { get; set; }

	public virtual DbSet<CourseType> CourseTypes { get; set; }

	public virtual DbSet<CtsComplianceActive> CtsComplianceActives { get; set; }

	public virtual DbSet<CtsComplianceAllEmp> CtsComplianceAllEmps { get; set; }

	public virtual DbSet<Department> Departments { get; set; }

	public virtual DbSet<ESignature> ESignatures { get; set; }

	public virtual DbSet<Employee> Employees { get; set; }

	public virtual DbSet<EmployeeCompliance> EmployeeCompliances { get; set; }

	public virtual DbSet<EmployeeImage> EmployeeImages { get; set; }

	public virtual DbSet<EmployeeIndex> EmployeeIndices { get; set; }

	public virtual DbSet<EmployeeJobRequirement> EmployeeJobRequirements { get; set; }

	public virtual DbSet<EmployeeModule> EmployeeModules { get; set; }

	public virtual DbSet<EmployeeStatus> EmployeeStatuses { get; set; }

	public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }

	public virtual DbSet<Event> Events { get; set; }

	public virtual DbSet<EventBooking> EventBookings { get; set; }

	public virtual DbSet<EventStatus> EventStatuses { get; set; }

	public virtual DbSet<Gender> Genders { get; set; }

	public virtual DbSet<Grading> Gradings { get; set; }

	public virtual DbSet<JobLevel> JobLevels { get; set; }

	public virtual DbSet<JobTitle> JobTitles { get; set; }

	public virtual DbSet<JobTrainingRequirement> JobTrainingRequirements { get; set; }

	public virtual DbSet<Language> Languages { get; set; }

	public virtual DbSet<License> Licenses { get; set; }

	public virtual DbSet<LicenseApplication> LicenseApplications { get; set; }

	public virtual DbSet<LicenseApplicationIndex> LicenseApplicationIndices { get; set; }

	public virtual DbSet<LicenseEscalation> LicenseEscalations { get; set; }

	public virtual DbSet<LicenseLog> LicenseLogs { get; set; }

	public virtual DbSet<LicensePrintHistory> LicensePrintHistories { get; set; }

	public virtual DbSet<LicenseRestriction> LicenseRestrictions { get; set; }

	public virtual DbSet<LicenseStatus> LicenseStatuses { get; set; }

	public virtual DbSet<LicenseType> LicenseTypes { get; set; }

	public virtual DbSet<LicenseTypeAuthorisation> LicenseTypeAuthorisations { get; set; }

	public virtual DbSet<Permit> Permits { get; set; }

	public virtual DbSet<Ppeissue> Ppeissues { get; set; }

	public virtual DbSet<Ppeitem> Ppeitems { get; set; }

	public virtual DbSet<PreSetNote> PreSetNotes { get; set; }

	public virtual DbSet<PreSetNotesCategory> PreSetNotesCategories { get; set; }

	public virtual DbSet<Privilege> Privileges { get; set; }

	public virtual DbSet<Race> Races { get; set; }

	public virtual DbSet<Report> Reports { get; set; }

	public virtual DbSet<ReportsWorkbench> ReportsWorkbenches { get; set; }

	public virtual DbSet<Resource> Resources { get; set; }

	public virtual DbSet<ResourceStatus> ResourceStatuses { get; set; }

	public virtual DbSet<Role> Roles { get; set; }

	public virtual DbSet<RoleUser> RoleUsers { get; set; }

	public virtual DbSet<RoleUserIndex> RoleUserIndices { get; set; }

	public virtual DbSet<ServerInstruction> ServerInstructions { get; set; }

	public virtual DbSet<SmartClickAnalysis> SmartClickAnalyses { get; set; }

	public virtual DbSet<SmartClickAnalysisJobTitle> SmartClickAnalysisJobTitles { get; set; }

	public virtual DbSet<SmartClickCourse> SmartClickCourses { get; set; }

	public virtual DbSet<SmartClickCourseQuestion> SmartClickCourseQuestions { get; set; }

	public virtual DbSet<SmartClickCourseResponce> SmartClickCourseResponces { get; set; }

	public virtual DbSet<SmartClickIndex> SmartClickIndices { get; set; }

	public virtual DbSet<SmartClickTemplate> SmartClickTemplates { get; set; }

	public virtual DbSet<SpecialRequest> SpecialRequests { get; set; }

	public virtual DbSet<SpecialRequestIndex> SpecialRequestIndices { get; set; }

	public virtual DbSet<StudyAssistance> StudyAssistances { get; set; }

	public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }

	public virtual DbSet<SystemConfiguration> SystemConfigurations { get; set; }

	public virtual DbSet<TaskItem> TaskItems { get; set; }

	public virtual DbSet<Title> Titles { get; set; }

	public virtual DbSet<Training> Training { get; set; }

	public virtual DbSet<TrainingChannel> TrainingChannels { get; set; }

	public virtual DbSet<TrainingCourse> TrainingCourses { get; set; }

	public virtual DbSet<TrainingCourseCategory> TrainingCourseCategories { get; set; }

	public virtual DbSet<TrainingCourseModule> TrainingCourseModules { get; set; }

	public virtual DbSet<TrainingCredit> TrainingCredits { get; set; }

	public virtual DbSet<TrainingCreditModule> TrainingCreditModules { get; set; }

	public virtual DbSet<TrainingEvent> TrainingEvents { get; set; }

	public virtual DbSet<TrainingIndex> TrainingIndices { get; set; }

	public virtual DbSet<TrainingIndexold> TrainingIndexolds { get; set; }

	public virtual DbSet<TrainingModule> TrainingModules { get; set; }

	public virtual DbSet<TrainingProvider> TrainingProviders { get; set; }

	public virtual DbSet<TrainingStatus> TrainingStatuses { get; set; }

	public virtual DbSet<TrainingType> TrainingTypes { get; set; }

	public virtual DbSet<Transaction> Transactions { get; set; }

	public virtual DbSet<UnitStandard> UnitStandards { get; set; }

	public virtual DbSet<User> Users { get; set; }

	public virtual DbSet<UserIndex> UserIndices { get; set; }

	public virtual DbSet<UserLayout> UserLayouts { get; set; }

	public virtual DbSet<UserPrivelagesIndex> UserPrivelagesIndices { get; set; }

	public virtual DbSet<UserPrivilage> UserPrivilages { get; set; }

	public virtual DbSet<VwBookingEvent> VwBookingEvents { get; set; }

	public virtual DbSet<VwEmployeeLicense> VwEmployeeLicenses { get; set; }

	public virtual DbSet<VwLicensesAll> VwLicensesAlls { get; set; }

	public virtual DbSet<WfworkItem> WfworkItems { get; set; }

	public virtual DbSet<WfworkType> WfworkTypes { get; set; }

	public virtual DbSet<WfworkitemIndex> WfworkitemIndices { get; set; }

	public virtual DbSet<Workplace> Workplaces { get; set; }

	public CTSDBContext()
	{
	}

	public CTSDBContext(DbContextOptions<CTSDBContext> options)
		: base((DbContextOptions)(object)options)
	{
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		SqlServerDbContextOptionsExtensions.UseSqlServer(optionsBuilder, "Server=4.221.211.38;Database=CTS2016Capture;User=ctscore;Password=ctscore;Encrypt=False;Trust Server Certificate=True", (Action<SqlServerDbContextOptionsBuilder>)null);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		RelationalModelBuilderExtensions.UseCollation(modelBuilder, "Latin1_General_CI_AS");
		modelBuilder.Entity<Activeemp>((Action<EntityTypeBuilder<Activeemp>>)delegate(EntityTypeBuilder<Activeemp> entity)
		{
			entity.HasNoKey();
			entity.Property<string>((Expression<Func<Activeemp, string>>)((Activeemp e) => e.EmpNumber)).HasMaxLength(255);
		});
		modelBuilder.Entity<ApplicationLicense>((Action<EntityTypeBuilder<ApplicationLicense>>)delegate(EntityTypeBuilder<ApplicationLicense> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<ApplicationLicense>(entity, "ApplicationLicense");
			entity.Property<Guid>((Expression<Func<ApplicationLicense, Guid>>)((ApplicationLicense e) => e.Id)).ValueGeneratedNever();
			RelationalForeignKeyBuilderExtensions.HasConstraintName<LicenseApplication, ApplicationLicense>(entity.HasOne<LicenseApplication>((Expression<Func<ApplicationLicense, LicenseApplication>>)((ApplicationLicense d) => d.Application)).WithMany((Expression<Func<LicenseApplication, IEnumerable<ApplicationLicense>>>)((LicenseApplication p) => p.ApplicationLicenses)).HasForeignKey((Expression<Func<ApplicationLicense, object>>)((ApplicationLicense d) => d.ApplicationId)), "FK_ApplicationLicense_LicenseApplication");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<LicenseType, ApplicationLicense>(entity.HasOne<LicenseType>((Expression<Func<ApplicationLicense, LicenseType>>)((ApplicationLicense d) => d.LicenceTypeNavigation)).WithMany((Expression<Func<LicenseType, IEnumerable<ApplicationLicense>>>)((LicenseType p) => p.ApplicationLicenses)).HasForeignKey((Expression<Func<ApplicationLicense, object>>)((ApplicationLicense d) => d.LicenceType)), "FK_ApplicationLicense_LicenseType");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<LicenseRestriction, ApplicationLicense>(entity.HasOne<LicenseRestriction>((Expression<Func<ApplicationLicense, LicenseRestriction>>)((ApplicationLicense d) => d.RestrictionTypeNavigation)).WithMany((Expression<Func<LicenseRestriction, IEnumerable<ApplicationLicense>>>)((LicenseRestriction p) => p.ApplicationLicenses)).HasForeignKey((Expression<Func<ApplicationLicense, object>>)((ApplicationLicense d) => d.RestrictionType)), "FK_ApplicationLicense_LicenseRestriction");
		});
		modelBuilder.Entity<Appointment>((Action<EntityTypeBuilder<Appointment>>)delegate(EntityTypeBuilder<Appointment> entity)
		{
			RelationalKeyBuilderExtensions.HasName(entity.HasKey((Expression<Func<Appointment, object>>)((Appointment e) => e.Id)), "PK_Appointments_1");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<Appointment, Guid>>)((Appointment e) => e.Id)).ValueGeneratedNever(), "ID");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<Appointment, DateTime?>>)((Appointment e) => e.EndDate)), "smalldatetime");
			entity.Property<string>((Expression<Func<Appointment, string>>)((Appointment e) => e.Location)).HasMaxLength(50);
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<Appointment, int?>>)((Appointment e) => e.ResourceId)), "ResourceID");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<Appointment, string>>)((Appointment e) => e.ResourceIds)), "ResourceIDs");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<Appointment, DateTime?>>)((Appointment e) => e.StartDate)), "smalldatetime");
			entity.Property<string>((Expression<Func<Appointment, string>>)((Appointment e) => e.Subject)).HasMaxLength(50);
		});
		modelBuilder.Entity<AssessmentEvidence>((Action<EntityTypeBuilder<AssessmentEvidence>>)delegate(EntityTypeBuilder<AssessmentEvidence> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<AssessmentEvidence>(entity, "AssessmentEvidence");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<AssessmentEvidence, Guid>>)((AssessmentEvidence e) => e.Id)).ValueGeneratedNever(), "ID");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<AssessmentEvidence, Guid?>>)((AssessmentEvidence e) => e.AssessmentInstanceId)), "AssessmentInstanceID");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<AssessmentEvidence, Guid?>>)((AssessmentEvidence e) => e.AssessmentOutcomeId)), "AssessmentOutcomeID");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<AssessmentEvidence, DateTime?>>)((AssessmentEvidence e) => e.ImageDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<string>(entity.Property<string>((Expression<Func<AssessmentEvidence, string>>)((AssessmentEvidence e) => e.ImageNotes)), "text");
			RelationalPropertyBuilderExtensions.HasColumnType<byte[]>(entity.Property<byte[]>((Expression<Func<AssessmentEvidence, byte[]>>)((AssessmentEvidence e) => e.Picture)), "image");
			entity.Property<string>((Expression<Func<AssessmentEvidence, string>>)((AssessmentEvidence e) => e.TakenBy)).HasMaxLength(50).IsUnicode(false);
			RelationalForeignKeyBuilderExtensions.HasConstraintName<AssessmentInstanceOutcome, AssessmentEvidence>(entity.HasOne<AssessmentInstanceOutcome>((Expression<Func<AssessmentEvidence, AssessmentInstanceOutcome>>)((AssessmentEvidence d) => d.AssessmentOutcome)).WithMany((Expression<Func<AssessmentInstanceOutcome, IEnumerable<AssessmentEvidence>>>)((AssessmentInstanceOutcome p) => p.AssessmentEvidences)).HasForeignKey((Expression<Func<AssessmentEvidence, object>>)((AssessmentEvidence d) => d.AssessmentOutcomeId)), "FK_AssessmentEvidence_AssessmentInstanceOutcomes");
		});
		modelBuilder.Entity<AssessmentInstance>((Action<EntityTypeBuilder<AssessmentInstance>>)delegate(EntityTypeBuilder<AssessmentInstance> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<AssessmentInstance, Guid>>)((AssessmentInstance e) => e.Id)), "(newid())");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime>(entity.Property<DateTime>((Expression<Func<AssessmentInstance, DateTime>>)((AssessmentInstance e) => e.BookingDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<AssessmentInstance, DateTime?>>)((AssessmentInstance e) => e.DateCheckedIn)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<AssessmentInstance, DateTime?>>)((AssessmentInstance e) => e.DateCheckedOut)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<AssessmentInstance, DateTime?>>)((AssessmentInstance e) => e.DateCompleted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<AssessmentInstance, DateTime?>>)((AssessmentInstance e) => e.DateModerated)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<AssessmentInstance, DateTime?>>)((AssessmentInstance e) => e.DateStarted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<AssessmentInstance, Guid?>>)((AssessmentInstance e) => e.EmployeeId1)), "Employee_Id");
			entity.Property<string>((Expression<Func<AssessmentInstance, string>>)((AssessmentInstance e) => e.Moderator)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<string>(entity.Property<string>((Expression<Func<AssessmentInstance, string>>)((AssessmentInstance e) => e.ModeratorComments)), "text");
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<AssessmentInstance, int?>>)((AssessmentInstance e) => e.OrderId)), "OrderID");
			entity.HasOne<AssessmentResult>((Expression<Func<AssessmentInstance, AssessmentResult>>)((AssessmentInstance d) => d.AssessmentResult)).WithMany((Expression<Func<AssessmentResult, IEnumerable<AssessmentInstance>>>)((AssessmentResult p) => p.AssessmentInstances)).HasForeignKey((Expression<Func<AssessmentInstance, object>>)((AssessmentInstance d) => d.AssessmentResultId));
			entity.HasOne<AssessmentStatus>((Expression<Func<AssessmentInstance, AssessmentStatus>>)((AssessmentInstance d) => d.AssessmentStatus)).WithMany((Expression<Func<AssessmentStatus, IEnumerable<AssessmentInstance>>>)((AssessmentStatus p) => p.AssessmentInstances)).HasForeignKey((Expression<Func<AssessmentInstance, object>>)((AssessmentInstance d) => d.AssessmentStatusId));
			entity.HasOne<AssessmentTemplate>((Expression<Func<AssessmentInstance, AssessmentTemplate>>)((AssessmentInstance d) => d.AssessmentTemplate)).WithMany((Expression<Func<AssessmentTemplate, IEnumerable<AssessmentInstance>>>)((AssessmentTemplate p) => p.AssessmentInstances)).HasForeignKey((Expression<Func<AssessmentInstance, object>>)((AssessmentInstance d) => d.AssessmentTemplateId));
			RelationalForeignKeyBuilderExtensions.HasConstraintName<User, AssessmentInstance>(entity.HasOne<User>((Expression<Func<AssessmentInstance, User>>)((AssessmentInstance d) => d.Assessor)).WithMany((Expression<Func<User, IEnumerable<AssessmentInstance>>>)((User p) => p.AssessmentInstances)).HasForeignKey((Expression<Func<AssessmentInstance, object>>)((AssessmentInstance d) => d.AssessorId)), "FK_AssessmentInstances_Users");
			entity.HasOne<Employee>((Expression<Func<AssessmentInstance, Employee>>)((AssessmentInstance d) => d.Employee)).WithMany((Expression<Func<Employee, IEnumerable<AssessmentInstance>>>)((Employee p) => p.AssessmentInstances)).HasForeignKey((Expression<Func<AssessmentInstance, object>>)((AssessmentInstance d) => d.EmployeeId));
		});
		modelBuilder.Entity<AssessmentInstanceIndex>((Action<EntityTypeBuilder<AssessmentInstanceIndex>>)delegate(EntityTypeBuilder<AssessmentInstanceIndex> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<AssessmentInstanceIndex>(entity.HasNoKey(), "AssessmentInstanceIndex");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime>(entity.Property<DateTime>((Expression<Func<AssessmentInstanceIndex, DateTime>>)((AssessmentInstanceIndex e) => e.BookingDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<AssessmentInstanceIndex, DateTime?>>)((AssessmentInstanceIndex e) => e.DateCompleted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<AssessmentInstanceIndex, DateTime?>>)((AssessmentInstanceIndex e) => e.DateModerated)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<AssessmentInstanceIndex, DateTime?>>)((AssessmentInstanceIndex e) => e.DateStarted)), "datetime");
			entity.Property<string>((Expression<Func<AssessmentInstanceIndex, string>>)((AssessmentInstanceIndex e) => e.Moderator)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<AssessmentInstanceIndex, Guid>>)((AssessmentInstanceIndex e) => e.UserId)), "userID");
			entity.Property<string>((Expression<Func<AssessmentInstanceIndex, string>>)((AssessmentInstanceIndex e) => e.UserName)).HasMaxLength(128);
		});
		modelBuilder.Entity<AssessmentInstanceOutcome>((Action<EntityTypeBuilder<AssessmentInstanceOutcome>>)delegate(EntityTypeBuilder<AssessmentInstanceOutcome> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<AssessmentInstanceOutcome, Guid>>)((AssessmentInstanceOutcome e) => e.Id)), "(newid())");
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<AssessmentInstanceOutcome, int?>>)((AssessmentInstanceOutcome e) => e.OrderId)), "OrderID");
			entity.HasOne<AssessmentInstanceSection>((Expression<Func<AssessmentInstanceOutcome, AssessmentInstanceSection>>)((AssessmentInstanceOutcome d) => d.AssessmentInstanceSection)).WithMany((Expression<Func<AssessmentInstanceSection, IEnumerable<AssessmentInstanceOutcome>>>)((AssessmentInstanceSection p) => p.AssessmentInstanceOutcomes)).HasForeignKey((Expression<Func<AssessmentInstanceOutcome, object>>)((AssessmentInstanceOutcome d) => d.AssessmentInstanceSectionId));
			entity.HasOne<AssessmentResult>((Expression<Func<AssessmentInstanceOutcome, AssessmentResult>>)((AssessmentInstanceOutcome d) => d.AssessmentResult)).WithMany((Expression<Func<AssessmentResult, IEnumerable<AssessmentInstanceOutcome>>>)((AssessmentResult p) => p.AssessmentInstanceOutcomes)).HasForeignKey((Expression<Func<AssessmentInstanceOutcome, object>>)((AssessmentInstanceOutcome d) => d.AssessmentResultId));
		});
		modelBuilder.Entity<AssessmentInstanceResultDetail>((Action<EntityTypeBuilder<AssessmentInstanceResultDetail>>)delegate(EntityTypeBuilder<AssessmentInstanceResultDetail> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<AssessmentInstanceResultDetail>(entity.HasNoKey(), "AssessmentInstanceResultDetails");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime>(entity.Property<DateTime>((Expression<Func<AssessmentInstanceResultDetail, DateTime>>)((AssessmentInstanceResultDetail e) => e.BookingDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime>(entity.Property<DateTime>((Expression<Func<AssessmentInstanceResultDetail, DateTime>>)((AssessmentInstanceResultDetail e) => e.DateCheckedIn)), "datetime");
		});
		modelBuilder.Entity<AssessmentInstanceResultSummary>((Action<EntityTypeBuilder<AssessmentInstanceResultSummary>>)delegate(EntityTypeBuilder<AssessmentInstanceResultSummary> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<AssessmentInstanceResultSummary>(entity.HasNoKey(), "AssessmentInstanceResultSummary");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime>(entity.Property<DateTime>((Expression<Func<AssessmentInstanceResultSummary, DateTime>>)((AssessmentInstanceResultSummary e) => e.BookingDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<AssessmentInstanceResultSummary, DateTime?>>)((AssessmentInstanceResultSummary e) => e.DateCheckedIn)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<AssessmentInstanceResultSummary, DateTime?>>)((AssessmentInstanceResultSummary e) => e.DateCompleted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<AssessmentInstanceResultSummary, DateTime?>>)((AssessmentInstanceResultSummary e) => e.DateStarted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<AssessmentInstanceResultSummary, Guid>>)((AssessmentInstanceResultSummary e) => e.EmployeeId)), "EmployeeID");
		});
		modelBuilder.Entity<AssessmentInstanceSection>((Action<EntityTypeBuilder<AssessmentInstanceSection>>)delegate(EntityTypeBuilder<AssessmentInstanceSection> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<AssessmentInstanceSection, Guid>>)((AssessmentInstanceSection e) => e.Id)), "(newid())");
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<AssessmentInstanceSection, int?>>)((AssessmentInstanceSection e) => e.OrderId)), "OrderID");
			entity.HasOne<AssessmentInstanceSpecificOutcome>((Expression<Func<AssessmentInstanceSection, AssessmentInstanceSpecificOutcome>>)((AssessmentInstanceSection d) => d.AssessmentInstanceSpecificOutcome)).WithMany((Expression<Func<AssessmentInstanceSpecificOutcome, IEnumerable<AssessmentInstanceSection>>>)((AssessmentInstanceSpecificOutcome p) => p.AssessmentInstanceSections)).HasForeignKey((Expression<Func<AssessmentInstanceSection, object>>)((AssessmentInstanceSection d) => d.AssessmentInstanceSpecificOutcomeId));
			entity.HasOne<AssessmentResult>((Expression<Func<AssessmentInstanceSection, AssessmentResult>>)((AssessmentInstanceSection d) => d.AssessmentResult)).WithMany((Expression<Func<AssessmentResult, IEnumerable<AssessmentInstanceSection>>>)((AssessmentResult p) => p.AssessmentInstanceSections)).HasForeignKey((Expression<Func<AssessmentInstanceSection, object>>)((AssessmentInstanceSection d) => d.AssessmentResultId));
		});
		modelBuilder.Entity<AssessmentInstanceSpecificOutcome>((Action<EntityTypeBuilder<AssessmentInstanceSpecificOutcome>>)delegate(EntityTypeBuilder<AssessmentInstanceSpecificOutcome> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<AssessmentInstanceSpecificOutcome, Guid>>)((AssessmentInstanceSpecificOutcome e) => e.Id)), "(newid())");
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<AssessmentInstanceSpecificOutcome, int?>>)((AssessmentInstanceSpecificOutcome e) => e.OrderId)), "OrderID");
			entity.HasOne<AssessmentInstance>((Expression<Func<AssessmentInstanceSpecificOutcome, AssessmentInstance>>)((AssessmentInstanceSpecificOutcome d) => d.AssessmentInstance)).WithMany((Expression<Func<AssessmentInstance, IEnumerable<AssessmentInstanceSpecificOutcome>>>)((AssessmentInstance p) => p.AssessmentInstanceSpecificOutcomes)).HasForeignKey((Expression<Func<AssessmentInstanceSpecificOutcome, object>>)((AssessmentInstanceSpecificOutcome d) => d.AssessmentInstanceId));
			entity.HasOne<AssessmentResult>((Expression<Func<AssessmentInstanceSpecificOutcome, AssessmentResult>>)((AssessmentInstanceSpecificOutcome d) => d.AssessmentResult)).WithMany((Expression<Func<AssessmentResult, IEnumerable<AssessmentInstanceSpecificOutcome>>>)((AssessmentResult p) => p.AssessmentInstanceSpecificOutcomes)).HasForeignKey((Expression<Func<AssessmentInstanceSpecificOutcome, object>>)((AssessmentInstanceSpecificOutcome d) => d.AssessmentResultId));
		});
		modelBuilder.Entity<AssessmentPack>((Action<EntityTypeBuilder<AssessmentPack>>)delegate(EntityTypeBuilder<AssessmentPack> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<AssessmentPack>(entity, "AssessmentPack");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<AssessmentPack, Guid>>)((AssessmentPack e) => e.Id)).ValueGeneratedNever(), "ID");
			entity.Property<string>((Expression<Func<AssessmentPack, string>>)((AssessmentPack e) => e.Description)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<AssessmentPack, string>>)((AssessmentPack e) => e.Name)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<AssessmentPack, string>>)((AssessmentPack e) => e.Test)).HasMaxLength(50).IsUnicode(false), "test");
		});
		modelBuilder.Entity<AssessmentPackTemplate>((Action<EntityTypeBuilder<AssessmentPackTemplate>>)delegate(EntityTypeBuilder<AssessmentPackTemplate> entity)
		{
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<AssessmentPackTemplate, Guid>>)((AssessmentPackTemplate e) => e.Id)).ValueGeneratedNever(), "ID");
			entity.Property<string>((Expression<Func<AssessmentPackTemplate, string>>)((AssessmentPackTemplate e) => e.Description)).IsUnicode(false);
			entity.Property<string>((Expression<Func<AssessmentPackTemplate, string>>)((AssessmentPackTemplate e) => e.Name)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<AssessmentPackTemplate, Guid?>>)((AssessmentPackTemplate e) => e.PackId)), "PackID");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<AssessmentPackTemplate, Guid?>>)((AssessmentPackTemplate e) => e.TempId)), "TempID");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<AssessmentPack, AssessmentPackTemplate>(entity.HasOne<AssessmentPack>((Expression<Func<AssessmentPackTemplate, AssessmentPack>>)((AssessmentPackTemplate d) => d.Pack)).WithMany((Expression<Func<AssessmentPack, IEnumerable<AssessmentPackTemplate>>>)((AssessmentPack p) => p.AssessmentPackTemplates)).HasForeignKey((Expression<Func<AssessmentPackTemplate, object>>)((AssessmentPackTemplate d) => d.PackId)), "FK_AssessmentPackTemplates_AssessmentPack");
		});
		modelBuilder.Entity<AssessmentResult>((Action<EntityTypeBuilder<AssessmentResult>>)delegate(EntityTypeBuilder<AssessmentResult> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<AssessmentResult, Guid>>)((AssessmentResult e) => e.Id)), "(newid())");
		});
		modelBuilder.Entity<AssessmentStatus>((Action<EntityTypeBuilder<AssessmentStatus>>)delegate(EntityTypeBuilder<AssessmentStatus> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<AssessmentStatus, Guid>>)((AssessmentStatus e) => e.Id)), "(newid())");
		});
		modelBuilder.Entity<AssessmentTemplate>((Action<EntityTypeBuilder<AssessmentTemplate>>)delegate(EntityTypeBuilder<AssessmentTemplate> entity)
		{
			entity.Property<Guid>((Expression<Func<AssessmentTemplate, Guid>>)((AssessmentTemplate e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<AssessmentTemplate, DateTime?>>)((AssessmentTemplate e) => e.ClientCreatedDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<AssessmentTemplate, DateTime?>>)((AssessmentTemplate e) => e.ClientModifiedDate)), "datetime");
			entity.Property<string>((Expression<Func<AssessmentTemplate, string>>)((AssessmentTemplate e) => e.FileName)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<AssessmentTemplate, int?>>)((AssessmentTemplate e) => e.OrderId)), "OrderID");
		});
		modelBuilder.Entity<AssessmentTemplateIndex>((Action<EntityTypeBuilder<AssessmentTemplateIndex>>)delegate(EntityTypeBuilder<AssessmentTemplateIndex> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<AssessmentTemplateIndex>(entity.HasNoKey(), "AssessmentTemplateIndex");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<AssessmentTemplateIndex, DateTime?>>)((AssessmentTemplateIndex e) => e.ClientCreatedDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<AssessmentTemplateIndex, DateTime?>>)((AssessmentTemplateIndex e) => e.ClientModifiedDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<AssessmentTemplateIndex, int?>>)((AssessmentTemplateIndex e) => e.OrderId)), "OrderID");
		});
		modelBuilder.Entity<AssessmentTemplateOutcome>((Action<EntityTypeBuilder<AssessmentTemplateOutcome>>)delegate(EntityTypeBuilder<AssessmentTemplateOutcome> entity)
		{
			entity.Property<Guid>((Expression<Func<AssessmentTemplateOutcome, Guid>>)((AssessmentTemplateOutcome e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<AssessmentTemplateOutcome, int?>>)((AssessmentTemplateOutcome e) => e.OrderId)), "OrderID");
			entity.HasOne<AssessmentTemplateSection>((Expression<Func<AssessmentTemplateOutcome, AssessmentTemplateSection>>)((AssessmentTemplateOutcome d) => d.AssessmentTemplateSection)).WithMany((Expression<Func<AssessmentTemplateSection, IEnumerable<AssessmentTemplateOutcome>>>)((AssessmentTemplateSection p) => p.AssessmentTemplateOutcomes)).HasForeignKey((Expression<Func<AssessmentTemplateOutcome, object>>)((AssessmentTemplateOutcome d) => d.AssessmentTemplateSectionId));
		});
		modelBuilder.Entity<AssessmentTemplateSection>((Action<EntityTypeBuilder<AssessmentTemplateSection>>)delegate(EntityTypeBuilder<AssessmentTemplateSection> entity)
		{
			entity.Property<Guid>((Expression<Func<AssessmentTemplateSection, Guid>>)((AssessmentTemplateSection e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<AssessmentTemplateSection, int?>>)((AssessmentTemplateSection e) => e.OrderId)), "OrderID");
			entity.HasOne<AssessmentTemplateSpecificOutcome>((Expression<Func<AssessmentTemplateSection, AssessmentTemplateSpecificOutcome>>)((AssessmentTemplateSection d) => d.AssessmentTemplateSpecificOutcome)).WithMany((Expression<Func<AssessmentTemplateSpecificOutcome, IEnumerable<AssessmentTemplateSection>>>)((AssessmentTemplateSpecificOutcome p) => p.AssessmentTemplateSections)).HasForeignKey((Expression<Func<AssessmentTemplateSection, object>>)((AssessmentTemplateSection d) => d.AssessmentTemplateSpecificOutcomeId));
		});
		modelBuilder.Entity<AssessmentTemplateSpecificOutcome>((Action<EntityTypeBuilder<AssessmentTemplateSpecificOutcome>>)delegate(EntityTypeBuilder<AssessmentTemplateSpecificOutcome> entity)
		{
			entity.Property<Guid>((Expression<Func<AssessmentTemplateSpecificOutcome, Guid>>)((AssessmentTemplateSpecificOutcome e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<AssessmentTemplateSpecificOutcome, int?>>)((AssessmentTemplateSpecificOutcome e) => e.OrderId)), "OrderID");
			entity.HasOne<AssessmentTemplate>((Expression<Func<AssessmentTemplateSpecificOutcome, AssessmentTemplate>>)((AssessmentTemplateSpecificOutcome d) => d.AssessmentTemplate)).WithMany((Expression<Func<AssessmentTemplate, IEnumerable<AssessmentTemplateSpecificOutcome>>>)((AssessmentTemplate p) => p.AssessmentTemplateSpecificOutcomes)).HasForeignKey((Expression<Func<AssessmentTemplateSpecificOutcome, object>>)((AssessmentTemplateSpecificOutcome d) => d.AssessmentTemplateId));
		});
		modelBuilder.Entity<AtrQualification>((Action<EntityTypeBuilder<AtrQualification>>)delegate(EntityTypeBuilder<AtrQualification> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<AtrQualification>(entity, "ATR_Qualification");
			entity.Property<Guid>((Expression<Func<AtrQualification, Guid>>)((AtrQualification e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<AtrQualification, string>>)((AtrQualification e) => e.QualificationType)).IsUnicode(false);
		});
		modelBuilder.Entity<AtrSpecialisation>((Action<EntityTypeBuilder<AtrSpecialisation>>)delegate(EntityTypeBuilder<AtrSpecialisation> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<AtrSpecialisation>(entity, "ATR_Specialisation");
			entity.Property<Guid>((Expression<Func<AtrSpecialisation, Guid>>)((AtrSpecialisation e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<AtrSpecialisation, Guid?>>)((AtrSpecialisation e) => e.QualificationId)), "QualificationID");
			entity.Property<string>((Expression<Func<AtrSpecialisation, string>>)((AtrSpecialisation e) => e.SpesialisationType)).IsUnicode(false);
		});
		modelBuilder.Entity<AuditLog>((Action<EntityTypeBuilder<AuditLog>>)delegate(EntityTypeBuilder<AuditLog> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<AuditLog>(entity, "AuditLog");
			entity.Property<Guid>((Expression<Func<AuditLog, Guid>>)((AuditLog e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<AuditLog, DateTime?>>)((AuditLog e) => e.DateLogged)), "datetime");
			entity.Property<string>((Expression<Func<AuditLog, string>>)((AuditLog e) => e.LogDescription)).HasMaxLength(255);
			entity.Property<string>((Expression<Func<AuditLog, string>>)((AuditLog e) => e.LogTypeText)).HasMaxLength(50);
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<AuditLog, string>>)((AuditLog e) => e.LoggedCtsuser)).HasMaxLength(50), "LoggedCTSUser");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<AuditLog, string>>)((AuditLog e) => e.LoggedIp)).HasMaxLength(50), "LoggedIP");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<AuditLog, string>>)((AuditLog e) => e.LoggedPc)).HasMaxLength(50), "LoggedPC");
			entity.Property<string>((Expression<Func<AuditLog, string>>)((AuditLog e) => e.LoggedUser)).HasMaxLength(50);
		});
		modelBuilder.Entity<Company>((Action<EntityTypeBuilder<Company>>)delegate(EntityTypeBuilder<Company> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<Company, Guid>>)((Company e) => e.Id)), "(newid())");
		});
		modelBuilder.Entity<Compliance>((Action<EntityTypeBuilder<Compliance>>)delegate(EntityTypeBuilder<Compliance> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<Compliance>(entity.HasNoKey(), "Compliance");
			entity.Property<string>((Expression<Func<Compliance, string>>)((Compliance e) => e.CourseName)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<Compliance, DateTime?>>)((Compliance e) => e.DateCompleted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<Compliance, Guid>>)((Compliance e) => e.EmpId)), "EmpID");
		});
		modelBuilder.Entity<ComplianceSaco>((Action<EntityTypeBuilder<ComplianceSaco>>)delegate(EntityTypeBuilder<ComplianceSaco> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<ComplianceSaco>(entity.HasNoKey(), "ComplianceSaco");
			entity.Property<string>((Expression<Func<ComplianceSaco, string>>)((ComplianceSaco e) => e.CourseName)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<ComplianceSaco, DateTime?>>)((ComplianceSaco e) => e.DateCompleted)), "datetime");
		});
		modelBuilder.Entity<ComplianceType>((Action<EntityTypeBuilder<ComplianceType>>)delegate(EntityTypeBuilder<ComplianceType> entity)
		{
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<ComplianceType, Guid>>)((ComplianceType e) => e.ComplianceTypeId)).ValueGeneratedNever(), "ComplianceTypeID");
			entity.Property<string>((Expression<Func<ComplianceType, string>>)((ComplianceType e) => e.Name)).HasMaxLength(50).IsUnicode(false);
		});
		modelBuilder.Entity<ContentType>((Action<EntityTypeBuilder<ContentType>>)delegate(EntityTypeBuilder<ContentType> entity)
		{
			RelationalKeyBuilderExtensions.HasName(entity.HasKey((Expression<Func<ContentType, object>>)((ContentType e) => e.ContentTypeId)), "PK_ContentType_1");
			RelationalEntityTypeBuilderExtensions.ToTable<ContentType>(entity, "ContentType");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<ContentType, Guid>>)((ContentType e) => e.ContentTypeId)).ValueGeneratedNever(), "ContentTypeID");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<ContentType, string>>)((ContentType e) => e.ContentType1)).HasMaxLength(50), "ContentType");
			RelationalPropertyBuilderExtensions.HasDefaultValue<int?>(entity.Property<int?>((Expression<Func<ContentType, int?>>)((ContentType e) => e.ContentTypeCode)), (object)0);
		});
		modelBuilder.Entity<CostCentre>((Action<EntityTypeBuilder<CostCentre>>)delegate(EntityTypeBuilder<CostCentre> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<CostCentre>(entity, "CostCentre");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<CostCentre, Guid>>)((CostCentre e) => e.Id)).ValueGeneratedNever(), "ID");
			entity.Property<string>((Expression<Func<CostCentre, string>>)((CostCentre e) => e.CostCentreName)).IsUnicode(false);
			entity.Property<string>((Expression<Func<CostCentre, string>>)((CostCentre e) => e.CostCode)).HasMaxLength(50).IsUnicode(false);
		});
		modelBuilder.Entity<Country>((Action<EntityTypeBuilder<Country>>)delegate(EntityTypeBuilder<Country> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<Country, Guid>>)((Country e) => e.Id)), "(newid())");
		});
		modelBuilder.Entity<CourseImport>((Action<EntityTypeBuilder<CourseImport>>)delegate(EntityTypeBuilder<CourseImport> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<CourseImport>(entity, "CourseImport");
			RelationalPropertyBuilderExtensions.HasColumnName<int>(entity.Property<int>((Expression<Func<CourseImport, int>>)((CourseImport e) => e.Id)), "id");
			entity.Property<string>((Expression<Func<CourseImport, string>>)((CourseImport e) => e.CourseName)).HasMaxLength(100).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<CourseImport, int?>>)((CourseImport e) => e.MaxSeat)), "maxSeat");
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<CourseImport, int?>>)((CourseImport e) => e.Minseat)), "minseat");
		});
		modelBuilder.Entity<CourseInstance>((Action<EntityTypeBuilder<CourseInstance>>)delegate(EntityTypeBuilder<CourseInstance> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<CourseInstance, Guid>>)((CourseInstance e) => e.Id)), "(newid())");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CourseInstance, DateTime?>>)((CourseInstance e) => e.BookingDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasDefaultValue<int?>(entity.Property<int?>((Expression<Func<CourseInstance, int?>>)((CourseInstance e) => e.ClientStatus)), (object)8);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CourseInstance, DateTime?>>)((CourseInstance e) => e.CompletionDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CourseInstance, DateTime?>>)((CourseInstance e) => e.CompletionUploadDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<CourseInstance, Guid?>>)((CourseInstance e) => e.ContentFileId)), "ContentFileID");
			entity.Property<string>((Expression<Func<CourseInstance, string>>)((CourseInstance e) => e.CourseFilePath)).HasMaxLength(255).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<CourseInstance, string>>)((CourseInstance e) => e.CourseLmspath)).HasMaxLength(255).IsUnicode(false), "CourseLMSPath");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<CourseInstance, Guid?>>)((CourseInstance e) => e.CtscourseId)), "CTSCourseID");
			RelationalPropertyBuilderExtensions.HasDefaultValue<bool?>(entity.Property<bool?>((Expression<Func<CourseInstance, bool?>>)((CourseInstance e) => e.IsUnrestricted)), (object)false);
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<CourseInstance, int?>>)((CourseInstance e) => e.OrderId)), "OrderID");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<CourseInstance, Guid?>>)((CourseInstance e) => e.ParentId)), "ParentID");
			RelationalPropertyBuilderExtensions.HasDefaultValue<int?>(entity.Property<int?>((Expression<Func<CourseInstance, int?>>)((CourseInstance e) => e.RebookInstanceCount)), (object)0);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CourseInstance, DateTime?>>)((CourseInstance e) => e.StartDate)), "datetime");
			entity.HasOne<CourseTemplate>((Expression<Func<CourseInstance, CourseTemplate>>)((CourseInstance d) => d.CourseTemplate)).WithMany((Expression<Func<CourseTemplate, IEnumerable<CourseInstance>>>)((CourseTemplate p) => p.CourseInstances)).HasForeignKey((Expression<Func<CourseInstance, object>>)((CourseInstance d) => d.CourseTemplateId));
			entity.HasOne<Employee>((Expression<Func<CourseInstance, Employee>>)((CourseInstance d) => d.Employee)).WithMany((Expression<Func<Employee, IEnumerable<CourseInstance>>>)((Employee p) => p.CourseInstanceEmployees)).HasForeignKey((Expression<Func<CourseInstance, object>>)((CourseInstance d) => d.EmployeeId));
			entity.HasOne<Employee>((Expression<Func<CourseInstance, Employee>>)((CourseInstance d) => d.Instructor)).WithMany((Expression<Func<Employee, IEnumerable<CourseInstance>>>)((Employee p) => p.CourseInstanceInstructors)).HasForeignKey((Expression<Func<CourseInstance, object>>)((CourseInstance d) => d.InstructorId));
			entity.HasOne<TrainingStatus>((Expression<Func<CourseInstance, TrainingStatus>>)((CourseInstance d) => d.Status)).WithMany((Expression<Func<TrainingStatus, IEnumerable<CourseInstance>>>)((TrainingStatus p) => p.CourseInstances)).HasForeignKey((Expression<Func<CourseInstance, object>>)((CourseInstance d) => d.StatusId));
		});
		modelBuilder.Entity<CourseInstanceContent>((Action<EntityTypeBuilder<CourseInstanceContent>>)delegate(EntityTypeBuilder<CourseInstanceContent> entity)
		{
			entity.Property<Guid>((Expression<Func<CourseInstanceContent, Guid>>)((CourseInstanceContent e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<CourseInstanceContent, string>>)((CourseInstanceContent e) => e.ContentBody)).IsUnicode(false);
			entity.Property<string>((Expression<Func<CourseInstanceContent, string>>)((CourseInstanceContent e) => e.ContentText)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasDefaultValue<int?>(entity.Property<int?>((Expression<Func<CourseInstanceContent, int?>>)((CourseInstanceContent e) => e.ContentTypeCode)), (object)0);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<CourseInstanceContent, Guid?>>)((CourseInstanceContent e) => e.ContentTypeId)), "ContentTypeID");
			entity.Property<string>((Expression<Func<CourseInstanceContent, string>>)((CourseInstanceContent e) => e.Description)).IsUnicode(false);
			entity.Property<string>((Expression<Func<CourseInstanceContent, string>>)((CourseInstanceContent e) => e.ExternalLink)).IsUnicode(false);
			entity.Property<string>((Expression<Func<CourseInstanceContent, string>>)((CourseInstanceContent e) => e.FileLocation)).IsUnicode(false);
			entity.Property<string>((Expression<Func<CourseInstanceContent, string>>)((CourseInstanceContent e) => e.FilePath)).HasMaxLength(255).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<bool?>(entity.Property<bool?>((Expression<Func<CourseInstanceContent, bool?>>)((CourseInstanceContent e) => e.IsCtsrepository)), "IsCTSRepository");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<CourseInstanceContent, string>>)((CourseInstanceContent e) => e.Lmspath)).HasMaxLength(255).IsUnicode(false), "LMSPath");
			entity.Property<string>((Expression<Func<CourseInstanceContent, string>>)((CourseInstanceContent e) => e.Name)).IsUnicode(false);
		});
		modelBuilder.Entity<CourseInstanceEvent>((Action<EntityTypeBuilder<CourseInstanceEvent>>)delegate(EntityTypeBuilder<CourseInstanceEvent> entity)
		{
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<CourseInstanceEvent, Guid>>)((CourseInstanceEvent e) => e.Id)).ValueGeneratedNever(), "ID");
			entity.Property<string>((Expression<Func<CourseInstanceEvent, string>>)((CourseInstanceEvent e) => e.ClientRuntimeVersion)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<CourseInstanceEvent, Guid?>>)((CourseInstanceEvent e) => e.CourseInstanceId)), "CourseInstanceID");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<CourseInstanceEvent, Guid?>>)((CourseInstanceEvent e) => e.EmpId)), "EmpID");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CourseInstanceEvent, DateTime?>>)((CourseInstanceEvent e) => e.EventDateTime)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CourseInstanceEvent, DateTime?>>)((CourseInstanceEvent e) => e.EventDatetimeServer)), "datetime");
			entity.Property<string>((Expression<Func<CourseInstanceEvent, string>>)((CourseInstanceEvent e) => e.EventDescription)).HasMaxLength(255).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<CourseInstanceEvent, string>>)((CourseInstanceEvent e) => e.EventPc)).HasMaxLength(50).IsUnicode(false), "EventPC");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<CourseInstanceEvent, string>>)((CourseInstanceEvent e) => e.EventSourceIp)).HasMaxLength(20).IsUnicode(false), "EventSourceIP");
		});
		modelBuilder.Entity<CourseInstanceExam>((Action<EntityTypeBuilder<CourseInstanceExam>>)delegate(EntityTypeBuilder<CourseInstanceExam> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<CourseInstanceExam, Guid>>)((CourseInstanceExam e) => e.Id)), "(newid())");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CourseInstanceExam, DateTime?>>)((CourseInstanceExam e) => e.EndDateTime)), "datetime");
			entity.Property<string>((Expression<Func<CourseInstanceExam, string>>)((CourseInstanceExam e) => e.FliePath)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<CourseInstanceExam, string>>)((CourseInstanceExam e) => e.LmsPath)).IsUnicode(false), "LMS Path");
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<CourseInstanceExam, int?>>)((CourseInstanceExam e) => e.OrderId)), "OrderID");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CourseInstanceExam, DateTime?>>)((CourseInstanceExam e) => e.StartDateTime)), "datetime");
			entity.HasOne<CourseInstance>((Expression<Func<CourseInstanceExam, CourseInstance>>)((CourseInstanceExam d) => d.CourseInstance)).WithMany((Expression<Func<CourseInstance, IEnumerable<CourseInstanceExam>>>)((CourseInstance p) => p.CourseInstanceExams)).HasForeignKey((Expression<Func<CourseInstanceExam, object>>)((CourseInstanceExam d) => d.CourseInstanceId));
		});
		modelBuilder.Entity<CourseInstanceIndex>((Action<EntityTypeBuilder<CourseInstanceIndex>>)delegate(EntityTypeBuilder<CourseInstanceIndex> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<CourseInstanceIndex>(entity.HasNoKey(), "CourseInstanceIndex");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CourseInstanceIndex, DateTime?>>)((CourseInstanceIndex e) => e.BookingDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CourseInstanceIndex, DateTime?>>)((CourseInstanceIndex e) => e.CompletionDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CourseInstanceIndex, DateTime?>>)((CourseInstanceIndex e) => e.StartDate)), "datetime");
			entity.Property<string>((Expression<Func<CourseInstanceIndex, string>>)((CourseInstanceIndex e) => e.Workplace)).HasMaxLength(100).IsUnicode(false);
		});
		modelBuilder.Entity<CourseInstanceQuestion>((Action<EntityTypeBuilder<CourseInstanceQuestion>>)delegate(EntityTypeBuilder<CourseInstanceQuestion> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<CourseInstanceQuestion, Guid>>)((CourseInstanceQuestion e) => e.Id)), "(newid())");
			entity.Property<string>((Expression<Func<CourseInstanceQuestion, string>>)((CourseInstanceQuestion e) => e.CandidateAnswer)).HasMaxLength(10).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<CourseInstanceQuestion, Guid?>>)((CourseInstanceQuestion e) => e.CourseTemplateQuestionId)), "CourseTemplateQuestionID");
			entity.Property<string>((Expression<Func<CourseInstanceQuestion, string>>)((CourseInstanceQuestion e) => e.FilePath)).HasMaxLength(255).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<CourseInstanceQuestion, string>>)((CourseInstanceQuestion e) => e.Lmspath)).HasMaxLength(255).IsUnicode(false), "LMSPath");
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<CourseInstanceQuestion, int?>>)((CourseInstanceQuestion e) => e.OrderId)), "OrderID");
			entity.HasOne<CourseInstanceExam>((Expression<Func<CourseInstanceQuestion, CourseInstanceExam>>)((CourseInstanceQuestion d) => d.CourseInstanceExam)).WithMany((Expression<Func<CourseInstanceExam, IEnumerable<CourseInstanceQuestion>>>)((CourseInstanceExam p) => p.CourseInstanceQuestions)).HasForeignKey((Expression<Func<CourseInstanceQuestion, object>>)((CourseInstanceQuestion d) => d.CourseInstanceExamId));
			RelationalForeignKeyBuilderExtensions.HasConstraintName<CourseTemplateQuestion, CourseInstanceQuestion>(entity.HasOne<CourseTemplateQuestion>((Expression<Func<CourseInstanceQuestion, CourseTemplateQuestion>>)((CourseInstanceQuestion d) => d.CourseTemplateQuestion)).WithMany((Expression<Func<CourseTemplateQuestion, IEnumerable<CourseInstanceQuestion>>>)((CourseTemplateQuestion p) => p.CourseInstanceQuestions)).HasForeignKey((Expression<Func<CourseInstanceQuestion, object>>)((CourseInstanceQuestion d) => d.CourseTemplateQuestionId)), "FK_CourseInstanceQuestions_CourseTemplateQuestions");
		});
		modelBuilder.Entity<CoursePack>((Action<EntityTypeBuilder<CoursePack>>)delegate(EntityTypeBuilder<CoursePack> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<CoursePack>(entity, "CoursePack");
			entity.Property<Guid>((Expression<Func<CoursePack, Guid>>)((CoursePack e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CoursePack, DateTime?>>)((CoursePack e) => e.DateCreated)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CoursePack, DateTime?>>)((CoursePack e) => e.DateModified)), "datetime");
			entity.Property<string>((Expression<Func<CoursePack, string>>)((CoursePack e) => e.Description)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasDefaultValue<bool?>(entity.Property<bool?>((Expression<Func<CoursePack, bool?>>)((CoursePack e) => e.IsActive)), (object)true);
			RelationalPropertyBuilderExtensions.HasDefaultValue<bool?>(entity.Property<bool?>((Expression<Func<CoursePack, bool?>>)((CoursePack e) => e.IsDeleted)), (object)false);
			entity.Property<string>((Expression<Func<CoursePack, string>>)((CoursePack e) => e.Name)).IsUnicode(false);
		});
		modelBuilder.Entity<CoursePackTemplate>((Action<EntityTypeBuilder<CoursePackTemplate>>)delegate(EntityTypeBuilder<CoursePackTemplate> entity)
		{
			entity.Property<Guid>((Expression<Func<CoursePackTemplate, Guid>>)((CoursePackTemplate e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<CoursePackTemplate, string>>)((CoursePackTemplate e) => e.TemplateDescription)).IsUnicode(false);
			entity.Property<string>((Expression<Func<CoursePackTemplate, string>>)((CoursePackTemplate e) => e.TemplateName)).IsUnicode(false);
			entity.Property<string>((Expression<Func<CoursePackTemplate, string>>)((CoursePackTemplate e) => e.TemplateVersion)).HasMaxLength(10).IsUnicode(false);
			RelationalForeignKeyBuilderExtensions.HasConstraintName<CoursePack, CoursePackTemplate>(entity.HasOne<CoursePack>((Expression<Func<CoursePackTemplate, CoursePack>>)((CoursePackTemplate d) => d.CoursePack)).WithMany((Expression<Func<CoursePack, IEnumerable<CoursePackTemplate>>>)((CoursePack p) => p.CoursePackTemplates)).HasForeignKey((Expression<Func<CoursePackTemplate, object>>)((CoursePackTemplate d) => d.CoursePackId)), "FK_CoursePackTemplates_CoursePack");
		});
		modelBuilder.Entity<CourseStructureItem>((Action<EntityTypeBuilder<CourseStructureItem>>)delegate(EntityTypeBuilder<CourseStructureItem> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<CourseStructureItem, Guid>>)((CourseStructureItem e) => e.Id)), "(newid())");
		});
		modelBuilder.Entity<CourseTemplate>((Action<EntityTypeBuilder<CourseTemplate>>)delegate(EntityTypeBuilder<CourseTemplate> entity)
		{
			entity.Property<Guid>((Expression<Func<CourseTemplate, Guid>>)((CourseTemplate e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<CourseTemplate, string>>)((CourseTemplate e) => e.ChangeLog)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CourseTemplate, DateTime?>>)((CourseTemplate e) => e.ClientCreatedDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CourseTemplate, DateTime?>>)((CourseTemplate e) => e.ClientModifiedDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<CourseTemplate, Guid?>>)((CourseTemplate e) => e.ContentFileId)), "ContentFileID");
			entity.Property<string>((Expression<Func<CourseTemplate, string>>)((CourseTemplate e) => e.CourseFilePath)).HasMaxLength(255).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<CourseTemplate, string>>)((CourseTemplate e) => e.CourseLmspath)).HasMaxLength(255).IsUnicode(false), "CourseLMSPath");
			entity.Property<string>((Expression<Func<CourseTemplate, string>>)((CourseTemplate e) => e.FileName)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<CourseTemplate, Guid?>>)((CourseTemplate e) => e.MasterCopyId)), "MasterCopyID");
			entity.Property<string>((Expression<Func<CourseTemplate, string>>)((CourseTemplate e) => e.MasterDocument)).HasMaxLength(255).IsUnicode(false);
			entity.Property<string>((Expression<Func<CourseTemplate, string>>)((CourseTemplate e) => e.MasterDocumentRev)).HasMaxLength(10).IsUnicode(false);
			RelationalForeignKeyBuilderExtensions.HasConstraintName<CourseTemplateMaster, CourseTemplate>(entity.HasOne<CourseTemplateMaster>((Expression<Func<CourseTemplate, CourseTemplateMaster>>)((CourseTemplate d) => d.CourseMaster)).WithMany((Expression<Func<CourseTemplateMaster, IEnumerable<CourseTemplate>>>)((CourseTemplateMaster p) => p.CourseTemplates)).HasForeignKey((Expression<Func<CourseTemplate, object>>)((CourseTemplate d) => d.CourseMasterId)), "FK_CourseTemplates_CourseTemplateMaster");
			entity.HasOne<CourseType>((Expression<Func<CourseTemplate, CourseType>>)((CourseTemplate d) => d.CourseType)).WithMany((Expression<Func<CourseType, IEnumerable<CourseTemplate>>>)((CourseType p) => p.CourseTemplates)).HasForeignKey((Expression<Func<CourseTemplate, object>>)((CourseTemplate d) => d.CourseTypeId));
		});
		modelBuilder.Entity<CourseTemplateContent>((Action<EntityTypeBuilder<CourseTemplateContent>>)delegate(EntityTypeBuilder<CourseTemplateContent> entity)
		{
			entity.Property<Guid>((Expression<Func<CourseTemplateContent, Guid>>)((CourseTemplateContent e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasDefaultValue<int?>(entity.Property<int?>((Expression<Func<CourseTemplateContent, int?>>)((CourseTemplateContent e) => e.ContentTypeCode)), (object)0);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<CourseTemplateContent, Guid?>>)((CourseTemplateContent e) => e.ContentTypeId)), "ContentTypeID");
			entity.Property<string>((Expression<Func<CourseTemplateContent, string>>)((CourseTemplateContent e) => e.FilePath)).HasMaxLength(255).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<CourseTemplateContent, string>>)((CourseTemplateContent e) => e.Lmspath)).HasMaxLength(255).IsUnicode(false), "LMSPath");
			entity.Property<string>((Expression<Func<CourseTemplateContent, string>>)((CourseTemplateContent e) => e.Name)).IsUnicode(false);
			entity.HasOne<CourseTemplate>((Expression<Func<CourseTemplateContent, CourseTemplate>>)((CourseTemplateContent d) => d.CourseTemplate)).WithMany((Expression<Func<CourseTemplate, IEnumerable<CourseTemplateContent>>>)((CourseTemplate p) => p.CourseTemplateContents)).HasForeignKey((Expression<Func<CourseTemplateContent, object>>)((CourseTemplateContent d) => d.CourseTemplateId));
		});
		modelBuilder.Entity<CourseTemplateExam>((Action<EntityTypeBuilder<CourseTemplateExam>>)delegate(EntityTypeBuilder<CourseTemplateExam> entity)
		{
			entity.Property<Guid>((Expression<Func<CourseTemplateExam, Guid>>)((CourseTemplateExam e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<CourseTemplateExam, string>>)((CourseTemplateExam e) => e.FilePath)).HasMaxLength(255).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<CourseTemplateExam, string>>)((CourseTemplateExam e) => e.Lmspath)).HasMaxLength(255).IsUnicode(false), "LMSPath");
			entity.HasOne<CourseTemplate>((Expression<Func<CourseTemplateExam, CourseTemplate>>)((CourseTemplateExam d) => d.CourseTemplate)).WithMany((Expression<Func<CourseTemplate, IEnumerable<CourseTemplateExam>>>)((CourseTemplate p) => p.CourseTemplateExams)).HasForeignKey((Expression<Func<CourseTemplateExam, object>>)((CourseTemplateExam d) => d.CourseTemplateId));
		});
		modelBuilder.Entity<CourseTemplateIndex>((Action<EntityTypeBuilder<CourseTemplateIndex>>)delegate(EntityTypeBuilder<CourseTemplateIndex> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<CourseTemplateIndex>(entity.HasNoKey(), "CourseTemplateIndex");
		});
		modelBuilder.Entity<CourseTemplateMaster>((Action<EntityTypeBuilder<CourseTemplateMaster>>)delegate(EntityTypeBuilder<CourseTemplateMaster> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<CourseTemplateMaster>(entity, "CourseTemplateMaster");
			entity.Property<Guid>((Expression<Func<CourseTemplateMaster, Guid>>)((CourseTemplateMaster e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<CourseTemplateMaster, string>>)((CourseTemplateMaster e) => e.Description)).IsUnicode(false);
			entity.Property<string>((Expression<Func<CourseTemplateMaster, string>>)((CourseTemplateMaster e) => e.Name)).HasMaxLength(100).IsUnicode(false);
		});
		modelBuilder.Entity<CourseTemplateQuestion>((Action<EntityTypeBuilder<CourseTemplateQuestion>>)delegate(EntityTypeBuilder<CourseTemplateQuestion> entity)
		{
			entity.Property<Guid>((Expression<Func<CourseTemplateQuestion, Guid>>)((CourseTemplateQuestion e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<CourseTemplateQuestion, string>>)((CourseTemplateQuestion e) => e.FilePath)).HasMaxLength(255).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<CourseTemplateQuestion, string>>)((CourseTemplateQuestion e) => e.Lmspath)).HasMaxLength(255).IsUnicode(false), "LMSPath");
			entity.HasOne<CourseTemplateExam>((Expression<Func<CourseTemplateQuestion, CourseTemplateExam>>)((CourseTemplateQuestion d) => d.CourseTemplateExam)).WithMany((Expression<Func<CourseTemplateExam, IEnumerable<CourseTemplateQuestion>>>)((CourseTemplateExam p) => p.CourseTemplateQuestions)).HasForeignKey((Expression<Func<CourseTemplateQuestion, object>>)((CourseTemplateQuestion d) => d.CourseTemplateExamId));
			entity.HasOne<CourseTemplate>((Expression<Func<CourseTemplateQuestion, CourseTemplate>>)((CourseTemplateQuestion d) => d.CourseTemplate)).WithMany((Expression<Func<CourseTemplate, IEnumerable<CourseTemplateQuestion>>>)((CourseTemplate p) => p.CourseTemplateQuestions)).HasForeignKey((Expression<Func<CourseTemplateQuestion, object>>)((CourseTemplateQuestion d) => d.CourseTemplateId));
		});
		modelBuilder.Entity<CourseType>((Action<EntityTypeBuilder<CourseType>>)delegate(EntityTypeBuilder<CourseType> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<CourseType, Guid>>)((CourseType e) => e.Id)), "(newid())");
		});
		modelBuilder.Entity<CtsComplianceActive>((Action<EntityTypeBuilder<CtsComplianceActive>>)delegate(EntityTypeBuilder<CtsComplianceActive> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<CtsComplianceActive>(entity.HasNoKey(), "CTS_COMPLIANCE_ACTIVE");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<CtsComplianceActive, string>>)((CtsComplianceActive e) => e.Coursename)).HasMaxLength(50).IsUnicode(false), "coursename");
			RelationalPropertyBuilderExtensions.HasColumnName<DateTime?>(RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CtsComplianceActive, DateTime?>>)((CtsComplianceActive e) => e.Datecompleted)), "datetime"), "datecompleted");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CtsComplianceActive, DateTime?>>)((CtsComplianceActive e) => e.Expirydate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<CtsComplianceActive, string>>)((CtsComplianceActive e) => e.Idnum)), "IDnum");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<CtsComplianceActive, string>>)((CtsComplianceActive e) => e.Refnum)), "refnum");
		});
		modelBuilder.Entity<CtsComplianceAllEmp>((Action<EntityTypeBuilder<CtsComplianceAllEmp>>)delegate(EntityTypeBuilder<CtsComplianceAllEmp> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<CtsComplianceAllEmp>(entity.HasNoKey(), "CTS_COMPLIANCE_ALL_EMPS");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<CtsComplianceAllEmp, string>>)((CtsComplianceAllEmp e) => e.Coursename)).HasMaxLength(50).IsUnicode(false), "coursename");
			RelationalPropertyBuilderExtensions.HasColumnName<DateTime?>(RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CtsComplianceAllEmp, DateTime?>>)((CtsComplianceAllEmp e) => e.Datecompleted)), "datetime"), "datecompleted");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<CtsComplianceAllEmp, DateTime?>>)((CtsComplianceAllEmp e) => e.Expirydate)), "datetime");
		});
		modelBuilder.Entity<Department>((Action<EntityTypeBuilder<Department>>)delegate(EntityTypeBuilder<Department> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<Department, Guid>>)((Department e) => e.Id)), "(newid())");
		});
		modelBuilder.Entity<ESignature>((Action<EntityTypeBuilder<ESignature>>)delegate(EntityTypeBuilder<ESignature> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<ESignature>(entity, "eSignature");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<ESignature, Guid>>)((ESignature e) => e.Id)).ValueGeneratedNever(), "ID");
			RelationalPropertyBuilderExtensions.IsFixedLength<string>(entity.Property<string>((Expression<Func<ESignature, string>>)((ESignature e) => e.IsActive)).HasMaxLength(10), true);
			RelationalPropertyBuilderExtensions.HasColumnName<string>(RelationalPropertyBuilderExtensions.IsFixedLength<string>(entity.Property<string>((Expression<Func<ESignature, string>>)((ESignature e) => e.IsDeleted)).HasMaxLength(10), true), "isDeleted");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<ESignature, DateTime?>>)((ESignature e) => e.SigAssessorDate)), "datetime");
			entity.Property<string>((Expression<Func<ESignature, string>>)((ESignature e) => e.SigAssessorFor)).IsUnicode(false);
			entity.Property<string>((Expression<Func<ESignature, string>>)((ESignature e) => e.SigAssessorWho)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<ESignature, DateTime?>>)((ESignature e) => e.SigEmployeeDate)), "datetime");
			entity.Property<string>((Expression<Func<ESignature, string>>)((ESignature e) => e.SigEmployeeFor)).IsUnicode(false);
			entity.Property<string>((Expression<Func<ESignature, string>>)((ESignature e) => e.SigEmployeeWho)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<ESignature, DateTime?>>)((ESignature e) => e.SigFacilitatorDate)), "datetime");
			entity.Property<string>((Expression<Func<ESignature, string>>)((ESignature e) => e.SigFacilitatorFor)).IsUnicode(false);
			entity.Property<string>((Expression<Func<ESignature, string>>)((ESignature e) => e.SigFacilitratorWho)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<ESignature, DateTime?>>)((ESignature e) => e.SigModeratorDate)), "datetime");
			entity.Property<string>((Expression<Func<ESignature, string>>)((ESignature e) => e.SigModeratorFor)).IsUnicode(false);
			entity.Property<string>((Expression<Func<ESignature, string>>)((ESignature e) => e.SigModeratorWho)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<ESignature, DateTime?>>)((ESignature e) => e.SigOtherDate)), "datetime");
			entity.Property<string>((Expression<Func<ESignature, string>>)((ESignature e) => e.SigOtherFor)).IsUnicode(false);
			entity.Property<string>((Expression<Func<ESignature, string>>)((ESignature e) => e.SigOtherWho)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<ESignature, Guid>>)((ESignature e) => e.SourceId)), "SourceID");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<AssessmentInstance, ESignature>(entity.HasOne<AssessmentInstance>((Expression<Func<ESignature, AssessmentInstance>>)((ESignature d) => d.Source)).WithMany((Expression<Func<AssessmentInstance, IEnumerable<ESignature>>>)((AssessmentInstance p) => p.ESignatures)).HasForeignKey((Expression<Func<ESignature, object>>)((ESignature d) => d.SourceId))
				.OnDelete((DeleteBehavior)0), "FK_eSignature_AssessmentInstances");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<CourseInstance, ESignature>(entity.HasOne<CourseInstance>((Expression<Func<ESignature, CourseInstance>>)((ESignature d) => d.SourceNavigation)).WithMany((Expression<Func<CourseInstance, IEnumerable<ESignature>>>)((CourseInstance p) => p.ESignatures)).HasForeignKey((Expression<Func<ESignature, object>>)((ESignature d) => d.SourceId))
				.OnDelete((DeleteBehavior)0), "FK_eSignature_CourseInstances");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<License, ESignature>(entity.HasOne<License>((Expression<Func<ESignature, License>>)((ESignature d) => d.Source1)).WithMany((Expression<Func<License, IEnumerable<ESignature>>>)((License p) => p.ESignatures)).HasForeignKey((Expression<Func<ESignature, object>>)((ESignature d) => d.SourceId))
				.OnDelete((DeleteBehavior)0), "FK_eSignature_License");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<LicenseApplication, ESignature>(entity.HasOne<LicenseApplication>((Expression<Func<ESignature, LicenseApplication>>)((ESignature d) => d.Source2)).WithMany((Expression<Func<LicenseApplication, IEnumerable<ESignature>>>)((LicenseApplication p) => p.ESignatures)).HasForeignKey((Expression<Func<ESignature, object>>)((ESignature d) => d.SourceId))
				.OnDelete((DeleteBehavior)0), "FK_eSignature_LicenseApplication");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<SmartClickCourse, ESignature>(entity.HasOne<SmartClickCourse>((Expression<Func<ESignature, SmartClickCourse>>)((ESignature d) => d.Source3)).WithMany((Expression<Func<SmartClickCourse, IEnumerable<ESignature>>>)((SmartClickCourse p) => p.ESignatures)).HasForeignKey((Expression<Func<ESignature, object>>)((ESignature d) => d.SourceId))
				.OnDelete((DeleteBehavior)0), "FK_eSignature_SmartClickCourse");
		});
		modelBuilder.Entity<Employee>((Action<EntityTypeBuilder<Employee>>)delegate(EntityTypeBuilder<Employee> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<Employee, Guid>>)((Employee e) => e.Id)), "(newid())");
			entity.Property<string>((Expression<Func<Employee, string>>)((Employee e) => e.CustomField1)).IsUnicode(false);
			entity.Property<string>((Expression<Func<Employee, string>>)((Employee e) => e.CustomField2)).IsUnicode(false);
			entity.Property<string>((Expression<Func<Employee, string>>)((Employee e) => e.CustomField3)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime>(entity.Property<DateTime>((Expression<Func<Employee, DateTime>>)((Employee e) => e.DateOfBirth)), "datetime");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Company, Employee>(entity.HasOne<Company>((Expression<Func<Employee, Company>>)((Employee d) => d.Company)).WithMany((Expression<Func<Company, IEnumerable<Employee>>>)((Company p) => p.Employees)).HasForeignKey((Expression<Func<Employee, object>>)((Employee d) => d.CompanyId))
				.OnDelete((DeleteBehavior)0), "FK_Employees_Companies");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Country, Employee>(entity.HasOne<Country>((Expression<Func<Employee, Country>>)((Employee d) => d.Country)).WithMany((Expression<Func<Country, IEnumerable<Employee>>>)((Country p) => p.Employees)).HasForeignKey((Expression<Func<Employee, object>>)((Employee d) => d.CountryId))
				.OnDelete((DeleteBehavior)0), "FK_Employees_Countries");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Department, Employee>(entity.HasOne<Department>((Expression<Func<Employee, Department>>)((Employee d) => d.Department)).WithMany((Expression<Func<Department, IEnumerable<Employee>>>)((Department p) => p.Employees)).HasForeignKey((Expression<Func<Employee, object>>)((Employee d) => d.DepartmentId))
				.OnDelete((DeleteBehavior)0), "FK_Employees_Departments");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<EmployeeType, Employee>(entity.HasOne<EmployeeType>((Expression<Func<Employee, EmployeeType>>)((Employee d) => d.EmployeeTypeNavigation)).WithMany((Expression<Func<EmployeeType, IEnumerable<Employee>>>)((EmployeeType p) => p.Employees)).HasForeignKey((Expression<Func<Employee, object>>)((Employee d) => d.EmployeeType)), "FK_Employees_EmployeeTypes");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Gender, Employee>(entity.HasOne<Gender>((Expression<Func<Employee, Gender>>)((Employee d) => d.Gender)).WithMany((Expression<Func<Gender, IEnumerable<Employee>>>)((Gender p) => p.Employees)).HasForeignKey((Expression<Func<Employee, object>>)((Employee d) => d.GenderId))
				.OnDelete((DeleteBehavior)0), "FK_Employees_Genders");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Grading, Employee>(entity.HasOne<Grading>((Expression<Func<Employee, Grading>>)((Employee d) => d.Grade)).WithMany((Expression<Func<Grading, IEnumerable<Employee>>>)((Grading p) => p.Employees)).HasForeignKey((Expression<Func<Employee, object>>)((Employee d) => d.GradeId)), "FK_Employees_Gradings");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<JobLevel, Employee>(entity.HasOne<JobLevel>((Expression<Func<Employee, JobLevel>>)((Employee d) => d.JobLevel)).WithMany((Expression<Func<JobLevel, IEnumerable<Employee>>>)((JobLevel p) => p.Employees)).HasForeignKey((Expression<Func<Employee, object>>)((Employee d) => d.JobLevelId))
				.OnDelete((DeleteBehavior)0), "FK_Employees_JobLevels");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<JobTitle, Employee>(entity.HasOne<JobTitle>((Expression<Func<Employee, JobTitle>>)((Employee d) => d.JobTitle)).WithMany((Expression<Func<JobTitle, IEnumerable<Employee>>>)((JobTitle p) => p.Employees)).HasForeignKey((Expression<Func<Employee, object>>)((Employee d) => d.JobTitleId))
				.OnDelete((DeleteBehavior)0), "FK_Employees_JobTitles");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Language, Employee>(entity.HasOne<Language>((Expression<Func<Employee, Language>>)((Employee d) => d.Language)).WithMany((Expression<Func<Language, IEnumerable<Employee>>>)((Language p) => p.Employees)).HasForeignKey((Expression<Func<Employee, object>>)((Employee d) => d.LanguageId))
				.OnDelete((DeleteBehavior)0), "FK_Employees_Languages");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Race, Employee>(entity.HasOne<Race>((Expression<Func<Employee, Race>>)((Employee d) => d.Race)).WithMany((Expression<Func<Race, IEnumerable<Employee>>>)((Race p) => p.Employees)).HasForeignKey((Expression<Func<Employee, object>>)((Employee d) => d.RaceId))
				.OnDelete((DeleteBehavior)0), "FK_Employees_Races");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<EmployeeStatus, Employee>(entity.HasOne<EmployeeStatus>((Expression<Func<Employee, EmployeeStatus>>)((Employee d) => d.Status)).WithMany((Expression<Func<EmployeeStatus, IEnumerable<Employee>>>)((EmployeeStatus p) => p.Employees)).HasForeignKey((Expression<Func<Employee, object>>)((Employee d) => d.StatusId))
				.OnDelete((DeleteBehavior)0), "FK_Employees_EmployeeStatuses");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Title, Employee>(entity.HasOne<Title>((Expression<Func<Employee, Title>>)((Employee d) => d.Title)).WithMany((Expression<Func<Title, IEnumerable<Employee>>>)((Title p) => p.Employees)).HasForeignKey((Expression<Func<Employee, object>>)((Employee d) => d.TitleId))
				.OnDelete((DeleteBehavior)0), "FK_Employees_Titles");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Workplace, Employee>(entity.HasOne<Workplace>((Expression<Func<Employee, Workplace>>)((Employee d) => d.Workplace)).WithMany((Expression<Func<Workplace, IEnumerable<Employee>>>)((Workplace p) => p.Employees)).HasForeignKey((Expression<Func<Employee, object>>)((Employee d) => d.WorkplaceId)), "FK_Employees_Workplace");
		});
		modelBuilder.Entity<EmployeeCompliance>((Action<EntityTypeBuilder<EmployeeCompliance>>)delegate(EntityTypeBuilder<EmployeeCompliance> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<EmployeeCompliance>(entity, "EmployeeCompliance");
			entity.Property<Guid>((Expression<Func<EmployeeCompliance, Guid>>)((EmployeeCompliance e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<EmployeeCompliance, string>>)((EmployeeCompliance e) => e.ComplianceName)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<string>(entity.Property<string>((Expression<Func<EmployeeCompliance, string>>)((EmployeeCompliance e) => e.Notes)), "text");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<EmployeeCompliance, Guid?>>)((EmployeeCompliance e) => e.SatisfyRefId)), "SatisfyRefID");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<EmployeeCompliance, Guid?>>)((EmployeeCompliance e) => e.SourceId)), "SourceID");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<ComplianceType, EmployeeCompliance>(entity.HasOne<ComplianceType>((Expression<Func<EmployeeCompliance, ComplianceType>>)((EmployeeCompliance d) => d.ComplianceType)).WithMany((Expression<Func<ComplianceType, IEnumerable<EmployeeCompliance>>>)((ComplianceType p) => p.EmployeeCompliances)).HasForeignKey((Expression<Func<EmployeeCompliance, object>>)((EmployeeCompliance d) => d.ComplianceTypeId)), "FK_EmployeeCompliance_ComplianceTypes");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Employee, EmployeeCompliance>(entity.HasOne<Employee>((Expression<Func<EmployeeCompliance, Employee>>)((EmployeeCompliance d) => d.Employee)).WithMany((Expression<Func<Employee, IEnumerable<EmployeeCompliance>>>)((Employee p) => p.EmployeeCompliances)).HasForeignKey((Expression<Func<EmployeeCompliance, object>>)((EmployeeCompliance d) => d.EmployeeId)), "FK_EmployeeCompliance_Employees");
		});
		modelBuilder.Entity<EmployeeImage>((Action<EntityTypeBuilder<EmployeeImage>>)delegate(EntityTypeBuilder<EmployeeImage> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<EmployeeImage>(entity, "EmployeeImage");
			entity.Property<Guid>((Expression<Func<EmployeeImage, Guid>>)((EmployeeImage e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnName<byte[]>(RelationalPropertyBuilderExtensions.HasColumnType<byte[]>(entity.Property<byte[]>((Expression<Func<EmployeeImage, byte[]>>)((EmployeeImage e) => e.EmployeeImage1)), "image"), "EmployeeImage");
			RelationalPropertyBuilderExtensions.HasColumnType<byte[]>(entity.Property<byte[]>((Expression<Func<EmployeeImage, byte[]>>)((EmployeeImage e) => e.ImageThumbnail)), "image");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Employee, EmployeeImage>(entity.HasOne<Employee>((Expression<Func<EmployeeImage, Employee>>)((EmployeeImage d) => d.Employee)).WithMany((Expression<Func<Employee, IEnumerable<EmployeeImage>>>)((Employee p) => p.EmployeeImages)).HasForeignKey((Expression<Func<EmployeeImage, object>>)((EmployeeImage d) => d.EmployeeId)), "FK_EmployeeImage_Employees");
		});
		modelBuilder.Entity<EmployeeIndex>((Action<EntityTypeBuilder<EmployeeIndex>>)delegate(EntityTypeBuilder<EmployeeIndex> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<EmployeeIndex>(entity.HasNoKey(), "EmployeeIndex");
			entity.Property<string>((Expression<Func<EmployeeIndex, string>>)((EmployeeIndex e) => e.Workplace)).HasMaxLength(100).IsUnicode(false);
		});
		modelBuilder.Entity<EmployeeJobRequirement>((Action<EntityTypeBuilder<EmployeeJobRequirement>>)delegate(EntityTypeBuilder<EmployeeJobRequirement> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<EmployeeJobRequirement>(entity, "EmployeeJobRequirement");
			entity.Property<Guid>((Expression<Func<EmployeeJobRequirement, Guid>>)((EmployeeJobRequirement e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<EmployeeJobRequirement, Guid?>>)((EmployeeJobRequirement e) => e.TrainingCourseId)), "TrainingCourseID");
			entity.Property<string>((Expression<Func<EmployeeJobRequirement, string>>)((EmployeeJobRequirement e) => e.TrainingCourseName)).HasMaxLength(50).IsUnicode(false);
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Employee, EmployeeJobRequirement>(entity.HasOne<Employee>((Expression<Func<EmployeeJobRequirement, Employee>>)((EmployeeJobRequirement d) => d.Employee)).WithMany((Expression<Func<Employee, IEnumerable<EmployeeJobRequirement>>>)((Employee p) => p.EmployeeJobRequirements)).HasForeignKey((Expression<Func<EmployeeJobRequirement, object>>)((EmployeeJobRequirement d) => d.EmployeeId)), "FK_EmployeeJobRequirement_Employees");
		});
		modelBuilder.Entity<EmployeeModule>((Action<EntityTypeBuilder<EmployeeModule>>)delegate(EntityTypeBuilder<EmployeeModule> entity)
		{
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<EmployeeModule, Guid>>)((EmployeeModule e) => e.Id)).ValueGeneratedNever(), "ID");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<EmployeeModule, Guid?>>)((EmployeeModule e) => e.EmployeeId)), "EmployeeID");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<EmployeeModule, DateTime?>>)((EmployeeModule e) => e.ExpiryDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<EmployeeModule, Guid?>>)((EmployeeModule e) => e.UnitStandardId)), "UnitStandardID");
			entity.Property<string>((Expression<Func<EmployeeModule, string>>)((EmployeeModule e) => e.UnitStandardName)).IsUnicode(false);
		});
		modelBuilder.Entity<EmployeeStatus>((Action<EntityTypeBuilder<EmployeeStatus>>)delegate(EntityTypeBuilder<EmployeeStatus> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<EmployeeStatus, Guid>>)((EmployeeStatus e) => e.Id)), "(newid())");
		});
		modelBuilder.Entity<EmployeeType>((Action<EntityTypeBuilder<EmployeeType>>)delegate(EntityTypeBuilder<EmployeeType> entity)
		{
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<EmployeeType, Guid>>)((EmployeeType e) => e.Id)).ValueGeneratedNever(), "ID");
			entity.Property<string>((Expression<Func<EmployeeType, string>>)((EmployeeType e) => e.Name)).HasMaxLength(50).IsUnicode(false);
		});
		modelBuilder.Entity<Event>((Action<EntityTypeBuilder<Event>>)delegate(EntityTypeBuilder<Event> entity)
		{
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<Event, Guid>>)((Event e) => e.Id)).ValueGeneratedNever(), "ID");
			entity.Property<string>((Expression<Func<Event, string>>)((Event e) => e.Description)).IsUnicode(false);
			entity.Property<string>((Expression<Func<Event, string>>)((Event e) => e.Name)).HasMaxLength(100).IsUnicode(false);
		});
		modelBuilder.Entity<EventBooking>((Action<EntityTypeBuilder<EventBooking>>)delegate(EntityTypeBuilder<EventBooking> entity)
		{
			entity.HasKey((Expression<Func<EventBooking, object>>)((EventBooking e) => e.BookingId));
			RelationalEntityTypeBuilderExtensions.ToTable<EventBooking>(entity, "EventBooking");
			entity.Property<Guid>((Expression<Func<EventBooking, Guid>>)((EventBooking e) => e.BookingId)).ValueGeneratedNever();
			entity.Property<int>((Expression<Func<EventBooking, int>>)((EventBooking e) => e.BookingInt)).ValueGeneratedOnAdd();
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<EventBooking, DateTime?>>)((EventBooking e) => e.EndDate)), "datetime");
			entity.Property<string>((Expression<Func<EventBooking, string>>)((EventBooking e) => e.EventDescription)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasDefaultValue<bool?>(entity.Property<bool?>((Expression<Func<EventBooking, bool?>>)((EventBooking e) => e.IsCanceled)), (object)false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<EventBooking, Guid?>>)((EventBooking e) => e.LocationId)), "LocationID");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<EventBooking, DateTime?>>)((EventBooking e) => e.StartDate)), "datetime");
		});
		modelBuilder.Entity<EventStatus>((Action<EntityTypeBuilder<EventStatus>>)delegate(EntityTypeBuilder<EventStatus> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<EventStatus>(entity, "EventStatus");
			entity.Property<Guid>((Expression<Func<EventStatus, Guid>>)((EventStatus e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<EventStatus, string>>)((EventStatus e) => e.Name)).HasMaxLength(50).IsUnicode(false);
		});
		modelBuilder.Entity<Gender>((Action<EntityTypeBuilder<Gender>>)delegate(EntityTypeBuilder<Gender> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<Gender, Guid>>)((Gender e) => e.Id)), "(newid())");
		});
		modelBuilder.Entity<Grading>((Action<EntityTypeBuilder<Grading>>)delegate(EntityTypeBuilder<Grading> entity)
		{
			entity.Property<Guid>((Expression<Func<Grading, Guid>>)((Grading e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<Grading, string>>)((Grading e) => e.Grading1)).HasMaxLength(50).IsUnicode(false), "Grading");
		});
		modelBuilder.Entity<JobLevel>((Action<EntityTypeBuilder<JobLevel>>)delegate(EntityTypeBuilder<JobLevel> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<JobLevel, Guid>>)((JobLevel e) => e.Id)), "(newid())");
		});
		modelBuilder.Entity<JobTitle>((Action<EntityTypeBuilder<JobTitle>>)delegate(EntityTypeBuilder<JobTitle> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<JobTitle, Guid>>)((JobTitle e) => e.Id)), "(newid())");
		});
		modelBuilder.Entity<JobTrainingRequirement>((Action<EntityTypeBuilder<JobTrainingRequirement>>)delegate(EntityTypeBuilder<JobTrainingRequirement> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<JobTrainingRequirement>(entity, "JobTrainingRequirement");
			entity.Property<Guid>((Expression<Func<JobTrainingRequirement, Guid>>)((JobTrainingRequirement e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<JobTrainingRequirement, Guid?>>)((JobTrainingRequirement e) => e.SatisfyingRefId)), "SatisfyingRefID");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<TrainingCourse, JobTrainingRequirement>(entity.HasOne<TrainingCourse>((Expression<Func<JobTrainingRequirement, TrainingCourse>>)((JobTrainingRequirement d) => d.Course)).WithMany((Expression<Func<TrainingCourse, IEnumerable<JobTrainingRequirement>>>)((TrainingCourse p) => p.JobTrainingRequirements)).HasForeignKey((Expression<Func<JobTrainingRequirement, object>>)((JobTrainingRequirement d) => d.CourseId)), "FK_JobTrainingRequirement_TrainingCourse");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<JobTitle, JobTrainingRequirement>(entity.HasOne<JobTitle>((Expression<Func<JobTrainingRequirement, JobTitle>>)((JobTrainingRequirement d) => d.JobTitle)).WithMany((Expression<Func<JobTitle, IEnumerable<JobTrainingRequirement>>>)((JobTitle p) => p.JobTrainingRequirements)).HasForeignKey((Expression<Func<JobTrainingRequirement, object>>)((JobTrainingRequirement d) => d.JobTitleId)), "FK_JobTrainingRequirement_JobTitles");
		});
		modelBuilder.Entity<Language>((Action<EntityTypeBuilder<Language>>)delegate(EntityTypeBuilder<Language> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<Language, Guid>>)((Language e) => e.Id)), "(newid())");
		});
		modelBuilder.Entity<License>((Action<EntityTypeBuilder<License>>)delegate(EntityTypeBuilder<License> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<License>(entity, "License");
			entity.Property<Guid>((Expression<Func<License, Guid>>)((License e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<License, DateTime?>>)((License e) => e.DateIssued)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<License, Guid?>>)((License e) => e.EmployeeId)), "EmployeeID");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<License, DateTime?>>)((License e) => e.ExpiryDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<string>(entity.Property<string>((Expression<Func<License, string>>)((License e) => e.Notes)), "text");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<License, Guid?>>)((License e) => e.ProviderId)), "ProviderID");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Employee, License>(entity.HasOne<Employee>((Expression<Func<License, Employee>>)((License d) => d.Employee)).WithMany((Expression<Func<Employee, IEnumerable<License>>>)((Employee p) => p.Licenses)).HasForeignKey((Expression<Func<License, object>>)((License d) => d.EmployeeId)), "FK_License_Employees");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<User, License>(entity.HasOne<User>((Expression<Func<License, User>>)((License d) => d.IssuedByNavigation)).WithMany((Expression<Func<User, IEnumerable<License>>>)((User p) => p.Licenses)).HasForeignKey((Expression<Func<License, object>>)((License d) => d.IssuedBy)), "FK_License_Users");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<LicenseType, License>(entity.HasOne<LicenseType>((Expression<Func<License, LicenseType>>)((License d) => d.LicenseType)).WithMany((Expression<Func<LicenseType, IEnumerable<License>>>)((LicenseType p) => p.Licenses)).HasForeignKey((Expression<Func<License, object>>)((License d) => d.LicenseTypeId)), "FK_License_LicenseType");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<LicenseRestriction, License>(entity.HasOne<LicenseRestriction>((Expression<Func<License, LicenseRestriction>>)((License d) => d.RestrictionNavigation)).WithMany((Expression<Func<LicenseRestriction, IEnumerable<License>>>)((LicenseRestriction p) => p.Licenses)).HasForeignKey((Expression<Func<License, object>>)((License d) => d.Restriction)), "FK_License_LicenseRestriction");
		});
		modelBuilder.Entity<LicenseApplication>((Action<EntityTypeBuilder<LicenseApplication>>)delegate(EntityTypeBuilder<LicenseApplication> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<LicenseApplication>(entity, "LicenseApplication");
			entity.Property<Guid>((Expression<Func<LicenseApplication, Guid>>)((LicenseApplication e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.IsFixedLength<string>(entity.Property<string>((Expression<Func<LicenseApplication, string>>)((LicenseApplication e) => e.DateCompleted)).HasMaxLength(10), true);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<LicenseApplication, DateTime?>>)((LicenseApplication e) => e.DateIssued)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<LicenseApplication, DateTime?>>)((LicenseApplication e) => e.DateRequested)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<LicenseApplication, DateTime?>>)((LicenseApplication e) => e.DateStarted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<LicenseApplication, Guid?>>)((LicenseApplication e) => e.EmployeeId)), "EmployeeID");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<LicenseApplication, DateTime?>>)((LicenseApplication e) => e.ExpiryDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<LicenseApplication, DateTime?>>)((LicenseApplication e) => e.LastActionDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<LicenseApplication, DateTime?>>)((LicenseApplication e) => e.LicenseStartDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<string>(entity.Property<string>((Expression<Func<LicenseApplication, string>>)((LicenseApplication e) => e.Notes)), "text");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<LicenseApplication, Guid?>>)((LicenseApplication e) => e.ProviderId)), "ProviderID");
			entity.Property<string>((Expression<Func<LicenseApplication, string>>)((LicenseApplication e) => e.Status)).HasMaxLength(50).IsUnicode(false);
		});
		modelBuilder.Entity<LicenseApplicationIndex>((Action<EntityTypeBuilder<LicenseApplicationIndex>>)delegate(EntityTypeBuilder<LicenseApplicationIndex> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<LicenseApplicationIndex>(entity.HasNoKey(), "LicenseApplicationIndex");
			RelationalPropertyBuilderExtensions.IsFixedLength<string>(entity.Property<string>((Expression<Func<LicenseApplicationIndex, string>>)((LicenseApplicationIndex e) => e.DateCompleted)).HasMaxLength(10), true);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<LicenseApplicationIndex, DateTime?>>)((LicenseApplicationIndex e) => e.DateIssued)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<LicenseApplicationIndex, DateTime?>>)((LicenseApplicationIndex e) => e.DateRequested)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<LicenseApplicationIndex, DateTime?>>)((LicenseApplicationIndex e) => e.DateStarted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<LicenseApplicationIndex, Guid?>>)((LicenseApplicationIndex e) => e.EmployeeId)), "EmployeeID");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<LicenseApplicationIndex, DateTime?>>)((LicenseApplicationIndex e) => e.ExpiryDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<LicenseApplicationIndex, DateTime?>>)((LicenseApplicationIndex e) => e.LastActionDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<LicenseApplicationIndex, DateTime?>>)((LicenseApplicationIndex e) => e.LicenseStartDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<string>(entity.Property<string>((Expression<Func<LicenseApplicationIndex, string>>)((LicenseApplicationIndex e) => e.Notes)), "text");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<LicenseApplicationIndex, Guid?>>)((LicenseApplicationIndex e) => e.ProviderId)), "ProviderID");
			entity.Property<string>((Expression<Func<LicenseApplicationIndex, string>>)((LicenseApplicationIndex e) => e.Status)).HasMaxLength(50).IsUnicode(false);
		});
		modelBuilder.Entity<LicenseEscalation>((Action<EntityTypeBuilder<LicenseEscalation>>)delegate(EntityTypeBuilder<LicenseEscalation> entity)
		{
			entity.Property<Guid>((Expression<Func<LicenseEscalation, Guid>>)((LicenseEscalation e) => e.Id)).ValueGeneratedNever();
		});
		modelBuilder.Entity<LicenseLog>((Action<EntityTypeBuilder<LicenseLog>>)delegate(EntityTypeBuilder<LicenseLog> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<LicenseLog>(entity, "LicenseLog");
			entity.Property<Guid>((Expression<Func<LicenseLog, Guid>>)((LicenseLog e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<LicenseLog, DateTime?>>)((LicenseLog e) => e.DateLogged)), "datetime");
			entity.Property<string>((Expression<Func<LicenseLog, string>>)((LicenseLog e) => e.LogDescription)).HasMaxLength(255);
			entity.Property<string>((Expression<Func<LicenseLog, string>>)((LicenseLog e) => e.LogTypeText)).HasMaxLength(50);
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<LicenseLog, string>>)((LicenseLog e) => e.LoggedCtsuser)).HasMaxLength(50), "LoggedCTSUser");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<LicenseLog, string>>)((LicenseLog e) => e.LoggedIp)).HasMaxLength(50), "LoggedIP");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<LicenseLog, string>>)((LicenseLog e) => e.LoggedPc)).HasMaxLength(50), "LoggedPC");
			entity.Property<string>((Expression<Func<LicenseLog, string>>)((LicenseLog e) => e.LoggedUser)).HasMaxLength(50);
		});
		modelBuilder.Entity<LicensePrintHistory>((Action<EntityTypeBuilder<LicensePrintHistory>>)delegate(EntityTypeBuilder<LicensePrintHistory> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<LicensePrintHistory>(entity, "LicensePrintHistory");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<LicensePrintHistory, Guid>>)((LicensePrintHistory e) => e.Id)).ValueGeneratedNever(), "ID");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<LicensePrintHistory, DateTime?>>)((LicensePrintHistory e) => e.DatePrinted)), "datetime");
			entity.Property<string>((Expression<Func<LicensePrintHistory, string>>)((LicensePrintHistory e) => e.DeviceName)).HasMaxLength(150).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<LicensePrintHistory, Guid?>>)((LicensePrintHistory e) => e.EmployeeId)), "EmployeeID");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<LicensePrintHistory, string>>)((LicensePrintHistory e) => e.Ipadress)).HasMaxLength(50).IsUnicode(false), "IPAdress");
			entity.Property<string>((Expression<Func<LicensePrintHistory, string>>)((LicensePrintHistory e) => e.LoggedOnUser)).IsUnicode(false);
			entity.Property<string>((Expression<Func<LicensePrintHistory, string>>)((LicensePrintHistory e) => e.PrintReason)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<LicensePrintHistory, Guid?>>)((LicensePrintHistory e) => e.UserId)), "UserID");
			entity.Property<string>((Expression<Func<LicensePrintHistory, string>>)((LicensePrintHistory e) => e.UserName)).HasMaxLength(150).IsUnicode(false);
		});
		modelBuilder.Entity<LicenseRestriction>((Action<EntityTypeBuilder<LicenseRestriction>>)delegate(EntityTypeBuilder<LicenseRestriction> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<LicenseRestriction>(entity, "LicenseRestriction");
			entity.Property<Guid>((Expression<Func<LicenseRestriction, Guid>>)((LicenseRestriction e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<LicenseRestriction, string>>)((LicenseRestriction e) => e.Name)).HasMaxLength(50).IsUnicode(false);
		});
		modelBuilder.Entity<LicenseStatus>((Action<EntityTypeBuilder<LicenseStatus>>)delegate(EntityTypeBuilder<LicenseStatus> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<LicenseStatus>(entity, "LicenseStatus");
			entity.Property<Guid>((Expression<Func<LicenseStatus, Guid>>)((LicenseStatus e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<LicenseStatus, string>>)((LicenseStatus e) => e.Status)).HasMaxLength(50).IsUnicode(false);
		});
		modelBuilder.Entity<LicenseType>((Action<EntityTypeBuilder<LicenseType>>)delegate(EntityTypeBuilder<LicenseType> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<LicenseType>(entity, "LicenseType");
			entity.Property<Guid>((Expression<Func<LicenseType, Guid>>)((LicenseType e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<LicenseType, string>>)((LicenseType e) => e.Name)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<LicenseType, string>>)((LicenseType e) => e.ShortCode)).HasMaxLength(50).IsUnicode(false);
			RelationalForeignKeyBuilderExtensions.HasConstraintName<LicenseTypeAuthorisation, LicenseType>(entity.HasOne<LicenseTypeAuthorisation>((Expression<Func<LicenseType, LicenseTypeAuthorisation>>)((LicenseType d) => d.Authorisation)).WithMany((Expression<Func<LicenseTypeAuthorisation, IEnumerable<LicenseType>>>)((LicenseTypeAuthorisation p) => p.LicenseTypes)).HasForeignKey((Expression<Func<LicenseType, object>>)((LicenseType d) => d.AuthorisationId)), "FK_LicenseType_LicenseTypeAuthorisation");
		});
		modelBuilder.Entity<LicenseTypeAuthorisation>((Action<EntityTypeBuilder<LicenseTypeAuthorisation>>)delegate(EntityTypeBuilder<LicenseTypeAuthorisation> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<LicenseTypeAuthorisation>(entity, "LicenseTypeAuthorisation");
			entity.Property<Guid>((Expression<Func<LicenseTypeAuthorisation, Guid>>)((LicenseTypeAuthorisation e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<LicenseTypeAuthorisation, string>>)((LicenseTypeAuthorisation e) => e.AuthHeader)).IsUnicode(false);
			entity.Property<string>((Expression<Func<LicenseTypeAuthorisation, string>>)((LicenseTypeAuthorisation e) => e.AuthName)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<LicenseTypeAuthorisation, string>>)((LicenseTypeAuthorisation e) => e.AuthText)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<LicenseTypeAuthorisation, DateTime?>>)((LicenseTypeAuthorisation e) => e.DateCreated)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<LicenseTypeAuthorisation, DateTime?>>)((LicenseTypeAuthorisation e) => e.DateModified)), "datetime");
		});
		modelBuilder.Entity<Permit>((Action<EntityTypeBuilder<Permit>>)delegate(EntityTypeBuilder<Permit> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<Permit>(entity.HasNoKey(), "Permit");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(RelationalPropertyBuilderExtensions.IsFixedLength<string>(entity.Property<string>((Expression<Func<Permit, string>>)((Permit e) => e.PermitId)).HasMaxLength(10), true), "PermitID");
			entity.Property<int>((Expression<Func<Permit, int>>)((Permit e) => e.PermitNumber)).ValueGeneratedOnAdd();
		});
		modelBuilder.Entity<Ppeissue>((Action<EntityTypeBuilder<Ppeissue>>)delegate(EntityTypeBuilder<Ppeissue> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<Ppeissue>(entity, "PPEIssues");
			entity.Property<Guid>((Expression<Func<Ppeissue, Guid>>)((Ppeissue e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<Ppeissue, Guid>>)((Ppeissue e) => e.BatchId)), "BatchID");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime>(entity.Property<DateTime>((Expression<Func<Ppeissue, DateTime>>)((Ppeissue e) => e.DateCaptured)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<Ppeissue, Guid>>)((Ppeissue e) => e.EmployeeId)), "EmployeeID");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<Ppeissue, Guid?>>)((Ppeissue e) => e.IssuedToEmployeeId)), "IssuedToEmployeeID");
			entity.Property<string>((Expression<Func<Ppeissue, string>>)((Ppeissue e) => e.ReasonOrNote)).IsUnicode(false);
			entity.Property<string>((Expression<Func<Ppeissue, string>>)((Ppeissue e) => e.Size)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<Ppeissue, Guid?>>)((Ppeissue e) => e.SizeId)), "SizeID");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Employee, Ppeissue>(entity.HasOne<Employee>((Expression<Func<Ppeissue, Employee>>)((Ppeissue d) => d.Employee)).WithMany((Expression<Func<Employee, IEnumerable<Ppeissue>>>)((Employee p) => p.Ppeissues)).HasForeignKey((Expression<Func<Ppeissue, object>>)((Ppeissue d) => d.EmployeeId))
				.OnDelete((DeleteBehavior)0), "FK_PPEIssues_Employees");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Ppeitem, Ppeissue>(entity.HasOne<Ppeitem>((Expression<Func<Ppeissue, Ppeitem>>)((Ppeissue d) => d.Item)).WithMany((Expression<Func<Ppeitem, IEnumerable<Ppeissue>>>)((Ppeitem p) => p.Ppeissues)).HasForeignKey((Expression<Func<Ppeissue, object>>)((Ppeissue d) => d.ItemId))
				.OnDelete((DeleteBehavior)0), "FK_PPEIssues_PPEItem");
		});
		modelBuilder.Entity<Ppeitem>((Action<EntityTypeBuilder<Ppeitem>>)delegate(EntityTypeBuilder<Ppeitem> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<Ppeitem>(entity, "PPEItem");
			entity.Property<Guid>((Expression<Func<Ppeitem, Guid>>)((Ppeitem e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<Ppeitem, string>>)((Ppeitem e) => e.Description)).IsUnicode(false);
			entity.Property<string>((Expression<Func<Ppeitem, string>>)((Ppeitem e) => e.Name)).HasMaxLength(100).IsUnicode(false);
		});
		modelBuilder.Entity<PreSetNote>((Action<EntityTypeBuilder<PreSetNote>>)delegate(EntityTypeBuilder<PreSetNote> entity)
		{
			entity.Property<Guid>((Expression<Func<PreSetNote, Guid>>)((PreSetNote e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<PreSetNote, Guid?>>)((PreSetNote e) => e.CategoryId)), "CategoryID");
			entity.Property<string>((Expression<Func<PreSetNote, string>>)((PreSetNote e) => e.NoteText)).IsUnicode(false);
		});
		modelBuilder.Entity<PreSetNotesCategory>((Action<EntityTypeBuilder<PreSetNotesCategory>>)delegate(EntityTypeBuilder<PreSetNotesCategory> entity)
		{
			entity.Property<Guid>((Expression<Func<PreSetNotesCategory, Guid>>)((PreSetNotesCategory e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<PreSetNotesCategory, string>>)((PreSetNotesCategory e) => e.Category)).HasMaxLength(50).IsUnicode(false);
		});
		modelBuilder.Entity<Privilege>((Action<EntityTypeBuilder<Privilege>>)delegate(EntityTypeBuilder<Privilege> entity)
		{
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<Privilege, Guid>>)((Privilege e) => e.Id)).ValueGeneratedNever(), "ID");
			entity.Property<string>((Expression<Func<Privilege, string>>)((Privilege e) => e.Module)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<Privilege, string>>)((Privilege e) => e.Privilege1)).HasMaxLength(50).IsUnicode(false), "Privilege");
		});
		modelBuilder.Entity<Race>((Action<EntityTypeBuilder<Race>>)delegate(EntityTypeBuilder<Race> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<Race, Guid>>)((Race e) => e.Id)), "(newid())");
		});
		modelBuilder.Entity<Report>((Action<EntityTypeBuilder<Report>>)delegate(EntityTypeBuilder<Report> entity)
		{
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<Report, Guid>>)((Report e) => e.ReportId)).ValueGeneratedNever(), "ReportID");
			entity.Property<string>((Expression<Func<Report, string>>)((Report e) => e.CreatedBy)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<Report, DateTime?>>)((Report e) => e.DateCreated)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<Report, DateTime?>>)((Report e) => e.DateModified)), "datetime");
			entity.Property<string>((Expression<Func<Report, string>>)((Report e) => e.Description)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasDefaultValue<bool>(entity.Property<bool>((Expression<Func<Report, bool>>)((Report e) => e.IsActive)), (object)true);
			RelationalPropertyBuilderExtensions.HasDefaultValue<bool?>(entity.Property<bool?>((Expression<Func<Report, bool?>>)((Report e) => e.IsDeleted)), (object)false);
			entity.Property<string>((Expression<Func<Report, string>>)((Report e) => e.ModifiedBy)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<Report, string>>)((Report e) => e.Name)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<string>(entity.Property<string>((Expression<Func<Report, string>>)((Report e) => e.ReportData)), "text");
		});
		modelBuilder.Entity<ReportsWorkbench>((Action<EntityTypeBuilder<ReportsWorkbench>>)delegate(EntityTypeBuilder<ReportsWorkbench> entity)
		{
			entity.HasKey((Expression<Func<ReportsWorkbench, object>>)((ReportsWorkbench e) => e.ReportId));
			RelationalEntityTypeBuilderExtensions.ToTable<ReportsWorkbench>(entity, "ReportsWorkbench");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<ReportsWorkbench, Guid>>)((ReportsWorkbench e) => e.ReportId)).ValueGeneratedNever(), "ReportID");
			entity.Property<string>((Expression<Func<ReportsWorkbench, string>>)((ReportsWorkbench e) => e.CreatedBy)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<ReportsWorkbench, DateTime?>>)((ReportsWorkbench e) => e.DateCreated)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<ReportsWorkbench, DateTime?>>)((ReportsWorkbench e) => e.DateModified)), "datetime");
			entity.Property<string>((Expression<Func<ReportsWorkbench, string>>)((ReportsWorkbench e) => e.Description)).IsUnicode(false);
			entity.Property<string>((Expression<Func<ReportsWorkbench, string>>)((ReportsWorkbench e) => e.ModifiedBy)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<ReportsWorkbench, string>>)((ReportsWorkbench e) => e.Name)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<string>(entity.Property<string>((Expression<Func<ReportsWorkbench, string>>)((ReportsWorkbench e) => e.ReportData)), "text");
		});
		modelBuilder.Entity<Resource>((Action<EntityTypeBuilder<Resource>>)delegate(EntityTypeBuilder<Resource> entity)
		{
			RelationalKeyBuilderExtensions.HasName(entity.HasKey((Expression<Func<Resource, object>>)((Resource e) => e.Id)), "PK_Resources_1");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<Resource, Guid>>)((Resource e) => e.Id)).ValueGeneratedNever(), "ID");
			entity.Property<string>((Expression<Func<Resource, string>>)((Resource e) => e.BookedBy)).HasMaxLength(100).IsUnicode(false);
			entity.Property<string>((Expression<Func<Resource, string>>)((Resource e) => e.BookedFrom)).HasMaxLength(100).IsUnicode(false);
			entity.Property<string>((Expression<Func<Resource, string>>)((Resource e) => e.Company)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<Resource, DateTime?>>)((Resource e) => e.DateBooked)), "datetime");
			entity.Property<string>((Expression<Func<Resource, string>>)((Resource e) => e.EmpRef)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<Resource, Guid?>>)((Resource e) => e.EventId)), "EventID");
			entity.Property<string>((Expression<Func<Resource, string>>)((Resource e) => e.Gender)).HasMaxLength(10).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<Resource, string>>)((Resource e) => e.Idnumber)).HasMaxLength(50).IsUnicode(false), "IDNumber");
			RelationalPropertyBuilderExtensions.HasColumnType<byte[]>(entity.Property<byte[]>((Expression<Func<Resource, byte[]>>)((Resource e) => e.Image)), "image");
			RelationalPropertyBuilderExtensions.HasColumnName<bool?>(entity.Property<bool?>((Expression<Func<Resource, bool?>>)((Resource e) => e.IsDocumentationOk)), "IsDocumentationOK");
			entity.Property<string>((Expression<Func<Resource, string>>)((Resource e) => e.Notes)).IsUnicode(false);
			entity.Property<string>((Expression<Func<Resource, string>>)((Resource e) => e.Occupation)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<Resource, string>>)((Resource e) => e.Race)).HasMaxLength(10).IsUnicode(false);
			entity.Property<string>((Expression<Func<Resource, string>>)((Resource e) => e.ResourceName)).HasMaxLength(50);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<Resource, DateTime?>>)((Resource e) => e.TransferDate)), "datetime");
			entity.Property<string>((Expression<Func<Resource, string>>)((Resource e) => e.Workplace)).HasMaxLength(50).IsUnicode(false);
			RelationalForeignKeyBuilderExtensions.HasConstraintName<EventBooking, Resource>(entity.HasOne<EventBooking>((Expression<Func<Resource, EventBooking>>)((Resource d) => d.Event)).WithMany((Expression<Func<EventBooking, IEnumerable<Resource>>>)((EventBooking p) => p.Resources)).HasForeignKey((Expression<Func<Resource, object>>)((Resource d) => d.EventId)), "FK_Resources_EventBooking");
		});
		modelBuilder.Entity<ResourceStatus>((Action<EntityTypeBuilder<ResourceStatus>>)delegate(EntityTypeBuilder<ResourceStatus> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<ResourceStatus>(entity, "ResourceStatus");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<ResourceStatus, Guid>>)((ResourceStatus e) => e.Id)).ValueGeneratedNever(), "ID");
			entity.Property<string>((Expression<Func<ResourceStatus, string>>)((ResourceStatus e) => e.Name)).HasMaxLength(50).IsUnicode(false);
		});
		modelBuilder.Entity<Role>((Action<EntityTypeBuilder<Role>>)delegate(EntityTypeBuilder<Role> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<Role, Guid>>)((Role e) => e.Id)), "(newid())");
		});
		modelBuilder.Entity<RoleUser>((Action<EntityTypeBuilder<RoleUser>>)delegate(EntityTypeBuilder<RoleUser> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<RoleUser, Guid>>)((RoleUser e) => e.Id)), "(newid())");
			entity.HasOne<Role>((Expression<Func<RoleUser, Role>>)((RoleUser d) => d.Role)).WithMany((Expression<Func<Role, IEnumerable<RoleUser>>>)((Role p) => p.RoleUsers)).HasForeignKey((Expression<Func<RoleUser, object>>)((RoleUser d) => d.RoleId));
			RelationalForeignKeyBuilderExtensions.HasConstraintName<User, RoleUser>(entity.HasOne<User>((Expression<Func<RoleUser, User>>)((RoleUser d) => d.User)).WithMany((Expression<Func<User, IEnumerable<RoleUser>>>)((User p) => p.RoleUsers)).HasForeignKey((Expression<Func<RoleUser, object>>)((RoleUser d) => d.UserId))
				.OnDelete((DeleteBehavior)0), "FK_RoleUsers_Users");
		});
		modelBuilder.Entity<RoleUserIndex>((Action<EntityTypeBuilder<RoleUserIndex>>)delegate(EntityTypeBuilder<RoleUserIndex> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<RoleUserIndex>(entity.HasNoKey(), "RoleUserIndex");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<RoleUserIndex, string>>)((RoleUserIndex e) => e.EMail)).IsUnicode(false), "eMail");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<RoleUserIndex, string>>)((RoleUserIndex e) => e.EmpComb)), "empComb");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<RoleUserIndex, DateTime?>>)((RoleUserIndex e) => e.LastLoginTime)), "datetime");
		});
		modelBuilder.Entity<ServerInstruction>((Action<EntityTypeBuilder<ServerInstruction>>)delegate(EntityTypeBuilder<ServerInstruction> entity)
		{
			entity.Property<Guid>((Expression<Func<ServerInstruction, Guid>>)((ServerInstruction e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<ServerInstruction, string>>)((ServerInstruction e) => e.Originator)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<ServerInstruction, string>>)((ServerInstruction e) => e.OriginatorIp)).HasMaxLength(50).IsUnicode(false), "OriginatorIP");
			entity.Property<string>((Expression<Func<ServerInstruction, string>>)((ServerInstruction e) => e.ParamData)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<ServerInstruction, Guid?>>)((ServerInstruction e) => e.ParamId)), "ParamID");
			entity.Property<string>((Expression<Func<ServerInstruction, string>>)((ServerInstruction e) => e.Process)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<ServerInstruction, DateTime?>>)((ServerInstruction e) => e.ProcessedDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<ServerInstruction, DateTime?>>)((ServerInstruction e) => e.RequestDate)), "datetime");
			entity.Property<string>((Expression<Func<ServerInstruction, string>>)((ServerInstruction e) => e.Result)).HasMaxLength(10).IsUnicode(false);
			entity.Property<string>((Expression<Func<ServerInstruction, string>>)((ServerInstruction e) => e.ServerMessage)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<ServerInstruction, Guid?>>)((ServerInstruction e) => e.TargetId)), "TargetID");
		});
		modelBuilder.Entity<SmartClickAnalysis>((Action<EntityTypeBuilder<SmartClickAnalysis>>)delegate(EntityTypeBuilder<SmartClickAnalysis> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<SmartClickAnalysis>(entity.HasNoKey(), "SmartClickAnalysis");
			entity.Property<string>((Expression<Func<SmartClickAnalysis, string>>)((SmartClickAnalysis e) => e.Correct)).HasMaxLength(3).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<SmartClickAnalysis, DateTime?>>)((SmartClickAnalysis e) => e.CourseDate)), "datetime");
			entity.Property<string>((Expression<Func<SmartClickAnalysis, string>>)((SmartClickAnalysis e) => e.CourseName)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<SmartClickAnalysis, Guid?>>)((SmartClickAnalysis e) => e.DesignCourseId)), "DesignCourseID");
			entity.Property<string>((Expression<Func<SmartClickAnalysis, string>>)((SmartClickAnalysis e) => e.EmployeeRef)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<SmartClickAnalysis, string>>)((SmartClickAnalysis e) => e.QuestionText)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<SmartClickAnalysis, Guid>>)((SmartClickAnalysis e) => e.Questionid)), "questionid");
			entity.Property<string>((Expression<Func<SmartClickAnalysis, string>>)((SmartClickAnalysis e) => e.Responce)).HasMaxLength(3).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<SmartClickAnalysis, Guid?>>)((SmartClickAnalysis e) => e.TemplateId)), "TemplateID");
			entity.Property<string>((Expression<Func<SmartClickAnalysis, string>>)((SmartClickAnalysis e) => e.TestType)).HasMaxLength(10).IsUnicode(false);
		});
		modelBuilder.Entity<SmartClickAnalysisJobTitle>((Action<EntityTypeBuilder<SmartClickAnalysisJobTitle>>)delegate(EntityTypeBuilder<SmartClickAnalysisJobTitle> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<SmartClickAnalysisJobTitle>(entity.HasNoKey(), "SmartClickAnalysisJobTitle");
			entity.Property<string>((Expression<Func<SmartClickAnalysisJobTitle, string>>)((SmartClickAnalysisJobTitle e) => e.Correct)).HasMaxLength(3).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<SmartClickAnalysisJobTitle, DateTime?>>)((SmartClickAnalysisJobTitle e) => e.CourseDate)), "datetime");
			entity.Property<string>((Expression<Func<SmartClickAnalysisJobTitle, string>>)((SmartClickAnalysisJobTitle e) => e.CourseName)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<SmartClickAnalysisJobTitle, Guid?>>)((SmartClickAnalysisJobTitle e) => e.DesignCourseId)), "DesignCourseID");
			entity.Property<string>((Expression<Func<SmartClickAnalysisJobTitle, string>>)((SmartClickAnalysisJobTitle e) => e.EmployeeRef)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<SmartClickAnalysisJobTitle, string>>)((SmartClickAnalysisJobTitle e) => e.QuestionText)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<SmartClickAnalysisJobTitle, Guid>>)((SmartClickAnalysisJobTitle e) => e.Questionid)), "questionid");
			entity.Property<string>((Expression<Func<SmartClickAnalysisJobTitle, string>>)((SmartClickAnalysisJobTitle e) => e.Responce)).HasMaxLength(3).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<SmartClickAnalysisJobTitle, Guid?>>)((SmartClickAnalysisJobTitle e) => e.TemplateId)), "TemplateID");
			entity.Property<string>((Expression<Func<SmartClickAnalysisJobTitle, string>>)((SmartClickAnalysisJobTitle e) => e.TestType)).HasMaxLength(10).IsUnicode(false);
		});
		modelBuilder.Entity<SmartClickCourse>((Action<EntityTypeBuilder<SmartClickCourse>>)delegate(EntityTypeBuilder<SmartClickCourse> entity)
		{
			RelationalKeyBuilderExtensions.HasName(entity.HasKey((Expression<Func<SmartClickCourse, object>>)((SmartClickCourse e) => e.Id)), "PK_Smart");
			RelationalEntityTypeBuilderExtensions.ToTable<SmartClickCourse>(entity, "SmartClickCourse");
			entity.Property<Guid>((Expression<Func<SmartClickCourse, Guid>>)((SmartClickCourse e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<SmartClickCourse, DateTime?>>)((SmartClickCourse e) => e.CourseDate)), "datetime");
			entity.Property<string>((Expression<Func<SmartClickCourse, string>>)((SmartClickCourse e) => e.CourseName)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<SmartClickCourse, DateTime?>>)((SmartClickCourse e) => e.DateModerated)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<SmartClickCourse, DateTime?>>)((SmartClickCourse e) => e.DateSynced)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<SmartClickCourse, Guid?>>)((SmartClickCourse e) => e.DesignCourseId)), "DesignCourseID");
			entity.Property<string>((Expression<Func<SmartClickCourse, string>>)((SmartClickCourse e) => e.EmployeeRef)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<SmartClickCourse, string>>)((SmartClickCourse e) => e.Moderator)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<string>(entity.Property<string>((Expression<Func<SmartClickCourse, string>>)((SmartClickCourse e) => e.ModeratorComments)), "text");
			entity.Property<string>((Expression<Func<SmartClickCourse, string>>)((SmartClickCourse e) => e.Result)).HasMaxLength(10).IsUnicode(false);
			entity.Property<string>((Expression<Func<SmartClickCourse, string>>)((SmartClickCourse e) => e.SyncedFrom)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<SmartClickCourse, string>>)((SmartClickCourse e) => e.Teacher)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<SmartClickCourse, Guid?>>)((SmartClickCourse e) => e.TemplateId)), "TemplateID");
			entity.Property<string>((Expression<Func<SmartClickCourse, string>>)((SmartClickCourse e) => e.TestType)).HasMaxLength(10).IsUnicode(false);
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Employee, SmartClickCourse>(entity.HasOne<Employee>((Expression<Func<SmartClickCourse, Employee>>)((SmartClickCourse d) => d.Employee)).WithMany((Expression<Func<Employee, IEnumerable<SmartClickCourse>>>)((Employee p) => p.SmartClickCourses)).HasForeignKey((Expression<Func<SmartClickCourse, object>>)((SmartClickCourse d) => d.EmployeeId)), "FK_SmartClickCourse_Employees");
		});
		modelBuilder.Entity<SmartClickCourseQuestion>((Action<EntityTypeBuilder<SmartClickCourseQuestion>>)delegate(EntityTypeBuilder<SmartClickCourseQuestion> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<SmartClickCourseQuestion>(entity, "SmartClickCourseQuestion");
			entity.Property<Guid>((Expression<Func<SmartClickCourseQuestion, Guid>>)((SmartClickCourseQuestion e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<SmartClickCourseQuestion, string>>)((SmartClickCourseQuestion e) => e.CorrectAnswer)).HasMaxLength(5).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<SmartClickCourseQuestion, int?>>)((SmartClickCourseQuestion e) => e.OrderId)), "OrderID");
			entity.Property<string>((Expression<Func<SmartClickCourseQuestion, string>>)((SmartClickCourseQuestion e) => e.QuestionBody)).IsUnicode(false);
			entity.Property<string>((Expression<Func<SmartClickCourseQuestion, string>>)((SmartClickCourseQuestion e) => e.QuestionText)).IsUnicode(false);
			entity.Property<string>((Expression<Func<SmartClickCourseQuestion, string>>)((SmartClickCourseQuestion e) => e.Responce)).HasMaxLength(5).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<SmartClickCourseQuestion, DateTime?>>)((SmartClickCourseQuestion e) => e.ResponceDate)), "datetime");
		});
		modelBuilder.Entity<SmartClickCourseResponce>((Action<EntityTypeBuilder<SmartClickCourseResponce>>)delegate(EntityTypeBuilder<SmartClickCourseResponce> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<SmartClickCourseResponce>(entity, "SmartClickCourseResponce");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<SmartClickCourseResponce, Guid>>)((SmartClickCourseResponce e) => e.Id)).ValueGeneratedNever(), "ID");
			entity.Property<string>((Expression<Func<SmartClickCourseResponce, string>>)((SmartClickCourseResponce e) => e.Correct)).HasMaxLength(3).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<SmartClickCourseResponce, Guid?>>)((SmartClickCourseResponce e) => e.CourseId)), "CourseID");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<SmartClickCourseResponce, Guid?>>)((SmartClickCourseResponce e) => e.QuestionId)), "QuestionID");
			entity.Property<string>((Expression<Func<SmartClickCourseResponce, string>>)((SmartClickCourseResponce e) => e.Responce)).HasMaxLength(3).IsUnicode(false);
			RelationalForeignKeyBuilderExtensions.HasConstraintName<SmartClickCourse, SmartClickCourseResponce>(entity.HasOne<SmartClickCourse>((Expression<Func<SmartClickCourseResponce, SmartClickCourse>>)((SmartClickCourseResponce d) => d.Course)).WithMany((Expression<Func<SmartClickCourse, IEnumerable<SmartClickCourseResponce>>>)((SmartClickCourse p) => p.SmartClickCourseResponces)).HasForeignKey((Expression<Func<SmartClickCourseResponce, object>>)((SmartClickCourseResponce d) => d.CourseId)), "FK_SmartClickCourseResponce_SmartClickCourse");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<SmartClickCourseQuestion, SmartClickCourseResponce>(entity.HasOne<SmartClickCourseQuestion>((Expression<Func<SmartClickCourseResponce, SmartClickCourseQuestion>>)((SmartClickCourseResponce d) => d.Question)).WithMany((Expression<Func<SmartClickCourseQuestion, IEnumerable<SmartClickCourseResponce>>>)((SmartClickCourseQuestion p) => p.SmartClickCourseResponces)).HasForeignKey((Expression<Func<SmartClickCourseResponce, object>>)((SmartClickCourseResponce d) => d.QuestionId)), "FK_SmartClickCourseResponce_SmartClickCourseQuestion");
		});
		modelBuilder.Entity<SmartClickIndex>((Action<EntityTypeBuilder<SmartClickIndex>>)delegate(EntityTypeBuilder<SmartClickIndex> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<SmartClickIndex>(entity.HasNoKey(), "SmartClickIndex");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<SmartClickIndex, DateTime?>>)((SmartClickIndex e) => e.CourseDate)), "datetime");
			entity.Property<string>((Expression<Func<SmartClickIndex, string>>)((SmartClickIndex e) => e.CourseName)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<SmartClickIndex, DateTime?>>)((SmartClickIndex e) => e.DateModerated)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<SmartClickIndex, DateTime?>>)((SmartClickIndex e) => e.DateSynced)), "datetime");
			entity.Property<string>((Expression<Func<SmartClickIndex, string>>)((SmartClickIndex e) => e.Moderator)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<string>(entity.Property<string>((Expression<Func<SmartClickIndex, string>>)((SmartClickIndex e) => e.ModeratorComments)), "text");
			entity.Property<string>((Expression<Func<SmartClickIndex, string>>)((SmartClickIndex e) => e.Result)).HasMaxLength(10).IsUnicode(false);
			entity.Property<string>((Expression<Func<SmartClickIndex, string>>)((SmartClickIndex e) => e.SyncedFrom)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<SmartClickIndex, string>>)((SmartClickIndex e) => e.Teacher)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<SmartClickIndex, Guid?>>)((SmartClickIndex e) => e.TemplateId)), "TemplateID");
			entity.Property<string>((Expression<Func<SmartClickIndex, string>>)((SmartClickIndex e) => e.TestType)).HasMaxLength(10).IsUnicode(false);
			entity.Property<string>((Expression<Func<SmartClickIndex, string>>)((SmartClickIndex e) => e.Workplace)).HasMaxLength(100).IsUnicode(false);
		});
		modelBuilder.Entity<SmartClickTemplate>((Action<EntityTypeBuilder<SmartClickTemplate>>)delegate(EntityTypeBuilder<SmartClickTemplate> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<SmartClickTemplate>(entity, "SmartClickTemplate");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<SmartClickTemplate, Guid>>)((SmartClickTemplate e) => e.Id)).ValueGeneratedNever(), "ID");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<SmartClickTemplate, DateTime?>>)((SmartClickTemplate e) => e.CreateDate)), "datetime");
			entity.Property<string>((Expression<Func<SmartClickTemplate, string>>)((SmartClickTemplate e) => e.CreatedBy)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<SmartClickTemplate, DateTime?>>)((SmartClickTemplate e) => e.DateImported)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<SmartClickTemplate, Guid?>>)((SmartClickTemplate e) => e.DesignId)), "DesignID");
			entity.Property<string>((Expression<Func<SmartClickTemplate, string>>)((SmartClickTemplate e) => e.FileName)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<bool?>(entity.Property<bool?>((Expression<Func<SmartClickTemplate, bool?>>)((SmartClickTemplate e) => e.IsActive)), "isActive");
			RelationalPropertyBuilderExtensions.HasColumnName<bool?>(entity.Property<bool?>((Expression<Func<SmartClickTemplate, bool?>>)((SmartClickTemplate e) => e.IsDeleted)), "isDeleted");
			entity.Property<string>((Expression<Func<SmartClickTemplate, string>>)((SmartClickTemplate e) => e.ModifiedBy)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<SmartClickTemplate, DateTime?>>)((SmartClickTemplate e) => e.ModifiedDate)), "datetime");
			entity.Property<string>((Expression<Func<SmartClickTemplate, string>>)((SmartClickTemplate e) => e.TemplateDescription)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<SmartClickTemplate, Guid?>>)((SmartClickTemplate e) => e.TemplateId)), "TemplateID");
			entity.Property<string>((Expression<Func<SmartClickTemplate, string>>)((SmartClickTemplate e) => e.TemplateName)).IsUnicode(false);
			entity.Property<string>((Expression<Func<SmartClickTemplate, string>>)((SmartClickTemplate e) => e.TemplateVersion)).IsUnicode(false);
		});
		modelBuilder.Entity<SpecialRequest>((Action<EntityTypeBuilder<SpecialRequest>>)delegate(EntityTypeBuilder<SpecialRequest> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<SpecialRequest>(entity, "SpecialRequest");
			entity.Property<Guid>((Expression<Func<SpecialRequest, Guid>>)((SpecialRequest e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<SpecialRequest, DateTime?>>)((SpecialRequest e) => e.DateRequested)), "datetime");
			RelationalPropertyBuilderExtensions.HasDefaultValue<bool?>(entity.Property<bool?>((Expression<Func<SpecialRequest, bool?>>)((SpecialRequest e) => e.IsNew)), (object)true);
			entity.Property<string>((Expression<Func<SpecialRequest, string>>)((SpecialRequest e) => e.Message)).IsUnicode(false);
			entity.Property<string>((Expression<Func<SpecialRequest, string>>)((SpecialRequest e) => e.RequestCourse)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<SpecialRequest, string>>)((SpecialRequest e) => e.RequestName)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<SpecialRequest, string>>)((SpecialRequest e) => e.Status)).HasMaxLength(20).IsUnicode(false);
		});
		modelBuilder.Entity<SpecialRequestIndex>((Action<EntityTypeBuilder<SpecialRequestIndex>>)delegate(EntityTypeBuilder<SpecialRequestIndex> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<SpecialRequestIndex>(entity.HasNoKey(), "SpecialRequestIndex");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<SpecialRequestIndex, DateTime?>>)((SpecialRequestIndex e) => e.DateRequested)), "datetime");
			entity.Property<string>((Expression<Func<SpecialRequestIndex, string>>)((SpecialRequestIndex e) => e.Message)).IsUnicode(false);
			entity.Property<string>((Expression<Func<SpecialRequestIndex, string>>)((SpecialRequestIndex e) => e.RequestCourse)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<SpecialRequestIndex, string>>)((SpecialRequestIndex e) => e.RequestName)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<SpecialRequestIndex, string>>)((SpecialRequestIndex e) => e.Status)).HasMaxLength(20).IsUnicode(false);
			entity.Property<string>((Expression<Func<SpecialRequestIndex, string>>)((SpecialRequestIndex e) => e.UserName)).HasMaxLength(128);
		});
		modelBuilder.Entity<StudyAssistance>((Action<EntityTypeBuilder<StudyAssistance>>)delegate(EntityTypeBuilder<StudyAssistance> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<StudyAssistance>(entity, "StudyAssistance");
			entity.Property<Guid>((Expression<Func<StudyAssistance, Guid>>)((StudyAssistance e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<StudyAssistance, DateTime?>>)((StudyAssistance e) => e.AcademicYear)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<decimal?>(entity.Property<decimal?>((Expression<Func<StudyAssistance, decimal?>>)((StudyAssistance e) => e.AccomodationCost)), "money");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<StudyAssistance, Guid?>>)((StudyAssistance e) => e.AgreementId)), "AgreementID");
			RelationalPropertyBuilderExtensions.HasColumnType<decimal?>(entity.Property<decimal?>((Expression<Func<StudyAssistance, decimal?>>)((StudyAssistance e) => e.BookCost)), "money");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<StudyAssistance, DateTime?>>)((StudyAssistance e) => e.DateAllocated)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<StudyAssistance, Guid?>>)((StudyAssistance e) => e.EmployeeId)), "EmployeeID");
			RelationalPropertyBuilderExtensions.HasColumnType<decimal?>(entity.Property<decimal?>((Expression<Func<StudyAssistance, decimal?>>)((StudyAssistance e) => e.OtherFees)), "money");
			RelationalPropertyBuilderExtensions.HasColumnType<decimal?>(entity.Property<decimal?>((Expression<Func<StudyAssistance, decimal?>>)((StudyAssistance e) => e.TotalCost)), "money");
			RelationalPropertyBuilderExtensions.HasColumnType<decimal?>(entity.Property<decimal?>((Expression<Func<StudyAssistance, decimal?>>)((StudyAssistance e) => e.TutionFees)), "money");
		});
		modelBuilder.Entity<Sysdiagram>((Action<EntityTypeBuilder<Sysdiagram>>)delegate(EntityTypeBuilder<Sysdiagram> entity)
		{
			RelationalKeyBuilderExtensions.HasName(entity.HasKey((Expression<Func<Sysdiagram, object>>)((Sysdiagram e) => e.DiagramId)), "PK__sysdiagrams__05D8E0BE");
			RelationalEntityTypeBuilderExtensions.ToTable<Sysdiagram>(entity, "sysdiagrams");
			entity.HasIndex((Expression<Func<Sysdiagram, object>>)((Sysdiagram e) => new { e.PrincipalId, e.Name }), "UK_principal_name").IsUnique(true);
			RelationalPropertyBuilderExtensions.HasColumnName<int>(entity.Property<int>((Expression<Func<Sysdiagram, int>>)((Sysdiagram e) => e.DiagramId)), "diagram_id");
			RelationalPropertyBuilderExtensions.HasColumnName<byte[]>(entity.Property<byte[]>((Expression<Func<Sysdiagram, byte[]>>)((Sysdiagram e) => e.Definition)), "definition");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<Sysdiagram, string>>)((Sysdiagram e) => e.Name)).HasMaxLength(128), "name");
			RelationalPropertyBuilderExtensions.HasColumnName<int>(entity.Property<int>((Expression<Func<Sysdiagram, int>>)((Sysdiagram e) => e.PrincipalId)), "principal_id");
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<Sysdiagram, int?>>)((Sysdiagram e) => e.Version)), "version");
		});
		modelBuilder.Entity<SystemConfiguration>((Action<EntityTypeBuilder<SystemConfiguration>>)delegate(EntityTypeBuilder<SystemConfiguration> entity)
		{
			RelationalKeyBuilderExtensions.HasName(entity.HasKey((Expression<Func<SystemConfiguration, object>>)((SystemConfiguration e) => e.CompanyId)), "PK_Configuration");
			RelationalEntityTypeBuilderExtensions.ToTable<SystemConfiguration>(entity, "SystemConfiguration");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<SystemConfiguration, Guid>>)((SystemConfiguration e) => e.CompanyId)).ValueGeneratedNever(), "CompanyID");
			entity.Property<string>((Expression<Func<SystemConfiguration, string>>)((SystemConfiguration e) => e.CompanyName)).IsUnicode(false);
			entity.Property<string>((Expression<Func<SystemConfiguration, string>>)((SystemConfiguration e) => e.CompanyReg)).IsUnicode(false);
			entity.Property<string>((Expression<Func<SystemConfiguration, string>>)((SystemConfiguration e) => e.CompanyVat)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<SystemConfiguration, DateTime?>>)((SystemConfiguration e) => e.DateInstalled)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<SystemConfiguration, DateTime?>>)((SystemConfiguration e) => e.DateLastUpgrade)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<SystemConfiguration, int?>>)((SystemConfiguration e) => e.DbversionMajor)), "DBVersionMajor");
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<SystemConfiguration, int?>>)((SystemConfiguration e) => e.DbversionMinor)), "DBVersionMinor");
			entity.Property<string>((Expression<Func<SystemConfiguration, string>>)((SystemConfiguration e) => e.LicenseKey)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<string>(entity.Property<string>((Expression<Func<SystemConfiguration, string>>)((SystemConfiguration e) => e.LowestDatabaseVersion)), "text");
			RelationalPropertyBuilderExtensions.HasColumnType<string>(entity.Property<string>((Expression<Func<SystemConfiguration, string>>)((SystemConfiguration e) => e.LowestDesignToolVersion)), "text");
			entity.Property<string>((Expression<Func<SystemConfiguration, string>>)((SystemConfiguration e) => e.MailFrom)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<string>(entity.Property<string>((Expression<Func<SystemConfiguration, string>>)((SystemConfiguration e) => e.ServerVersion)), "text");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<SystemConfiguration, string>>)((SystemConfiguration e) => e.Smtpserver)).HasMaxLength(50).IsUnicode(false), "SMTPServer");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(RelationalPropertyBuilderExtensions.HasColumnType<string>(entity.Property<string>((Expression<Func<SystemConfiguration, string>>)((SystemConfiguration e) => e.SqlserverVersion)), "text"), "SQLServerVersion");
			entity.Property<string>((Expression<Func<SystemConfiguration, string>>)((SystemConfiguration e) => e.UpgradePath)).IsUnicode(false);
		});
		modelBuilder.Entity<TaskItem>((Action<EntityTypeBuilder<TaskItem>>)delegate(EntityTypeBuilder<TaskItem> entity)
		{
			entity.Property<Guid>((Expression<Func<TaskItem, Guid>>)((TaskItem e) => e.TaskItemId)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<TaskItem, Guid?>>)((TaskItem e) => e.AsigneeId)), "AsigneeID");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<TaskItem, DateTime?>>)((TaskItem e) => e.DateClosed)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<TaskItem, DateTime?>>)((TaskItem e) => e.DateOriginated)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<TaskItem, Guid?>>)((TaskItem e) => e.OriginatorId)), "OriginatorID");
			RelationalPropertyBuilderExtensions.HasColumnType<string>(entity.Property<string>((Expression<Func<TaskItem, string>>)((TaskItem e) => e.TaskDescription)), "text");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<TaskItem, Guid?>>)((TaskItem e) => e.TaskItemTemplateId)), "TaskItemTemplateID");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<TaskItem, Guid?>>)((TaskItem e) => e.TaskStatusId)), "TaskStatusID");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<TaskItem, Guid?>>)((TaskItem e) => e.TaskTargetId)), "TaskTargetID");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(RelationalPropertyBuilderExtensions.IsFixedLength<string>(entity.Property<string>((Expression<Func<TaskItem, string>>)((TaskItem e) => e.TaskTargetTypeId)).HasMaxLength(10), true), "TaskTargetTypeID");
		});
		modelBuilder.Entity<Title>((Action<EntityTypeBuilder<Title>>)delegate(EntityTypeBuilder<Title> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<Title, Guid>>)((Title e) => e.Id)), "(newid())");
		});
		modelBuilder.Entity<Training>((Action<EntityTypeBuilder<Training>>)delegate(EntityTypeBuilder<Training> entity)
		{
			entity.Property<Guid>((Expression<Func<Training, Guid>>)((Training e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnType<decimal?>(entity.Property<decimal?>((Expression<Func<Training, decimal?>>)((Training e) => e.AccomodationCost)), "money");
			entity.Property<string>((Expression<Func<Training, string>>)((Training e) => e.BatchDescription)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<Training, Guid?>>)((Training e) => e.BatchId)), "BatchID");
			RelationalPropertyBuilderExtensions.HasColumnType<decimal?>(entity.Property<decimal?>((Expression<Func<Training, decimal?>>)((Training e) => e.CourseCost)), "money");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<Training, DateTime?>>)((Training e) => e.DateBooked)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<Training, DateTime?>>)((Training e) => e.DateCaptured)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<Training, DateTime?>>)((Training e) => e.DateCompleted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<Training, DateTime?>>)((Training e) => e.DateStarted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<Training, DateTime?>>)((Training e) => e.ExpiryDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasDefaultValue<bool?>(entity.Property<bool?>((Expression<Func<Training, bool?>>)((Training e) => e.IsProcessed)), (object)false);
			entity.Property<string>((Expression<Func<Training, string>>)((Training e) => e.ModuleName)).HasMaxLength(100).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<decimal?>(entity.Property<decimal?>((Expression<Func<Training, decimal?>>)((Training e) => e.OtherCost)), "money");
			entity.Property<string>((Expression<Func<Training, string>>)((Training e) => e.ProviderName)).HasMaxLength(100).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(RelationalPropertyBuilderExtensions.HasDefaultValue<int?>(entity.Property<int?>((Expression<Func<Training, int?>>)((Training e) => e.TdaysPractical)), (object)0), "TDaysPractical");
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(RelationalPropertyBuilderExtensions.HasDefaultValue<int?>(entity.Property<int?>((Expression<Func<Training, int?>>)((Training e) => e.TdaysTheoretical)), (object)0), "TDaysTheoretical");
			RelationalPropertyBuilderExtensions.HasColumnType<decimal?>(entity.Property<decimal?>((Expression<Func<Training, decimal?>>)((Training e) => e.TotalCost)), "money");
			RelationalPropertyBuilderExtensions.HasColumnType<decimal?>(entity.Property<decimal?>((Expression<Func<Training, decimal?>>)((Training e) => e.TravelCost)), "money");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<TrainingChannel, Training>(entity.HasOne<TrainingChannel>((Expression<Func<Training, TrainingChannel>>)((Training d) => d.Channel)).WithMany((Expression<Func<TrainingChannel, IEnumerable<Training>>>)((TrainingChannel p) => p.Training)).HasForeignKey((Expression<Func<Training, object>>)((Training d) => d.ChannelId)), "FK_Training_TrainingChannels");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<CostCentre, Training>(entity.HasOne<CostCentre>((Expression<Func<Training, CostCentre>>)((Training d) => d.CostAllocationNavigation)).WithMany((Expression<Func<CostCentre, IEnumerable<Training>>>)((CostCentre p) => p.Training)).HasForeignKey((Expression<Func<Training, object>>)((Training d) => d.CostAllocation)), "FK_Training_CostCentre");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<TrainingType, Training>(entity.HasOne<TrainingType>((Expression<Func<Training, TrainingType>>)((Training d) => d.CourseType)).WithMany((Expression<Func<TrainingType, IEnumerable<Training>>>)((TrainingType p) => p.Training)).HasForeignKey((Expression<Func<Training, object>>)((Training d) => d.CourseTypeId)), "FK_Training_TrainingTypes");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Employee, Training>(entity.HasOne<Employee>((Expression<Func<Training, Employee>>)((Training d) => d.Employee)).WithMany((Expression<Func<Employee, IEnumerable<Training>>>)((Employee p) => p.Training)).HasForeignKey((Expression<Func<Training, object>>)((Training d) => d.EmployeeId)), "FK_Training_Employees");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<TrainingCourse, Training>(entity.HasOne<TrainingCourse>((Expression<Func<Training, TrainingCourse>>)((Training d) => d.Module)).WithMany((Expression<Func<TrainingCourse, IEnumerable<Training>>>)((TrainingCourse p) => p.Training)).HasForeignKey((Expression<Func<Training, object>>)((Training d) => d.ModuleId)), "FK_Training_TrainingCourse");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<TrainingProvider, Training>(entity.HasOne<TrainingProvider>((Expression<Func<Training, TrainingProvider>>)((Training d) => d.Provider)).WithMany((Expression<Func<TrainingProvider, IEnumerable<Training>>>)((TrainingProvider p) => p.Training)).HasForeignKey((Expression<Func<Training, object>>)((Training d) => d.ProviderId)), "FK_Training_TrainingProvider1");
		});
		modelBuilder.Entity<TrainingChannel>((Action<EntityTypeBuilder<TrainingChannel>>)delegate(EntityTypeBuilder<TrainingChannel> entity)
		{
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<TrainingChannel, Guid>>)((TrainingChannel e) => e.Id)).ValueGeneratedNever(), "ID");
			entity.Property<string>((Expression<Func<TrainingChannel, string>>)((TrainingChannel e) => e.ChannelName)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<TrainingChannel, string>>)((TrainingChannel e) => e.Description)).HasMaxLength(50).IsUnicode(false);
		});
		modelBuilder.Entity<TrainingCourse>((Action<EntityTypeBuilder<TrainingCourse>>)delegate(EntityTypeBuilder<TrainingCourse> entity)
		{
			RelationalKeyBuilderExtensions.HasName(entity.HasKey((Expression<Func<TrainingCourse, object>>)((TrainingCourse e) => e.Id)), "PK_TrainingCourses");
			RelationalEntityTypeBuilderExtensions.ToTable<TrainingCourse>(entity, "TrainingCourse");
			entity.Property<Guid>((Expression<Func<TrainingCourse, Guid>>)((TrainingCourse e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<TrainingCourse, string>>)((TrainingCourse e) => e.CourseDescription)).IsUnicode(false);
			entity.Property<string>((Expression<Func<TrainingCourse, string>>)((TrainingCourse e) => e.CourseName)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasDefaultValue<bool?>(entity.Property<bool?>((Expression<Func<TrainingCourse, bool?>>)((TrainingCourse e) => e.DoesExpire)), (object)false);
			entity.Property<string>((Expression<Func<TrainingCourse, string>>)((TrainingCourse e) => e.Duration)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<TrainingCourse, string>>)((TrainingCourse e) => e.SpecialisationNoLookup)).IsUnicode(false);
		});
		modelBuilder.Entity<TrainingCourseCategory>((Action<EntityTypeBuilder<TrainingCourseCategory>>)delegate(EntityTypeBuilder<TrainingCourseCategory> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<TrainingCourseCategory>(entity, "TrainingCourseCategory");
			entity.Property<Guid>((Expression<Func<TrainingCourseCategory, Guid>>)((TrainingCourseCategory e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<TrainingCourseCategory, string>>)((TrainingCourseCategory e) => e.Decsription)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<bool?>(entity.Property<bool?>((Expression<Func<TrainingCourseCategory, bool?>>)((TrainingCourseCategory e) => e.IsActive)), "isActive");
			RelationalPropertyBuilderExtensions.HasColumnName<bool?>(entity.Property<bool?>((Expression<Func<TrainingCourseCategory, bool?>>)((TrainingCourseCategory e) => e.IsDeleted)), "isDeleted");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<TrainingCourseCategory, string>>)((TrainingCourseCategory e) => e.Mqaid)).IsUnicode(false), "MQAId");
			entity.Property<string>((Expression<Func<TrainingCourseCategory, string>>)((TrainingCourseCategory e) => e.Name)).IsUnicode(false);
		});
		modelBuilder.Entity<TrainingCourseModule>((Action<EntityTypeBuilder<TrainingCourseModule>>)delegate(EntityTypeBuilder<TrainingCourseModule> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<TrainingCourseModule>(entity, "TrainingCourseModule");
			entity.Property<Guid>((Expression<Func<TrainingCourseModule, Guid>>)((TrainingCourseModule e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<TrainingCourseModule, string>>)((TrainingCourseModule e) => e.ModuleName)).IsUnicode(false);
			RelationalForeignKeyBuilderExtensions.HasConstraintName<TrainingCourse, TrainingCourseModule>(entity.HasOne<TrainingCourse>((Expression<Func<TrainingCourseModule, TrainingCourse>>)((TrainingCourseModule d) => d.TrainingCourse)).WithMany((Expression<Func<TrainingCourse, IEnumerable<TrainingCourseModule>>>)((TrainingCourse p) => p.TrainingCourseModules)).HasForeignKey((Expression<Func<TrainingCourseModule, object>>)((TrainingCourseModule d) => d.TrainingCourseId)), "FK_TrainingCourseModule_TrainingCourse");
		});
		modelBuilder.Entity<TrainingCredit>((Action<EntityTypeBuilder<TrainingCredit>>)delegate(EntityTypeBuilder<TrainingCredit> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<TrainingCredit>(entity, "TrainingCredit");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<TrainingCredit, Guid>>)((TrainingCredit e) => e.TrainingCreditId)).ValueGeneratedNever(), "TrainingCreditID");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<TrainingCredit, Guid?>>)((TrainingCredit e) => e.TrainingCourseId)), "TrainingCourseID");
		});
		modelBuilder.Entity<TrainingCreditModule>((Action<EntityTypeBuilder<TrainingCreditModule>>)delegate(EntityTypeBuilder<TrainingCreditModule> entity)
		{
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<TrainingCreditModule, Guid>>)((TrainingCreditModule e) => e.TrainingCreditModuleId)).ValueGeneratedNever(), "TrainingCreditModuleID");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<TrainingCreditModule, Guid?>>)((TrainingCreditModule e) => e.CreditSourceId)), "CreditSourceID");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<TrainingCreditModule, Guid?>>)((TrainingCreditModule e) => e.TrainingModuleId)), "TrainingModuleID");
		});
		modelBuilder.Entity<TrainingEvent>((Action<EntityTypeBuilder<TrainingEvent>>)delegate(EntityTypeBuilder<TrainingEvent> entity)
		{
			entity.Property<Guid>((Expression<Func<TrainingEvent, Guid>>)((TrainingEvent e) => e.TrainingEventId)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<TrainingEvent, string>>)((TrainingEvent e) => e.EventDescription)).IsUnicode(false);
			entity.Property<string>((Expression<Func<TrainingEvent, string>>)((TrainingEvent e) => e.EventName)).HasMaxLength(100).IsUnicode(false);
		});
		modelBuilder.Entity<TrainingIndex>((Action<EntityTypeBuilder<TrainingIndex>>)delegate(EntityTypeBuilder<TrainingIndex> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<TrainingIndex>(entity.HasNoKey(), "TrainingIndex");
			entity.Property<string>((Expression<Func<TrainingIndex, string>>)((TrainingIndex e) => e.CourseName)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<TrainingIndex, DateTime?>>)((TrainingIndex e) => e.DateBooked)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<TrainingIndex, DateTime?>>)((TrainingIndex e) => e.DateCompleted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<TrainingIndex, DateTime?>>)((TrainingIndex e) => e.DateStarted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<TrainingIndex, DateTime?>>)((TrainingIndex e) => e.ExpiryDate)), "datetime");
			entity.Property<string>((Expression<Func<TrainingIndex, string>>)((TrainingIndex e) => e.Grading)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<TrainingIndex, string>>)((TrainingIndex e) => e.ModuleName)).HasMaxLength(100).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<TrainingIndex, int?>>)((TrainingIndex e) => e.TdaysPractical)), "TDaysPractical");
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<TrainingIndex, int?>>)((TrainingIndex e) => e.TdaysTheoretical)), "TDaysTheoretical");
			entity.Property<string>((Expression<Func<TrainingIndex, string>>)((TrainingIndex e) => e.Workplace)).HasMaxLength(100).IsUnicode(false);
		});
		modelBuilder.Entity<TrainingIndexold>((Action<EntityTypeBuilder<TrainingIndexold>>)delegate(EntityTypeBuilder<TrainingIndexold> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<TrainingIndexold>(entity.HasNoKey(), "TrainingIndexold");
			entity.Property<string>((Expression<Func<TrainingIndexold, string>>)((TrainingIndexold e) => e.CourseName)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<TrainingIndexold, DateTime?>>)((TrainingIndexold e) => e.DateBooked)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<TrainingIndexold, DateTime?>>)((TrainingIndexold e) => e.DateCompleted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<TrainingIndexold, DateTime?>>)((TrainingIndexold e) => e.DateStarted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<TrainingIndexold, DateTime?>>)((TrainingIndexold e) => e.ExpiryDate)), "datetime");
			entity.Property<string>((Expression<Func<TrainingIndexold, string>>)((TrainingIndexold e) => e.Grading)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<TrainingIndexold, string>>)((TrainingIndexold e) => e.ModuleName)).HasMaxLength(100).IsUnicode(false);
			entity.Property<string>((Expression<Func<TrainingIndexold, string>>)((TrainingIndexold e) => e.Workplace)).HasMaxLength(100).IsUnicode(false);
		});
		modelBuilder.Entity<TrainingModule>((Action<EntityTypeBuilder<TrainingModule>>)delegate(EntityTypeBuilder<TrainingModule> entity)
		{
			entity.Property<Guid>((Expression<Func<TrainingModule, Guid>>)((TrainingModule e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<TrainingModule, Guid?>>)((TrainingModule e) => e.CouseModuleId)), "CouseModuleID");
			entity.Property<string>((Expression<Func<TrainingModule, string>>)((TrainingModule e) => e.Description)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<TrainingModule, Guid?>>)((TrainingModule e) => e.EmployeeId)), "EmployeeID");
			RelationalPropertyBuilderExtensions.HasDefaultValue<bool?>(entity.Property<bool?>((Expression<Func<TrainingModule, bool?>>)((TrainingModule e) => e.IsProcessed)), (object)false);
			entity.Property<string>((Expression<Func<TrainingModule, string>>)((TrainingModule e) => e.Name)).IsUnicode(false);
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Training, TrainingModule>(entity.HasOne<Training>((Expression<Func<TrainingModule, Training>>)((TrainingModule d) => d.Training)).WithMany((Expression<Func<Training, IEnumerable<TrainingModule>>>)((Training p) => p.TrainingModules)).HasForeignKey((Expression<Func<TrainingModule, object>>)((TrainingModule d) => d.TrainingId)), "FK_TrainingModules_Training");
		});
		modelBuilder.Entity<TrainingProvider>((Action<EntityTypeBuilder<TrainingProvider>>)delegate(EntityTypeBuilder<TrainingProvider> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<TrainingProvider>(entity, "TrainingProvider");
			entity.Property<Guid>((Expression<Func<TrainingProvider, Guid>>)((TrainingProvider e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<TrainingProvider, string>>)((TrainingProvider e) => e.ProviderName)).HasMaxLength(50).IsUnicode(false);
		});
		modelBuilder.Entity<TrainingStatus>((Action<EntityTypeBuilder<TrainingStatus>>)delegate(EntityTypeBuilder<TrainingStatus> entity)
		{
			RelationalPropertyBuilderExtensions.HasDefaultValueSql<Guid>(entity.Property<Guid>((Expression<Func<TrainingStatus, Guid>>)((TrainingStatus e) => e.Id)), "(newid())");
		});
		modelBuilder.Entity<TrainingType>((Action<EntityTypeBuilder<TrainingType>>)delegate(EntityTypeBuilder<TrainingType> entity)
		{
			entity.Property<Guid>((Expression<Func<TrainingType, Guid>>)((TrainingType e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<TrainingType, string>>)((TrainingType e) => e.Description)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<TrainingType, string>>)((TrainingType e) => e.Name)).HasMaxLength(50).IsUnicode(false);
		});
		modelBuilder.Entity<Transaction>((Action<EntityTypeBuilder<Transaction>>)delegate(EntityTypeBuilder<Transaction> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<Transaction>(entity, "Transaction");
			entity.Property<Guid>((Expression<Func<Transaction, Guid>>)((Transaction e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnType<decimal?>(entity.Property<decimal?>((Expression<Func<Transaction, decimal?>>)((Transaction e) => e.Amount)), "money");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<Transaction, Guid?>>)((Transaction e) => e.ContraId)), "ContraID");
			RelationalPropertyBuilderExtensions.HasColumnType<decimal?>(entity.Property<decimal?>((Expression<Func<Transaction, decimal?>>)((Transaction e) => e.Credit)), "money");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<Transaction, DateTime?>>)((Transaction e) => e.DateCaptured)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<decimal?>(entity.Property<decimal?>((Expression<Func<Transaction, decimal?>>)((Transaction e) => e.Debit)), "money");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<Transaction, DateTime?>>)((Transaction e) => e.TransactionDate)), "datetime");
			entity.Property<string>((Expression<Func<Transaction, string>>)((Transaction e) => e.TransactionDescription)).HasMaxLength(50).IsUnicode(false);
		});
		modelBuilder.Entity<UnitStandard>((Action<EntityTypeBuilder<UnitStandard>>)delegate(EntityTypeBuilder<UnitStandard> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<UnitStandard>(entity, "UnitStandard");
			entity.Property<Guid>((Expression<Func<UnitStandard, Guid>>)((UnitStandard e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<UnitStandard, string>>)((UnitStandard e) => e.Code)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<UnitStandard, string>>)((UnitStandard e) => e.Description)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasDefaultValue<bool?>(entity.Property<bool?>((Expression<Func<UnitStandard, bool?>>)((UnitStandard e) => e.DoesExpire)), (object)false);
			entity.Property<string>((Expression<Func<UnitStandard, string>>)((UnitStandard e) => e.Name)).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<int?>(entity.Property<int?>((Expression<Func<UnitStandard, int?>>)((UnitStandard e) => e.Nqflevel)), "NQFLevel");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<UnitStandard, string>>)((UnitStandard e) => e.Saqacode)).HasMaxLength(50).IsUnicode(false), "SAQACode");
		});
		modelBuilder.Entity<User>((Action<EntityTypeBuilder<User>>)delegate(EntityTypeBuilder<User> entity)
		{
			entity.Property<Guid>((Expression<Func<User, Guid>>)((User e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<User, string>>)((User e) => e.EMail)).IsUnicode(false), "eMail");
			RelationalPropertyBuilderExtensions.HasColumnName<byte[]>(entity.Property<byte[]>((Expression<Func<User, byte[]>>)((User e) => e.ESignature)), "eSignature");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<User, Guid?>>)((User e) => e.EmployeeId)), "EmployeeID");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime>(entity.Property<DateTime>((Expression<Func<User, DateTime>>)((User e) => e.LastLoginTime)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime>(entity.Property<DateTime>((Expression<Func<User, DateTime>>)((User e) => e.PasswordDate)), "datetime");
			entity.Property<string>((Expression<Func<User, string>>)((User e) => e.UserName)).HasMaxLength(128);
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Employee, User>(entity.HasOne<Employee>((Expression<Func<User, Employee>>)((User d) => d.Employee)).WithMany((Expression<Func<Employee, IEnumerable<User>>>)((Employee p) => p.Users)).HasForeignKey((Expression<Func<User, object>>)((User d) => d.EmployeeId)), "FK_Users_Employees");
		});
		modelBuilder.Entity<UserIndex>((Action<EntityTypeBuilder<UserIndex>>)delegate(EntityTypeBuilder<UserIndex> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<UserIndex>(entity.HasNoKey(), "UserIndex");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<UserIndex, string>>)((UserIndex e) => e.EMail)).IsUnicode(false), "eMail");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<UserIndex, Guid?>>)((UserIndex e) => e.EmployeeId)), "EmployeeID");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime>(entity.Property<DateTime>((Expression<Func<UserIndex, DateTime>>)((UserIndex e) => e.LastLoginTime)), "datetime");
			entity.Property<string>((Expression<Func<UserIndex, string>>)((UserIndex e) => e.UserName)).HasMaxLength(128);
		});
		modelBuilder.Entity<UserLayout>((Action<EntityTypeBuilder<UserLayout>>)delegate(EntityTypeBuilder<UserLayout> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<UserLayout>(entity, "UserLayout");
			entity.Property<Guid>((Expression<Func<UserLayout, Guid>>)((UserLayout e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<UserLayout, string>>)((UserLayout e) => e.ComponentName)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<UserLayout, string>>)((UserLayout e) => e.LayoutData)).IsUnicode(false);
		});
		modelBuilder.Entity<UserPrivelagesIndex>((Action<EntityTypeBuilder<UserPrivelagesIndex>>)delegate(EntityTypeBuilder<UserPrivelagesIndex> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<UserPrivelagesIndex>(entity.HasNoKey(), "UserPrivelagesIndex");
			RelationalPropertyBuilderExtensions.HasColumnName<Guid?>(entity.Property<Guid?>((Expression<Func<UserPrivelagesIndex, Guid?>>)((UserPrivelagesIndex e) => e.EmployeeId)), "EmployeeID");
			entity.Property<string>((Expression<Func<UserPrivelagesIndex, string>>)((UserPrivelagesIndex e) => e.Module)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<UserPrivelagesIndex, string>>)((UserPrivelagesIndex e) => e.Privilege)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<UserPrivelagesIndex, string>>)((UserPrivelagesIndex e) => e.UserName)).HasMaxLength(128);
		});
		modelBuilder.Entity<UserPrivilage>((Action<EntityTypeBuilder<UserPrivilage>>)delegate(EntityTypeBuilder<UserPrivilage> entity)
		{
			entity.Property<Guid>((Expression<Func<UserPrivilage, Guid>>)((UserPrivilage e) => e.Id)).ValueGeneratedNever();
			RelationalForeignKeyBuilderExtensions.HasConstraintName<Privilege, UserPrivilage>(entity.HasOne<Privilege>((Expression<Func<UserPrivilage, Privilege>>)((UserPrivilage d) => d.Privilege)).WithMany((Expression<Func<Privilege, IEnumerable<UserPrivilage>>>)((Privilege p) => p.UserPrivilages)).HasForeignKey((Expression<Func<UserPrivilage, object>>)((UserPrivilage d) => d.PrivilegeId)), "FK_UserPrivilages_Privileges");
			RelationalForeignKeyBuilderExtensions.HasConstraintName<User, UserPrivilage>(entity.HasOne<User>((Expression<Func<UserPrivilage, User>>)((UserPrivilage d) => d.User)).WithMany((Expression<Func<User, IEnumerable<UserPrivilage>>>)((User p) => p.UserPrivilages)).HasForeignKey((Expression<Func<UserPrivilage, object>>)((UserPrivilage d) => d.UserId)), "FK_UserPrivilages_Users");
		});
		modelBuilder.Entity<VwBookingEvent>((Action<EntityTypeBuilder<VwBookingEvent>>)delegate(EntityTypeBuilder<VwBookingEvent> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<VwBookingEvent>(entity.HasNoKey(), "vwBookingEvents");
			entity.Property<string>((Expression<Func<VwBookingEvent, string>>)((VwBookingEvent e) => e.BookedBy)).HasMaxLength(100).IsUnicode(false);
			entity.Property<string>((Expression<Func<VwBookingEvent, string>>)((VwBookingEvent e) => e.BookedFrom)).HasMaxLength(100).IsUnicode(false);
			entity.Property<string>((Expression<Func<VwBookingEvent, string>>)((VwBookingEvent e) => e.Company)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<VwBookingEvent, DateTime?>>)((VwBookingEvent e) => e.DateBooked)), "datetime");
			entity.Property<string>((Expression<Func<VwBookingEvent, string>>)((VwBookingEvent e) => e.EmpRef)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<VwBookingEvent, DateTime?>>)((VwBookingEvent e) => e.EndDate)), "datetime");
			entity.Property<string>((Expression<Func<VwBookingEvent, string>>)((VwBookingEvent e) => e.EventDescription)).IsUnicode(false);
			entity.Property<string>((Expression<Func<VwBookingEvent, string>>)((VwBookingEvent e) => e.Gender)).HasMaxLength(10).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<VwBookingEvent, Guid>>)((VwBookingEvent e) => e.Id)), "ID");
			RelationalPropertyBuilderExtensions.HasColumnName<string>(entity.Property<string>((Expression<Func<VwBookingEvent, string>>)((VwBookingEvent e) => e.Idnumber)).HasMaxLength(50).IsUnicode(false), "IDNumber");
			RelationalPropertyBuilderExtensions.HasColumnName<bool?>(entity.Property<bool?>((Expression<Func<VwBookingEvent, bool?>>)((VwBookingEvent e) => e.IsDocumentationOk)), "IsDocumentationOK");
			entity.Property<string>((Expression<Func<VwBookingEvent, string>>)((VwBookingEvent e) => e.Notes)).IsUnicode(false);
			entity.Property<string>((Expression<Func<VwBookingEvent, string>>)((VwBookingEvent e) => e.Occupation)).HasMaxLength(50).IsUnicode(false);
			entity.Property<string>((Expression<Func<VwBookingEvent, string>>)((VwBookingEvent e) => e.Race)).HasMaxLength(10).IsUnicode(false);
			entity.Property<string>((Expression<Func<VwBookingEvent, string>>)((VwBookingEvent e) => e.ResourceName)).HasMaxLength(50);
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<VwBookingEvent, DateTime?>>)((VwBookingEvent e) => e.StartDate)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<VwBookingEvent, DateTime?>>)((VwBookingEvent e) => e.TransferDate)), "datetime");
			entity.Property<string>((Expression<Func<VwBookingEvent, string>>)((VwBookingEvent e) => e.Workplace)).HasMaxLength(50).IsUnicode(false);
		});
		modelBuilder.Entity<VwEmployeeLicense>((Action<EntityTypeBuilder<VwEmployeeLicense>>)delegate(EntityTypeBuilder<VwEmployeeLicense> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<VwEmployeeLicense>(entity.HasNoKey(), "vw_EmployeeLicenses");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<VwEmployeeLicense, DateTime?>>)((VwEmployeeLicense e) => e.DateIssued)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<VwEmployeeLicense, DateTime?>>)((VwEmployeeLicense e) => e.ExpiryDate)), "datetime");
			entity.Property<string>((Expression<Func<VwEmployeeLicense, string>>)((VwEmployeeLicense e) => e.LicenseName)).HasMaxLength(50).IsUnicode(false);
			RelationalPropertyBuilderExtensions.HasColumnName<Guid>(entity.Property<Guid>((Expression<Func<VwEmployeeLicense, Guid>>)((VwEmployeeLicense e) => e.LicenseTypeId)), "LicenseTypeID");
			entity.Property<string>((Expression<Func<VwEmployeeLicense, string>>)((VwEmployeeLicense e) => e.Restriction)).HasMaxLength(50).IsUnicode(false);
		});
		modelBuilder.Entity<VwLicensesAll>((Action<EntityTypeBuilder<VwLicensesAll>>)delegate(EntityTypeBuilder<VwLicensesAll> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<VwLicensesAll>(entity.HasNoKey(), "vw_Licenses_All");
			entity.Property<string>((Expression<Func<VwLicensesAll, string>>)((VwLicensesAll e) => e.Name)).HasMaxLength(50).IsUnicode(false);
		});
		modelBuilder.Entity<WfworkItem>((Action<EntityTypeBuilder<WfworkItem>>)delegate(EntityTypeBuilder<WfworkItem> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<WfworkItem>(entity, "WFWorkItem");
			entity.Property<Guid>((Expression<Func<WfworkItem, Guid>>)((WfworkItem e) => e.Id)).ValueGeneratedNever();
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<WfworkItem, DateTime?>>)((WfworkItem e) => e.DateCompleted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<WfworkItem, DateTime?>>)((WfworkItem e) => e.DateStarted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<WfworkItem, DateTime?>>)((WfworkItem e) => e.DateWithdrawn)), "datetime");
			entity.Property<string>((Expression<Func<WfworkItem, string>>)((WfworkItem e) => e.Description)).IsUnicode(false);
		});
		modelBuilder.Entity<WfworkType>((Action<EntityTypeBuilder<WfworkType>>)delegate(EntityTypeBuilder<WfworkType> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<WfworkType>(entity, "WFWorkTypes");
			entity.Property<Guid>((Expression<Func<WfworkType, Guid>>)((WfworkType e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<WfworkType, string>>)((WfworkType e) => e.EntityName)).IsUnicode(false);
			entity.Property<string>((Expression<Func<WfworkType, string>>)((WfworkType e) => e.WorkTypeName)).IsUnicode(false);
		});
		modelBuilder.Entity<WfworkitemIndex>((Action<EntityTypeBuilder<WfworkitemIndex>>)delegate(EntityTypeBuilder<WfworkitemIndex> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToView<WfworkitemIndex>(entity.HasNoKey(), "WFWorkitemIndex");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<WfworkitemIndex, DateTime?>>)((WfworkitemIndex e) => e.DateCompleted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<WfworkitemIndex, DateTime?>>)((WfworkitemIndex e) => e.DateStarted)), "datetime");
			RelationalPropertyBuilderExtensions.HasColumnType<DateTime?>(entity.Property<DateTime?>((Expression<Func<WfworkitemIndex, DateTime?>>)((WfworkitemIndex e) => e.DateWithdrawn)), "datetime");
			entity.Property<string>((Expression<Func<WfworkitemIndex, string>>)((WfworkitemIndex e) => e.Description)).IsUnicode(false);
			entity.Property<string>((Expression<Func<WfworkitemIndex, string>>)((WfworkitemIndex e) => e.WorkTypeName)).IsUnicode(false);
		});
		modelBuilder.Entity<Workplace>((Action<EntityTypeBuilder<Workplace>>)delegate(EntityTypeBuilder<Workplace> entity)
		{
			RelationalEntityTypeBuilderExtensions.ToTable<Workplace>(entity, "Workplace");
			entity.Property<Guid>((Expression<Func<Workplace, Guid>>)((Workplace e) => e.Id)).ValueGeneratedNever();
			entity.Property<string>((Expression<Func<Workplace, string>>)((Workplace e) => e.Description)).IsUnicode(false);
			entity.Property<string>((Expression<Func<Workplace, string>>)((Workplace e) => e.Name)).HasMaxLength(100).IsUnicode(false);
		});
	}
}
