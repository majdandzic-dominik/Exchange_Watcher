using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExchangeWatcher.UnitTests
{
    [TestClass]
    public class SignUpFormTests
    {
        [TestMethod]
        public void IsValidEmail_EmailIsValid_ReturnsTrue()
        {
            var form = new SignUpForm();
            var email = "user@mail.com";

            bool result = form.IsValidEmail(email);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValidEmail_EmailIsNotValid_ReturnsFalse()
        {
            var form = new SignUpForm();
            var email1 = "";
            var email2 = "usermailcom";
            var email3 = "usermail.com";
            var email4 = "user@mailcom";
            var email5 = "@mail.com";

            bool result1 = form.IsValidEmail(email1);
            bool result2 = form.IsValidEmail(email2);
            bool result3 = form.IsValidEmail(email3);
            bool result4 = form.IsValidEmail(email4);
            bool result5 = form.IsValidEmail(email5);

            Assert.IsFalse(result1);
            Assert.IsFalse(result2);
            Assert.IsFalse(result3);
            Assert.IsFalse(result4);
            Assert.IsFalse(result5);
        }

        [TestMethod]
        public void IsValidUserNameLength_UserNameLengthIsEqualOrMoreThan4_ReturnsTrue()
        {
            var form = new SignUpForm();
            var usernameEqual4 = "user";
            var usernameMoreThan4 = "username";

            bool result1 = form.IsValidUserNameLength(usernameEqual4);
            bool result2 = form.IsValidUserNameLength(usernameMoreThan4);

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
        }

        [TestMethod]
        public void IsValidUserNameLength_UserNameLengthIsLessThan4_ReturnsFalse()
        {
            var form = new SignUpForm();
            var usernameLessThan4 = "use";

            bool result = form.IsValidUserNameLength(usernameLessThan4);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValidPasswordLength_PasswordLengthIsEqualOrMoreThan8_ReturnsTrue()
        {
            var form = new SignUpForm();
            var passwordEqual8 = "password";
            var passwordMoreThan8 = "longpassword";

            bool result1 = form.IsValidPasswordLength(passwordEqual8);
            bool result2 = form.IsValidPasswordLength(passwordMoreThan8);

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
        }

        [TestMethod]
        public void IsValidPasswordLength_PasswordLengthIsLessThan8_ReturnsFalse()
        {
            var form = new SignUpForm();
            var passwordLessThan8 = "pass";

            bool result = form.IsValidPasswordLength(passwordLessThan8);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValidPasswordFormat_PasswordFormatIsValid_ReturnsTrue()
        {
            var form = new SignUpForm();
            var password = "password";

            bool result = form.IsValidPasswordFormat(password);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValidPasswordFormat_PasswordFormatIsNotValid_ReturnsFalse()
        {
            var form = new SignUpForm();
            var password = "pass has spaces";

            bool result = form.IsValidPasswordFormat(password);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DoesPasswordMatch_PasswordsMatch_ReturnsTrue()
        {
            var form = new SignUpForm();
            var password1 = "samepassword";
            var password2 = "samepassword";

            bool result = form.DoesPasswordMatch(password1, password2);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void DoesPasswordMatch_PasswordsDoNotMatch_ReturnsFalse()
        {
            var form = new SignUpForm();
            var password1 = "password";
            var password2 = "differentpassword";

            bool result = form.DoesPasswordMatch(password1, password2);

            Assert.IsFalse(result);
        }
    }
}
