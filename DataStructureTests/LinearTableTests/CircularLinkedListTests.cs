using System;
using DataStructureCore.LinearTableSamples.LinkedList.CircularLinkedListSamples;
using Xunit;
namespace DataStructureTests.LinearTableTests
{
    public class CircularLinkedListTests
    {
        [Fact]
        public void HeadInsert()
        {
            var students = new Student[]
            {
                new Student{ No=1,Name="李1",Score=22.1},
                new Student{ No=2,Name="李2",Score=32.3},
                new Student{ No=3,Name="李3",Score=42.5}
            };

            var circularLinkedList = new CircularLinkedList<Student>();

            foreach (var student in students)
            {
                circularLinkedList.HeadInsert(new Node<Student>(student));
            }
        }

        [Fact]
        public void TailInsert()
        {
            var students = new Student[]
            {
                new Student{ No=1,Name="李1",Score=22.1},
                new Student{ No=2,Name="李2",Score=32.3},
                new Student{ No=3,Name="李3",Score=42.5}
            };

            var circularLinkedList = new CircularLinkedList<Student>();

            foreach (var student in students)
            {
                circularLinkedList.TailInsert(new Node<Student>(student));
            }

        }

        [Fact]
        public void Insert()
        {
            var students = new Student[]
            {
                new Student{ No=1,Name="李1",Score=22.1},
                new Student{ No=2,Name="李2",Score=32.3},
                new Student{ No=3,Name="李3",Score=42.5}
            };

            var circularLinkedList = new CircularLinkedList<Student>();

            foreach (var student in students)
            {
                circularLinkedList.TailInsert(new Node<Student>(student));
            }

            var insertStudent = new Student
            {
                No = 4,
                Name = "李4",
                Score = 44.4
            };

            circularLinkedList.Insert(new Node<Student>(insertStudent), 1);

        }

        [Fact]
        public void Delete()
        {
            var students = new Student[]
            {
                new Student{ No=1,Name="李1",Score=22.1},
                new Student{ No=2,Name="李2",Score=32.3},
                new Student{ No=3,Name="李3",Score=42.5}
            };

            var circularLinkedList = new CircularLinkedList<Student>();

            foreach (var student in students)
            {
                circularLinkedList.TailInsert(new Node<Student>(student));
            }

            circularLinkedList.Delete(2);
        }


    }
}
