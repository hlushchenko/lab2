namespace lab2
{
    public class Student
    {
        private string Name;
        private int[] Marks = new int[5];
        private bool Donater;
        
        public Student(string name, int mark1, int mark2, int mark3, int mark4, int mark5, bool donater)
        {
            Name = name;
            Marks[0] = mark1;
            Marks[1] = mark2;
            Marks[2] = mark3;
            Marks[3] = mark4;
            Marks[4] = mark5;
            Donater = donater;
        }

    }
}
