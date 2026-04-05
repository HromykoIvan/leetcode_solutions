var email = "support@reload.services";
Console.Write(ValidateEmails(email));

static bool ValidateEmails(string emailAddress)
{
    return emailAddress?.Split(',').All(address => EmailValidation.EmailValidator.Validate(address.Trim(), allowInternational: true)) ?? false;
}