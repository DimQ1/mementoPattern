using System;
using System.Collections.Generic;
using System.Text;

namespace MomentoPattern
{
    public class Student
    {
        public string Status { get; set; }
        private Memento memento;

        public Student()
        {
            this.Status = "Pending Approval";
            this.memento = new Memento(this.Status);
        }

        public void StartAdmissionProcess()
        {
            this.Status = "Admitted";
        }

        public void Revert()
        {
            this.Status = this.memento.status;
        }
    }

    class Memento
    {
        public readonly string status;

        public Memento(string status)
        {
            this.status = status;
        }
    }
}
