﻿using HR_CMS.Data;
using HR_CMS.Models;
using HR_CMS.Models._03_WorkInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Services
{
    public class WorkInfoService
    {
        public bool CreateWorkInfo(WorkInfoCreate model)
        {
            var entity = new WorkInfo()
            {
                PersonnelId = model.PersonnelId,
                PositionId = model.PositionId,
                ContactId = model.ContactId,
                Wage = model.Wage,
                HasBenefits = model.HasBenefits,
                StartOfBenefits = model.StartOfBenefits,
                WorkEmail = model.WorkEmail,
                LastReview = model.LastReview,
                NextReview = model.NextReview,
                PositionHeld = model.Position,
                Contact = model.Contact,
                VacationDaysAccruedLifetime = model.VacationDaysAccruedLifetime,
                VacationDaysUsedLifetime = model.VacationDaysUsedLifetime,
                VacationDaysAccruedForPeriod = model.VacationDaysAccruedForPeriod,
                VacationDaysUsedForPeriod = model.VacationDaysUsedForPeriod,
                PersonalDaysAccruedLifetime = model.PersonalDaysAccruedLifetime,
                PersonalDaysUsedLifetime = model.PersonalDaysUsedLifetime,
                PersonalDaysAccruedForPeriod = model.PersonalDaysAccruedForPeriod,
                PersonalDaysUsedForPeriod = model.PersonalDaysUsedForPeriod,
                SickDaysAccruedLifetime = model.SickDaysAccruedLifetime,
                SickDaysUsedLifetime = model.SickDaysUsedLifetime,
                SickDaysAccruedForPeriod = model.SickDaysAccruedForPeriod,
                SickDaysUsedForPeriod = model.SickDaysUsedForPeriod
                
               
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.WorkInfoDbSet.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public bool EditWorkInfo(WorkInfoEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.WorkInfoDbSet.Single(e => e.PersonnelId == model.PersonnelId);
                entity.PositionId = model.PositionId;
                entity.Wage = model.Wage;
                entity.WorkEmail = model.WorkEmail;
                entity.LastReview = model.LastReview;

                return ctx.SaveChanges() == 1;
            }
        }

        public WorkInfoDetail GetWorkInfoById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.WorkInfoDbSet.Single(e => e.PersonnelId == id);
                return new WorkInfoDetail
                {
                    PersonnelId = entity.PersonnelId,
                    WorkInfoId = entity.WorkInfoId,
                    PositionId = entity.PositionId,
                    ContactId = entity.ContactId,
                    Wage = entity.Wage,
                    HasBenefits = entity.HasBenefits,
                    StartOfBenefits = entity.StartOfBenefits,
                    WorkEmail = entity.WorkEmail,
                   VacationDaysAccruedLifetime = entity.VacationDaysAccruedLifetime,
                    VacationDaysUsedLifetime = entity.VacationDaysUsedLifetime,
                    VacationDaysAccruedForPeriod = entity.VacationDaysAccruedForPeriod,
                    VacationDaysUsedForPeriod = entity.VacationDaysUsedForPeriod,
                    PersonalDaysAccruedLifetime = entity.PersonalDaysAccruedLifetime,
                    PersonalDaysUsedLifetime = entity.PersonalDaysUsedLifetime,
                    PersonalDaysAccruedForPeriod = entity.PersonalDaysAccruedForPeriod,
                    PersonalDaysUsedForPeriod = entity.PersonalDaysUsedForPeriod,
                    SickDaysAccruedLifetime = entity.SickDaysAccruedLifetime,
                    SickDaysUsedLifetime = entity.SickDaysUsedLifetime,
                    SickDaysAccruedForPeriod = entity.SickDaysAccruedForPeriod,
                    SickDaysUsedForPeriod = entity.SickDaysUsedForPeriod
                };
            }
        }
        public WorkInfoDeptName GetDeptByPersonnelId(int id)
                {
                    using (var ctx = new ApplicationDbContext())
                    {
                        var entity = ctx.WorkInfoDbSet.Single(e => e.PersonnelId == id );
                return new WorkInfoDeptName
                {
                    DeptName = entity.PositionHeld.Department.DeptName
                };
                    }
                }
        public WorkInfoPositionName GetPositionByPersonnelId(int id)
        {
            {
                using (var ctx = new ApplicationDbContext())
                {
                    var entity = ctx.WorkInfoDbSet.Single(e => e.PersonnelId == id);
                    return new WorkInfoPositionName
                    {
                        PositionTitle = entity.PositionHeld.PositionTitle,
                        IsSupervisor = entity.PositionHeld.IsSupervisor,
                        IsDirector = entity.PositionHeld.IsDirector,
                        IsExecutive = entity.PositionHeld.IsDirector
                    };
                }
            }
        }

        //Stretch Goal
/*
        public WorkInfoDetail GetSupervisorByPersonnelId(int id)
        {
                using (var ctx = new ApplicationDbContext())
                {
                    var entity = ctx.WorkInfoDbSet.Where(e => e.PositionHeld.DeptId != 0).Single(e => e.PersonnelId == id);
                    return new WorkInfoDetail
                    {
                        PositionTitle = entity.PositionHeld.PositionTitle,
                        
                    };
                }
        }
        
        public WorkInfoDetail GetDirectorByPersonnelId(int id)
        {

        }
*/
        public IEnumerable<WorkInfoListItem> GetPersonnelByDeptId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.WorkInfoDbSet.Where(e => e.PositionHeld.DeptId == id)
                    .Select(e => new WorkInfoListItem
                    {
                        FirstName= e.Personnel.FirstName,
                        LastName = e.Personnel.LastName,
                        PositionTitle = e.PositionHeld.PositionTitle
                    }
                    );

                return query.ToArray();
            }
        }
        public IEnumerable<WorkInfoListItem> GetAllSupervisorsByDept(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.WorkInfoDbSet.Where(e => e.PositionHeld.IsSupervisor == true && e.PositionHeld.DeptId == id)
                    .Select(e => new WorkInfoListItem
                    {
                        WorkInfoId = e.WorkInfoId,
                        PositionId = e.PositionId,
                        ContactId = e.ContactId,
                        PersonnelId = e.PersonnelId,
                        FirstName = e.Personnel.FirstName,
                        LastName = e.Personnel.LastName,
                        PositionTitle = e.PositionHeld.PositionTitle,
                        DeptName = e.PositionHeld.Department.DeptName,
                        Wage = e.Wage,
                        WorkEmail = e.WorkEmail,
                    }
                    );
                return query.ToArray();
            }
        }

        // START OF GET ALL
        public IEnumerable<WorkInfoListItem> GetWorkInfo()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.WorkInfoDbSet.Select(e => new WorkInfoListItem
                {
                    PersonnelId = e.PersonnelId,
                    WorkInfoId = e.WorkInfoId,
                    PositionId = e.PositionId,
                    ContactId = e.ContactId,
                    Wage = e.Wage,
                    //StartOfBenefits = e.StartOfBenefits,
                    WorkEmail = e.WorkEmail,
                    //LINE BREAK - REMOVE PROPERTIES BELOW IF IMPLEMENTING STRETCH GOALS
                    FirstName = e.Personnel.FirstName,
                    LastName = e.Personnel.LastName,
                    PositionTitle = e.PositionHeld.PositionTitle,
                    DeptName = e.PositionHeld.Department.DeptName,
                }
                    );

                return query.ToArray();
            }
        }
