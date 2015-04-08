using System;

namespace Student_class_ex7
{
    class Student
    {
        private string soName;
        private string name;
        private string secName;
        private string group;
        private int age;

        private int[][] mark = new int[3][];

        public Student(string name, string soname, string secname, string group, int age)
        {
            this.name = name;
            this.soName = soname;
            this.secName = secname;
            this.group = group;
            this.age = age;

            mark[0] = new int[10];
            mark[1] = new int[10];
            mark[2] = new int[10];
        }

        public Student(string name, string soname, string secname, string group):this(name, soname, secname, group, 0)
        {}

        public Student(string name, string soname, string secname):this(name, soname, secname, null, 0)
        {}

        public Student(string name, string soname):this(name, soname, null, null, 0)
        {}

        public Student(string name):this(name, null, null, null, 0)
        {}

        public void ShowInfo()
        {
            string FIO = name;
            if(!String.IsNullOrEmpty(soName))
            {
                FIO = String.Join(" ", new string[]{ FIO, soName});
            }
            if(!String.IsNullOrEmpty(secName))
            {
               FIO = String.Concat(FIO, " ", secName);
            }
            Console.WriteLine(FIO);
            if(!String.IsNullOrEmpty(group))
            {
                Console.WriteLine("Group:" + group);
            }
            if(age > 0)
            {
                Console.WriteLine("Age:" + age);
            }
            Console.WriteLine("----------------------");
            Console.Write("Programming: ");
            for(int i = 0; i < mark[0].Length; ++i)
            {
                Console.Write(mark[0][i] + " ");
            }
            Console.WriteLine();
            
            Console.Write("Administrating: ");
            for(int i = 0; i < mark[1].Length; ++i)
            {
                Console.Write(mark[1][i] + " ");
            }
            Console.WriteLine();

            Console.Write("Design: ");
            for(int i =0; i < mark[2].Length; ++i)
            {
                Console.Write(mark[2][i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public void SetMarkProgramming(int _mark)
        {
            SetMark(0, _mark);
        }

        public void SetMarkAdministrating(int _mark)
        {
            SetMark(1, _mark);
        }

        public void SetMarkDesign(int _mark)
        {
            SetMark(2, _mark);
        }

        private void SetMark(int i, int _mark)
        {

            if (_mark <= 0 || _mark > 12)
            {
                Console.WriteLine("Incorrenct mark!");
                return;
            }

            for (int j = 0; j < mark[i].Length; ++j)
            {
                if (mark[i][j] == 0)
                {
                    mark[i][j] = _mark;
                    return;
                }

            }
            Console.WriteLine("Not enough journal!");
            return;
        }

        public void ShowMarkProgramming()
        {
            ShowMark(0);
        }

        public void ShowMarkAdministrating()
        {
            ShowMark(1);
        }

        public void ShowMarkDesign()
        {
            ShowMark(2);
        }

        private void ShowMark(int i)
        {
            for(int j = 0; j < mark[i].Length; ++j)
            {
                Console.Write(mark[i][j] + " ");
            }
            Console.WriteLine();
        }

        private void AverageMark(int i)
        {
            int sum = 0;
            int count = 0;
            for(int j= 0; j < mark[i].Length; ++j)
            {
                if(mark[i][j] > 0)
                {
                    ++count;
                }
                sum += mark[i][j];
            }
            Console.WriteLine(sum / count);
        }

        public void GetAverageProgramming()
        {
            AverageMark(0);
        }

        public void GetAverageAdministrating()
        {
            AverageMark(1);
        }

        public void GetAverageDesign()
        {
            AverageMark(2);
        }
    }
}
