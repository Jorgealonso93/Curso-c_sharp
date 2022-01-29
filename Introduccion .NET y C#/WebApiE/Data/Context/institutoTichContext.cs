using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebApiE.Data.Models;

#nullable disable

namespace WebApiE.Data.Context
{
    public partial class institutoTichContext : DbContext
    {
        public institutoTichContext()
        {
        }

        public institutoTichContext(DbContextOptions<institutoTichContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; }
        public virtual DbSet<AlumnosBaja> AlumnosBajas { get; set; }
        public virtual DbSet<CatCurso> CatCursos { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<CursoAlumno> CursoAlumnos { get; set; }
        public virtual DbSet<CursoInstructore> CursoInstructores { get; set; }
        public virtual DbSet<Estado> Estados { get; set; }
        public virtual DbSet<EstatusAlumno> EstatusAlumnos { get; set; }
        public virtual DbSet<Instructore> Instructores { get; set; }
        public virtual DbSet<Saldo> Saldos { get; set; }
        public virtual DbSet<TablaIsr> TablaIsrs { get; set; }
        public virtual DbSet<Transaccione> Transacciones { get; set; }
        public virtual DbSet<VAlumno> VAlumnos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasKey(e => e.IdAlumno)
                    .HasName("PK__alumnos__6D77A7F1AB96DF13");

                entity.ToTable("alumnos");

                entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Curp)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("curp")
                    .IsFixedLength(true);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");

                entity.Property(e => e.NombreAlumno)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nombre_alumno");

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");

                entity.Property(e => e.Sueldo)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("sueldo");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("telefono")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Alumnos)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_alumnosEstado");

