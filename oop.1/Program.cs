using System;

namespace oop._1
{
    class Program
    {
        public static void Main()
        {
            Person mPerson = new Person();
            mPerson.Gteet();

            Students mStudents = new Students();
            mStudents.SetAge(18);
            mStudents.Gteet();
            mStudents.ShowAge();
            mStudents.study();

            Teacher mTeacher = new Teacher();
            mTeacher.SetAge(25);
            mTeacher.Gteet();
            mTeacher.Explain();


        }
    }
}