using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SMS.Model;
using System.Data;

namespace SMS.IDAL
{
    public interface ITeachersDetailInfo
    {
        void TeachersPersonalInfo_Insert(PersonalData objPersonalData);
        void AcademicsData_Insert(Academic_Data objAcademics);
        void AcademicsData_Update(Academic_Data objAcademics);
        void Promotions_Insert(Promotions objPromo, string Promotype);
        void Promotions_Update(Promotions objPromo, string Promotype);
        void Transfers_Insert(Transfers objTrans);
        void Transfers_Update(Transfers objTrans);
        void AccountInfo_Insert(AccountInfos objAcctInfo);
        void AccountInfo_Update(AccountInfos objAcctInfo);
        void Experiences_Insert(Experiences objExper);
        void Experiences_Update(Experiences objExper);
        DataTable PersonalData_GetAll();
        DataTable PersonalData_GetByAllByS_Id(int schoolid);
        DataTable PersonalData_GetAllByNIC(long NIC);
        DataTable PersonalData_GetAllByD_Id(int D_Id); 

    }
}
