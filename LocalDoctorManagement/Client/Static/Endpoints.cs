using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalDoctorManagement.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string PatientsEndpoint = $"{Prefix}/patients";
    }
}
