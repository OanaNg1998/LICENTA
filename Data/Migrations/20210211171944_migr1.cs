using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JUSTMOVE.Data.Migrations
{
    public partial class migr1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymInstructors_Instructor_InstructorId",
                table: "GymInstructors");

            migrationBuilder.DropForeignKey(
                name: "FK_GymTrainings_Training_TrainingId",
                table: "GymTrainings");

            migrationBuilder.DropForeignKey(
                name: "FK_InstructorTrainings_Instructor_InstructorId",
                table: "InstructorTrainings");

            migrationBuilder.DropForeignKey(
                name: "FK_InstructorTrainings_Training_TrainingId",
                table: "InstructorTrainings");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscription_Gym_GymId",
                table: "Subscription");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubscription_Gym_GymId",
                table: "UserSubscription");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubscription_Subscription_SubscriptionId",
                table: "UserSubscription");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubscription_AspNetUsers_UserId",
                table: "UserSubscription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSubscription",
                table: "UserSubscription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Training",
                table: "Training");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subscription",
                table: "Subscription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.RenameTable(
                name: "UserSubscription",
                newName: "UserSubscriptions");

            migrationBuilder.RenameTable(
                name: "Training",
                newName: "Trainings");

            migrationBuilder.RenameTable(
                name: "Subscription",
                newName: "Subscriptions");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "Instructors");

            migrationBuilder.RenameIndex(
                name: "IX_UserSubscription_UserId",
                table: "UserSubscriptions",
                newName: "IX_UserSubscriptions_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserSubscription_SubscriptionId",
                table: "UserSubscriptions",
                newName: "IX_UserSubscriptions_SubscriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_UserSubscription_GymId",
                table: "UserSubscriptions",
                newName: "IX_UserSubscriptions_GymId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscription_GymId",
                table: "Subscriptions",
                newName: "IX_Subscriptions_GymId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSubscriptions",
                table: "UserSubscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trainings",
                table: "Trainings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subscriptions",
                table: "Subscriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "County", "Street", "StreetNumber" },
                values: new object[,]
                {
                    { "1", "Ploiesti", "Prahova", "Bulevardul Republicii", 17 },
                    { "2", "Ploiesti", "Prahova", "Bulevardul Republicii", 25 },
                    { "3", "Bucuresti", "Bucuresti", "Constantin Aricescu", 12 },
                    { "4", "Bucuresti", "Bucuresti", "Padesu", 2 },
                    { "5", "Cluj-Napoca", "Cluj", "Avram Iancu", 492 },
                    { "6", "Cluj-Napoca", "Cluj", "Alexandru Vaida Voevod", 53 },
                    { "7", "Bucuresti", "Bucuresti", "Tarnave", 10 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Gender", "IntrestDomain", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ad1cac20-b871-4cc6-925c-8b182d061f2c", null, false, "Neagu", "femeie", "Fitness", "Oana", false, null, null, null, null, null, false, "96ff2763-9043-4ded-ad09-9eebe3c90a6a", false, null });

            migrationBuilder.InsertData(
                table: "Gym",
                columns: new[] { "Id", "AddressId", "DailyClosingHour", "DailyOpenHour", "Name", "WeekendClosingHour", "WeekendOpenHour" },
                values: new object[,]
                {
                    { "1", "1", 22, 6, "Titan Academy", 20, 8 },
                    { "2", "2", 23, 7, "MaxGym Club", 21, 7 },
                    { "3", "3", 22, 8, "Movement Studio", 18, 9 },
                    { "4", "4", 22, 7, "LotusClub Padesu", 18, 7 },
                    { "5", "5", 22, 6, "WorldClass Vivo", 21, 8 },
                    { "6", "6", 20, 7, "SerGym", 20, 8 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_GymInstructors_Instructors_InstructorId",
                table: "GymInstructors",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GymTrainings_Trainings_TrainingId",
                table: "GymTrainings",
                column: "TrainingId",
                principalTable: "Trainings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorTrainings_Instructors_InstructorId",
                table: "InstructorTrainings",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorTrainings_Trainings_TrainingId",
                table: "InstructorTrainings",
                column: "TrainingId",
                principalTable: "Trainings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Gym_GymId",
                table: "Subscriptions",
                column: "GymId",
                principalTable: "Gym",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubscriptions_Gym_GymId",
                table: "UserSubscriptions",
                column: "GymId",
                principalTable: "Gym",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubscriptions_Subscriptions_SubscriptionId",
                table: "UserSubscriptions",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubscriptions_AspNetUsers_UserId",
                table: "UserSubscriptions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GymInstructors_Instructors_InstructorId",
                table: "GymInstructors");

            migrationBuilder.DropForeignKey(
                name: "FK_GymTrainings_Trainings_TrainingId",
                table: "GymTrainings");

            migrationBuilder.DropForeignKey(
                name: "FK_InstructorTrainings_Instructors_InstructorId",
                table: "InstructorTrainings");

            migrationBuilder.DropForeignKey(
                name: "FK_InstructorTrainings_Trainings_TrainingId",
                table: "InstructorTrainings");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Gym_GymId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubscriptions_Gym_GymId",
                table: "UserSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubscriptions_Subscriptions_SubscriptionId",
                table: "UserSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSubscriptions_AspNetUsers_UserId",
                table: "UserSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserSubscriptions",
                table: "UserSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trainings",
                table: "Trainings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subscriptions",
                table: "Subscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Gym",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.RenameTable(
                name: "UserSubscriptions",
                newName: "UserSubscription");

            migrationBuilder.RenameTable(
                name: "Trainings",
                newName: "Training");

            migrationBuilder.RenameTable(
                name: "Subscriptions",
                newName: "Subscription");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructor");

            migrationBuilder.RenameIndex(
                name: "IX_UserSubscriptions_UserId",
                table: "UserSubscription",
                newName: "IX_UserSubscription_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserSubscriptions_SubscriptionId",
                table: "UserSubscription",
                newName: "IX_UserSubscription_SubscriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_UserSubscriptions_GymId",
                table: "UserSubscription",
                newName: "IX_UserSubscription_GymId");

            migrationBuilder.RenameIndex(
                name: "IX_Subscriptions_GymId",
                table: "Subscription",
                newName: "IX_Subscription_GymId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserSubscription",
                table: "UserSubscription",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Training",
                table: "Training",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subscription",
                table: "Subscription",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GymInstructors_Instructor_InstructorId",
                table: "GymInstructors",
                column: "InstructorId",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GymTrainings_Training_TrainingId",
                table: "GymTrainings",
                column: "TrainingId",
                principalTable: "Training",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorTrainings_Instructor_InstructorId",
                table: "InstructorTrainings",
                column: "InstructorId",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorTrainings_Training_TrainingId",
                table: "InstructorTrainings",
                column: "TrainingId",
                principalTable: "Training",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subscription_Gym_GymId",
                table: "Subscription",
                column: "GymId",
                principalTable: "Gym",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubscription_Gym_GymId",
                table: "UserSubscription",
                column: "GymId",
                principalTable: "Gym",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubscription_Subscription_SubscriptionId",
                table: "UserSubscription",
                column: "SubscriptionId",
                principalTable: "Subscription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSubscription_AspNetUsers_UserId",
                table: "UserSubscription",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
