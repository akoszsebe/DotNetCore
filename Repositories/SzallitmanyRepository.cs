using System.Collections.Generic;
using DotNetCore.Models;

namespace DotNetCore.Repositories
{
    public class SzallitmanyRepository : ISzallitmanyRepository
    {
        private List<Szallitmany> _szallitmanyList;

        public SzallitmanyRepository()
        {
            InitializeData();
        }

        public IEnumerable<Szallitmany> All
        {
            get { return _szallitmanyList; }
        }

        public bool DoesItemExist(int id)
        {
            return _szallitmanyList.Exists(item => item.id == id);
        }

        public Szallitmany Find(int id)
        {
            return _szallitmanyList.Find(item => item.id == id);
        }

        public void Insert(Szallitmany item)
        {
            _szallitmanyList.Add(item);
        }

        public void Update(Szallitmany item)
        {
            var tmpItem = this.Find(item.id);
            var index = _szallitmanyList.IndexOf(tmpItem);
            _szallitmanyList.RemoveAt(index);
            _szallitmanyList.Insert(index, item);
        }

        public void Delete(int id)
        {
            _szallitmanyList.Remove(this.Find(id));
        }

        private void InitializeData()
        {
            _szallitmanyList = new List<Szallitmany>();

            var item1 = new Szallitmany
            {
                id = 1,
                name = "Csiki Sor",
                date = System.DateTime.Now
            };

            var item2 = new Szallitmany
            {
                id = 2,
                name = "Csiki Buza",
                date = System.DateTime.Now
            };

            var item3 = new Szallitmany
            {
                id = 3,
                name = "Csiki Kukorica",
                date =  System.DateTime.Now
            };

            _szallitmanyList.Add(item1);
            _szallitmanyList.Add(item2);
            _szallitmanyList.Add(item3);
        }
    }
}