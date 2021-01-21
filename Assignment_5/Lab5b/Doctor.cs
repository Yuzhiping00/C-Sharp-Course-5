using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5b
{
   /**
    * Name: Zhiping Yu   student number: 000822513
    * File date: 2020.12.09
    * Purpose: This class is used to create Doctor objects and those objects will be stored into a list of Doctor. 
    *          Thus, it only has properties and a constructor 
    *          
    * I, Zhiping Yu, 000822513 certify that this material is my original work.  No other person's work has been used 
    * without due acknowledgement.
    */
    class Doctor
    {
        // properties of Doctor objects
        public int DoctorId { get; set; } // doctor's unique id
        public string Actor{ get; set; } // who plays the Doctor
        public int Series { get; set; } // the number of series
        public int Age { get; set; } // actor's age
        public string Debut { get; set; } // debut name
        public byte[] Picture { get; set; }  // the Doctor's picture

        /// <summary>
        /// Constructor  initialize doctor's properties
        /// </summary>
        /// <param name="doctorId">doctor's id</param>
        /// <param name="actor">the person who plays the doctor role</param>
        /// <param name="series">the number of series</param>
        /// <param name="age">the actor's age when they first plays the doctor's role</param>
        /// <param name="debut">the name of debut</param>
        /// <param name="picture">the doctor's picture</param>
        public Doctor(int doctorId, string actor , int series, int age, string debut, byte[] picture)
        {
            DoctorId = doctorId;
            Actor = actor;
            Series = series;
            Age = age;
            Debut = debut;
            Picture=  picture;
        }


    }
}
