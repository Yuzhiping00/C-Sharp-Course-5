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
    * Purpose: This class is used to create Episode objects and those objects will be stored into a list of Episode. 
    *          Thus, it only has properties and a constructor 
    *          
    * I, Zhiping Yu, 000822513 certify that this material is my original work.  No other person's work has been used 
    * without due acknowledgement.
    */
    class Episode
    { 
        // properties of episode objects
        public string StoryId { get; set; } 
        public int Season { get; set; } // season number
        public int SeasonYear { get; set; } // the year of season released
        public string  Title { get; set; } // title of the episode

        /// <summary>
        /// Constuctor    initilize properties
        /// </summary>
        /// <param name="storyId">story's id</param>
        /// <param name="season">season number</param>
        /// <param name="seasonYear">the year of season released</param>
        /// <param name="title">title of the episode</param>
        public Episode(string storyId, int season, int seasonYear, string title)
        {
            StoryId = storyId;
            Season = season;
            SeasonYear = seasonYear;
            Title = title;
        }



    }
}
