using System;
using System.Xml.Linq;

//HAJRAH SIDDIQUI

namespace TeamSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTIONS FOR THE CODE

            int studentCount, studentGrade, i; //DECLARING VARIABLE OF STUDENTCOUNT AND GRADE ***SEPERATE BECAUSE THEY ARE NUMBERS***
            string studentName, studentGender; //DECLARING VARIABLE OF STRINGS --- Seperated from the one below to make it organized
            string juniorMale = "", juniorFemale = "", seniorMale = "", seniorFemale = ""; //DECLARING PROCESSED VARIABLES USED QUOTATION MARKS BECAUSE THEY ARE EMPTY STRINGS THAT STORE THE OTHER VARIABLES --- Teams

            Console.Write("ENTER HOW MANY STUDENTS ARE ON THE TEAM : "); //First question of how many students are on the team
            studentCount = int.Parse(Console.ReadLine());
            i = studentCount;  //Made an iteration so that it will be easier to do the while loop and it will help declaring one student
                               //iteration is basically repeating of a proceess

            while (i > 0) //this whole loop is basically tracking 1 student, therefore if you got like two students it would repeat itself
            {
                Console.Write("Please enter student name : "); //this shows on the run box
                studentName = Console.ReadLine(); //It will accept a string as input for the name
                Console.Write("Please enter student gender (female/male) : ");
                studentGender = Console.ReadLine(); //It will now input the gender the user types in the previous question

                while (!(studentGender == "male" || studentGender == "female")) //Showing what will happen if user does not say male or female so I made a loop
                {
                    Console.Write("Please enter female or male for the gender: "); //This code will make it repeat itself again because it will be an error
                    studentGender = Console.ReadLine();
                }

                Console.Write("Please enter student grade : ");
                studentGrade = int.Parse(Console.ReadLine()); //It will now input grade now

                while (!(studentGrade >= 9 && studentGrade <= 12)) //check if grade is not between 9 and 12 --- if not between it will do the same as the previous one
                {
                    Console.Write("Please enter student grade again between 9-12 : "); //It will repeat itself again because it will be an error for the previous word
                    studentGrade = int.Parse(Console.ReadLine());
                }

                //Check if student is junior/senior
                if (studentGrade == 9 || studentGrade == 10) //These numbers symbolize the juniors because it is the grade level
                {
                    if (studentGender == "female")
                    {
                        juniorFemale += studentName + ", "; //Junior team students (the += means how it is adding itself to the team and double quotation explanation below
                    }
                    else
                    {
                        juniorMale += studentName + ", "; //the double quotation marks represent how it will add the other number of students name
                    }
                }
                else //these are for the seniors, since we limited ourselves to only grade 9,10,11,12 if we equaled the student grade to 9,10 else would be 11,12
                {
                    if (studentGender == "female")
                    {
                        seniorFemale += studentName + ", "; //senior team females
                    }
                    else
                    {
                        seniorMale += studentName + ", ";  //Senior male females
                    }
                }
                Console.WriteLine("");

                i = i - 1; //will decrease the amount of students you enter because obviously the students need to less
            }
            Console.WriteLine("The junior males are: " + juniorMale);  //the questions at the end aka. the output
            Console.WriteLine("The junior females are: " + juniorFemale); //The variables are all joining them at the end
            Console.WriteLine("The senior males are: " + seniorMale);
            Console.WriteLine("The senior females are: " + seniorFemale);
            Console.WriteLine("Have a nice day with " + juniorMale + juniorFemale + seniorMale + seniorFemale);
            Console.ReadKey();
        }
    }
}

