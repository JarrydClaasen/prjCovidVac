using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCovidVac
{
    class Info
    {
        //special Student Vars
        private static int iSizeArray = 0;
        private static int iCounter = 0;

        private static String strHospital_Name;
        private static String strAddress;
        private static bool bType;
        private static char cProvince;

        public static string StrHospital_Name { get => strHospital_Name; set => strHospital_Name = value; }
        public static string StrAddress { get => StrAddress; set => StrAddress = value; }
        public static bool BType { get => bType; set => bType = value; }
        public static char CProvince { get => cProvince; set => cProvince = value; }

        private static String[] ID_Number;
        private static String[] MedicalAid;
        private static String[] Name;
        private static String[] Surname;
        private static String[] RefDr;
        private static Char[] BloodType;
        private static String[] Allergies;
        private static Boolean[] CovidPositive;
        private static String[] Vaccine;

        public void setArray(int num)
        {
            ID_Number = new String[num];
            MedicalAid = new String[num];
            Name = new String[num];
            Surname = new String[num];
            RefDr = new String[num];
            BloodType = new Char[num];
            Allergies = new String[num];
            CovidPositive = new Boolean[num];
            Vaccine = new String[num];

            iSizeArray = num;

        }

        public void addPerson(String strID, String strMedic, String strName,
            String strSuranme, String strRefDr, Char cBloodType,
            String strAllergies, Boolean bCovid, String strVac)
        {

            ID_Number[iCounter] = strID;
            MedicalAid[iCounter] = strMedic;
            Name[iCounter] = strName;
            Surname[iCounter] = strSuranme;
            RefDr[iCounter] = strRefDr;
            BloodType[iCounter] = cBloodType;
            Allergies[iCounter] = strAllergies;
            CovidPositive[iCounter] = bCovid;
            Vaccine[iCounter] = strVac;

            iCounter++;
        }
    }
}
