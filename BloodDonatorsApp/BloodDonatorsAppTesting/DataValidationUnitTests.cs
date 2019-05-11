using NUnit.Framework;
using FluentValidation;
using FluentValidation.TestHelper;
using BloodDonatorsApp.Validations;
using BloodDonatorsApp.Models;


namespace Tests
{
    public class DonationValidatorTester
    {
        private DonationValidator validator;

        [SetUp]
        public void Setup()
        {
            validator = new DonationValidator();
        }

        [Test]
        public void ShouldHaveErrorWhenFirstNameIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(donation => donation.First_Name, string.Empty);
        }


        [Test]
        public void ShouldHaveErrorWhenLastNameIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(donation => donation.Last_Name, string.Empty);
        }

        [Test]
        public void ShouldHaveErrorWhenPeselIsNull()
        {
            validator.ShouldHaveValidationErrorFor(donation => donation.Pesel, 0);
        }

        [Test]
        public void ShouldHaveErrorWhenDonationDateIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(donation => donation.Donation_date, string.Empty);
        }

        [Test]
        public void ShouldHaveErrorWhenDonatedBloodAmountIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(donation => donation.Donated_blood_amount, string.Empty);
        }

        [Test]
        public void ShouldHaveErrorWhenBloodTypeIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(donation => donation.Blood_type, string.Empty);
        }

        [Test]
        public void ShouldHaveErrorWhenBloodFactorIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(donation => donation.Blood_factor, string.Empty);
        }

        [Test]
        public void ShouldHaveErrorWhenAddressIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(donation => donation.Address, string.Empty);
        }

    }

    public class DonatorValidatorTester
    {
        private DisplayDonatorViewModelValidator validator;

        [SetUp]
        public void Setup()
        {
            validator = new DisplayDonatorViewModelValidator();
        }

        [Test]
        public void ShouldHaveErrorWhenFirstNameIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(donator => donator.First_Name, string.Empty);
        }

        [Test]
        public void ShouldHaveErrorWhenLastNameIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(donator => donator.Last_Name, string.Empty);
        }


        [Test]
        public void ShouldHaveErrorWhenDonatedBloodAmountIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(donator => donator.Donated_blood_amount, string.Empty);
        }
    }

    public class DonationDetailsValidatorTester
    {
        private DisplayDonationDetailsValidator validator;

        [SetUp]
        public void Setup()
        {
            validator = new DisplayDonationDetailsValidator();
        }

        [Test]
        public void ShouldHaveErrorWhenFirstNameIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(details => details.First_Name, string.Empty);
        }

        [Test]
        public void ShouldHaveErrorWhenLastNameIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(details => details.Last_Name, string.Empty);
        }

        [Test]
        public void ShouldHaveErrorWhenPeselIsNull()
        {
            validator.ShouldHaveValidationErrorFor(details => details.Pesel, 0);
        }

        [Test]
        public void ShouldHaveErrorWhenDonationDateIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(details => details.Donation_date, string.Empty);
        }

        [Test]
        public void ShouldHaveErrorWhenDonatedBloodAmountIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(details => details.Donated_blood_amount, string.Empty);
        }

        [Test]
        public void ShouldHaveErrorWhenBloodTypeIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(details => details.Blood_type, string.Empty);
        }

        [Test]
        public void ShouldHaveErrorWhenBloodFactorIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(details => details.Blood_factor, string.Empty);
        }

        [Test]
        public void ShouldHaveErrorWhenAddressIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(details => details.Address, string.Empty);
        }

        
    }
}