using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BC_English.Models
{
    public class CourseData : IComparable
    {
        public string Title { get; set; }
        public string Subject { get; set; }
        public string CourseNumber { get; set; }
        public string CourseId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public int Credits { get; set; }
        public Boolean IsVariableCredits { get; set; }
        public Boolean IsCommonCourse { get; set; }

        //This is needed to sort the Json list alphabetically.
        public int CompareTo(object obj)
        {
            CourseData obj_1 = obj as CourseData;
            if (obj_1 == null)
            {
                return -1;
            }

            return string.Compare(this.Title, obj_1.Title);
        }
    }

}
