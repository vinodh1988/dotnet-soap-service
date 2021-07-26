using System.ServiceModel;

namespace Model{
    [ServiceContract]
    interface ISoapService{

          [OperationContract]
          public string greet(string name);

          [OperationContract]
          public string process(Person person);

    }
}