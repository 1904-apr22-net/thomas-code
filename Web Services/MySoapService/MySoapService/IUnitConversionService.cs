using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MySoapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUnitConversionService" in both code and config file together.
    [ServiceContract] // means, this interface will be a service having some operations.
    public interface IUnitConversionService
    {
        [OperationContract] // means, this method will be accessible as a SOAP operation
        //[OperationBehavior] // can configure transaction semantics, etc
        double FeetToMeters(double feet);

        [OperationContract]
        Temperature ConvertTemperature(Temperature temperature);
    }
}
