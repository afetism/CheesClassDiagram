using CheesClassDiagram.Enum;


namespace CheesClassDiagram.Models;


    public class Account
    {
        public int Id { get; set; }
        public string Password { get; set; } = string.Empty;
        AccountStatus Status { get; set; }
        public bool ResetPassword()
        {
           throw new NotImplementedException();
        }

}

