using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace HW11_6
{
    internal class Client
    {
        private FIO fio;
        private string phoneNum;
        private string pasportNum;
        public DateTime dateTime;
        public string WhatDataIsChange;
        public string TypeDataChange;
        public string WhoIsChange;

        public FIO Fio { get { return fio; } set { fio = value; } }
        public string PhoneNum { get { return phoneNum; } set { phoneNum = value; } }
        public string PasportNum { get { return pasportNum; } set { pasportNum = value; } }

        public Client(FIO name, string phoneNum, string pasportNum)
        {
            this.fio = name;
            this.phoneNum = phoneNum;
            this.pasportNum = pasportNum;
        }
        public Client()
        {

        }
       
     }


    internal struct FIO
    {   /// <summary>
        /// Имя
        /// </summary>
        public string FirstName;
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName;
        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName;
        public override string ToString()
        {
            return $"Имя: {FirstName}, Фамилия: {LastName}, Отчество: {MiddleName}";
        }
    }
}
