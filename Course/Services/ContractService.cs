using System;
using System.Collections.Generic;
using Course.Entities;

namespace Course.Services
{
    class ContractService
    {
        public List<Contract> contract { get; set; } = new List<Contract>();
        public int Months { get; set; }

        public ContractService(int months)
        {
            Months = months;
        }
        public void ProcessContract(Contract contract,int months)
        {
            for(int i = 1; i <= months; i++)
            {

            }

        }

    }
}
