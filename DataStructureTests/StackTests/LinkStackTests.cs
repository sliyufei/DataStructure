using System;
using DataStructureCore.Model;
using DataStructureCore.StackSamples.LinkStackSamples;
using Xunit;

namespace DataStructureTests.StackTests
{
    public class LinkStackTests
    {
        [Fact]
        public void PushAndPop()
        {
            var students = new Student[]
            {
                new Student {No = 1, Name = "李1", Score = 22.1},
                new Student {No = 2, Name = "李2", Score = 32.3},
                new Student {No = 3, Name = "李3", Score = 42.5}
            };

            var linkStack = new LinkStack<Student>();

            foreach (var student in students)
            {
                linkStack.Push(new Node<Student>(student));
            }

            var popStudent = new Node<Student>();

            while (linkStack.Pop(out popStudent))
            {
            }
        }
    }
}