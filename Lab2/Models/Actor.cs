namespace Lab2.Models
{
    public class Actor
    {
        private int _actorId;
        public int ActorId { get { return _actorId; } }

        private string _name;
        public string Name { get { return _name; } }

        private int _paid;
        public int Paid { get { return _paid; } }

        public Actor(int actorId, string name,int paid)
        {
            _actorId = actorId;
            _name = name;
            _paid = paid;
        }
    }
}
