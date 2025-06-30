using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunittest
{
    public class StringUtils
    {
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            var reversed = new string(input.Reverse().ToArray());
            return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }
    }
    public class BankAccount
    {
        public string Owner { get; }
        public decimal Balance { get; private set; }

        public BankAccount(string owner, decimal initialBalance)
        {
            Owner = owner;
            Balance = initialBalance;
        }
        public void Deposit(decimal amount) => Balance += amount;

        public void Withdraw(decimal amount)
        {
            if (amount > Balance) throw new InvalidOperationException("Insufficient funds");
            Balance -= amount;
        }
    }
    public class DateUtils
    {
        public bool IsWeekend(DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek ==
            DayOfWeek.Sunday;
        }
    }
    public class MathUtils
    {
        public bool IsEven(int number) => number % 2 == 0;
    }

    public class SessionManager
    {
        public bool IsActive { get; private set; }
        [SetUp]
        public void Start() => IsActive = true;
        [TearDown]
        public void End() => IsActive = false;
    }
    public class Validator
    {
        public void CheckAge(int age)
        {
            if (age < 18)
                throw new ArgumentException("Age must be 18 or older");
        }
    }
}
