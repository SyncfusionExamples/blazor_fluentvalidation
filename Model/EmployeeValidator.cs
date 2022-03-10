using FluentValidation;

namespace SyncFluentValidation.Model
{
    public class EmployeeValidator: AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(e => e.FirstName).NotEmpty();
            RuleFor(e => e.EmailAddress).EmailAddress().NotEmpty();
            RuleFor(e => e.DateOfBirth).NotEmpty();
            RuleFor(e => e.Experience).NotEmpty().LessThanOrEqualTo(40).GreaterThanOrEqualTo(0);
            RuleFor(e => e.Gender).NotEmpty();
            RuleFor(e => e.PermanentAddress).SetValidator(new AddressValidator());
        }
    }
    public class AddressValidator : AbstractValidator<PermanentAddress>
    {
        public AddressValidator()
        {
            RuleFor(address => address.AddressLine1).NotEmpty();
            RuleFor(address => address.Country).NotEmpty();
            RuleFor(address => address.Postcode).NotEmpty();
            When(address => address.Country == "US", () => { RuleFor(address => address.Postcode).MinimumLength(5).MaximumLength(10); })
                .Otherwise(()=> {
                    RuleFor(address => address.Postcode).MaximumLength(7);
                });
        }
    }
}
