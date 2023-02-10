namespace Lab2.Models
{
    public class Role
    {
        private int _roleId;
        public int RoleId { get { return _roleId; } }

        private string _name;
        public string Name { get { return _name; } }

        public Movie Movie { get; set; }
        public Actor Actor { get; set; }

        public Role(int roleId, string name, Movie movie, Actor actor)
        {
            _roleId = roleId;
            _name = name;
            this.Movie = movie;
            this.Actor = actor;
        }
    }
}
