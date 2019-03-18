using System.Linq;
using ClinicNetCore.Models;

namespace ClinicNetCore
{
    public static class SampleData
    {
        public static void Initialize(ClinicContext context)
        {
            if (!context.Patients.Any())
            {
                context.Patients.AddRange(
                    new Patient
                    {
                        FirstName = "Dauren",
                        LastName = "Dossymbek",
                        Address = "18/1 Syganak str. Apt. 376, Astana, Kazakhstan",
                    },
                    new Patient
                    {
                        FirstName = "Frank",
                        LastName = "Collins",
                        Address = "401 Ringgold Rd. Apt. 400, Brownsville, Texas",
                    },
                    new Patient
                    {
                        FirstName = "Anton",
                        LastName = "Gribovskiy",
                        Address = "34 University blvd Apt. 78, Edinburg, Texas",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
