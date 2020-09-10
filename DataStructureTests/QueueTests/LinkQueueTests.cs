using DataStructureCore.Model;
using DataStructureCore.QueueSamples.LinkQueueSamples;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructureTests.QueueTests
{
    public class LinkQueueTests
    {
        [Fact]
        public void EnqueueAndDequeue()
        {
            var students = new Student[]
            {
                new Student{ No=1,Name="李1",Score=22.1},
                new Student{ No=2,Name="李2",Score=32.3},
                new Student{ No=3,Name="李3",Score=42.5}
            };

            var linkQueue = new LinkQueue<Student>();

            foreach (var student in students)
            {
                linkQueue.Enqueue(new Node<Student>(student));
            }

           
            var deqStudent = new Node<Student>();

            while (deqStudent != null)
            {
                deqStudent= linkQueue.Dequeue();
            }

        }
    }
}
