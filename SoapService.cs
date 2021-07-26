using Model;

namespace soapservice{
     class SoapService:ISoapService
     {

         public string greet(string name){
             return "Hello!!! "+name;
         }


          public string process(Person person){
              return "Processed "+person.Sno+"  Name "+person.Name+" City "+person.City;
          }
     }
}