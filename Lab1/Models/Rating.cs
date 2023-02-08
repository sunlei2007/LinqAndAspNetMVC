namespace Lab1.Models
{
    public class Rating
    {
        private int _ratingId;
        public int RatingId { get { return _ratingId; } }
        private int _level;
        public int Level { get { return _level; } }
        

        public Rating(int ratingId,int rating)
        {
            _ratingId = ratingId;
            _level = rating;
        }
    }
}
