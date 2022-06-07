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
        public delegate Type OnChangeDelegate();
        public delegate void OnAfterChangeDelegate();
        public event OnChangeDelegate OnChange;
        public event OnAfterChangeDelegate OnAfterChange; 
        private FIO fio;
        private string phoneNum;
        private string pasportNum;
        public DateTime dateTime;
        public string WhatDataIsChange;
        public string TypeDataChange;
        public string WhoIsChange;

        public FIO Fio { get { return fio; } set { Change(fio, value); fio = value; } }
        public string PhoneNum { get { return phoneNum; } set { Change(phoneNum, value); phoneNum = value; } }
        public string PasportNum { get { return pasportNum; } set { Change(pasportNum, value); pasportNum = value; } }

        public Client(FIO name, string phoneNum, string pasportNum)
        {
            this.fio = name;
            this.phoneNum = phoneNum;
            this.pasportNum = pasportNum;
        }
        private void Change(Object od, Object nw)
        {
            WhoIsChange = OnChange().Name;
            WhatDataIsChange = nw.GetType().Name;
            dateTime = DateTime.Now;
            if (od == null) TypeDataChange = "Новая запись";
            else TypeDataChange = "Изменение";
            OnAfterChange();
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
