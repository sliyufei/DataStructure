using DataStructureCore.LinearTableSamples.LinkedList.SingleLinkedListSamples;
using DataStructureCore.LinearTableSamples.SingleLinkedListSamples.SingleLinkedList;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructureTests.LinearTableTests
{
    public class SingleLinkedListTests
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

            var singleLinkedList = new SingleLinkedList<Student>();

            foreach (var student in students)
            {
                singleLinkedList.HeadInsert(new Node<Student>(student));
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

            var singleLinkedList = new SingleLinkedList<Student>();

            foreach (var student in students)
            {
                singleLinkedList.TailInsert(new Node<Student>(student));
            }

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

            var singleLinkedList = new SingleLinkedList<Student>();

            foreach (var student in students)
            {
                singleLinkedList.TailInsert(new Node<Student>(student));
            }

            singleLinkedList.Print();
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

            var singleLinkedList = new SingleLinkedList<Student>();

            foreach (var student in students)
            {
                singleLinkedList.TailInsert(new Node<Student>(student));
            }

            var node = singleLinkedList.GetElement(2);
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

            var singleLinkedList = new SingleLinkedList<Student>();

            foreach (var student in students)
            {
                singleLinkedList.TailInsert(new Node<Student>(student));
            }

            var index = singleLinkedList.GetIndex(singleLinkedList.First.Next);
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

            var singleLinkedList = new SingleLinkedList<Student>();

            foreach (var student in students)
            {
                singleLinkedList.TailInsert(new Node<Student>(student));
            }

            singleLinkedList.Delete(2);
        }

        [Fact]
        public void Reverse()
        {
            var students = new Student[]
            {
                new Student{ No=1,Name="李1",Score=22.1},
                new Student{ No=2,Name="李2",Score=32.3},
                new Student{ No=3,Name="李3",Score=42.5}
            };

            var singleLinkedList = new SingleLinkedList<Student>();

            foreach (var student in students)
            {
                singleLinkedList.TailInsert(new Node<Student>(student));
            }

            singleLinkedList.Reverse();
        }



    }
}
