﻿using HR_CMS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Models
{
    public class WorkInfoCreate
    {
        [Required]
        public int? PersonnelId { get; set; }
        [Required]
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }
        [Required]
        public decimal Wage { get; set; }
        //generated by method, not required by user input
        public bool HasBenefits
        {
            get
            {
                if ((DateTime.Now - StartOfBenefits).TotalSeconds >= 0)
                {
                    return true;
                }
                return false;
            }
        }
        public DateTimeOffset StartOfBenefits
        {
            get
            {
                Personnel pers = new Personnel();
                DateTimeOffset result = pers.DOH.AddDays(90);
                return result;
            }
        }
        [Required]
        public string WorkEmail { get; set; }
        [Required] //required bc right now it is not a method, service will likely input 0
        public DateTimeOffset LastReview { get; set; }
        // generated by method, not required by user input
        public DateTimeOffset NextReview
        {
            get
            {
                DateTimeOffset result = LastReview.AddDays(90);
                return result;
            }
        }
        public double VacationDaysAccruedLifetime
        {
            get
            {

                int vacationVariable = 30;
                double totalDaysSinceBenefitStart = (DateTimeOffset.Now - StartOfBenefits).TotalDays;
                double accrued = totalDaysSinceBenefitStart / vacationVariable;
                return accrued;
            }
        }
        /*public double VacationDaysUsedLifetime
        {
            get
            {
                TimeSpan newVacationSubmission = TimeSpan.FromDays(5);
                double total = VacationDaysUsedLifetime + Convert.ToDouble(newVacationSubmission);
                return total;
            }
        }*/
        public double VacationDaysAccruedForPeriod
        {
            get
            {
                int vacationVariable = 30;
                DateTime startOfPeriod = new DateTime(2020, 1, 1);
                double totalDaysSincePeriodStart = (DateTimeOffset.Now - startOfPeriod).TotalDays;
                double accrued = totalDaysSincePeriodStart / vacationVariable;
                return accrued;
            }
        }
       /* public double VacationDaysUsedForPeriod
        {
            get
            {
                int newVacationSubmission = 5;
                double total = VacationDaysUsedForPeriod + newVacationSubmission;
                return total;
            }
        }*/
        public double PersonalDaysAccruedLifetime
        {
            get
            {

                int personalVariable = 30;
                double totalDaysSinceBenefitStart = (DateTimeOffset.Now - StartOfBenefits).TotalDays;
                double accrued = totalDaysSinceBenefitStart / personalVariable;
                return accrued;
            }
        }
        /*public double PersonalDaysUsedLifetime
        {
            get
            {
                int newPersonalSubmission = 1;
                double total = PersonalDaysUsedLifetime + newPersonalSubmission;
                return total;
            }
        }*/
        public double PersonalDaysAccruedForPeriod
        {
            get
            {
                int personalVariable = 30;
                DateTimeOffset startOfPeriod = new DateTime(2020, 1, 1);
                double totalDaysSincePeriodStart = (DateTimeOffset.Now - startOfPeriod).TotalDays;
                double accrued = totalDaysSincePeriodStart / personalVariable;
                return accrued;
            }
        }
        /*public double PersonalDaysUsedForPeriod
        {
            get
            {
                int newPersonalSubmission = 5;
                double total = PersonalDaysUsedForPeriod + newPersonalSubmission;
                return total;
            }
        }*/
        public double SickDaysAccruedLifetime
        {
            get
            {

                int diseaseVariable = 30;
                double totalDaysSinceBenefitStart = (DateTimeOffset.Now - StartOfBenefits).TotalDays;
                double accrued = totalDaysSinceBenefitStart / diseaseVariable;
                return accrued;
            }
        }
        /*public double SickDaysUsedLifetime
        {
            get
            {
                int newDiseaseSubmission = 1;
                double total = SickDaysUsedLifetime + newDiseaseSubmission;
                return total;
            }
        }*/
        public double SickDaysAccruedForPeriod
        {
            get
            {
                int diseaseVariable = 30;
                DateTimeOffset startOfPeriod = new DateTime(2020, 1, 1);
                double totalDaysSincePeriodStart = (DateTimeOffset.Now - startOfPeriod).TotalDays;
                double accrued = totalDaysSincePeriodStart / diseaseVariable;
                return accrued;
            }
        }
        /*public double SickDaysUsedForPeriod
        {
            get
            {
                int newDiseaseSubmission = 5;
                double total = SickDaysUsedForPeriod + newDiseaseSubmission;
                return total;
            }
        }*/
    }
}
