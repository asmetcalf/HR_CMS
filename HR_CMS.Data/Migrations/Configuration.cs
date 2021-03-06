﻿namespace HR_CMS.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography;
    using System.Security.Cryptography.X509Certificates;

    internal sealed class Configuration : DbMigrationsConfiguration<HR_CMS.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "HR_CMS.Data.ApplicationDbContext";
        }

        protected override void Seed(HR_CMS.Data.ApplicationDbContext context)
        {
            //return; // <-- comment for seed content / uncomment for no seed content

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //Seed Depts
            var vDays = 1.5;
            var pDays = .5;
            var sDays = .5;
            context.DeptDbSet.AddOrUpdate(x => x.DeptId,
                //Human Resources
                new Dept()
                {
                    DeptId = 1,
                    DeptName = "Human Resources",
                },
                //Sales
                new Dept()
                {
                    DeptId = 2,
                    DeptName = "Sales",
                },
                //Marketing
                new Dept()
                {
                    DeptId = 3,
                    DeptName = "Marketing",
                },
                // R&D
                new Dept()
                {
                    DeptId = 4,
                    DeptName = "Research & Development",
                },
                // Compliance
                new Dept()
                {
                    DeptId = 5,
                    DeptName = "Compliance",
                }
            );
            //Seed Positions
            context.PositionDbSet.AddOrUpdate(x => x.PositionId,
                //HR Executive Director
                new Position()
                {
                    PositionId = 1,
                    DeptId = 1,
                    Department = context.DeptDbSet.Find(1),
                    PositionTitle = "Executive Director",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = true
                },
                //HR Director
                new Position()
                {
                    PositionId = 2,
                    DeptId = 1,
                    Department = context.DeptDbSet.Find(1),
                    PositionTitle = "Director",
                    IsSupervisor = false,
                    IsDirector = true,
                    IsExecutive = false
                },
                //HR Supervisor
                new Position()
                {
                    PositionId = 3,
                    DeptId = 1,
                    Department = context.DeptDbSet.Find(1),
                    PositionTitle = "Supervisor",
                    IsSupervisor = true,
                    IsDirector = false,
                    IsExecutive = false
                },
                //HR Associate
                new Position()
                {
                    PositionId = 4,
                    DeptId = 1,
                    Department = context.DeptDbSet.Find(1),
                    PositionTitle = "Associate",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = false
                },
                //Sales Executive Director
                new Position()
                {
                    PositionId = 5,
                    DeptId = 2,
                    Department = context.DeptDbSet.Find(2),
                    PositionTitle = "Executive Director",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = true
                },
                //Sales Director
                new Position()
                {
                    PositionId = 6,
                    DeptId = 2,
                    Department = context.DeptDbSet.Find(2),
                    PositionTitle = "Director",
                    IsSupervisor = false,
                    IsDirector = true,
                    IsExecutive = false
                },
                //Sales Supervisor
                new Position()
                {
                    PositionId = 7,
                    DeptId = 2,
                    Department = context.DeptDbSet.Find(2),
                    PositionTitle = "Supervisor",
                    IsSupervisor = true,
                    IsDirector = false,
                    IsExecutive = false
                },
                //Sales Associate
                new Position()
                {
                    PositionId = 8,
                    DeptId = 2,
                    Department = context.DeptDbSet.Find(2),
                    PositionTitle = "Associate",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = false
                },
                //Sales Associate, Temp.
                new Position()
                {
                    PositionId = 9,
                    DeptId = 2,
                    Department = context.DeptDbSet.Find(2),
                    PositionTitle = "Temp. Associate",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = false
                },
                //Marketing Executive Director
                new Position()
                {
                    PositionId = 10,
                    DeptId = 3,
                    Department = context.DeptDbSet.Find(3),
                    PositionTitle = "Executive Director",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = true
                },
                //Marketing Director
                new Position()
                {
                    PositionId = 11,
                    DeptId = 3,
                    Department = context.DeptDbSet.Find(3),
                    PositionTitle = "Director",
                    IsSupervisor = false,
                    IsDirector = true,
                    IsExecutive = false
                },
                //Marketing Supervisor
                new Position()
                {
                    PositionId = 12,
                    DeptId = 3,
                    Department = context.DeptDbSet.Find(3),
                    PositionTitle = "Supervisor",
                    IsSupervisor = true,
                    IsDirector = false,
                    IsExecutive = false
                },
                //Marketing Associate
                new Position()
                {
                    PositionId = 13,
                    DeptId = 3,
                    Department = context.DeptDbSet.Find(3),
                    PositionTitle = "Associate",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = false
                },
                //R&D Executive Director
                new Position()
                {
                    PositionId = 14,
                    DeptId = 4,
                    Department = context.DeptDbSet.Find(4),
                    PositionTitle = "Executive Director",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = true
                },
                //R&D Director
                new Position()
                {
                    PositionId = 15,
                    DeptId = 4,
                    Department = context.DeptDbSet.Find(4),
                    PositionTitle = "Director",
                    IsSupervisor = false,
                    IsDirector = true,
                    IsExecutive = false
                },
                //R&D Supervisor
                new Position()
                {
                    PositionId = 16,
                    DeptId = 4,
                    Department = context.DeptDbSet.Find(4),
                    PositionTitle = "Supervisor",
                    IsSupervisor = true,
                    IsDirector = false,
                    IsExecutive = false
                },
                //R&D Associate
                new Position()
                {
                    PositionId = 17,
                    DeptId = 4,
                    Department = context.DeptDbSet.Find(4),
                    PositionTitle = "Associate",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = false
                },
                //Compliance Executive Director
                new Position()
                {
                    PositionId = 18,
                    DeptId = 5,
                    Department = context.DeptDbSet.Find(5),
                    PositionTitle = "Executive Director",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = true
                },
                //Compliance Director
                new Position()
                {
                    PositionId = 19,
                    DeptId = 5,
                    Department = context.DeptDbSet.Find(5),
                    PositionTitle = "Director",
                    IsSupervisor = false,
                    IsDirector = true,
                    IsExecutive = false
                },
                //Compliance Supervisor
                new Position()
                {
                    PositionId = 20,
                    DeptId = 5,
                    Department = context.DeptDbSet.Find(5),
                    PositionTitle = "Supervisor",
                    IsSupervisor = true,
                    IsDirector = false,
                    IsExecutive = false
                },
                //Compliance Associate
                new Position()
                {
                    PositionId = 21,
                    DeptId = 5,
                    Department = context.DeptDbSet.Find(5),
                    PositionTitle = "Associate",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = false
                }
            );
            //Seed Personnel
            context.PersonnelDbSet.AddOrUpdate(x => x.PersonnelId,
                //1: Tammy Winslow, Marketing Director
                new Personnel()
                {
                    PersonnelId = 1,
                    FirstName = "Tammy",
                    LastName = "Winslow",
                    MiddleName = "Christine",
                    SSN = "431-90-2134",
                    DOB = new DateTime(1973, 09, 08),
                    DOH = new DateTime(2005, 07, 13),
                    DOT = null
                },
                //2: Cassidy Pfannerstill, Sales Director
                new Personnel()
                {
                    PersonnelId = 2,
                    FirstName = "Cassidy",
                    LastName = "Pfannerstill",
                    MiddleName = "Kyle",
                    SSN = "003-36-2848",
                    DOB = new DateTime(1981, 09, 21),
                    DOH = new DateTime(2011, 02, 19),
                    DOT = null
                },
                //3: Jeff Shields, R&D Supervisor
                new Personnel()
                {
                    PersonnelId = 3,
                    FirstName = "Jeffrey",
                    LastName = "Shields",
                    MiddleName = "Steven",
                    SSN = "004-82-9269",
                    DOB = new DateTime(1986, 06, 27),
                    DOH = new DateTime(2017, 11, 06),
                    DOT = null
                },
                //4: Percy Champlin, R&D Executive Director
                new Personnel()
                {
                    PersonnelId = 4,
                    FirstName = "Percival",
                    LastName = "Champlin",
                    SSN = "217-90-1548",
                    DOB = new DateTime(1978, 01, 04),
                    DOH = new DateTime(1999, 03, 07),
                    DOT = new DateTime(2019, 05, 27)
                },
                //5: Kailyn Douglas, R&D Director
                new Personnel()
                {
                    PersonnelId = 5,
                    FirstName = "Kailyn",
                    LastName = "Douglas",
                    MiddleName = "Celine",
                    SSN = "221-30-6362",
                    DOB = new DateTime(1998, 10, 31),
                    DOH = DateTime.Now.Subtract(TimeSpan.FromDays(67)),
                    DOT = null
                },
                //6: Ellis Reinger, Sales Associate
                new Personnel()
                {
                    PersonnelId = 6,
                    FirstName = "Ellis",
                    LastName = "Reinger",
                    MiddleName = "Archibald",
                    SSN = "528-29-0168",
                    DOB = new DateTime(1985, 04, 02),
                    DOH = new DateTime(2019, 06, 18),
                    DOT = new DateTime(2019, 07, 19)
                },
                //7: Su Lin Park, HR Executive Director
                new Personnel()
                {
                    PersonnelId = 7,
                    FirstName = "Su Lin",
                    LastName = "Park",
                    SSN = "502-35-6860",
                    DOB = new DateTime(1971, 11, 08),
                    DOH = new DateTime(1992, 08, 01),
                    DOT = null
                },
                //8: Mackenzie Lairmore, Compliance Associate
                new Personnel()
                {
                    PersonnelId = 8,
                    FirstName = "Mackenzie",
                    LastName = "Lairmore",
                    MiddleName = "Joseph",
                    SSN = "166-28-6107",
                    DOB = new DateTime(1989, 03, 11),
                    DOH = new DateTime(2009, 07, 11),
                    DOT = new DateTime(2019, 06, 02)
                },
                //9: Ralph Kirlin, Compliance Supervisor
                new Personnel()
                {
                    PersonnelId = 9,
                    FirstName = "Ralph",
                    LastName = "Kirlin",
                    MiddleName = "Oriole",
                    SSN = "520-06-9301",
                    DOB = new DateTime(1993, 04, 07),
                    DOH = new DateTime(2014, 04, 15),
                    DOT = null
                },
                //10: Kat Mwanza, Sales Associate (Temp)
                new Personnel()
                {
                    PersonnelId = 10,
                    FirstName = "Katarina",
                    LastName = "Mwanza",
                    SSN = "587-80-1954",
                    DOB = new DateTime(2001, 03, 17),
                    DOH = DateTime.Now.Subtract(TimeSpan.FromDays(34)),
                    DOT = null
                },
                //11: Ed Fergusen, HR Supervisor
                new Personnel()
                {
                    PersonnelId = 11,
                    FirstName = "Edward",
                    LastName = "Fergusen",
                    MiddleName = "Nicholas",
                    SSN = "127-92-6481",
                    DOB = new DateTime(1981, 07, 04),
                    DOH = new DateTime(2005, 08, 16),
                    DOT = default
                },
                //12: Jackie Nuhn, HR Associate
                new Personnel()
                {
                    PersonnelId = 12,
                    FirstName = "Jacqueline",
                    LastName = "Nuhn",
                    SSN = "656-11-0227",
                    DOB = new DateTime(1997, 01, 25),
                    DOH = new DateTime(2016, 01, 30),
                    DOT = new DateTime(2019, 05, 22)
                },
                //13: Fred Silk, Compliance Director
                new Personnel()
                {
                    PersonnelId = 13,
                    FirstName = "Fred",
                    LastName = "Silk",
                    MiddleName = "Oswald",
                    SSN = "133-77-5619",
                    DOB = new DateTime(1978, 03, 13),
                    DOH = new DateTime(2011, 12, 02),
                    DOT = null
                },
                //14: Reggie Williams, Marketing Executive Director
                new Personnel()
                {
                    PersonnelId = 14,
                    FirstName = "Reggie",
                    LastName = "Williams",
                    MiddleName = "Samuel",
                    SSN = "226-14-1207",
                    DOB = new DateTime(1977, 11, 08),
                    DOH = new DateTime(2008, 04, 06),
                    DOT = null
                },
                //15: Jun Makoto, Marketing Associate
                new Personnel()
                {
                    PersonnelId = 15,
                    FirstName = "Jun",
                    LastName = "Makoto",
                    SSN = "984-64-3337",
                    DOB = new DateTime(1999, 01, 01),
                    DOH = new DateTime(2019, 01, 02),
                    DOT = null
                }

            );
            //Seed Contact
            context.ContactDbSet.AddOrUpdate(x => x.ContactId,
                //1: Tammy Winslow, Marketing Director
                new Contact()
                {
                    ContactId = 1,
                    PersonnelId = 1,
                    PhoneNumber = "(883)555-0421",
                    Email = "workerbee411@email.net",
                    Address = "1911 Colton Ave"
                },
                //2: Cassidy Pfannerstill, Sales Director
                new Contact()
                {
                    ContactId = 2,
                    PersonnelId = 2,
                    PhoneNumber = "(883)555-0422",
                    Email = "workerbee311@email.net",
                    Address = "111 Golden Ave"
                },
                //3: Jeff Shields, R&D Supervisor
                new Contact()
                {
                    ContactId = 3,
                    PersonnelId = 3,
                    PhoneNumber = "(883)555-0423",
                    Email = "workerbee211@email.net",
                    Address = "211 Golden Ave"
                },
                //4: Percy Champlin, R&D Executive Director
                new Contact()
                {
                    ContactId = 4,
                    PersonnelId = 4,
                    PhoneNumber = "(883)555-0424",
                    Email = "workerbee11@email.net",
                    Address = "202 Forensic Drive"
                },
                //5: Kailyn Douglas, R&D Director
                new Contact()
                {
                    ContactId = 5,
                    PersonnelId = 5,
                    PhoneNumber = "(883)555-0271",
                    Email = "workerbee511@email.net",
                    Address = "2503 Colton Ave"
                },
                //6: Ellis Reinger, Sales Associate
                new Contact()
                {
                    ContactId = 6,
                    PersonnelId = 6,
                    PhoneNumber = "(883)555-0523",
                    Email = "workerbee611@email.net",
                    Address = "3713 Broadridge Way"
                },
                //7: Su Lin Park, HR Executive Director
                new Contact()
                {
                    ContactId = 7,
                    PersonnelId = 7,
                    PhoneNumber = "(883)555-8971",
                    Email = "workerbee31@email.net",
                    Address = "25 Cottage Circle"
                },
                //8: Mackenzie Lairmore, Compliance Associate
                new Contact()
                {
                    ContactId = 8,
                    PersonnelId = 8,
                    PhoneNumber = "(883)555-1143",
                    Email = "workerbee271@email.net",
                    Address = "37005 Carlton Cove Parkway"
                },
                //9: Ralph Kirlin, Compliance Supervisor
                new Contact()
                {
                    ContactId = 9,
                    PersonnelId = 9,
                    PhoneNumber = "(883)555-2123",
                    Email = "workerbee411@email.net",
                    Address = "3498 Chicago Rd"
                },
                //10: Kat Mwanza, Sales Associate (Temp)
                new Contact()
                {
                    ContactId = 10,
                    PersonnelId = 10,
                    PhoneNumber = "(883)555-1539",
                    Email = "elvis.is.life@elvisfans.net",
                    Address = "205 Memphis Rd"
                },
                //11: Ed Fergusen, HR Supervisor
                new Contact()
                {
                    ContactId = 11,
                    PersonnelId = 11,
                    PhoneNumber = "(965)555-6897",
                    Email = "ed.ferg@email.com",
                    Address = "346 Greyscale Drive"
                },
                //12: Jackie Nuhn, HR Associate
                new Contact()
                {
                    ContactId = 12,
                    PersonnelId = 12,
                    PhoneNumber = "(883)555-3491",
                    Email = "nuhnyabizness@email.com",
                    Address = "56 Digital Frontier Circle"
                },
                //13: Fred Silk, Compliance Director
                new Contact()
                {
                    ContactId = 13,
                    PersonnelId = 13,
                    PhoneNumber = "(883)555-5551",
                    Email = "fred.silk.compliance@email.com",
                    Address = "425 Marco Polo Parkway"
                },
                //14: Reggie Williams, Marketing Executive Director
                new Contact()
                {
                    ContactId = 14,
                    PersonnelId = 14,
                    PhoneNumber = "(883)555-4541",
                    Email = "reggiewill@email.com",
                    Address = "66 Sabbath Lane"
                },
                //15: Jun Makoto, Marketing Associate
                new Contact()
                {
                    ContactId = 15,
                    PersonnelId = 15,
                    PhoneNumber = "(883)555-7749",
                    Email = "truth4good@email.com",
                    Address = "25681 Airway West Blvd"
                }
            );
            //Seed WorkInfo
            context.WorkInfoDbSet.AddOrUpdate(x => x.WorkInfoId,
                //1: Tammy Winslow, Marketing Director
                new WorkInfo()
                {
                    WorkInfoId = 1,
                    ContactId = 1,
                    PersonnelId = 1,
                    PositionId = 11,
                    Wage = 75000,
                    WorkEmail = "tammy.winslow@company.com",
                    HasBenefits = true,
                    StartOfBenefits = new DateTime(2005, 07, 13).AddDays(90),
                    LastReview = DateTime.Now.Subtract(TimeSpan.FromDays(75)),
                    VacationDaysAccruedLifetime = 15 * 12 * vDays,
                    PersonalDaysAccruedLifetime = 15 * 12 * pDays,
                    SickDaysAccruedLifetime = 15 * 12 * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 30,
                    PersonalDaysUsedLifetime = 5,
                    SickDaysUsedLifetime = 7,
                    VacationDaysUsedForPeriod = 4,
                    PersonalDaysUsedForPeriod = 0,
                    SickDaysUsedForPeriod = 1
                },
                //2: Cassidy Pfannerstill, Sales Director
                new WorkInfo()
                {
                    WorkInfoId = 2,
                    ContactId = 2,
                    PersonnelId = 2,
                    PositionId = 6,
                    Wage = 89000,
                    WorkEmail = "cassidy.pfannerstill@company.com",
                    HasBenefits = true,
                    StartOfBenefits = new DateTime(2011, 02, 19).AddDays(90),
                    LastReview = DateTime.Now.Subtract(TimeSpan.FromDays(75)),
                    VacationDaysAccruedLifetime = 12 * 9 * vDays,
                    PersonalDaysAccruedLifetime = 12 * 9 * pDays,
                    SickDaysAccruedLifetime = 12 * 9 * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 55,
                    PersonalDaysUsedLifetime = 11,
                    SickDaysUsedLifetime = 1,
                    VacationDaysUsedForPeriod = 15,
                    PersonalDaysUsedForPeriod = 3,
                    SickDaysUsedForPeriod = 0

                },
                //3: Jeff Shields, R&D Supervisor
                new WorkInfo()
                {
                    WorkInfoId = 3,
                    ContactId = 3,
                    PersonnelId = 3,
                    PositionId = 16,
                    Wage = 61000,
                    WorkEmail = "jeff.shields@company.com",
                    HasBenefits = true,
                    StartOfBenefits = new DateTime(2017, 11, 06).AddDays(90),
                    LastReview = DateTime.Now.Subtract(TimeSpan.FromDays(75)),
                    VacationDaysAccruedLifetime = 12 * 3 * vDays,
                    PersonalDaysAccruedLifetime = 12 * 3 * pDays,
                    SickDaysAccruedLifetime = 12 * 3 * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 6,
                    PersonalDaysUsedLifetime = 0,
                    SickDaysUsedLifetime = 2,
                    VacationDaysUsedForPeriod = 0,
                    PersonalDaysUsedForPeriod = 0,
                    SickDaysUsedForPeriod = 0
                },
                //4: Percy Champlin, R&D Executive Director
                new WorkInfo()
                {
                    WorkInfoId = 4,
                    ContactId = 4,
                    PersonnelId = 4,
                    PositionId = 14,
                    Wage = 145000,
                    WorkEmail = "percy.champlin@company.com",
                    HasBenefits = true,
                    StartOfBenefits = new DateTime(1999, 03, 07).AddDays(90),
                    LastReview = new DateTime(2019, 05, 27).Subtract(TimeSpan.FromDays(75)),
                    VacationDaysAccruedLifetime = 12 * 20 * vDays,
                    PersonalDaysAccruedLifetime = 12 * 20 * pDays,
                    SickDaysAccruedLifetime = 12 * 20 * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 320,
                    PersonalDaysUsedLifetime = 54,
                    SickDaysUsedLifetime = 21,
                    VacationDaysUsedForPeriod = 0,
                    PersonalDaysUsedForPeriod = 0,
                    SickDaysUsedForPeriod = 0

                },
                //5: Kailyn Douglas, R&D Director
                new WorkInfo()
                {
                    WorkInfoId = 5,
                    ContactId = 5,
                    PersonnelId = 5,
                    PositionId = 15,
                    Wage = 94000,
                    WorkEmail = "kailyn.douglas@company.com",
                    HasBenefits = false,
                    StartOfBenefits = DateTime.Now.Subtract(TimeSpan.FromDays(67)).AddDays(90),
                    LastReview = null,
                    VacationDaysAccruedLifetime = default,
                    PersonalDaysAccruedLifetime = default,
                    SickDaysAccruedLifetime = default,
                    VacationDaysAccruedForPeriod = default,
                    PersonalDaysAccruedForPeriod = default,
                    SickDaysAccruedForPeriod = default,
                    VacationDaysUsedLifetime = default,
                    PersonalDaysUsedLifetime = default,
                    SickDaysUsedLifetime = default,
                    VacationDaysUsedForPeriod = default,
                    PersonalDaysUsedForPeriod = default,
                    SickDaysUsedForPeriod = default

                },
                //6: Ellis Reinger, Sales Associate
                new WorkInfo()
                {
                    WorkInfoId = 6,
                    ContactId = 6,
                    PersonnelId = 6,
                    PositionId = 8,
                    Wage = 32000,
                    WorkEmail = "ellis.reinger@company.com",
                    HasBenefits = default,
                    StartOfBenefits = default,
                    LastReview = new DateTime(2019, 07, 19).Subtract(TimeSpan.FromDays(75)),
                    VacationDaysAccruedLifetime = default,
                    PersonalDaysAccruedLifetime = default,
                    SickDaysAccruedLifetime = default,
                    VacationDaysAccruedForPeriod = default,
                    PersonalDaysAccruedForPeriod = default,
                    SickDaysAccruedForPeriod = default,
                    VacationDaysUsedLifetime = default,
                    PersonalDaysUsedLifetime = default,
                    SickDaysUsedLifetime = default,
                    VacationDaysUsedForPeriod = default,
                    PersonalDaysUsedForPeriod = default,
                    SickDaysUsedForPeriod = default
                },
                //7: Su Lin Park, HR Executive Director
                new WorkInfo()
                {
                    WorkInfoId = 7,
                    ContactId = 7,
                    PersonnelId = 7,
                    PositionId = 1,
                    Wage = 115000,
                    WorkEmail = "sulin.park@company.com",
                    HasBenefits = true,
                    StartOfBenefits = new DateTime(1992, 08, 01).AddDays(90),
                    LastReview = DateTime.Now.Subtract(TimeSpan.FromDays(75)),
                    VacationDaysAccruedLifetime = 18 * 12 * vDays,
                    PersonalDaysAccruedLifetime = 18 * 12 * pDays,
                    SickDaysAccruedLifetime = 18 * 12 * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 180,
                    PersonalDaysUsedLifetime = 14,
                    SickDaysUsedLifetime = 3,
                    VacationDaysUsedForPeriod = 0,
                    PersonalDaysUsedForPeriod = 1,
                    SickDaysUsedForPeriod = 0
                },
                //8: Mackenzie Lairmore, Compliance Associate
                new WorkInfo()
                {
                    WorkInfoId = 8,
                    ContactId = 8,
                    PersonnelId = 8,
                    PositionId = 21,
                    Wage = 35000,
                    WorkEmail = "mackenzie.lairmore@company.com",
                    HasBenefits = true,
                    StartOfBenefits = new DateTime(2009, 07, 11).AddDays(90),
                    LastReview = new DateTime(2019, 06, 02).Subtract(TimeSpan.FromDays(23)),
                    VacationDaysAccruedLifetime = 10 * 12 * vDays,
                    PersonalDaysAccruedLifetime = 10 * 12 * pDays,
                    SickDaysAccruedLifetime = 10 * 12 * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 45,
                    PersonalDaysUsedLifetime = 9,
                    SickDaysUsedLifetime = 1,
                    VacationDaysUsedForPeriod = 0,
                    PersonalDaysUsedForPeriod = 0,
                    SickDaysUsedForPeriod = 0
                },
                //9: Ralph Kirlin, Compliance Supervisor
                new WorkInfo()
                {
                    WorkInfoId = 9,
                    ContactId = 9,
                    PersonnelId = 9,
                    PositionId = 20,
                    Wage = 58000,
                    WorkEmail = "ralph.kirlin@company.com",
                    HasBenefits = true,
                    StartOfBenefits = new DateTime(2014, 04, 15).AddDays(90),
                    LastReview = DateTime.Now.Subtract(TimeSpan.FromDays(2)),
                    VacationDaysAccruedLifetime = 6 * 12 * vDays,
                    PersonalDaysAccruedLifetime = 6 * 12 * pDays,
                    SickDaysAccruedLifetime = 6 * 12 * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 19,
                    PersonalDaysUsedLifetime = 4,
                    SickDaysUsedLifetime = 0,
                    VacationDaysUsedForPeriod = 0,
                    PersonalDaysUsedForPeriod = 4,
                    SickDaysUsedForPeriod = 0

                },
                //10: Kat Mwanza, Sales Associate (Temp)
                new WorkInfo()
                {
                    WorkInfoId = 10,
                    ContactId = 10,
                    PersonnelId = 10,
                    PositionId = 9,
                    Wage = 34000,
                    WorkEmail = "kat.mwanza@company.com",
                    HasBenefits = false,
                    StartOfBenefits = null,
                    LastReview = null,
                    VacationDaysAccruedLifetime = default,
                    PersonalDaysAccruedLifetime = default,
                    SickDaysAccruedLifetime = default,
                    VacationDaysAccruedForPeriod = default,
                    PersonalDaysAccruedForPeriod = default,
                    SickDaysAccruedForPeriod = default,
                    VacationDaysUsedLifetime = default,
                    PersonalDaysUsedLifetime = default,
                    SickDaysUsedLifetime = default,
                    VacationDaysUsedForPeriod = default,
                    PersonalDaysUsedForPeriod = default,
                    SickDaysUsedForPeriod = default
                },
                //11: Ed Fergusen, HR Supervisor
                new WorkInfo()
                {
                    WorkInfoId = 11,
                    ContactId = 11,
                    PersonnelId = 11,
                    PositionId = 3,
                    Wage = 65000,
                    WorkEmail = "ed.fergusen@company.com",
                    HasBenefits = true,
                    StartOfBenefits = new DateTime(2005, 08, 16).AddDays(90),
                    LastReview = DateTime.Now.Subtract(TimeSpan.FromDays(5)),
                    VacationDaysAccruedLifetime = 15 * 12 * vDays,
                    PersonalDaysAccruedLifetime = 15 * 12 * pDays,
                    SickDaysAccruedLifetime = 15 * 12 * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 90,
                    PersonalDaysUsedLifetime = 15,
                    SickDaysUsedLifetime = 23,
                    VacationDaysUsedForPeriod = 0,
                    PersonalDaysUsedForPeriod = 2,
                    SickDaysUsedForPeriod = 3
                },
                //12: Jackie Nuhn, HR Associate
                new WorkInfo()
                {
                    WorkInfoId = 12,
                    ContactId = 12,
                    PersonnelId = 12,
                    PositionId = 4,
                    Wage = 38500,
                    WorkEmail = "jackie.nuhn@company.com",
                    HasBenefits = true,
                    StartOfBenefits = new DateTime(2016, 01, 30).AddDays(90),
                    LastReview = new DateTime(2019, 05, 22).Subtract(TimeSpan.FromDays(35)),
                    VacationDaysAccruedLifetime = 3 * 12 * vDays,
                    PersonalDaysAccruedLifetime = 3 * 12 * pDays,
                    SickDaysAccruedLifetime = 3 * 12 * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 15,
                    PersonalDaysUsedLifetime = 32,
                    SickDaysUsedLifetime = 25,
                    VacationDaysUsedForPeriod = 0,
                    PersonalDaysUsedForPeriod = 0,
                    SickDaysUsedForPeriod = 0
                },
                //13: Fred Silk, Compliance Director
                new WorkInfo()
                {
                    WorkInfoId = 13,
                    ContactId = 13,
                    PersonnelId = 13,
                    PositionId = 19,
                    Wage = 89000,
                    WorkEmail = "fred.silk@company.com",
                    HasBenefits = true,
                    StartOfBenefits = new DateTime(2011, 12, 02).AddDays(90),
                    LastReview = DateTime.Now.Subtract(TimeSpan.FromDays(87)),
                    VacationDaysAccruedLifetime = 9 * 12 * vDays,
                    PersonalDaysAccruedLifetime = 9 * 12 * pDays,
                    SickDaysAccruedLifetime = 9 * 12 * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 63,
                    PersonalDaysUsedLifetime = 8,
                    SickDaysUsedLifetime = 13,
                    VacationDaysUsedForPeriod = 0,
                    PersonalDaysUsedForPeriod = 1,
                    SickDaysUsedForPeriod = 0
                },
                //14: Reggie Williams, Marketing Executive Director
                new WorkInfo()
                {
                    WorkInfoId = 14,
                    ContactId = 14,
                    PersonnelId = 14,
                    PositionId = 10,
                    Wage = 135000,
                    WorkEmail = "reggie.williams@company.com",
                    HasBenefits = true,
                    StartOfBenefits = new DateTime(2008, 04, 06).AddDays(90),
                    LastReview = DateTime.Now.Subtract(TimeSpan.FromDays(2)),
                    VacationDaysAccruedLifetime = 12 * 12 * vDays,
                    PersonalDaysAccruedLifetime = 12 * 12 * pDays,
                    SickDaysAccruedLifetime = 12 * 12 * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 14,
                    PersonalDaysUsedLifetime = 2,
                    SickDaysUsedLifetime = 0,
                    VacationDaysUsedForPeriod = 14,
                    PersonalDaysUsedForPeriod = 0,
                    SickDaysUsedForPeriod = 0
                },
                //15: Jun Makoto, Marketing Associate
                new WorkInfo()
                {
                    WorkInfoId = 15,
                    ContactId = 15,
                    PersonnelId = 15,
                    PositionId = 13,
                    Wage = 65000,
                    WorkEmail = "jun.makoto@company.com",
                    HasBenefits = true,
                    StartOfBenefits = new DateTime(2019, 01, 02).AddDays(90),
                    LastReview = DateTime.Now.Subtract(TimeSpan.FromDays(2)),
                    VacationDaysAccruedLifetime = 1 * 12 * vDays,
                    PersonalDaysAccruedLifetime = 1 * 12 * pDays,
                    SickDaysAccruedLifetime = 1 * 12 * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 0,
                    PersonalDaysUsedLifetime = 0,
                    SickDaysUsedLifetime = 0,
                    VacationDaysUsedForPeriod = 0,
                    PersonalDaysUsedForPeriod = 0,
                    SickDaysUsedForPeriod = 0
                }
            );
        }
    }
}
