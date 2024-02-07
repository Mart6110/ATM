using ATM.Controllers;
using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ATM.Tests
{
    public class BankControllerTests
    {
        [Fact]
        public void WithdrawMoney_WithValidPINAndSufficientFunds_ReturnsTrue()
        {
            // Arrange
            var account = new Account(1000);
            var pinValidator = new PINValidator();
            var bankController = new BankController(account, pinValidator);

            // Act
            bool result = bankController.WithdrawMoney("1234", 500);

            // Assert
            Assert.True(result);
            Assert.Equal(500, account.Balance);
        }

        [Fact]
        public void WithdrawMoney_WithInvalidPIN_ReturnsFalse()
        {
            // Arrange
            var account = new Account(1000);
            var pinValidator = new PINValidator();
            var bankController = new BankController(account, pinValidator);

            // Act
            bool result = bankController.WithdrawMoney("0000", 500);

            // Assert
            Assert.False(result);
            Assert.Equal(1000, account.Balance);
        }

        [Fact]
        public void WithdrawMoney_WithInsufficientFunds_ReturnsFalse()
        {
            // Arrange
            var account = new Account(1000);
            var pinValidator = new PINValidator();
            var bankController = new BankController(account, pinValidator);

            // Act
            bool result = bankController.WithdrawMoney("1234", 1500);

            // Assert
            Assert.False(result);
            Assert.Equal(1000, account.Balance);
        }
    }
}
