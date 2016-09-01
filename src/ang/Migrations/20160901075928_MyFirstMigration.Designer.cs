using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ang.Models;

namespace ang.Migrations
{
    [DbContext(typeof(GroupContext))]
    [Migration("20160901075928_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ang.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("ang.Models.Participant", b =>
                {
                    b.Property<int>("ParticipantId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<int>("GroupId");

                    b.Property<string>("LastName");

                    b.HasKey("ParticipantId");

                    b.HasIndex("GroupId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("ang.Models.Participant", b =>
                {
                    b.HasOne("ang.Models.Group", "Group")
                        .WithMany("Participants")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
