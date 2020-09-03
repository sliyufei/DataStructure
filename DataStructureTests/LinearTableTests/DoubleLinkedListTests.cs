using System;
using DataStructureCore.LinearTableSamples.LinkedList.DoubleLinkedListSamples;
using Xunit;

namespace DataStructureTests.LinearTableTests
{
    public class DoubleLinkedListTests
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

            var doubleLinkedList = new DoubleLinkedList<Student>();

            foreach (var student in students)
            {
                doubleLinkedList.HeadInsert(new Node<Student>(student));
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

            var doubleLinkedList = new DoubleLinkedList<Student>();

            foreach (var student in students)
            {
                doubleLinkedList.TailInsert(new Node<Student>(student));
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

            var doubleLinkedList = new DoubleLinkedList<Student>();

            foreach (var student in students)
            {
                doubleLinkedList.TailInsert(new Node<Student>(student));
            }

            var insertStudent = new Student
            {
                No = 4,
                Name = "李4",
                Score = 44.4
            };

            doubleLinkedList.Insert(new Node<Student>(insertStudent), 1);

        }



        [Fact]
        public void Print()
        {
            var students = new Student[]
            {
                new Student{ No=1,Name="李1",Score=22.1},
                new Student{ No=2,Name="李2",Score=32.3},
                new Student{ No=3,Name="李3",Score=42.5}
            };

            var doubleLinkedList = new DoubleLinkedList<Student>();

            foreach (var student in students)
            {
                doubleLinkedList.TailInsert(new Node<Student>(student));
            }

            doubleLinkedList.Print();
        }


        [Fact]
        public void GetElement()
        {
            var students = new Student[]
            {
                new Student{ No=1,Name="李1",Score=22.1},
                new Student{ No=2,Name="李2",Score=32.3},
                new Student{ No=3,Name="李3",Score=42.5}
            };

            var doubleLinkedList = new DoubleLinkedList<Student>();

            foreach (var student in students)
            {
                doubleLinkedList.TailInsert(new Node<Student>(student));
            }

            var node = doubleLinkedList.GetElement(2);
        }

        [Fact]
        public void GetIndex()
        {
            var students = new Student[]
            {
                new Student{ No=1,Name="李1",Score=22.1},
                new Student{ No=2,Name="李2",Score=32.3},
                new Student{ No=3,Name="李3",Score=42.5}
            };

            var doubleLinkedList = new DoubleLinkedList<Student>();

            foreach (var student in students)
            {
                doubleLinkedList.TailInsert(new Node<Student>(student));
            }

            var index = doubleLinkedList.GetIndex(doubleLinkedList.First.Next);
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

            var doubleLinkedList = new DoubleLinkedList<Student>();

            foreach (var student in students)
            {
                doubleLinkedList.TailInsert(new Node<Student>(student));
            }

            doubleLinkedList.Delete(2);
        }
    }
}
