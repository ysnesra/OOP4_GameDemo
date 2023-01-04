using OOP4_GameDemo.Abstract;
using OOP4_GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MernisServiceReference1;
using static MernisServiceReference1.KPSPublicSoapClient;

namespace OOP4_GameDemo.Adapters
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);

            var result = client.TCKimlikNoDogrulaAsync(
                    Convert.ToInt64(person.NationalityId),
                    person.FirstName.ToUpper(),
                    person.LastName.ToUpper(),
                    person.DateOfBirth.Year
             );

            bool sonuc = result.Result.Body.TCKimlikNoDogrulaResult;
            return sonuc;
        }
    }
}
