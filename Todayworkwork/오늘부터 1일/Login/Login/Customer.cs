﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Customer
    {
        private string id;
        private string pw;
        private string name;
        private string addr;
        private string email;
        private string phone;

        public string ID { get { return id; } set { this.id = value; } }
        public string PW { get { return pw; } set { this.pw = value; } }
        public string NAME { get { return pw; } set { this.pw = value; } }
        public string ADDR { get { return pw; } set { this.pw = value; } }
        public string EMAIL { get { return pw; } set { this.pw = value; } }
        public string PHONE { get { return pw; } set { this.pw = value; } }
    }
}
