﻿using JobPortalApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalApplication.Interface
{
    internal interface IInterviewProvider
    {
        void ScheduleInterview(Interview interview);
        Interview[]GetInterviews();
    }
}
