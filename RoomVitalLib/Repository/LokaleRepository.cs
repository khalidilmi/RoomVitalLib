using RoomVitalLib.Interface;
using RoomVitalLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomVitalLib.Repository
{
    public class LokaleRepository : ILokaleRepository
    {
        private readonly List<Lokale> _lokaleList = new List<Lokale>();
        public Lokale Create(Lokale lokale)
        {
            _lokaleList.Add(lokale);
            return lokale;
        }

        public Lokale Delete(int id)
        {
            Lokale delete = GetById(id);
            _lokaleList.Remove(delete);
            return delete;
        }

        public Lokale GetById(int id)
        {
            foreach(Lokale lokale in  _lokaleList)
            {
                if(lokale.Id == id)
                {
                    return lokale;
                }
            }
            return null;
        }

        public List<Lokale> GetAll()
        {
            return new List<Lokale>(_lokaleList);
        }

        public Lokale Update(int id, Lokale lokale)
        {
            foreach(Lokale aLokale in _lokaleList)
            {
                if(aLokale.Id == id)
                {
                    aLokale.Id = lokale.Id;
                    aLokale.Navn = lokale.Navn;
                    aLokale.StørrelseType = lokale.StørrelseType;
                    return aLokale;
                }
            }
            return null;
        }
    }
}
