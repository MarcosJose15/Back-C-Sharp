using System;
using System.Collections.Generic;
using System.Linq;
using SistemaPedidos.Entities.Enums;
using SistemaPedidos.Entities;

namespace SistemaPedidos.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client() { }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
