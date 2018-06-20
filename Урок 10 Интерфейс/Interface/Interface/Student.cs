using System;                
using System.Collections.Generic;
using System.Linq;           
using System.Text;           
using System.Threading.Tasks;
                             
namespace Interface          
{                            
    class Student:IComparable
    {                        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public StudentCard StudentCard { get; set; }
        public override string ToString()
        {                    
            return $"{LastName}{FirstName}{BirthDate.ToLongDateString()}{StudentCard.Series}{StudentCard.Number}";
        }                    
                             
        public int CompareTo(object obj)
        {                    
            if (obj is Student)
            {                
              return LastName.CompareTo((obj as Student).LastName);
            }                
            throw new NotImplementedException();
                             
        }                    
                             
        //public object Clone() для значимых типов 
        //{                  
        //    return this.MemberwiseClone();
        //}                  
        public object Clone()
        {    
          Student temp=(Student)this.MemberwiseClone();
            temp.StudentCard = new StudentCard
            {
                Series = this.StudentCard.Series,
                Number = this.StudentCard.Number

            };
            return temp;
        }

    }
}
