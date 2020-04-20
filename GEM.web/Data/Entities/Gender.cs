using System.Collections.Generic;

namespace GEM.web.Data.Entities
{
    public class Gender : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Client> Clients { get; set;}
    }
}
