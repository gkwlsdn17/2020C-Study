using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Individual.Resume_menu3
{

    class InsertResume
    {
           
        private string resumeSubject;
        private string resumeLocation;
        private string resumeExp;
        private string resumeLicense;
        private string resumeContent;

        public string resume_Subject { get { return resumeSubject; } set { resumeSubject = value; } }
        public string resume_Location { get { return resumeLocation; } set { resumeLocation = value; } }
        public string resume_Exp { get { return resumeExp; } set { resumeExp = value; } }
        public string resume_License { get { return resumeLicense; } set { resumeLicense = value; } }
        public string resume_Content { get { return resumeContent; } set { resumeContent = value; } }
   
    }

}
