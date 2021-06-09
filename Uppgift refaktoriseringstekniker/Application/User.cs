namespace Application
{
    internal class User
    {
        public User()
        {
        }

        public string Username { get; internal set; }
        public string Password { get; internal set; }
        public int Age { get; internal set; }
        public int MembershipLength { get; internal set; }
        public int DiscountLevel { get; internal set; }

        public override string ToString()
        {
            return $"User: [" +
                $"\n  Username: {Username}" +
                $"\n  Password: {Password}" +
                $"\n  Age: {Age}" +
                $"\n  MembershipLength: {MembershipLength}" +
                $"\n  DiscountLevel: {DiscountLevel}" +
                $"\n]";
        }
    }
}