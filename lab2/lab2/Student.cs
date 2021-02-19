namespace lab2
{
    public class Student
    {
        private string _name;
        private int[] _marks = new int[5];
        private bool _donater;
        
        public Student(string name, int mark1, int mark2, int mark3, int mark4, int mark5, bool donater)
        {
            _name = name;
            _marks[0] = mark1;
            _marks[1] = mark2;
            _marks[2] = mark3;
            _marks[3] = mark4;
            _marks[4] = mark5;
            _donater = donater;
        }

    }
}