                entity.HasOne(d => d.IdEstatusNavigation)
                    .WithMany(p => p.Alumnos)
                    .HasForeignKey(d => d.IdEstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_alumnosEstatus");
            });

            modelBuilder.Entity<AlumnosBaja>(entity =>
            {
                entity.HasKey(e => e.IdAlumnosBaja)
                    .HasName("PK__alumnosB__A927D1462FAEA683");

                entity.ToTable("alumnosBaja");

                entity.Property(e => e.IdAlumnosBaja).HasColumnName("idAlumnos_Baja");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaBaja");

                entity.Property(e => e.NombreAlumno)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nombreAlumno");

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");
            });

            modelBuilder.Entity<CatCurso>(entity =>
            {
                entity.HasKey(e => e.IdCatCurso)
                    .HasName("PK__cat_curs__7B976C3223C1EC6A");

                entity.ToTable("cat_cursos");

                entity.Property(e => e.IdCatCurso).HasColumnName("id_catCurso");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.ClaveCatCurso)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("clave_catCurso");

                entity.Property(e => e.DescCatCurso)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("desc_catCurso");

                entity.Property(e => e.Horas).HasColumnName("horas");

                entity.Property(e => e.IdPrerequisito).HasColumnName("idPrerequisito");

                entity.Property(e => e.NombreCatCurso)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre_catCurso");

                entity.HasOne(d => d.IdPrerequisitoNavigation)
                    .WithMany(p => p.InverseIdPrerequisitoNavigation)
                    .HasForeignKey(d => d.IdPrerequisito)
                    .HasConstraintName("FK_catCursos");
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasKey(e => e.IdCurso)
                    .HasName("PK__cursos__5D3F7502DDE7330E");

                entity.ToTable("cursos");

                entity.Property(e => e.IdCurso).HasColumnName("id_curso");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("date")
                    .HasColumnName("fechaInicio");

                entity.Property(e => e.FechaTermino)
                    .HasColumnType("date")
                    .HasColumnName("fechaTermino");

                entity.Property(e => e.IdCatCurso).HasColumnName("id_catCurso");

                entity.HasOne(d => d.IdCatCursoNavigation)
                    .WithMany(p => p.Cursos)
                    .HasForeignKey(d => d.IdCatCurso)
                    .HasConstraintName("FK_curso_catCurso");
            });

            modelBuilder.Entity<CursoAlumno>(entity =>
            {
                entity.HasKey(e => e.IdCursoAlumno)
                    .HasName("PK__cursoAlu__9CB7D457BB5B5EEF");

                entity.ToTable("cursoAlumnos");

                entity.Property(e => e.IdCursoAlumno).HasColumnName("idCurso_alumno");

                entity.Property(e => e.Calificacion).HasColumnName("calificacion");

                entity.Property(e => e.FechaBaja)
                    .HasColumnType("date")
                    .HasColumnName("fechaBaja");

                entity.Property(e => e.FechaInscripcion)
                    .HasColumnType("date")
                    .HasColumnName("fechaInscripcion");

                entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");

                entity.Property(e => e.IdCurso).HasColumnName("id_curso");

                entity.HasOne(d => d.IdAlumnoNavigation)
                    .WithMany(p => p.CursoAlumnos)
                    .HasForeignKey(d => d.IdAlumno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_alumno_CursoAlumno");

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.CursoAlumnos)
                    .HasForeignKey(d => d.IdCurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_curso_CursoAlumno");
            });

            modelBuilder.Entity<CursoInstructore>(entity =>
            {
                entity.HasKey(e => e.IdCursoInstructor)
                    .HasName("PK__cursoIns__CE655F839E1DBCBB");

                entity.ToTable("cursoInstructores");

                entity.Property(e => e.IdCursoInstructor).HasColumnName("idCurso_instructor");

                entity.Property(e => e.FechaContratacion)
                    .HasColumnType("date")
                    .HasColumnName("fechaContratacion");

                entity.Property(e => e.IdCurso).HasColumnName("id_curso");

                entity.Property(e => e.IdInstructor).HasColumnName("id_instructor");

                entity.HasOne(d => d.IdCursoNavigation)
                    .WithMany(p => p.CursoInstructores)
                    .HasForeignKey(d => d.IdCurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_curso_CursoInstructor");

                entity.HasOne(d => d.IdInstructorNavigation)
                    .WithMany(p => p.CursoInstructores)
                    .HasForeignKey(d => d.IdInstructor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_inst_CursoInstructor");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PK__estados__86989FB21DB81B87");

                entity.ToTable("estados");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.NombreEstado)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre_estado");
            });

            modelBuilder.Entity<EstatusAlumno>(entity =>
            {
                entity.HasKey(e => e.IdEstatus)
                    .HasName("PK__estatus___3B2CE273B40D0A90");

                entity.ToTable("estatus_alumnos");

                entity.Property(e => e.IdEstatus).HasColumnName("id_estatus");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("clave")
                    .IsFixedLength(true);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            modelBuilder.Entity<Instructore>(entity =>
            {
                entity.HasKey(e => e.IdInstructor)
                    .HasName("PK__instruct__1CCC4C122CBAE398");

                entity.ToTable("instructores");

                entity.Property(e => e.IdInstructor).HasColumnName("id_instructor");

                entity.Property(e => e.Activo).HasColumnName("activo");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.CuotaHora)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("cuotaHora");

                entity.Property(e => e.Curp)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("curp")
                    .IsFixedLength(true);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.NombreInstructor)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nombre_instructor");

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.Rfc)
                    .IsRequired()
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("rfc")
                    .IsFixedLength(true);

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("telefono")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Saldo>(entity =>
            {
                entity.ToTable("saldos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Saldo1)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("saldo");
            });

            modelBuilder.Entity<TablaIsr>(entity =>
            {
                entity.ToTable("TablaISR");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CuotaFija).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.ExedLimInf).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.LimInf).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.LimSup).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.Subsidio).HasColumnType("decimal(19, 2)");
            });

            modelBuilder.Entity<Transaccione>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdDestino).HasColumnName("idDestino");

                entity.Property(e => e.IdOrigen).HasColumnName("idOrigen");

                entity.Property(e => e.Monto)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("monto");

                entity.HasOne(d => d.IdDestinoNavigation)
                    .WithMany(p => p.TransaccioneIdDestinoNavigations)
                    .HasForeignKey(d => d.IdDestino)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Transacci__idDes__151B244E");

                entity.HasOne(d => d.IdOrigenNavigation)
                    .WithMany(p => p.TransaccioneIdOrigenNavigations)
                    .HasForeignKey(d => d.IdOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Transacci__idOri__14270015");
            });

            modelBuilder.Entity<VAlumno>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAlumnos");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Curp)
                    .IsRequired()
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .HasColumnName("curp")
                    .IsFixedLength(true);

                entity.Property(e => e.Estado)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre).HasColumnName("nombre");

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("telefono")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
