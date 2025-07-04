﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace pdc_api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250630174234_SeedGuiaRequisito11")]
    partial class SeedGuiaRequisito11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

            modelBuilder.Entity("Questionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Pergunta")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Resposta")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Visivel")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Questionario", (string)null);
                });

            modelBuilder.Entity("Referencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubRequisitoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SubRequisitoId");

                    b.ToTable("Referencias");
                });

            modelBuilder.Entity("RegrasOcultacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PerguntaAlvoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PerguntaGatilhoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RespostaGatilho")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PerguntaAlvoId");

                    b.HasIndex("PerguntaGatilhoId");

                    b.ToTable("RegrasOcultacoes", (string)null);
                });

            modelBuilder.Entity("Requisito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Requisitos");
                });

            modelBuilder.Entity("Software", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Fonte")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Justificativa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SubRequisitoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SubRequisitoId")
                        .IsUnique();

                    b.ToTable("Softwares");
                });

            modelBuilder.Entity("SubRequisito", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Check")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("QuestionarioId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RequisitoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("QuestionarioId");

                    b.HasIndex("RequisitoId");

                    b.ToTable("SubRequisitos");
                });

            modelBuilder.Entity("Referencia", b =>
                {
                    b.HasOne("SubRequisito", "SubRequisito")
                        .WithMany()
                        .HasForeignKey("SubRequisitoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubRequisito");
                });

            modelBuilder.Entity("RegrasOcultacao", b =>
                {
                    b.HasOne("Questionario", "PerguntaAlvo")
                        .WithMany("RegrasOcultacaoAlvo")
                        .HasForeignKey("PerguntaAlvoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Questionario", "PerguntaGatilho")
                        .WithMany("RegrasOcultacaoGatilho")
                        .HasForeignKey("PerguntaGatilhoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("PerguntaAlvo");

                    b.Navigation("PerguntaGatilho");
                });

            modelBuilder.Entity("Software", b =>
                {
                    b.HasOne("SubRequisito", "SubRequisito")
                        .WithOne("Software")
                        .HasForeignKey("Software", "SubRequisitoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SubRequisito");
                });

            modelBuilder.Entity("SubRequisito", b =>
                {
                    b.HasOne("Questionario", "Questionario")
                        .WithMany("SubRequisitos")
                        .HasForeignKey("QuestionarioId");

                    b.HasOne("Requisito", "Requisito")
                        .WithMany("SubRequisitos")
                        .HasForeignKey("RequisitoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Questionario");

                    b.Navigation("Requisito");
                });

            modelBuilder.Entity("Questionario", b =>
                {
                    b.Navigation("RegrasOcultacaoAlvo");

                    b.Navigation("RegrasOcultacaoGatilho");

                    b.Navigation("SubRequisitos");
                });

            modelBuilder.Entity("Requisito", b =>
                {
                    b.Navigation("SubRequisitos");
                });

            modelBuilder.Entity("SubRequisito", b =>
                {
                    b.Navigation("Software");
                });
#pragma warning restore 612, 618
        }
    }
}
