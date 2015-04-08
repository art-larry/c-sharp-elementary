using System;

namespace Student_class_ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            var st = new Student("Art", "Larry");
            st.ShowInfo();
            st.SetMarkAdministrating(34);
            st.SetMarkAdministrating(9);
            st.SetMarkAdministrating(5);
            st.SetMarkDesign(5);
            st.SetMarkDesign(7);
            st.SetMarkProgramming(10);
            st.SetMarkProgramming(9);
            st.ShowInfo();
            st.GetAverageDesign();
            st.GetAverageProgramming();
        }
    }
}
