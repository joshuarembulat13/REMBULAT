using System;

namespace RembulatITELEC1C

{
    public class DataService : DataInterfaceService

    {

        public List<Student> StudentsList { get; }

        public List<Instructor> instructorsList { get; }

        public DataService()
        {
            StudentsList = new List<Student>() {
                    new Student() {
                        studentID= 1,
                        studentName= "Joshua Rembulat",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "joshua.rembulat.cics@ust.edu.ph"
                    },

                    new Student() {
                        studentID= 2,
                        studentName= "EJ Monteclaro",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "elpidio.monteclaro.cics@ust.edu.ph"
                    },

                    new Student() {
                        studentID= 3,
                        studentName= "Leannard Ramos",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "lennard.ramos.cics@ust.edu.ph"
                    },
                    new Student() {
                        studentID= 4,
                        studentName= "Phoebe Ngitngit",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "alexisphoebe.ngitngi.cics@ust.edu.ph"
                    },
                    new Student() {
                        studentID= 4,
                        studentName= "Jasper Noel Llave",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "jaspernodel.llave.cics@ust.edu.ph"
                    },
                    new Student() {
                        studentID= 5,
                        studentName= "Jean Stefanie Khaldyn Abarquez",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "jeanstafanie.abarquez.cics@ust.edu.ph"
                    },
                     new Student() {
                        studentID= 6,
                        studentName= "Azzilhea Angel Samson",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "azzilheaangel.samson.cics@ust.edu.ph"
                    },
                    new Student() {
                        studentID= 7,
                        studentName= "Antonio Criscencio Arrieta",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "antoniocriscencio.arrieta.cics@ust.edu.ph"
                    },
                     new Student() {
                        studentID= 8,
                        studentName= "Micko Tee",
                        studentCourse = Course.BSIT,
                        DateEndrolled = DateTime.Now,
                        studentEmail = "micko.tee.cics@ust.edu.ph"
                    },

                };


            instructorsList = new List<Instructor>() {
                    new Instructor(){
                        id = 1,
                        firstName=  "Ronina",
                        lastName= "Tayuan",
                        isTenured =true,
                        instructorDateHired = DateTime.Now,
                        instructorRank = Hello.AssistantProfessor,
                      },
                    new Instructor(){
                        id = 2,
                        firstName = "Maricel",
                        lastName = "Balais",
                        isTenured = false,
                        instructorDateHired = DateTime.Now,
                        instructorRank = Hello.AssociateProfessor
                      },
                        new Instructor(){
                        id = 3,
                        firstName ="Jerralyn",
                        lastName ="Padua",
                        isTenured = true,
                        instructorDateHired = DateTime.Now,
                        instructorRank = Hello.AssociateProfessor
                      },

                };
        }


    }
}