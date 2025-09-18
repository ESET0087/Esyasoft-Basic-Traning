namespace DS_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List Example
            Console.WriteLine("List demo");
            List<Student> students = new List<Student>();
            Student first = new Student(1, "Alice", 10);
            Student second = new Student(2, "Bob", 90);
            Student third = new Student(3, "Charlie", 78);
            students.Add(first);
            students.Add(second);
            students.Add(third);

            Console.WriteLine("Student List:");
            foreach (Student s in students)
            {
                Console.WriteLine($"ID: {s.id}, Name: {s.name}, Marks: {s.marks}");
            }

            // Access a specific object by index
            Console.WriteLine($"\nSecond student is: {students[1].name}");


            //Dictionay Example
            Console.WriteLine("\nDictionary demo");
            Dictionary<string, Student> students_dict = new Dictionary<string, Student>();
            students_dict.Add("firstStudent", first);
            students_dict.Add("seondStudent", second);
            students_dict.Add("thirdStudent", third);

            foreach (KeyValuePair<string, Student> student in students_dict)
            {
                Console.WriteLine($"Key: {student.Key}, Name: {student.Value.name}");
            }


            //Hashset Example
            Console.WriteLine("\nHashset demo");
            HashSet<Student> students_hashset = new HashSet<Student>();
            students_hashset.Add(first);
            students_hashset.Add(second);
            students_hashset.Add(first);
            students_hashset.Add(third);

            foreach (Student student in students_hashset)
            {
                Console.WriteLine(student.id);
            }


            //StackDemo
            Console.WriteLine("\nStack demo");
            Stack<Student> students_stack = new Stack<Student>();
            students_stack.Push(first);
            students_stack.Push(second);
            students_stack.Push(third);

            Student pop_stack = students_stack.Pop();
            Console.WriteLine(pop_stack.name);


            //Queue demo
            Console.WriteLine("\nQueue demo");
            Queue<Student> students_queue = new Queue<Student>();
            students_queue.Enqueue(first);
            students_queue.Enqueue(second);
            students_queue.Enqueue(third);

            Console.WriteLine(students_queue.Dequeue().name);


            // Linked List demo
            Console.WriteLine("\nLinkedList demo");
            LinkedList<Student> students_list = new LinkedList<Student>();
            students_list.AddFirst(first);
            students_list.AddLast(second);
            students_list.AddLast(third);

            foreach (var student in students_list)
            {
                Console.WriteLine(student.name);
            }

            // Tuple demo
            Console.WriteLine("\nTuple demo");
            (int id, string name, int marks) person = (first.id, first.name, first.marks);
            Console.WriteLine($"Name: {person.name}");  
            Console.WriteLine($"Marks: {person.marks}");

            // List of Dictionary
            Console.WriteLine("\nList of Dictionaries demo");
            List<Dictionary<string, Student>> list_of_dict = new List<Dictionary<string, Student>>();
            list_of_dict.Add(students_dict);

            foreach (var dict in list_of_dict)
            {
                foreach (var entry in dict)
                {
                    Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value.name}");
                }
            }
        }
    }
}