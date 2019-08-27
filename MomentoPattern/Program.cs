using System;

namespace MomentoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            Console.WriteLine($"Initial student status {student.Status}");
            try
            {
                student.StartAdmissionProcess();
                Console.WriteLine($"Student status after proucessing {student.Status}");
                throw new Exception();
            }
            catch (Exception)
            {
                student.Revert();
            }

            Console.WriteLine($"Student status after failure {student.Status}");
            Console.ReadKey();
        }
    }
}
