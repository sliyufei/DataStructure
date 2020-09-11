using DataStructureCore.Model;
using DataStructureCore.QueueSamples.ArrayQueueSamples;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructureTests.QueueTests
{
    public class ArrayQueueTests
    {
        [Fact]
        public void EnqueueAndDequeue()
        {
            var students = new Student[]
            {
                new Student{ No=1,Name="李1",Score=22.1},
                new Student{ No=2,Name="李2",Score=32.3},
                new Student{ No=3,Name="李3",Score=42.5},
                new Student{ No=4,Name="李4",Score=45}
            };

            var arrayQueue = new ArrayQueue<Student>(3);

            foreach (var student in students)
            {
                var result = arrayQueue.Enqueue(student);
            }


            var deqStudent = new Student();
            arrayQueue.Dequeue(out deqStudent);

            arrayQueue.Enqueue(students[3]);

        }


        [Fact]
        public void EnqueueAndDequeue2()
        {
            var students = new Student[]
            {
                new Student{ No=1,Name="李1",Score=22.1},
                new Student{ No=2,Name="李2",Score=32.3},
                new Student{ No=3,Name="李3",Score=42.5},
                new Student{ No=4,Name="李4",Score=45}
            };

            var arrayQueue = new ArrayQueueWithoutRear<Student>(3);

            foreach (var student in students)
            {
                var result = arrayQueue.Enqueue(student);
            }


            var deqStudent = new Student();
            arrayQueue.Dequeue(out deqStudent);

            arrayQueue.Enqueue(students[3]);

        }


    }
}
