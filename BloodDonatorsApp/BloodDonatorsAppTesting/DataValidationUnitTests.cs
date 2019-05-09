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
        public void ShouldHaveErrorWhenFirstNameIsNull()
        {
            validator.ShouldHaveValidationErrorFor(donation => donation.First_Name, null as string);
        }

        [Test]
        public void ShouldHaveErrorWhenLastNameIsNull()
        {
            validator.ShouldHaveValidationErrorFor(donation => donation.Last_Name, null as string);
        }

        [Test]
        public void ShouldHaveErrorWhenPeselIsNull()
        {
            validator.ShouldHaveValidationErrorFor(donation => donation.Pesel, 0);
        }

        [Test]
        public void ShouldHaveErrorWhenDonationDateIsNull()
        {
            validator.ShouldHaveValidationErrorFor(donation => donation.Donation_date, null as string);
        }

        [Test]
        public void ShouldHaveErrorWhenDonatedBloodAmountIsNull()
        {
            validator.ShouldHaveValidationErrorFor(donation => donation.Donated_blood_amount, null as string);
        }

        [Test]
        public void ShouldHaveErrorWhenBloodTypeIsNull()
        {
            validator.ShouldHaveValidationErrorFor(donation => donation.Blood_type, null as string);
        }

        [Test]
        public void ShouldHaveErrorWhenBloodFactorIsNull()
        {
            validator.ShouldHaveValidationErrorFor(donation => donation.Blood_factor, null as string);
        }

        [Test]
        public void ShouldHaveErrorWhenAddressIsNull()
        {
            validator.ShouldHaveValidationErrorFor(donation => donation.Address, null as string);
        }

    }
}