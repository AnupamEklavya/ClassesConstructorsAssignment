using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassesConstructorsAssignment
{
    internal class Instructor
    {
        public string InstructorName { get; set; }
        public string[] InstructorSkill { get; set; }
        public int Experience { get; set; }
        public float AvgFeedback { get; set; }

        public Instructor(string instructorname,string[] instructorskill,int experience,float avgfeedback)
        {
            InstructorName = instructorname;
            InstructorSkill = instructorskill;
            Experience = experience;
            AvgFeedback = avgfeedback;
        }
        public  bool ValidateEligiblity() {
            //eligiblity check
            if((Experience>3 && AvgFeedback < 4.5)||(Experience<=3 && AvgFeedback<4)) {
                return false;
            }else
                return true;
        }
        public bool CheckSkill(string technology)
        {
           //searching the technology given by the user
           if(!Array.Exists(InstructorSkill,element =>element.Equals(technology)))
            {
                return false;
            }
            if (!ValidateEligiblity())
            {
                return false;
            }else
                return true;
        }
        public void Details()
        {
            Console.WriteLine("Name :" + InstructorName);
            Console.WriteLine("Experience :" + Experience+" years");
            Console.WriteLine("Rating :" + AvgFeedback+" stars");
            Console.WriteLine("Skills :");
            for(int i=0;i<InstructorSkill.Length;i++)
            {
                Console.WriteLine(InstructorSkill[i]);
            }
        }
    }
}
