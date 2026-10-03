using System;

namespace Pattern14_HideDelegate._3_Real
{
    public class BankBranch
    {
        public string BranchName { get; set; } = "Chi nhánh Quận 1";
    }

    public class BankAccount
    {
        private BankBranch _branch = new BankBranch();

        // Che giấu class BankBranch đối với người gọi bên ngoài
        public string GetBranchName() => _branch.BranchName;
    }

    internal class RealExample
    {
        public void Run()
        {
            BankAccount account = new BankAccount();
            Console.WriteLine($"Tài khoản mở tại: {account.GetBranchName()}");
        }
    }
}