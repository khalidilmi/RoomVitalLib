using RoomVitalLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomVitalLib.Interface
{
    public interface ILokaleRepository
    {
        public Lokale Create(Lokale lokale);
        public List<Lokale> GetAll();
        public Lokale GetById(int id);
        public Lokale Update(int id, Lokale lokale);
        public Lokale Delete(int id);
    }
}
