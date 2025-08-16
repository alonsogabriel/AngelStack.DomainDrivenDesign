using AngelStack.Common.Guards;
using AngelStack.DomainDrivenDesign.Abstractions;
using AngelStack.DomainDrivenDesign.ValueObjects;

namespace AngelStack.DomainDrivenDesign.Entities;

public class AbstractUser<T> : AbstractEntity<T>
{
    protected AbstractUser() { }
    public AbstractUser(Username username, Email email, PhoneNumber? phoneNumber)
    {
        Username = username.Guard();
        Email = email.Guard();
        PhoneNumber = phoneNumber;
    }

    public Username Username { get; protected set; }
    public Email Email { get; protected set; }
    public PhoneNumber? PhoneNumber { get; protected set; }
}
