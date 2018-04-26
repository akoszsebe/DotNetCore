using System.Collections.Generic;
using DotNetCore.Models;

namespace DotNetCore.Repositories
{
    public interface ISzallitmanyRepository
    {
        bool DoesItemExist(int id);
        IEnumerable<Szallitmany> All { get; }
        Szallitmany Find(int id);
        void Insert(Szallitmany item);
        void Update(Szallitmany item);
        void Delete(int id);
    }
}