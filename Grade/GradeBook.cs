using System;
using System.Collections.Generic;

namespace Grades
{
   public class GradeBook
    {
       public event NameChangeDelegate NameChange;
       private List<float> currentGrades;
       private string _name;
       public string Name
       {
           get{

               return _name;
           }
           set{
               
               if (!String.IsNullOrEmpty(value))
               {
                    if(_name != value)
                    {

                      NameChangedEventArgs args = new NameChangedEventArgs();  
                      args.CurrentName = _name;
                      args.NewName = value;
                      NameChange(this, args);

                    }
                    _name = value;
               }

               }
       }
        public GradeBook()
        {
            currentGrades = new List<float>();
            _name = "empty";
        }
        public void AddGrade (float grade)
        {
            currentGrades.Add(grade);
        }

        public Statistics ComputeStatistics()
        {
          Statistics stats = new Statistics();
          if (currentGrades.Count != 0)
          {
              stats.setActiveStats(true);
          float highestGrade = 0f;
          float lowestGrade =100f;
          float averGrade = 0f;
          float gradeTotal = 0f;

          for(int i = 0; i<currentGrades.Count;i++)
          {
              
                  highestGrade = Math.Max(currentGrades[i], highestGrade);
             
              if (currentGrades[i] < lowestGrade)
              {
                  lowestGrade = Math.Min(currentGrades[i], lowestGrade);
              }
              gradeTotal += currentGrades[i];
          }
            
        averGrade = gradeTotal/currentGrades.Count;
        stats.SetHighestGrade(highestGrade);
        stats.SetLowestGrade(lowestGrade);
        stats.SetAverGrade(averGrade);
        
          return stats;
        }
        else
        {
            return stats; 
        }
        }
    }
}