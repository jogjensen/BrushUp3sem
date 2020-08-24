using System;

namespace Brushup3sem
{

    #region Enum
    public enum Gender
    {
        Male, Female
    }
    #endregion

    public class Student
    {
        #region Instance fields

        private string _name;
        private string _address;
        private int _sem;
      

        #endregion



        #region Properties

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (value == null) throw new ArgumentException("Name","Name is not filled");
                if (value.Length <2) throw new ArgumentException("Name must be longer than 2 symbols");
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
                if (value==null) throw new ArgumentException("Address", "Address is not filled");
                
            }

        }

        public int Sem
        {
            get { return _sem;}
            set
            {
                if (value <= 1 && value <= 8) _sem = value;
                else throw new ArgumentOutOfRangeException("Semester",value,"Semester must be between 1 & 8");
            }
        }

        private Gender Gender { get; set; }
        #endregion

        #region Constructor

        public Student(Gender gender, string name,string address,int sem)
        {
            Gender = gender;
            Name = name;
            Address = address;
            Sem = sem;
        }

        #endregion

    }


}


