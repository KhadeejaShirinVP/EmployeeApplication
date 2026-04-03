namespace EmployeeApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //for rolebased authorization
        public string Role { get; set; }
    }
}
