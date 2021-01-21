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
   * Purpose: This class is used to create Companion objects and those objects will be stored into a list of Companion. 
   *          Thus, it only has properties and a constructor 
   *          
   * I, Zhiping Yu, 000822513 certify that this material is my original work.  No other person's work has been used 
   * without due acknowledgement.
   */
    class Companion
    {
        // properties of a Companion ohjects
        public string Name { get; set; }
        public string Actor{ get; set; }
        public int DoctorId { get; set; }
        public string StoryId { get; set; }
        /// <summary>
        ///  Constructor   initialize properties
        /// </summary>
        /// <param name="name">companion's name</param>
        /// <param name="actor">companion's actor</param>
        /// <param name="doctorId">doctor's id</param>
        /// <param name="storyId">story id</param>
        public Companion(string name, string actor, int doctorId, string storyId)
        {
            Name = name;
            Actor = actor;
            DoctorId = doctorId;
            StoryId = storyId;

        }
    }
}
