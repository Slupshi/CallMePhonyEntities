namespace CallMePhonyEntities.DTO.Responses
{
    public class UsersResponse : ResponseBase
    {
        public IEnumerable<UserResponse>? Users { get; set; }
    }
}
