namespace GEM.Web.Data.Entities
{
    using System;
    public class Client : IEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public string FullName => $"{LastName} {FirstName}";
        public Gender Gender { get; set; }
    }
}
