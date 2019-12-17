using System;
namespace CourseWithdrawAccounts.Entities.Exceptions {
    class DomainException : ApplicationException {
        public DomainException(string message) : base(message) {
        }
    }
}
