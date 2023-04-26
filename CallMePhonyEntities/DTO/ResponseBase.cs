using CallMePhonyEntities.Models;

namespace CallMePhonyEntities.DTO
{
    public class ResponseBase : ModelBase
    {
        public string? ErrorMessage { get; set; }
    }
}
