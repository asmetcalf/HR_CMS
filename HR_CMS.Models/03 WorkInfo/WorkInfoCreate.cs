﻿using HR_CMS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace HR_CMS.Models
{
    public class WorkInfoCreate
    {
        [Required]
        public int? PersonnelId { get; set; }
        public virtual Personnel Personnel { get; set; }
        [Required]
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }
        [Required]
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }
        [Required]
        public decimal Wage { get; set; }
        //generated by method, not required by user input
        public bool HasBenefits 
        {
            get
            {
                if ((DateTimeOffset.Now - StartOfBenefits).Value.TotalDays >= 90)
                {
                    return true;
                }
                return false;
            }
        }
        public DateTimeOffset? StartOfBenefits { get; set; }
        [Required]
        public string WorkEmail { get; set; }
        public DateTimeOffset? LastReview { get; set; }
        public DateTimeOffset? NextReview
        {
            get
            {
                if (LastReview.Equals(null))
                {
                    return DateTime.Now.AddDays(30);
                }
                else
                {
                    return LastReview.Value.Date.AddDays(90);
                }
            }
        }
        public double VacationDaysAccruedLifetime { get; set; }
        public double VacationDaysUsedLifetime { get; set; }
        public double VacationDaysAccruedForPeriod { get; set; }
        public double VacationDaysUsedForPeriod { get; set; }
        public double PersonalDaysAccruedLifetime { get; set; }
        public double PersonalDaysUsedLifetime { get; set; }
        public double PersonalDaysAccruedForPeriod { get; set; }
        public double PersonalDaysUsedForPeriod { get; set; }
        public double SickDaysAccruedLifetime { get; set; }
        public double SickDaysUsedLifetime { get; set; }
        public double SickDaysAccruedForPeriod { get; set; }
        public double SickDaysUsedForPeriod { get; set; }
    }
}
