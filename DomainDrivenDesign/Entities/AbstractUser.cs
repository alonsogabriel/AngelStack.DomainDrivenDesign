using DomainDrivenDesign.Abstractions.Entities;
using DomainDrivenDesign.Abstractions.Extensions;
using DomainDrivenDesign.ValueObjects;

namespace DomainDrivenDesign.Entities;

public class AbstractUser<T> : AbstractEntity<T>
{
    protected AbstractUser() { }
    public AbstractUser(Username username, Email email, PhoneNumber? phoneNumber)
    {
        Username = username.Guard(new ArgumentNullException(nameof(username)));
        Email = email.Guard(new ArgumentNullException(nameof(email)));
        PhoneNumber = phoneNumber;
    }

    public Username Username { get; protected set; }
    public Email Email { get; protected set; }
    public PhoneNumber? PhoneNumber { get; protected set; }
}
