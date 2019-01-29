using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

            string line = String.Empty;
            string lessonName = String.Empty;

            while (true)
            {
                line = Console.ReadLine();

                if (line == "course start")
                {
                    break;
                }

                string[] tokens = line.Split(':');
                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        lessonName = tokens[1];
                        Add(lessons, lessonName);
                        break;

                    case "Insert":
                        lessonName = tokens[1];
                        int index = int.Parse(tokens[2]);
                        Insert(lessons, lessonName, index);
                        break;
                    case "Remove":
                        lessonName = tokens[1];
                        Remove(lessons, lessonName);
                        break;
                    case "Swap":
                        lessonName = tokens[1];
                        string secondLessonName = tokens[2];
                        Swap(lessons, lessonName, secondLessonName);
                        break;
                    case "Exercise":
                        lessonName = tokens[1];
                        Exercise(lessons, lessonName);
                        break;
                }
            }

            foreach (var lesson in lessons)
            {
                Console.WriteLine($"{lessons.IndexOf(lesson) + 1}.{lesson}");
            }

        }

        private static void Exercise(List<string> lessons, string lessonName)
        { 
            if (lessons.Contains(lessonName))
            {
                int indexOfLesson = lessons.IndexOf(lessonName);
                string textToAdd = $"{lessonName}-Exercise";

                lessons.Insert(indexOfLesson + 1, textToAdd);
            }
            else if(!lessons.Contains(lessonName))
            {
                lessons.Add(lessonName);
                int indexOfLesson = lessons.IndexOf(lessonName);
                string textToAdd = $"{lessonName}-Exercise";
                lessons.Insert(indexOfLesson + 1, textToAdd);
            }
        }

        private static void Swap(List<string> lessons, string lessonName, string secondLessonName)
        {
            if (lessons.Contains(lessonName) && lessons.Contains(secondLessonName))
            {
                int indexFirstLesson = lessons.IndexOf(lessonName);
                int indexSecondLesson = lessons.IndexOf(secondLessonName);

                lessons.RemoveAt(indexFirstLesson);
                lessons.Insert(indexFirstLesson, secondLessonName);
                lessons.RemoveAt(indexSecondLesson);
                lessons.Insert(indexSecondLesson, lessonName);
                if (lessons.Contains($"{lessonName}-Exercise"))
                {
                    lessons.Remove($"{lessonName}-Exercise");
                    Exercise(lessons, lessonName);
                }
                else if (lessons.Contains($"{secondLessonName}-Exercise"))
                {
                    lessons.Remove($"{secondLessonName}-Exercise");
                    int index = lessons.IndexOf(secondLessonName);
                    lessons.Insert(index + 1, $"{secondLessonName}-Exercise");
                }
            }
        }

        private static void Remove(List<string> lessons, string lessonName)
        {
            if (lessons.Contains(lessonName))
            {
                lessons.Remove(lessonName);

                if (lessons.Contains($"{lessonName}-Exercise"))
                {
                    lessons.Remove($"{lessonName}-Exercise");
                }
            }
        }

        private static void Insert(List<string> lessons, string lessonName, int index)
        {
            if (index >= 0 && index <= lessons.Count - 1)
            {
                if (!lessons.Contains(lessonName))
                {
                    lessons.Insert(index, lessonName);
                }
            }
        }

        private static void Add(List<string> lessons, string lessonName)
        {
            if (!lessons.Contains(lessonName))
            {
                lessons.Add(lessonName);
            }
        }
    }
}
