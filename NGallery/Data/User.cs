namespace NGallery.Data;
using  Microsoft.AspNetCore.Identity;


public class User : IdentityUser {
    // public int id {get;set;}
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public DateTime DateSubsciption {get;set;}

    public bool IsActive {get;set;} = true;
    public bool IsPrivate {get;set;} = false;
    public List<Photo> ? Photos {get; set;}

}