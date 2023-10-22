using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork06.Bankomat
{
    /// <summary>
    /// decimal = https://translated.turbopages.org/proxy_u/en-ru.ru.0f37fcae-6534e8ce-a23834b6-74722d776562/https/www.geeksforgeeks.org/difference-between-decimal-float-and-double-in-net/
    /// </summary>
    public class Banc
    {
        private List<Account> accounts;
        private int accountNumberSeed = 1000;

        public Banc()
        {
            accounts = new List<Account>();
        }

        //public Account OpenAccount(Client client, decimal initialDeposit)
        //{
        //    int accountNumber = GenerateAccountNumber();
        //    Account account = new Account(client, accountNumber, initialDeposit);
        //    accounts.Add(account);
        //    return account;
        //}

        private int GenerateAccountNumber()
        {
            return accountNumberSeed++;
        }
    }
}
