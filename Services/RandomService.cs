namespace ProvaPub.Services
{
	public class RandomService
	{
		int seed;
		Random rnd;
		public RandomService()
		{
			seed = Guid.NewGuid().GetHashCode();
			rnd = new Random(seed);
		}
		public int GetRandom()
		{
			return rnd.Next(10);
		}

	}
}
