using System.ComponentModel.DataAnnotations;

namespace sess09_delegates_events_and_collections;

/// <summary>
/// This class represents a basic user account with information such as userid, username and password. It can be
/// used for systems requiring authentication like online accounts or POS systems.
/// </summary>
public class UserAccount
{
    /// <summary>
    /// Static/class variable to autogenerate unique userID's starting from 1001
    /// </summary>
    private static long initialID = 1001L;

    /// <summary>
    /// Retrieves/fetches the unique identifier for the user account.
    /// This property is read-only and is automatically assigned during user account creation.
    /// </summary>
    [Key]
    [Required]
    public long UserID { get; }
    [Required]
    public string Username { get; set; }
    [Required]
    [MinLength(8), MaxLength(15)]
    public string Password { get; set; }

    /// <summary>
    /// Initialises a new instance of the <see cref="UserAccount"/> class with a specified username and password.
    /// The userID is automatically assigned from a static counter that increments with each new instance.
    /// </summary>
    /// <param name="username">The username associated with the account</param>
    /// <param name="password">The password associated and used to access the account</param>
    public UserAccount(string username,  string password)
    {
        this.Username = username;
        this.Password = password;
        this.UserID = initialID++;
    }

    /// <summary>
    /// Returns a string representation of the <see cref="UserAccount"/> object including:
    /// the userID, username, and a masked/obscured version of the account password.
    /// The password will be partially masked to ensure privacy. (Only the first and last
    /// character are visible).
    /// </summary>
    /// <returns>
    /// A string representation of the account's userid, username and masked version of the password.
    /// </returns>
    public override string ToString()
    {
        return $"User Account Details" +
               $"\n" + new string('-', 55) +
               $"\nUser ID: {this.UserID}" +
               $"\nUsername: {this.Username}" +
               $"\nPassword: {this.Password.Remove(1,
                   (this.Password.Length - 2)).Insert(1,"***********")}"+ // Hide/obfuscicate password chars.
               $"\n" + new string('-', 55);
    }
}