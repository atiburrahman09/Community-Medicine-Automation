﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CommunityMedicineAutomation.DAL;
using CommunityMedicineAutomation.Model;

namespace CommunityMedicineAutomation.BLL
{
    public class DoctorManager
    {
        DoctorGateway doctorGateway = new DoctorGateway();
        public string SaveDoctor(Doctor aDoctor, int centerId)
        {
            int value = doctorGateway.SaveDoctor(aDoctor, centerId); ;

            if (value > 0)
            {
                return "Doctor Has Been Saved";
            }
            else return "Failed";
        }
        public List<Doctor> GetAllDoctors(int centerId)
        {
            return doctorGateway.GetAllDoctors(centerId);
        }
        public string GetDoctorName(int doctorId)
        {
            return doctorGateway.GetDoctorName(doctorId);
        }

        public bool IsDoctorExists(Doctor aDoctor)
        {
            return doctorGateway.IsDoctorExists(aDoctor);
        }
    }
}