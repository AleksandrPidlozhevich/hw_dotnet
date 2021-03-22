using System.Collections;

namespace HW_11
{

    interface ReposMoto
    {
        void GetMotorcycles();
        void GetMotorcycleId(int id);
        void CreateMotorcycle(Motorcycle moto);
        void UpdateMotorcycle(int id, string name, string model, int year, int odometer);
        void DelMotorcycle(int id);
    }
}