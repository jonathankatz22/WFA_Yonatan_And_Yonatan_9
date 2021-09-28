using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_Yonatan_And_Yonatan_9.BL;

namespace WFA_Yonatan_And_Yonatan_9.BL
{
     public class Client
    {
        private int m_PhoneNumber;
        private int m_firstnum;
        private int m_Id;
        private string m_FirstName;
        private string m_LastName;

        public int PhoneNumber { get => m_PhoneNumber; set => m_PhoneNumber = value; }
        public int Id { get => m_Id; set => m_Id = value; }
        public string FirstName { get => m_FirstName; set => m_FirstName = value; }
        public string LastName { get => m_LastName; set => m_LastName = value; }
        public int firstnum { get => m_firstnum; set => m_firstnum = value; }



    }

}
