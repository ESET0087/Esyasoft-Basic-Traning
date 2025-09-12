namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Total no of subjects : ");
            int no_of_subjects, sum = 0, avg = 0, failed = 0;

            // number of subjects to input (5 accouding to out problem)
            no_of_subjects = Convert.ToInt32(Console.ReadLine());

            int[] marks_of_sub = new int[no_of_subjects];

            // input marks in subjects
            for (int i = 0; i < no_of_subjects; i++)
            {
                Console.Write($"Marks of subject {i + 1}: ");
                marks_of_sub[i] = Convert.ToInt32(Console.ReadLine());
                sum += marks_of_sub[i];
                if (marks_of_sub[i] < 33) failed++;
            }

            // finding average
            avg = sum / no_of_subjects;

            Console.WriteLine($"Avg marks obtained by the Student : {avg}");

            // if else loop for assigning grade and marking number of failed subjects
            if (avg > 90) { 
                Console.WriteLine("Grade A");
                if(failed > 0) Console.WriteLine($"Failed in {failed} subjects");
                else Console.WriteLine("All subject passed.");
            }
            else if (avg > 80) {
                Console.WriteLine("Grade B");
                if (failed > 0) Console.WriteLine($"Failed in {failed} subjects");
                else Console.WriteLine("All subject passed.");
            }
            else if (avg > 60) {
                Console.WriteLine("Grade C");
                if (failed > 0) Console.WriteLine($"Failed in {failed} subjects");
                else Console.WriteLine("All subject passed.");
            }
            else if (avg > 50) {
                Console.WriteLine("Grade D");
                if (failed > 0) Console.WriteLine($"Failed in {failed} subjects");
                else Console.WriteLine("All subject passed.");
            }
            else if (avg > 30) {
                Console.WriteLine("Grade E");
                if (failed > 0) Console.WriteLine($"Failed in {failed} subjects");
                else Console.WriteLine("All subject passed.");
            }
            else {
                Console.WriteLine("Failed.");
            }
        }
    }
}
