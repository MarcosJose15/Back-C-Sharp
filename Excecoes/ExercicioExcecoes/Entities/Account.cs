using System;
using ExercicioExcecoes.Entities.Exceptions;

namespace ExercicioExcecoes.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdraw)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdraw;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new DomainException("Error: O valor que voce deseja depositar é invalido, favor deposite um valor maior que 0.");
            }

            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Error: Voce nao possui saldo sufiente em conta para efetuar este valor de saque.");
            }

            if (amount > WithdrawLimit)
            {
                throw new DomainException("Error: Voce nao possui limite de saque suficiente.");
            }

            Balance -= amount;
        }
    }
}