﻿// <auto-generated />
using System;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(KLTNContext))]
    partial class KLTNContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Models.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Data.Models.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Data.Models.BaiPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdkenhThaoLuan")
                        .HasColumnName("IDKenhThaoLuan")
                        .HasColumnType("int");

                    b.Property<long>("IdnguoiTao")
                        .HasColumnName("IDNguoiTao")
                        .HasColumnType("bigint");

                    b.Property<int?>("Loai")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayPost")
                        .HasColumnType("datetime");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TieuDe")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("IdkenhThaoLuan");

                    b.ToTable("BaiPost");
                });

            modelBuilder.Entity("Data.Models.BaoCaoTienDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DanhGia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("HanNop")
                        .HasColumnType("date");

                    b.Property<long?>("IddeTai")
                        .HasColumnName("IDDeTai")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("NgayNop")
                        .HasColumnType("date");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TepDinhKem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TienDo")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("IddeTai");

                    b.ToTable("BaoCaoTienDo");
                });

            modelBuilder.Entity("Data.Models.BoNhiem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("IdgiangVien")
                        .HasColumnName("IDGiangVien")
                        .HasColumnType("bigint");

                    b.Property<int?>("IdhoiDong")
                        .HasColumnName("IDHoiDong")
                        .HasColumnType("int");

                    b.Property<long?>("IdquanLy")
                        .HasColumnName("IDQuanLy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("NgayBoNhiem")
                        .HasColumnType("datetime");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("VaiTro")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdgiangVien");

                    b.HasIndex("IdhoiDong");

                    b.HasIndex("IdquanLy");

                    b.ToTable("BoNhiem");
                });

            modelBuilder.Entity("Data.Models.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnhDinhKem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdbaiPost")
                        .HasColumnName("IDBaiPost")
                        .HasColumnType("int");

                    b.Property<int>("IdnguoiTao")
                        .HasColumnName("IDNguoiTao")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayPost")
                        .HasColumnType("datetime");

                    b.Property<string>("NoiDungComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdbaiPost");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Data.Models.CtxetDuyetVaDanhGia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CauHoi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CauTraLoi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Diem")
                        .HasColumnType("float");

                    b.Property<int>("IdnguoiTao")
                        .HasColumnName("IDNguoiTao")
                        .HasColumnType("int");

                    b.Property<int?>("IdxetDuyet")
                        .HasColumnName("IDXetDuyet")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("datetime");

                    b.Property<string>("NhanXet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdxetDuyet");

                    b.ToTable("CTXetDuyetVaDanhGia");
                });

            modelBuilder.Entity("Data.Models.DeTaiNghienCuu", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("IdgiangVien")
                        .HasColumnName("IDGiangVien")
                        .HasColumnType("bigint");

                    b.Property<int?>("Idnhom")
                        .HasColumnName("IDNhom")
                        .HasColumnType("int");

                    b.Property<bool?>("Loai")
                        .HasColumnType("bit");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgayLap")
                        .HasColumnType("datetime");

                    b.Property<string>("TenDeTai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("TepDinhKem")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("TinhTrangDangKy")
                        .HasColumnType("int");

                    b.Property<int?>("TinhTrangPheDuyet")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdgiangVien");

                    b.HasIndex("Idnhom");

                    b.ToTable("DeTaiNghienCuu");
                });

            modelBuilder.Entity("Data.Models.GiangVien", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("bigint");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("Ho")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<string>("Sdt")
                        .HasColumnName("SDT")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("GiangVien");
                });

            modelBuilder.Entity("Data.Models.HoiDong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("NgayLap")
                        .HasColumnType("datetime");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HoiDong");
                });

            modelBuilder.Entity("Data.Models.ImgBaiPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnhDinhKem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdbaiPost")
                        .HasColumnName("IDBaiPost")
                        .HasColumnType("int");

                    b.Property<string>("KichThuoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenAnh")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdbaiPost");

                    b.ToTable("imgBaiPost");
                });

            modelBuilder.Entity("Data.Models.KenhThaoLuan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("IddeTai")
                        .HasColumnName("IDDeTai")
                        .HasColumnType("bigint");

                    b.Property<long?>("IdgiangVien")
                        .HasColumnName("IDGiangVien")
                        .HasColumnType("bigint");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IddeTai");

                    b.HasIndex("IdgiangVien");

                    b.ToTable("KenhThaoLuan");
                });

            modelBuilder.Entity("Data.Models.MoDot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdnamHoc")
                        .HasColumnName("IDNamHoc")
                        .HasColumnType("int");

                    b.Property<long?>("IdquanLy")
                        .HasColumnName("IDQuanLy")
                        .HasColumnType("bigint");

                    b.Property<int?>("Loai")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ThoiGianBd")
                        .HasColumnName("ThoiGianBD")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("ThoiGianKt")
                        .HasColumnName("ThoiGianKT")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("IdnamHoc");

                    b.HasIndex("IdquanLy");

                    b.ToTable("MoDot");
                });

            modelBuilder.Entity("Data.Models.NamHoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HocKy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("NamHoc");
                });

            modelBuilder.Entity("Data.Models.Nhom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Nhom");
                });

            modelBuilder.Entity("Data.Models.NhomSinhVien", b =>
                {
                    b.Property<int>("Idnhom")
                        .HasColumnName("IDNhom")
                        .HasColumnType("int");

                    b.Property<long>("IdsinhVien")
                        .HasColumnName("IDSinhVien")
                        .HasColumnType("bigint");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("Idnhom", "IdsinhVien")
                        .HasName("PK__Nhom_Sin__CD149E43F71CE773");

                    b.HasIndex("IdsinhVien");

                    b.ToTable("Nhom_SinhVien");
                });

            modelBuilder.Entity("Data.Models.QuanLy", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnName("ID")
                        .HasColumnType("bigint");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("Ho")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<string>("Sdt")
                        .HasColumnName("SDT")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("QuanLy");
                });

            modelBuilder.Entity("Data.Models.SinhVien", b =>
                {
                    b.Property<long>("Mssv")
                        .HasColumnName("MSSV")
                        .HasColumnType("bigint");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("Ho")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<string>("Sdt")
                        .HasColumnName("SDT")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Mssv")
                        .HasName("PK__SinhVien__6CB3B7F96B8F18DF");

                    b.ToTable("SinhVien");
                });

            modelBuilder.Entity("Data.Models.XetDuyetVaDanhGia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("IddeTai")
                        .HasColumnName("IDDeTai")
                        .HasColumnType("bigint");

                    b.Property<int?>("IdhoiDong")
                        .HasColumnName("IDHoiDong")
                        .HasColumnType("int");

                    b.Property<int?>("IdmoDot")
                        .HasColumnName("IDMoDot")
                        .HasColumnType("int");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TepDinhKem")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IddeTai");

                    b.HasIndex("IdhoiDong");

                    b.HasIndex("IdmoDot");

                    b.ToTable("XetDuyetVaDanhGia");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("Data.Models.BaiPost", b =>
                {
                    b.HasOne("Data.Models.KenhThaoLuan", "IdkenhThaoLuanNavigation")
                        .WithMany("BaiPost")
                        .HasForeignKey("IdkenhThaoLuan")
                        .HasConstraintName("FK__BaiPost__IDCTKen__6754599E");
                });

            modelBuilder.Entity("Data.Models.BaoCaoTienDo", b =>
                {
                    b.HasOne("Data.Models.DeTaiNghienCuu", "IddeTaiNavigation")
                        .WithMany("BaoCaoTienDo")
                        .HasForeignKey("IddeTai")
                        .HasConstraintName("FK__BaoCaoTie__IDDeT__5DCAEF64");
                });

            modelBuilder.Entity("Data.Models.BoNhiem", b =>
                {
                    b.HasOne("Data.Models.GiangVien", "IdgiangVienNavigation")
                        .WithMany("BoNhiem")
                        .HasForeignKey("IdgiangVien")
                        .HasConstraintName("FK__BoNhiem__IDGiang__49C3F6B7");

                    b.HasOne("Data.Models.HoiDong", "IdhoiDongNavigation")
                        .WithMany("BoNhiem")
                        .HasForeignKey("IdhoiDong")
                        .HasConstraintName("FK__BoNhiem__IDHoiDo__4BAC3F29");

                    b.HasOne("Data.Models.QuanLy", "IdquanLyNavigation")
                        .WithMany("BoNhiem")
                        .HasForeignKey("IdquanLy")
                        .HasConstraintName("FK__BoNhiem__IDQuanL__4AB81AF0");
                });

            modelBuilder.Entity("Data.Models.Comments", b =>
                {
                    b.HasOne("Data.Models.BaiPost", "IdbaiPostNavigation")
                        .WithMany("Comments")
                        .HasForeignKey("IdbaiPost")
                        .HasConstraintName("FK__Comments__IDBaiP__6A30C649");
                });

            modelBuilder.Entity("Data.Models.CtxetDuyetVaDanhGia", b =>
                {
                    b.HasOne("Data.Models.XetDuyetVaDanhGia", "IdxetDuyetNavigation")
                        .WithMany("CtxetDuyetVaDanhGia")
                        .HasForeignKey("IdxetDuyet")
                        .HasConstraintName("FK__CTXetDuye__IDXet__5AEE82B9");
                });

            modelBuilder.Entity("Data.Models.DeTaiNghienCuu", b =>
                {
                    b.HasOne("Data.Models.GiangVien", "IdgiangVienNavigation")
                        .WithMany("DeTaiNghienCuu")
                        .HasForeignKey("IdgiangVien")
                        .HasConstraintName("FK__DeTaiNghi__IDGia__4E88ABD4");

                    b.HasOne("Data.Models.Nhom", "IdnhomNavigation")
                        .WithMany("DeTaiNghienCuu")
                        .HasForeignKey("Idnhom")
                        .HasConstraintName("FK__DeTaiNghi__IDNho__4F7CD00D");
                });

            modelBuilder.Entity("Data.Models.ImgBaiPost", b =>
                {
                    b.HasOne("Data.Models.BaiPost", "IdbaiPostNavigation")
                        .WithMany("ImgBaiPost")
                        .HasForeignKey("IdbaiPost")
                        .HasConstraintName("FK__imgBaiPost__IDBaiP__6A30C649");
                });

            modelBuilder.Entity("Data.Models.KenhThaoLuan", b =>
                {
                    b.HasOne("Data.Models.DeTaiNghienCuu", "IddeTaiNavigation")
                        .WithMany("KenhThaoLuan")
                        .HasForeignKey("IddeTai")
                        .HasConstraintName("FK__KenhThaoL__IDDeTai__60A75C0F");

                    b.HasOne("Data.Models.GiangVien", "IdgiangVienNavigation")
                        .WithMany("KenhThaoLuan")
                        .HasForeignKey("IdgiangVien")
                        .HasConstraintName("FK__KenhThaoL__IDGia__60A75C0F");
                });

            modelBuilder.Entity("Data.Models.MoDot", b =>
                {
                    b.HasOne("Data.Models.NamHoc", "IdnamHocNavigation")
                        .WithMany("MoDot")
                        .HasForeignKey("IdnamHoc")
                        .HasConstraintName("FK__MoDot__IDNamHoc__52593CB8");

                    b.HasOne("Data.Models.QuanLy", "IdquanLyNavigation")
                        .WithMany("MoDot")
                        .HasForeignKey("IdquanLy")
                        .HasConstraintName("FK__MoDot__IDQuanLy__534D60F1");
                });

            modelBuilder.Entity("Data.Models.NhomSinhVien", b =>
                {
                    b.HasOne("Data.Models.Nhom", "IdnhomNavigation")
                        .WithMany("NhomSinhVien")
                        .HasForeignKey("Idnhom")
                        .HasConstraintName("FK__Nhom_Sinh__Statu__3F466844")
                        .IsRequired();

                    b.HasOne("Data.Models.SinhVien", "IdsinhVienNavigation")
                        .WithMany("NhomSinhVien")
                        .HasForeignKey("IdsinhVien")
                        .HasConstraintName("FK__Nhom_Sinh__IDSin__403A8C7D")
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Models.XetDuyetVaDanhGia", b =>
                {
                    b.HasOne("Data.Models.DeTaiNghienCuu", "IddeTaiNavigation")
                        .WithMany("XetDuyetVaDanhGia")
                        .HasForeignKey("IddeTai")
                        .HasConstraintName("FK__XetDuyetV__IDDeT__5629CD9C");

                    b.HasOne("Data.Models.HoiDong", "IdhoiDongNavigation")
                        .WithMany("XetDuyetVaDanhGia")
                        .HasForeignKey("IdhoiDong")
                        .HasConstraintName("FK__XetDuyetV__IDHoi__571DF1D5");

                    b.HasOne("Data.Models.MoDot", "IdmoDotNavigation")
                        .WithMany("XetDuyetVaDanhGia")
                        .HasForeignKey("IdmoDot")
                        .HasConstraintName("FK__XetDuyetV__IDMoD__5812160E");
                });
#pragma warning restore 612, 618
        }
    }
}
