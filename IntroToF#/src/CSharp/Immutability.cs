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
            private readonly string _username;
            private readonly string _password;

            public Credentials(string username, string password)
            {
                _username = username;
                _password = password;
            }

            public Credentials ChangeUsername(string username)
            {
                return new Credentials(username, _password);
            }

            public string Username { get { return _username; } }
            public string Password { get { return _password; } }
        }
    }
}
