namespace eMCHDB.Domain.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class eMCHDBModel : DbContext
    {
        public eMCHDBModel()
            : base("name=ModeleMCHDB")
        {
        }

        public virtual DbSet<ANLabTest> ANLabTests { get; set; }
        public virtual DbSet<Child> Children { get; set; }
        public virtual DbSet<ChildMeasure> ChildMeasures { get; set; }
        public virtual DbSet<ChildVisit> ChildVisits { get; set; }
        public virtual DbSet<FamilyPlanning> FamilyPlannings { get; set; }
        public virtual DbSet<Field> Fields { get; set; }
        public virtual DbSet<FPWay> FPWays { get; set; }
        public virtual DbSet<HealthCenter> HealthCenters { get; set; }
        public virtual DbSet<Immunization> Immunizations { get; set; }
        public virtual DbSet<Mother> Mothers { get; set; }
        public virtual DbSet<NewbornAssessment> NewbornAssessments { get; set; }
        public virtual DbSet<OralHealth> OralHealths { get; set; }
        public virtual DbSet<PNVisit> PNVisits { get; set; }
        public virtual DbSet<Pregnancy> Pregnancies { get; set; }
        public virtual DbSet<PregnancyVisit> PregnancyVisits { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ANLabTest>()
                .Property(e => e.MotherID)
                .IsUnicode(false);

            modelBuilder.Entity<Child>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Child>()
                .Property(e => e.MotherId)
                .IsUnicode(false);

            modelBuilder.Entity<Child>()
                .Property(e => e.CHR)
                .IsUnicode(false);

            modelBuilder.Entity<Child>()
                .Property(e => e.GMWeight)
                .IsUnicode(false);

            modelBuilder.Entity<Child>()
                .Property(e => e.Length)
                .IsUnicode(false);

            modelBuilder.Entity<Child>()
                .Property(e => e.HC)
                .IsUnicode(false);

            modelBuilder.Entity<Child>()
                .Property(e => e.Temp)
                .IsUnicode(false);

            modelBuilder.Entity<Child>()
                .Property(e => e.PulseAt0)
                .IsUnicode(false);

            modelBuilder.Entity<Child>()
                .Property(e => e.PulseAt12)
                .IsUnicode(false);

            modelBuilder.Entity<Child>()
                .Property(e => e.PulseAt36)
                .IsUnicode(false);

            modelBuilder.Entity<Child>()
                .Property(e => e.HepatitisB)
                .IsUnicode(false);

            modelBuilder.Entity<ChildMeasure>()
                .Property(e => e.ChildId)
                .IsUnicode(false);

            modelBuilder.Entity<ChildMeasure>()
                .Property(e => e.Age)
                .IsUnicode(false);

            modelBuilder.Entity<ChildMeasure>()
                .Property(e => e.Weight)
                .IsUnicode(false);

            modelBuilder.Entity<ChildMeasure>()
                .Property(e => e.Height)
                .IsUnicode(false);

            modelBuilder.Entity<ChildMeasure>()
                .Property(e => e.HC)
                .IsUnicode(false);

            modelBuilder.Entity<ChildMeasure>()
                .Property(e => e.NurseName)
                .IsUnicode(false);

            modelBuilder.Entity<ChildVisit>()
                .Property(e => e.ChildId)
                .IsUnicode(false);

            modelBuilder.Entity<ChildVisit>()
                .Property(e => e.GeneralAppearance)
                .IsUnicode(false);

            modelBuilder.Entity<ChildVisit>()
                .Property(e => e.Fontanell)
                .IsUnicode(false);

            modelBuilder.Entity<ChildVisit>()
                .Property(e => e.Squint)
                .IsUnicode(false);

            modelBuilder.Entity<ChildVisit>()
                .Property(e => e.MurmersAt0)
                .IsUnicode(false);

            modelBuilder.Entity<ChildVisit>()
                .Property(e => e.MurmersAt12)
                .IsUnicode(false);

            modelBuilder.Entity<ChildVisit>()
                .Property(e => e.MurmersAt36)
                .IsUnicode(false);

            modelBuilder.Entity<ChildVisit>()
                .Property(e => e.Masses)
                .IsUnicode(false);

            modelBuilder.Entity<ChildVisit>()
                .Property(e => e.Hepatosplenomegally)
                .IsUnicode(false);

            modelBuilder.Entity<ChildVisit>()
                .Property(e => e.Hernia)
                .IsUnicode(false);

            modelBuilder.Entity<ChildVisit>()
                .Property(e => e.TesticularExamination)
                .IsUnicode(false);

            modelBuilder.Entity<ChildVisit>()
                .Property(e => e.hypospadias)
                .IsUnicode(false);

            modelBuilder.Entity<ChildVisit>()
                .Property(e => e.Dysplasia)
                .IsUnicode(false);

            modelBuilder.Entity<ChildVisit>()
                .Property(e => e.LimitedAbduction)
                .IsUnicode(false);

            modelBuilder.Entity<ChildVisit>()
                .Property(e => e.AbnormalSpine)
                .IsUnicode(false);

            modelBuilder.Entity<ChildVisit>()
                .Property(e => e.AbnormalExternalgenitalia)
                .IsUnicode(false);

            modelBuilder.Entity<ChildVisit>()
                .Property(e => e.InguinalHernia)
                .IsUnicode(false);

            modelBuilder.Entity<FamilyPlanning>()
                .Property(e => e.MotherID)
                .IsUnicode(false);

            modelBuilder.Entity<FamilyPlanning>()
                .Property(e => e.PregnancyId)
                .IsUnicode(false);

            modelBuilder.Entity<FPWay>()
                .Property(e => e.MotherID)
                .IsUnicode(false);

            modelBuilder.Entity<HealthCenter>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<HealthCenter>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<Immunization>()
                .Property(e => e.ChildId)
                .IsUnicode(false);

            modelBuilder.Entity<Immunization>()
                .Property(e => e.AdverseEvents)
                .IsUnicode(false);

            modelBuilder.Entity<Mother>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Mother>()
                .Property(e => e.RCN)
                .IsUnicode(false);

            modelBuilder.Entity<Mother>()
                .Property(e => e.MotherID)
                .IsUnicode(false);

            modelBuilder.Entity<Mother>()
                .Property(e => e.MotherBloodType)
                .IsUnicode(false);

            modelBuilder.Entity<NewbornAssessment>()
                .Property(e => e.ChildID)
                .IsUnicode(false);

            modelBuilder.Entity<NewbornAssessment>()
                .Property(e => e.Weight)
                .IsUnicode(false);

            modelBuilder.Entity<NewbornAssessment>()
                .Property(e => e.Length)
                .IsUnicode(false);

            modelBuilder.Entity<NewbornAssessment>()
                .Property(e => e.HC)
                .IsUnicode(false);

            modelBuilder.Entity<NewbornAssessment>()
                .Property(e => e.Temp)
                .IsUnicode(false);

            modelBuilder.Entity<NewbornAssessment>()
                .Property(e => e.Pulse)
                .IsUnicode(false);

            modelBuilder.Entity<NewbornAssessment>()
                .Property(e => e.RespiratoryRate)
                .IsUnicode(false);

            modelBuilder.Entity<NewbornAssessment>()
                .Property(e => e.MoroReflex)
                .IsUnicode(false);

            modelBuilder.Entity<NewbornAssessment>()
                .Property(e => e.GraspReflex)
                .IsUnicode(false);

            modelBuilder.Entity<NewbornAssessment>()
                .Property(e => e.SucklingReflex)
                .IsUnicode(false);

            modelBuilder.Entity<NewbornAssessment>()
                .Property(e => e.NeonatalJaundice)
                .IsUnicode(false);

            modelBuilder.Entity<NewbornAssessment>()
                .Property(e => e.NeonatalCyanosis)
                .IsUnicode(false);

            modelBuilder.Entity<NewbornAssessment>()
                .Property(e => e.UnbilicalCord)
                .IsUnicode(false);

            modelBuilder.Entity<NewbornAssessment>()
                .Property(e => e.HepatitisB)
                .IsUnicode(false);

            modelBuilder.Entity<OralHealth>()
                .Property(e => e.ChildId)
                .IsUnicode(false);

            modelBuilder.Entity<OralHealth>()
                .Property(e => e.RiskScoringAssessment)
                .IsUnicode(false);

            modelBuilder.Entity<OralHealth>()
                .Property(e => e.FluorideVarnishApplication)
                .IsUnicode(false);

            modelBuilder.Entity<PNVisit>()
                .Property(e => e.MotherID)
                .IsUnicode(false);

            modelBuilder.Entity<PNVisit>()
                .Property(e => e.PregnancyId)
                .IsUnicode(false);

            modelBuilder.Entity<PNVisit>()
                .Property(e => e.BP)
                .IsUnicode(false);

            modelBuilder.Entity<Pregnancy>()
                .Property(e => e.MotherId)
                .IsUnicode(false);

            modelBuilder.Entity<Pregnancy>()
                .Property(e => e.Temp)
                .IsUnicode(false);

            modelBuilder.Entity<Pregnancy>()
                .Property(e => e.BP)
                .IsUnicode(false);

            modelBuilder.Entity<PregnancyVisit>()
                .Property(e => e.MotherID)
                .IsUnicode(false);

            modelBuilder.Entity<PregnancyVisit>()
                .Property(e => e.PregnancyId)
                .IsUnicode(false);

            modelBuilder.Entity<PregnancyVisit>()
                .Property(e => e.Weight)
                .IsUnicode(false);

            modelBuilder.Entity<PregnancyVisit>()
                .Property(e => e.BP)
                .IsUnicode(false);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.start_ip_address)
                .IsUnicode(false);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.end_ip_address)
                .IsUnicode(false);
        }
    }
}