/*        STRETCH GOALS FOR GET ALL METHODS - REQUIRES ROUTING TO IMPLEMENT AS SEPARATE ENDPOINTS - PLACEHOLDER CODE
 *        
 *        public IEnumerable<WorkInfoListItem> GetWorkInfoByActive()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.WorkInfoDbSet.Where(e => e.Personnel.IsActive == true)
                    .Select(e => new WorkInfoListItem
                {
                    WorkInfoId = e.WorkInfoId,
                    PositionId = e.PositionId,
                    ContactId = e.ContactId,
                    Wage = e.Wage,
                    StartOfBenefits = e.StartOfBenefits,
                    WorkEmail = e.WorkEmail,
                }
                    );

                return query.ToArray();
            }
        }
        public IEnumerable<WorkInfoListItem> GetWorkInfoByInactive()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.WorkInfoDbSet.Where(e => e.Personnel.IsActive == false)
                    .Select(e => new WorkInfoListItem
                    {
                        WorkInfoId = e.WorkInfoId,
                        PositionId = e.PositionId,
                        ContactId = e.ContactId,
                        Wage = e.Wage,
                        StartOfBenefits = e.StartOfBenefits,
                        WorkEmail = e.WorkEmail,
                    }
                    );

                return query.ToArray();
            }
        }
        public IEnumerable<WorkInfoListItem> GetAllDirectors()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.WorkInfoDbSet.Where(e => e.PositionHeld.IsDirector == true)
                    .Select(e => new WorkInfoListItem
                    {
                        WorkInfoId = e.WorkInfoId,
                        PositionId = e.PositionId,
                        ContactId = e.ContactId,
                        PersonnelId = e.PersonnelId,
                        FirstName = e.Personnel.FirstName,
                        LastName = e.Personnel.LastName,
                        PositionTitle = e.PositionHeld.PositionTitle,
                        DeptName = e.PositionHeld.Department.DeptName,
                        Wage = e.Wage,
                        WorkEmail = e.WorkEmail,
                    }
                    );
                return query.ToArray();
            }
        }
        public IEnumerable<WorkInfoListItem> GetAllSupervisors()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.WorkInfoDbSet.Where(e => e.PositionHeld.IsSupervisor == true)
                    .Select(e => new WorkInfoListItem
                    {
                        WorkInfoId = e.WorkInfoId,
                        PositionId = e.PositionId,
                        ContactId = e.ContactId,
                        PersonnelId = e.PersonnelId,
                        FirstName = e.Personnel.FirstName,
                        LastName = e.Personnel.LastName,
                        PositionTitle = e.PositionHeld.PositionTitle,
                        DeptName = e.PositionHeld.Department.DeptName,
                        Wage = e.Wage,
                        WorkEmail = e.WorkEmail,
                    }
                    );
                return query.ToArray();
            }
        }*/

    }
}
