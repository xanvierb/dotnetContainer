using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using StartProject.Contexts;

namespace StartProject.Migrations
{
    [DbContext(typeof(ContactsContext))]
    [Migration("20161201133436_testMySql")]
    partial class testMySql
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("StartProject.Models.Contacts", b =>
                {
                    b.Property<string>("MobilePhone");

                    b.Property<string>("AnniversaryDate");

                    b.Property<string>("Company");

                    b.Property<string>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("IsFamilyMember");

                    b.Property<string>("JobTitle");

                    b.Property<string>("LastName");

                    b.HasKey("MobilePhone");

                    b.ToTable("Contacts");
                });
        }
    }
}
