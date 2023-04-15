namespace HikingInvites.Models
{
    public static class Repository
    {
        private static List<UserResponse> userResponses = new();

        public static IEnumerable<UserResponse> UserResponses => userResponses;

        public static void AddResponse(UserResponse response)
        {
            Console.WriteLine(response);
            userResponses.Add(response);
        }

    }
}
