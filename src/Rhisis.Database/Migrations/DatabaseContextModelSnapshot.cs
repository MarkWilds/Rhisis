﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rhisis.Database.Context;

namespace Rhisis.Database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Rhisis.Database.Entities.DbCharacter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Angle")
                        .HasColumnType("float");

                    b.Property<int>("BankCode")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("Dexterity")
                        .HasColumnType("int");

                    b.Property<long>("Experience")
                        .HasColumnType("bigint");

                    b.Property<int>("FaceId")
                        .HasColumnType("int");

                    b.Property<int>("Fp")
                        .HasColumnType("int");

                    b.Property<byte>("Gender")
                        .HasColumnType("tinyint unsigned");

                    b.Property<int>("Gold")
                        .HasColumnType("int");

                    b.Property<int>("HairColor")
                        .HasColumnType("int");

                    b.Property<int>("HairId")
                        .HasColumnType("int");

                    b.Property<int>("Hp")
                        .HasColumnType("int");

                    b.Property<int>("Intelligence")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastConnectionTime")
                        .HasColumnType("DATETIME");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("MapId")
                        .HasColumnType("int");

                    b.Property<int>("MapLayerId")
                        .HasColumnType("int");

                    b.Property<int>("Mp")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("PlayTime")
                        .HasColumnType("BIGINT");

                    b.Property<float>("PosX")
                        .HasColumnType("float");

                    b.Property<float>("PosY")
                        .HasColumnType("float");

                    b.Property<float>("PosZ")
                        .HasColumnType("float");

                    b.Property<int>("SkillPoints")
                        .HasColumnType("int");

                    b.Property<int>("SkinSetId")
                        .HasColumnType("int");

                    b.Property<int>("Slot")
                        .HasColumnType("int");

                    b.Property<int>("Stamina")
                        .HasColumnType("int");

                    b.Property<int>("StatPoints")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("characters");
                });

            modelBuilder.Entity("Rhisis.Database.Entities.DbItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("CreatorId")
                        .HasColumnType("int");

                    b.Property<byte>("Element")
                        .HasColumnType("tinyint unsigned");

                    b.Property<byte>("ElementRefine")
                        .HasColumnType("tinyint unsigned");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ItemCount")
                        .HasColumnType("int");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("ItemSlot")
                        .HasColumnType("int");

                    b.Property<byte>("Refine")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("items");
                });

            modelBuilder.Entity("Rhisis.Database.Entities.DbMail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<long>("Gold")
                        .HasColumnType("BIGINT");

                    b.Property<bool>("HasBeenRead")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasReceivedGold")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("HasReceivedItem")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("ItemId")
                        .HasColumnType("int");

                    b.Property<short>("ItemQuantity")
                        .HasColumnType("smallint");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("mails");
                });

            modelBuilder.Entity("Rhisis.Database.Entities.DbQuest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<ulong>("Finished")
                        .HasColumnType("BIT");

                    b.Property<ulong>("IsChecked")
                        .HasColumnType("BIT");

                    b.Property<ulong>("IsDeleted")
                        .HasColumnType("BIT");

                    b.Property<ulong>("IsPatrolDone")
                        .HasColumnType("BIT");

                    b.Property<sbyte>("MonsterKilled1")
                        .HasColumnType("TINYINT");

                    b.Property<sbyte>("MonsterKilled2")
                        .HasColumnType("TINYINT");

                    b.Property<int>("QuestId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("DATETIME");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("QuestId", "CharacterId")
                        .IsUnique();

                    b.ToTable("quests");
                });

            modelBuilder.Entity("Rhisis.Database.Entities.DbShortcut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<uint>("ObjectData")
                        .HasColumnType("int unsigned");

                    b.Property<uint>("ObjectId")
                        .HasColumnType("int unsigned");

                    b.Property<uint>("ObjectIndex")
                        .HasColumnType("int unsigned");

                    b.Property<uint>("ObjectType")
                        .HasColumnType("int unsigned");

                    b.Property<int>("SlotIndex")
                        .HasColumnType("int");

                    b.Property<int?>("SlotLevelIndex")
                        .HasColumnType("int");

                    b.Property<int>("TargetTaskbar")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<uint>("Type")
                        .HasColumnType("int unsigned");

                    b.Property<uint>("UserId")
                        .HasColumnType("int unsigned");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("shortcuts");
                });

            modelBuilder.Entity("Rhisis.Database.Entities.DbSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<byte>("Level")
                        .HasColumnType("tinyint unsigned");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.HasIndex("SkillId", "CharacterId")
                        .IsUnique();

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Rhisis.Database.Entities.DbUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Authority")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastConnectionTime")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("Username", "Email")
                        .IsUnique();

                    b.ToTable("users");
                });

            modelBuilder.Entity("Rhisis.Database.Entities.DbCharacter", b =>
                {
                    b.HasOne("Rhisis.Database.Entities.DbUser", "User")
                        .WithMany("Characters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Rhisis.Database.Entities.DbItem", b =>
                {
                    b.HasOne("Rhisis.Database.Entities.DbCharacter", "Character")
                        .WithMany("Items")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Rhisis.Database.Entities.DbMail", b =>
                {
                    b.HasOne("Rhisis.Database.Entities.DbItem", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.HasOne("Rhisis.Database.Entities.DbCharacter", "Receiver")
                        .WithMany("ReceivedMails")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rhisis.Database.Entities.DbCharacter", "Sender")
                        .WithMany("SentMails")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Rhisis.Database.Entities.DbQuest", b =>
                {
                    b.HasOne("Rhisis.Database.Entities.DbCharacter", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Rhisis.Database.Entities.DbShortcut", b =>
                {
                    b.HasOne("Rhisis.Database.Entities.DbCharacter", "Character")
                        .WithMany("TaskbarShortcuts")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Rhisis.Database.Entities.DbSkill", b =>
                {
                    b.HasOne("Rhisis.Database.Entities.DbCharacter", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
