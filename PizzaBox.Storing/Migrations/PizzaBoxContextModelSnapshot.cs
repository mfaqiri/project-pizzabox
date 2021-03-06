// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaBox.Storing;

namespace PizzaBox.Storing.Migrations
{
    [DbContext(typeof(PizzaBoxContext))]
    partial class PizzaBoxContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.ACrust", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<bool>("vegan")
                        .HasColumnType("bit");

                    b.Property<bool>("veget")
                        .HasColumnType("bit");

                    b.HasKey("EntityId");

                    b.ToTable("Crusts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ACrust");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.APizza", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CrustEntityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("SauceEntityId")
                        .HasColumnType("bigint");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("orderEntityId")
                        .HasColumnType("bigint");

                    b.Property<long>("pizzaType")
                        .HasColumnType("bigint");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("EntityId");

                    b.HasIndex("CrustEntityId");

                    b.HasIndex("SauceEntityId");

                    b.HasIndex("orderEntityId");

                    b.ToTable("Pizzas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("APizza");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.ASauce", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<bool>("vegan")
                        .HasColumnType("bit");

                    b.Property<bool>("veget")
                        .HasColumnType("bit");

                    b.HasKey("EntityId");

                    b.ToTable("Sauces");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ASauce");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.AStore", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntityId");

                    b.ToTable("Stores");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AStore");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.ATopping", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("pizzaEntityId")
                        .HasColumnType("bigint");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<bool>("vegan")
                        .HasColumnType("bit");

                    b.Property<bool>("veget")
                        .HasColumnType("bit");

                    b.HasKey("EntityId");

                    b.HasIndex("pizzaEntityId");

                    b.ToTable("Toppings");

                    b.HasDiscriminator<string>("Discriminator").HasValue("ATopping");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Orders.Customer", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntityId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            name = "Uncle John"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Orders.Order", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("customerEntityId")
                        .HasColumnType("bigint");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.Property<long?>("storeEntityId")
                        .HasColumnType("bigint");

                    b.HasKey("EntityId");

                    b.HasIndex("customerEntityId");

                    b.HasIndex("storeEntityId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Crusts.LargeCrust", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ACrust");

                    b.HasDiscriminator().HasValue("LargeCrust");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Crusts.MediumCrust", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ACrust");

                    b.HasDiscriminator().HasValue("MediumCrust");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Crusts.SmallCrust", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ACrust");

                    b.HasDiscriminator().HasValue("SmallCrust");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Crusts.XLargeCrust", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ACrust");

                    b.HasDiscriminator().HasValue("XLargeCrust");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizzas.CheesePizza", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.APizza");

                    b.HasDiscriminator().HasValue("CheesePizza");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizzas.CustomPizza", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.APizza");

                    b.HasDiscriminator().HasValue("CustomPizza");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizzas.MeatloversPizza", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.APizza");

                    b.HasDiscriminator().HasValue("MeatloversPizza");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Sauces.Alfredo", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ASauce");

                    b.HasDiscriminator().HasValue("Alfredo");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Sauces.Bbq", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ASauce");

                    b.HasDiscriminator().HasValue("Bbq");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Sauces.Marinara", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ASauce");

                    b.HasDiscriminator().HasValue("Marinara");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Stores.ChicagoStore", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.AStore");

                    b.HasDiscriminator().HasValue("ChicagoStore");

                    b.HasData(
                        new
                        {
                            EntityId = 1L,
                            name = "Chitown Main Street"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Stores.NewYorkStore", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.AStore");

                    b.HasDiscriminator().HasValue("NewYorkStore");

                    b.HasData(
                        new
                        {
                            EntityId = 2L,
                            name = "Big Apple"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.BlackBeans", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("BlackBeans");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Chedder", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Chedder");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.FriedEgg", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("FriedEgg");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.GrilledChicken", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("GrilledChicken");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Jalapeno", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Jalapeno");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Mozzerella", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Mozzerella");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Parmesan", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Parmesan");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Pepporoni", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Pepporoni");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Pineapple", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Pineapple");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Sausage", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Sausage");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Spinach", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Spinach");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Toppings.Tomato", b =>
                {
                    b.HasBaseType("PizzaBox.Domain.Abstracts.ATopping");

                    b.HasDiscriminator().HasValue("Tomato");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.APizza", b =>
                {
                    b.HasOne("PizzaBox.Domain.Abstracts.ACrust", "Crust")
                        .WithMany()
                        .HasForeignKey("CrustEntityId");

                    b.HasOne("PizzaBox.Domain.Abstracts.ASauce", "Sauce")
                        .WithMany()
                        .HasForeignKey("SauceEntityId");

                    b.HasOne("PizzaBox.Domain.Models.Orders.Order", "order")
                        .WithMany("pizzas")
                        .HasForeignKey("orderEntityId");

                    b.Navigation("Crust");

                    b.Navigation("order");

                    b.Navigation("Sauce");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.ATopping", b =>
                {
                    b.HasOne("PizzaBox.Domain.Abstracts.APizza", "pizza")
                        .WithMany("Toppings")
                        .HasForeignKey("pizzaEntityId");

                    b.Navigation("pizza");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Orders.Order", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Orders.Customer", "customer")
                        .WithMany("orders")
                        .HasForeignKey("customerEntityId");

                    b.HasOne("PizzaBox.Domain.Abstracts.AStore", "store")
                        .WithMany("orders")
                        .HasForeignKey("storeEntityId");

                    b.Navigation("customer");

                    b.Navigation("store");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.APizza", b =>
                {
                    b.Navigation("Toppings");
                });

            modelBuilder.Entity("PizzaBox.Domain.Abstracts.AStore", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Orders.Customer", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Orders.Order", b =>
                {
                    b.Navigation("pizzas");
                });
#pragma warning restore 612, 618
        }
    }
}
