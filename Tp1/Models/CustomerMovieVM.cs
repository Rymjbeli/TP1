namespace Tp1.Models
{
    public class CustomerMovieVM
    {
        public Customer customer { get; set; }
        public List<Movie> movies { get; set; }

        public CustomerMovieVM(Customer customer, List<Movie> movies)
        {
            this.customer = customer;
            this.movies = movies;
        }
    }
}
