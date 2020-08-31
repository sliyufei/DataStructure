using System;
using DataStructureCore.LinearTableSamples.SequenceListSamples;
using Xunit;
namespace DataStructureTests.LinearTableTests
{
    public class SequenceListTests
    {
        [Fact]
        public void Print()
        {
            var students = new Student[]
            {
                new Student{ No=1,Name="李1",Score=22.1},
                new Student{ No=2,Name="李2",Score=32.3},
                new Student{ No=3,Name="李3",Score=42.5}
            };

            var sqList = new SequenceList<Student>(students);

            sqList.Print();
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

            var sqList = new SequenceList<Student>(students);

            var student = sqList.GetElement(2);
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

            var sqList = new SequenceList<Student>(students);

            var index = sqList.GetIndex(students[1]);
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

            var sqList = new SequenceList<Student>(students);

            var insertStudent = new Student
            {
                No = 4,
                Name = "李5",
                Score = 66
            };

            sqList.Insert(insertStudent, 1);
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

            var sqList = new SequenceList<Student>(students);

            sqList.Delete(0);
        }


    }
}
