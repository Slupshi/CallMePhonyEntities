using CallMePhonyEntities.DTO.Responses;
using CallMePhonyEntities.Enums;

namespace CallMePhonyEntities.Models;

public class User : ModelBase, ISearchableObject
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string MobilePhone { get; set; }
    public string? Password { get; set; }
    public UserType? UserType { get; set; }
    public string Gender { get; set; }

    public virtual Service? Service { get; set; }
    public virtual Site? Site { get; set; }

    public User() { }

    public User(UserResponse userResponse)
    {
        Id = userResponse.Id;
        FirstName = userResponse.FirstName;
        LastName = userResponse.LastName;
        UserName = userResponse.UserName;
        Email = userResponse.Email;
        Phone = userResponse.Phone;
        MobilePhone = userResponse.MobilePhone;
        Gender = userResponse.Gender;
        UserType = userResponse.UserType;
        Service = userResponse.Service;
        Site = userResponse.Site;

    }
}
