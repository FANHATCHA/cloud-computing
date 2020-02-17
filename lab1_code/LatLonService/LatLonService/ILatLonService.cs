// original code by Bret Stateham - MS "Developing Windows Azure and Web Services Jump Start"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LatLonService
{
    [ServiceContract(Namespace = "http://gcu.ac.uk/cpd/2017/06/LatLon")]
    public interface ILatLonService
    {
        [OperationContract]
        double RadiansBetweenTwoPoints(double Latitude1, double Longitude1, double Latitude2, double Longitude2);

        [OperationContract]
        double NauticalMilesBetweenTwoPoints(double Latitude1, double Longitude1, double Latitude2, double Longitude2);

        [OperationContract]
        double KilometersBetweenTwoPoints(double Latitude1, double Longitude1, double Latitude2, double Longitude2);

        [OperationContract]
        double MilesBetweenTwoPoints(double Latitude1, double Longitude1, double Latitude2, double Longitude2);
    }
}
