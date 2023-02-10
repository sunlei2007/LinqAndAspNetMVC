namespace Lab2.Models
{
    public class User
    {
        private int _userId;
        public int UserId { get { return _userId; } }

        private string _name;
        public string Name { get { return _name; } }


        public User(int userId, string name)
        {
            _userId = userId;
            _name = name;
        }
    }
}
