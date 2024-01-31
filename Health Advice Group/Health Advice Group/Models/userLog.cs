namespace Health_Advice_Group.Models
{
    public class userLog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        //creating a constructor

        public userLog(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

    }
}
