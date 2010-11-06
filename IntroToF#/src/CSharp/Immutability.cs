namespace CSharp
{
    public class Immutability
    {
        public void Sample()
        {
            Credentials credentials = new Credentials("someuser", "$3cr3t");

            // Cant do it, this class is immutable!
            credentials.Username = "anotheruser";

            // But we can create a new one
            credentials = credentials.ChangeUsername("anotheruser");
        }

        // This type is immutable
        public class Credentials
        {
            public readonly string Username;
            public readonly string Password;

            public Credentials(string username, string password)
            {
                Username = username;
                Password = password;
            }

            public Credentials ChangeUsername(string username)
            {
                return new Credentials(username, Password);
            }
        }
    }
}
