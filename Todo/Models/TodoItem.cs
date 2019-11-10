using SQLite;

namespace Todo
{
	public class TodoItem
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
        public int Votes { get; set; } = 0;
		public string Name { get; set; }
		public string Notes { get; set; }
		public bool Done { get; set; }

        public void Increment()
        {
            Votes += 1;
        }
	}
}

