using Lab2.Models;

namespace Lab2.Data
{
    public static class Context
    {
        public static HashSet<Movie> movies= new HashSet<Movie>();
        public static HashSet<Actor> actors= new HashSet<Actor>();
        public static HashSet<Role> roles= new HashSet<Role>();
        public static HashSet<User> users= new HashSet<User>();
        public static HashSet<Rating> ratings = new HashSet<Rating>();

        private static int idCounter = 0;
        static Context() 
        {
             
            Movie movie1= new Movie(idCounter++, "Movie1", "Comedy", 100, 80);
            Movie movie2= new Movie(idCounter++, "Movie2", "Comedy", 120, 90);
            Movie movie3 = new Movie(idCounter++, "Movie3", "Adventure", 130, 90);
            Movie movie4 = new Movie(idCounter++, "Movie4", "Adventure", 150, 90);

            Actor act1=new Actor(idCounter++, "Actor1", 100);
            Actor act2 = new Actor(idCounter++, "Actor2", 200);
            Actor act3 = new Actor(idCounter++, "Actor3", 300);
            Actor act4 = new Actor(idCounter++, "Actor4", 400);

            movies.Add(movie1);
            movies.Add(movie2);
            movies.Add(movie3);
            movies.Add(movie4);

            actors.Add(act1);
            actors.Add(act2);
            actors.Add(act3);
            actors.Add(act4);

            roles.Add(new Role(idCounter++, "Role1", movie1, act1));
            roles.Add(new Role(idCounter++, "Role2", movie2, act1));
            roles.Add(new Role(idCounter++, "Role3", movie3, act2));
            roles.Add(new Role(idCounter++, "Role4", movie4, act2));
            roles.Add(new Role(idCounter++, "Role5", movie1, act3));
            roles.Add(new Role(idCounter++, "Role6", movie1, act4));

            users.Add(new User(idCounter++,"user1"));
            users.Add(new User(idCounter++, "user2"));
            users.Add(new User(idCounter++, "user3"));
        }
    }
}
