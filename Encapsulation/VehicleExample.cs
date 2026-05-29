using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    abstract class Vehicle
    {
        string VehicleName;
        public Vehicle(string VehicleName)
        {
            this.VehicleName = VehicleName;
            Console.WriteLine("Vehicle is Calling");
        }
        public void ShowVehicleDetails()
        {
            Console.WriteLine($"Vehicle name: {VehicleName}");
        }
        public abstract void VehicleType();
    }
    abstract class VehicleModel : Vehicle
    {
        string ModelName;
        public VehicleModel(string ModelName,string VehicleName):base(VehicleName)
        {
            this.ModelName = ModelName;
            Console.WriteLine($"Vehicle Model is Calling ");
        }
        public void DisplayModel()
        {
            Console.WriteLine($"Model Name: {ModelName}");
        }
        public abstract void ModelType();
    }
    class VehicleData:VehicleModel
    {
        int Vehiclenum;
        public VehicleData(int Vehiclenum,string VehicleName,string ModelName):base(ModelName,VehicleName)
        {
            this.Vehiclenum = Vehiclenum;
            Console.WriteLine("Vehicle Data is Calling");
        }
        public override void ModelType()
        {
            Console.WriteLine("Electric");
        }
        public override void VehicleType()
        {
            Console.WriteLine("Cars");
        }
    }
    internal class VehicleExample
    {
        static void Main(string[] args)
        {
            //VehicleData v = new VehicleData(9999, "Audi", "A8");
            //v.ShowVehicleDetails();
            //v.DisplayModel();
            //v.VehicleType();
            //v.ModelType();

            Vehicle m = new VehicleData(8888, "ABC", "A1");
           // m.ModelType();  its not exicuted because Vehicle does not have modeltype
            m.ShowVehicleDetails();
            m.VehicleType();
            // m.DisplayModel();   its not exicuted because Vehicle does not have vehicletype
        }
    }
}
