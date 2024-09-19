using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HRMS.Models;

public partial class HrmstestContext : DbContext
{
    public HrmstestContext()
    {
    }

    public HrmstestContext(DbContextOptions<HrmstestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AnnouncementMaster> AnnouncementMasters { get; set; }

    public virtual DbSet<ApiLog> ApiLogs { get; set; }

    public virtual DbSet<Apicronjob> Apicronjobs { get; set; }

    public virtual DbSet<AssignReview> AssignReviews { get; set; }

    public virtual DbSet<Billmaster> Billmasters { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Claimdetail> Claimdetails { get; set; }

    public virtual DbSet<Claimsummary> Claimsummaries { get; set; }

    public virtual DbSet<ClientEmployeeMapping> ClientEmployeeMappings { get; set; }

    public virtual DbSet<ClientMaster> ClientMasters { get; set; }

    public virtual DbSet<ClientProjectMapping> ClientProjectMappings { get; set; }

    public virtual DbSet<CodeReview> CodeReviews { get; set; }

    public virtual DbSet<Comment> Comments { get; set; }

    public virtual DbSet<DesignationMaster> DesignationMasters { get; set; }

    public virtual DbSet<DeviceInformation> DeviceInformations { get; set; }

    public virtual DbSet<DeviceStatus> DeviceStatuses { get; set; }

    public virtual DbSet<Deviceevent> Deviceevents { get; set; }

    public virtual DbSet<Devicefetchlog> Devicefetchlogs { get; set; }

    public virtual DbSet<Deviceinfo> Deviceinfos { get; set; }

    public virtual DbSet<Deviceseqcount> Deviceseqcounts { get; set; }

    public virtual DbSet<Deviceuser> Deviceusers { get; set; }

    public virtual DbSet<Earningmaster> Earningmasters { get; set; }

    public virtual DbSet<Emaillog> Emaillogs { get; set; }

    public virtual DbSet<EmpOtherDocument> EmpOtherDocuments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeBuddyMapping> EmployeeBuddyMappings { get; set; }

    public virtual DbSet<EmployeeProjectMapping> EmployeeProjectMappings { get; set; }

    public virtual DbSet<EmployeeReview> EmployeeReviews { get; set; }

    public virtual DbSet<EmployeeReviewerMapping> EmployeeReviewerMappings { get; set; }

    public virtual DbSet<EmployeeSkillsetMapping> EmployeeSkillsetMappings { get; set; }

    public virtual DbSet<Employeelog> Employeelogs { get; set; }

    public virtual DbSet<Employeemaster> Employeemasters { get; set; }

    public virtual DbSet<Employeesalarytemplate> Employeesalarytemplates { get; set; }

    public virtual DbSet<Employeesalarytemplatedetail> Employeesalarytemplatedetails { get; set; }

    public virtual DbSet<Epf> Epfs { get; set; }

    public virtual DbSet<Esi> Esis { get; set; }

    public virtual DbSet<FailedJob> FailedJobs { get; set; }

    public virtual DbSet<Fptemplate> Fptemplates { get; set; }

    public virtual DbSet<Holiday> Holidays { get; set; }

    public virtual DbSet<Leaf> Leaves { get; set; }

    public virtual DbSet<Leavemaster> Leavemasters { get; set; }

    public virtual DbSet<Loan> Loans { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<LogOfTemplateApproval> LogOfTemplateApprovals { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<MoodTracker> MoodTrackers { get; set; }

    public virtual DbSet<NewPunchtime> NewPunchtimes { get; set; }

    public virtual DbSet<PasswordManage> PasswordManages { get; set; }

    public virtual DbSet<PasswordReset> PasswordResets { get; set; }

    public virtual DbSet<Payrolldepartment> Payrolldepartments { get; set; }

    public virtual DbSet<Payrun> Payruns { get; set; }

    public virtual DbSet<Payrundeduction> Payrundeductions { get; set; }

    public virtual DbSet<Payrunleaf> Payrunleaves { get; set; }

    public virtual DbSet<Payrunloan> Payrunloans { get; set; }

    public virtual DbSet<Payrunlosscollection> Payrunlosscollections { get; set; }

    public virtual DbSet<Payrunpayment> Payrunpayments { get; set; }

    public virtual DbSet<PersonalAccessToken> PersonalAccessTokens { get; set; }

    public virtual DbSet<Professionaltaxslab> Professionaltaxslabs { get; set; }

    public virtual DbSet<ProjectMaster> ProjectMasters { get; set; }

    public virtual DbSet<Pterm> Pterms { get; set; }

    public virtual DbSet<Punchtime> Punchtimes { get; set; }

    public virtual DbSet<Reimbursementmaster> Reimbursementmasters { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<RequestCategory> RequestCategories { get; set; }

    public virtual DbSet<ReviewParamMaster> ReviewParamMasters { get; set; }

    public virtual DbSet<Roledetail> Roledetails { get; set; }

    public virtual DbSet<Rolemaster> Rolemasters { get; set; }

    public virtual DbSet<Salaryrivision> Salaryrivisions { get; set; }

    public virtual DbSet<Salaryrivisiontemplate> Salaryrivisiontemplates { get; set; }

    public virtual DbSet<Salarytemplate> Salarytemplates { get; set; }

    public virtual DbSet<Salarytemplatesummary> Salarytemplatesummaries { get; set; }

    public virtual DbSet<SendToClientLog> SendToClientLogs { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<StoreCategory> StoreCategories { get; set; }

    public virtual DbSet<StoreItem> StoreItems { get; set; }

    public virtual DbSet<StoreStatus> StoreStatuses { get; set; }

    public virtual DbSet<TagMaster> TagMasters { get; set; }

    public virtual DbSet<TaskEmployeeMapping> TaskEmployeeMappings { get; set; }

    public virtual DbSet<TaskMaster> TaskMasters { get; set; }

    public virtual DbSet<TaskTrackingApiLog> TaskTrackingApiLogs { get; set; }

    public virtual DbSet<Taxis> Taxes { get; set; }

    public virtual DbSet<TempPunch> TempPunches { get; set; }

    public virtual DbSet<TemplateMaster> TemplateMasters { get; set; }

    public virtual DbSet<TemplateSkill> TemplateSkills { get; set; }

    public virtual DbSet<TemplateTopic> TemplateTopics { get; set; }

    public virtual DbSet<TimeTracking> TimeTrackings { get; set; }

    public virtual DbSet<Timerule> Timerules { get; set; }

    public virtual DbSet<TimesheetLog> TimesheetLogs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Worklocation> Worklocations { get; set; }

    public virtual DbSet<Workshift> Workshifts { get; set; }

    public virtual DbSet<Workshiftrule> Workshiftrules { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server=35.161.7.92;Database=hrmstest;User Id=hrmstest;Password=HwreMyT@2021;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnnouncementMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("announcement_master");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Detail)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("detail");
            entity.Property(e => e.File)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("file");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnType("enum('Active','InActive')")
                .HasColumnName("status");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ApiLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("api_log");

            entity.HasIndex(e => e.Channel, "seller_log_channel_index");

            entity.HasIndex(e => e.Level, "seller_log_level_index");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Channel)
                .HasMaxLength(191)
                .HasColumnName("channel");
            entity.Property(e => e.Context).HasColumnName("context");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Extra).HasColumnName("extra");
            entity.Property(e => e.Formatted).HasColumnName("formatted");
            entity.Property(e => e.Level)
                .HasMaxLength(191)
                .HasColumnName("level");
            entity.Property(e => e.LevelName)
                .HasMaxLength(191)
                .HasColumnName("level_name");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.RecordDatetime)
                .HasMaxLength(191)
                .HasColumnName("record_datetime");
            entity.Property(e => e.RemoteAddr)
                .HasMaxLength(191)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("remote_addr");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserAgent)
                .HasMaxLength(191)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("user_agent");
            entity.Property(e => e.UserId)
                .HasColumnType("int(255)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Apicronjob>(entity =>
        {
            entity.HasKey(e => e.Apicronjobid).HasName("PRIMARY");

            entity.ToTable("apicronjob");

            entity.Property(e => e.Apicronjobid)
                .HasColumnType("int(11)")
                .HasColumnName("apicronjobid");
            entity.Property(e => e.Api)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("api");
            entity.Property(e => e.Apitype)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("apitype");
            entity.Property(e => e.Apiuserid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(20)")
                .HasColumnName("apiuserid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.ResponseCode)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("response_code");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<AssignReview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("assign_review");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.EmpId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("emp_id");
            entity.Property(e => e.ReviewCount)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(3)")
                .HasColumnName("review_count");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.TotalReview)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(3)")
                .HasColumnName("total_review");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Billmaster>(entity =>
        {
            entity.HasKey(e => e.Billmasterid).HasName("PRIMARY");

            entity.ToTable("billmaster");

            entity.Property(e => e.Billmasterid)
                .HasColumnType("int(11)")
                .HasColumnName("billmasterid");
            entity.Property(e => e.Billno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("billno");
            entity.Property(e => e.Contactdetail)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("contactdetail");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("name");
            entity.Property(e => e.Purchasedate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("purchasedate");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Cityid).HasName("PRIMARY");

            entity.ToTable("cities");

            entity.Property(e => e.Cityid)
                .HasColumnType("int(11)")
                .HasColumnName("cityid");
            entity.Property(e => e.Cityname)
                .HasMaxLength(30)
                .HasColumnName("cityname");
            entity.Property(e => e.Stateid)
                .HasColumnType("int(11)")
                .HasColumnName("stateid");
        });

        modelBuilder.Entity<Claimdetail>(entity =>
        {
            entity.HasKey(e => e.Claimdetailid).HasName("PRIMARY");

            entity.ToTable("claimdetail");

            entity.Property(e => e.Claimdetailid)
                .HasColumnType("int(11)")
                .HasColumnName("claimdetailid");
            entity.Property(e => e.Amount)
                .HasPrecision(11)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("amount");
            entity.Property(e => e.Billdate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("billdate");
            entity.Property(e => e.Billno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("billno");
            entity.Property(e => e.Claimsummaryid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("claimsummaryid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Reimbursementid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("reimbursementid");
            entity.Property(e => e.Remarks)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("remarks");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Vendor)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("vendor");
        });

        modelBuilder.Entity<Claimsummary>(entity =>
        {
            entity.HasKey(e => e.Claimsummaryid).HasName("PRIMARY");

            entity.ToTable("claimsummary");

            entity.Property(e => e.Claimsummaryid)
                .HasColumnType("int(11)")
                .HasColumnName("claimsummaryid");
            entity.Property(e => e.Claimamount)
                .HasPrecision(11)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("claimamount");
            entity.Property(e => e.Claimdate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("claimdate");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Employeeid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("employeeid");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Pending'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ClientEmployeeMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("client_employee_mapping");

            entity.Property(e => e.Id)
                .HasColumnType("int(255)")
                .HasColumnName("id");
            entity.Property(e => e.ClientId)
                .HasColumnType("int(255)")
                .HasColumnName("client_id");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.EmpId)
                .HasColumnType("int(255)")
                .HasColumnName("emp_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ClientMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("client_master");

            entity.Property(e => e.Id)
                .HasColumnType("int(255)")
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(1000)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("address");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("city");
            entity.Property(e => e.ClientName)
                .HasMaxLength(255)
                .HasColumnName("client_name");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("country");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.Roleid)
                .HasColumnType("int(255)")
                .HasColumnName("roleid");
            entity.Property(e => e.State)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("state");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnType("enum('Active','InActive')")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId)
                .HasColumnType("int(255)")
                .HasColumnName("user_id");
            entity.Property(e => e.Website)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("website");
            entity.Property(e => e.Zipcode)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("zipcode");
        });

        modelBuilder.Entity<ClientProjectMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("client_project_mapping");

            entity.Property(e => e.Id)
                .HasColumnType("int(255)")
                .HasColumnName("id");
            entity.Property(e => e.ClientId)
                .HasColumnType("int(255)")
                .HasColumnName("client_id");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.ProjectId)
                .HasColumnType("int(255)")
                .HasColumnName("project_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CodeReview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("code_review");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(21)")
                .HasColumnName("id");
            entity.Property(e => e.Buddyid)
                .HasDefaultValueSql("'NULL'")
                .HasComment("emp_id")
                .HasColumnType("int(11)")
                .HasColumnName("buddyid");
            entity.Property(e => e.CodeDescription)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("code_description");
            entity.Property(e => e.CodeImage)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("code_image");
            entity.Property(e => e.ContinueText)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("continue_text");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Mentorid)
                .HasDefaultValueSql("'NULL'")
                .HasComment("user_id")
                .HasColumnType("int(11)")
                .HasColumnName("mentorid");
            entity.Property(e => e.Projectid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("projectid");
            entity.Property(e => e.Rating)
                .HasPrecision(4)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("rating");
            entity.Property(e => e.ReviewStatus)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Pending'''")
                .HasColumnName("review_status");
            entity.Property(e => e.StartText)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("start_text");
            entity.Property(e => e.Status)
                .HasMaxLength(25)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.StopText)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("stop_text");
            entity.Property(e => e.Tagid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("tagid");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("comments");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(21)")
                .HasColumnName("id");
            entity.Property(e => e.CodeReviewid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(11)")
                .HasColumnName("code_reviewid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Message)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.Reply)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("reply");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.Userid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<DesignationMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("designation_master");

            entity.Property(e => e.Id)
                .HasColumnType("int(255)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<DeviceInformation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("device_information");

            entity.Property(e => e.ActionBy)
                .HasColumnType("int(10)")
                .HasColumnName("action_by");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.DeviceId)
                .HasColumnType("int(11)")
                .HasColumnName("device_id");
            entity.Property(e => e.DeviceIp)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("device_ip");
            entity.Property(e => e.DeviceName)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("device_name");
            entity.Property(e => e.DevicePort)
                .HasColumnType("int(5)")
                .HasColumnName("device_port");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(20)
                .HasDefaultValueSql("'''0'''")
                .HasColumnName("serial_number");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.WanIp)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("wan_ip");
            entity.Property(e => e.WanPort)
                .HasColumnType("int(5)")
                .HasColumnName("wan_port");
        });

        modelBuilder.Entity<DeviceStatus>(entity =>
        {
            entity.HasKey(e => e.DeviceStatus1).HasName("PRIMARY");

            entity.ToTable("device_status");

            entity.Property(e => e.DeviceStatus1)
                .HasColumnType("bigint(20)")
                .HasColumnName("device_status");
            entity.Property(e => e.Extra)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("extra");
            entity.Property(e => e.Ip)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("ip");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Deviceevent>(entity =>
        {
            entity.HasKey(e => e.Deviceeventid).HasName("PRIMARY");

            entity.ToTable("deviceevent");

            entity.Property(e => e.Deviceeventid)
                .HasColumnType("int(11)")
                .HasColumnName("deviceeventid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Date)
                .HasMaxLength(191)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("date");
            entity.Property(e => e.Detail1)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("detail1");
            entity.Property(e => e.Detail2)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("detail2");
            entity.Property(e => e.Detail3)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("detail3");
            entity.Property(e => e.Detail4)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("detail4");
            entity.Property(e => e.Detail5)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("detail5");
            entity.Property(e => e.Deviceid)
                .HasColumnType("int(11)")
                .HasColumnName("deviceid");
            entity.Property(e => e.Eventid)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("eventid");
            entity.Property(e => e.Rollovercount)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("rollovercount");
            entity.Property(e => e.Seqno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("seqno");
            entity.Property(e => e.Time)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("time");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Devicefetchlog>(entity =>
        {
            entity.HasKey(e => e.Deviceeventid).HasName("PRIMARY");

            entity.ToTable("devicefetchlogs");

            entity.Property(e => e.Deviceeventid)
                .HasColumnType("int(11)")
                .HasColumnName("deviceeventid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Detail1)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("detail1");
            entity.Property(e => e.Detail2)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("detail2");
            entity.Property(e => e.Detail3)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("detail3");
            entity.Property(e => e.Detail4)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("detail4");
            entity.Property(e => e.Detail5)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("detail5");
            entity.Property(e => e.Eventid)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("eventid");
            entity.Property(e => e.Rollovercount)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("rollovercount");
            entity.Property(e => e.Seqno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("seqno");
            entity.Property(e => e.Time)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("time")
                .HasColumnName("time");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Deviceinfo>(entity =>
        {
            entity.HasKey(e => e.Deviceinfoid).HasName("PRIMARY");

            entity.ToTable("deviceinfo");

            entity.Property(e => e.Deviceinfoid)
                .HasColumnType("int(11)")
                .HasColumnName("deviceinfoid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Devicecode)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("devicecode");
            entity.Property(e => e.Devicename)
                .HasMaxLength(191)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("devicename");
            entity.Property(e => e.Devicetype)
                .HasMaxLength(191)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("devicetype");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("ipaddress");
            entity.Property(e => e.Location)
                .HasMaxLength(191)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("location");
            entity.Property(e => e.Main)
                .HasColumnType("int(11)")
                .HasColumnName("main");
            entity.Property(e => e.Password)
                .HasMaxLength(191)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("password");
            entity.Property(e => e.Portno)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("portno");
            entity.Property(e => e.Productname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("productname");
            entity.Property(e => e.Reader)
                .HasMaxLength(191)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("reader");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Username)
                .HasMaxLength(191)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("username");
        });

        modelBuilder.Entity<Deviceseqcount>(entity =>
        {
            entity.HasKey(e => e.Deviceseqcountid).HasName("PRIMARY");

            entity.ToTable("deviceseqcount");

            entity.Property(e => e.Deviceseqcountid)
                .HasColumnType("int(11)")
                .HasColumnName("deviceseqcountid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Deviceid)
                .HasColumnType("int(11)")
                .HasColumnName("deviceid");
            entity.Property(e => e.Rollovercount)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("rollovercount");
            entity.Property(e => e.Seqno)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("seqno");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Deviceuser>(entity =>
        {
            entity.HasKey(e => e.Deviceusersid).HasName("PRIMARY");

            entity.ToTable("deviceusers");

            entity.Property(e => e.Deviceusersid)
                .HasColumnType("bigint(20)")
                .HasColumnName("deviceusersid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Deviceinfoid)
                .HasColumnType("int(11)")
                .HasColumnName("deviceinfoid");
            entity.Property(e => e.Devicestatus)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("devicestatus");
            entity.Property(e => e.Employeeid)
                .HasColumnType("bigint(20)")
                .HasColumnName("employeeid");
            entity.Property(e => e.Enroll)
                .HasColumnType("int(11)")
                .HasColumnName("enroll");
            entity.Property(e => e.Enrollcardno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("enrollcardno");
            entity.Property(e => e.Expirydate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("expirydate");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Uploadfptemplate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'''No'''")
                .HasColumnName("uploadfptemplate");
        });

        modelBuilder.Entity<Earningmaster>(entity =>
        {
            entity.HasKey(e => e.Earningmasterid).HasName("PRIMARY");

            entity.ToTable("earningmaster");

            entity.Property(e => e.Earningmasterid)
                .HasColumnType("int(11)")
                .HasColumnName("earningmasterid");
            entity.Property(e => e.Amount)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("amount");
            entity.Property(e => e.Calculationtype)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("calculationtype");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("name");
            entity.Property(e => e.Payslipname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("payslipname");
            entity.Property(e => e.Paytype)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("paytype");
            entity.Property(e => e.Percentage)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("percentage");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Emaillog>(entity =>
        {
            entity.HasKey(e => e.Logid).HasName("PRIMARY");

            entity.ToTable("emaillog");

            entity.Property(e => e.Logid)
                .HasColumnType("int(11)")
                .HasColumnName("logid");
            entity.Property(e => e.Body)
                .HasColumnType("text")
                .HasColumnName("body");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Subject)
                .HasColumnType("text")
                .HasColumnName("subject");
            entity.Property(e => e.Toemail)
                .HasColumnType("text")
                .HasColumnName("toemail");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<EmpOtherDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("emp_other_documents");

            entity.Property(e => e.Id)
                .HasColumnType("int(255)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.EmpId)
                .HasColumnType("int(255)")
                .HasColumnName("emp_id");
            entity.Property(e => e.OtherDoc)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("other_doc");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Employeeid).HasName("PRIMARY");

            entity.ToTable("employee");

            entity.Property(e => e.Employeeid)
                .HasColumnType("int(11)")
                .HasColumnName("employeeid");
            entity.Property(e => e.Aadharback)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("aadharback");
            entity.Property(e => e.Aadharcardno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("aadharcardno");
            entity.Property(e => e.Aadharfront)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("aadharfront");
            entity.Property(e => e.Accommodation)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("accommodation");
            entity.Property(e => e.Applicantresume)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("applicantresume");
            entity.Property(e => e.Bankaccountnumber)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20)")
                .HasColumnName("bankaccountnumber");
            entity.Property(e => e.Bankbranch)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("bankbranch");
            entity.Property(e => e.Bankdetailsaccounttype)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("bankdetailsaccounttype");
            entity.Property(e => e.Bankholdername)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("bankholdername");
            entity.Property(e => e.Bankifscode)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("bankifscode");
            entity.Property(e => e.Bankname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("bankname");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Dateofjoining)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("dateofjoining");
            entity.Property(e => e.Dateofregine)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("dateofregine");
            entity.Property(e => e.Department)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("department");
            entity.Property(e => e.Drivinglicense)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("drivinglicense");
            entity.Property(e => e.EdittrackingStatus)
                .HasMaxLength(10)
                .HasDefaultValueSql("'''OFF'''")
                .HasColumnName("edittracking_status");
            entity.Property(e => e.Employeebloodgroup)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeebloodgroup");
            entity.Property(e => e.Employeecode)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeecode");
            entity.Property(e => e.Employeecodeid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("employeecodeid");
            entity.Property(e => e.Employeecontactno1)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeecontactno1");
            entity.Property(e => e.Employeecontactno2)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20)")
                .HasColumnName("employeecontactno2");
            entity.Property(e => e.Employeecurrentaddress)
                .HasMaxLength(1000)
                .HasColumnName("employeecurrentaddress");
            entity.Property(e => e.Employeecurrentcity)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeecurrentcity");
            entity.Property(e => e.Employeedob)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("employeedob");
            entity.Property(e => e.Employeeeaddress)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeeeaddress");
            entity.Property(e => e.Employeeecity)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeeecity");
            entity.Property(e => e.Employeeecurrentpincode)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeeecurrentpincode");
            entity.Property(e => e.Employeeemailid)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeeemailid");
            entity.Property(e => e.Employeeepincode)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeeepincode");
            entity.Property(e => e.Employeefirstname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeefirstname");
            entity.Property(e => e.Employeegender)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeegender");
            entity.Property(e => e.Employeelastname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeelastname");
            entity.Property(e => e.Employeemaritalstatus)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeemaritalstatus");
            entity.Property(e => e.Employeestate)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeestate");
            entity.Property(e => e.Employeetype)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeetype");
            entity.Property(e => e.Employeewhatsappnumber)
                .HasMaxLength(15)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeewhatsappnumber");
            entity.Property(e => e.Esiapplicable)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("esiapplicable");
            entity.Property(e => e.Esidispensary)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("esidispensary");
            entity.Property(e => e.Esinumber)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("esinumber");
            entity.Property(e => e.ExperianceYear)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(10)")
                .HasColumnName("experiance_year");
            entity.Property(e => e.Experience)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("experience");
            entity.Property(e => e.Expirydate)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("expirydate");
            entity.Property(e => e.Facebook)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("facebook");
            entity.Property(e => e.Icedetailscontactno1)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("icedetailscontactno1");
            entity.Property(e => e.Icedetailscontactno2)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("icedetailscontactno2");
            entity.Property(e => e.Icedetailsname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("icedetailsname");
            entity.Property(e => e.Icedetailsrelationship)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("icedetailsrelationship");
            entity.Property(e => e.Instagram)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("instagram");
            entity.Property(e => e.JobProfile)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("job_profile");
            entity.Property(e => e.Jobdesignation)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("jobdesignation");
            entity.Property(e => e.Leftservice)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("leftservice");
            entity.Property(e => e.Leftservicedate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("leftservicedate");
            entity.Property(e => e.Leftservicereason)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("leftservicereason");
            entity.Property(e => e.Linkedin)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("linkedin");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("location");
            entity.Property(e => e.Otapplicable)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("otapplicable");
            entity.Property(e => e.Otherreferencename)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("otherreferencename");
            entity.Property(e => e.Otherreferenceno)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20)")
                .HasColumnName("otherreferenceno");
            entity.Property(e => e.Pancard)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("pancard");
            entity.Property(e => e.Pancardno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("pancardno");
            entity.Property(e => e.Passportno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("passportno");
            entity.Property(e => e.Pfaccountno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("pfaccountno");
            entity.Property(e => e.Pfapplicable)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("pfapplicable");
            entity.Property(e => e.Pfdoj)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("pfdoj");
            entity.Property(e => e.Photo)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("photo");
            entity.Property(e => e.PreviousCompanyname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("previous_companyname");
            entity.Property(e => e.PunchtimeSmsStatus)
                .HasMaxLength(10)
                .HasDefaultValueSql("'''ON'''")
                .HasColumnName("punchtime_sms_status");
            entity.Property(e => e.Referenceempname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("referenceempname");
            entity.Property(e => e.Referenceempno)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20)")
                .HasColumnName("referenceempno");
            entity.Property(e => e.Referencefromcurrentemp)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("referencefromcurrentemp");
            entity.Property(e => e.Remindonexpiry)
                .HasMaxLength(255)
                .HasColumnName("remindonexpiry");
            entity.Property(e => e.ReviewCount)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(3)")
                .HasColumnName("review_count");
            entity.Property(e => e.Roleid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("roleid");
            entity.Property(e => e.Shift)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("shift");
            entity.Property(e => e.SmsStatus)
                .HasMaxLength(10)
                .HasDefaultValueSql("'''ON'''")
                .HasColumnName("sms_status");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.Subdepartment)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("subdepartment");
            entity.Property(e => e.TShirtsize)
                .HasMaxLength(10)
                .HasColumnName("t_shirtsize");
            entity.Property(e => e.TrackingSmsStatus)
                .HasMaxLength(10)
                .HasDefaultValueSql("'''ON'''")
                .HasColumnName("tracking_sms_status");
            entity.Property(e => e.Twitter)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("twitter");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Userid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("userid");
            entity.Property(e => e.WorkfromStatus)
                .HasMaxLength(25)
                .HasDefaultValueSql("'''NotAllow'''")
                .HasColumnName("workfrom_status");
        });

        modelBuilder.Entity<EmployeeBuddyMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("employee_buddy_mapping");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.EmpId)
                .HasColumnType("int(11)")
                .HasColumnName("emp_id");
            entity.Property(e => e.ParentEmpId)
                .HasColumnType("int(11)")
                .HasColumnName("parent_emp_id");
            entity.Property(e => e.ReviewCount)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(3)")
                .HasColumnName("review_count");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<EmployeeProjectMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("employee_project_mapping");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("int(11)")
                .HasColumnName("created_at");
            entity.Property(e => e.EmpId)
                .HasColumnType("int(11)")
                .HasColumnName("emp_id");
            entity.Property(e => e.ProjectId)
                .HasColumnType("int(11)")
                .HasColumnName("project_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<EmployeeReview>(entity =>
        {
            entity.HasKey(e => e.EmployeeReviewId).HasName("PRIMARY");

            entity.ToTable("employee_review");

            entity.Property(e => e.EmployeeReviewId)
                .HasColumnType("int(11)")
                .HasColumnName("employee_review_id");
            entity.Property(e => e.Buddyid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("buddyid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Mentorid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("mentorid");
            entity.Property(e => e.OverallComment)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("overall_comment");
            entity.Property(e => e.OverallRating)
                .HasPrecision(11)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("overall_rating");
            entity.Property(e => e.Param10Comment)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param10_comment");
            entity.Property(e => e.Param10Rating)
                .HasPrecision(11)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param10_rating");
            entity.Property(e => e.Param1Comment)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param1_comment");
            entity.Property(e => e.Param1Rating)
                .HasPrecision(11)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param1_rating");
            entity.Property(e => e.Param2Comment)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param2_comment");
            entity.Property(e => e.Param2Rating)
                .HasPrecision(11)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param2_rating");
            entity.Property(e => e.Param3Comment)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param3_comment");
            entity.Property(e => e.Param3Rating)
                .HasPrecision(11)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param3_rating");
            entity.Property(e => e.Param4Comment)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param4_comment");
            entity.Property(e => e.Param4Rating)
                .HasPrecision(11)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param4_rating");
            entity.Property(e => e.Param5Comment)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param5_comment");
            entity.Property(e => e.Param5Rating)
                .HasPrecision(11)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param5_rating");
            entity.Property(e => e.Param6Comment)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param6_comment");
            entity.Property(e => e.Param6Rating)
                .HasPrecision(11)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param6_rating");
            entity.Property(e => e.Param7Comment)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param7_comment");
            entity.Property(e => e.Param7Rating)
                .HasPrecision(11)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param7_rating");
            entity.Property(e => e.Param8Comment)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param8_comment");
            entity.Property(e => e.Param8Rating)
                .HasPrecision(11)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param8_rating");
            entity.Property(e => e.Param9Comment)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param9_comment");
            entity.Property(e => e.Param9Rating)
                .HasPrecision(11)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("param9_rating");
            entity.Property(e => e.PrivateComment)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("private_comment");
            entity.Property(e => e.PrivateRating)
                .HasPrecision(3)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("private_rating");
            entity.Property(e => e.Projectid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("projectid");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.Tagid)
                .HasMaxLength(255)
                .HasColumnName("tagid");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<EmployeeReviewerMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("employee_reviewer_mapping");

            entity.Property(e => e.Id)
                .HasColumnType("int(255)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.EmpId)
                .HasColumnType("int(255)")
                .HasColumnName("emp_id");
            entity.Property(e => e.ReviewCount)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(3)")
                .HasColumnName("review_count");
            entity.Property(e => e.ReviewerId)
                .HasColumnType("int(255)")
                .HasColumnName("reviewer_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<EmployeeSkillsetMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("employee_skillset_mapping");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("id");
            entity.Property(e => e.ApprovedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("approved_at");
            entity.Property(e => e.Approver)
                .HasColumnType("bigint(20)")
                .HasColumnName("approver");
            entity.Property(e => e.Comment)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.CompletedStatus).HasColumnName("completed_status");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.EmpId)
                .HasColumnType("int(11)")
                .HasColumnName("emp_id");
            entity.Property(e => e.Rating)
                .HasPrecision(4)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("rating");
            entity.Property(e => e.SkillsId)
                .HasColumnType("bigint(20)")
                .HasColumnName("skills_id");
            entity.Property(e => e.SubmitComment)
                .HasMaxLength(1000)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("submitComment");
            entity.Property(e => e.SubmitForApproval)
                .HasDefaultValueSql("'''yet_to_submit'''")
                .HasColumnType("enum('yet_to_submit','Pending','approved','rejected')")
                .HasColumnName("submit_for_approval");
            entity.Property(e => e.SubmitForApprovalAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("submit_for_approval_at");
            entity.Property(e => e.TaskId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20)")
                .HasColumnName("task_id");
            entity.Property(e => e.TemplateId)
                .HasColumnType("bigint(20)")
                .HasColumnName("template_id");
            entity.Property(e => e.TimeTaken)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("time_taken");
            entity.Property(e => e.TopicId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20)")
                .HasColumnName("topic_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Employeelog>(entity =>
        {
            entity.HasKey(e => e.Emplogid).HasName("PRIMARY");

            entity.ToTable("employeelog");

            entity.Property(e => e.Emplogid)
                .HasColumnType("bigint(20)")
                .HasColumnName("emplogid");
            entity.Property(e => e.Actionby)
                .HasColumnType("bigint(20)")
                .HasColumnName("actionby");
            entity.Property(e => e.Checkin)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("time")
                .HasColumnName("checkin");
            entity.Property(e => e.Checkout)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("time")
                .HasColumnName("checkout");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Punchdate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("punchdate");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(20)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<Employeemaster>(entity =>
        {
            entity.HasKey(e => e.Employeeid).HasName("PRIMARY");

            entity.ToTable("employeemaster");

            entity.Property(e => e.Employeeid)
                .HasColumnType("int(20)")
                .HasColumnName("employeeid");
            entity.Property(e => e.Aadharback)
                .HasMaxLength(255)
                .HasColumnName("aadharback");
            entity.Property(e => e.Aadharfront)
                .HasMaxLength(255)
                .HasColumnName("aadharfront");
            entity.Property(e => e.Acccountnumber)
                .HasMaxLength(255)
                .HasColumnName("acccountnumber");
            entity.Property(e => e.Accomodation)
                .HasMaxLength(255)
                .HasColumnName("accomodation");
            entity.Property(e => e.Accounttype)
                .HasMaxLength(1)
                .HasColumnName("accounttype");
            entity.Property(e => e.Address)
                .HasColumnType("text")
                .HasColumnName("address");
            entity.Property(e => e.Bloodgroup)
                .HasMaxLength(50)
                .HasColumnName("bloodgroup");
            entity.Property(e => e.Branchname)
                .HasMaxLength(255)
                .HasColumnName("branchname");
            entity.Property(e => e.Cityid)
                .HasColumnType("int(20)")
                .HasColumnName("cityid");
            entity.Property(e => e.Contactno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("contactno");
            entity.Property(e => e.Dateofbirth)
                .HasColumnType("date")
                .HasColumnName("dateofbirth");
            entity.Property(e => e.Dateofjoining)
                .HasColumnType("date")
                .HasColumnName("dateofjoining");
            entity.Property(e => e.Dateofleaving)
                .HasColumnType("date")
                .HasColumnName("dateofleaving");
            entity.Property(e => e.Deptid)
                .HasColumnType("int(20)")
                .HasColumnName("deptid");
            entity.Property(e => e.Designationid)
                .HasColumnType("int(20)")
                .HasColumnName("designationid");
            entity.Property(e => e.Dojofpf)
                .HasColumnType("date")
                .HasColumnName("dojofpf");
            entity.Property(e => e.Drivinglicense)
                .HasMaxLength(255)
                .HasColumnName("drivinglicense");
            entity.Property(e => e.Emailid)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("emailid");
            entity.Property(e => e.Employeecode)
                .HasMaxLength(50)
                .HasColumnName("employeecode");
            entity.Property(e => e.Employeetype)
                .HasMaxLength(1)
                .HasColumnName("employeetype");
            entity.Property(e => e.Esiapplicable)
                .HasMaxLength(1)
                .HasColumnName("esiapplicable");
            entity.Property(e => e.Esidispensaryname)
                .HasMaxLength(255)
                .HasColumnName("esidispensaryname");
            entity.Property(e => e.Esinumber)
                .HasMaxLength(50)
                .HasColumnName("esinumber");
            entity.Property(e => e.Expiredate)
                .HasColumnType("date")
                .HasColumnName("expiredate");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasColumnName("firstname");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .HasColumnName("gender");
            entity.Property(e => e.Icecontactno)
                .HasMaxLength(10)
                .HasColumnName("icecontactno");
            entity.Property(e => e.Icefullname)
                .HasMaxLength(255)
                .HasColumnName("icefullname");
            entity.Property(e => e.Icemobileno)
                .HasMaxLength(10)
                .HasColumnName("icemobileno");
            entity.Property(e => e.Icerelationship)
                .HasMaxLength(255)
                .HasColumnName("icerelationship");
            entity.Property(e => e.Ifsccode)
                .HasMaxLength(255)
                .HasColumnName("ifsccode");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .HasColumnName("lastname");
            entity.Property(e => e.Leavereason)
                .HasColumnType("text")
                .HasColumnName("leavereason");
            entity.Property(e => e.Locationid)
                .HasColumnType("int(20)")
                .HasColumnName("locationid");
            entity.Property(e => e.Maritalstatus)
                .HasMaxLength(50)
                .HasColumnName("maritalstatus");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("mobileno");
            entity.Property(e => e.Nameasperbank)
                .HasMaxLength(255)
                .HasColumnName("nameasperbank");
            entity.Property(e => e.Otapplicable)
                .HasMaxLength(1)
                .HasColumnName("otapplicable");
            entity.Property(e => e.Pancard)
                .HasMaxLength(255)
                .HasColumnName("pancard");
            entity.Property(e => e.Pfaccnumber)
                .HasMaxLength(50)
                .HasColumnName("pfaccnumber");
            entity.Property(e => e.Pfapplicable)
                .HasMaxLength(1)
                .HasColumnName("pfapplicable");
            entity.Property(e => e.Photo)
                .HasMaxLength(255)
                .HasColumnName("photo");
            entity.Property(e => e.Pincode)
                .HasMaxLength(10)
                .HasColumnName("pincode");
            entity.Property(e => e.Refbycontactno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("refbycontactno");
            entity.Property(e => e.Refbyname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("refbyname");
            entity.Property(e => e.Resume)
                .HasMaxLength(255)
                .HasColumnName("resume");
            entity.Property(e => e.Shift)
                .HasMaxLength(1)
                .HasColumnName("shift");
            entity.Property(e => e.Stateid)
                .HasColumnType("int(20)")
                .HasColumnName("stateid");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.Subdeptid)
                .HasColumnType("int(20)")
                .HasColumnName("subdeptid");
        });

        modelBuilder.Entity<Employeesalarytemplate>(entity =>
        {
            entity.HasKey(e => e.Employeesalarytemplateid).HasName("PRIMARY");

            entity.ToTable("employeesalarytemplate");

            entity.Property(e => e.Employeesalarytemplateid)
                .HasColumnType("int(11)")
                .HasColumnName("employeesalarytemplateid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("deleted");
            entity.Property(e => e.Employeeid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("employeeid");
            entity.Property(e => e.Perfomancebonus)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("perfomancebonus");
            entity.Property(e => e.Salary)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20)")
                .HasColumnName("salary");
            entity.Property(e => e.Salarytemplateid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("salarytemplateid");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.Totalctcannually)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("totalctcannually");
            entity.Property(e => e.Totalctcmonthly)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("totalctcmonthly");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Employeesalarytemplatedetail>(entity =>
        {
            entity.HasKey(e => e.Employeesalarytemplatedetailid).HasName("PRIMARY");

            entity.ToTable("employeesalarytemplatedetail");

            entity.Property(e => e.Employeesalarytemplatedetailid)
                .HasColumnType("bigint(20)")
                .HasColumnName("employeesalarytemplatedetailid");
            entity.Property(e => e.Amtannually)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("amtannually");
            entity.Property(e => e.Amtmonthly)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("amtmonthly");
            entity.Property(e => e.Calculationtype)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("calculationtype");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Employeesalarytemplateid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20)")
                .HasColumnName("employeesalarytemplateid");
            entity.Property(e => e.Salarycomponent)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("salarycomponent");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Epf>(entity =>
        {
            entity.HasKey(e => e.Epfid).HasName("PRIMARY");

            entity.ToTable("epf");

            entity.Property(e => e.Epfid)
                .HasColumnType("int(11)")
                .HasColumnName("epfid");
            entity.Property(e => e.Contributionrate)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("contributionrate");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Deductioncycle)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("deductioncycle");
            entity.Property(e => e.Employeescontribution)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeescontribution");
            entity.Property(e => e.Employerscontribution)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employerscontribution");
            entity.Property(e => e.Epfnumber)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("epfnumber");
            entity.Property(e => e.Inctc)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("inctc");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Esi>(entity =>
        {
            entity.HasKey(e => e.Esiid).HasName("PRIMARY");

            entity.ToTable("esi");

            entity.Property(e => e.Esiid)
                .HasColumnType("int(11)")
                .HasColumnName("esiid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Deductioncycle)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("deductioncycle");
            entity.Property(e => e.Employeescontribution)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("employeescontribution");
            entity.Property(e => e.Employercontribution)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("employercontribution");
            entity.Property(e => e.Esinumber)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("esinumber");
            entity.Property(e => e.Inctc)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("inctc");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<FailedJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("failed_jobs");

            entity.HasIndex(e => e.Uuid, "failed_jobs_uuid_unique").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Connection)
                .HasColumnType("text")
                .HasColumnName("connection");
            entity.Property(e => e.Exception).HasColumnName("exception");
            entity.Property(e => e.FailedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("failed_at");
            entity.Property(e => e.Payload).HasColumnName("payload");
            entity.Property(e => e.Queue)
                .HasColumnType("text")
                .HasColumnName("queue");
            entity.Property(e => e.Uuid)
                .HasMaxLength(191)
                .HasColumnName("uuid");
        });

        modelBuilder.Entity<Fptemplate>(entity =>
        {
            entity.HasKey(e => e.Fptemplateid).HasName("PRIMARY");

            entity.ToTable("fptemplate");

            entity.Property(e => e.Fptemplateid)
                .HasColumnType("int(11)")
                .HasColumnName("fptemplateid");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Employeeid)
                .HasColumnType("int(11)")
                .HasColumnName("employeeid");
            entity.Property(e => e.Finger)
                .HasMaxLength(30)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("finger");
            entity.Property(e => e.Fingercount)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("fingercount");
            entity.Property(e => e.Fptemplate1)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("fptemplate");
            entity.Property(e => e.Hand)
                .HasMaxLength(30)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("hand");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Holiday>(entity =>
        {
            entity.HasKey(e => e.Holidaysid).HasName("PRIMARY");

            entity.ToTable("holidays");

            entity.Property(e => e.Holidaysid)
                .HasColumnType("int(11)")
                .HasColumnName("holidaysid");
            entity.Property(e => e.Calendardays)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("calendardays");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Holidaysdate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("holidaysdate");
            entity.Property(e => e.Month)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("month");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.Totalholidays)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("totalholidays");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Leaf>(entity =>
        {
            entity.HasKey(e => e.Leaveid).HasName("PRIMARY");

            entity.ToTable("leaves");

            entity.Property(e => e.Leaveid)
                .HasColumnType("int(11)")
                .HasColumnName("leaveid");
            entity.Property(e => e.ClientRemarks)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("client_remarks");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Employeeid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("employeeid");
            entity.Property(e => e.FlagId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("flag_id");
            entity.Property(e => e.HalfTime)
                .HasMaxLength(10)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("half_time");
            entity.Property(e => e.LeaveStatus)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Pending'''")
                .HasColumnName("leave_status");
            entity.Property(e => e.Leavedate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("leavedate");
            entity.Property(e => e.Leavefromdate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("leavefromdate");
            entity.Property(e => e.Leavetodate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("leavetodate");
            entity.Property(e => e.Leavetype)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("leavetype");
            entity.Property(e => e.Reason)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("reason");
            entity.Property(e => e.Remainleave)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("double(11,2)")
                .HasColumnName("remainleave");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.Totalleave)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("double(11,2)")
                .HasColumnName("totalleave");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Leavemaster>(entity =>
        {
            entity.HasKey(e => e.Leavemasterid).HasName("PRIMARY");

            entity.ToTable("leavemaster");

            entity.Property(e => e.Leavemasterid)
                .HasColumnType("int(11)")
                .HasColumnName("leavemasterid");
            entity.Property(e => e.AllowAfterTake)
                .HasMaxLength(10)
                .HasDefaultValueSql("'''No'''")
                .HasColumnName("allow_after_take");
            entity.Property(e => e.AllowHalfLeave)
                .HasMaxLength(10)
                .HasDefaultValueSql("'''No'''")
                .HasColumnName("allow_half_leave");
            entity.Property(e => e.Carryfoward)
                .HasMaxLength(30)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("carryfoward");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Leavedays)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("double(11,2)")
                .HasColumnName("leavedays");
            entity.Property(e => e.Leavename)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("leavename");
            entity.Property(e => e.Leaverepeat)
                .HasMaxLength(30)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("leaverepeat");
            entity.Property(e => e.Nameinpayslip)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("nameinpayslip");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Loan>(entity =>
        {
            entity.HasKey(e => e.Loanid).HasName("PRIMARY");

            entity.ToTable("loans");

            entity.Property(e => e.Loanid)
                .HasColumnType("int(11)")
                .HasColumnName("loanid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Disbursementdate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("disbursementdate");
            entity.Property(e => e.EmiAmount)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("double(11,2)")
                .HasColumnName("emi_amount");
            entity.Property(e => e.EmiStartdate)
                .HasColumnType("datetime")
                .HasColumnName("emi_startdate");
            entity.Property(e => e.Employeeid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("employeeid");
            entity.Property(e => e.Loanamount)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("double(11,2)")
                .HasColumnName("loanamount");
            entity.Property(e => e.Reason)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("reason");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("location");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Extra)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("extra");
            entity.Property(e => e.Locationname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("locationname");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<LogOfTemplateApproval>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("log_of_template_approvals");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("id");
            entity.Property(e => e.Approver)
                .HasColumnType("bigint(20)")
                .HasColumnName("approver");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.EmpId)
                .HasColumnType("bigint(20)")
                .HasColumnName("emp_id");
            entity.Property(e => e.EmpSkillsetMappingId)
                .HasColumnType("bigint(20)")
                .HasColumnName("emp_skillset_mapping_id");
            entity.Property(e => e.SkillsId)
                .HasColumnType("bigint(20)")
                .HasColumnName("skills_id");
            entity.Property(e => e.SubmitForApproval)
                .HasDefaultValueSql("'''yet_to_submit'''")
                .HasColumnType("enum('yet_to_submit','pending','approved','rejected')")
                .HasColumnName("submit_for_approval");
            entity.Property(e => e.TemplateId)
                .HasColumnType("bigint(20)")
                .HasColumnName("template_id");
            entity.Property(e => e.TopicId)
                .HasColumnType("bigint(20)")
                .HasColumnName("topic_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("migrations");

            entity.Property(e => e.Id)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Batch)
                .HasColumnType("int(11)")
                .HasColumnName("batch");
            entity.Property(e => e.Migration1)
                .HasMaxLength(255)
                .HasColumnName("migration");
        });

        modelBuilder.Entity<MoodTracker>(entity =>
        {
            entity.HasKey(e => e.MoodTrackerid).HasName("PRIMARY");

            entity.ToTable("mood_tracker");

            entity.Property(e => e.MoodTrackerid)
                .HasColumnType("int(11)")
                .HasColumnName("mood_trackerid");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Mood)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("mood");
            entity.Property(e => e.MoodDate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("mood_date");
            entity.Property(e => e.Status)
                .HasMaxLength(25)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<NewPunchtime>(entity =>
        {
            entity.HasKey(e => e.Punchtimeid).HasName("PRIMARY");

            entity.ToTable("new_punchtime");

            entity.Property(e => e.Punchtimeid)
                .HasColumnType("int(11)")
                .HasColumnName("punchtimeid");
            entity.Property(e => e.Approveby)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("approveby");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Employeeid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("employeeid");
            entity.Property(e => e.Leavetype)
                .HasColumnType("int(11)")
                .HasColumnName("leavetype");
            entity.Property(e => e.Overtime)
                .HasColumnType("int(11)")
                .HasColumnName("overtime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.TimeIn)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("time_in");
            entity.Property(e => e.TimeOut)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("time_out");
            entity.Property(e => e.Totalactualtime)
                .HasPrecision(10)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("totalactualtime");
            entity.Property(e => e.Totaltime)
                .HasPrecision(10)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("totaltime");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<PasswordManage>(entity =>
        {
            entity.HasKey(e => e.PasswordManageId).HasName("PRIMARY");

            entity.ToTable("password_manage");

            entity.Property(e => e.PasswordManageId)
                .HasColumnType("int(11)")
                .HasColumnName("password_manage_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.Header)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("header");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("password");
            entity.Property(e => e.ProjectId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("project_id");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.Upload)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("upload");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("url");
            entity.Property(e => e.User)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("user");
        });

        modelBuilder.Entity<PasswordReset>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("password_resets");

            entity.HasIndex(e => e.Email, "password_resets_email_index");

            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(191)
                .HasColumnName("email");
            entity.Property(e => e.Token)
                .HasMaxLength(191)
                .HasColumnName("token");
        });

        modelBuilder.Entity<Payrolldepartment>(entity =>
        {
            entity.HasKey(e => e.Payrolldepartmentid).HasName("PRIMARY");

            entity.ToTable("payrolldepartment");

            entity.Property(e => e.Payrolldepartmentid)
                .HasColumnType("int(11)")
                .HasColumnName("payrolldepartmentid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("deleted");
            entity.Property(e => e.Departmentname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("departmentname");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("description");
            entity.Property(e => e.Parentdepartment)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("parentdepartment");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.Subdepartmentaction)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("subdepartmentaction");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Payrun>(entity =>
        {
            entity.HasKey(e => e.Payrunid).HasName("PRIMARY");

            entity.ToTable("payrun");

            entity.Property(e => e.Payrunid)
                .HasColumnType("int(11)")
                .HasColumnName("payrunid");
            entity.Property(e => e.Actionbonus)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Pending'''")
                .HasColumnName("actionbonus");
            entity.Property(e => e.Actiondeduction)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Pending'''")
                .HasColumnName("actiondeduction");
            entity.Property(e => e.Actionleaves)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Pending'''")
                .HasColumnName("actionleaves");
            entity.Property(e => e.Actionloan)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Pending'''")
                .HasColumnName("actionloan");
            entity.Property(e => e.Actionloss)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Pending'''")
                .HasColumnName("actionloss");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Employeesnetpay)
                .HasPrecision(22)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("employeesnetpay");
            entity.Property(e => e.Payrunmonth)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("payrunmonth");
            entity.Property(e => e.Payrunstatus)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Pending'''")
                .HasColumnName("payrunstatus");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.Totalcontribution)
                .HasPrecision(22)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("totalcontribution");
            entity.Property(e => e.Totaldeduction)
                .HasPrecision(22)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("totaldeduction");
            entity.Property(e => e.Totalemployee)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("totalemployee");
            entity.Property(e => e.Totalpayrollcost)
                .HasPrecision(22)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("totalpayrollcost");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Workingdays)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("workingdays");
        });

        modelBuilder.Entity<Payrundeduction>(entity =>
        {
            entity.HasKey(e => e.Payrundeductionid).HasName("PRIMARY");

            entity.ToTable("payrundeduction");

            entity.Property(e => e.Payrundeductionid)
                .HasColumnType("int(11)")
                .HasColumnName("payrundeductionid");
            entity.Property(e => e.Absent)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("absent");
            entity.Property(e => e.Bonuscalculation)
                .HasMaxLength(10)
                .HasDefaultValueSql("'''off'''")
                .HasColumnName("bonuscalculation");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Deductionamt)
                .HasPrecision(23)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("deductionamt");
            entity.Property(e => e.Earning)
                .HasPrecision(23)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("earning");
            entity.Property(e => e.Emiamt)
                .HasPrecision(23)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("emiamt");
            entity.Property(e => e.Empesi)
                .HasPrecision(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("empesi");
            entity.Property(e => e.Employeeid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("employeeid");
            entity.Property(e => e.Emppf)
                .HasPrecision(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("emppf");
            entity.Property(e => e.Empproftax)
                .HasPrecision(23)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("empproftax");
            entity.Property(e => e.Empresi)
                .HasPrecision(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("empresi");
            entity.Property(e => e.Emprpf)
                .HasPrecision(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("emprpf");
            entity.Property(e => e.Grosspay)
                .HasPrecision(23)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("grosspay");
            entity.Property(e => e.Netpay)
                .HasPrecision(23)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("netpay");
            entity.Property(e => e.Ottime)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("ottime");
            entity.Property(e => e.Payrunid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("payrunid");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Payrunleaf>(entity =>
        {
            entity.HasKey(e => e.Payrunleaveid).HasName("PRIMARY");

            entity.ToTable("payrunleaves");

            entity.Property(e => e.Payrunleaveid)
                .HasColumnType("bigint(20)")
                .HasColumnName("payrunleaveid");
            entity.Property(e => e.Absent)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("absent");
            entity.Property(e => e.Calanderdays)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(10)")
                .HasColumnName("calanderdays");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Employeeid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("employeeid");
            entity.Property(e => e.Holidays)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("holidays");
            entity.Property(e => e.Overtime)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("overtime");
            entity.Property(e => e.Overtimeadjustment)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("overtimeadjustment");
            entity.Property(e => e.Payabledays)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("payabledays");
            entity.Property(e => e.Payrunid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("payrunid");
            entity.Property(e => e.Punchstatus)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("punchstatus");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Workingdays)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("workingdays");
        });

        modelBuilder.Entity<Payrunloan>(entity =>
        {
            entity.HasKey(e => e.Payrunloanid).HasName("PRIMARY");

            entity.ToTable("payrunloan");

            entity.Property(e => e.Payrunloanid)
                .HasColumnType("bigint(20)")
                .HasColumnName("payrunloanid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Emideductamt)
                .HasPrecision(23)
                .HasColumnName("emideductamt");
            entity.Property(e => e.Employeeid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("employeeid");
            entity.Property(e => e.Loanid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("loanid");
            entity.Property(e => e.Payrunid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("payrunid");
            entity.Property(e => e.Remaingamount)
                .HasPrecision(23)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("remaingamount");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Payrunlosscollection>(entity =>
        {
            entity.HasKey(e => e.Payrunlosscollectionid).HasName("PRIMARY");

            entity.ToTable("payrunlosscollection");

            entity.Property(e => e.Payrunlosscollectionid)
                .HasColumnType("bigint(20)")
                .HasColumnName("payrunlosscollectionid");
            entity.Property(e => e.Associatedemployeeid)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("associatedemployeeid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Departmentid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("departmentid");
            entity.Property(e => e.Loss)
                .HasPrecision(23, 3)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("loss");
            entity.Property(e => e.Payrunid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("payrunid");
            entity.Property(e => e.Scrapjama)
                .HasPrecision(23, 3)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("scrapjama");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Ytdlosspending)
                .HasPrecision(23, 3)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("ytdlosspending");
            entity.Property(e => e.Ytdscrapjama)
                .HasPrecision(23, 3)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("ytdscrapjama");
        });

        modelBuilder.Entity<Payrunpayment>(entity =>
        {
            entity.HasKey(e => e.Parunpaymentid).HasName("PRIMARY");

            entity.ToTable("payrunpayment");

            entity.Property(e => e.Parunpaymentid)
                .HasColumnType("int(11)")
                .HasColumnName("parunpaymentid");
            entity.Property(e => e.Absent)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("absent");
            entity.Property(e => e.Amount)
                .HasPrecision(23)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("amount");
            entity.Property(e => e.Bankname)
                .HasMaxLength(100)
                .HasColumnName("bankname");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Employeeid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("employeeid");
            entity.Property(e => e.Grosspay)
                .HasPrecision(23)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("grosspay");
            entity.Property(e => e.Mode)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("mode");
            entity.Property(e => e.Netpay)
                .HasPrecision(23)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("netpay");
            entity.Property(e => e.Ottime)
                .HasPrecision(23)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("ottime");
            entity.Property(e => e.Payrunid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("payrunid");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<PersonalAccessToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("personal_access_tokens");

            entity.HasIndex(e => e.Token, "personal_access_tokens_token_unique").IsUnique();

            entity.HasIndex(e => new { e.TokenableType, e.TokenableId }, "personal_access_tokens_tokenable_type_tokenable_id_index");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Abilities)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("abilities");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.LastUsedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("last_used_at");
            entity.Property(e => e.Name)
                .HasMaxLength(191)
                .HasColumnName("name");
            entity.Property(e => e.Token)
                .HasMaxLength(64)
                .HasColumnName("token");
            entity.Property(e => e.TokenableId)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("tokenable_id");
            entity.Property(e => e.TokenableType)
                .HasMaxLength(191)
                .HasColumnName("tokenable_type");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Professionaltaxslab>(entity =>
        {
            entity.HasKey(e => e.Professionaltaxslabsid).HasName("PRIMARY");

            entity.ToTable("professionaltaxslabs");

            entity.Property(e => e.Professionaltaxslabsid)
                .HasColumnType("int(11)")
                .HasColumnName("professionaltaxslabsid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Endrange)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("endrange");
            entity.Property(e => e.Monthlytaxamount)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("monthlytaxamount");
            entity.Property(e => e.Startrange)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("startrange");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Worklocationid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("worklocationid");
        });

        modelBuilder.Entity<ProjectMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("project_master");

            entity.Property(e => e.Id)
                .HasColumnType("int(255)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("deleted_at");
            entity.Property(e => e.EndDate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(255)
                .HasColumnName("project_name");
            entity.Property(e => e.ProjectStatus)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''In-Progress'''")
                .HasColumnName("project_status");
            entity.Property(e => e.StartDate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Pterm>(entity =>
        {
            entity.HasKey(e => e.Ptermsid).HasName("PRIMARY");

            entity.ToTable("pterms");

            entity.Property(e => e.Ptermsid)
                .HasColumnType("int(11)")
                .HasColumnName("ptermsid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Isdefault)
                .HasMaxLength(25)
                .HasDefaultValueSql("'''no'''")
                .HasColumnName("isdefault");
            entity.Property(e => e.Ptermsname)
                .HasMaxLength(25)
                .HasColumnName("ptermsname");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Punchtime>(entity =>
        {
            entity.HasKey(e => e.Punchtimeid).HasName("PRIMARY");

            entity.ToTable("punchtime");

            entity.Property(e => e.Punchtimeid)
                .HasColumnType("int(11)")
                .HasColumnName("punchtimeid");
            entity.Property(e => e.ActualtimeIn)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("time")
                .HasColumnName("actualtime_in");
            entity.Property(e => e.ActualtimeOut)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("time")
                .HasColumnName("actualtime_out");
            entity.Property(e => e.Approveby)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("approveby");
            entity.Property(e => e.BreakIn)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("time")
                .HasColumnName("break_in");
            entity.Property(e => e.BreakOut)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("time")
                .HasColumnName("break_out");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Earlypunchtime)
                .HasPrecision(10)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("earlypunchtime");
            entity.Property(e => e.Editedby)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("editedby");
            entity.Property(e => e.Employeeid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("employeeid");
            entity.Property(e => e.Latepunchtime)
                .HasPrecision(10)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("latepunchtime");
            entity.Property(e => e.Leavetype)
                .HasComment("1-weekend,2-leave")
                .HasColumnType("int(11)")
                .HasColumnName("leavetype");
            entity.Property(e => e.Overtime)
                .HasPrecision(10)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("overtime");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.TimeIn)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("time")
                .HasColumnName("time_in");
            entity.Property(e => e.TimeOut)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("time")
                .HasColumnName("time_out");
            entity.Property(e => e.Totalactualtime)
                .HasPrecision(10)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("totalactualtime");
            entity.Property(e => e.Totalbreak)
                .HasPrecision(10)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("totalbreak");
            entity.Property(e => e.Totaltime)
                .HasPrecision(10)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("totaltime");
            entity.Property(e => e.Totalworkingtime)
                .HasPrecision(10)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("totalworkingtime");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Reimbursementmaster>(entity =>
        {
            entity.HasKey(e => e.Reimbursementmasterid).HasName("PRIMARY");

            entity.ToTable("reimbursementmaster");

            entity.Property(e => e.Reimbursementmasterid)
                .HasColumnType("int(11)")
                .HasColumnName("reimbursementmasterid");
            entity.Property(e => e.Amount)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("amount");
            entity.Property(e => e.Balancecarrayforward)
                .HasMaxLength(10)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("balancecarrayforward");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("name");
            entity.Property(e => e.Payslipname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("payslipname");
            entity.Property(e => e.Paytype)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("paytype");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("requests");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("categoryId");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasColumnType("int(11)")
                .HasColumnName("created_by");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Description)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.EmployeeId)
                .HasColumnType("int(11)")
                .HasColumnName("employeeId");
            entity.Property(e => e.Status)
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<RequestCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("request_categories");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ReviewParamMaster>(entity =>
        {
            entity.HasKey(e => e.ReviewParamMasterId).HasName("PRIMARY");

            entity.ToTable("review_param_master");

            entity.Property(e => e.ReviewParamMasterId)
                .HasColumnType("int(11)")
                .HasColumnName("review_param_master_id");
            entity.Property(e => e.Comment)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Persantage)
                .HasPrecision(5)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("persantage");
            entity.Property(e => e.ReviewParamName)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("review_param_name");
            entity.Property(e => e.Status)
                .HasMaxLength(25)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Roledetail>(entity =>
        {
            entity.HasKey(e => e.Roledetailid).HasName("PRIMARY");

            entity.ToTable("roledetail");

            entity.Property(e => e.Roledetailid)
                .HasColumnType("int(11)")
                .HasColumnName("roledetailid");
            entity.Property(e => e.Approve)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("approve");
            entity.Property(e => e.Assigncrm)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("assigncrm");
            entity.Property(e => e.CreatePermission)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("create_permission");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletePermission)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("delete_permission");
            entity.Property(e => e.EditPermission)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("edit_permission");
            entity.Property(e => e.Fullaccess)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("fullaccess");
            entity.Property(e => e.Pay)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("pay");
            entity.Property(e => e.Permissionname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("permissionname");
            entity.Property(e => e.Rolemasterid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("rolemasterid");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.View)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("view");
        });

        modelBuilder.Entity<Rolemaster>(entity =>
        {
            entity.HasKey(e => e.Rolemasterid).HasName("PRIMARY");

            entity.ToTable("rolemaster");

            entity.Property(e => e.Rolemasterid)
                .HasColumnType("int(11)")
                .HasColumnName("rolemasterid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Discription)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("discription");
            entity.Property(e => e.Rolename)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("rolename");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Salaryrivision>(entity =>
        {
            entity.HasKey(e => e.Salaryrivisionid).HasName("PRIMARY");

            entity.ToTable("salaryrivision");

            entity.Property(e => e.Salaryrivisionid)
                .HasColumnType("int(11)")
                .HasColumnName("salaryrivisionid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Effectfromdate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("effectfromdate");
            entity.Property(e => e.Employeeid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("employeeid");
            entity.Property(e => e.Newamount)
                .HasPrecision(23)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("newamount");
            entity.Property(e => e.Oldamount)
                .HasPrecision(23, 3)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("oldamount");
            entity.Property(e => e.Payoutmonth)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("payoutmonth");
            entity.Property(e => e.Percentage)
                .HasPrecision(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("percentage");
            entity.Property(e => e.Salaryrevisiontype)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("salaryrevisiontype");
            entity.Property(e => e.Salaryrivisionstatus)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Pending'''")
                .HasColumnName("salaryrivisionstatus");
            entity.Property(e => e.Salarytemplateid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("salarytemplateid");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.Totalctcannually)
                .HasPrecision(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("totalctcannually");
            entity.Property(e => e.Totalctcmonthly)
                .HasPrecision(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("totalctcmonthly");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Salaryrivisiontemplate>(entity =>
        {
            entity.HasKey(e => e.Salaryrivisiontemplateid).HasName("PRIMARY");

            entity.ToTable("salaryrivisiontemplate");

            entity.Property(e => e.Salaryrivisiontemplateid)
                .HasColumnType("int(11)")
                .HasColumnName("salaryrivisiontemplateid");
            entity.Property(e => e.Amtannually)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("amtannually");
            entity.Property(e => e.Amtmonthly)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("amtmonthly");
            entity.Property(e => e.Calculationtype)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("calculationtype");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Salarycomponent)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("salarycomponent");
            entity.Property(e => e.Salaryrivisionid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("salaryrivisionid");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Salarytemplate>(entity =>
        {
            entity.HasKey(e => e.Salarytemplateid).HasName("PRIMARY");

            entity.ToTable("salarytemplate");

            entity.Property(e => e.Salarytemplateid)
                .HasColumnType("int(11)")
                .HasColumnName("salarytemplateid");
            entity.Property(e => e.Amtannually)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("amtannually");
            entity.Property(e => e.Amtmonthly)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("amtmonthly");
            entity.Property(e => e.Calculationtype)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("calculationtype");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Salarycomponent)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("salarycomponent");
            entity.Property(e => e.Salarytemplatesummaryid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20)")
                .HasColumnName("salarytemplatesummaryid");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Salarytemplatesummary>(entity =>
        {
            entity.HasKey(e => e.Salarytemplatesummaryid).HasName("PRIMARY");

            entity.ToTable("salarytemplatesummary");

            entity.Property(e => e.Salarytemplatesummaryid)
                .HasColumnType("bigint(20)")
                .HasColumnName("salarytemplatesummaryid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("deleted");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("description");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.Templatename)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("templatename");
            entity.Property(e => e.Totalctcannually)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20)")
                .HasColumnName("totalctcannually");
            entity.Property(e => e.Totalctcmonthly)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20)")
                .HasColumnName("totalctcmonthly");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<SendToClientLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("send_to_client_log");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Clientid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("clientid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Leaveid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("leaveid");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("sessions");

            entity.HasIndex(e => e.LastActivity, "sessions_last_activity_index");

            entity.HasIndex(e => e.UserId, "sessions_user_id_index");

            entity.Property(e => e.Id)
                .HasMaxLength(191)
                .HasColumnName("id");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(45)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("ip_address");
            entity.Property(e => e.LastActivity)
                .HasColumnType("int(11)")
                .HasColumnName("last_activity");
            entity.Property(e => e.Payload)
                .HasColumnType("text")
                .HasColumnName("payload");
            entity.Property(e => e.UserAgent)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("user_agent");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.Stateid).HasName("PRIMARY");

            entity.ToTable("states");

            entity.Property(e => e.Stateid)
                .HasColumnType("int(11)")
                .HasColumnName("stateid");
            entity.Property(e => e.CountryId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("country_id");
            entity.Property(e => e.Gstcode)
                .HasMaxLength(20)
                .HasColumnName("gstcode");
            entity.Property(e => e.Statename)
                .HasMaxLength(30)
                .HasColumnName("statename");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.StoreId).HasName("PRIMARY");

            entity.ToTable("store");

            entity.Property(e => e.StoreId)
                .HasColumnType("int(11)")
                .HasColumnName("store_id");
            entity.Property(e => e.AssignEmployee)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("assign_employee");
            entity.Property(e => e.AssignOther)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("assign_other");
            entity.Property(e => e.Assignto)
                .HasMaxLength(25)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("assignto");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Price)
                .HasPrecision(10)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("price");
            entity.Property(e => e.PurchaseDate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("purchase_date");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.StoreCategoryId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("store_category_id");
            entity.Property(e => e.StoreItemId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("store_item_id");
            entity.Property(e => e.StoreStatus)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("store_status");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("supplier_name");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("type");
            entity.Property(e => e.Uniqueno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("uniqueno");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.Warranty)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("warranty");
        });

        modelBuilder.Entity<StoreCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("store_category");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Status)
                .HasMaxLength(25)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.StoreCategoryName)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("store_category_name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<StoreItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("store_item");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Status)
                .HasMaxLength(25)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.StoreCategoryId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("store_category_id");
            entity.Property(e => e.StoreItemName)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("store_item_name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<StoreStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("store_status");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Status)
                .HasMaxLength(25)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.StoreStatusName)
                .HasMaxLength(255)
                .HasColumnName("store_status_name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TagMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tag_master");

            entity.Property(e => e.Id)
                .HasColumnType("int(255)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("status");
            entity.Property(e => e.TagName)
                .HasMaxLength(255)
                .HasColumnName("tag_name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TaskEmployeeMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("task_employee_mapping");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.TaskId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("task_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<TaskMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("task_master");

            entity.Property(e => e.Id)
                .HasColumnType("int(255)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.DueDate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("due_date");
            entity.Property(e => e.Priority)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Normal'''")
                .HasColumnName("priority");
            entity.Property(e => e.ProjectId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("project_id");
            entity.Property(e => e.StartDate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.TagId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("tag_id");
            entity.Property(e => e.TaskName)
                .HasMaxLength(255)
                .HasColumnName("task_name");
            entity.Property(e => e.TaskStatus)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Pending'''")
                .HasColumnName("task_status");
            entity.Property(e => e.Ticketid)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("ticketid");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TaskTrackingApiLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("task_tracking_api_log");

            entity.HasIndex(e => e.Channel, "seller_log_channel_index");

            entity.HasIndex(e => e.Level, "seller_log_level_index");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Channel)
                .HasMaxLength(191)
                .HasColumnName("channel");
            entity.Property(e => e.Context).HasColumnName("context");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Extra).HasColumnName("extra");
            entity.Property(e => e.Formatted).HasColumnName("formatted");
            entity.Property(e => e.Level)
                .HasMaxLength(191)
                .HasColumnName("level");
            entity.Property(e => e.LevelName)
                .HasMaxLength(191)
                .HasColumnName("level_name");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.RecordDatetime)
                .HasMaxLength(191)
                .HasColumnName("record_datetime");
            entity.Property(e => e.RemoteAddr)
                .HasMaxLength(191)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("remote_addr");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserAgent)
                .HasMaxLength(191)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("user_agent");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("bigint(20)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Taxis>(entity =>
        {
            entity.HasKey(e => e.Taxesid).HasName("PRIMARY");

            entity.ToTable("taxes");

            entity.Property(e => e.Taxesid)
                .HasColumnType("int(11)")
                .HasColumnName("taxesid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Panno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("panno");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.Tanno)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("tanno");
            entity.Property(e => e.Taxdeductorfathername)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("taxdeductorfathername");
            entity.Property(e => e.Taxdeductorname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("taxdeductorname");
            entity.Property(e => e.Taxpaymentmode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("taxpaymentmode");
            entity.Property(e => e.TdsAoCode)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("tds_ao_code");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TempPunch>(entity =>
        {
            entity.HasKey(e => e.TempPunchid).HasName("PRIMARY");

            entity.ToTable("temp_punch");

            entity.Property(e => e.TempPunchid)
                .HasColumnType("int(11)")
                .HasColumnName("temp_punchid");
            entity.Property(e => e.Approveby)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("approveby");
            entity.Property(e => e.BreakIn)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("time")
                .HasColumnName("break_in");
            entity.Property(e => e.BreakOut)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("time")
                .HasColumnName("break_out");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Emplyeeid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("emplyeeid");
            entity.Property(e => e.Punchtimeid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("punchtimeid");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Pending'''")
                .HasColumnName("status");
            entity.Property(e => e.TimeIn)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("time_in");
            entity.Property(e => e.TimeOut)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("time_out");
            entity.Property(e => e.Totalworkingtime)
                .HasPrecision(10)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("totalworkingtime");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TemplateMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("template_master");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("id");
            entity.Property(e => e.CompletedBadge)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("completed_badge");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("created_by");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.OptedBadge)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("opted_badge");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnType("enum('Active','InActive')")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TemplateSkill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("template_skills");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("description");
            entity.Property(e => e.SkillName)
                .HasMaxLength(1000)
                .HasColumnName("skill_name");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnType("enum('Active','InActive')")
                .HasColumnName("status");
            entity.Property(e => e.TemplateId)
                .HasColumnType("bigint(20)")
                .HasColumnName("template_id");
            entity.Property(e => e.TopicId)
                .HasColumnType("bigint(20)")
                .HasColumnName("topic_id");
            entity.Property(e => e.TotalHours)
                .HasMaxLength(1000)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("total_hours");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TemplateTopic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("template_topics");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnType("enum('Active','InActive')")
                .HasColumnName("status");
            entity.Property(e => e.TemplateId)
                .HasColumnType("bigint(20)")
                .HasColumnName("template_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TimeTracking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("time_tracking");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(21)")
                .HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.EditedBy)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("edited_by");
            entity.Property(e => e.ProjectId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("project_id");
            entity.Property(e => e.StartTime)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("start_time");
            entity.Property(e => e.Status)
                .HasMaxLength(25)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.StopTime)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("stop_time");
            entity.Property(e => e.TaskId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("task_id");
            entity.Property(e => e.TotalTime)
                .HasPrecision(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("total_time");
            entity.Property(e => e.TrackingStatus)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Start'''")
                .HasColumnName("tracking_status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Timerule>(entity =>
        {
            entity.HasKey(e => e.Timeruleid).HasName("PRIMARY");

            entity.ToTable("timerules");

            entity.Property(e => e.Timeruleid)
                .HasColumnType("int(11)")
                .HasColumnName("timeruleid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.Timerule1)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("timerule");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Withvalue)
                .HasMaxLength(12)
                .HasDefaultValueSql("'''yes'''")
                .HasColumnName("withvalue");
        });

        modelBuilder.Entity<TimesheetLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("timesheet_log");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(21)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("action");
            entity.Property(e => e.AfterAction)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("after_action");
            entity.Property(e => e.BeforeAction)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("before_action");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Delivered)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("delivered");
            entity.Property(e => e.Module)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("module");
            entity.Property(e => e.ModuleId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("module_id");
            entity.Property(e => e.Other)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("other");
            entity.Property(e => e.Readed)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("readed");
            entity.Property(e => e.Sented)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("sented");
            entity.Property(e => e.TrackingId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("tracking_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(20) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(191)
                .HasColumnName("email");
            entity.Property(e => e.EmailVerifiedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("email_verified_at");
            entity.Property(e => e.Name)
                .HasMaxLength(191)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(191)
                .HasColumnName("password");
            entity.Property(e => e.RememberToken)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("remember_token");
            entity.Property(e => e.Roleid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("roleid");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.TnC)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Worklocation>(entity =>
        {
            entity.HasKey(e => e.Worklocationsid).HasName("PRIMARY");

            entity.ToTable("worklocations");

            entity.Property(e => e.Worklocationsid)
                .HasColumnType("int(11)")
                .HasColumnName("worklocationsid");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("address");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("city");
            entity.Property(e => e.Contactperson)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("contactperson");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Deductioncycle)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("deductioncycle");
            entity.Property(e => e.Landlinenumber)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("landlinenumber");
            entity.Property(e => e.Landlinenumbercode)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("landlinenumbercode");
            entity.Property(e => e.Locationname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("locationname");
            entity.Property(e => e.Mobileno)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("mobileno");
            entity.Property(e => e.Pincode)
                .HasMaxLength(11)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("pincode");
            entity.Property(e => e.Ptnumber)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("ptnumber");
            entity.Property(e => e.State)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("state");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Workshift>(entity =>
        {
            entity.HasKey(e => e.Workshiftid).HasName("PRIMARY");

            entity.ToTable("workshift");

            entity.Property(e => e.Workshiftid)
                .HasColumnType("int(11)")
                .HasColumnName("workshiftid");
            entity.Property(e => e.Applicabledate)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("datetime")
                .HasColumnName("applicabledate");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.InTime)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("time")
                .HasColumnName("in_time");
            entity.Property(e => e.OtType)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("ot_type");
            entity.Property(e => e.OutTime)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("time")
                .HasColumnName("out_time");
            entity.Property(e => e.Remarks)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("remarks");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Weeklyoff)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("weeklyoff");
            entity.Property(e => e.Workshiftname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("workshiftname");
        });

        modelBuilder.Entity<Workshiftrule>(entity =>
        {
            entity.HasKey(e => e.Workshiftruleid).HasName("PRIMARY");

            entity.ToTable("workshiftrules");

            entity.Property(e => e.Workshiftruleid)
                .HasColumnType("int(11)")
                .HasColumnName("workshiftruleid");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Ruleid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("ruleid");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasDefaultValueSql("'''Active'''")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'current_timestamp()'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("value");
            entity.Property(e => e.Workshiftid)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("workshiftid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
