using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using wings_api.Data;

namespace wings_api.Migrations
{
    [DbContext(typeof(WingsContext))]
    partial class WingsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("wings_api.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("AgeInterestedMax");

                    b.Property<int>("AgeInterestedMin");

                    b.Property<string>("Bio");

                    b.Property<string>("City");

                    b.Property<string>("DOB");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("GenderInterested");

                    b.Property<string>("Job");

                    b.Property<string>("LastName");

                    b.Property<string>("Latitude");

                    b.Property<string>("Longitude");

                    b.Property<bool>("Onboarded");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("School");

                    b.Property<string>("State");

                    b.Property<string>("Zip");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("wings_api.Models.UserBacklog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<int?>("UserFriendID");

                    b.Property<int>("UserID");

                    b.Property<int?>("UserPotentialMatchID");

                    b.HasKey("Id");

                    b.HasIndex("UserFriendID");

                    b.HasIndex("UserID");

                    b.HasIndex("UserPotentialMatchID");

                    b.ToTable("UserBacklogs");
                });

            modelBuilder.Entity("wings_api.Models.UserChatlog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.HasKey("Id");

                    b.ToTable("UserChatlogs");
                });

            modelBuilder.Entity("wings_api.Models.UserFriend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<int?>("UserFriendID");

                    b.Property<int>("UserID");

                    b.HasKey("Id");

                    b.HasIndex("UserFriendID");

                    b.HasIndex("UserID");

                    b.ToTable("UserFriends");
                });

            modelBuilder.Entity("wings_api.Models.UserInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Interest");

                    b.Property<int>("UserID");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("UserInterests");
                });

            modelBuilder.Entity("wings_api.Models.UserMatch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<int?>("UserFriendID");

                    b.Property<int>("UserID");

                    b.Property<int?>("UserMatchID");

                    b.HasKey("Id");

                    b.HasIndex("UserFriendID");

                    b.HasIndex("UserID");

                    b.HasIndex("UserMatchID");

                    b.ToTable("UserMatches");
                });

            modelBuilder.Entity("wings_api.Models.UserPicture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Url");

                    b.Property<int>("UserID");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("UserPictures");
                });

            modelBuilder.Entity("wings_api.Models.UserBacklog", b =>
                {
                    b.HasOne("wings_api.Models.User", "Friend")
                        .WithMany()
                        .HasForeignKey("UserFriendID");

                    b.HasOne("wings_api.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("wings_api.Models.User", "PotentialMatch")
                        .WithMany("UserBacklogs")
                        .HasForeignKey("UserPotentialMatchID");
                });

            modelBuilder.Entity("wings_api.Models.UserFriend", b =>
                {
                    b.HasOne("wings_api.Models.User", "Friend")
                        .WithMany("UserFriends")
                        .HasForeignKey("UserFriendID");

                    b.HasOne("wings_api.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("wings_api.Models.UserInterest", b =>
                {
                    b.HasOne("wings_api.Models.User")
                        .WithMany("UserInterests")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("wings_api.Models.UserMatch", b =>
                {
                    b.HasOne("wings_api.Models.User", "Friend")
                        .WithMany()
                        .HasForeignKey("UserFriendID");

                    b.HasOne("wings_api.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("wings_api.Models.User", "Match")
                        .WithMany("UserMatches")
                        .HasForeignKey("UserMatchID");
                });

            modelBuilder.Entity("wings_api.Models.UserPicture", b =>
                {
                    b.HasOne("wings_api.Models.User")
                        .WithMany("UserPictures")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
