using Bogus;
using Bogus.DataSets;
using System;
using Xunit;
using TestProject1.Models;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Faker<UserAddress> addressBogus = new Faker<UserAddress>();
            addressBogus.RuleFor(x => x.Description, y => y.Address.FullAddress());
            addressBogus.RuleFor(x => x.Number, y => y.Address.CountryCode());

            var personBogus = new Faker<Models.Person>();
            personBogus.RuleFor(x => x.Name, y => y.Person.FirstName);
            personBogus.RuleFor(x => x.Surname, y => y.Person.LastName);
            personBogus.RuleFor(x => x.Birthday, y => y.Person.DateOfBirth);
            personBogus.RuleFor(x => x.Address, y => addressBogus.Generate());

            var hundredPpl = personBogus.Generate(100);
        }


    }

    public class UnitTest2
    {
        [Fact]
        public void Test2()
        {
            Faker<CarOwner> carsBogus = new Faker<CarOwner>();
            carsBogus.RuleFor(x => x.Name, y => y.Person.FirstName);
            carsBogus.RuleFor(x => x.Surname, y => y.Person.LastName);
            carsBogus.RuleFor(x => x.PhoneNumber, y => y.Phone.PhoneNumber());
            carsBogus.RuleFor(x => x.Manufacturer, y => y.Vehicle.Manufacturer());
            carsBogus.RuleFor(x => x.Model, y => y.Vehicle.Model());
            carsBogus.RuleFor(x => x.Vin, y => y.Vehicle.Vin());
            carsBogus.RuleFor(x => x.Fuel, y => y.Vehicle.Fuel());

            var sevenCars = carsBogus.Generate(7);
            
        }
    }
}
