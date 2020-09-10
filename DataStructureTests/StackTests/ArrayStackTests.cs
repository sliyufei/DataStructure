using System;
using Xunit;
using DataStructureCore.StackSamples.ArrayStackSamples;
using DataStructureCore.Model;

namespace DataStructureTests.StackTests
{
    public class ArrayStackTests
    {
        [Fact]
        public void PushAndPop()
        {
            var students = new Student[]
            {
                new Student{ No=1,Name="李1",Score=22.1},
                new Student{ No=2,Name="李2",Score=32.3},
                new Student{ No=3,Name="李3",Score=42.5}
            };

            var arrayStack = new ArrayStack<Student>(students.Length);

            foreach (var student in students)
            {
                arrayStack.Push(student);
            }

            var popStudent = new Student();

            while (arrayStack.Pop(out popStudent))
            {

            }

        }
    }
}
