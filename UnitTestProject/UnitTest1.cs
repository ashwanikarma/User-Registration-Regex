using System.ComponentModel.DataAnnotations;
using UserRegistrationRegex;

namespace UnitTestProject
{
   
        [TestClass]
        public class UnitTest1
        {
        //declaration of variable regexValidation of RegexValidation class
            UserRegistration regexValidation;

            [TestInitialize]
            public void InitValidationObj()
            {
                //Arrange -- initialise the object to compare/test
                regexValidation = new UserRegistration();
            }

            [TestMethod]
            public void FirstNameTest_ShouldReturnTrue()
            {
                //Arrange -- declare a firstName string variable 
                string firstName = "Ashwani";

                //Act -- basic logical construct for testing
                var FirstName = regexValidation.ValidateFirstName(firstName);

                //Assert --  test comparison with the standard values
                Assert.IsTrue(FirstName);

            }
            //Method to test lastname function in user registration project
            [TestMethod]
            public void LastNameTest_ShouldReturnTrue()
            {
                //Arrange -- declare a lastName string variable 
                string lastName = "Karma";

                //Act
                var LastName = regexValidation.ValidateLastName(lastName);

                //Assert
                Assert.IsTrue(LastName);

            }
            //Method to test Email function in user registration project
            [TestMethod]
            public void EmailTest_ShouldReturnTrue()
            {
                //Arrange -- declare an email string variable 
                string email = "ashwanikarma9@gmail.com";

                //Act
                var Email = regexValidation.ValidateEmail(email);

                //Assert
                Assert.IsTrue(Email);

            }
            //ValidatePhone
            [TestMethod]
            public void PhoneNumberTest_ShouldReturnTrue()
            {
                //Arrange -- declare a number string variable 
                string number = "91 9131715292";

                //Act
                var PhoneNumber = regexValidation.ValidateMobileNumber(number);

                //Assert
                Assert.IsTrue(PhoneNumber);

            }
            //Validate Password
            [TestMethod]
            public void PasswordTest_ShouldReturnTrue()
            {
                //Arrange -- declare a passW string variable 
                string passW = "Ashwani#12";

                //Act
                var password = regexValidation.ValidatePassword(passW);

                //Assert
                Assert.IsTrue(password);
            }

            [TestMethod]
            [DataRow("abc@yahoo.com", "abc@yahoo.com")]
            [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
            [DataRow("abc-100@abc.net", "abc-100@abc.net")]
            [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
            [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
            [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
            [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
            public void Email(string a, string expected)
            {
                UserRegistration validate = new UserRegistration();

                string actual = validate.Email(a);

                Assert.AreEqual(expected, actual);
            }
        }
}
