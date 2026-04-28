using Farmers_Market_API.Exceptions;
using Farmers_Market_API.Interfaces;
using Farmers_Market_API.Models;

namespace Farmers_Market_API.Repositories
{
    public class FarmerRepository: IRepository<Farmer>
    {
        private List<Farmer> farmers = new List<Farmer> {
            new (1, "Kobus", "kobus@example.com", "123-456-7890", "Location A", "Province A", 4.5, true),
            new (2, "Tyrique", "tyrique@example.com", "098-765-4321", "Location B", "Province B", 4.0, true),
            new (3, "Zandre", "zandre@example.com", "555-555-5555", "Location C", "Province C", 4.8, true),
            new (4, "Aisha", "aisha@example.com", "111-222-3333", "Location D", "Province D", 4.2, true),
            new (5, "Bongani", "bongani@example.com", "222-333-4444", "Location E", "Province E", 3.9, false),
            new (6, "Carmen", "carmen@example.com", "333-444-5555", "Location F", "Province F", 4.7, true),
            new (7, "Daniel", "daniel@example.com", "444-555-6666", "Location G", "Province G", 4.1, true),
            new (8, "Elena", "elena@example.com", "555-666-7777", "Location H", "Province H", 3.8, false),
            new (9, "Farid", "farid@example.com", "666-777-8888", "Location I", "Province I", 4.6, true),
            new (10, "Grace", "grace@example.com", "777-888-9999", "Location J", "Province J", 4.3, true),
            new (11, "Hendrik", "hendrik@example.com", "888-999-0000", "Location K", "Province K", 3.7, false),
            new (12, "Imani", "imani@example.com", "101-202-3030", "Location L", "Province L", 4.4, true),
            new (13, "Jabulani", "jabulani@example.com", "121-212-1212", "Location M", "Province M", 4.0, true),
            new (14, "Keisha", "keisha@example.com", "131-313-1313", "Location N", "Province N", 3.6, false),
            new (15, "Lungile", "lungile@example.com", "141-414-1414", "Location O", "Province O", 4.9, true),
            new (16, "Mpho", "mpho@example.com", "151-515-1515", "Location P", "Province P", 4.2, true),
            new (17, "Nokuthula", "nokuthula@example.com", "161-616-1616", "Location Q", "Province Q", 3.5, false),
            new (18, "Omar", "omar@example.com", "171-717-1717", "Location R", "Province R", 4.1, true),
            new (19, "Palesa", "palesa@example.com", "181-818-1818", "Location S", "Province S", 4.0, true),
            new (20, "Quentin", "quentin@example.com", "191-919-1919", "Location T", "Province T", 3.9, false)
            };

        public List<Farmer> GetAll()
        {
            return farmers;
        }

        public Farmer Add(Farmer farmer)
        {
            farmers.Add(farmer);
            return farmer;
        }

        public Farmer GetById(int Id)
        {
            var farmer = farmers.Find(farmer => farmer.FarmerId == Id);
            return farmer ?? throw new FarmerNotFoundException(Id);
        }

        public Farmer GetByEmail(string email)
        {
            var farmer = farmers.Find(farmer => farmer.Email == email);
            return farmer ?? throw new FarmerNotFoundException(email);
        }

        public Farmer Update(Farmer updatedFarmer)
        {
            var farmer = farmers.Find(f => f.FarmerId == updatedFarmer.FarmerId);
            if (farmer != null)
            {
                int index = farmers.IndexOf(farmer);
                farmers[index] = updatedFarmer;
                return updatedFarmer;
            }
            else
            {
                throw new FarmerNotFoundException(updatedFarmer.FarmerId);
            }
        }

        public Farmer Delete(int Id)
        {
            var farmer = farmers.Find(farmer => farmer.FarmerId == Id);
            if (farmer != null)
            {
                farmers.Remove(farmer);
                return farmer;
            }
            else
            {
                throw new FarmerNotFoundException(Id);
            }

        }

        public Farmer Delete(Farmer farmerToDelete)
        {
            var farmer = farmers.Find(farmer => farmer.FarmerId == farmerToDelete.FarmerId);
            if (farmer != null)
            {
                farmers.Remove(farmer);
                return farmer;
            }
            else
            {
                throw new FarmerNotFoundException("");
            }

        }
    }


}
